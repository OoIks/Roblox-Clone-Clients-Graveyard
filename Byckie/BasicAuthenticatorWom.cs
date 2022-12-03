using UnityEngine;
using System.Collections;
using Mirror;
using Mirror.Authenticators;
using JsonHelperLibrary;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Networking;
[AddComponentMenu("Network/Authenticators/BasicAuthenticator")]
public class BasicAuthenticatorWom : NetworkAuthenticator
{
    [Header("Custom Properties")]

    // set these in the inspector
    public string username;
    public string password;
    public string email;
    public string localcharacters;
    public int SignupMode;
    public Text textresponse;
    public GameObject CanvasObj;
    [System.Serializable]
    public class AuthenticateAnswear
    {
        public string a = "";
        public string b = "";
    }
    public class AuthRequestMessage : Mirror.MessageBase
    {
        // use whatever credentials make sense for your game
        // for example, you might want to pass the accessToken if using oauth
        public string authUsername;
        public string authPassword;
    }
    public class AuthResponseMessage : Mirror.MessageBase
    {
        public byte code;
        public string message;
        public string info;
    }
    public class RegisterRequestMessage : Mirror.MessageBase
    {
        public string _username;
        public string _password;
        public string _email;
    }
    public class RegisterResponseMessage : Mirror.MessageBase
    {
        public byte code;
        public string answear;
    }
    
    IEnumerator HandleUserRegistration(Mirror.NetworkConnection conn, RegisterRequestMessage msg)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", msg._username);
        form.AddField("password", msg._password);
        form.AddField("email", msg._email);

        UnityWebRequest www = UnityWebRequest.Post("http://http://198.199.72.75/BryckieApp/serverregister.php", form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            RegisterResponseMessage newmessage = new RegisterResponseMessage
            {
                answear = www.error
            };
            conn.Send(newmessage);
            conn.isAuthenticated = false;

            // disconnect the client after 1 second so that response message gets delivered
            StartCoroutine(DelayedDisconnect(conn, 1));
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
            RegisterResponseMessage newmessage = new RegisterResponseMessage
            {
                answear = www.downloadHandler.text
            };
            conn.Send(newmessage);
            conn.isAuthenticated = false;

            // disconnect the client after 1 second so that response message gets delivered
            StartCoroutine(DelayedDisconnect(conn, 1));
        }
    }
    public void OnRegRequestMessage(Mirror.NetworkConnection conn, RegisterRequestMessage msg)
    {
        StartCoroutine(HandleUserRegistration(conn, msg));
    }
    
    IEnumerator OnAuthRequestMessageCO(Mirror.NetworkConnection conn, AuthRequestMessage msg)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", msg.authUsername);
        form.AddField("password", msg.authPassword);
        Debug.Log("sending sign in for : "+msg.authUsername);
        UnityWebRequest www = UnityWebRequest.Post("http://198.199.72.75:80/BryckieApp/serverlogin.php", form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            AuthResponseMessage authResponseMessage = new AuthResponseMessage
            {
                code = 1,
                message = "Error"
            };
            conn.Send(authResponseMessage);
            conn.isAuthenticated = false;

            // disconnect the client after 1 second so that response message gets delivered
            StartCoroutine(DelayedDisconnect(conn, 1));
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
            AuthenticateAnswear newAnswear = JsonUtility.FromJson<AuthenticateAnswear>(www.downloadHandler.text);
            if(newAnswear.a == "Invalid Credentials") {
                AuthResponseMessage authResponseMessage = new AuthResponseMessage
                {
                    code = 0,
                    message = "Invalid Credentials"
                };
                conn.Send(authResponseMessage);
                conn.isAuthenticated = false;

                // disconnect the client after 1 second so that response message gets delivered
                StartCoroutine(DelayedDisconnect(conn, 1));
            }
            if (newAnswear.a == "Success Login")
            {
                // create and send msg to client so it knows to proceed
                AuthResponseMessage authResponseMessage = new AuthResponseMessage
                {
                    code = 100,
                    message = "Success",
                    info = newAnswear.b
                };

                conn.Send(authResponseMessage);

                // Invoke the event to complete a successful authentication
                OnServerAuthenticated.Invoke(conn);
            }
        }
    }
    public void OnAuthRequestMessage(Mirror.NetworkConnection conn, AuthRequestMessage msg)
    {
        StartCoroutine(OnAuthRequestMessageCO(conn,msg));
    }
    public override void OnStartServer()
    {
        // register a handler for the authentication request we expect from client
        Mirror.NetworkServer.RegisterHandler<AuthRequestMessage>(OnAuthRequestMessage, false);
        Mirror.NetworkServer.RegisterHandler<RegisterRequestMessage>(OnRegRequestMessage, false);
    }
    
    public override void OnStartClient()
    {
        // register a handler for the authentication response we expect from server
        Mirror.NetworkClient.RegisterHandler<AuthResponseMessage>(OnAuthResponseMessage, false);
        Mirror.NetworkClient.RegisterHandler<RegisterResponseMessage>(OnRResponseMessage, false);
    }
    public void OnRResponseMessage(Mirror.NetworkConnection conn, RegisterResponseMessage msg)
    {
        Debug.LogFormat("Registration Response: {0}", msg.answear);
        textresponse.text = msg.answear;
        conn.isAuthenticated = false;

        // disconnect the client
        conn.Disconnect();
    }
    public override void OnServerAuthenticate(Mirror.NetworkConnection conn)
    {
        // do nothing...wait for AuthRequestMessage from client
    }

    public override void OnClientAuthenticate(Mirror.NetworkConnection conn)
    {
        if (SignupMode == 0)
        {
            AuthRequestMessage authRequestMessage = new AuthRequestMessage
            {
                authUsername = username,
                authPassword = password
            };
            Debug.LogFormat("Sending message:Uame {0} Password {1}", username,password);
            Mirror.NetworkClient.Send(authRequestMessage);
        }
        if (SignupMode == 1)
        {
            RegisterRequestMessage regRequestMessage = new RegisterRequestMessage
            {
                _username = username,
                _password = password,
                _email = email
            };

            Mirror.NetworkClient.Send(regRequestMessage);
        }
    }

    public IEnumerator DelayedDisconnect(Mirror.NetworkConnection conn, float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        conn.Disconnect();
    }
    IEnumerator CheckPlayerSpawned()
    {
        Mirror.NetworkIdentity Ni = Mirror.NetworkClient.connection.identity;
        while (Ni == null)
        {
            Ni = Mirror.NetworkClient.connection.identity;
            yield return new WaitForSeconds(0.1f);
        }
        if (Ni.gameObject != null)
        {
            Ni.gameObject.GetComponent<PlayerNetwork>().PlayerCamera.SetActive(true);
            Ni.gameObject.GetComponent<PlayerNetwork>().PlayerCamera.transform.SetParent(null);
        }
    }
    public void OnAuthResponseMessage(Mirror.NetworkConnection conn, AuthResponseMessage msg)
    {
        if (msg.code == 100)
        {
            Debug.LogFormat("Authentication Response: {0}", msg.message);
            textresponse.text = msg.message;
            localcharacters = msg.info;
            CanvasObj.SetActive(false);
            StartCoroutine(CheckPlayerSpawned());
            // Invoke the event to complete a successful authentication
            OnClientAuthenticated.Invoke(conn);
        }
        else
        {
            Debug.LogErrorFormat("Authentication Response: {0}", msg.message);
            textresponse.text = msg.message;
            // Set this on the client for local reference
            conn.isAuthenticated = false;

            // disconnect the client
            conn.Disconnect();
        }
    }
    public string CreateEmptyCharacterJSON()
    {
        InventoryClass inventory = new InventoryClass()
        {
            slotsitems = new int[9]
        };
        PlayerCharacterClass playerclass = new PlayerCharacterClass()
        {
            Nickname = "",
            Title = "",
            //races : 0 = african , 1 = asian, 2 = caucasian
            race = 0,
            //races : 0 = muscle , 1 = ninja , 2 = Gunslinger , 3 = Marksman
            classType = 0,
            //races : 0 = farmer , 1 = miner , 2 = chemist , 3 = druglord , 4 = armslord , 5 = jeweler , 6 = tailor , 7 = mechanic , 8 = medic , 9 =
            profession = 0,
            level = 1,
            currentexp = 0,
            health = 100,
            stamina = 100,
            item_head_slot = 0,
            item_neck_slot = 0,
            item_chest_slot = 0,
            item_legs_slot = 0,
            item_foots_slot = 0,
            item_leftbracer_slot = 0,
            item_rightbracer_slot = 0,
            item_gloves_slot = 0,
            Inventory = inventory
        };
        
        string contents = JsonUtility.ToJson(playerclass, true);
        return contents;
    }
}
