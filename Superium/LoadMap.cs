// LoadMap
using Mirror;
using SimpleJSON;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LoadMap : NetworkBehaviour
{
	public GameObject partPrefab;

	public int placeid = 1;

	private void MHCKEFGNEIP()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("Cube2") != "normalTimeScale")
			{
				GDIOIPNGOCB(PlayerPrefs.GetString("Sand"));
			}
			else if (PlayerPrefs.GetInt("><b>") > 0)
			{
				StartCoroutine(HNLJOLHPPPB(PlayerPrefs.GetInt("message")));
			}
		}
	}

	private void FIMMFFKNONE(string AHFEICHKEHB)
	{
	}

	private void OLPNBKPEPMP()
	{
	}

	private IEnumerator JNAPGKGOLFM(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private void JNFPBGBDKLK()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("Connecting to port: ") != "Discord RPC: Clearing activity")
			{
				OKKMIDGOLHB(PlayerPrefs.GetString("Scale"));
			}
			else if (PlayerPrefs.GetInt("Wearables") > 0)
			{
				StartCoroutine(CHCGNAGJNFJ(PlayerPrefs.GetInt("><b>")));
			}
		}
	}

	private void GMGGOAKFKHE()
	{
	}

	private IEnumerator KEMGDFAMKKD(int LHCMMKLKDHH)
	{
		return new FFBMDIAADAA(1)
		{
			OINCCKIFOLH = this,
			LHCMMKLKDHH = LHCMMKLKDHH
		};
	}

	private void KGEHIJONHKP(string AHFEICHKEHB)
	{
	}

	private void EPFCEBKJJCO()
	{
	}

	private void IHOPGKINDHA()
	{
	}

	private IEnumerator ACOLLBPPPFK(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private void KAHPPKNOOCJ(string AHFEICHKEHB)
	{
	}

	private void EIBFPPABKCC(string AHFEICHKEHB)
	{
	}

	private void HABEDGIMNNB()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("<noparse><</noparse>") != "ui_graphicsQualitySlider")
			{
				ALIJANPOKEI(PlayerPrefs.GetString("Explosion"));
			}
			else if (PlayerPrefs.GetInt("onStartTime:") > 0)
			{
				StartCoroutine(DIAGNFHILOC(PlayerPrefs.GetInt("Wearables")));
			}
		}
	}

	private void OMPJKBNMCBF()
	{
	}

	private void IPOMCIBLHDL()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("rotateAroundExample") != "updateValueExample")
			{
				FNDJAPGJEAP(PlayerPrefs.GetString("You ran out of GUI Element spaces"));
			}
			else if (PlayerPrefs.GetInt("Vertical") > 0)
			{
				StartCoroutine(DIAGNFHILOC(PlayerPrefs.GetInt("ChatInput")));
			}
		}
	}

	private void KOEJPAKBLFJ()
	{
	}

	private void DONBEMLJIFH()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString(" returned:") != "CANCEL TWEEN LEANTWEEN")
			{
				IFFGGEBDBOL(PlayerPrefs.GetString("plr_container"));
			}
			else if (PlayerPrefs.GetInt("Wearables") > 0)
			{
				StartCoroutine(OFMDHLLONOB(PlayerPrefs.GetInt("moveExample")));
			}
		}
	}

	private void LHKKHKIACBO()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("GameAuthorText") != "GameController")
			{
				POBDGAPIHDJ(PlayerPrefs.GetString("FreeCam"));
			}
			else if (PlayerPrefs.GetInt("Player") > 0)
			{
				StartCoroutine(JKDMPIEHMFM(PlayerPrefs.GetInt("cube")));
			}
		}
	}

	private void Start()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("PlaceFile") != "")
			{
				MFIOPOHJGBI(PlayerPrefs.GetString("PlaceFile"));
			}
			else if (PlayerPrefs.GetInt("PlaceID") > 0)
			{
				StartCoroutine(AJPAJALFDDM(PlayerPrefs.GetInt("PlaceID")));
			}
		}
	}

	private void LKAPLLBLBMD(string AHFEICHKEHB)
	{
	}

	private void AFJCIJEKLEA()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("cube") != "solo")
			{
				KGEHIJONHKP(PlayerPrefs.GetString("WaterFilledExtinguish"));
			}
			else if (PlayerPrefs.GetInt("Metal") > 1)
			{
				StartCoroutine(ACIPNLANGMN(PlayerPrefs.GetInt("WaterFilled")));
			}
		}
	}

	private IEnumerator AJPAJALFDDM(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private void HEPACNIHKPP()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("_") != "https://superium.net/api/server/log_chat?data=")
			{
				FALIAPNLAFK(PlayerPrefs.GetString("EaseInBack"));
			}
			else if (PlayerPrefs.GetInt("PlaceID") > 0)
			{
				StartCoroutine(FPDIOJEJDGJ(PlayerPrefs.GetInt("rotateAroundExample")));
			}
		}
	}

	private void OELPOMHOPPL()
	{
	}

	private void FNDJAPGJEAP(string AHFEICHKEHB)
	{
	}

	private void IFFGGEBDBOL(string AHFEICHKEHB)
	{
	}

	private void BAGOIIFGNHJ()
	{
	}

	private void GDIOIPNGOCB(string AHFEICHKEHB)
	{
	}

	private void GNJBDHIJICF()
	{
	}

	private IEnumerator FPDIOJEJDGJ(int LHCMMKLKDHH)
	{
		return new FFBMDIAADAA(1)
		{
			OINCCKIFOLH = this,
			LHCMMKLKDHH = LHCMMKLKDHH
		};
	}

	private IEnumerator AOFJLPDBCON(int LHCMMKLKDHH)
	{
		return new FFBMDIAADAA(1)
		{
			OINCCKIFOLH = this,
			LHCMMKLKDHH = LHCMMKLKDHH
		};
	}

	private void MFIOPOHJGBI(string AHFEICHKEHB)
	{
	}

	private void LHAFBMCMHDC()
	{
	}

	private void DNJDLHDMAIJ()
	{
	}

	private void FJAEBAELHGL()
	{
	}

	private void KMPPOOBDCGA()
	{
	}

	private void LLFJPAHPKJE(string AHFEICHKEHB)
	{
	}

	private IEnumerator DHNHPHDNGCG(int LHCMMKLKDHH)
	{
		return new FFBMDIAADAA(1)
		{
			OINCCKIFOLH = this,
			LHCMMKLKDHH = LHCMMKLKDHH
		};
	}

	private void OLOFCBOPJFK(string AHFEICHKEHB)
	{
	}

	private void LNFMCJOGPNJ()
	{
	}

	private void DBHAOAFNKEB()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("Server started.") != "PlaceFile")
			{
				PGHOKBNGONC(PlayerPrefs.GetString("OUT OF BOUNDS"));
			}
			else if (PlayerPrefs.GetInt("Mouse X") > 1)
			{
				StartCoroutine(JKDMPIEHMFM(PlayerPrefs.GetInt("moveExample")));
			}
		}
	}

	private void ALIJANPOKEI(string AHFEICHKEHB)
	{
	}

	private void NCJEIBLJCDK(string AHFEICHKEHB)
	{
	}

	private void EGPNGGHMAKJ(string AHFEICHKEHB)
	{
	}

	private IEnumerator PFPDICFEMEJ(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private void ILMPCBPAHLK()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("', direction must be -1f or 1f") != "Mouse X")
			{
				GFNJOOPDODG(PlayerPrefs.GetString("In game"));
			}
			else if (PlayerPrefs.GetInt("expected scale z:") > 1)
			{
				StartCoroutine(AJPAJALFDDM(PlayerPrefs.GetInt("cubeDestroy")));
			}
		}
	}

	private IEnumerator OFMDHLLONOB(int LHCMMKLKDHH)
	{
		return new FFBMDIAADAA(1)
		{
			OINCCKIFOLH = this,
			LHCMMKLKDHH = LHCMMKLKDHH
		};
	}

	private void PLPPHHOCLPK()
	{
	}

	private void KFKACCAFEDG(string AHFEICHKEHB)
	{
	}

	private void EIKHDJDDHMD()
	{
	}

	private void KGCGKJMOPMI(string AHFEICHKEHB)
	{
	}

	private void CKCJBHODCAL()
	{
	}

	private void AMEMAEMKDDM()
	{
	}

	private void CHJHGAIKPOK(string AHFEICHKEHB)
	{
	}

	private void EBMLEALCJEB()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString(" set LeanTest.expected = ") != "f, ")
			{
				NCJEIBLJCDK(PlayerPrefs.GetString("moveExample"));
			}
			else if (PlayerPrefs.GetInt("Player auth token not set.") > 1)
			{
				StartCoroutine(DELPJELMNMO(PlayerPrefs.GetInt("You ran out of areas to add listeners, consider increasing LISTENERS_MAX, ex: LeanTween.LISTENERS_MAX = ")));
			}
		}
	}

	private void FALIAPNLAFK(string AHFEICHKEHB)
	{
	}

	private void OHJFLKGKKOK(string AHFEICHKEHB)
	{
	}

	private void IDMEAONILPK(string AHFEICHKEHB)
	{
	}

	private IEnumerator JKDMPIEHMFM(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private void FGIPNFFOHFN()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString(".obj") != "plr_container")
			{
				PGHOKBNGONC(PlayerPrefs.GetString("server_token"));
			}
			else if (PlayerPrefs.GetInt("GameController") > 1)
			{
				StartCoroutine(DHNHPHDNGCG(PlayerPrefs.GetInt("Player auth token not set.")));
			}
		}
	}

	private IEnumerator DIAGNFHILOC(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private IEnumerator ONMFHGKLODA(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private IEnumerator ECAJCLOILJA(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private IEnumerator OCKKENLDGBL(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private void LNKCGCDKGPJ()
	{
	}

	private void POBDGAPIHDJ(string AHFEICHKEHB)
	{
	}

	private void PGHOKBNGONC(string AHFEICHKEHB)
	{
	}

	private void DBMHDPKGOAN()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString(" )") != "https://superium.net/assets/catalog/")
			{
				JMCGFCIGIJL(PlayerPrefs.GetString("\\Superium\\"));
			}
			else if (PlayerPrefs.GetInt("-solo") > 0)
			{
				StartCoroutine(ECAJCLOILJA(PlayerPrefs.GetInt("SPLINE WITH TWO POINTS SUCCEEDS")));
			}
		}
	}

	private void BOKBIFHEFGM()
	{
	}

	private IEnumerator HNLJOLHPPPB(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private IEnumerator DELPJELMNMO(int LHCMMKLKDHH)
	{
		return new FFBMDIAADAA(1)
		{
			OINCCKIFOLH = this,
			LHCMMKLKDHH = LHCMMKLKDHH
		};
	}

	private void AIMBPEJAGIG(string AHFEICHKEHB)
	{
	}

	private void DHDIFNJEMGK()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("CANCEL AFTER RESET SHOULD FAIL") != "sphere")
			{
				OHBNKNCMFAO(PlayerPrefs.GetString("NOTHING TWEEENING AT BEGINNING"));
			}
			else if (PlayerPrefs.GetInt("expected:") > 1)
			{
				StartCoroutine(CMCFMHDIMFL(PlayerPrefs.GetInt("EVENT ALL REMOVED")));
			}
		}
	}

	private void MBGKLHEPFOD()
	{
	}

	private void JEDBEELLACK()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("unknown") != "Wearables")
			{
				GFNJOOPDODG(PlayerPrefs.GetString("</color>: </b>"));
			}
			else if (PlayerPrefs.GetInt("SCALED ENDING POSITION") > 1)
			{
				StartCoroutine(JKDMPIEHMFM(PlayerPrefs.GetInt("ON UPDATE FIRED")));
			}
		}
	}

	private void OHBNKNCMFAO(string AHFEICHKEHB)
	{
	}

	private void OKKMIDGOLHB(string AHFEICHKEHB)
	{
	}

	private IEnumerator HMOEOANPIJI(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private void JKEIENKJOKF()
	{
	}

	private void KEAHMICOMEJ()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("Loading...") != "")
			{
				LKAPLLBLBMD(PlayerPrefs.GetString("GROUP IDS MATCH"));
			}
			else if (PlayerPrefs.GetInt("\nConnecting to network address: ") > 0)
			{
				StartCoroutine(KIEDPIINMHB(PlayerPrefs.GetInt("ignoreTimeScale")));
			}
		}
	}

	private void NKHNFBMBCPP()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("LeanTweenLogo") != "moving")
			{
				KAHPPKNOOCJ(PlayerPrefs.GetString("Part"));
			}
			else if (PlayerPrefs.GetInt("LCharacter") > 1)
			{
				StartCoroutine(CHCGNAGJNFJ(PlayerPrefs.GetInt("EaseOutExpo")));
			}
		}
	}

	private void MMIAFNEGFMC()
	{
	}

	private void PJMPJPGAEKL()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString(" but got ") != "cylinder")
			{
				FNDJAPGJEAP(PlayerPrefs.GetString("green"));
			}
			else if (PlayerPrefs.GetInt("BodyColors") > 0)
			{
				StartCoroutine(ONMFHGKLODA(PlayerPrefs.GetInt(" hasInitiliazed:")));
			}
		}
	}

	private void GFNJOOPDODG(string AHFEICHKEHB)
	{
	}

	private IEnumerator CHCGNAGJNFJ(int LHCMMKLKDHH)
	{
		return new FFBMDIAADAA(1)
		{
			OINCCKIFOLH = this,
			LHCMMKLKDHH = LHCMMKLKDHH
		};
	}

	private void OCOHKAGLGIE(string AHFEICHKEHB)
	{
	}

	private void FGFLCFGDHNC()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString(".obj") != "loopTestClamp Time:")
			{
				NCJEIBLJCDK(PlayerPrefs.GetString("Respawn"));
			}
			else if (PlayerPrefs.GetInt("ui_fullscreenToggle") > 0)
			{
				StartCoroutine(DHNHPHDNGCG(PlayerPrefs.GetInt("")));
			}
		}
	}

	private void CNNFAKABNEP()
	{
	}

	private void HKJMFFHEAMF()
	{
	}

	private void JCALDGKFAPL()
	{
		if (base.isServer)
		{
			if (PlayerPrefs.GetString("scaleExample") != "https://superium.net/assets/catalog/")
			{
				PGHOKBNGONC(PlayerPrefs.GetString("ZERO TIME FINSHES CORRECTLY"));
			}
			else if (PlayerPrefs.GetInt("game:") > 0)
			{
				StartCoroutine(FPDIOJEJDGJ(PlayerPrefs.GetInt(" origin:")));
			}
		}
	}

	private void IBCFPJMEBCE(string AHFEICHKEHB)
	{
	}

	private void PJHFBEHALOF()
	{
	}

	private void PBNFONGLNHF()
	{
	}

	private IEnumerator CMCFMHDIMFL(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private void NDMEGLMHEOD()
	{
	}

	private void IPJODMLNLGG(string AHFEICHKEHB)
	{
	}

	private void NJDANPHABEO()
	{
	}

	private void HOMMONACDIC()
	{
	}

	private void JMCGFCIGIJL(string AHFEICHKEHB)
	{
	}

	private IEnumerator KIEDPIINMHB(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private IEnumerator EAGOCBFGLPM(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}

	private void FFMBBNFLONA(string AHFEICHKEHB)
	{
	}

	private IEnumerator ACIPNLANGMN(int LHCMMKLKDHH)
	{
		string uri = "http://superium.net/assets/games/" + LHCMMKLKDHH + ".btw";
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri))
		{
			yield return unityWebRequest.SendWebRequest();
			if (unityWebRequest.isNetworkError)
			{
				yield break;
			}
			_ = unityWebRequest.downloadHandler.text;
			JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
			Vector3 vector = new Vector3(0f, 0f, 0f);
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Vector3 localScale = new Vector3(1f, 1f, 1f);
			string str = "FFFFFF";
			bool flag = false;
			JSONNode.Enumerator enumerator = jSONNode["Environment"].GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode.Enumerator enumerator2 = ((JSONNode)enumerator.Current).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					KeyValuePair<string, JSONNode> current = enumerator2.Current;
					if (current.Key == "position")
					{
						vector = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "rotation")
					{
						vector2 = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "scale")
					{
						localScale = LIAMMICMDMG.OIHCBJLDFGI(current.Value);
					}
					else if (current.Key == "hexColor")
					{
						str = current.Value;
					}
					else if (current.Key == "isSpawn")
					{
						flag = current.Value;
					}
					else
					{
						Debug.LogWarning("Found unknown key: " + current.Key);
					}
				}
				GameObject gameObject = Object.Instantiate(partPrefab, new Vector3(vector.x, vector.y, vector.z), Quaternion.Euler(vector2.x, vector2.y, vector2.z));
				gameObject.name = "Part";
				gameObject.transform.localScale = localScale;
				Color color = new Color(1f, 0f, 1f);
				ColorUtility.TryParseHtmlString("#" + str, out color);
				gameObject.GetComponent<Renderer>().material.color = color;
				gameObject.GetComponent<PartManager>().CGMPBBJBIBC = color;
				if (flag)
				{
					gameObject.tag = "SpawnLocation";
				}
				NetworkServer.Spawn(gameObject);
			}
		}
	}
}
