using UnityEngine;
using Mirror;
using Invector.vCharacterController;
[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(NetworkTransform))]
public class PlayerNetwork : NetworkBehaviour
{
    public GameObject PlayerCamera;
    public Animator anim;
    public int currentHorizontal = 0;
    public int currentVertical = 0;

    public bool cachejump = false;
    public bool cacherunning = false;
    public bool cachem_IsGrounded = false;
    float cachemoving = 0f;
    [SyncVar]
    public string nickname;
    void OnValidate()
    {
        
    }

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        gameObject.tag = "Player";
    }

    void OnDisable()
    {
        if (isLocalPlayer)
        {
           
        }
    }

    [Command]
    public void CmdGrounded(bool isgrounded)
    {
        this.anim.SetBool("IsGrounded", isgrounded);
        RpcGround(isgrounded);
    }

    [ClientRpc]
    void RpcGround(bool isgrounded)
    {
        if (isLocalPlayer)
        {
            return;
        }
        this.anim.SetBool("IsGrounded", isgrounded);
    }

    [Command]
    public void CmdJump(bool jumpbool)
    {
        if (jumpbool == true)
            anim.CrossFadeInFixedTime("Jump", 0.1f);
        else
            anim.CrossFadeInFixedTime("JumpMove", .2f);
        RpcUpdateJump(jumpbool);
    }
    [ClientRpc]
    void RpcUpdateJump(bool jumpbool)
    {
        if (isLocalPlayer)
        {
            return;
        }
        if (jumpbool == true)
            anim.CrossFadeInFixedTime("Jump", 0.1f);
        else
            anim.CrossFadeInFixedTime("JumpMove", .2f);
    }

    [Command]
    public void CmdRun(bool runbool)
    {
        // Do your own shot validation here because this runs on the server
        this.anim.SetBool("IsSprinting", runbool);
        RpcRun(runbool);
    }
    [ClientRpc]
    void RpcRun(bool runbool)
    {
        if (isLocalPlayer)
        {
            return;
        }
        this.anim.SetBool("IsSprinting", runbool);
    }

    [Command]
    public void CmdMoving(int H, int V, float movingbool)
    {
        // Do your own shot validation here because this runs on the server
        this.currentHorizontal = H;
        this.currentVertical = V;
        this.anim.SetFloat("InputHorizontal", H);
        this.anim.SetFloat("InputVertical", V);
        this.anim.SetFloat("InputMagnitude", movingbool);

        RpcUpdateAnim(H, V, movingbool);
    }
    [ClientRpc]
    void RpcUpdateAnim(int H, int V, float movingbool)
    {
        if (isLocalPlayer)
        {
            return;
        }
        //Debug.Log("Animation update  H :" + H.ToString() + " V : " + V.ToString() + " Bool moving = " + movingbool.ToString());
        this.anim.SetFloat("InputHorizontal", H);
        this.anim.SetFloat("InputVertical", V);
        this.anim.SetFloat("InputMagnitude", movingbool);
    }
    void Update()
    {
        if (!isLocalPlayer)
        {
            Destroy(PlayerCamera);
            Destroy(gameObject.GetComponent<vThirdPersonInput>());
            Destroy(gameObject.GetComponent<vThirdPersonController>());
        }
        return;
       
    }

    void FixedUpdate()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

       
        if (GetComponent<vThirdPersonController>().isGrounded != cachem_IsGrounded)
        {
            CmdGrounded(GetComponent<vThirdPersonController>().isGrounded);
            cachem_IsGrounded = GetComponent<vThirdPersonController>().isGrounded;
        }
        if (GetComponent<vThirdPersonController>().isJumping != cachejump)
        {
            CmdJump(GetComponent<vThirdPersonController>().isJumping);
            //anim.SetBool("Jump", GetComponent<vThirdPersonController>().isJumping);
            cachejump = GetComponent<vThirdPersonController>().isJumping;
        }
        if (GetComponent<vThirdPersonController>().isSprinting != cacherunning)
        {
            CmdRun(GetComponent<vThirdPersonController>().isSprinting);
            cacherunning = GetComponent<vThirdPersonController>().isSprinting;
        }

        if ((int)anim.GetFloat("InputHorizontal") != currentHorizontal)
        {
            CmdMoving((int)anim.GetFloat("InputHorizontal"), (int)anim.GetFloat("InputVertical"), GetComponent<vThirdPersonController>().inputMagnitude);
            currentHorizontal = (int)anim.GetFloat("InputHorizontal");
        }
        if ((int)anim.GetFloat("InputVertical") != currentVertical)
        {
            CmdMoving((int)anim.GetFloat("InputHorizontal"), (int)anim.GetFloat("InputVertical"), GetComponent<vThirdPersonController>().inputMagnitude);
            currentVertical = (int)anim.GetFloat("InputVertical");
        }

        if (GetComponent<vThirdPersonController>().inputMagnitude != cachemoving)
        {
            CmdMoving((int)anim.GetFloat("InputHorizontal"), (int)anim.GetFloat("InputVertical"), GetComponent<vThirdPersonController>().inputMagnitude);
            cachemoving = GetComponent<vThirdPersonController>().inputMagnitude;
        }
    }
}