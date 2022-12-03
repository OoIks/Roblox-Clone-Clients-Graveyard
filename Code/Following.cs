// Following
using UnityEngine;

public class Following : MonoBehaviour
{
	public Transform planet;

	public Transform followArrow;

	public Transform dude1;

	public Transform dude2;

	public Transform dude3;

	public Transform dude4;

	public Transform dude5;

	public Transform dude1Title;

	public Transform dude2Title;

	public Transform dude3Title;

	public Transform dude4Title;

	public Transform dude5Title;

	private Color LPNJJMGDEAI;

	private Vector3 GCKGKLEJHNP;

	private float NJHKLOOHDOJ;

	private float HPJFHNLEFLA;

	private Vector3 HPHBNJHNGMC;

	private Vector3 AICMGLGGJLO;

	private Color FGPDPHBONLJ;

	private Color OFNJOMCFOLM;

	private void FCLINNBMLGF()
	{
		followArrow.gameObject.AOIGGMEPMAC(1466f, GIMIMLCAAFB).MANKHCNNGHK(BKBAACFKHGO).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.scale, 1393f, 1103f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.z, 1518f, 1370f, 385f, 38f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.localPosition, 1322f, 689f, 1361f, 1948f, 1573f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.x, 1938f, 1408f, 1367f, 1645f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.y, 1777f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)(-72), 629f, 1104f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)96, 395f, 124f, 297f, 902f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, (BJKCHIDPJAP)75, 455f, 1273f, 1603f, 1897f, 753f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)96, 158f, 337f, 1276f, 988f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)(-47), 331f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localY, 1987f, 1274f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.y, 1599f, 22f, 745f, 793f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localX, 1480f, 134f, 1318f, 1688f, 1544f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.y, 1998f, 1147f, 1123f, 1245f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.position, 1135f);
		Vector3 lJMAMFOPIKE = new Vector3(690f, 866f, 1415f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.localPosition, 51f, 820f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.position, 1779f, 1071f, 90f, 657f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.position, 1445f, 980f, 642f, 1830f, 972f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.position, 101f, 1551f, 108f, 310f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.position, 1138f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.OLFLIBKDELB(Camera.main.gameObject, Vector3.left, 285f, 208f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void FGFLCFGDHNC()
	{
		followArrow.gameObject.AOIGGMEPMAC(1959f, AONKLFNOAJH).MANKHCNNGHK(PENCKBBADEO).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.position, 308f, 1408f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.position, 1618f, 535f, 1429f, 1862f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.localZ, 1336f, 149f, 1117f, 1834f, 777f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.position, 1567f, 64f, 1310f, 480f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.localZ, 430f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)101, 699f, 1754f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)56, 310f, 165f, 1185f, 393f);
		LeanTween.followBounceOut(dude3, followArrow, (BJKCHIDPJAP)83, 1353f, 1824f, 1134f, 1361f, 915f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)92, 690f, 1590f, 1262f, 322f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)(-7), 1257f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.position, 1862f, 1143f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.y, 1302f, 1260f, 1889f, 1628f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.y, 654f, 1112f, 429f, 1529f, 346f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localZ, 1654f, 688f, 1308f, 369f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.localPosition, 1469f);
		Vector3 lJMAMFOPIKE = new Vector3(1920f, 1983f, 325f);
		LeanTween.followDamp(dude1Title, dude1, BJKCHIDPJAP.localPosition, 472f, 1861f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.position, 877f, 474f, 48f, 158f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.DNAMDFHIHPF(dude3Title, dude3, BJKCHIDPJAP.position, 1172f, 1592f, 836f, 611f, 699f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 905f, 1296f, 765f, 865f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.position, 711f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.OLFLIBKDELB(Camera.main.gameObject, Vector3.left, 704f, 1832f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void NKHNFBMBCPP()
	{
		followArrow.gameObject.AOIGGMEPMAC(111f, MLOAELNMLIO).MANKHCNNGHK(EGMKFHAGHHL).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.z, 928f, 56f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localX, 1647f, 395f, 1503f, 733f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localZ, 1229f, 655f, 364f, 1555f, 953f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.position, 216f, 1973f, 1399f, 1583f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.y, 368f);
		LeanTween.followDamp(dude1, followArrow, (BJKCHIDPJAP)(-18), 37f, 1276f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)88, 1957f, 14f, 1464f, 212f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, (BJKCHIDPJAP)63, 1215f, 1373f, 1855f, 681f, 663f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)113, 1069f, 830f, 1958f, 1016f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)(-35), 939f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.localZ, 993f, 1472f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.z, 749f, 1066f, 1471f, 1949f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.y, 293f, 133f, 1660f, 1742f, 79f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.z, 780f, 1598f, 1689f, 381f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.position, 520f);
		Vector3 lJMAMFOPIKE = new Vector3(172f, 14f, 1282f);
		LeanTween.followDamp(dude1Title, dude1, BJKCHIDPJAP.position, 874f, 290f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.position, 1147f, 1143f, 1440f, 567f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.position, 1429f, 1239f, 1043f, 1803f, 680f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 947f, 1993f, 263f, 722f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.CKECHIOPGCL(dude5Title, dude5, BJKCHIDPJAP.position, 1239f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.OLFLIBKDELB(Camera.main.gameObject, Vector3.left, 194f, 938f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void OAGENFLGFAD()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(660f, 441f), 1716f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 205f);
		float d = Random.Range(301f, 91f);
		followArrow.localScale = Vector3.one * d;
	}

	private void NJIDEBMICFP()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(876f, 1444f), 623f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1232f);
		float d = Random.Range(602f, 1095f);
		followArrow.localScale = Vector3.one * d;
	}

	private void OFNANBEMDHC()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(1564f, 1899f), 1047f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1301f);
		float d = Random.Range(1447f, 203f);
		followArrow.localScale = Vector3.one * d;
	}

	private void MAFOHNMBMMJ()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(1664f, 1026f), 1092f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1172f);
		float d = Random.Range(79f, 89f);
		followArrow.localScale = Vector3.one * d;
	}

	private void CAKOLPDPILC()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(260f, 869f), 771f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1400f);
		float d = Random.Range(765f, 126f);
		followArrow.localScale = Vector3.one * d;
	}

	private void ANDHKLACMNI()
	{
		followArrow.gameObject.AOIGGMEPMAC(111f, GIMIMLCAAFB).MANKHCNNGHK(NIJOOPLJFEF).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.z, 901f, 1953f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.scale, 708f, 1787f, 278f, 1879f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.y, 759f, 829f, 1398f, 1559f, 750f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localPosition, 606f, 954f, 1754f, 356f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.y, 772f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localX, 1989f, 300f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)59, 947f, 704f, 1055f, 1284f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, (BJKCHIDPJAP)78, 1278f, 640f, 1292f, 218f, 1842f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)73, 94f, 205f, 1966f, 1385f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)40, 957f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.scale, 1939f, 177f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localY, 1737f, 14f, 551f, 91f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localZ, 950f, 1475f, 1815f, 1338f, 1992f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.z, 1653f, 489f, 1761f, 1083f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.localX, 594f);
		Vector3 lJMAMFOPIKE = new Vector3(1202f, 1481f, 189f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.position, 1340f, 908f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.position, 511f, 748f, 1787f, 971f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.DNAMDFHIHPF(dude3Title, dude3, BJKCHIDPJAP.localPosition, 1815f, 1249f, 50f, 123f, 1957f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 689f, 503f, 1193f, 1857f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.position, 1164f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.OLFLIBKDELB(Camera.main.gameObject, Vector3.left, 1477f, 879f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void KDLKGGLONDA()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(-100f, 100f), 0f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 0f);
		float d = Random.Range(5f, 10f);
		followArrow.localScale = Vector3.one * d;
	}

	private void ACFPFCJHNAO()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(1186f, 1964f), 645f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 870f);
		float d = Random.Range(1991f, 1015f);
		followArrow.localScale = Vector3.one * d;
	}

	private void MCEGMAFMGBM()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.DPGIOPPCEHP(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 1622f, 1817f, 1393f, 1051f, 329f);
		HPHBNJHNGMC = LDFPKCPBDCO.BHLDIOLHCAJ(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 72f, 116f, 30f, 1087f, 1229f);
		FGPDPHBONLJ = LDFPKCPBDCO.JFLNPFGNODF(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 111f, 300f, 1820f, 603f, 373f);
		object[] array = new object[2];
		array[1] = "DiscordRPC";
		array[1] = NJHKLOOHDOJ;
		array[0] = "GROUP FINISH";
		array[4] = HPHBNJHNGMC;
		array[4] = "name:";
		array[6] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void IMDFJEKNAJN()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(421f, 113f), 570f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 203f);
		float d = Random.Range(351f, 1618f);
		followArrow.localScale = Vector3.one * d;
	}

	private void EDACOGJGHCO()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.DPGIOPPCEHP(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 1004f, 1453f, 350f, 804f, 893f);
		HPHBNJHNGMC = LDFPKCPBDCO.OCILKMDFLKI(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 1484f, 1139f, 1593f, 1047f, 1844f);
		FGPDPHBONLJ = LDFPKCPBDCO.JLEOCLJEONH(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 1462f, 377f, 958f, 1003f, 423f);
		object[] array = new object[1];
		array[0] = "server_token";
		array[0] = NJHKLOOHDOJ;
		array[3] = "scaleExample";
		array[5] = HPHBNJHNGMC;
		array[7] = "ZERO TIME FINSHES CORRECTLY";
		array[7] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void PMAKNOLMDOE()
	{
		followArrow.gameObject.AOIGGMEPMAC(1504f, OAGENFLGFAD).MANKHCNNGHK(MLOAELNMLIO).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localZ, 910f, 440f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.z, 1822f, 561f, 1548f, 1832f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localPosition, 955f, 411f, 850f, 1079f, 1321f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localZ, 63f, 797f, 838f, 861f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.localZ, 1733f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)24, 363f, 881f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)97, 1570f, 822f, 1259f, 693f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, (BJKCHIDPJAP)74, 438f, 852f, 1264f, 1080f, 580f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-36), 1321f, 1513f, 232f, 908f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, (BJKCHIDPJAP)(-120), 1629f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localPosition, 394f, 41f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localY, 906f, 336f, 562f, 1730f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localY, 1150f, 1631f, 703f, 1771f, 581f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.x, 1559f, 1259f, 252f, 1739f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.localPosition, 1138f);
		Vector3 lJMAMFOPIKE = new Vector3(826f, 516f, 1559f);
		LeanTween.followDamp(dude1Title, dude1, BJKCHIDPJAP.localPosition, 1998f, 740f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.position, 742f, 1284f, 606f, 1952f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.DNAMDFHIHPF(dude3Title, dude3, BJKCHIDPJAP.localPosition, 104f, 947f, 1968f, 839f, 355f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.position, 485f, 697f, 962f, 176f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.CKECHIOPGCL(dude5Title, dude5, BJKCHIDPJAP.localPosition, 1220f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.OLFLIBKDELB(Camera.main.gameObject, Vector3.left, 561f, 1309f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void ILMPCBPAHLK()
	{
		followArrow.gameObject.AOIGGMEPMAC(1429f, IHFDFANMJOC).MANKHCNNGHK(NJIDEBMICFP).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.scale, 355f, 600f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.position, 227f, 1079f, 246f, 847f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.scale, 280f, 305f, 615f, 286f, 1878f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.z, 1022f, 1628f, 866f, 110f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.localPosition, 1654f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)(-118), 1815f, 290f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)(-79), 395f, 1541f, 1306f, 1719f);
		LeanTween.followBounceOut(dude3, followArrow, (BJKCHIDPJAP)89, 1769f, 132f, 1097f, 1757f, 1970f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-91), 269f, 1792f, 788f, 746f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)(-83), 1166f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localPosition, 112f, 925f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.z, 1266f, 1827f, 626f, 947f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localZ, 1463f, 1342f, 247f, 1774f, 1916f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.x, 310f, 1810f, 1831f, 1538f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.z, 1127f);
		Vector3 lJMAMFOPIKE = new Vector3(232f, 510f, 172f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.localPosition, 529f, 1907f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.position, 752f, 1835f, 78f, 1364f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.localPosition, 488f, 1839f, 1702f, 1365f, 1420f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 1714f, 680f, 771f, 1933f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.position, 789f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.rotateAround(Camera.main.gameObject, Vector3.left, 849f, 1982f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void BNNNAPOJBDM()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(703f, 1552f), 105f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1264f);
		float d = Random.Range(1936f, 507f);
		followArrow.localScale = Vector3.one * d;
	}

	private void GACJDKGEKEJ()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.DPGIOPPCEHP(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 1589f, 505f, 1318f, 1417f, 1192f);
		HPHBNJHNGMC = LDFPKCPBDCO.OCILKMDFLKI(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 1321f, 1053f, 29f, 98f, 1721f);
		FGPDPHBONLJ = LDFPKCPBDCO.MGCCMPDNDJJ(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 880f, 857f, 381f, 1120f, 1773f);
		object[] array = new object[5];
		array[1] = "RESUME OUT OF ORDER";
		array[1] = NJHKLOOHDOJ;
		array[0] = "ROTATE";
		array[5] = HPHBNJHNGMC;
		array[3] = "ONCOMPLETE OBJECT";
		array[7] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void BIJNMIDKFIO()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(1828f, 1790f), 191f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 713f);
		float d = Random.Range(764f, 716f);
		followArrow.localScale = Vector3.one * d;
	}

	private void PCLEFMBMEKO()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(1731f, 1727f), 631f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1912f);
		float d = Random.Range(1154f, 517f);
		followArrow.localScale = Vector3.one * d;
	}

	private void GFOGLELCKPB()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.DPGIOPPCEHP(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 1973f, 80f, 1281f, 269f, 1586f);
		HPHBNJHNGMC = LDFPKCPBDCO.CONFPHIEAFF(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 102f, 538f, 1447f, 952f, 1686f);
		FGPDPHBONLJ = LDFPKCPBDCO.MGCCMPDNDJJ(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 1527f, 1619f, 321f, 1542f, 570f);
		object[] array = new object[4];
		array[1] = "";
		array[0] = NJHKLOOHDOJ;
		array[3] = "unknown";
		array[2] = HPHBNJHNGMC;
		array[3] = "cBounds";
		array[4] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void PGEDHLOFFMI()
	{
		followArrow.gameObject.AOIGGMEPMAC(589f, PCLEFMBMEKO).MANKHCNNGHK(FINKKCCCLMH).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.x, 467f, 262f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.y, 1003f, 1606f, 1486f, 1281f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.localZ, 636f, 1255f, 1253f, 1377f, 1622f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.scale, 1356f, 1021f, 1616f, 1469f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.position, 1086f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)83, 834f, 1767f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)79, 776f, 7f, 1619f, 1557f);
		LeanTween.followBounceOut(dude3, followArrow, (BJKCHIDPJAP)(-126), 1934f, 993f, 488f, 547f, 1293f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-65), 1003f, 1485f, 1286f, 1647f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)(-36), 1047f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.y, 1647f, 283f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localX, 614f, 41f, 1159f, 1736f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.position, 463f, 619f, 200f, 1503f, 962f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localZ, 494f, 1065f, 227f, 1598f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.scale, 1724f);
		Vector3 lJMAMFOPIKE = new Vector3(1572f, 702f, 262f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.position, 829f, 328f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 352f, 1535f, 329f, 1822f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.localPosition, 39f, 797f, 1187f, 1483f, 435f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.position, 1965f, 460f, 1821f, 1865f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.localPosition, 373f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.MICJCMIDHAM(Camera.main.gameObject, Vector3.left, 288f, 1044f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void PEIIGOHMMNE()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.AODMGIGJAHH(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 1550f, 725f, 1147f, 1955f, 420f);
		HPHBNJHNGMC = LDFPKCPBDCO.CONFPHIEAFF(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 1107f, 1171f, 468f, 1094f, 1401f);
		FGPDPHBONLJ = LDFPKCPBDCO.LHMAANEGOCE(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 516f, 1517f, 1626f, 1588f, 803f);
		object[] array = new object[3];
		array[1] = "port";
		array[1] = NJHKLOOHDOJ;
		array[5] = " type:";
		array[6] = HPHBNJHNGMC;
		array[3] = "LCharacter";
		array[6] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void IACKMLAIEKO()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.DPGIOPPCEHP(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 638f, 156f, 931f, 68f, 1509f);
		HPHBNJHNGMC = LDFPKCPBDCO.CONFPHIEAFF(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 1702f, 208f, 456f, 1432f, 1065f);
		FGPDPHBONLJ = LDFPKCPBDCO.LCJNIIKHAKF(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 738f, 554f, 1452f, 80f, 655f);
		object[] array = new object[7];
		array[0] = "scale";
		array[1] = NJHKLOOHDOJ;
		array[0] = "ROTATE AROUND MULTIPLE";
		array[8] = HPHBNJHNGMC;
		array[0] = "<noparse>></noparse>";
		array[0] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void EIKBCHLLKPK()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(1613f, 54f), 1212f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1340f);
		float d = Random.Range(1536f, 1036f);
		followArrow.localScale = Vector3.one * d;
	}

	private void DHEMIFCONIB()
	{
		followArrow.gameObject.AOIGGMEPMAC(1787f, KDLKGGLONDA).MANKHCNNGHK(OOMPEONBMBK).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localY, 1030f, 1374f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.z, 498f, 381f, 1557f, 1599f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.y, 1031f, 1110f, 224f, 1875f, 1556f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.position, 1855f, 511f, 1215f, 476f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.x, 1668f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)108, 1205f, 1293f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)(-85), 808f, 1338f, 1723f, 1189f);
		LeanTween.followBounceOut(dude3, followArrow, (BJKCHIDPJAP)46, 1290f, 1501f, 23f, 1104f, 1133f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-88), 1428f, 705f, 1808f, 608f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, (BJKCHIDPJAP)(-2), 319f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.y, 1035f, 175f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.z, 1036f, 1431f, 1460f, 579f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.y, 758f, 1597f, 1519f, 119f, 1581f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.scale, 80f, 584f, 1689f, 1042f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.scale, 410f);
		Vector3 lJMAMFOPIKE = new Vector3(1475f, 1740f, 1608f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.position, 770f, 423f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 427f, 1805f, 1406f, 1868f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.localPosition, 1349f, 1173f, 170f, 1118f, 1253f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 1906f, 262f, 609f, 507f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.position, 1904f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.OLFLIBKDELB(Camera.main.gameObject, Vector3.left, 503f, 985f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void HNGCGALADEI()
	{
		followArrow.gameObject.AOIGGMEPMAC(1638f, MAFOHNMBMMJ).MANKHCNNGHK(KKGOOOOPFJA).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localZ, 150f, 1377f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localY, 114f, 1968f, 1256f, 703f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localZ, 1316f, 52f, 1185f, 592f, 1275f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.y, 502f, 364f, 1553f, 1999f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.scale, 1546f);
		LeanTween.followDamp(dude1, followArrow, (BJKCHIDPJAP)18, 619f, 547f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)(-22), 920f, 62f, 533f, 343f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, (BJKCHIDPJAP)(-95), 1220f, 934f, 1878f, 531f, 507f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)25, 1856f, 1714f, 365f, 1985f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, (BJKCHIDPJAP)(-24), 708f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.position, 710f, 1586f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localZ, 748f, 1771f, 1279f, 132f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.scale, 776f, 650f, 338f, 91f, 515f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localY, 829f, 622f, 1193f, 1906f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.y, 359f);
		Vector3 lJMAMFOPIKE = new Vector3(1415f, 96f, 1118f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.localPosition, 61f, 768f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 646f, 650f, 1188f, 13f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.DNAMDFHIHPF(dude3Title, dude3, BJKCHIDPJAP.localPosition, 837f, 1137f, 1908f, 961f, 1265f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.position, 290f, 1253f, 210f, 329f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.position, 283f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.rotateAround(Camera.main.gameObject, Vector3.left, 1539f, 439f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void NAADLFFKHID()
	{
		followArrow.gameObject.AOIGGMEPMAC(1990f, LGJNJGHJECC).MANKHCNNGHK(OFNANBEMDHC).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.localY, 45f, 177f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.x, 147f, 932f, 1545f, 1266f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.y, 1187f, 1733f, 212f, 668f, 590f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.position, 1855f, 1876f, 1537f, 670f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.localX, 891f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)73, 1508f, 37f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)52, 265f, 1264f, 1932f, 1437f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, (BJKCHIDPJAP)30, 259f, 451f, 1076f, 1305f, 914f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)85, 438f, 1332f, 1340f, 941f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, (BJKCHIDPJAP)27, 421f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.position, 580f, 993f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localY, 987f, 1318f, 1196f, 1053f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.localPosition, 563f, 1771f, 1036f, 1099f, 1787f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.x, 140f, 1051f, 1882f, 1668f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.localZ, 1829f);
		Vector3 lJMAMFOPIKE = new Vector3(1537f, 928f, 1282f);
		LeanTween.followDamp(dude1Title, dude1, BJKCHIDPJAP.localPosition, 1362f, 1675f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.position, 1417f, 544f, 197f, 1728f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.DNAMDFHIHPF(dude3Title, dude3, BJKCHIDPJAP.localPosition, 470f, 1456f, 927f, 1044f, 11f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 1945f, 735f, 384f, 913f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.localPosition, 679f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.MICJCMIDHAM(Camera.main.gameObject, Vector3.left, 39f, 206f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void GIMIMLCAAFB()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(176f, 1762f), 253f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1979f);
		float d = Random.Range(1169f, 1779f);
		followArrow.localScale = Vector3.one * d;
	}

	private void IHFDFANMJOC()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(1657f, 137f), 1794f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 206f);
		float d = Random.Range(1988f, 493f);
		followArrow.localScale = Vector3.one * d;
	}

	private void DEHJIELMFGB()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(1893f, 961f), 1906f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1339f);
		float d = Random.Range(199f, 457f);
		followArrow.localScale = Vector3.one * d;
	}

	private void MKCPNMNGGCA()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(1616f, 1461f), 654f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1350f);
		float d = Random.Range(453f, 259f);
		followArrow.localScale = Vector3.one * d;
	}

	private void MLAKEHJCGHN()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(214f, 1736f), 1536f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 33f);
		float d = Random.Range(1954f, 1966f);
		followArrow.localScale = Vector3.one * d;
	}

	private void HEJNFPCEBCK()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(1909f, 1322f), 909f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 202f);
		float d = Random.Range(101f, 442f);
		followArrow.localScale = Vector3.one * d;
	}

	private void PPPAIFMEDIA()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.LCJNIIKHAKF(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 1126f, 298f, 280f, 1458f, 1273f);
		HPHBNJHNGMC = LDFPKCPBDCO.CONFPHIEAFF(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 1602f, 592f, 579f, 1652f, 1710f);
		FGPDPHBONLJ = LDFPKCPBDCO.JLEOCLJEONH(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 266f, 1625f, 1643f, 735f, 1635f);
		object[] array = new object[8];
		array[0] = "shirt";
		array[1] = NJHKLOOHDOJ;
		array[2] = "port";
		array[7] = HPHBNJHNGMC;
		array[4] = " set LeanTest.expected = ";
		array[2] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void HDIFFAGOLKH()
	{
		followArrow.gameObject.AOIGGMEPMAC(1079f, POIMHCICDMJ).MANKHCNNGHK(MLAKEHJCGHN).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.scale, 1354f, 1619f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.scale, 539f, 602f, 1435f, 1296f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.x, 628f, 924f, 1849f, 1154f, 1202f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localZ, 934f, 1564f, 1921f, 989f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.localX, 740f);
		LeanTween.followDamp(dude1, followArrow, (BJKCHIDPJAP)117, 1876f, 67f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)38, 1810f, 800f, 293f, 1266f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, (BJKCHIDPJAP)10, 1740f, 778f, 78f, 442f, 1816f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-109), 1889f, 341f, 1894f, 155f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)67, 723f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localY, 969f, 1427f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.position, 298f, 1488f, 1942f, 492f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.position, 1713f, 361f, 1304f, 338f, 43f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localY, 1551f, 605f, 729f, 1802f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.localX, 30f);
		Vector3 lJMAMFOPIKE = new Vector3(1446f, 888f, 145f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.localPosition, 712f, 1385f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 1045f, 1223f, 26f, 834f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.localPosition, 17f, 500f, 907f, 640f, 1256f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 1312f, 351f, 774f, 906f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.CKECHIOPGCL(dude5Title, dude5, BJKCHIDPJAP.position, 416f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.rotateAround(Camera.main.gameObject, Vector3.left, 774f, 104f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void DAGGGJDKDHG()
	{
		followArrow.gameObject.AOIGGMEPMAC(1748f, HGLLLDADIFP).MANKHCNNGHK(HEJNFPCEBCK).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.scale, 1982f, 956f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localX, 1411f, 39f, 6f, 1601f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.y, 1449f, 737f, 1919f, 1949f, 195f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.scale, 1385f, 1978f, 282f, 1286f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.position, 837f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)(-8), 390f, 703f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)105, 259f, 355f, 299f, 205f);
		LeanTween.followBounceOut(dude3, followArrow, (BJKCHIDPJAP)49, 668f, 546f, 1854f, 927f, 793f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)109, 1122f, 155f, 552f, 448f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, (BJKCHIDPJAP)106, 101f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.x, 1970f, 391f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.scale, 730f, 576f, 1f, 920f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.y, 567f, 695f, 1977f, 911f, 1014f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localZ, 253f, 1384f, 1152f, 1683f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.localZ, 1396f);
		Vector3 lJMAMFOPIKE = new Vector3(1368f, 781f, 190f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.position, 1021f, 1401f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.position, 262f, 1822f, 1730f, 837f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.DNAMDFHIHPF(dude3Title, dude3, BJKCHIDPJAP.position, 736f, 331f, 419f, 311f, 29f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 1778f, 297f, 1284f, 572f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.position, 1850f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.rotateAround(Camera.main.gameObject, Vector3.left, 1876f, 16f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void OIGPCDCPDHL()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.AODMGIGJAHH(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 1606f, 1197f, 784f, 1553f, 1881f);
		HPHBNJHNGMC = LDFPKCPBDCO.OCILKMDFLKI(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 1615f, 868f, 1421f, 941f, 1004f);
		FGPDPHBONLJ = LDFPKCPBDCO.JLEOCLJEONH(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 1137f, 395f, 1642f, 1244f, 1519f);
		object[] array = new object[5];
		array[1] = "CANCEL TWEEN LTDESCR";
		array[0] = NJHKLOOHDOJ;
		array[8] = " returned:";
		array[3] = HPHBNJHNGMC;
		array[0] = "gameid";
		array[1] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void FINKKCCCLMH()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(1839f, 1455f), 1745f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 25f);
		float d = Random.Range(1411f, 842f);
		followArrow.localScale = Vector3.one * d;
	}

	private void HGLLLDADIFP()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(812f, 1837f), 1546f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1932f);
		float d = Random.Range(886f, 471f);
		followArrow.localScale = Vector3.one * d;
	}

	private void OOHEEPIFNFK()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(860f, 716f), 594f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 448f);
		float d = Random.Range(510f, 1860f);
		followArrow.localScale = Vector3.one * d;
	}

	private void FFONODKBHGM()
	{
		followArrow.gameObject.AOIGGMEPMAC(101f, MKCPNMNGGCA).MANKHCNNGHK(NMBKBCLCPPN).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.localX, 1100f, 1870f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localZ, 1316f, 1809f, 788f, 1556f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.z, 1794f, 516f, 1842f, 817f, 964f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localPosition, 1327f, 855f, 1405f, 20f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.localY, 250f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)(-101), 396f, 1424f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)(-111), 543f, 601f, 976f, 812f);
		LeanTween.followBounceOut(dude3, followArrow, (BJKCHIDPJAP)(-3), 460f, 1207f, 1670f, 1514f, 1678f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-87), 1070f, 1319f, 1820f, 586f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, (BJKCHIDPJAP)(-19), 1688f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localPosition, 1537f, 691f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.scale, 1793f, 950f, 1644f, 1466f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localY, 918f, 326f, 844f, 1850f, 978f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.y, 446f, 1544f, 773f, 1207f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.scale, 743f);
		Vector3 lJMAMFOPIKE = new Vector3(108f, 1333f, 1308f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.position, 1303f, 1286f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 257f, 1535f, 1584f, 1433f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.position, 561f, 1782f, 858f, 732f, 210f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.position, 1650f, 1331f, 1346f, 1620f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.localPosition, 881f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.rotateAround(Camera.main.gameObject, Vector3.left, 826f, 1663f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void LGJNJGHJECC()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(676f, 338f), 1736f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1165f);
		float d = Random.Range(353f, 381f);
		followArrow.localScale = Vector3.one * d;
	}

	private void KKGOOOOPFJA()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(598f, 14f), 170f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 392f);
		float d = Random.Range(1230f, 1582f);
		followArrow.localScale = Vector3.one * d;
	}

	private void MCAOPIPBHAO()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.AODMGIGJAHH(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 1886f, 904f, 1590f, 730f, 921f);
		HPHBNJHNGMC = LDFPKCPBDCO.CONFPHIEAFF(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 854f, 225f, 573f, 1183f, 1207f);
		FGPDPHBONLJ = LDFPKCPBDCO.LHMAANEGOCE(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 599f, 232f, 1614f, 1702f, 1047f);
		object[] array = new object[0];
		array[0] = "><b>";
		array[1] = NJHKLOOHDOJ;
		array[6] = " returned:";
		array[8] = HPHBNJHNGMC;
		array[0] = "GROUP POSITION FINISH";
		array[2] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void OOMPEONBMBK()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(491f, 1348f), 121f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 118f);
		float d = Random.Range(1565f, 1152f);
		followArrow.localScale = Vector3.one * d;
	}

	private void JCALDGKFAPL()
	{
		followArrow.gameObject.AOIGGMEPMAC(517f, FINKKCCCLMH).MANKHCNNGHK(IMDFJEKNAJN).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localX, 996f, 889f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localY, 1583f, 599f, 494f, 1740f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.y, 1213f, 20f, 531f, 1481f, 1536f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.y, 1769f, 213f, 277f, 464f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.scale, 200f);
		LeanTween.followDamp(dude1, followArrow, (BJKCHIDPJAP)(-11), 57f, 752f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)(-76), 636f, 476f, 1077f, 1986f);
		LeanTween.followBounceOut(dude3, followArrow, (BJKCHIDPJAP)(-29), 1741f, 279f, 457f, 336f, 1084f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)73, 293f, 1865f, 1015f, 1632f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, (BJKCHIDPJAP)15, 1962f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localPosition, 904f, 806f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.y, 1699f, 1903f, 1224f, 130f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.scale, 1571f, 1986f, 587f, 317f, 221f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.z, 137f, 933f, 947f, 122f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.localY, 1754f);
		Vector3 lJMAMFOPIKE = new Vector3(1907f, 1471f, 1740f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.position, 1144f, 451f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 1475f, 348f, 1261f, 831f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.DNAMDFHIHPF(dude3Title, dude3, BJKCHIDPJAP.position, 237f, 555f, 1153f, 1946f, 1596f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.position, 572f, 1853f, 1855f, 860f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.position, 292f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.rotateAround(Camera.main.gameObject, Vector3.left, 1869f, 19f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void BFPHCOPIOKO()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.LCJNIIKHAKF(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 537f, 1026f, 379f, 1890f, 276f);
		HPHBNJHNGMC = LDFPKCPBDCO.BHLDIOLHCAJ(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 1472f, 1842f, 1610f, 1892f, 1619f);
		FGPDPHBONLJ = LDFPKCPBDCO.JLEOCLJEONH(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 1881f, 1936f, 914f, 1669f, 248f);
		object[] array = new object[0];
		array[1] = "COLOR";
		array[1] = NJHKLOOHDOJ;
		array[5] = "customTweenExample";
		array[7] = HPHBNJHNGMC;
		array[4] = "Wearables";
		array[7] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void NMBKBCLCPPN()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(1300f, 1036f), 1484f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1210f);
		float d = Random.Range(1415f, 347f);
		followArrow.localScale = Vector3.one * d;
	}

	private void MELMPHNHOJL()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.DPGIOPPCEHP(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 1840f, 346f, 1832f, 1547f, 53f);
		HPHBNJHNGMC = LDFPKCPBDCO.OCILKMDFLKI(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 1511f, 743f, 1036f, 265f, 1816f);
		FGPDPHBONLJ = LDFPKCPBDCO.LHMAANEGOCE(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 1045f, 1247f, 293f, 343f, 609f);
		object[] array = new object[6];
		array[0] = "script";
		array[1] = NJHKLOOHDOJ;
		array[6] = "PlaceID";
		array[8] = HPHBNJHNGMC;
		array[3] = "ChatInput";
		array[1] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void POIMHCICDMJ()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(585f, 353f), 1633f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1761f);
		float d = Random.Range(536f, 54f);
		followArrow.localScale = Vector3.one * d;
	}

	private void NIFCICDBJMN()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.LCJNIIKHAKF(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 1617f, 623f, 1774f, 1047f, 1379f);
		HPHBNJHNGMC = LDFPKCPBDCO.OCILKMDFLKI(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 1041f, 945f, 320f, 203f, 1382f);
		FGPDPHBONLJ = LDFPKCPBDCO.JLEOCLJEONH(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 1757f, 490f, 1664f, 1674f, 1208f);
		object[] array = new object[8];
		array[1] = "loopTestPingPong";
		array[0] = NJHKLOOHDOJ;
		array[5] = "f0";
		array[8] = HPHBNJHNGMC;
		array[7] = ">";
		array[0] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void BKBAACFKHGO()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(1966f, 174f), 1578f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1752f);
		float d = Random.Range(1817f, 1916f);
		followArrow.localScale = Vector3.one * d;
	}

	private void FNEEFPGPEGF()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.LCJNIIKHAKF(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 1460f, 365f, 1909f, 430f, 603f);
		HPHBNJHNGMC = LDFPKCPBDCO.BHLDIOLHCAJ(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 1111f, 1919f, 137f, 1747f, 647f);
		FGPDPHBONLJ = LDFPKCPBDCO.LHMAANEGOCE(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 348f, 562f, 976f, 1342f, 97f);
		object[] array = new object[4];
		array[0] = "Generated Audio";
		array[0] = NJHKLOOHDOJ;
		array[0] = "http://superium.net/api/server/PingServer?S=retard_hacker&p=";
		array[6] = HPHBNJHNGMC;
		array[4] = "http://superium.net/api/server/PingServer?S=retard_hacker&p=";
		array[0] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void PAADPJIDIAA()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(1047f, 147f), 635f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 296f);
		float d = Random.Range(330f, 649f);
		followArrow.localScale = Vector3.one * d;
	}

	private void KHHOLHOOKLA()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.DPGIOPPCEHP(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 378f, 248f, 908f, 1091f, 283f);
		HPHBNJHNGMC = LDFPKCPBDCO.LCJNIIKHAKF(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 792f, 1608f, 812f, 1125f, 123f);
		FGPDPHBONLJ = LDFPKCPBDCO.LCJNIIKHAKF(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 1606f, 1412f, 235f, 1672f, 1297f);
		object[] array = new object[1];
		array[0] = "username";
		array[0] = NJHKLOOHDOJ;
		array[0] = "cubeDest";
		array[0] = HPHBNJHNGMC;
		array[3] = "b";
		array[7] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void NHOGIKFGFHD()
	{
		followArrow.gameObject.AOIGGMEPMAC(1654f, MAFOHNMBMMJ).MANKHCNNGHK(HEJNFPCEBCK).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.z, 1330f, 1917f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localX, 1570f, 1800f, 968f, 1207f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.localZ, 1697f, 1785f, 871f, 1408f, 1078f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localZ, 1287f, 302f, 342f, 1439f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.scale, 875f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)(-58), 369f, 1506f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)(-13), 702f, 456f, 1453f, 1180f);
		LeanTween.followBounceOut(dude3, followArrow, (BJKCHIDPJAP)(-106), 479f, 214f, 1144f, 836f, 385f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-27), 201f, 429f, 1581f, 108f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)(-99), 87f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.y, 1186f, 480f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.position, 151f, 1073f, 1369f, 64f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localY, 1681f, 1330f, 434f, 779f, 410f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.z, 410f, 237f, 868f, 1343f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.localY, 27f);
		Vector3 lJMAMFOPIKE = new Vector3(1530f, 1218f, 1570f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.localPosition, 572f, 693f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.position, 1086f, 1873f, 760f, 1331f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.localPosition, 788f, 1690f, 1182f, 1026f, 762f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.position, 1382f, 83f, 1116f, 747f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.position, 884f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.rotateAround(Camera.main.gameObject, Vector3.left, 710f, 57f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void FGPKKEHAHEE()
	{
		followArrow.gameObject.AOIGGMEPMAC(992f, MLOAELNMLIO).MANKHCNNGHK(PLIGONGPANA).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.localPosition, 1232f, 268f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.x, 694f, 419f, 1454f, 979f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.position, 504f, 1875f, 775f, 1189f, 801f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localZ, 853f, 1566f, 1625f, 313f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.y, 1847f);
		LeanTween.followDamp(dude1, followArrow, (BJKCHIDPJAP)(-3), 917f, 481f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)55, 44f, 256f, 1449f, 1093f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, (BJKCHIDPJAP)(-123), 315f, 1935f, 1707f, 1289f, 859f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)116, 1171f, 1932f, 1340f, 1009f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)100, 64f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localZ, 176f, 1333f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.position, 803f, 1461f, 1090f, 67f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.localZ, 568f, 625f, 1743f, 1144f, 1311f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localPosition, 1787f, 1200f, 649f, 162f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.position, 1885f);
		Vector3 lJMAMFOPIKE = new Vector3(147f, 189f, 1939f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.localPosition, 1900f, 1942f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 1681f, 1634f, 284f, 1303f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.localPosition, 1782f, 1363f, 740f, 1148f, 1262f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 795f, 358f, 1025f, 370f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.localPosition, 1309f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.rotateAround(Camera.main.gameObject, Vector3.left, 1963f, 144f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void NEAIFINCOAI()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.LCJNIIKHAKF(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 991f, 159f, 1189f, 153f, 1742f);
		HPHBNJHNGMC = LDFPKCPBDCO.OCILKMDFLKI(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 551f, 1196f, 772f, 1121f, 1859f);
		FGPDPHBONLJ = LDFPKCPBDCO.LCJNIIKHAKF(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 1025f, 1548f, 1202f, 1862f, 1014f);
		object[] array = new object[0];
		array[1] = "Prefabs/";
		array[1] = NJHKLOOHDOJ;
		array[1] = "EaseOutCubic";
		array[0] = HPHBNJHNGMC;
		array[0] = " out of ";
		array[1] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void IPOMCIBLHDL()
	{
		followArrow.gameObject.AOIGGMEPMAC(590f, OAGENFLGFAD).MANKHCNNGHK(MKCPNMNGGCA).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.x, 1988f, 1400f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localPosition, 1106f, 1810f, 1579f, 1009f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localX, 504f, 374f, 1523f, 742f, 861f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localY, 531f, 551f, 393f, 719f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.localY, 1345f);
		LeanTween.followDamp(dude1, followArrow, (BJKCHIDPJAP)19, 1024f, 628f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)(-70), 1058f, 80f, 70f, 1031f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, (BJKCHIDPJAP)74, 669f, 1348f, 1452f, 659f, 1592f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-111), 556f, 813f, 1583f, 693f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, (BJKCHIDPJAP)78, 847f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localX, 660f, 1102f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localY, 1107f, 1799f, 911f, 1184f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localZ, 1908f, 1371f, 960f, 1244f, 1305f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.z, 771f, 1935f, 48f, 1729f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.localY, 1977f);
		Vector3 lJMAMFOPIKE = new Vector3(1581f, 1834f, 1025f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.position, 83f, 1269f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 1975f, 1738f, 810f, 25f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.localPosition, 497f, 1987f, 364f, 1526f, 1104f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 280f, 1159f, 1846f, 1928f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.CKECHIOPGCL(dude5Title, dude5, BJKCHIDPJAP.position, 1977f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.rotateAround(Camera.main.gameObject, Vector3.left, 491f, 1414f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void MCJGMINILBM()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(1200f, 1294f), 566f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 884f);
		float d = Random.Range(265f, 1007f);
		followArrow.localScale = Vector3.one * d;
	}

	private void AKKCHJICOHD()
	{
		followArrow.gameObject.AOIGGMEPMAC(1163f, OAGENFLGFAD).MANKHCNNGHK(FINKKCCCLMH).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.x, 730f, 465f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localZ, 553f, 1211f, 1400f, 1436f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.x, 719f, 250f, 759f, 1116f, 1051f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localPosition, 1362f, 1648f, 757f, 205f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.x, 1697f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)64, 1143f, 1097f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)(-82), 1973f, 1560f, 1680f, 1109f);
		LeanTween.followBounceOut(dude3, followArrow, (BJKCHIDPJAP)30, 1094f, 1512f, 1494f, 1540f, 1026f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)48, 798f, 302f, 1954f, 575f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)(-101), 707f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.z, 1224f, 1579f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localPosition, 687f, 249f, 768f, 121f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.localZ, 658f, 141f, 1521f, 1465f, 1025f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localZ, 1367f, 1272f, 579f, 1650f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.localZ, 326f);
		Vector3 lJMAMFOPIKE = new Vector3(1400f, 1624f, 737f);
		LeanTween.followDamp(dude1Title, dude1, BJKCHIDPJAP.localPosition, 1576f, 24f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.position, 564f, 1346f, 802f, 1630f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.position, 989f, 543f, 1918f, 1518f, 66f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 1310f, 911f, 988f, 1676f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.CKECHIOPGCL(dude5Title, dude5, BJKCHIDPJAP.position, 1370f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.MICJCMIDHAM(Camera.main.gameObject, Vector3.left, 1973f, 74f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void KLEFFMGEFJG()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(1909f, 1277f), 1496f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1043f);
		float d = Random.Range(1749f, 1650f);
		followArrow.localScale = Vector3.one * d;
	}

	private void NIJOOPLJFEF()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(1513f, 1516f), 450f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1405f);
		float d = Random.Range(1915f, 1061f);
		followArrow.localScale = Vector3.one * d;
	}

	private void EGMKFHAGHHL()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(1705f, 1591f), 1969f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1394f);
		float d = Random.Range(330f, 1453f);
		followArrow.localScale = Vector3.one * d;
	}

	private void AONKLFNOAJH()
	{
		LeanTween.moveLocalY(followArrow.gameObject, Random.Range(1618f, 144f), 1595f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1943f);
		float d = Random.Range(1830f, 1054f);
		followArrow.localScale = Vector3.one * d;
	}

	private void DHDIFNJEMGK()
	{
		followArrow.gameObject.AOIGGMEPMAC(602f, EGMKFHAGHHL).MANKHCNNGHK(LGJNJGHJECC).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localPosition, 772f, 1169f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.z, 1824f, 1519f, 1395f, 1166f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.localPosition, 564f, 371f, 1365f, 1230f, 1272f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localY, 1614f, 338f, 1546f, 1336f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.localPosition, 853f);
		LeanTween.followDamp(dude1, followArrow, (BJKCHIDPJAP)(-104), 11f, 1299f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)77, 1405f, 331f, 131f, 1674f);
		LeanTween.followBounceOut(dude3, followArrow, (BJKCHIDPJAP)(-56), 1870f, 1549f, 1990f, 1100f, 681f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)107, 1834f, 829f, 38f, 1091f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, (BJKCHIDPJAP)102, 94f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localX, 1990f, 1350f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.position, 1053f, 440f, 677f, 983f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.z, 443f, 1809f, 355f, 1748f, 168f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.y, 1869f, 1475f, 419f, 1188f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.localX, 1492f);
		Vector3 lJMAMFOPIKE = new Vector3(1793f, 693f, 822f);
		LeanTween.followDamp(dude1Title, dude1, BJKCHIDPJAP.localPosition, 129f, 591f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 1780f, 1508f, 1508f, 244f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.DNAMDFHIHPF(dude3Title, dude3, BJKCHIDPJAP.position, 758f, 959f, 20f, 1948f, 1598f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.position, 1890f, 1453f, 691f, 1499f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.CKECHIOPGCL(dude5Title, dude5, BJKCHIDPJAP.localPosition, 1740f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.rotateAround(Camera.main.gameObject, Vector3.left, 1634f, 1351f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void MJBAPNCKMKM()
	{
		followArrow.gameObject.AOIGGMEPMAC(1417f, FINKKCCCLMH).MANKHCNNGHK(PCLEFMBMEKO).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.scale, 482f, 1822f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.z, 1596f, 1709f, 988f, 124f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.x, 1678f, 1099f, 1666f, 1634f, 578f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.y, 904f, 1588f, 1253f, 1591f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.position, 649f);
		LeanTween.followDamp(dude1, followArrow, (BJKCHIDPJAP)29, 338f, 1025f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)(-40), 740f, 676f, 980f, 1030f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, (BJKCHIDPJAP)(-48), 783f, 1824f, 1613f, 1530f, 90f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-83), 533f, 1755f, 889f, 987f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)124, 52f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.y, 1541f, 1461f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localZ, 365f, 1597f, 1042f, 1349f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localPosition, 1915f, 187f, 314f, 767f, 649f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.position, 796f, 218f, 855f, 1033f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.position, 1093f);
		Vector3 lJMAMFOPIKE = new Vector3(1917f, 895f, 1275f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.position, 103f, 488f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.position, 371f, 1833f, 364f, 603f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.position, 597f, 484f, 796f, 1563f, 1046f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.position, 1078f, 1937f, 1681f, 235f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.position, 1636f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.OLFLIBKDELB(Camera.main.gameObject, Vector3.left, 1298f, 762f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void CMKLLDPHOEL()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.AODMGIGJAHH(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 76f, 866f, 762f, 1218f, 1596f);
		HPHBNJHNGMC = LDFPKCPBDCO.OCILKMDFLKI(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 921f, 828f, 502f, 1597f, 470f);
		FGPDPHBONLJ = LDFPKCPBDCO.JLEOCLJEONH(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 326f, 1701f, 1162f, 287f, 578f);
		object[] array = new object[0];
		array[1] = "Starting to tween...";
		array[1] = NJHKLOOHDOJ;
		array[7] = "game:";
		array[8] = HPHBNJHNGMC;
		array[2] = "move punch!";
		array[4] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void PELEFHJHKBI()
	{
		followArrow.gameObject.AOIGGMEPMAC(861f, IHFDFANMJOC).MANKHCNNGHK(NMBKBCLCPPN).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.x, 420f, 1059f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.position, 858f, 1323f, 1282f, 944f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.position, 420f, 1784f, 1713f, 1785f, 1383f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.x, 133f, 797f, 775f, 1464f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.position, 445f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localPosition, 629f, 65f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)81, 1406f, 1903f, 1707f, 1231f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, (BJKCHIDPJAP)113, 476f, 1785f, 1997f, 512f, 1843f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)14, 1269f, 1774f, 565f, 716f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, (BJKCHIDPJAP)65, 242f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localY, 15f, 376f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localPosition, 674f, 437f, 1249f, 1337f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localZ, 1512f, 1580f, 166f, 415f, 1497f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.scale, 993f, 415f, 1451f, 1419f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.localZ, 1713f);
		Vector3 lJMAMFOPIKE = new Vector3(132f, 1944f, 1999f);
		LeanTween.followDamp(dude1Title, dude1, BJKCHIDPJAP.localPosition, 1273f, 1539f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 864f, 1023f, 209f, 748f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.DNAMDFHIHPF(dude3Title, dude3, BJKCHIDPJAP.position, 202f, 1549f, 613f, 1688f, 1380f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.position, 1465f, 457f, 1893f, 312f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.position, 204f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.OLFLIBKDELB(Camera.main.gameObject, Vector3.left, 1830f, 96f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void LHJAILEKNKI()
	{
		followArrow.gameObject.AOIGGMEPMAC(1331f, PLIGONGPANA).MANKHCNNGHK(AONKLFNOAJH).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.scale, 909f, 409f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localZ, 380f, 474f, 977f, 1553f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.z, 1998f, 692f, 1990f, 720f, 1779f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localY, 1475f, 318f, 1961f, 1431f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.z, 783f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)(-75), 686f, 1017f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)(-63), 718f, 1065f, 1295f, 1682f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, (BJKCHIDPJAP)(-122), 567f, 1025f, 728f, 359f, 1214f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-114), 353f, 970f, 1002f, 1608f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, (BJKCHIDPJAP)(-111), 1193f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.scale, 885f, 17f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.position, 1254f, 49f, 406f, 716f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localPosition, 803f, 1285f, 1149f, 547f, 1547f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localPosition, 1392f, 1064f, 1662f, 1408f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.localZ, 1871f);
		Vector3 lJMAMFOPIKE = new Vector3(872f, 1431f, 1667f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.localPosition, 361f, 564f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 1122f, 1347f, 958f, 1822f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.DNAMDFHIHPF(dude3Title, dude3, BJKCHIDPJAP.position, 1589f, 543f, 1800f, 999f, 448f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 1016f, 888f, 966f, 1653f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.localPosition, 1740f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.OLFLIBKDELB(Camera.main.gameObject, Vector3.left, 1579f, 1811f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void Update()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.LCJNIIKHAKF(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 1.1f);
		HPHBNJHNGMC = LDFPKCPBDCO.LCJNIIKHAKF(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 1.1f);
		FGPDPHBONLJ = LDFPKCPBDCO.LCJNIIKHAKF(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 1.1f);
		Debug.Log(string.Concat("Smoothed y:", NJHKLOOHDOJ, " vec3:", HPHBNJHNGMC, " color:", FGPDPHBONLJ));
	}

	private void DPKDAPGGBBH()
	{
		followArrow.gameObject.AOIGGMEPMAC(1171f, IHFDFANMJOC).MANKHCNNGHK(CAKOLPDPILC).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.scale, 878f, 1535f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.z, 103f, 870f, 1584f, 825f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.position, 1285f, 1024f, 530f, 1516f, 1209f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.scale, 1097f, 1346f, 1172f, 746f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.localX, 599f);
		LeanTween.followDamp(dude1, followArrow, (BJKCHIDPJAP)31, 830f, 97f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)57, 350f, 130f, 1652f, 1073f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.localY, 1579f, 669f, 983f, 224f, 190f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-18), 1275f, 1061f, 1685f, 1627f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)(-77), 1538f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.localY, 1819f, 925f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localZ, 1642f, 637f, 13f, 1663f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.x, 1319f, 667f, 968f, 572f, 539f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.position, 1437f, 1514f, 1752f, 740f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.scale, 1752f);
		Vector3 lJMAMFOPIKE = new Vector3(1027f, 1705f, 355f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.localPosition, 1291f, 1019f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 1822f, 284f, 1487f, 1119f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.position, 1060f, 1796f, 1011f, 1172f, 1698f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.position, 1492f, 1638f, 1409f, 417f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.CKECHIOPGCL(dude5Title, dude5, BJKCHIDPJAP.position, 1f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.MICJCMIDHAM(Camera.main.gameObject, Vector3.left, 14f, 1652f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void PLIGONGPANA()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(152f, 1053f), 1351f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1729f);
		float d = Random.Range(24f, 770f);
		followArrow.localScale = Vector3.one * d;
	}

	private void PENCKBBADEO()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(1596f, 1384f), 731f);
		LeanTween.BAHMJNENJIN(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 691f);
		float d = Random.Range(847f, 1780f);
		followArrow.localScale = Vector3.one * d;
	}

	private void MLOAELNMLIO()
	{
		LeanTween.CIPCPCNBGNN(followArrow.gameObject, Random.Range(479f, 1396f), 488f);
		LeanTween.color(HIECNNGMKIE: new Color(Random.value, Random.value, Random.value), GKHONGJMCLB: followArrow.gameObject, MAEOCPAHAHA: 1792f);
		float d = Random.Range(427f, 1345f);
		followArrow.localScale = Vector3.one * d;
	}

	private void ICFHIAANJMI()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.AODMGIGJAHH(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 1244f, 1189f, 200f, 1729f, 1708f);
		HPHBNJHNGMC = LDFPKCPBDCO.BHLDIOLHCAJ(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 1175f, 1923f, 657f, 987f, 836f);
		FGPDPHBONLJ = LDFPKCPBDCO.JFLNPFGNODF(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 1858f, 1734f, 175f, 682f, 1173f);
		object[] array = new object[8];
		array[1] = "cancel";
		array[1] = NJHKLOOHDOJ;
		array[6] = "hat3";
		array[3] = HPHBNJHNGMC;
		array[3] = "\nConnecting to network address: ";
		array[0] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void BLANFEOIEHH()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.AODMGIGJAHH(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 826f, 646f, 186f, 1589f, 261f);
		HPHBNJHNGMC = LDFPKCPBDCO.CONFPHIEAFF(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 1109f, 680f, 978f, 557f, 1551f);
		FGPDPHBONLJ = LDFPKCPBDCO.MGCCMPDNDJJ(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 1583f, 113f, 170f, 165f, 1346f);
		object[] array = new object[5];
		array[1] = " diff:";
		array[1] = NJHKLOOHDOJ;
		array[0] = "Player passed invalid auth token.";
		array[7] = HPHBNJHNGMC;
		array[0] = "cubeDestroy";
		array[3] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void Start()
	{
		followArrow.gameObject.AOIGGMEPMAC(3f, KDLKGGLONDA).MANKHCNNGHK(KDLKGGLONDA).MNELFOFMPKF(-1);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.localY, 1.1f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localY, 1.1f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.localY, 1.1f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localY, 1.1f, -1f, 1.5f, 0.8f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.localY, 50f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.color, 1.1f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.color, 1.1f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.color, 1.1f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.color, 1.1f, -1f, 1.5f, 0.8f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.color, 0.5f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.scale, 1.1f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.scale, 1.1f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.scale, 1.1f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.scale, 1.1f, -1f, 1.5f, 0.8f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.scale, 5f);
		Vector3 lJMAMFOPIKE = new Vector3(0f, -20f, -18f);
		LeanTween.followDamp(dude1Title, dude1, BJKCHIDPJAP.localPosition, 0.6f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 0.6f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.localPosition, 0.6f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 0.6f, -1f, 1.5f, 0.8f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.localPosition, 30f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.rotateAround(Camera.main.gameObject, Vector3.left, 360f, 300f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void DKFIEGJBGDL()
	{
		NJHKLOOHDOJ = LDFPKCPBDCO.LCJNIIKHAKF(NJHKLOOHDOJ, followArrow.localPosition.y, ref HPJFHNLEFLA, 548f, 1334f, 1119f, 263f, 739f);
		HPHBNJHNGMC = LDFPKCPBDCO.CONFPHIEAFF(HPHBNJHNGMC, dude5Title.localPosition, ref AICMGLGGJLO, 455f, 315f, 1878f, 877f, 1274f);
		FGPDPHBONLJ = LDFPKCPBDCO.LHMAANEGOCE(FGPDPHBONLJ, dude1.GetComponent<Renderer>().material.color, ref OFNJOMCFOLM, 1333f, 1744f, 1652f, 302f, 0f);
		object[] array = new object[3];
		array[1] = "<";
		array[0] = NJHKLOOHDOJ;
		array[4] = ".png";
		array[3] = HPHBNJHNGMC;
		array[6] = "Error loading file";
		array[5] = FGPDPHBONLJ;
		Debug.Log(string.Concat(array));
	}

	private void HLKNKOKNOKB()
	{
		followArrow.gameObject.AOIGGMEPMAC(767f, LGJNJGHJECC).MANKHCNNGHK(CAKOLPDPILC).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.scale, 970f, 867f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.position, 965f, 583f, 526f, 1453f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.scale, 1577f, 592f, 119f, 100f, 1544f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.scale, 412f, 1727f, 1318f, 1488f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.scale, 1309f);
		LeanTween.followDamp(dude1, followArrow, (BJKCHIDPJAP)111, 103f, 1032f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)71, 1290f, 1557f, 1981f, 1560f);
		LeanTween.followBounceOut(dude3, followArrow, (BJKCHIDPJAP)38, 1110f, 1316f, 1354f, 1072f, 1622f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-29), 1157f, 1381f, 1876f, 1127f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, (BJKCHIDPJAP)(-2), 62f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.x, 1827f, 1322f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.z, 1493f, 69f, 106f, 800f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.localZ, 217f, 1548f, 627f, 1458f, 1965f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.y, 1835f, 472f, 1674f, 1025f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.x, 1893f);
		Vector3 lJMAMFOPIKE = new Vector3(579f, 466f, 1276f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.position, 1027f, 1921f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 1254f, 346f, 1441f, 360f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.DNAMDFHIHPF(dude3Title, dude3, BJKCHIDPJAP.position, 1246f, 1296f, 275f, 1709f, 616f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 1487f, 1874f, 760f, 1687f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.CKECHIOPGCL(dude5Title, dude5, BJKCHIDPJAP.position, 1768f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.MICJCMIDHAM(Camera.main.gameObject, Vector3.left, 727f, 1614f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void BDMGKLPALJN()
	{
		followArrow.gameObject.AOIGGMEPMAC(1612f, MLOAELNMLIO).MANKHCNNGHK(OOHEEPIFNFK).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.y, 706f, 1486f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.y, 480f, 1303f, 1323f, 527f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.y, 1358f, 986f, 1924f, 1209f, 1812f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localX, 1954f, 340f, 889f, 1155f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.scale, 231f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)(-115), 1427f, 387f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)121, 1863f, 1590f, 1437f, 1432f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, (BJKCHIDPJAP)28, 1553f, 1272f, 978f, 490f, 1811f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-34), 1465f, 824f, 1046f, 316f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)(-1), 1014f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.localZ, 1552f, 361f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localX, 1280f, 978f, 1929f, 586f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.x, 839f, 1841f, 825f, 1380f, 621f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localX, 1099f, 915f, 616f, 1712f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.scale, 1094f);
		Vector3 lJMAMFOPIKE = new Vector3(1606f, 1805f, 1713f);
		LeanTween.followDamp(dude1Title, dude1, BJKCHIDPJAP.position, 718f, 1f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.position, 489f, 1515f, 1842f, 839f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.position, 1217f, 361f, 1875f, 26f, 652f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.position, 612f, 1508f, 846f, 698f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.CKECHIOPGCL(dude5Title, dude5, BJKCHIDPJAP.position, 1430f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.OLFLIBKDELB(Camera.main.gameObject, Vector3.left, 153f, 1109f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void EODENBEOJID()
	{
		followArrow.gameObject.AOIGGMEPMAC(897f, KDLKGGLONDA).MANKHCNNGHK(MLOAELNMLIO).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.localY, 161f, 1441f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localZ, 1622f, 314f, 266f, 1539f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.localPosition, 649f, 1643f, 569f, 1532f, 1748f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localY, 605f, 1919f, 277f, 1202f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.y, 663f);
		LeanTween.followDamp(dude1, followArrow, (BJKCHIDPJAP)60, 568f, 1290f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)17, 1807f, 1664f, 417f, 1784f);
		LeanTween.followBounceOut(dude3, followArrow, (BJKCHIDPJAP)100, 422f, 1121f, 344f, 586f, 1766f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)55, 1606f, 225f, 1840f, 62f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, (BJKCHIDPJAP)(-40), 1464f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.position, 1743f, 972f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localZ, 860f, 1044f, 1533f, 613f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.localZ, 1649f, 480f, 1697f, 234f, 1903f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localZ, 150f, 479f, 1814f, 650f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.scale, 1754f);
		Vector3 lJMAMFOPIKE = new Vector3(562f, 226f, 521f);
		LeanTween.followDamp(dude1Title, dude1, BJKCHIDPJAP.position, 945f, 1982f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 999f, 1694f, 437f, 1139f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.position, 1198f, 1394f, 825f, 317f, 1509f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.position, 620f, 884f, 1171f, 35f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followLinear(dude5Title, dude5, BJKCHIDPJAP.position, 641f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.MICJCMIDHAM(Camera.main.gameObject, Vector3.left, 647f, 352f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}

	private void LHKKHKIACBO()
	{
		followArrow.gameObject.AOIGGMEPMAC(1273f, ACFPFCJHNAO).MANKHCNNGHK(BIJNMIDKFIO).MNELFOFMPKF(-1);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, BJKCHIDPJAP.localY, 897f, 601f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localY, 356f, 1874f, 679f, 1568f);
		LeanTween.DNAMDFHIHPF(dude3, followArrow, BJKCHIDPJAP.position, 427f, 453f, 1961f, 140f, 907f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localZ, 1572f, 1730f, 886f, 1639f);
		LeanTween.followLinear(dude5, followArrow, BJKCHIDPJAP.position, 1443f);
		LeanTween.HABMIGMCBAJ(dude1, followArrow, (BJKCHIDPJAP)103, 668f, 216f);
		LeanTween.followSpring(dude2, followArrow, (BJKCHIDPJAP)(-43), 711f, 250f, 716f, 1856f);
		LeanTween.followBounceOut(dude3, followArrow, (BJKCHIDPJAP)77, 276f, 1315f, 1609f, 237f, 1369f);
		LeanTween.followSpring(dude4, followArrow, (BJKCHIDPJAP)(-111), 1663f, 321f, 688f, 1373f);
		LeanTween.followLinear(dude5, followArrow, (BJKCHIDPJAP)78, 774f);
		LeanTween.followDamp(dude1, followArrow, BJKCHIDPJAP.x, 1017f, 1900f);
		LeanTween.followSpring(dude2, followArrow, BJKCHIDPJAP.localZ, 1499f, 460f, 466f, 412f);
		LeanTween.followBounceOut(dude3, followArrow, BJKCHIDPJAP.z, 668f, 592f, 265f, 1830f, 1561f);
		LeanTween.followSpring(dude4, followArrow, BJKCHIDPJAP.localPosition, 385f, 824f, 1645f, 1623f);
		LeanTween.CKECHIOPGCL(dude5, followArrow, BJKCHIDPJAP.scale, 1712f);
		Vector3 lJMAMFOPIKE = new Vector3(462f, 151f, 1138f);
		LeanTween.HABMIGMCBAJ(dude1Title, dude1, BJKCHIDPJAP.position, 1902f, 1538f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude2Title, dude2, BJKCHIDPJAP.localPosition, 1909f, 1409f, 197f, 266f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followBounceOut(dude3Title, dude3, BJKCHIDPJAP.position, 668f, 1273f, 1650f, 315f, 1100f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.followSpring(dude4Title, dude4, BJKCHIDPJAP.localPosition, 1790f, 249f, 1443f, 602f).CAJMMFCONJA(lJMAMFOPIKE);
		LeanTween.CKECHIOPGCL(dude5Title, dude5, BJKCHIDPJAP.localPosition, 722f).CAJMMFCONJA(lJMAMFOPIKE);
		Vector3 cNBPFDEFCEK = Camera.main.transform.InverseTransformPoint(planet.transform.position);
		LeanTween.MICJCMIDHAM(Camera.main.gameObject, Vector3.left, 1344f, 407f).PKHDJFJBHFC(cNBPFDEFCEK).MNELFOFMPKF(-1);
	}
}
