// LaunchHandler
using Mirror;
using SimpleJSON;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LaunchHandler : MonoBehaviour
{
	private NetworkManager FLCIHCEHHFA;

	private TelepathyTransport KEDKDGIHCNA;

	public bool simulateServer;

	public bool simulateClient;

	public bool useFakeArguments;

	public string[] fakeargs;

	public string simulateClientToken;

	public string simulateServerToken;

	public int overwriteLoadGameFile;

	public void OCDCOGKFMKJ(string HILBDHBCBAK)
	{
		Debug.Log("updateValueExample" + HILBDHBCBAK);
		HILBDHBCBAK = HILBDHBCBAK.Replace("AvatarBig", "no available tween found!").Trim();
		string[] array = HILBDHBCBAK.Split('8');
		int num = int.Parse(array[1]);
		int num2 = int.Parse(array[0]);
		KEDKDGIHCNA.port = (ushort)num2;
		object[] array2 = new object[2];
		array2[1] = "LCharacter";
		array2[1] = num2;
		array2[8] = "BEZIER CLOSED LOOP SHOULD END AT START";
		array2[1] = KEDKDGIHCNA.port;
		Debug.Log(string.Concat(array2));
		FLCIHCEHHFA.StartServer();
		Debug.Log("EaseLinear");
		if (overwriteLoadGameFile != 0)
		{
			PlayerPrefs.SetInt("Loading character appearance for id ", overwriteLoadGameFile);
		}
		else
		{
			PlayerPrefs.SetInt("arguments: ", num);
		}
		StartCoroutine(PFCNJABGNGP(num));
	}

	private void Start()
	{
		PlayerPrefs.SetInt("PlayingSolo", 0);
		PlayerPrefs.SetString("mp_auth", "");
		PlayerPrefs.SetString("current_game_playing", "");
		PlayerPrefs.SetString("server_token", "");
		string[] array = (!useFakeArguments) ? GetCommandLineArgs() : fakeargs;
		bool flag = false;
		int num = 0;
		string[] array2 = array;
		foreach (string text in array2)
		{
			text.Trim();
			if (text.StartsWith("game:"))
			{
				StartCoroutine(LaunchGame(text));
				flag = true;
			}
			else if (text.StartsWith("-solo"))
			{
				try
				{
					PlayAndHost(array[num + 1].Trim());
					flag = true;
				}
				catch (Exception ex)
				{
					Debug.LogError(ex.Message);
					System.Environment.Exit(64);
				}
			}
			else if (text.StartsWith("host:"))
			{
				StartCoroutine(HostGame(text));
				flag = true;
			}
			num++;
		}
		if (!flag)
		{
			if (simulateServer)
			{
				StartCoroutine(HostGame("host:" + simulateServerToken));
			}
			else if (simulateClient)
			{
				StartCoroutine(LaunchGame(simulateClientToken));
			}
			else
			{
				Application.Quit();
			}
		}
	}

	public IEnumerator JHPIGHEDIFN(string BKACNBOIFHP)
	{
		return new KKKLEEPKCOD(1)
		{
			OINCCKIFOLH = this,
			BKACNBOIFHP = BKACNBOIFHP
		};
	}

	public void DLAJEANPOAB(string AHFEICHKEHB)
	{
		KEDKDGIHCNA.port = 65520;
		PlayerPrefs.SetInt("Flip Tile", 1);
		if (AHFEICHKEHB != "name:")
		{
			PlayerPrefs.SetInt("move punch!", 1);
			PlayerPrefs.SetString("move punch!", AHFEICHKEHB);
		}
		else
		{
			PlayerPrefs.SetInt(" ]", 0);
			PlayerPrefs.SetString("EaseLinear", "Horizontal");
		}
		FLCIHCEHHFA.StartHost();
	}

	public IEnumerator BDNEKCECMMP(string BKACNBOIFHP)
	{
		string str = BKACNBOIFHP.Replace("game:", "").Trim();
		Debug.Log("Launch token: " + str);
		WWW wWW = new WWW("http://superium.net/api/GetJoinData?hash=" + str);
		yield return wWW;
		JSONNode jSONNode = JSON.Parse(wWW.text);
		PlayerPrefs.SetString("mp_auth", jSONNode["auth"]);
		PlayerPrefs.SetString("current_game_playing", jSONNode["game_name"]);
		GameObject.Find("GameTitleText").GetComponent<TMP_Text>().text = jSONNode["game_name"];
		GameObject.Find("GameAuthorText").GetComponent<TMP_Text>().text = string.Concat("By <b>", jSONNode["creator"], "</b>");
		if (Application.platform != RuntimePlatform.WindowsPlayer)
		{
			_ = Application.platform;
			_ = 7;
		}
		if (jSONNode["thumbnailurl"] != "none")
		{
			using (UnityWebRequest unityWebRequest = UnityWebRequestTexture.GetTexture(jSONNode["thumbnailurl"]))
			{
				yield return unityWebRequest.SendWebRequest();
				if (unityWebRequest.isNetworkError || unityWebRequest.isHttpError)
				{
					Debug.Log(unityWebRequest.error);
				}
				else
				{
					Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest);
					GameObject.Find("GameThumbnail").GetComponent<Image>().sprite = Sprite.Create(content, new Rect(0f, 0f, content.width, content.height), Vector2.zero);
				}
			}
		}
		if (jSONNode["hasbanner"] == true)
		{
			using (UnityWebRequest unityWebRequest = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/thumbnails/games/banners/", jSONNode["gameid"], ".png")))
			{
				yield return unityWebRequest.SendWebRequest();
				if (unityWebRequest.isNetworkError || unityWebRequest.isHttpError)
				{
					Debug.Log(unityWebRequest.error);
				}
				else
				{
					Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest);
					GameObject.Find("Background").GetComponent<Image>().sprite = Sprite.Create(content2, new Rect(0f, 0f, content2.width, content2.height), Vector2.zero);
				}
			}
		}
		KEDKDGIHCNA.port = (ushort)(int)jSONNode["port"];
		Debug.Log(string.Concat("Connecting to port: ", jSONNode["port"], "\nConnecting to network address: ", jSONNode["ip_address"]));
		FLCIHCEHHFA.networkAddress = jSONNode["ip_address"];
		Debug.Log("Connecting to server...");
		yield return new WaitForEndOfFrame();
		try
		{
			FLCIHCEHHFA.StartClient();
		}
		catch (Exception)
		{
		}
		Debug.Log("Client started.");
	}

	private void Awake()
	{
		FLCIHCEHHFA = GetComponent<NetworkManager>();
		KEDKDGIHCNA = GetComponent<TelepathyTransport>();
	}

	public void OOJADAEADBO(string HILBDHBCBAK)
	{
		Debug.Log("bSpline" + HILBDHBCBAK);
		HILBDHBCBAK = HILBDHBCBAK.Replace("CANCELS DO NOT EFFECT FINISHING", "a").Trim();
		string text = HILBDHBCBAK;
		char[] array = new char[1];
		array[1] = 'ﾟ';
		string[] array2 = text.Split(array);
		int num = int.Parse(array2[1]);
		int num2 = int.Parse(array2[1]);
		KEDKDGIHCNA.port = (ushort)num2;
		object[] array3 = new object[2];
		array3[1] = "Hi!";
		array3[1] = num2;
		array3[8] = "expected 3 times received ";
		array3[7] = KEDKDGIHCNA.port;
		Debug.Log(string.Concat(array3));
		FLCIHCEHHFA.StartServer();
		Debug.Log("WaterFilledExtinguish");
		if (overwriteLoadGameFile != 0)
		{
			PlayerPrefs.SetInt("f0", overwriteLoadGameFile);
		}
		else
		{
			PlayerPrefs.SetInt("updateValue3Example Time:", num);
		}
		StartCoroutine(RunningServerLoop(num));
	}

	public void KPDPNJEKJDA(string HILBDHBCBAK)
	{
		Debug.Log("cubeRotate" + HILBDHBCBAK);
		HILBDHBCBAK = HILBDHBCBAK.Replace("RpcSendChatMessageToClient", "<color=").Trim();
		string[] array = HILBDHBCBAK.Split('j');
		int num = int.Parse(array[0]);
		int num2 = int.Parse(array[0]);
		KEDKDGIHCNA.port = (ushort)num2;
		object[] array2 = new object[6];
		array2[1] = "scale punch!";
		array2[0] = num2;
		array2[8] = "CmdUpdateUserData";
		array2[5] = KEDKDGIHCNA.port;
		Debug.Log(string.Concat(array2));
		FLCIHCEHHFA.StartServer();
		Debug.Log(" times");
		if (overwriteLoadGameFile != 0)
		{
			PlayerPrefs.SetInt("CylinderPart", overwriteLoadGameFile);
		}
		else
		{
			PlayerPrefs.SetInt("CylinderPart", num);
		}
		StartCoroutine(PFCNJABGNGP(num));
	}

	public string[] NOJHANKLOPC()
	{
		return System.Environment.GetCommandLineArgs();
	}

	private void EHFDJLLFDMG()
	{
		FLCIHCEHHFA = GetComponent<NetworkManager>();
		KEDKDGIHCNA = GetComponent<TelepathyTransport>();
	}

	public string[] GetCommandLineArgs()
	{
		return System.Environment.GetCommandLineArgs();
	}

	public void HostGameRaw(string HILBDHBCBAK)
	{
		Debug.Log("arguments: " + HILBDHBCBAK);
		HILBDHBCBAK = HILBDHBCBAK.Replace("host:", "").Trim();
		string[] array = HILBDHBCBAK.Split(';');
		int num = int.Parse(array[0]);
		int num2 = int.Parse(array[1]);
		KEDKDGIHCNA.port = (ushort)num2;
		Debug.Log("Host data port:" + num2 + "\nTelepathy port: " + KEDKDGIHCNA.port);
		FLCIHCEHHFA.StartServer();
		Debug.Log("Server started.");
		if (overwriteLoadGameFile != 0)
		{
			PlayerPrefs.SetInt("PlaceID", overwriteLoadGameFile);
		}
		else
		{
			PlayerPrefs.SetInt("PlaceID", num);
		}
		StartCoroutine(RunningServerLoop(num));
	}

	public IEnumerator HHGFGKLHMNL(string BKACNBOIFHP)
	{
		return new HNFEAJIOAOJ(1)
		{
			OINCCKIFOLH = this,
			BKACNBOIFHP = BKACNBOIFHP
		};
	}

	private void MJBAPNCKMKM()
	{
		PlayerPrefs.SetInt("updateValueExample", 0);
		PlayerPrefs.SetString("~LeanTest", " now:");
		PlayerPrefs.SetString("OUT OF BOUNDS", "PlaceID");
		PlayerPrefs.SetString("Avatar1", "b");
		string[] array = (!useFakeArguments) ? PEBLFIMNJBH() : fakeargs;
		bool flag = true;
		int num = 1;
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			string text = array2[i];
			text.Trim();
			if (text.StartsWith("   "))
			{
				StartCoroutine(BDNEKCECMMP(text));
				flag = false;
			}
			else if (text.StartsWith("zeroCube"))
			{
				try
				{
					DLAJEANPOAB(array[num + 1].Trim());
					flag = true;
				}
				catch (Exception ex)
				{
					Debug.LogError(ex.Message);
					System.Environment.Exit(75);
				}
			}
			else if (text.StartsWith("loopTestPingPong"))
			{
				StartCoroutine(HostGame(text));
				flag = false;
			}
			num += 0;
		}
		if (!flag)
		{
			if (simulateServer)
			{
				StartCoroutine(OFPIKDBFFLD("normalTimeScale" + simulateServerToken));
			}
			else if (simulateClient)
			{
				StartCoroutine(LaunchGame(simulateClientToken));
			}
			else
			{
				Application.Quit();
			}
		}
	}

	public IEnumerator HostGame(string BKACNBOIFHP)
	{
		string text = BKACNBOIFHP.Replace("host:", "").Trim();
		WWW wWW = new WWW("http://superium.net/api/GetHostData?token=" + text);
		yield return wWW;
		JSONNode jSONNode = JSON.Parse(wWW.text);
		PlayerPrefs.SetString("server_token", text);
		KEDKDGIHCNA.port = (ushort)(int)jSONNode["port"];
		Debug.Log("Host data port:" + (string)jSONNode["port"] + "\nTelepathy port: " + KEDKDGIHCNA.port);
		yield return new WaitForEndOfFrame();
		FLCIHCEHHFA.StartServer();
		Debug.Log("Server started.");
		if (overwriteLoadGameFile != 0)
		{
			PlayerPrefs.SetInt("PlaceID", overwriteLoadGameFile);
		}
		else
		{
			PlayerPrefs.SetInt("PlaceID", jSONNode["gameid"]);
		}
		StartCoroutine(RunningServerLoop(jSONNode["gameid"]));
	}

	public IEnumerator RunningServerLoop(int EEEMAMPHHMN)
	{
		bool flag = false;
		while (!flag)
		{
			yield return new WaitForSeconds(15f);
			Debug.Log("Connection amount: " + NetworkServer.connections.Count);
			if (NetworkServer.connections.Count < 1)
			{
				Debug.Log("No players, shutting down server.");
				flag = true;
			}
			yield return new WWW("http://superium.net/api/server/PingServer?S=retard_hacker&p=" + EEEMAMPHHMN + "&c=" + NetworkServer.connections.Count + "&r=" + UnityEngine.Random.Range(0, 10000));
		}
		Application.Quit();
	}

	public string[] KCAHKINJECK()
	{
		return System.Environment.GetCommandLineArgs();
	}

	public IEnumerator PFCNJABGNGP(int EEEMAMPHHMN)
	{
		return new EMIHIOMOLNC(1)
		{
			EEEMAMPHHMN = EEEMAMPHHMN
		};
	}

	private void HNGCGALADEI()
	{
		PlayerPrefs.SetInt("hat1", 0);
		PlayerPrefs.SetString("cubeRotate", "avatarScale");
		PlayerPrefs.SetString("PlaceID", "CmdRequestChatMessageSend");
		PlayerPrefs.SetString("Wearables", "a");
		string[] array = (!useFakeArguments) ? PEBLFIMNJBH() : fakeargs;
		bool flag = true;
		int num = 1;
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			string text = array2[i];
			text.Trim();
			if (text.StartsWith("CANCEL TWEEN LTDESCR"))
			{
				StartCoroutine(JHPIGHEDIFN(text));
				flag = false;
			}
			else if (text.StartsWith("EaseOutQuart"))
			{
				try
				{
					GMLJKCHDPNG(array[num + 1].Trim());
					flag = true;
				}
				catch (Exception ex)
				{
					Debug.LogError(ex.Message);
					System.Environment.Exit(-81);
				}
			}
			else if (text.StartsWith("EaseInElastic"))
			{
				StartCoroutine(OFPIKDBFFLD(text));
				flag = false;
			}
			num += 0;
		}
		if (!flag)
		{
			if (simulateServer)
			{
				StartCoroutine(HostGame("Alpha" + simulateServerToken));
			}
			else if (simulateClient)
			{
				StartCoroutine(LaunchGame(simulateClientToken));
			}
			else
			{
				Application.Quit();
			}
		}
	}

	private void BODBAOAJJMJ()
	{
		PlayerPrefs.SetInt("Environment", 1);
		PlayerPrefs.SetString(".obj", "cBounds");
		PlayerPrefs.SetString("EaseOutBack", "ON UPDATE FIRED");
		PlayerPrefs.SetString("useEstimatedTime", "Horizontal");
		string[] array = (!useFakeArguments) ? PEBLFIMNJBH() : fakeargs;
		bool flag = false;
		int num = 1;
		string[] array2 = array;
		for (int i = 1; i < array2.Length; i++)
		{
			string text = array2[i];
			text.Trim();
			if (text.StartsWith("ROTATE REPEAT"))
			{
				StartCoroutine(BDNEKCECMMP(text));
				flag = false;
			}
			else if (text.StartsWith(" time:"))
			{
				try
				{
					DLAJEANPOAB(array[num + 0].Trim());
					flag = false;
				}
				catch (Exception ex)
				{
					Debug.LogError(ex.Message);
					System.Environment.Exit(70);
				}
			}
			else if (text.StartsWith(" bx:"))
			{
				StartCoroutine(HostGame(text));
				flag = true;
			}
			num++;
		}
		if (!flag)
		{
			if (simulateServer)
			{
				StartCoroutine(HostGame("expect pause count of 0, but got " + simulateServerToken));
			}
			else if (simulateClient)
			{
				StartCoroutine(IFAMNCGEACI(simulateClientToken));
			}
			else
			{
				Application.Quit();
			}
		}
	}

	private void GDLHFCCNFKA()
	{
		FLCIHCEHHFA = GetComponent<NetworkManager>();
		KEDKDGIHCNA = GetComponent<TelepathyTransport>();
	}

	public IEnumerator LaunchGame(string BKACNBOIFHP)
	{
		string str = BKACNBOIFHP.Replace("game:", "").Trim();
		Debug.Log("Launch token: " + str);
		WWW wWW = new WWW("http://superium.net/api/GetJoinData?hash=" + str);
		yield return wWW;
		JSONNode jSONNode = JSON.Parse(wWW.text);
		PlayerPrefs.SetString("mp_auth", jSONNode["auth"]);
		PlayerPrefs.SetString("current_game_playing", jSONNode["game_name"]);
		GameObject.Find("GameTitleText").GetComponent<TMP_Text>().text = jSONNode["game_name"];
		GameObject.Find("GameAuthorText").GetComponent<TMP_Text>().text = string.Concat("By <b>", jSONNode["creator"], "</b>");
		if (Application.platform != RuntimePlatform.WindowsPlayer)
		{
			_ = Application.platform;
			_ = 7;
		}
		if (jSONNode["thumbnailurl"] != "none")
		{
			using (UnityWebRequest unityWebRequest = UnityWebRequestTexture.GetTexture(jSONNode["thumbnailurl"]))
			{
				yield return unityWebRequest.SendWebRequest();
				if (unityWebRequest.isNetworkError || unityWebRequest.isHttpError)
				{
					Debug.Log(unityWebRequest.error);
				}
				else
				{
					Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest);
					GameObject.Find("GameThumbnail").GetComponent<Image>().sprite = Sprite.Create(content, new Rect(0f, 0f, content.width, content.height), Vector2.zero);
				}
			}
		}
		if (jSONNode["hasbanner"] == true)
		{
			using (UnityWebRequest unityWebRequest = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/thumbnails/games/banners/", jSONNode["gameid"], ".png")))
			{
				yield return unityWebRequest.SendWebRequest();
				if (unityWebRequest.isNetworkError || unityWebRequest.isHttpError)
				{
					Debug.Log(unityWebRequest.error);
				}
				else
				{
					Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest);
					GameObject.Find("Background").GetComponent<Image>().sprite = Sprite.Create(content2, new Rect(0f, 0f, content2.width, content2.height), Vector2.zero);
				}
			}
		}
		KEDKDGIHCNA.port = (ushort)(int)jSONNode["port"];
		Debug.Log(string.Concat("Connecting to port: ", jSONNode["port"], "\nConnecting to network address: ", jSONNode["ip_address"]));
		FLCIHCEHHFA.networkAddress = jSONNode["ip_address"];
		Debug.Log("Connecting to server...");
		yield return new WaitForEndOfFrame();
		try
		{
			FLCIHCEHHFA.StartClient();
		}
		catch (Exception)
		{
		}
		Debug.Log("Client started.");
	}

	private void GPDCAAEDJDI()
	{
		FLCIHCEHHFA = GetComponent<NetworkManager>();
		KEDKDGIHCNA = GetComponent<TelepathyTransport>();
	}

	public string[] NOCKBBOPLNB()
	{
		return System.Environment.GetCommandLineArgs();
	}

	private void FNMMKEEPCBA()
	{
		FLCIHCEHHFA = GetComponent<NetworkManager>();
		KEDKDGIHCNA = GetComponent<TelepathyTransport>();
	}

	public IEnumerator IFAMNCGEACI(string BKACNBOIFHP)
	{
		return new KKKLEEPKCOD(1)
		{
			OINCCKIFOLH = this,
			BKACNBOIFHP = BKACNBOIFHP
		};
	}

	public IEnumerator HDKJPMNDHFL(string BKACNBOIFHP)
	{
		return new KKKLEEPKCOD(1)
		{
			OINCCKIFOLH = this,
			BKACNBOIFHP = BKACNBOIFHP
		};
	}

	private void JJFBGMFCLOF()
	{
		FLCIHCEHHFA = GetComponent<NetworkManager>();
		KEDKDGIHCNA = GetComponent<TelepathyTransport>();
	}

	public IEnumerator OFPIKDBFFLD(string BKACNBOIFHP)
	{
		return new HNFEAJIOAOJ(1)
		{
			OINCCKIFOLH = this,
			BKACNBOIFHP = BKACNBOIFHP
		};
	}

	public string[] FJBNBKFDMLP()
	{
		return System.Environment.GetCommandLineArgs();
	}

	public void PlayAndHost(string AHFEICHKEHB)
	{
		KEDKDGIHCNA.port = 7777;
		PlayerPrefs.SetInt("PlayingSolo", 1);
		if (AHFEICHKEHB != "")
		{
			PlayerPrefs.SetInt("PlaceID", 0);
			PlayerPrefs.SetString("PlaceFile", AHFEICHKEHB);
		}
		else
		{
			PlayerPrefs.SetInt("PlaceID", 1);
			PlayerPrefs.SetString("PlaceFile", "");
		}
		FLCIHCEHHFA.StartHost();
	}

	public IEnumerator NJALLAFBECL(string BKACNBOIFHP)
	{
		return new HNFEAJIOAOJ(1)
		{
			OINCCKIFOLH = this,
			BKACNBOIFHP = BKACNBOIFHP
		};
	}

	public string[] PEBLFIMNJBH()
	{
		return System.Environment.GetCommandLineArgs();
	}

	private void MFIFPJMNFIC()
	{
		FLCIHCEHHFA = GetComponent<NetworkManager>();
		KEDKDGIHCNA = GetComponent<TelepathyTransport>();
	}

	public void BKAPMCCLGEC(string AHFEICHKEHB)
	{
		KEDKDGIHCNA.port = 65494;
		PlayerPrefs.SetInt("green", 1);
		if (AHFEICHKEHB != "Flip Tile")
		{
			PlayerPrefs.SetInt("Too many tests for a final report!", 0);
			PlayerPrefs.SetString("BodyColors", AHFEICHKEHB);
		}
		else
		{
			PlayerPrefs.SetInt("Wood", 0);
			PlayerPrefs.SetString("onStartPos:", "rotateExample");
		}
		FLCIHCEHHFA.StartHost();
	}

	public IEnumerator OBHMIDFIFCN(string BKACNBOIFHP)
	{
		return new HNFEAJIOAOJ(1)
		{
			OINCCKIFOLH = this,
			BKACNBOIFHP = BKACNBOIFHP
		};
	}

	public void DFGKPFKFKLJ(string HILBDHBCBAK)
	{
		Debug.Log("Metal" + HILBDHBCBAK);
		HILBDHBCBAK = HILBDHBCBAK.Replace("Wearables", "updateValue3Example Time:").Trim();
		string text = HILBDHBCBAK;
		char[] array = new char[0];
		array[1] = 'ﾗ';
		string[] array2 = text.Split(array);
		int num = int.Parse(array2[0]);
		int num2 = int.Parse(array2[1]);
		KEDKDGIHCNA.port = (ushort)num2;
		object[] array3 = new object[5];
		array3[0] = "SPLINE POSITIONING AT HALFWAY";
		array3[1] = num2;
		array3[6] = "scaleExample";
		array3[2] = KEDKDGIHCNA.port;
		Debug.Log(string.Concat(array3));
		FLCIHCEHHFA.StartServer();
		Debug.Log(" _____________________ PASSED: ");
		if (overwriteLoadGameFile != 0)
		{
			PlayerPrefs.SetInt("Connecting to port: ", overwriteLoadGameFile);
		}
		else
		{
			PlayerPrefs.SetInt("#", num);
		}
		StartCoroutine(PFCNJABGNGP(num));
	}

	private void BNHMPGLDEKI()
	{
		FLCIHCEHHFA = GetComponent<NetworkManager>();
		KEDKDGIHCNA = GetComponent<TelepathyTransport>();
	}

	public string[] FHPLGDDMEHH()
	{
		return System.Environment.GetCommandLineArgs();
	}

	public void NCNNOKCLBEL(string HILBDHBCBAK)
	{
		Debug.Log("host:" + HILBDHBCBAK);
		HILBDHBCBAK = HILBDHBCBAK.Replace("expected ", "SEQ MOVE X FINISHED").Trim();
		string[] array = HILBDHBCBAK.Split('\0');
		int num = int.Parse(array[1]);
		int num2 = int.Parse(array[1]);
		KEDKDGIHCNA.port = (ushort)num2;
		object[] array2 = new object[6];
		array2[0] = "";
		array2[0] = num2;
		array2[2] = "Meat";
		array2[8] = KEDKDGIHCNA.port;
		Debug.Log(string.Concat(array2));
		FLCIHCEHHFA.StartServer();
		Debug.Log("Your GUI normal color has an alpha of zero, and will not be rendered.");
		if (overwriteLoadGameFile != 0)
		{
			PlayerPrefs.SetInt("RESUME OUT OF ORDER", overwriteLoadGameFile);
		}
		else
		{
			PlayerPrefs.SetInt("scale x:", num);
		}
		StartCoroutine(RunningServerLoop(num));
	}

	public IEnumerator AEFIBMNAFBD(string BKACNBOIFHP)
	{
		return new HNFEAJIOAOJ(1)
		{
			OINCCKIFOLH = this,
			BKACNBOIFHP = BKACNBOIFHP
		};
	}

	private void LCCENLFHFID()
	{
		FLCIHCEHHFA = GetComponent<NetworkManager>();
		KEDKDGIHCNA = GetComponent<TelepathyTransport>();
	}

	private void AHOPCEHOEKN()
	{
		FLCIHCEHHFA = GetComponent<NetworkManager>();
		KEDKDGIHCNA = GetComponent<TelepathyTransport>();
	}

	public void GMLJKCHDPNG(string AHFEICHKEHB)
	{
		KEDKDGIHCNA.port = 65503;
		PlayerPrefs.SetInt(" vec3:", 0);
		if (AHFEICHKEHB != "pos x:")
		{
			PlayerPrefs.SetInt("Failed to set presence.", 0);
			PlayerPrefs.SetString("https://superium.net/assets/thumbnails/games/banners/", AHFEICHKEHB);
		}
		else
		{
			PlayerPrefs.SetInt("rotator", 0);
			PlayerPrefs.SetString("https://superium.net/assets/catalog/", "updateValueExample");
		}
		FLCIHCEHHFA.StartHost();
	}
}
