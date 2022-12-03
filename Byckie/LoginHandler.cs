using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror.Authenticators;
using Mirror;
using UnityEngine.UI;

public class LoginHandler : MonoBehaviour
{
    public InputField UsernameLogin;
    public InputField PasswordLogin;
    public InputField Username;
    public InputField Password;
    public InputField Email;
    public Text ResponseTxt;
    private Mirror.NetworkManager nm;
    [SerializeField]
    private BasicAuthenticatorWom bawom;
    // Start is called before the first frame update
    public IEnumerator SigninRoutine(string u, string p)
    {
        nm = FindObjectOfType<Mirror.NetworkManager>();
        while (nm == null)
        {
            yield return new WaitForSeconds(0.1f);
        }
        bawom.SignupMode = 0;
        bawom.username = u;
        bawom.password = p;
        nm.StartClient();
        /*MessageSignin message = new MessageSignin
        {
            Username = Username.text,
            Password = Password.text
        };
        NetworkClient.Send(message);*/
    }
    public void Signin()
    {
        if (UsernameLogin.text == string.Empty)
        {
            ResponseTxt.text = "Username cant be empty";
            if (PasswordLogin.text == string.Empty)
            {
                ResponseTxt.text += ", Password cant be empty";
                return;
            }
            return;
        }
        else
        {
            if (PasswordLogin.text == string.Empty)
            {
                ResponseTxt.text += "Password cant be empty";
                return;
            }
            else
            {
                StartCoroutine(SigninRoutine(UsernameLogin.text, PasswordLogin.text));
            }
        }

    }
    public IEnumerator SignupRoutine(string u, string p, string e)
    {
        nm = FindObjectOfType<Mirror.NetworkManager>();
        while (nm == null)
        {
            yield return new WaitForSeconds(0.1f);
        }
        nm.gameObject.GetComponent<BasicAuthenticatorWom>().SignupMode = 1;
        nm.gameObject.GetComponent<BasicAuthenticatorWom>().username = u;
        nm.gameObject.GetComponent<BasicAuthenticatorWom>().password = p;
        nm.gameObject.GetComponent<BasicAuthenticatorWom>().email = e;
        nm.StartClient();
        /*MessageSignin message = new MessageSignin
        {
            Username = Username.text,
            Password = Password.text
        };
        NetworkClient.Send(message);*/
    }
   
    public void Signup()
    {

        if (Username.text == string.Empty)
        {
            ResponseTxt.text = "Username cant be empty";
            if (Password.text == string.Empty)
            {
                ResponseTxt.text += ", Password cant be empty";
                return;
            }
            return;
        }
        else
        {
            if (Password.text == string.Empty)
            {
                ResponseTxt.text += "Password cant be empty";
                return;
            }
            else
            {
                if (Email.text == string.Empty)
                {
                    ResponseTxt.text += "E-mail cant be empty";
                    return;
                }
                else
                {
                    StartCoroutine(SignupRoutine(Username.text, Password.text, Email.text));
                }
            }
        }

    }
}
