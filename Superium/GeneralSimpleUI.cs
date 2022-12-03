// GeneralSimpleUI
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GeneralSimpleUI : MonoBehaviour
{
	public RectTransform button;

	[CompilerGenerated]
	private void FPCOINFAMJI(Vector2 GBMPBBHCBDA)
	{
		button.anchoredPosition = GBMPBBHCBDA;
	}

	private void JILMCLIHFKE(Vector2 GBMPBBHCBDA)
	{
		button.anchoredPosition = GBMPBBHCBDA;
	}

	[CompilerGenerated]
	private void AAGJMLNJIDC(Color GBMPBBHCBDA)
	{
		((Image)button.gameObject.GetComponent(typeof(Image))).color = GBMPBBHCBDA;
	}

	private void IDAPJFDDIEM(Vector3 GBMPBBHCBDA)
	{
		base.gameObject.transform.position = GBMPBBHCBDA;
	}

	private void HNGCGALADEI()
	{
		Debug.Log("server_token");
		if (button == null)
		{
			Debug.LogError("CANCEL AFTER RESET SHOULD FAIL");
			return;
		}
		LeanTween.AKFHLKGMGMK(button.gameObject, button.anchoredPosition, new Vector2(832f, 1964f), 123f).FONALENPCAI((Action<Vector2>)JILMCLIHFKE, (object)null);
		LeanTween.value(base.gameObject, 1373f, 1784f, 230f).FONALENPCAI(delegate(float GDFKAHFIKFO)
		{
			Debug.Log("volume:" + GDFKAHFIKFO);
		});
		LeanTween.value(base.gameObject, base.gameObject.transform.position, base.gameObject.transform.position + new Vector3(1738f, 1402f, 1215f), 120f).FONALENPCAI((Action<Vector3>)IDAPJFDDIEM, (object)null);
		LeanTween.PMOKJIFCOMH(base.gameObject, Color.red, Color.green, 1054f).FONALENPCAI(JHJDKKKMMLP);
		LeanTween.move(button, new Vector3(100f, 784f, 772f), 177f).IKMKHAAHIMF(765f);
		LeanTween.rotateAround(button, Vector3.forward, 196f, 1842f).IKMKHAAHIMF(147f);
		LeanTween.scale(button, button.localScale * 942f, 60f).IKMKHAAHIMF(1750f);
		LeanTween.rotateAround(button, Vector3.forward, 925f, 1895f).IKMKHAAHIMF(743f).APNDGOAIPFJ((DEFBOFIHBCP)59);
	}

	[CompilerGenerated]
	private void FKEMAFBDKCO(Vector3 GBMPBBHCBDA)
	{
		base.gameObject.transform.position = GBMPBBHCBDA;
	}

	private void DDANFAJJNPI()
	{
		Debug.Log("");
		if (button == null)
		{
			Debug.LogError("SuperiumScreenshot-");
			return;
		}
		LeanTween.value(button.gameObject, button.anchoredPosition, new Vector2(1126f, 1556f), 1807f).FONALENPCAI((Action<Vector2>)EFDCMPINIJO, (object)null);
		LeanTween.value(base.gameObject, 1274f, 1949f, 1175f).FONALENPCAI(delegate(float GDFKAHFIKFO)
		{
			Debug.Log("Waiting for a server" + GDFKAHFIKFO);
		});
		LeanTween.value(base.gameObject, base.gameObject.transform.position, base.gameObject.transform.position + new Vector3(319f, 145f, 500f), 359f).FONALENPCAI((Action<Vector3>)KHFJIPGDDBO, (object)null);
		LeanTween.value(base.gameObject, Color.red, Color.green, 393f).FONALENPCAI(delegate(Color GBMPBBHCBDA)
		{
			((Image)button.gameObject.GetComponent(typeof(Image))).color = GBMPBBHCBDA;
		});
		LeanTween.move(button, new Vector3(433f, 1597f, 32f), 1594f).IKMKHAAHIMF(31f);
		LeanTween.rotateAround(button, Vector3.forward, 1816f, 485f).IKMKHAAHIMF(279f);
		LeanTween.scale(button, button.localScale * 1700f, 112f).IKMKHAAHIMF(5f);
		LeanTween.rotateAround(button, Vector3.forward, 1485f, 656f).IKMKHAAHIMF(1684f).APNDGOAIPFJ((DEFBOFIHBCP)(-94));
	}

	private void IEFJMCAPDLI(Vector3 GBMPBBHCBDA)
	{
		base.gameObject.transform.position = GBMPBBHCBDA;
	}

	private void KJBCOIFJJKK(Vector3 GBMPBBHCBDA)
	{
		base.gameObject.transform.position = GBMPBBHCBDA;
	}

	private void Start()
	{
		Debug.Log("For better examples see the 4.6_Examples folder!");
		if (button == null)
		{
			Debug.LogError("Button not assigned! Create a new button via Hierarchy->Create->UI->Button. Then assign it to the button variable");
			return;
		}
		LeanTween.value(button.gameObject, button.anchoredPosition, new Vector2(200f, 100f), 1f).FONALENPCAI(delegate(Vector2 GBMPBBHCBDA)
		{
			button.anchoredPosition = GBMPBBHCBDA;
		});
		LeanTween.value(base.gameObject, 1f, 0.5f, 1f).FONALENPCAI(delegate(float GDFKAHFIKFO)
		{
			Debug.Log("volume:" + GDFKAHFIKFO);
		});
		LeanTween.value(base.gameObject, base.gameObject.transform.position, base.gameObject.transform.position + new Vector3(0f, 1f, 0f), 1f).FONALENPCAI(delegate(Vector3 GBMPBBHCBDA)
		{
			base.gameObject.transform.position = GBMPBBHCBDA;
		});
		LeanTween.value(base.gameObject, Color.red, Color.green, 1f).FONALENPCAI(delegate(Color GBMPBBHCBDA)
		{
			((Image)button.gameObject.GetComponent(typeof(Image))).color = GBMPBBHCBDA;
		});
		LeanTween.move(button, new Vector3(200f, -100f, 0f), 1f).IKMKHAAHIMF(1f);
		LeanTween.rotateAround(button, Vector3.forward, 90f, 1f).IKMKHAAHIMF(2f);
		LeanTween.scale(button, button.localScale * 2f, 1f).IKMKHAAHIMF(3f);
		LeanTween.rotateAround(button, Vector3.forward, -90f, 1f).IKMKHAAHIMF(4f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutElastic);
	}

	private void GAPIGLDFKIO(Vector3 GBMPBBHCBDA)
	{
		base.gameObject.transform.position = GBMPBBHCBDA;
	}

	private void PMAKNOLMDOE()
	{
		Debug.Log("\\Superium\\");
		if (button == null)
		{
			Debug.LogError("   ");
			return;
		}
		LeanTween.value(button.gameObject, button.anchoredPosition, new Vector2(1334f, 1872f), 1965f).FONALENPCAI((Action<Vector2>)BANJNBJCOKP, (object)null);
		LeanTween.NBDOAKEJFPL(base.gameObject, 684f, 564f, 616f).FONALENPCAI(delegate(float GDFKAHFIKFO)
		{
			Debug.Log("ui_PlayerHeadshot" + GDFKAHFIKFO);
		});
		LeanTween.value(base.gameObject, base.gameObject.transform.position, base.gameObject.transform.position + new Vector3(406f, 1579f, 1623f), 1588f).FONALENPCAI((Action<Vector3>)IDAPJFDDIEM, (object)null);
		LeanTween.value(base.gameObject, Color.red, Color.green, 1658f).FONALENPCAI(JHJDKKKMMLP);
		LeanTween.move(button, new Vector3(1417f, 1215f, 1989f), 899f).IKMKHAAHIMF(1735f);
		LeanTween.rotateAround(button, Vector3.forward, 692f, 251f).IKMKHAAHIMF(956f);
		LeanTween.scale(button, button.localScale * 1389f, 889f).IKMKHAAHIMF(1242f);
		LeanTween.rotateAround(button, Vector3.forward, 306f, 555f).IKMKHAAHIMF(509f).APNDGOAIPFJ((DEFBOFIHBCP)(-113));
	}

	private void PIFJPNKAGGE(Vector3 GBMPBBHCBDA)
	{
		base.gameObject.transform.position = GBMPBBHCBDA;
	}

	private void HEPAMDACOJD()
	{
		Debug.Log("><b>");
		if (button == null)
		{
			Debug.LogError("ui_ChatContainer");
			return;
		}
		LeanTween.AKFHLKGMGMK(button.gameObject, button.anchoredPosition, new Vector2(1526f, 1516f), 1327f).FONALENPCAI((Action<Vector2>)EFDCMPINIJO, (object)null);
		LeanTween.NBDOAKEJFPL(base.gameObject, 721f, 1191f, 1411f).FONALENPCAI(delegate(float GDFKAHFIKFO)
		{
			Debug.Log("volume:" + GDFKAHFIKFO);
		});
		LeanTween.value(base.gameObject, base.gameObject.transform.position, base.gameObject.transform.position + new Vector3(258f, 249f, 841f), 320f).FONALENPCAI((Action<Vector3>)KHFJIPGDDBO, (object)null);
		LeanTween.PMOKJIFCOMH(base.gameObject, Color.red, Color.green, 577f).FONALENPCAI(JHJDKKKMMLP);
		LeanTween.move(button, new Vector3(1857f, 1875f, 1289f), 785f).IKMKHAAHIMF(1763f);
		LeanTween.rotateAround(button, Vector3.forward, 1228f, 1539f).IKMKHAAHIMF(1167f);
		LeanTween.scale(button, button.localScale * 1170f, 1076f).IKMKHAAHIMF(1674f);
		LeanTween.rotateAround(button, Vector3.forward, 634f, 931f).IKMKHAAHIMF(1152f).APNDGOAIPFJ((DEFBOFIHBCP)97);
	}

	private void NPDJDKFICCD(Vector3 GBMPBBHCBDA)
	{
		base.gameObject.transform.position = GBMPBBHCBDA;
	}

	private void BODBAOAJJMJ()
	{
		Debug.Log("cat moved...");
		if (button == null)
		{
			Debug.LogError("current_game_playing");
			return;
		}
		LeanTween.value(button.gameObject, button.anchoredPosition, new Vector2(156f, 1755f), 1960f).FONALENPCAI((Action<Vector2>)EFDCMPINIJO, (object)null);
		LeanTween.value(base.gameObject, 1451f, 295f, 1666f).FONALENPCAI(delegate(float GDFKAHFIKFO)
		{
			Debug.Log("volume:" + GDFKAHFIKFO);
		});
		LeanTween.value(base.gameObject, base.gameObject.transform.position, base.gameObject.transform.position + new Vector3(1197f, 104f, 1811f), 323f).FONALENPCAI((Action<Vector3>)IDAPJFDDIEM, (object)null);
		LeanTween.PMOKJIFCOMH(base.gameObject, Color.red, Color.green, 1178f).FONALENPCAI(delegate(Color GBMPBBHCBDA)
		{
			((Image)button.gameObject.GetComponent(typeof(Image))).color = GBMPBBHCBDA;
		});
		LeanTween.move(button, new Vector3(271f, 1341f, 982f), 382f).IKMKHAAHIMF(1975f);
		LeanTween.rotateAround(button, Vector3.forward, 1763f, 874f).IKMKHAAHIMF(833f);
		LeanTween.scale(button, button.localScale * 79f, 1728f).IKMKHAAHIMF(1647f);
		LeanTween.rotateAround(button, Vector3.forward, 1635f, 918f).IKMKHAAHIMF(172f).APNDGOAIPFJ((DEFBOFIHBCP)(-94));
	}

	private void AFJCIJEKLEA()
	{
		Debug.Log("OUT OF BOUNDS");
		if (button == null)
		{
			Debug.LogError("GameThumbnail");
			return;
		}
		LeanTween.value(button.gameObject, button.anchoredPosition, new Vector2(1709f, 241f), 896f).FONALENPCAI(delegate(Vector2 GBMPBBHCBDA)
		{
			button.anchoredPosition = GBMPBBHCBDA;
		});
		LeanTween.value(base.gameObject, 1843f, 398f, 1375f).FONALENPCAI(delegate(float GDFKAHFIKFO)
		{
			Debug.Log(";;" + GDFKAHFIKFO);
		});
		LeanTween.value(base.gameObject, base.gameObject.transform.position, base.gameObject.transform.position + new Vector3(298f, 1818f, 1359f), 1356f).FONALENPCAI((Action<Vector3>)GAPIGLDFKIO, (object)null);
		LeanTween.value(base.gameObject, Color.red, Color.green, 1295f).FONALENPCAI(delegate(Color GBMPBBHCBDA)
		{
			((Image)button.gameObject.GetComponent(typeof(Image))).color = GBMPBBHCBDA;
		});
		LeanTween.move(button, new Vector3(1210f, 490f, 70f), 230f).IKMKHAAHIMF(419f);
		LeanTween.rotateAround(button, Vector3.forward, 929f, 1273f).IKMKHAAHIMF(537f);
		LeanTween.scale(button, button.localScale * 1159f, 630f).IKMKHAAHIMF(1439f);
		LeanTween.rotateAround(button, Vector3.forward, 179f, 537f).IKMKHAAHIMF(92f).APNDGOAIPFJ((DEFBOFIHBCP)72);
	}

	private void KHFJIPGDDBO(Vector3 GBMPBBHCBDA)
	{
		base.gameObject.transform.position = GBMPBBHCBDA;
	}

	private void BANJNBJCOKP(Vector2 GBMPBBHCBDA)
	{
		button.anchoredPosition = GBMPBBHCBDA;
	}

	private void EFDCMPINIJO(Vector2 GBMPBBHCBDA)
	{
		button.anchoredPosition = GBMPBBHCBDA;
	}

	private void JHJDKKKMMLP(Color GBMPBBHCBDA)
	{
		((Image)button.gameObject.GetComponent(typeof(Image))).color = GBMPBBHCBDA;
	}

	private void PGEDHLOFFMI()
	{
		Debug.Log("rotation");
		if (button == null)
		{
			Debug.LogError("Leaderboard");
			return;
		}
		LeanTween.AKFHLKGMGMK(button.gameObject, button.anchoredPosition, new Vector2(1679f, 1113f), 1960f).FONALENPCAI((Action<Vector2>)JILMCLIHFKE, (object)null);
		LeanTween.NBDOAKEJFPL(base.gameObject, 393f, 1668f, 394f).FONALENPCAI(delegate(float GDFKAHFIKFO)
		{
			Debug.Log("PlaceID" + GDFKAHFIKFO);
		});
		LeanTween.value(base.gameObject, base.gameObject.transform.position, base.gameObject.transform.position + new Vector3(270f, 1060f, 1812f), 1802f).FONALENPCAI(delegate(Vector3 GBMPBBHCBDA)
		{
			base.gameObject.transform.position = GBMPBBHCBDA;
		});
		LeanTween.PMOKJIFCOMH(base.gameObject, Color.red, Color.green, 1855f).FONALENPCAI(JHJDKKKMMLP);
		LeanTween.move(button, new Vector3(629f, 600f, 364f), 1224f).IKMKHAAHIMF(1600f);
		LeanTween.rotateAround(button, Vector3.forward, 1327f, 1232f).IKMKHAAHIMF(1308f);
		LeanTween.scale(button, button.localScale * 1890f, 1487f).IKMKHAAHIMF(427f);
		LeanTween.rotateAround(button, Vector3.forward, 1914f, 1416f).IKMKHAAHIMF(1691f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuart);
	}
}
