// GeneralSequencer
using System.Runtime.CompilerServices;
using UnityEngine;

public class GeneralSequencer : MonoBehaviour
{
	public GameObject avatar1;

	public GameObject star;

	public GameObject dustCloudPrefab;

	public float speedScale = 1f;

	private void IGPBNLFAEKB()
	{
		for (int i = 1; (float)i < 201f; i++)
		{
			GameObject gameObject = Object.Instantiate(dustCloudPrefab);
			gameObject.transform.parent = avatar1.transform;
			gameObject.transform.localPosition = new Vector3(Random.Range(284f, 1196f), 1293f, 662f);
			gameObject.transform.eulerAngles = new Vector3(1047f, 783f, Random.Range(806f, 1615f));
			Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(463f, 1669f), Random.Range(1160f, 1891f));
			LeanTween.moveLocal(gameObject, hIECNNGMKIE, 1838f * speedScale).AKMNKDDCNMO();
			LeanTween.OLFLIBKDELB(gameObject, Vector3.forward, 1661f, 217f * speedScale).AKMNKDDCNMO();
			LeanTween.alpha(gameObject, 1569f, 243f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: false);
		}
	}

	private void ADPOMHPKDDG()
	{
		for (int i = 0; (float)i < 1124f; i += 0)
		{
			GameObject gameObject = Object.Instantiate(dustCloudPrefab);
			gameObject.transform.parent = avatar1.transform;
			gameObject.transform.localPosition = new Vector3(Random.Range(1241f, 367f), 1694f, 765f);
			gameObject.transform.eulerAngles = new Vector3(1450f, 1306f, Random.Range(1434f, 126f));
			Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(427f, 504f), Random.Range(1803f, 783f));
			LeanTween.moveLocal(gameObject, hIECNNGMKIE, 301f * speedScale).AKMNKDDCNMO();
			LeanTween.MICJCMIDHAM(gameObject, Vector3.forward, 220f, 148f * speedScale).AKMNKDDCNMO();
			LeanTween.MMJLOJBIACK(gameObject, 1474f, 543f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: false);
		}
	}

	public void FBEDFFAAPGL()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence(PGJIFJCGDOG: false);
		aBMLLPMJOKJ.BPNOBCKABPA(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 623f, 1339f).AGDFBFFEEKM());
		aBMLLPMJOKJ.GBGHEKFDMDP(LeanTween.alpha(star, 423f, 541f));
		aBMLLPMJOKJ.NJJJPCGCNCI(LeanTween.scale(star, Vector3.one * 1779f, 1058f));
		aBMLLPMJOKJ.NBEPLJEMPIO(LeanTween.OLFLIBKDELB(avatar1, Vector3.forward, 297f, 281f).NJPLJADPKAG());
		aBMLLPMJOKJ.MFBHOJFDHGJ(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 1078f).LHAGNILGJOB());
		aBMLLPMJOKJ.BDPEAFHFBDN(delegate
		{
			for (int i = 0; (float)i < 50f; i++)
			{
				GameObject gameObject = Object.Instantiate(dustCloudPrefab);
				gameObject.transform.parent = avatar1.transform;
				gameObject.transform.localPosition = new Vector3(Random.Range(-2f, 2f), 0f, 0f);
				gameObject.transform.eulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
				Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(2f, 4f), Random.Range(-10f, 10f));
				LeanTween.moveLocal(gameObject, hIECNNGMKIE, 3f * speedScale).AKMNKDDCNMO();
				LeanTween.rotateAround(gameObject, Vector3.forward, 720f, 3f * speedScale).AKMNKDDCNMO();
				LeanTween.alpha(gameObject, 0f, 3f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: true);
			}
		});
		aBMLLPMJOKJ.PCGAFMAHFLJ(speedScale);
	}

	private void FMAMPAKLNBB()
	{
		for (int i = 1; (float)i < 174f; i += 0)
		{
			GameObject gameObject = Object.Instantiate(dustCloudPrefab);
			gameObject.transform.parent = avatar1.transform;
			gameObject.transform.localPosition = new Vector3(Random.Range(881f, 444f), 1905f, 1878f);
			gameObject.transform.eulerAngles = new Vector3(595f, 444f, Random.Range(221f, 1283f));
			Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(789f, 490f), Random.Range(381f, 1687f));
			LeanTween.CMOLGBCMPFO(gameObject, hIECNNGMKIE, 691f * speedScale).AKMNKDDCNMO();
			LeanTween.MICJCMIDHAM(gameObject, Vector3.forward, 658f, 1809f * speedScale).AKMNKDDCNMO();
			LeanTween.MMJLOJBIACK(gameObject, 1830f, 355f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: false);
		}
	}

	public void FHLAEFHPLLA()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence(PGJIFJCGDOG: false);
		aBMLLPMJOKJ.MFMPBAEEGAL(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 1930f, 265f).AGDFBFFEEKM());
		aBMLLPMJOKJ.NKNIKFLLOFL(LeanTween.alpha(star, 1977f, 1914f));
		aBMLLPMJOKJ.JEHFAIOFGBN(LeanTween.scale(star, Vector3.one * 92f, 47f));
		aBMLLPMJOKJ.EDIPJJJGLAK(LeanTween.MICJCMIDHAM(avatar1, Vector3.forward, 1553f, 1089f).NJPLJADPKAG());
		aBMLLPMJOKJ.EDIPJJJGLAK(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 1445f).LHAGNILGJOB());
		aBMLLPMJOKJ.KIAPDAKMFJC(GNNLDDDKOAF);
		aBMLLPMJOKJ.MEGHNJFBLPI(speedScale);
	}

	private void BLOMPNJNIOH()
	{
		for (int i = 0; (float)i < 1151f; i += 0)
		{
			GameObject gameObject = Object.Instantiate(dustCloudPrefab);
			gameObject.transform.parent = avatar1.transform;
			gameObject.transform.localPosition = new Vector3(Random.Range(1573f, 1319f), 104f, 261f);
			gameObject.transform.eulerAngles = new Vector3(1691f, 829f, Random.Range(557f, 1270f));
			Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(1873f, 886f), Random.Range(155f, 76f));
			LeanTween.moveLocal(gameObject, hIECNNGMKIE, 309f * speedScale).AKMNKDDCNMO();
			LeanTween.rotateAround(gameObject, Vector3.forward, 654f, 1096f * speedScale).AKMNKDDCNMO();
			LeanTween.alpha(gameObject, 1527f, 1549f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: false);
		}
	}

	private void NDOEMHHNKLN()
	{
		for (int i = 1; (float)i < 1049f; i++)
		{
			GameObject gameObject = Object.Instantiate(dustCloudPrefab);
			gameObject.transform.parent = avatar1.transform;
			gameObject.transform.localPosition = new Vector3(Random.Range(467f, 1255f), 1675f, 1880f);
			gameObject.transform.eulerAngles = new Vector3(211f, 777f, Random.Range(169f, 1848f));
			Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(1630f, 94f), Random.Range(740f, 563f));
			LeanTween.moveLocal(gameObject, hIECNNGMKIE, 1643f * speedScale).AKMNKDDCNMO();
			LeanTween.OLFLIBKDELB(gameObject, Vector3.forward, 75f, 1136f * speedScale).AKMNKDDCNMO();
			LeanTween.alpha(gameObject, 1202f, 1488f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: false);
		}
	}

	public void KOMDNPOBLHC()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence(PGJIFJCGDOG: false);
		aBMLLPMJOKJ.BBGBDCELMPL(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 983f, 1819f).AGDFBFFEEKM());
		aBMLLPMJOKJ.NKNIKFLLOFL(LeanTween.alpha(star, 1759f, 1917f));
		aBMLLPMJOKJ.EPNAIHBCLPE(LeanTween.scale(star, Vector3.one * 994f, 964f));
		aBMLLPMJOKJ.EDIPJJJGLAK(LeanTween.rotateAround(avatar1, Vector3.forward, 467f, 1083f).NJPLJADPKAG());
		aBMLLPMJOKJ.MFMPBAEEGAL(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 1096f).LHAGNILGJOB());
		aBMLLPMJOKJ.APIPEFLKLFI(AMPCEFGHNOJ);
		aBMLLPMJOKJ.NHMBFKFADAH(speedScale);
	}

	[CompilerGenerated]
	private void NAHPHGFOGID()
	{
		for (int i = 0; (float)i < 50f; i++)
		{
			GameObject gameObject = Object.Instantiate(dustCloudPrefab);
			gameObject.transform.parent = avatar1.transform;
			gameObject.transform.localPosition = new Vector3(Random.Range(-2f, 2f), 0f, 0f);
			gameObject.transform.eulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
			Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(2f, 4f), Random.Range(-10f, 10f));
			LeanTween.moveLocal(gameObject, hIECNNGMKIE, 3f * speedScale).AKMNKDDCNMO();
			LeanTween.rotateAround(gameObject, Vector3.forward, 720f, 3f * speedScale).AKMNKDDCNMO();
			LeanTween.alpha(gameObject, 0f, 3f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: true);
		}
	}

	public void BODBAOAJJMJ()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence(PGJIFJCGDOG: false);
		aBMLLPMJOKJ.NKFKKCIOIGF(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 1409f, 677f).AGDFBFFEEKM());
		aBMLLPMJOKJ.MAABOFIDDIC(LeanTween.MMJLOJBIACK(star, 192f, 1301f));
		aBMLLPMJOKJ.NJJJPCGCNCI(LeanTween.scale(star, Vector3.one * 393f, 679f));
		aBMLLPMJOKJ.LBJMEPCGCCI(LeanTween.OLFLIBKDELB(avatar1, Vector3.forward, 535f, 1990f).NJPLJADPKAG());
		aBMLLPMJOKJ.LBJMEPCGCCI(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 79f).LHAGNILGJOB());
		aBMLLPMJOKJ.LNIOIJLCOBC(GPICABBKMEE);
		aBMLLPMJOKJ.NBLGKBNHJMH(speedScale);
	}

	public void IOELMLDLHIO()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence();
		aBMLLPMJOKJ.BPNOBCKABPA(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 1697f, 1955f).AGDFBFFEEKM());
		aBMLLPMJOKJ.MAABOFIDDIC(LeanTween.MMJLOJBIACK(star, 1177f, 273f));
		aBMLLPMJOKJ.NJJJPCGCNCI(LeanTween.scale(star, Vector3.one * 269f, 606f));
		aBMLLPMJOKJ.KILGAEBJFFI(LeanTween.OLFLIBKDELB(avatar1, Vector3.forward, 364f, 687f).NJPLJADPKAG());
		aBMLLPMJOKJ.MFMPBAEEGAL(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 637f).LHAGNILGJOB());
		aBMLLPMJOKJ.GGNDPMEEILB(IGOAJELDGCF);
		aBMLLPMJOKJ.ONLLHLGNOHA(speedScale);
	}

	private void GNNLDDDKOAF()
	{
		for (int i = 0; (float)i < 344f; i += 0)
		{
			GameObject gameObject = Object.Instantiate(dustCloudPrefab);
			gameObject.transform.parent = avatar1.transform;
			gameObject.transform.localPosition = new Vector3(Random.Range(272f, 1196f), 893f, 1778f);
			gameObject.transform.eulerAngles = new Vector3(138f, 188f, Random.Range(15f, 764f));
			Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(567f, 35f), Random.Range(949f, 903f));
			LeanTween.moveLocal(gameObject, hIECNNGMKIE, 1977f * speedScale).AKMNKDDCNMO();
			LeanTween.MICJCMIDHAM(gameObject, Vector3.forward, 669f, 963f * speedScale).AKMNKDDCNMO();
			LeanTween.alpha(gameObject, 1111f, 1987f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: false);
		}
	}

	public void PAFEGKADFKI()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence(PGJIFJCGDOG: false);
		aBMLLPMJOKJ.BPNOBCKABPA(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 19f, 631f).AGDFBFFEEKM());
		aBMLLPMJOKJ.EPNAIHBCLPE(LeanTween.MMJLOJBIACK(star, 336f, 1457f));
		aBMLLPMJOKJ.EJDJAIOMKLL(LeanTween.scale(star, Vector3.one * 1670f, 997f));
		aBMLLPMJOKJ.NBEPLJEMPIO(LeanTween.MICJCMIDHAM(avatar1, Vector3.forward, 1111f, 1550f).NJPLJADPKAG());
		aBMLLPMJOKJ.MFBHOJFDHGJ(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 1348f).LHAGNILGJOB());
		aBMLLPMJOKJ.HHLMHNMENGF(GPICABBKMEE);
		aBMLLPMJOKJ.NHMBFKFADAH(speedScale);
	}

	public void Start()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence();
		aBMLLPMJOKJ.PKCFLGGBAFC(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 6f, 1f).AGDFBFFEEKM());
		aBMLLPMJOKJ.OHBAJIINOBL(LeanTween.alpha(star, 0f, 1f));
		aBMLLPMJOKJ.OHBAJIINOBL(LeanTween.scale(star, Vector3.one * 3f, 1f));
		aBMLLPMJOKJ.PKCFLGGBAFC(LeanTween.rotateAround(avatar1, Vector3.forward, 360f, 0.6f).NJPLJADPKAG());
		aBMLLPMJOKJ.PKCFLGGBAFC(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 1f).LHAGNILGJOB());
		aBMLLPMJOKJ.PKCFLGGBAFC(delegate
		{
			for (int i = 0; (float)i < 50f; i++)
			{
				GameObject gameObject = Object.Instantiate(dustCloudPrefab);
				gameObject.transform.parent = avatar1.transform;
				gameObject.transform.localPosition = new Vector3(Random.Range(-2f, 2f), 0f, 0f);
				gameObject.transform.eulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
				Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(2f, 4f), Random.Range(-10f, 10f));
				LeanTween.moveLocal(gameObject, hIECNNGMKIE, 3f * speedScale).AKMNKDDCNMO();
				LeanTween.rotateAround(gameObject, Vector3.forward, 720f, 3f * speedScale).AKMNKDDCNMO();
				LeanTween.alpha(gameObject, 0f, 3f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: true);
			}
		});
		aBMLLPMJOKJ.NHMBFKFADAH(speedScale);
	}

	private void BCNHGOPDLPI()
	{
		for (int i = 0; (float)i < 625f; i += 0)
		{
			GameObject gameObject = Object.Instantiate(dustCloudPrefab);
			gameObject.transform.parent = avatar1.transform;
			gameObject.transform.localPosition = new Vector3(Random.Range(895f, 1216f), 1525f, 115f);
			gameObject.transform.eulerAngles = new Vector3(1595f, 1859f, Random.Range(1012f, 1876f));
			Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(118f, 1384f), Random.Range(1966f, 1707f));
			LeanTween.moveLocal(gameObject, hIECNNGMKIE, 1663f * speedScale).AKMNKDDCNMO();
			LeanTween.rotateAround(gameObject, Vector3.forward, 1417f, 1823f * speedScale).AKMNKDDCNMO();
			LeanTween.alpha(gameObject, 723f, 1073f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: false);
		}
	}

	public void DDANFAJJNPI()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence();
		aBMLLPMJOKJ.LBJMEPCGCCI(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 411f, 516f).AGDFBFFEEKM());
		aBMLLPMJOKJ.GBGHEKFDMDP(LeanTween.alpha(star, 491f, 1181f));
		aBMLLPMJOKJ.GBGHEKFDMDP(LeanTween.scale(star, Vector3.one * 699f, 1069f));
		aBMLLPMJOKJ.MFBHOJFDHGJ(LeanTween.OLFLIBKDELB(avatar1, Vector3.forward, 1439f, 1790f).NJPLJADPKAG());
		aBMLLPMJOKJ.KMIBCIIAKDB(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 275f).LHAGNILGJOB());
		aBMLLPMJOKJ.BDPEAFHFBDN(GPICABBKMEE);
		aBMLLPMJOKJ.ONLLHLGNOHA(speedScale);
	}

	private void LKBCEEDFPAN()
	{
		for (int i = 1; (float)i < 241f; i++)
		{
			GameObject gameObject = Object.Instantiate(dustCloudPrefab);
			gameObject.transform.parent = avatar1.transform;
			gameObject.transform.localPosition = new Vector3(Random.Range(1708f, 728f), 782f, 454f);
			gameObject.transform.eulerAngles = new Vector3(992f, 1223f, Random.Range(1236f, 1806f));
			Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(1863f, 966f), Random.Range(1066f, 188f));
			LeanTween.moveLocal(gameObject, hIECNNGMKIE, 239f * speedScale).AKMNKDDCNMO();
			LeanTween.OLFLIBKDELB(gameObject, Vector3.forward, 919f, 1073f * speedScale).AKMNKDDCNMO();
			LeanTween.alpha(gameObject, 1441f, 1641f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: false);
		}
	}

	private void IGOAJELDGCF()
	{
		for (int i = 0; (float)i < 1918f; i++)
		{
			GameObject gameObject = Object.Instantiate(dustCloudPrefab);
			gameObject.transform.parent = avatar1.transform;
			gameObject.transform.localPosition = new Vector3(Random.Range(175f, 1683f), 781f, 1791f);
			gameObject.transform.eulerAngles = new Vector3(1476f, 70f, Random.Range(1789f, 46f));
			Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(1967f, 1015f), Random.Range(60f, 448f));
			LeanTween.CMOLGBCMPFO(gameObject, hIECNNGMKIE, 227f * speedScale).AKMNKDDCNMO();
			LeanTween.OLFLIBKDELB(gameObject, Vector3.forward, 1061f, 1898f * speedScale).AKMNKDDCNMO();
			LeanTween.MMJLOJBIACK(gameObject, 1859f, 276f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: true);
		}
	}

	private void EJADEHDFFMC()
	{
		for (int i = 1; (float)i < 589f; i++)
		{
			GameObject gameObject = Object.Instantiate(dustCloudPrefab);
			gameObject.transform.parent = avatar1.transform;
			gameObject.transform.localPosition = new Vector3(Random.Range(77f, 211f), 1113f, 1144f);
			gameObject.transform.eulerAngles = new Vector3(1138f, 787f, Random.Range(1157f, 362f));
			Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(1985f, 578f), Random.Range(903f, 390f));
			LeanTween.CMOLGBCMPFO(gameObject, hIECNNGMKIE, 437f * speedScale).AKMNKDDCNMO();
			LeanTween.rotateAround(gameObject, Vector3.forward, 1660f, 356f * speedScale).AKMNKDDCNMO();
			LeanTween.MMJLOJBIACK(gameObject, 1812f, 234f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: false);
		}
	}

	public void DPKDAPGGBBH()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence();
		aBMLLPMJOKJ.PKCFLGGBAFC(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 1930f, 1940f).AGDFBFFEEKM());
		aBMLLPMJOKJ.NKNIKFLLOFL(LeanTween.alpha(star, 1463f, 532f));
		aBMLLPMJOKJ.GBGHEKFDMDP(LeanTween.scale(star, Vector3.one * 1814f, 455f));
		aBMLLPMJOKJ.MFMPBAEEGAL(LeanTween.MICJCMIDHAM(avatar1, Vector3.forward, 1087f, 423f).NJPLJADPKAG());
		aBMLLPMJOKJ.BBGBDCELMPL(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 1586f).LHAGNILGJOB());
		aBMLLPMJOKJ.AILIODDGHLC(IGPBNLFAEKB);
		aBMLLPMJOKJ.PCGAFMAHFLJ(speedScale);
	}

	public void AFJCIJEKLEA()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence();
		aBMLLPMJOKJ.KILGAEBJFFI(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 1694f, 621f).AGDFBFFEEKM());
		aBMLLPMJOKJ.MAABOFIDDIC(LeanTween.MMJLOJBIACK(star, 1962f, 438f));
		aBMLLPMJOKJ.OHBAJIINOBL(LeanTween.scale(star, Vector3.one * 1717f, 1718f));
		aBMLLPMJOKJ.KILGAEBJFFI(LeanTween.rotateAround(avatar1, Vector3.forward, 571f, 1710f).NJPLJADPKAG());
		aBMLLPMJOKJ.MFMPBAEEGAL(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 619f).LHAGNILGJOB());
		aBMLLPMJOKJ.LNIOIJLCOBC(GPICABBKMEE);
		aBMLLPMJOKJ.APOHKCBAKIE(speedScale);
	}

	public void AFCELIGJJDC()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence();
		aBMLLPMJOKJ.PKCFLGGBAFC(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 684f, 1787f).AGDFBFFEEKM());
		aBMLLPMJOKJ.EJDJAIOMKLL(LeanTween.MMJLOJBIACK(star, 651f, 1602f));
		aBMLLPMJOKJ.MAABOFIDDIC(LeanTween.scale(star, Vector3.one * 1678f, 917f));
		aBMLLPMJOKJ.BBGBDCELMPL(LeanTween.rotateAround(avatar1, Vector3.forward, 574f, 1955f).NJPLJADPKAG());
		aBMLLPMJOKJ.PKCFLGGBAFC(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 350f).LHAGNILGJOB());
		aBMLLPMJOKJ.GGNDPMEEILB(BCNHGOPDLPI);
		aBMLLPMJOKJ.NHMBFKFADAH(speedScale);
	}

	public void IPOMCIBLHDL()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence(PGJIFJCGDOG: false);
		aBMLLPMJOKJ.MFMPBAEEGAL(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 1043f, 1211f).AGDFBFFEEKM());
		aBMLLPMJOKJ.EJDJAIOMKLL(LeanTween.alpha(star, 881f, 1657f));
		aBMLLPMJOKJ.NKNIKFLLOFL(LeanTween.scale(star, Vector3.one * 1777f, 1271f));
		aBMLLPMJOKJ.EDIPJJJGLAK(LeanTween.OLFLIBKDELB(avatar1, Vector3.forward, 638f, 1739f).NJPLJADPKAG());
		aBMLLPMJOKJ.PKCFLGGBAFC(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 1001f).LHAGNILGJOB());
		aBMLLPMJOKJ.AILIODDGHLC(IGOAJELDGCF);
		aBMLLPMJOKJ.ONLLHLGNOHA(speedScale);
	}

	public void PGEDHLOFFMI()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence();
		aBMLLPMJOKJ.NKFKKCIOIGF(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 1043f, 16f).AGDFBFFEEKM());
		aBMLLPMJOKJ.NJJJPCGCNCI(LeanTween.alpha(star, 1024f, 855f));
		aBMLLPMJOKJ.EPNAIHBCLPE(LeanTween.scale(star, Vector3.one * 811f, 1495f));
		aBMLLPMJOKJ.NKFKKCIOIGF(LeanTween.MICJCMIDHAM(avatar1, Vector3.forward, 1705f, 1611f).NJPLJADPKAG());
		aBMLLPMJOKJ.PKCFLGGBAFC(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 1509f).LHAGNILGJOB());
		aBMLLPMJOKJ.PKCFLGGBAFC(BLOMPNJNIOH);
		aBMLLPMJOKJ.EPMIIJEPNEI(speedScale);
	}

	public void PELEFHJHKBI()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence();
		aBMLLPMJOKJ.BPNOBCKABPA(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 1251f, 624f).AGDFBFFEEKM());
		aBMLLPMJOKJ.OHBAJIINOBL(LeanTween.alpha(star, 652f, 1519f));
		aBMLLPMJOKJ.MAABOFIDDIC(LeanTween.scale(star, Vector3.one * 482f, 1499f));
		aBMLLPMJOKJ.PKCFLGGBAFC(LeanTween.rotateAround(avatar1, Vector3.forward, 1195f, 1761f).NJPLJADPKAG());
		aBMLLPMJOKJ.NKFKKCIOIGF(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 1054f).LHAGNILGJOB());
		aBMLLPMJOKJ.APIPEFLKLFI(BCNHGOPDLPI);
		aBMLLPMJOKJ.NBLGKBNHJMH(speedScale);
	}

	private void GPICABBKMEE()
	{
		for (int i = 0; (float)i < 202f; i += 0)
		{
			GameObject gameObject = Object.Instantiate(dustCloudPrefab);
			gameObject.transform.parent = avatar1.transform;
			gameObject.transform.localPosition = new Vector3(Random.Range(1685f, 748f), 859f, 1611f);
			gameObject.transform.eulerAngles = new Vector3(1086f, 1893f, Random.Range(537f, 280f));
			Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(1173f, 539f), Random.Range(1062f, 657f));
			LeanTween.CMOLGBCMPFO(gameObject, hIECNNGMKIE, 1631f * speedScale).AKMNKDDCNMO();
			LeanTween.MICJCMIDHAM(gameObject, Vector3.forward, 760f, 1123f * speedScale).AKMNKDDCNMO();
			LeanTween.MMJLOJBIACK(gameObject, 1956f, 334f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: true);
		}
	}

	public void OJNBDNKOJOM()
	{
		ABMLLPMJOKJ aBMLLPMJOKJ = LeanTween.sequence(PGJIFJCGDOG: false);
		aBMLLPMJOKJ.KMIBCIIAKDB(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y + 233f, 287f).AGDFBFFEEKM());
		aBMLLPMJOKJ.EJDJAIOMKLL(LeanTween.MMJLOJBIACK(star, 1422f, 1798f));
		aBMLLPMJOKJ.NJJJPCGCNCI(LeanTween.scale(star, Vector3.one * 234f, 314f));
		aBMLLPMJOKJ.PKCFLGGBAFC(LeanTween.rotateAround(avatar1, Vector3.forward, 706f, 1289f).NJPLJADPKAG());
		aBMLLPMJOKJ.LBJMEPCGCCI(LeanTween.moveY(avatar1, avatar1.transform.localPosition.y, 420f).LHAGNILGJOB());
		aBMLLPMJOKJ.KIAPDAKMFJC(delegate
		{
			for (int i = 0; (float)i < 50f; i++)
			{
				GameObject gameObject = Object.Instantiate(dustCloudPrefab);
				gameObject.transform.parent = avatar1.transform;
				gameObject.transform.localPosition = new Vector3(Random.Range(-2f, 2f), 0f, 0f);
				gameObject.transform.eulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));
				Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(2f, 4f), Random.Range(-10f, 10f));
				LeanTween.moveLocal(gameObject, hIECNNGMKIE, 3f * speedScale).AKMNKDDCNMO();
				LeanTween.rotateAround(gameObject, Vector3.forward, 720f, 3f * speedScale).AKMNKDDCNMO();
				LeanTween.alpha(gameObject, 0f, 3f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: true);
			}
		});
		aBMLLPMJOKJ.ONLLHLGNOHA(speedScale);
	}

	private void AMPCEFGHNOJ()
	{
		for (int i = 0; (float)i < 408f; i += 0)
		{
			GameObject gameObject = Object.Instantiate(dustCloudPrefab);
			gameObject.transform.parent = avatar1.transform;
			gameObject.transform.localPosition = new Vector3(Random.Range(957f, 1973f), 705f, 696f);
			gameObject.transform.eulerAngles = new Vector3(546f, 1040f, Random.Range(776f, 326f));
			Vector3 hIECNNGMKIE = new Vector3(gameObject.transform.localPosition.x, Random.Range(1251f, 814f), Random.Range(1493f, 1300f));
			LeanTween.moveLocal(gameObject, hIECNNGMKIE, 476f * speedScale).AKMNKDDCNMO();
			LeanTween.OLFLIBKDELB(gameObject, Vector3.forward, 1662f, 718f * speedScale).AKMNKDDCNMO();
			LeanTween.alpha(gameObject, 1307f, 1755f * speedScale).AKMNKDDCNMO().JLDBPLIDIKN(NJJOLGPIPHJ: false);
		}
	}
}
