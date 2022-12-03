// CharacterAppearance
using SimpleJSON;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class CharacterAppearance : MonoBehaviour
{
	public Transform headObj;

	public Transform leftarmObj;

	public Transform rightarmObj;

	public Transform torsoObj;

	public Transform leftlegObj;

	public Transform rightlegObj;

	public Transform lefthandObj;

	public Transform righthandObj;

	public Transform faceObject;

	public Material defaultMat;

	public IEnumerator PLFJNJDFPPJ()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	public IEnumerator BPLOGOIKLCN()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void PGEDHLOFFMI()
	{
		StartCoroutine(GCECAEJIAGB());
	}

	private void OHEKLCKKLHD()
	{
		StartCoroutine(JFJANJBLCMJ());
	}

	private bool GMIDDNODONH()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator MCNFFPPFOEE()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void FGFLCFGDHNC()
	{
		StartCoroutine(MBLJBNCNPNE());
	}

	private bool MINCLINFFIE()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator CKJAABOGGAJ()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	public IEnumerator FPMCPMCEBEC()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	private bool NMIFLDLKHGG()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	private void HONHJGIGOCO()
	{
		StartCoroutine(BBBBFGOGJDN());
	}

	public IEnumerator BEBAKFABPII()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private void ONDBPKKOMND()
	{
		StartCoroutine(FKCHJELKINH());
	}

	private bool PHPCJPMGKKP()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	private void KAGPAJCFBME()
	{
		StartCoroutine(NBEHNFCMIEN());
	}

	public IEnumerator GMGMEMDIGDP()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private void KPEJAJKLCBH()
	{
		StartCoroutine(MFHKLDHNPGO());
	}

	public IEnumerator LHLILKOJOBH()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private bool NKEBCGBAAFH()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator NCFEEHIKPFE()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator MFKBOPPMFGO()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator NJNJABDAEDC()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	private bool KFPDHPJOGOL()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator GFAIJJOJAOP()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator GKIKGHLKKCH()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	public IEnumerator HGIAMABBJGF()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator PMKLEKKAHBK()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	public IEnumerator CMAJDHCEFEO()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	public IEnumerator LoadAppearance()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	public IEnumerator NIIDFPFNJPC()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	private bool GPHACAOBMCC()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	private void HEJJIFBFBAP()
	{
		StartCoroutine(EMGNDACGHDI());
	}

	private bool HCPLNPINNDI()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator GBEFJFBFGHC()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private void ILMPCBPAHLK()
	{
		StartCoroutine(HKPAKBAOIJP());
	}

	private void BODBAOAJJMJ()
	{
		StartCoroutine(NBEHNFCMIEN());
	}

	private bool PECECHPCLPP()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator FKCHJELKINH()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator Init()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	private bool ELJDMMGHLDD()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator PGLDLNABEFD()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator MCKCDDECPKD()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	public IEnumerator GHDJBOIOBME()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private bool ALJFJKKNHOB()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator ODAGEIKHOOP()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void ANDHKLACMNI()
	{
		StartCoroutine(PMFPGPGCEEM());
	}

	private void DHDIFNJEMGK()
	{
		StartCoroutine(JFJANJBLCMJ());
	}

	public IEnumerator PAIIMLCPEJE()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	public IEnumerator GPIINIICAEO()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	private bool ENKLMABIOFG()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	private bool GBECPBEGPHH()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator FOCMCBPECHO()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	public IEnumerator JFJANJBLCMJ()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	public IEnumerator IHKKGJIBAAE()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	public IEnumerator FDOBPKINEFG()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private void CDJBDJKCMLJ()
	{
		StartCoroutine(ODAGEIKHOOP());
	}

	public IEnumerator JCMLKPGHNJJ()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	private void PELEFHJHKBI()
	{
		StartCoroutine(MFKBOPPMFGO());
	}

	public IEnumerator LPAMAOFGOLB()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator AFPJFBKBCBM()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator NFDAJIAMJIC()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator NOCIINMMAEA()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	public IEnumerator PMFPGPGCEEM()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	private void FCOLILJGBOC()
	{
		StartCoroutine(CJPINGFGGME());
	}

	public IEnumerator NJFIHCIPKGF()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	public IEnumerator POCICAIKKFN()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator KALGFLFJMIP()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	private bool BDGDDGDPNGK()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	[CompilerGenerated]
	private bool CBCBCPKGDPK()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	private void PJMPJPGAEKL()
	{
		StartCoroutine(CJGKCCLKGOF());
	}

	private bool KBOFMBBEPDL()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	private bool IBFPCNOJJOI()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator KEMOEPLPEJA()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	public IEnumerator AOPOJDLJKIA()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void ECLHPLHFMBM()
	{
		StartCoroutine(MCKCDDECPKD());
	}

	public IEnumerator IAECGIIJDFN()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator EGNIIOGCFHP()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator AABFHMICEOL()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void HABEDGIMNNB()
	{
		StartCoroutine(MFKBOPPMFGO());
	}

	public IEnumerator GIFIHFAGGFL()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	public IEnumerator PCMEBONOBCM()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator GCECAEJIAGB()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	public IEnumerator HIJBMDMGNKF()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator COADLAMCOGI()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator HKPAKBAOIJP()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator AECONBFJOPO()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private bool DEOINFJAMBK()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator MNKPMNGEKKB()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator MFHKLDHNPGO()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	public IEnumerator KOMFKDDILAE()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	public IEnumerator IBIJHABBOLL()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private void IOJCPGBLDNK()
	{
		StartCoroutine(AOPOJDLJKIA());
	}

	private void IPEBLOPAOBA()
	{
		StartCoroutine(GLPEBDHMBEB());
	}

	public IEnumerator DLJLGFGGOIE()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator OALIIIPMGJG()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	public IEnumerator POFBAEFBLOB()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void EDBBOBMJIMA()
	{
		StartCoroutine(MCKCDDECPKD());
	}

	private bool LIBPJOCLLHD()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	private void ONHHKJKAKED()
	{
		StartCoroutine(BMGFJLIBLHF());
	}

	private void JFAEEHONLPL()
	{
		StartCoroutine(LPAMAOFGOLB());
	}

	public IEnumerator AFONPILNJKN()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	private bool KCOMABOOHNJ()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator EMGNDACGHDI()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	private bool BAJJNPAMPOI()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator ABJKNPMHPAO()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private void Start()
	{
		StartCoroutine(Init());
	}

	private void DDANFAJJNPI()
	{
		StartCoroutine(PMFPGPGCEEM());
	}

	public IEnumerator JNEMJGDPFDG()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator OGBLGNIAEFH()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator HLOEEODKEAB()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void NIANFPFKICN()
	{
		StartCoroutine(BPLOGOIKLCN());
	}

	public IEnumerator CJPINGFGGME()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	private bool DFNLIHLHLIN()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator GLPEBDHMBEB()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	public IEnumerator CJGKCCLKGOF()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	private void EBMLEALCJEB()
	{
		StartCoroutine(MCKCDDECPKD());
	}

	private void KDKGJPEEIAD()
	{
		StartCoroutine(PMFPGPGCEEM());
	}

	private bool DHGJINJAJJH()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	private void AFCELIGJJDC()
	{
		StartCoroutine(AOPOJDLJKIA());
	}

	private bool JKIOEKIIIBO()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	private void HEPAMDACOJD()
	{
		StartCoroutine(MFKBOPPMFGO());
	}

	public IEnumerator JDPNMHBPEMM()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator BBBBFGOGJDN()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	public IEnumerator NKBGLFANAPP()
	{
		yield return new WaitUntil(() => GetComponent<PlayerData>().hasDataLoaded);
		StartCoroutine(LoadAppearance());
		yield return 0;
	}

	public IEnumerator JDFKABHCAPK()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private bool BHHIGJBIPMN()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator GLIIECGGGKL()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator NBEHNFCMIEN()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	private bool BOFBAELAHCA()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator DKNBAHFMDHE()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private void LNDNCLLAANE()
	{
		StartCoroutine(MBLJBNCNPNE());
	}

	public IEnumerator HIJACFLAPJJ()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private void MJBAPNCKMKM()
	{
		StartCoroutine(FOCMCBPECHO());
	}

	public IEnumerator IKACHNCBOLF()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private bool FOBKJENPFJN()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	private void AFJDIBFOBPH()
	{
		StartCoroutine(AOPOJDLJKIA());
	}

	public IEnumerator OFIAKAJOCMP()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator MIPNELIPBJB()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void NJOGBDOIHFJ()
	{
		StartCoroutine(MCNFFPPFOEE());
	}

	public IEnumerator APKLPKMPDPN()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void PPBJCIDDNGC()
	{
		StartCoroutine(CJGKCCLKGOF());
	}

	public IEnumerator DBFHANDJFEO()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	public IEnumerator CFDDGLCFOOL()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	public IEnumerator HGCCOADLDEM()
	{
		PlayerData component = GetComponent<PlayerData>();
		_ = component.userId;
		Debug.Log("Loading character appearance for id " + component.userId);
		using (UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://superium.net/api/GetCharacterAppearanceById?id=" + component.userId))
		{
			yield return unityWebRequest.SendWebRequest();
			if (!unityWebRequest.isNetworkError)
			{
				_ = unityWebRequest.downloadHandler.text;
				JSONNode jSONNode = JSON.Parse(unityWebRequest.downloadHandler.text);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["head"], out Color color);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftarm"], out Color color2);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightarm"], out Color color3);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["torso"], out Color color4);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["leftleg"], out Color color5);
				ColorUtility.TryParseHtmlString(jSONNode["BodyColors"]["rightleg"], out Color color6);
				headObj.GetComponent<MeshRenderer>().materials[0].color = color;
				leftarmObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				rightarmObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				torsoObj.GetComponent<MeshRenderer>().materials[0].color = color4;
				leftlegObj.GetComponent<MeshRenderer>().materials[0].color = color5;
				rightlegObj.GetComponent<MeshRenderer>().materials[0].color = color6;
				lefthandObj.GetComponent<MeshRenderer>().materials[0].color = color2;
				righthandObj.GetComponent<MeshRenderer>().materials[0].color = color3;
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["shirt"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						rightarmObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
						torsoObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content;
					}
				}
				using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["pants"], ".png")))
				{
					yield return unityWebRequest2.SendWebRequest();
					if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
					{
						Debug.Log(unityWebRequest2.error);
					}
					else
					{
						Texture2D content2 = DownloadHandlerTexture.GetContent(unityWebRequest2);
						leftlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
						rightlegObj.GetComponent<MeshRenderer>().materials[1].mainTexture = content2;
					}
				}
				if (jSONNode["Wearables"]["face"] != 0)
				{
					using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["face"], ".png")))
					{
						yield return unityWebRequest2.SendWebRequest();
						if (unityWebRequest2.isNetworkError || unityWebRequest2.isHttpError)
						{
							Debug.Log(unityWebRequest2.error);
						}
						else
						{
							Texture2D content3 = DownloadHandlerTexture.GetContent(unityWebRequest2);
							content3.wrapMode = TextureWrapMode.Clamp;
							faceObject.GetComponent<MeshRenderer>().materials[0].mainTexture = content3;
						}
					}
				}
				if (jSONNode["Wearables"]["hat1"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat1"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj in gameObjects)
					{
						obj.transform.parent = base.transform;
						obj.transform.localPosition = Vector3.zero;
						obj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat2"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat2"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj2 in gameObjects)
					{
						obj2.transform.parent = base.transform;
						obj2.transform.localPosition = Vector3.zero;
						obj2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj2.transform.localEulerAngles = Vector3.zero;
					}
				}
				if (jSONNode["Wearables"]["hat3"] != 0)
				{
					ObjReader.ObjData objData = ObjReader.use.ConvertFileAsync(string.Concat("https://superium.net/assets/catalog/", jSONNode["Wearables"]["hat3"], ".obj"), useMtl: true, defaultMat);
					while (!objData.isDone)
					{
						yield return null;
					}
					GameObject[] gameObjects = objData.gameObjects;
					foreach (GameObject obj3 in gameObjects)
					{
						obj3.transform.parent = base.transform;
						obj3.transform.localPosition = Vector3.zero;
						obj3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
						obj3.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
		}
		yield return 0;
	}

	private void CBEOODIPCFK()
	{
		StartCoroutine(Init());
	}

	public IEnumerator MBLJBNCNPNE()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	private bool OONGCOGNJMM()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	public IEnumerator BHFDBIAGMAD()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator BMGFJLIBLHF()
	{
		return new KJNBDHLELKN(1)
		{
			OINCCKIFOLH = this
		};
	}

	public IEnumerator GGIDCLNCMJG()
	{
		return new COHPNJPMNIE(1)
		{
			OINCCKIFOLH = this
		};
	}

	private bool NJDEAJCDDDK()
	{
		return GetComponent<PlayerData>().hasDataLoaded;
	}

	private void PBPPBGLJNIC()
	{
		StartCoroutine(FKCHJELKINH());
	}
}
