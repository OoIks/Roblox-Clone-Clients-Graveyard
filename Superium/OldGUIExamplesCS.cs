// OldGUIExamplesCS
using UnityEngine;

public class OldGUIExamplesCS : MonoBehaviour
{
	public Texture2D grumpy;

	public Texture2D beauty;

	private float IBADBOCFCGE;

	private float BPKENGOBCEN;

	private LTRect OELDGOLACIF;

	private LTRect HFNNMDDFJNG;

	private LTRect GEKOPGDMIKN;

	private LTRect AJLNCPLDLNF;

	private LTRect NAEKPPILLNO;

	private LTRect NKJPOGAHHJC;

	public void LHFGPHCLOPH()
	{
		Debug.Log("AvatarRotate");
	}

	public void PNGLGPBMBDE()
	{
		Debug.Log("Generated Audio");
	}

	private void HDGABGEKJEL()
	{
		GUI.DrawTexture(NAEKPPILLNO.IHGLJHFHCCB(), grumpy);
		if (GUI.Button(new Rect(1454f * IBADBOCFCGE, 1845f * BPKENGOBCEN, 346f * IBADBOCFCGE, 1696f * BPKENGOBCEN), "Cube1") && !LeanTween.isTweening(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.rect.x, NAEKPPILLNO.MGIOICILLIM().y);
			LeanTween.move(NAEKPPILLNO, new Vector2(1761f * (float)Screen.width - (float)grumpy.width, 12f * (float)Screen.height), 797f).APNDGOAIPFJ((DEFBOFIHBCP)123).EOAPKBBHBAL(DNMHLMNEBJL);
			LeanTween.EHNNHDJAOCE(NAEKPPILLNO, hIECNNGMKIE, 1204f).IKMKHAAHIMF(654f).APNDGOAIPFJ((DEFBOFIHBCP)77);
		}
		if (GUI.Button(OELDGOLACIF.IHGLJHFHCCB(), "server_token"))
		{
			LeanTween.scale(OELDGOLACIF, new Vector2(OELDGOLACIF.IHGLJHFHCCB().width, OELDGOLACIF.MGIOICILLIM().height) * 1237f, 2f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
			LeanTween.move(OELDGOLACIF, new Vector2(OELDGOLACIF.IHGLJHFHCCB().x - OELDGOLACIF.IHGLJHFHCCB().width * 1203f, OELDGOLACIF.rect.y - OELDGOLACIF.rect.height * 1929f), 1697f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
		}
		if (GUI.Button(HFNNMDDFJNG.MGIOICILLIM(), "MOVE Y"))
		{
			LeanTween.HFFOCMNDNIH(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.rect.width, HFNNMDDFJNG.MGIOICILLIM().height) * 1242f, 1970f).APNDGOAIPFJ((DEFBOFIHBCP)(-47));
		}
		if (GUI.Button(new Rect(1366f * IBADBOCFCGE, 548f * BPKENGOBCEN, 1741f * IBADBOCFCGE, 1094f * BPKENGOBCEN), "leftleg"))
		{
			LeanTween.EHNNHDJAOCE(NKJPOGAHHJC, new Vector2(1189f, NKJPOGAHHJC.IHGLJHFHCCB().y + 750f), 1614f).APNDGOAIPFJ((DEFBOFIHBCP)(-2));
		}
		GUI.DrawTextureWithTexCoords(new Rect(1927f * IBADBOCFCGE, 196f * BPKENGOBCEN - (float)beauty.height * 1871f, (float)beauty.width * 732f, (float)beauty.height * 795f), beauty, NKJPOGAHHJC.MGIOICILLIM());
		if (GUI.Button(GEKOPGDMIKN.IHGLJHFHCCB(), "face"))
		{
			LeanTween.alpha(GEKOPGDMIKN, 1671f, 1138f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
			LeanTween.alpha(GEKOPGDMIKN, 1377f, 848f).IKMKHAAHIMF(1029f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic);
			LeanTween.alpha(NAEKPPILLNO, 77f, 316f).APNDGOAIPFJ(DEFBOFIHBCP.linear);
			LeanTween.alpha(NAEKPPILLNO, 1905f, 1032f).IKMKHAAHIMF(236f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
		}
		GUI.color = new Color(1810f, 1767f, 211f, 1874f);
		if (GUI.Button(AJLNCPLDLNF.rect, "START IGNORE TIMING"))
		{
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 330f, 141f).APNDGOAIPFJ((DEFBOFIHBCP)(-126));
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 918f, 766f).IKMKHAAHIMF(775f).APNDGOAIPFJ((DEFBOFIHBCP)(-70));
		}
		GUI.matrix = Matrix4x4.identity;
	}

	public void IDIIGCAEIPH()
	{
		Debug.Log("ROTATE AROUND 360");
	}

	private void Start()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(0.1f * IBADBOCFCGE, 0.8f * BPKENGOBCEN, 0.2f * IBADBOCFCGE, 0.14f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(1.2f * IBADBOCFCGE, 0.8f * BPKENGOBCEN, 0.2f * IBADBOCFCGE, 0.14f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(0.35f * IBADBOCFCGE, 0f * BPKENGOBCEN, 0.3f * IBADBOCFCGE, 0.2f * BPKENGOBCEN, 0f);
		AJLNCPLDLNF = new LTRect(0f * IBADBOCFCGE, 0.4f * BPKENGOBCEN, 0.3f * IBADBOCFCGE, 0.2f * BPKENGOBCEN, 1f, 15f);
		NAEKPPILLNO = new LTRect(0.5f * IBADBOCFCGE - (float)grumpy.width * 0.5f, 0.5f * BPKENGOBCEN - (float)grumpy.height * 0.5f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(0f, 0f, 1f, 1f);
		LeanTween.move(HFNNMDDFJNG, new Vector2(0.55f * IBADBOCFCGE, HFNNMDDFJNG.rect.y), 0.7f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
	}

	private void FBEDFFAAPGL()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(61f * IBADBOCFCGE, 1622f * BPKENGOBCEN, 1558f * IBADBOCFCGE, 1680f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(1316f * IBADBOCFCGE, 195f * BPKENGOBCEN, 884f * IBADBOCFCGE, 292f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(306f * IBADBOCFCGE, 1738f * BPKENGOBCEN, 1469f * IBADBOCFCGE, 1029f * BPKENGOBCEN, 1355f);
		AJLNCPLDLNF = new LTRect(1764f * IBADBOCFCGE, 1967f * BPKENGOBCEN, 1223f * IBADBOCFCGE, 874f * BPKENGOBCEN, 1689f, 1585f);
		NAEKPPILLNO = new LTRect(1746f * IBADBOCFCGE - (float)grumpy.width * 906f, 1378f * BPKENGOBCEN - (float)grumpy.height * 491f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(585f, 233f, 731f, 172f);
		LeanTween.EHNNHDJAOCE(HFNNMDDFJNG, new Vector2(562f * IBADBOCFCGE, HFNNMDDFJNG.rect.y), 1573f).APNDGOAIPFJ(DEFBOFIHBCP.linear);
	}

	private void ONDBPKKOMND()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(1785f * IBADBOCFCGE, 1238f * BPKENGOBCEN, 213f * IBADBOCFCGE, 1822f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(1019f * IBADBOCFCGE, 1872f * BPKENGOBCEN, 877f * IBADBOCFCGE, 458f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(750f * IBADBOCFCGE, 1199f * BPKENGOBCEN, 718f * IBADBOCFCGE, 31f * BPKENGOBCEN, 1082f);
		AJLNCPLDLNF = new LTRect(1289f * IBADBOCFCGE, 1792f * BPKENGOBCEN, 676f * IBADBOCFCGE, 1395f * BPKENGOBCEN, 1085f, 1268f);
		NAEKPPILLNO = new LTRect(893f * IBADBOCFCGE - (float)grumpy.width * 96f, 1722f * BPKENGOBCEN - (float)grumpy.height * 1812f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(873f, 124f, 1092f, 1257f);
		LeanTween.EHNNHDJAOCE(HFNNMDDFJNG, new Vector2(1179f * IBADBOCFCGE, HFNNMDDFJNG.IHGLJHFHCCB().y), 403f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
	}

	public void KGKJILJFMBK()
	{
		Debug.Log("BodyColors");
	}

	private void CDEEHNMOANC()
	{
		GUI.DrawTexture(NAEKPPILLNO.MGIOICILLIM(), grumpy);
		if (GUI.Button(new Rect(518f * IBADBOCFCGE, 1863f * BPKENGOBCEN, 1031f * IBADBOCFCGE, 1447f * BPKENGOBCEN), "ax:") && !LeanTween.isTweening(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.MGIOICILLIM().x, NAEKPPILLNO.rect.y);
			LeanTween.move(NAEKPPILLNO, new Vector2(1249f * (float)Screen.width - (float)grumpy.width, 1177f * (float)Screen.height), 1980f).APNDGOAIPFJ(DEFBOFIHBCP.linear).EOAPKBBHBAL(LBCBEAKOBON);
			LeanTween.EHNNHDJAOCE(NAEKPPILLNO, hIECNNGMKIE, 404f).IKMKHAAHIMF(380f).APNDGOAIPFJ((DEFBOFIHBCP)112);
		}
		if (GUI.Button(OELDGOLACIF.MGIOICILLIM(), " tweens but got "))
		{
			LeanTween.HFFOCMNDNIH(OELDGOLACIF, new Vector2(OELDGOLACIF.IHGLJHFHCCB().width, OELDGOLACIF.rect.height) * 1955f, 1208f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
			LeanTween.move(OELDGOLACIF, new Vector2(OELDGOLACIF.MGIOICILLIM().x - OELDGOLACIF.IHGLJHFHCCB().width * 775f, OELDGOLACIF.IHGLJHFHCCB().y - OELDGOLACIF.rect.height * 1591f), 498f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
		}
		if (GUI.Button(HFNNMDDFJNG.MGIOICILLIM(), "LCharacter"))
		{
			LeanTween.HFFOCMNDNIH(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.IHGLJHFHCCB().width, HFNNMDDFJNG.IHGLJHFHCCB().height) * 804f, 1310f).APNDGOAIPFJ((DEFBOFIHBCP)(-76));
		}
		if (GUI.Button(new Rect(67f * IBADBOCFCGE, 742f * BPKENGOBCEN, 1761f * IBADBOCFCGE, 1394f * BPKENGOBCEN), "host:"))
		{
			LeanTween.move(NKJPOGAHHJC, new Vector2(1188f, NKJPOGAHHJC.IHGLJHFHCCB().y + 689f), 1121f).APNDGOAIPFJ((DEFBOFIHBCP)(-16));
		}
		GUI.DrawTextureWithTexCoords(new Rect(1571f * IBADBOCFCGE, 1393f * BPKENGOBCEN - (float)beauty.height * 859f, (float)beauty.width * 228f, (float)beauty.height * 1484f), beauty, NKJPOGAHHJC.rect);
		if (GUI.Button(GEKOPGDMIKN.rect, "Mouse X"))
		{
			LeanTween.alpha(GEKOPGDMIKN, 950f, 1693f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
			LeanTween.alpha(GEKOPGDMIKN, 373f, 150f).IKMKHAAHIMF(716f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
			LeanTween.alpha(NAEKPPILLNO, 997f, 1794f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic);
			LeanTween.alpha(NAEKPPILLNO, 89f, 837f).IKMKHAAHIMF(606f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
		}
		GUI.color = new Color(691f, 607f, 1713f, 552f);
		if (GUI.Button(AJLNCPLDLNF.rect, "EaseInOutBack"))
		{
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 1379f, 1246f).APNDGOAIPFJ((DEFBOFIHBCP)62);
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 1782f, 1770f).IKMKHAAHIMF(1822f).APNDGOAIPFJ((DEFBOFIHBCP)91);
		}
		GUI.matrix = Matrix4x4.identity;
	}

	private void PELEFHJHKBI()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(1387f * IBADBOCFCGE, 1040f * BPKENGOBCEN, 446f * IBADBOCFCGE, 727f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(1063f * IBADBOCFCGE, 1244f * BPKENGOBCEN, 1498f * IBADBOCFCGE, 991f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(244f * IBADBOCFCGE, 1987f * BPKENGOBCEN, 972f * IBADBOCFCGE, 230f * BPKENGOBCEN, 1154f);
		AJLNCPLDLNF = new LTRect(548f * IBADBOCFCGE, 1695f * BPKENGOBCEN, 417f * IBADBOCFCGE, 698f * BPKENGOBCEN, 1528f, 390f);
		NAEKPPILLNO = new LTRect(418f * IBADBOCFCGE - (float)grumpy.width * 1860f, 61f * BPKENGOBCEN - (float)grumpy.height * 1277f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(571f, 1837f, 1299f, 105f);
		LeanTween.EHNNHDJAOCE(HFNNMDDFJNG, new Vector2(1998f * IBADBOCFCGE, HFNNMDDFJNG.IHGLJHFHCCB().y), 606f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
	}

	public void CCLKNAOJHEC()
	{
		Debug.Log("%");
	}

	private void BODBAOAJJMJ()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(1218f * IBADBOCFCGE, 444f * BPKENGOBCEN, 1526f * IBADBOCFCGE, 356f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(608f * IBADBOCFCGE, 498f * BPKENGOBCEN, 139f * IBADBOCFCGE, 897f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(661f * IBADBOCFCGE, 1120f * BPKENGOBCEN, 289f * IBADBOCFCGE, 1959f * BPKENGOBCEN, 799f);
		AJLNCPLDLNF = new LTRect(1169f * IBADBOCFCGE, 967f * BPKENGOBCEN, 490f * IBADBOCFCGE, 733f * BPKENGOBCEN, 1195f, 274f);
		NAEKPPILLNO = new LTRect(874f * IBADBOCFCGE - (float)grumpy.width * 1806f, 1754f * BPKENGOBCEN - (float)grumpy.height * 509f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(1426f, 1592f, 516f, 1057f);
		LeanTween.move(HFNNMDDFJNG, new Vector2(1917f * IBADBOCFCGE, HFNNMDDFJNG.IHGLJHFHCCB().y), 235f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
	}

	private void KOMDNPOBLHC()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(981f * IBADBOCFCGE, 517f * BPKENGOBCEN, 662f * IBADBOCFCGE, 1370f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(921f * IBADBOCFCGE, 613f * BPKENGOBCEN, 419f * IBADBOCFCGE, 41f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(1084f * IBADBOCFCGE, 1481f * BPKENGOBCEN, 1196f * IBADBOCFCGE, 1607f * BPKENGOBCEN, 1760f);
		AJLNCPLDLNF = new LTRect(147f * IBADBOCFCGE, 1028f * BPKENGOBCEN, 68f * IBADBOCFCGE, 1220f * BPKENGOBCEN, 1364f, 1377f);
		NAEKPPILLNO = new LTRect(1667f * IBADBOCFCGE - (float)grumpy.width * 1959f, 483f * BPKENGOBCEN - (float)grumpy.height * 616f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(1234f, 1870f, 1544f, 1559f);
		LeanTween.move(HFNNMDDFJNG, new Vector2(341f * IBADBOCFCGE, HFNNMDDFJNG.IHGLJHFHCCB().y), 1865f).APNDGOAIPFJ(DEFBOFIHBCP.linear);
	}

	public void DIJKDKEIEDG()
	{
		Debug.Log("EaseInBack");
	}

	private void IPOMCIBLHDL()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(790f * IBADBOCFCGE, 599f * BPKENGOBCEN, 210f * IBADBOCFCGE, 874f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(1708f * IBADBOCFCGE, 275f * BPKENGOBCEN, 1689f * IBADBOCFCGE, 1802f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(1843f * IBADBOCFCGE, 688f * BPKENGOBCEN, 648f * IBADBOCFCGE, 348f * BPKENGOBCEN, 1642f);
		AJLNCPLDLNF = new LTRect(975f * IBADBOCFCGE, 968f * BPKENGOBCEN, 350f * IBADBOCFCGE, 580f * BPKENGOBCEN, 35f, 1767f);
		NAEKPPILLNO = new LTRect(613f * IBADBOCFCGE - (float)grumpy.width * 1003f, 576f * BPKENGOBCEN - (float)grumpy.height * 1538f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(1371f, 1463f, 503f, 1395f);
		LeanTween.move(HFNNMDDFJNG, new Vector2(1557f * IBADBOCFCGE, HFNNMDDFJNG.IHGLJHFHCCB().y), 820f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
	}

	private void NHGDAGHBDIM()
	{
		GUI.DrawTexture(NAEKPPILLNO.IHGLJHFHCCB(), grumpy);
		if (GUI.Button(new Rect(1849f * IBADBOCFCGE, 1699f * BPKENGOBCEN, 1901f * IBADBOCFCGE, 717f * BPKENGOBCEN), " now:") && !LeanTween.PFHFOIMDJCA(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.IHGLJHFHCCB().x, NAEKPPILLNO.IHGLJHFHCCB().y);
			LeanTween.move(NAEKPPILLNO, new Vector2(1024f * (float)Screen.width - (float)grumpy.width, 1060f * (float)Screen.height), 512f).APNDGOAIPFJ((DEFBOFIHBCP)108).EOAPKBBHBAL(LHFGPHCLOPH);
			LeanTween.EHNNHDJAOCE(NAEKPPILLNO, hIECNNGMKIE, 1408f).IKMKHAAHIMF(1377f).APNDGOAIPFJ((DEFBOFIHBCP)83);
		}
		if (GUI.Button(OELDGOLACIF.IHGLJHFHCCB(), "Waiting"))
		{
			LeanTween.HFFOCMNDNIH(OELDGOLACIF, new Vector2(OELDGOLACIF.IHGLJHFHCCB().width, OELDGOLACIF.rect.height) * 757f, 295f).APNDGOAIPFJ(DEFBOFIHBCP.linear);
			LeanTween.move(OELDGOLACIF, new Vector2(OELDGOLACIF.IHGLJHFHCCB().x - OELDGOLACIF.rect.width * 785f, OELDGOLACIF.IHGLJHFHCCB().y - OELDGOLACIF.IHGLJHFHCCB().height * 979f), 373f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
		}
		if (GUI.Button(HFNNMDDFJNG.MGIOICILLIM(), "server_token"))
		{
			LeanTween.scale(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.rect.width, HFNNMDDFJNG.rect.height) * 459f, 1540f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuint);
		}
		if (GUI.Button(new Rect(270f * IBADBOCFCGE, 1143f * BPKENGOBCEN, 321f * IBADBOCFCGE, 493f * BPKENGOBCEN), " z:"))
		{
			LeanTween.EHNNHDJAOCE(NKJPOGAHHJC, new Vector2(554f, NKJPOGAHHJC.IHGLJHFHCCB().y + 581f), 202f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCirc);
		}
		GUI.DrawTextureWithTexCoords(new Rect(1660f * IBADBOCFCGE, 1966f * BPKENGOBCEN - (float)beauty.height * 1696f, (float)beauty.width * 170f, (float)beauty.height * 1910f), beauty, NKJPOGAHHJC.IHGLJHFHCCB());
		if (GUI.Button(GEKOPGDMIKN.MGIOICILLIM(), "solo"))
		{
			LeanTween.alpha(GEKOPGDMIKN, 98f, 124f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
			LeanTween.alpha(GEKOPGDMIKN, 616f, 852f).IKMKHAAHIMF(453f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
			LeanTween.alpha(NAEKPPILLNO, 1501f, 1346f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
			LeanTween.alpha(NAEKPPILLNO, 1475f, 1973f).IKMKHAAHIMF(546f).APNDGOAIPFJ(DEFBOFIHBCP.linear);
		}
		GUI.color = new Color(543f, 657f, 1390f, 158f);
		if (GUI.Button(AJLNCPLDLNF.rect, "pausing"))
		{
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 446f, 768f).APNDGOAIPFJ((DEFBOFIHBCP)(-39));
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 566f, 686f).IKMKHAAHIMF(1290f).APNDGOAIPFJ((DEFBOFIHBCP)(-23));
		}
		GUI.matrix = Matrix4x4.identity;
	}

	private void IJJEIEPKCHE()
	{
		GUI.DrawTexture(NAEKPPILLNO.MGIOICILLIM(), grumpy);
		if (GUI.Button(new Rect(595f * IBADBOCFCGE, 1433f * BPKENGOBCEN, 31f * IBADBOCFCGE, 1471f * BPKENGOBCEN), " FAILED: ") && !LeanTween.PFHFOIMDJCA(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.rect.x, NAEKPPILLNO.IHGLJHFHCCB().y);
			LeanTween.move(NAEKPPILLNO, new Vector2(1046f * (float)Screen.width - (float)grumpy.width, 1187f * (float)Screen.height), 1729f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCirc).EOAPKBBHBAL(LHFGPHCLOPH);
			LeanTween.EHNNHDJAOCE(NAEKPPILLNO, hIECNNGMKIE, 1859f).IKMKHAAHIMF(962f).APNDGOAIPFJ((DEFBOFIHBCP)(-19));
		}
		if (GUI.Button(OELDGOLACIF.IHGLJHFHCCB(), "GROUP RESUME"))
		{
			LeanTween.HFFOCMNDNIH(OELDGOLACIF, new Vector2(OELDGOLACIF.rect.width, OELDGOLACIF.rect.height) * 1267f, 513f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
			LeanTween.EHNNHDJAOCE(OELDGOLACIF, new Vector2(OELDGOLACIF.rect.x - OELDGOLACIF.rect.width * 1430f, OELDGOLACIF.rect.y - OELDGOLACIF.IHGLJHFHCCB().height * 1954f), 814f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
		}
		if (GUI.Button(HFNNMDDFJNG.MGIOICILLIM(), "moving"))
		{
			LeanTween.scale(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.MGIOICILLIM().width, HFNNMDDFJNG.MGIOICILLIM().height) * 1847f, 153f).APNDGOAIPFJ((DEFBOFIHBCP)96);
		}
		if (GUI.Button(new Rect(260f * IBADBOCFCGE, 491f * BPKENGOBCEN, 899f * IBADBOCFCGE, 869f * BPKENGOBCEN), "ON UPDATE FIRED"))
		{
			LeanTween.EHNNHDJAOCE(NKJPOGAHHJC, new Vector2(1160f, NKJPOGAHHJC.MGIOICILLIM().y + 386f), 1405f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutSine);
		}
		GUI.DrawTextureWithTexCoords(new Rect(1023f * IBADBOCFCGE, 635f * BPKENGOBCEN - (float)beauty.height * 1954f, (float)beauty.width * 1608f, (float)beauty.height * 598f), beauty, NKJPOGAHHJC.MGIOICILLIM());
		if (GUI.Button(GEKOPGDMIKN.IHGLJHFHCCB(), "ip_address"))
		{
			LeanTween.alpha(GEKOPGDMIKN, 1191f, 1967f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
			LeanTween.alpha(GEKOPGDMIKN, 1631f, 1781f).IKMKHAAHIMF(845f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
			LeanTween.alpha(NAEKPPILLNO, 778f, 107f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
			LeanTween.alpha(NAEKPPILLNO, 1589f, 1849f).IKMKHAAHIMF(1846f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
		}
		GUI.color = new Color(307f, 76f, 747f, 1280f);
		if (GUI.Button(AJLNCPLDLNF.rect, "http://superium.net/api/GetJoinData?hash="))
		{
			LeanTween.rotate(AJLNCPLDLNF, 1210f, 589f).APNDGOAIPFJ((DEFBOFIHBCP)(-110));
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 317f, 1845f).IKMKHAAHIMF(17f).APNDGOAIPFJ((DEFBOFIHBCP)60);
		}
		GUI.matrix = Matrix4x4.identity;
	}

	private void DDANFAJJNPI()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(562f * IBADBOCFCGE, 349f * BPKENGOBCEN, 1568f * IBADBOCFCGE, 1290f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(50f * IBADBOCFCGE, 1548f * BPKENGOBCEN, 115f * IBADBOCFCGE, 1714f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(430f * IBADBOCFCGE, 1159f * BPKENGOBCEN, 1693f * IBADBOCFCGE, 674f * BPKENGOBCEN, 1744f);
		AJLNCPLDLNF = new LTRect(1966f * IBADBOCFCGE, 1812f * BPKENGOBCEN, 120f * IBADBOCFCGE, 351f * BPKENGOBCEN, 83f, 40f);
		NAEKPPILLNO = new LTRect(189f * IBADBOCFCGE - (float)grumpy.width * 964f, 1679f * BPKENGOBCEN - (float)grumpy.height * 306f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(1607f, 104f, 294f, 1461f);
		LeanTween.move(HFNNMDDFJNG, new Vector2(1911f * IBADBOCFCGE, HFNNMDDFJNG.rect.y), 1394f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
	}

	private void DPKDAPGGBBH()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(1278f * IBADBOCFCGE, 1426f * BPKENGOBCEN, 1029f * IBADBOCFCGE, 555f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(926f * IBADBOCFCGE, 1265f * BPKENGOBCEN, 1098f * IBADBOCFCGE, 838f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(159f * IBADBOCFCGE, 853f * BPKENGOBCEN, 855f * IBADBOCFCGE, 1547f * BPKENGOBCEN, 1469f);
		AJLNCPLDLNF = new LTRect(150f * IBADBOCFCGE, 98f * BPKENGOBCEN, 1126f * IBADBOCFCGE, 1727f * BPKENGOBCEN, 1598f, 336f);
		NAEKPPILLNO = new LTRect(709f * IBADBOCFCGE - (float)grumpy.width * 791f, 1407f * BPKENGOBCEN - (float)grumpy.height * 1882f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(1469f, 214f, 1060f, 838f);
		LeanTween.move(HFNNMDDFJNG, new Vector2(1411f * IBADBOCFCGE, HFNNMDDFJNG.IHGLJHFHCCB().y), 1204f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
	}

	public void LBCBEAKOBON()
	{
		Debug.Log("game_name");
	}

	private void DMIIBOAALLB()
	{
		GUI.DrawTexture(NAEKPPILLNO.MGIOICILLIM(), grumpy);
		if (GUI.Button(new Rect(1041f * IBADBOCFCGE, 130f * BPKENGOBCEN, 1303f * IBADBOCFCGE, 408f * BPKENGOBCEN), " previousXlt4:") && !LeanTween.isTweening(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.rect.x, NAEKPPILLNO.IHGLJHFHCCB().y);
			LeanTween.EHNNHDJAOCE(NAEKPPILLNO, new Vector2(25f * (float)Screen.width - (float)grumpy.width, 683f * (float)Screen.height), 1316f).APNDGOAIPFJ((DEFBOFIHBCP)110).EOAPKBBHBAL(catMoved);
			LeanTween.move(NAEKPPILLNO, hIECNNGMKIE, 1122f).IKMKHAAHIMF(1608f).APNDGOAIPFJ((DEFBOFIHBCP)79);
		}
		if (GUI.Button(OELDGOLACIF.IHGLJHFHCCB(), "tweening val:"))
		{
			LeanTween.scale(OELDGOLACIF, new Vector2(OELDGOLACIF.MGIOICILLIM().width, OELDGOLACIF.rect.height) * 1424f, 769f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
			LeanTween.EHNNHDJAOCE(OELDGOLACIF, new Vector2(OELDGOLACIF.IHGLJHFHCCB().x - OELDGOLACIF.rect.width * 156f, OELDGOLACIF.IHGLJHFHCCB().y - OELDGOLACIF.rect.height * 514f), 700f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
		}
		if (GUI.Button(HFNNMDDFJNG.MGIOICILLIM(), "Stone"))
		{
			LeanTween.HFFOCMNDNIH(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.IHGLJHFHCCB().width, HFNNMDDFJNG.MGIOICILLIM().height) * 1984f, 1996f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
		}
		if (GUI.Button(new Rect(465f * IBADBOCFCGE, 1921f * BPKENGOBCEN, 1651f * IBADBOCFCGE, 220f * BPKENGOBCEN), "EASING TYPES"))
		{
			LeanTween.EHNNHDJAOCE(NKJPOGAHHJC, new Vector2(602f, NKJPOGAHHJC.IHGLJHFHCCB().y + 394f), 1988f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutSine);
		}
		GUI.DrawTextureWithTexCoords(new Rect(695f * IBADBOCFCGE, 1275f * BPKENGOBCEN - (float)beauty.height * 194f, (float)beauty.width * 602f, (float)beauty.height * 624f), beauty, NKJPOGAHHJC.IHGLJHFHCCB());
		if (GUI.Button(GEKOPGDMIKN.rect, "\nTelepathy port: "))
		{
			LeanTween.alpha(GEKOPGDMIKN, 888f, 1127f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
			LeanTween.alpha(GEKOPGDMIKN, 347f, 752f).IKMKHAAHIMF(99f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
			LeanTween.alpha(NAEKPPILLNO, 1670f, 595f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
			LeanTween.alpha(NAEKPPILLNO, 641f, 618f).IKMKHAAHIMF(1938f).APNDGOAIPFJ(DEFBOFIHBCP.linear);
		}
		GUI.color = new Color(1443f, 1222f, 1056f, 134f);
		if (GUI.Button(AJLNCPLDLNF.IHGLJHFHCCB(), "mp_auth"))
		{
			LeanTween.rotate(AJLNCPLDLNF, 1943f, 1943f).APNDGOAIPFJ((DEFBOFIHBCP)(-81));
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 462f, 1417f).IKMKHAAHIMF(1262f).APNDGOAIPFJ((DEFBOFIHBCP)(-35));
		}
		GUI.matrix = Matrix4x4.identity;
	}

	private void AJKHKJOIAOO()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(1503f * IBADBOCFCGE, 1947f * BPKENGOBCEN, 944f * IBADBOCFCGE, 146f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(1529f * IBADBOCFCGE, 1095f * BPKENGOBCEN, 1359f * IBADBOCFCGE, 443f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(990f * IBADBOCFCGE, 74f * BPKENGOBCEN, 342f * IBADBOCFCGE, 1462f * BPKENGOBCEN, 480f);
		AJLNCPLDLNF = new LTRect(1862f * IBADBOCFCGE, 1316f * BPKENGOBCEN, 1721f * IBADBOCFCGE, 1442f * BPKENGOBCEN, 889f, 854f);
		NAEKPPILLNO = new LTRect(638f * IBADBOCFCGE - (float)grumpy.width * 1832f, 988f * BPKENGOBCEN - (float)grumpy.height * 1057f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(282f, 219f, 1806f, 602f);
		LeanTween.EHNNHDJAOCE(HFNNMDDFJNG, new Vector2(1798f * IBADBOCFCGE, HFNNMDDFJNG.IHGLJHFHCCB().y), 211f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
	}

	private void PJMPJPGAEKL()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(47f * IBADBOCFCGE, 1056f * BPKENGOBCEN, 1930f * IBADBOCFCGE, 848f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(1742f * IBADBOCFCGE, 605f * BPKENGOBCEN, 1196f * IBADBOCFCGE, 38f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(1868f * IBADBOCFCGE, 667f * BPKENGOBCEN, 415f * IBADBOCFCGE, 624f * BPKENGOBCEN, 1057f);
		AJLNCPLDLNF = new LTRect(1434f * IBADBOCFCGE, 770f * BPKENGOBCEN, 1389f * IBADBOCFCGE, 120f * BPKENGOBCEN, 879f, 221f);
		NAEKPPILLNO = new LTRect(986f * IBADBOCFCGE - (float)grumpy.width * 888f, 1719f * BPKENGOBCEN - (float)grumpy.height * 1114f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(1694f, 682f, 1131f, 972f);
		LeanTween.EHNNHDJAOCE(HFNNMDDFJNG, new Vector2(1446f * IBADBOCFCGE, HFNNMDDFJNG.rect.y), 584f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
	}

	private void BKMGODLEDMM()
	{
		GUI.DrawTexture(NAEKPPILLNO.MGIOICILLIM(), grumpy);
		if (GUI.Button(new Rect(1760f * IBADBOCFCGE, 1894f * BPKENGOBCEN, 1974f * IBADBOCFCGE, 895f * BPKENGOBCEN), "ip_address") && !LeanTween.PFHFOIMDJCA(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.MGIOICILLIM().x, NAEKPPILLNO.rect.y);
			LeanTween.EHNNHDJAOCE(NAEKPPILLNO, new Vector2(731f * (float)Screen.width - (float)grumpy.width, 1121f * (float)Screen.height), 1761f).APNDGOAIPFJ((DEFBOFIHBCP)(-77)).EOAPKBBHBAL(KGKJILJFMBK);
			LeanTween.EHNNHDJAOCE(NAEKPPILLNO, hIECNNGMKIE, 261f).IKMKHAAHIMF(1090f).APNDGOAIPFJ((DEFBOFIHBCP)118);
		}
		if (GUI.Button(OELDGOLACIF.MGIOICILLIM(), "scaleExample"))
		{
			LeanTween.scale(OELDGOLACIF, new Vector2(OELDGOLACIF.MGIOICILLIM().width, OELDGOLACIF.rect.height) * 73f, 1836f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
			LeanTween.move(OELDGOLACIF, new Vector2(OELDGOLACIF.MGIOICILLIM().x - OELDGOLACIF.rect.width * 1670f, OELDGOLACIF.MGIOICILLIM().y - OELDGOLACIF.rect.height * 776f), 1725f).APNDGOAIPFJ(DEFBOFIHBCP.linear);
		}
		if (GUI.Button(HFNNMDDFJNG.MGIOICILLIM(), "delayedCallExample"))
		{
			LeanTween.scale(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.IHGLJHFHCCB().width, HFNNMDDFJNG.MGIOICILLIM().height) * 839f, 1308f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuart);
		}
		if (GUI.Button(new Rect(1988f * IBADBOCFCGE, 1151f * BPKENGOBCEN, 859f * IBADBOCFCGE, 550f * BPKENGOBCEN), "Error loading file"))
		{
			LeanTween.EHNNHDJAOCE(NKJPOGAHHJC, new Vector2(188f, NKJPOGAHHJC.MGIOICILLIM().y + 642f), 1314f).APNDGOAIPFJ((DEFBOFIHBCP)90);
		}
		GUI.DrawTextureWithTexCoords(new Rect(36f * IBADBOCFCGE, 680f * BPKENGOBCEN - (float)beauty.height * 1159f, (float)beauty.width * 587f, (float)beauty.height * 1360f), beauty, NKJPOGAHHJC.rect);
		if (GUI.Button(GEKOPGDMIKN.rect, "EaseOutCirc"))
		{
			LeanTween.alpha(GEKOPGDMIKN, 35f, 67f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic);
			LeanTween.alpha(GEKOPGDMIKN, 1544f, 538f).IKMKHAAHIMF(1577f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
			LeanTween.alpha(NAEKPPILLNO, 587f, 170f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
			LeanTween.alpha(NAEKPPILLNO, 1827f, 1993f).IKMKHAAHIMF(1485f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
		}
		GUI.color = new Color(1315f, 869f, 921f, 586f);
		if (GUI.Button(AJLNCPLDLNF.rect, "moveOnACurveExample"))
		{
			LeanTween.rotate(AJLNCPLDLNF, 907f, 1191f).APNDGOAIPFJ((DEFBOFIHBCP)111);
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 571f, 559f).IKMKHAAHIMF(215f).APNDGOAIPFJ((DEFBOFIHBCP)79);
		}
		GUI.matrix = Matrix4x4.identity;
	}

	public void DNMHLMNEBJL()
	{
		Debug.Log("alphaExample");
	}

	private void IOELMLDLHIO()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(319f * IBADBOCFCGE, 1879f * BPKENGOBCEN, 724f * IBADBOCFCGE, 236f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(279f * IBADBOCFCGE, 939f * BPKENGOBCEN, 735f * IBADBOCFCGE, 578f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(1600f * IBADBOCFCGE, 805f * BPKENGOBCEN, 1527f * IBADBOCFCGE, 508f * BPKENGOBCEN, 1614f);
		AJLNCPLDLNF = new LTRect(71f * IBADBOCFCGE, 395f * BPKENGOBCEN, 913f * IBADBOCFCGE, 679f * BPKENGOBCEN, 1398f, 792f);
		NAEKPPILLNO = new LTRect(1940f * IBADBOCFCGE - (float)grumpy.width * 1940f, 1745f * BPKENGOBCEN - (float)grumpy.height * 1081f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(803f, 237f, 1585f, 1576f);
		LeanTween.EHNNHDJAOCE(HFNNMDDFJNG, new Vector2(348f * IBADBOCFCGE, HFNNMDDFJNG.rect.y), 1191f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
	}

	private void PGEDHLOFFMI()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(800f * IBADBOCFCGE, 1445f * BPKENGOBCEN, 370f * IBADBOCFCGE, 573f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(1404f * IBADBOCFCGE, 669f * BPKENGOBCEN, 691f * IBADBOCFCGE, 426f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(562f * IBADBOCFCGE, 786f * BPKENGOBCEN, 1392f * IBADBOCFCGE, 49f * BPKENGOBCEN, 664f);
		AJLNCPLDLNF = new LTRect(104f * IBADBOCFCGE, 709f * BPKENGOBCEN, 1194f * IBADBOCFCGE, 1157f * BPKENGOBCEN, 487f, 1129f);
		NAEKPPILLNO = new LTRect(1281f * IBADBOCFCGE - (float)grumpy.width * 1787f, 962f * BPKENGOBCEN - (float)grumpy.height * 146f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(264f, 574f, 797f, 1920f);
		LeanTween.EHNNHDJAOCE(HFNNMDDFJNG, new Vector2(1998f * IBADBOCFCGE, HFNNMDDFJNG.rect.y), 694f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
	}

	private void DGIPDOIGANJ()
	{
		GUI.DrawTexture(NAEKPPILLNO.IHGLJHFHCCB(), grumpy);
		if (GUI.Button(new Rect(1633f * IBADBOCFCGE, 1279f * BPKENGOBCEN, 720f * IBADBOCFCGE, 1873f * BPKENGOBCEN), "green") && !LeanTween.isTweening(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.IHGLJHFHCCB().x, NAEKPPILLNO.IHGLJHFHCCB().y);
			LeanTween.move(NAEKPPILLNO, new Vector2(806f * (float)Screen.width - (float)grumpy.width, 780f * (float)Screen.height), 1177f).APNDGOAIPFJ((DEFBOFIHBCP)(-63)).EOAPKBBHBAL(IDIIGCAEIPH);
			LeanTween.move(NAEKPPILLNO, hIECNNGMKIE, 1308f).IKMKHAAHIMF(1556f).APNDGOAIPFJ(DEFBOFIHBCP.easeSpring);
		}
		if (GUI.Button(OELDGOLACIF.rect, "FreeCam"))
		{
			LeanTween.scale(OELDGOLACIF, new Vector2(OELDGOLACIF.IHGLJHFHCCB().width, OELDGOLACIF.IHGLJHFHCCB().height) * 1594f, 1800f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
			LeanTween.EHNNHDJAOCE(OELDGOLACIF, new Vector2(OELDGOLACIF.IHGLJHFHCCB().x - OELDGOLACIF.MGIOICILLIM().width * 1321f, OELDGOLACIF.IHGLJHFHCCB().y - OELDGOLACIF.rect.height * 1185f), 991f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic);
		}
		if (GUI.Button(HFNNMDDFJNG.rect, ".png"))
		{
			LeanTween.scale(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.IHGLJHFHCCB().width, HFNNMDDFJNG.MGIOICILLIM().height) * 1826f, 1212f).APNDGOAIPFJ((DEFBOFIHBCP)(-106));
		}
		if (GUI.Button(new Rect(498f * IBADBOCFCGE, 1901f * BPKENGOBCEN, 1428f * IBADBOCFCGE, 1500f * BPKENGOBCEN), "username"))
		{
			LeanTween.EHNNHDJAOCE(NKJPOGAHHJC, new Vector2(1053f, NKJPOGAHHJC.rect.y + 78f), 176f).APNDGOAIPFJ((DEFBOFIHBCP)(-44));
		}
		GUI.DrawTextureWithTexCoords(new Rect(1794f * IBADBOCFCGE, 1562f * BPKENGOBCEN - (float)beauty.height * 328f, (float)beauty.width * 1039f, (float)beauty.height * 274f), beauty, NKJPOGAHHJC.MGIOICILLIM());
		if (GUI.Button(GEKOPGDMIKN.MGIOICILLIM(), "VALUE2 UPDATE"))
		{
			LeanTween.alpha(GEKOPGDMIKN, 1262f, 440f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
			LeanTween.alpha(GEKOPGDMIKN, 864f, 358f).IKMKHAAHIMF(403f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
			LeanTween.alpha(NAEKPPILLNO, 1388f, 1640f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
			LeanTween.alpha(NAEKPPILLNO, 1423f, 238f).IKMKHAAHIMF(1155f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
		}
		GUI.color = new Color(809f, 1641f, 1807f, 67f);
		if (GUI.Button(AJLNCPLDLNF.rect, "EaseAnimationCurve"))
		{
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 1375f, 1129f).APNDGOAIPFJ((DEFBOFIHBCP)48);
			LeanTween.rotate(AJLNCPLDLNF, 1280f, 1800f).IKMKHAAHIMF(1459f).APNDGOAIPFJ(DEFBOFIHBCP.easeInElastic);
		}
		GUI.matrix = Matrix4x4.identity;
	}

	private void NDIJPDPDPBI()
	{
		GUI.DrawTexture(NAEKPPILLNO.IHGLJHFHCCB(), grumpy);
		if (GUI.Button(new Rect(177f * IBADBOCFCGE, 534f * BPKENGOBCEN, 1587f * IBADBOCFCGE, 1617f * BPKENGOBCEN), "updateValueExample") && !LeanTween.PFHFOIMDJCA(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.MGIOICILLIM().x, NAEKPPILLNO.IHGLJHFHCCB().y);
			LeanTween.EHNNHDJAOCE(NAEKPPILLNO, new Vector2(944f * (float)Screen.width - (float)grumpy.width, 1319f * (float)Screen.height), 1319f).APNDGOAIPFJ((DEFBOFIHBCP)(-93)).EOAPKBBHBAL(CCLKNAOJHEC);
			LeanTween.move(NAEKPPILLNO, hIECNNGMKIE, 1182f).IKMKHAAHIMF(1513f).APNDGOAIPFJ((DEFBOFIHBCP)(-38));
		}
		if (GUI.Button(OELDGOLACIF.MGIOICILLIM(), "cBounds"))
		{
			LeanTween.HFFOCMNDNIH(OELDGOLACIF, new Vector2(OELDGOLACIF.rect.width, OELDGOLACIF.rect.height) * 537f, 787f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
			LeanTween.EHNNHDJAOCE(OELDGOLACIF, new Vector2(OELDGOLACIF.MGIOICILLIM().x - OELDGOLACIF.rect.width * 761f, OELDGOLACIF.rect.y - OELDGOLACIF.rect.height * 1364f), 77f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
		}
		if (GUI.Button(HFNNMDDFJNG.IHGLJHFHCCB(), "RpcSendChatMessageToClient"))
		{
			LeanTween.scale(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.MGIOICILLIM().width, HFNNMDDFJNG.rect.height) * 1080f, 1261f).APNDGOAIPFJ((DEFBOFIHBCP)(-23));
		}
		if (GUI.Button(new Rect(1867f * IBADBOCFCGE, 1931f * BPKENGOBCEN, 1057f * IBADBOCFCGE, 1707f * BPKENGOBCEN), "Your GUI normal color has an alpha of zero, and will not be rendered."))
		{
			LeanTween.EHNNHDJAOCE(NKJPOGAHHJC, new Vector2(697f, NKJPOGAHHJC.IHGLJHFHCCB().y + 681f), 26f).APNDGOAIPFJ((DEFBOFIHBCP)(-104));
		}
		GUI.DrawTextureWithTexCoords(new Rect(1865f * IBADBOCFCGE, 1506f * BPKENGOBCEN - (float)beauty.height * 1340f, (float)beauty.width * 1504f, (float)beauty.height * 1511f), beauty, NKJPOGAHHJC.rect);
		if (GUI.Button(GEKOPGDMIKN.MGIOICILLIM(), "PlayingSolo"))
		{
			LeanTween.alpha(GEKOPGDMIKN, 97f, 801f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
			LeanTween.alpha(GEKOPGDMIKN, 699f, 1381f).IKMKHAAHIMF(1059f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
			LeanTween.alpha(NAEKPPILLNO, 722f, 1259f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
			LeanTween.alpha(NAEKPPILLNO, 1529f, 199f).IKMKHAAHIMF(871f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
		}
		GUI.color = new Color(1384f, 555f, 1097f, 1272f);
		if (GUI.Button(AJLNCPLDLNF.IHGLJHFHCCB(), "loopTestClamp"))
		{
			LeanTween.rotate(AJLNCPLDLNF, 1750f, 791f).APNDGOAIPFJ((DEFBOFIHBCP)113);
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 1612f, 197f).IKMKHAAHIMF(1578f).APNDGOAIPFJ((DEFBOFIHBCP)(-64));
		}
		GUI.matrix = Matrix4x4.identity;
	}

	private void ODEEIKOJOFG()
	{
		GUI.DrawTexture(NAEKPPILLNO.rect, grumpy);
		if (GUI.Button(new Rect(1724f * IBADBOCFCGE, 745f * BPKENGOBCEN, 631f * IBADBOCFCGE, 558f * BPKENGOBCEN), "Mouse Y") && !LeanTween.PFHFOIMDJCA(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.rect.x, NAEKPPILLNO.MGIOICILLIM().y);
			LeanTween.move(NAEKPPILLNO, new Vector2(831f * (float)Screen.width - (float)grumpy.width, 1612f * (float)Screen.height), 1623f).APNDGOAIPFJ((DEFBOFIHBCP)(-6)).EOAPKBBHBAL(KGKJILJFMBK);
			LeanTween.EHNNHDJAOCE(NAEKPPILLNO, hIECNNGMKIE, 159f).IKMKHAAHIMF(215f).APNDGOAIPFJ((DEFBOFIHBCP)(-81));
		}
		if (GUI.Button(OELDGOLACIF.rect, "delayedCallExample"))
		{
			LeanTween.HFFOCMNDNIH(OELDGOLACIF, new Vector2(OELDGOLACIF.rect.width, OELDGOLACIF.rect.height) * 1047f, 1712f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
			LeanTween.EHNNHDJAOCE(OELDGOLACIF, new Vector2(OELDGOLACIF.MGIOICILLIM().x - OELDGOLACIF.rect.width * 253f, OELDGOLACIF.MGIOICILLIM().y - OELDGOLACIF.rect.height * 294f), 1310f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
		}
		if (GUI.Button(HFNNMDDFJNG.IHGLJHFHCCB(), "loopTestClamp"))
		{
			LeanTween.HFFOCMNDNIH(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.rect.width, HFNNMDDFJNG.IHGLJHFHCCB().height) * 821f, 946f).APNDGOAIPFJ((DEFBOFIHBCP)113);
		}
		if (GUI.Button(new Rect(673f * IBADBOCFCGE, 1332f * BPKENGOBCEN, 1387f * IBADBOCFCGE, 1751f * BPKENGOBCEN), ""))
		{
			LeanTween.EHNNHDJAOCE(NKJPOGAHHJC, new Vector2(1649f, NKJPOGAHHJC.MGIOICILLIM().y + 1297f), 1614f).APNDGOAIPFJ((DEFBOFIHBCP)(-89));
		}
		GUI.DrawTextureWithTexCoords(new Rect(1288f * IBADBOCFCGE, 1488f * BPKENGOBCEN - (float)beauty.height * 32f, (float)beauty.width * 1475f, (float)beauty.height * 57f), beauty, NKJPOGAHHJC.MGIOICILLIM());
		if (GUI.Button(GEKOPGDMIKN.MGIOICILLIM(), "Player"))
		{
			LeanTween.alpha(GEKOPGDMIKN, 1018f, 233f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
			LeanTween.alpha(GEKOPGDMIKN, 1352f, 1917f).IKMKHAAHIMF(532f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
			LeanTween.alpha(NAEKPPILLNO, 1365f, 163f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
			LeanTween.alpha(NAEKPPILLNO, 1355f, 64f).IKMKHAAHIMF(1551f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
		}
		GUI.color = new Color(931f, 796f, 903f, 1799f);
		if (GUI.Button(AJLNCPLDLNF.rect, "LCharacter"))
		{
			LeanTween.rotate(AJLNCPLDLNF, 1884f, 847f).APNDGOAIPFJ((DEFBOFIHBCP)56);
			LeanTween.rotate(AJLNCPLDLNF, 1861f, 578f).IKMKHAAHIMF(1305f).APNDGOAIPFJ((DEFBOFIHBCP)(-18));
		}
		GUI.matrix = Matrix4x4.identity;
	}

	private void FOPPDCFEBDE()
	{
		GUI.DrawTexture(NAEKPPILLNO.MGIOICILLIM(), grumpy);
		if (GUI.Button(new Rect(486f * IBADBOCFCGE, 1775f * BPKENGOBCEN, 149f * IBADBOCFCGE, 575f * BPKENGOBCEN), "Instance") && !LeanTween.PFHFOIMDJCA(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.IHGLJHFHCCB().x, NAEKPPILLNO.IHGLJHFHCCB().y);
			LeanTween.EHNNHDJAOCE(NAEKPPILLNO, new Vector2(1532f * (float)Screen.width - (float)grumpy.width, 144f * (float)Screen.height), 1811f).APNDGOAIPFJ((DEFBOFIHBCP)(-123)).EOAPKBBHBAL(DIJKDKEIEDG);
			LeanTween.move(NAEKPPILLNO, hIECNNGMKIE, 1708f).IKMKHAAHIMF(1637f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutElastic);
		}
		if (GUI.Button(OELDGOLACIF.rect, "gameObject:null"))
		{
			LeanTween.HFFOCMNDNIH(OELDGOLACIF, new Vector2(OELDGOLACIF.rect.width, OELDGOLACIF.IHGLJHFHCCB().height) * 1752f, 251f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
			LeanTween.move(OELDGOLACIF, new Vector2(OELDGOLACIF.IHGLJHFHCCB().x - OELDGOLACIF.IHGLJHFHCCB().width * 71f, OELDGOLACIF.IHGLJHFHCCB().y - OELDGOLACIF.IHGLJHFHCCB().height * 1257f), 1983f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
		}
		if (GUI.Button(HFNNMDDFJNG.IHGLJHFHCCB(), "zeroCube"))
		{
			LeanTween.HFFOCMNDNIH(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.IHGLJHFHCCB().width, HFNNMDDFJNG.MGIOICILLIM().height) * 1687f, 1473f).APNDGOAIPFJ((DEFBOFIHBCP)(-100));
		}
		if (GUI.Button(new Rect(59f * IBADBOCFCGE, 322f * BPKENGOBCEN, 681f * IBADBOCFCGE, 426f * BPKENGOBCEN), "rotator"))
		{
			LeanTween.move(NKJPOGAHHJC, new Vector2(665f, NKJPOGAHHJC.rect.y + 1034f), 1085f).APNDGOAIPFJ((DEFBOFIHBCP)(-125));
		}
		GUI.DrawTextureWithTexCoords(new Rect(480f * IBADBOCFCGE, 226f * BPKENGOBCEN - (float)beauty.height * 1894f, (float)beauty.width * 446f, (float)beauty.height * 1573f), beauty, NKJPOGAHHJC.rect);
		if (GUI.Button(GEKOPGDMIKN.MGIOICILLIM(), " height:"))
		{
			LeanTween.alpha(GEKOPGDMIKN, 1086f, 1794f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
			LeanTween.alpha(GEKOPGDMIKN, 1397f, 1514f).IKMKHAAHIMF(1418f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
			LeanTween.alpha(NAEKPPILLNO, 1355f, 190f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic);
			LeanTween.alpha(NAEKPPILLNO, 1318f, 390f).IKMKHAAHIMF(159f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
		}
		GUI.color = new Color(271f, 1970f, 799f, 302f);
		if (GUI.Button(AJLNCPLDLNF.rect, "SCALE"))
		{
			LeanTween.rotate(AJLNCPLDLNF, 515f, 1200f).APNDGOAIPFJ((DEFBOFIHBCP)(-20));
			LeanTween.rotate(AJLNCPLDLNF, 1718f, 1297f).IKMKHAAHIMF(1381f).APNDGOAIPFJ((DEFBOFIHBCP)(-42));
		}
		GUI.matrix = Matrix4x4.identity;
	}

	private void OnGUI()
	{
		GUI.DrawTexture(NAEKPPILLNO.rect, grumpy);
		if (GUI.Button(new Rect(0f * IBADBOCFCGE, 0f * BPKENGOBCEN, 0.2f * IBADBOCFCGE, 0.14f * BPKENGOBCEN), "Move Cat") && !LeanTween.isTweening(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.rect.x, NAEKPPILLNO.rect.y);
			LeanTween.move(NAEKPPILLNO, new Vector2(1f * (float)Screen.width - (float)grumpy.width, 0f * (float)Screen.height), 1f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutBounce).EOAPKBBHBAL(catMoved);
			LeanTween.move(NAEKPPILLNO, hIECNNGMKIE, 1f).IKMKHAAHIMF(1f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutBounce);
		}
		if (GUI.Button(OELDGOLACIF.rect, "Scale Centered"))
		{
			LeanTween.scale(OELDGOLACIF, new Vector2(OELDGOLACIF.rect.width, OELDGOLACIF.rect.height) * 1.2f, 0.25f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
			LeanTween.move(OELDGOLACIF, new Vector2(OELDGOLACIF.rect.x - OELDGOLACIF.rect.width * 0.1f, OELDGOLACIF.rect.y - OELDGOLACIF.rect.height * 0.1f), 0.25f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
		}
		if (GUI.Button(HFNNMDDFJNG.rect, "Scale"))
		{
			LeanTween.scale(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.rect.width, HFNNMDDFJNG.rect.height) * 1.2f, 0.25f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutBounce);
		}
		if (GUI.Button(new Rect(0.76f * IBADBOCFCGE, 0.53f * BPKENGOBCEN, 0.2f * IBADBOCFCGE, 0.14f * BPKENGOBCEN), "Flip Tile"))
		{
			LeanTween.move(NKJPOGAHHJC, new Vector2(0f, NKJPOGAHHJC.rect.y + 1f), 1f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutBounce);
		}
		GUI.DrawTextureWithTexCoords(new Rect(0.8f * IBADBOCFCGE, 0.5f * BPKENGOBCEN - (float)beauty.height * 0.5f, (float)beauty.width * 0.5f, (float)beauty.height * 0.5f), beauty, NKJPOGAHHJC.rect);
		if (GUI.Button(GEKOPGDMIKN.rect, "Alpha"))
		{
			LeanTween.alpha(GEKOPGDMIKN, 0f, 1f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
			LeanTween.alpha(GEKOPGDMIKN, 1f, 1f).IKMKHAAHIMF(1f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
			LeanTween.alpha(NAEKPPILLNO, 0f, 1f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
			LeanTween.alpha(NAEKPPILLNO, 1f, 1f).IKMKHAAHIMF(1f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
		}
		GUI.color = new Color(1f, 1f, 1f, 1f);
		if (GUI.Button(AJLNCPLDLNF.rect, "Rotate"))
		{
			LeanTween.rotate(AJLNCPLDLNF, 150f, 1f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutElastic);
			LeanTween.rotate(AJLNCPLDLNF, 0f, 1f).IKMKHAAHIMF(1f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutElastic);
		}
		GUI.matrix = Matrix4x4.identity;
	}

	private void KBJAFIFPCFN()
	{
		GUI.DrawTexture(NAEKPPILLNO.rect, grumpy);
		if (GUI.Button(new Rect(911f * IBADBOCFCGE, 664f * BPKENGOBCEN, 1336f * IBADBOCFCGE, 710f * BPKENGOBCEN), "ON START WAS CALLED") && !LeanTween.PFHFOIMDJCA(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.rect.x, NAEKPPILLNO.MGIOICILLIM().y);
			LeanTween.EHNNHDJAOCE(NAEKPPILLNO, new Vector2(19f * (float)Screen.width - (float)grumpy.width, 380f * (float)Screen.height), 1609f).APNDGOAIPFJ((DEFBOFIHBCP)(-20)).EOAPKBBHBAL(IDIIGCAEIPH);
			LeanTween.move(NAEKPPILLNO, hIECNNGMKIE, 509f).IKMKHAAHIMF(342f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutSine);
		}
		if (GUI.Button(OELDGOLACIF.rect, "</color>: </b>"))
		{
			LeanTween.scale(OELDGOLACIF, new Vector2(OELDGOLACIF.MGIOICILLIM().width, OELDGOLACIF.IHGLJHFHCCB().height) * 233f, 360f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
			LeanTween.move(OELDGOLACIF, new Vector2(OELDGOLACIF.IHGLJHFHCCB().x - OELDGOLACIF.MGIOICILLIM().width * 102f, OELDGOLACIF.rect.y - OELDGOLACIF.IHGLJHFHCCB().height * 1106f), 1799f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
		}
		if (GUI.Button(HFNNMDDFJNG.rect, "SpherePart"))
		{
			LeanTween.scale(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.rect.width, HFNNMDDFJNG.MGIOICILLIM().height) * 1935f, 99f).APNDGOAIPFJ((DEFBOFIHBCP)(-31));
		}
		if (GUI.Button(new Rect(92f * IBADBOCFCGE, 1440f * BPKENGOBCEN, 222f * IBADBOCFCGE, 661f * BPKENGOBCEN), "EaseInSine"))
		{
			LeanTween.EHNNHDJAOCE(NKJPOGAHHJC, new Vector2(1889f, NKJPOGAHHJC.IHGLJHFHCCB().y + 273f), 1118f).APNDGOAIPFJ((DEFBOFIHBCP)119);
		}
		GUI.DrawTextureWithTexCoords(new Rect(1498f * IBADBOCFCGE, 56f * BPKENGOBCEN - (float)beauty.height * 1826f, (float)beauty.width * 1397f, (float)beauty.height * 484f), beauty, NKJPOGAHHJC.MGIOICILLIM());
		if (GUI.Button(GEKOPGDMIKN.rect, "gameid"))
		{
			LeanTween.alpha(GEKOPGDMIKN, 855f, 1425f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
			LeanTween.alpha(GEKOPGDMIKN, 1658f, 917f).IKMKHAAHIMF(1249f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
			LeanTween.alpha(NAEKPPILLNO, 1712f, 1684f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
			LeanTween.alpha(NAEKPPILLNO, 1091f, 1128f).IKMKHAAHIMF(909f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
		}
		GUI.color = new Color(120f, 206f, 975f, 564f);
		if (GUI.Button(AJLNCPLDLNF.MGIOICILLIM(), "EaseInOutQuart"))
		{
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 617f, 451f).APNDGOAIPFJ((DEFBOFIHBCP)102);
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 1718f, 1023f).IKMKHAAHIMF(960f).APNDGOAIPFJ((DEFBOFIHBCP)(-98));
		}
		GUI.matrix = Matrix4x4.identity;
	}

	private void NHLEGPIPPHA()
	{
		GUI.DrawTexture(NAEKPPILLNO.IHGLJHFHCCB(), grumpy);
		if (GUI.Button(new Rect(220f * IBADBOCFCGE, 742f * BPKENGOBCEN, 1393f * IBADBOCFCGE, 676f * BPKENGOBCEN), "Part") && !LeanTween.isTweening(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.IHGLJHFHCCB().x, NAEKPPILLNO.IHGLJHFHCCB().y);
			LeanTween.move(NAEKPPILLNO, new Vector2(310f * (float)Screen.width - (float)grumpy.width, 172f * (float)Screen.height), 1689f).APNDGOAIPFJ((DEFBOFIHBCP)(-90)).EOAPKBBHBAL(LHFGPHCLOPH);
			LeanTween.EHNNHDJAOCE(NAEKPPILLNO, hIECNNGMKIE, 1355f).IKMKHAAHIMF(1295f).APNDGOAIPFJ((DEFBOFIHBCP)(-30));
		}
		if (GUI.Button(OELDGOLACIF.rect, "cylinder"))
		{
			LeanTween.HFFOCMNDNIH(OELDGOLACIF, new Vector2(OELDGOLACIF.MGIOICILLIM().width, OELDGOLACIF.IHGLJHFHCCB().height) * 834f, 563f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
			LeanTween.move(OELDGOLACIF, new Vector2(OELDGOLACIF.rect.x - OELDGOLACIF.IHGLJHFHCCB().width * 1448f, OELDGOLACIF.IHGLJHFHCCB().y - OELDGOLACIF.rect.height * 1374f), 195f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
		}
		if (GUI.Button(HFNNMDDFJNG.IHGLJHFHCCB(), "Prefabs/"))
		{
			LeanTween.HFFOCMNDNIH(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.rect.width, HFNNMDDFJNG.IHGLJHFHCCB().height) * 389f, 1166f).APNDGOAIPFJ((DEFBOFIHBCP)97);
		}
		if (GUI.Button(new Rect(573f * IBADBOCFCGE, 1691f * BPKENGOBCEN, 453f * IBADBOCFCGE, 1413f * BPKENGOBCEN), "Wood"))
		{
			LeanTween.move(NKJPOGAHHJC, new Vector2(1495f, NKJPOGAHHJC.rect.y + 998f), 1328f).APNDGOAIPFJ((DEFBOFIHBCP)(-11));
		}
		GUI.DrawTextureWithTexCoords(new Rect(1801f * IBADBOCFCGE, 933f * BPKENGOBCEN - (float)beauty.height * 1845f, (float)beauty.width * 777f, (float)beauty.height * 424f), beauty, NKJPOGAHHJC.IHGLJHFHCCB());
		if (GUI.Button(GEKOPGDMIKN.rect, "GameThumbnail"))
		{
			LeanTween.alpha(GEKOPGDMIKN, 1682f, 1313f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
			LeanTween.alpha(GEKOPGDMIKN, 1011f, 1514f).IKMKHAAHIMF(1626f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
			LeanTween.alpha(NAEKPPILLNO, 1395f, 72f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
			LeanTween.alpha(NAEKPPILLNO, 1183f, 1122f).IKMKHAAHIMF(1184f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
		}
		GUI.color = new Color(460f, 260f, 1831f, 1575f);
		if (GUI.Button(AJLNCPLDLNF.rect, "cubeDest"))
		{
			LeanTween.CPMEMEOMHKK(AJLNCPLDLNF, 103f, 1821f).APNDGOAIPFJ((DEFBOFIHBCP)109);
			LeanTween.rotate(AJLNCPLDLNF, 758f, 1526f).IKMKHAAHIMF(808f).APNDGOAIPFJ((DEFBOFIHBCP)(-83));
		}
		GUI.matrix = Matrix4x4.identity;
	}

	private void PAFEGKADFKI()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(718f * IBADBOCFCGE, 1934f * BPKENGOBCEN, 1295f * IBADBOCFCGE, 1421f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(1972f * IBADBOCFCGE, 1424f * BPKENGOBCEN, 916f * IBADBOCFCGE, 225f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(617f * IBADBOCFCGE, 1677f * BPKENGOBCEN, 1650f * IBADBOCFCGE, 1716f * BPKENGOBCEN, 1078f);
		AJLNCPLDLNF = new LTRect(491f * IBADBOCFCGE, 753f * BPKENGOBCEN, 1433f * IBADBOCFCGE, 1151f * BPKENGOBCEN, 1463f, 1342f);
		NAEKPPILLNO = new LTRect(52f * IBADBOCFCGE - (float)grumpy.width * 1683f, 1352f * BPKENGOBCEN - (float)grumpy.height * 1386f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(1554f, 327f, 1941f, 235f);
		LeanTween.move(HFNNMDDFJNG, new Vector2(165f * IBADBOCFCGE, HFNNMDDFJNG.rect.y), 611f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic);
	}

	private void FCDMICFPHPP()
	{
		GUI.DrawTexture(NAEKPPILLNO.MGIOICILLIM(), grumpy);
		if (GUI.Button(new Rect(596f * IBADBOCFCGE, 395f * BPKENGOBCEN, 1963f * IBADBOCFCGE, 758f * BPKENGOBCEN), "final") && !LeanTween.PFHFOIMDJCA(NAEKPPILLNO))
		{
			Vector2 hIECNNGMKIE = new Vector2(NAEKPPILLNO.rect.x, NAEKPPILLNO.MGIOICILLIM().y);
			LeanTween.EHNNHDJAOCE(NAEKPPILLNO, new Vector2(590f * (float)Screen.width - (float)grumpy.width, 1590f * (float)Screen.height), 1984f).APNDGOAIPFJ((DEFBOFIHBCP)(-126)).EOAPKBBHBAL(CCLKNAOJHEC);
			LeanTween.move(NAEKPPILLNO, hIECNNGMKIE, 1247f).IKMKHAAHIMF(13f).APNDGOAIPFJ((DEFBOFIHBCP)(-58));
		}
		if (GUI.Button(OELDGOLACIF.MGIOICILLIM(), "https://superium.net/api/GetCharacterAppearanceById?id="))
		{
			LeanTween.scale(OELDGOLACIF, new Vector2(OELDGOLACIF.rect.width, OELDGOLACIF.MGIOICILLIM().height) * 1720f, 1963f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
			LeanTween.EHNNHDJAOCE(OELDGOLACIF, new Vector2(OELDGOLACIF.rect.x - OELDGOLACIF.rect.width * 1834f, OELDGOLACIF.MGIOICILLIM().y - OELDGOLACIF.rect.height * 610f), 892f).APNDGOAIPFJ(DEFBOFIHBCP.linear);
		}
		if (GUI.Button(HFNNMDDFJNG.IHGLJHFHCCB(), "Part"))
		{
			LeanTween.HFFOCMNDNIH(HFNNMDDFJNG, new Vector2(HFNNMDDFJNG.rect.width, HFNNMDDFJNG.rect.height) * 1928f, 1316f).APNDGOAIPFJ((DEFBOFIHBCP)(-52));
		}
		if (GUI.Button(new Rect(514f * IBADBOCFCGE, 890f * BPKENGOBCEN, 662f * IBADBOCFCGE, 1926f * BPKENGOBCEN), "bSpline"))
		{
			LeanTween.EHNNHDJAOCE(NKJPOGAHHJC, new Vector2(493f, NKJPOGAHHJC.IHGLJHFHCCB().y + 1560f), 231f).APNDGOAIPFJ((DEFBOFIHBCP)(-28));
		}
		GUI.DrawTextureWithTexCoords(new Rect(108f * IBADBOCFCGE, 1746f * BPKENGOBCEN - (float)beauty.height * 1067f, (float)beauty.width * 517f, (float)beauty.height * 1103f), beauty, NKJPOGAHHJC.MGIOICILLIM());
		if (GUI.Button(GEKOPGDMIKN.IHGLJHFHCCB(), "Environment"))
		{
			LeanTween.alpha(GEKOPGDMIKN, 1130f, 1852f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
			LeanTween.alpha(GEKOPGDMIKN, 837f, 1391f).IKMKHAAHIMF(1818f).APNDGOAIPFJ(DEFBOFIHBCP.linear);
			LeanTween.alpha(NAEKPPILLNO, 1053f, 562f).APNDGOAIPFJ(DEFBOFIHBCP.linear);
			LeanTween.alpha(NAEKPPILLNO, 946f, 767f).IKMKHAAHIMF(1188f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
		}
		GUI.color = new Color(1947f, 800f, 668f, 1078f);
		if (GUI.Button(AJLNCPLDLNF.MGIOICILLIM(), "mp_auth"))
		{
			LeanTween.rotate(AJLNCPLDLNF, 243f, 938f).APNDGOAIPFJ((DEFBOFIHBCP)118);
			LeanTween.rotate(AJLNCPLDLNF, 1663f, 261f).IKMKHAAHIMF(1523f).APNDGOAIPFJ((DEFBOFIHBCP)87);
		}
		GUI.matrix = Matrix4x4.identity;
	}

	private void KFFNHFEKOJH()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(1134f * IBADBOCFCGE, 345f * BPKENGOBCEN, 1646f * IBADBOCFCGE, 1146f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(299f * IBADBOCFCGE, 1726f * BPKENGOBCEN, 825f * IBADBOCFCGE, 1902f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(21f * IBADBOCFCGE, 1379f * BPKENGOBCEN, 349f * IBADBOCFCGE, 392f * BPKENGOBCEN, 262f);
		AJLNCPLDLNF = new LTRect(1775f * IBADBOCFCGE, 1535f * BPKENGOBCEN, 1736f * IBADBOCFCGE, 1514f * BPKENGOBCEN, 1112f, 606f);
		NAEKPPILLNO = new LTRect(456f * IBADBOCFCGE - (float)grumpy.width * 1538f, 77f * BPKENGOBCEN - (float)grumpy.height * 62f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(1426f, 1340f, 1697f, 1927f);
		LeanTween.EHNNHDJAOCE(HFNNMDDFJNG, new Vector2(614f * IBADBOCFCGE, HFNNMDDFJNG.MGIOICILLIM().y), 1698f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
	}

	public void catMoved()
	{
		Debug.Log("cat moved...");
	}

	private void HNGCGALADEI()
	{
		IBADBOCFCGE = Screen.width;
		BPKENGOBCEN = Screen.height;
		OELDGOLACIF = new LTRect(1456f * IBADBOCFCGE, 394f * BPKENGOBCEN, 804f * IBADBOCFCGE, 1231f * BPKENGOBCEN);
		HFNNMDDFJNG = new LTRect(1233f * IBADBOCFCGE, 520f * BPKENGOBCEN, 1546f * IBADBOCFCGE, 555f * BPKENGOBCEN);
		GEKOPGDMIKN = new LTRect(1531f * IBADBOCFCGE, 575f * BPKENGOBCEN, 893f * IBADBOCFCGE, 1283f * BPKENGOBCEN, 1393f);
		AJLNCPLDLNF = new LTRect(928f * IBADBOCFCGE, 705f * BPKENGOBCEN, 1501f * IBADBOCFCGE, 1521f * BPKENGOBCEN, 1970f, 1649f);
		NAEKPPILLNO = new LTRect(1470f * IBADBOCFCGE - (float)grumpy.width * 1632f, 1218f * BPKENGOBCEN - (float)grumpy.height * 809f, grumpy.width, grumpy.height);
		NKJPOGAHHJC = new LTRect(1228f, 883f, 42f, 1961f);
		LeanTween.move(HFNNMDDFJNG, new Vector2(1186f * IBADBOCFCGE, HFNNMDDFJNG.IHGLJHFHCCB().y), 1755f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
	}
}
