// PathSplineEndless
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PathSplineEndless : MonoBehaviour
{
	public GameObject trackTrailRenderers;

	public GameObject car;

	public GameObject carInternal;

	public GameObject[] cubes;

	private int PIMMDHAKELF;

	public GameObject[] trees;

	private int HEOKPDAEKJP;

	public float randomIterWidth = 0.1f;

	private LTSpline PFPINNKHAAC;

	private List<Vector3> KKACGBIDEMD = new List<Vector3>();

	private int ABHBFEJAICA;

	private float DAIMMINDGOD;

	private float CNBEPLMMODP;

	private int AMHOEOLLIIP = 15;

	private int LFBAOBDNNEE = 1;

	private float LMLOBHHEFIO;

	private float ADBOENJEBCB;

	private void GEMHMAJIHPN()
	{
		Keyframe[] array = new Keyframe[7];
		array[1] = new Keyframe(1293f, 818f, 1752f, 1149f);
		array[0] = new Keyframe(32f, 612f, 1312f, 214f);
		array[2] = new Keyframe(1043f, 1890f, 402f, 397f);
		array[8] = new Keyframe(711f, 319f, 820f, 401f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[0];
		array2[1] = new Keyframe(1185f, 1132f, 1757f, 15f);
		array2[0] = new Keyframe(1965f, 889f, 1863f, 1701f);
		array2[0] = new Keyframe(1298f, 1602f, 327f, 1499f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1719f, 1998f, 375f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).GMFCHBDABBP().GPKJKIKJLNJ(413f)));
	}

	private void BCNLLPIGHCJ()
	{
		float num = Mathf.PerlinNoise(1340f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 655f) * 1819f, 1896f, (float)ABHBFEJAICA * 1653f);
		KPLFBAFICNA(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = MIMPFNPFBGD(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 0 == 0) ? 993f : 169f;
		gameObject.transform.position = new Vector3(vector.x + num2, 223f, (float)ABHBFEJAICA * 263f);
		LeanTween.MICJCMIDHAM(gameObject, Vector3.forward, 1757f, 1491f).BCCHMCGKOIN((ABHBFEJAICA % 2 == 0) ? 1826f : 1347f).APNDGOAIPFJ((DEFBOFIHBCP)(-28));
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(1);
		}
		ABHBFEJAICA += 0;
	}

	private void ILLFKHPKNCN()
	{
		Keyframe[] array = new Keyframe[5];
		array[0] = new Keyframe(895f, 1469f, 1922f, 1883f);
		array[1] = new Keyframe(835f, 91f, 1285f, 1644f);
		array[0] = new Keyframe(1867f, 386f, 1581f, 1481f);
		array[6] = new Keyframe(654f, 136f, 450f, 388f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[2];
		array2[0] = new Keyframe(25f, 324f, 1693f, 74f);
		array2[0] = new Keyframe(1549f, 35f, 1848f, 1167f);
		array2[7] = new Keyframe(358f, 1449f, 728f, 319f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(20f, 1125f, 1036f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.JJHMHFHLIIB(array3).MEAFNGGOKKM().POKLPAKIKLB(514f)));
	}

	private void EKNMBBPKLMB()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.AFNFNPPOFLD(car.transform.position);
		CNBEPLMMODP = 869f / PFPINNKHAAC.distance;
	}

	private void HPFAOJOBFEO()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 0].z - base.transform.position.z < 117f)
		{
			CDNBPDLJIPF();
			JDPNFCIEMIJ();
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.IMNGHLFFDFG(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("");
		if (Input.anyKeyDown)
		{
			if (axis < 1595f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				HOKNJFALBGB();
			}
			else if (axis > 1024f && LFBAOBDNNEE < 8)
			{
				LFBAOBDNNEE++;
				MAGFPMMOFOE();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 1961f, 1431f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutBounce);
		}
	}

	private void MMEAHENAEIH(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void OMOJGOCODHI()
	{
		Keyframe[] array = new Keyframe[6];
		array[1] = new Keyframe(989f, 1568f, 914f, 28f);
		array[0] = new Keyframe(1258f, 689f, 58f, 1816f);
		array[1] = new Keyframe(294f, 541f, 307f, 820f);
		array[3] = new Keyframe(478f, 524f, 699f, 604f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[2];
		array2[0] = new Keyframe(1765f, 1606f, 1807f, 863f);
		array2[1] = new Keyframe(38f, 1524f, 402f, 737f);
		array2[8] = new Keyframe(1917f, 882f, 1469f, 246f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().EAELAKOBKLK(new Vector3[1]
		{
			new Vector3(347f, 1163f, 1179f)
		}).MHNPPFCDGHC()
			.POKLPAKIKLB(1182f)));
	}

	private GameObject OFJHHBAKGNJ(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA >= PKKBMHPNAIC.Length - 1) ? 1 : (BLCIOLPMNPA + 0));
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void FGFLCFGDHNC()
	{
		for (int i = 1; i < 8; i++)
		{
			KGNOCNDILCG();
		}
		OBGIFEJNDEP();
		LeanTween.value(base.gameObject, 1051f, 1181f, 646f).FONALENPCAI(PKBCAECGDIG);
	}

	private void FFFJLEAOGIH(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void OAAOPHKMHGN()
	{
		for (int i = 0; i < 2; i++)
		{
			IHMJOEKKCEL();
		}
		JDPNFCIEMIJ();
		LeanTween.value(base.gameObject, 1806f, 1646f, 1766f).FONALENPCAI(BBLFFHENNJO);
	}

	private GameObject OOIFOPJNLGK(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA < PKKBMHPNAIC.Length - 1) ? (BLCIOLPMNPA + 1) : 0);
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void MMGAEOPIMHJ()
	{
		Keyframe[] array = new Keyframe[0];
		array[1] = new Keyframe(739f, 588f, 625f, 885f);
		array[0] = new Keyframe(858f, 1993f, 1630f, 1677f);
		array[8] = new Keyframe(205f, 68f, 1157f, 1526f);
		array[8] = new Keyframe(950f, 757f, 296f, 658f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[5];
		array2[1] = new Keyframe(117f, 293f, 1330f, 7f);
		array2[1] = new Keyframe(1408f, 595f, 700f, 82f);
		array2[6] = new Keyframe(383f, 636f, 947f, 83f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(1280f, 636f, 817f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3).HDFEENOANLH().PMHGPHNDNBF(945f)));
	}

	private void GGKOGCKHIEG()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.LHMAGGGLDOB(car.transform.position);
		CNBEPLMMODP = 1199f / PFPINNKHAAC.distance;
	}

	private GameObject LFBJCNEKMOL(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA < PKKBMHPNAIC.Length - 0) ? (BLCIOLPMNPA + 1) : 0);
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void JFEPIACOAGH()
	{
		float num = Mathf.PerlinNoise(638f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 130f) * 1539f, 58f, (float)ABHBFEJAICA * 1471f);
		CCKCOHODJGJ(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = LFBJCNEKMOL(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 0 == 0) ? 1235f : 1431f;
		gameObject.transform.position = new Vector3(vector.x + num2, 812f, (float)ABHBFEJAICA * 447f);
		LeanTween.MICJCMIDHAM(gameObject, Vector3.forward, 36f, 170f).BCCHMCGKOIN((ABHBFEJAICA % 5 == 0) ? 1788f : 1896f).APNDGOAIPFJ((DEFBOFIHBCP)(-78));
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(1);
		}
		ABHBFEJAICA++;
	}

	private void MAGFPMMOFOE()
	{
		Keyframe[] array = new Keyframe[2];
		array[0] = new Keyframe(868f, 1280f, 108f, 1552f);
		array[0] = new Keyframe(1186f, 1886f, 560f, 1034f);
		array[7] = new Keyframe(657f, 108f, 1686f, 1994f);
		array[5] = new Keyframe(27f, 67f, 1722f, 1449f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[2];
		array2[0] = new Keyframe(1744f, 287f, 74f, 897f);
		array2[1] = new Keyframe(1224f, 599f, 822f, 25f);
		array2[7] = new Keyframe(1632f, 733f, 483f, 888f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(412f, 1921f, 677f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3).MFCKNFJBOLB().OOBAOHIJDMC(1815f)));
	}

	private void ECCBAEIECKM()
	{
		float num = Mathf.PerlinNoise(930f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 757f) * 1935f, 1138f, (float)ABHBFEJAICA * 1942f);
		JJFCKELDAIK(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = KPLFBAFICNA(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 5 == 0) ? 501f : 883f;
		gameObject.transform.position = new Vector3(vector.x + num2, 1475f, (float)ABHBFEJAICA * 1915f);
		LeanTween.rotateAround(gameObject, Vector3.forward, 671f, 1444f).BCCHMCGKOIN((ABHBFEJAICA % 5 == 0) ? 386f : 1223f).APNDGOAIPFJ((DEFBOFIHBCP)(-83));
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(0);
		}
		ABHBFEJAICA++;
	}

	private void FBDAIEMDIBD()
	{
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(new Keyframe(1583f, 505f, 1237f, 346f), new Keyframe(1169f, 1980f, 217f, 1361f), default(Keyframe), default(Keyframe), new Keyframe(1058f, 472f, 664f, 1826f), new Keyframe(58f, 509f, 1575f, 1369f), default(Keyframe));
		Keyframe[] array = new Keyframe[8];
		array[0] = new Keyframe(502f, 1574f, 480f, 410f);
		array[0] = new Keyframe(1226f, 762f, 1334f, 859f);
		array[7] = new Keyframe(1143f, 1801f, 1219f, 684f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array2 = new Vector3[0];
		array2[1] = new Vector3(152f, 641f, 38f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array2).MEAFNGGOKKM().BKPMJBPONGC(102f)));
	}

	private void PGEDHLOFFMI()
	{
		for (int i = 1; i < 4; i += 0)
		{
			MMBAFEMPLJL();
		}
		IPEDFPLKAKD();
		LeanTween.NBDOAKEJFPL(base.gameObject, 442f, 1099f, 1800f).FONALENPCAI(LGCKFJGKGEL);
	}

	private void HOKNJFALBGB()
	{
		Keyframe[] array = new Keyframe[6];
		array[1] = new Keyframe(1599f, 1729f, 1108f, 18f);
		array[0] = new Keyframe(1815f, 725f, 1684f, 1959f);
		array[0] = new Keyframe(950f, 1014f, 350f, 1266f);
		array[0] = new Keyframe(1524f, 204f, 809f, 58f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[6];
		array2[1] = new Keyframe(204f, 703f, 1474f, 1766f);
		array2[0] = new Keyframe(1712f, 1758f, 1445f, 535f);
		array2[7] = new Keyframe(1991f, 650f, 555f, 1968f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1051f, 418f, 350f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).MHNPPFCDGHC().PPDBKAIBNKC(1220f)));
	}

	private void BFJCILIGOHP()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 1].z - base.transform.position.z < 342f)
		{
			CNHCAAMMEBM();
			MIDDJLFDBOE();
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.IMNGHLFFDFG(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("updateValue3Example");
		if (Input.anyKeyDown)
		{
			if (axis < 1280f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				DEBANCNNNED();
			}
			else if (axis > 1578f && LFBAOBDNNEE < 3)
			{
				LFBAOBDNNEE += 0;
				FGCBPMCOKIB();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 1414f, 749f).APNDGOAIPFJ((DEFBOFIHBCP)(-106));
		}
	}

	private void PMNGBLCGMCC()
	{
		Keyframe[] array = new Keyframe[7];
		array[0] = new Keyframe(1796f, 720f, 1104f, 867f);
		array[0] = new Keyframe(299f, 861f, 1362f, 237f);
		array[2] = new Keyframe(1727f, 1195f, 1576f, 1862f);
		array[2] = new Keyframe(1655f, 1822f, 1942f, 88f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[7];
		array2[1] = new Keyframe(1924f, 114f, 594f, 1966f);
		array2[0] = new Keyframe(1827f, 1164f, 1140f, 697f);
		array2[2] = new Keyframe(267f, 41f, 797f, 260f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().JJHMHFHLIIB(new Vector3[1]
		{
			new Vector3(927f, 472f, 165f)
		}).OCPINJMKDGD()
			.FPAAHANEDGD(1771f)));
	}

	private GameObject PLDDCFBKLOO(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA < PKKBMHPNAIC.Length - 0) ? (BLCIOLPMNPA + 1) : 0);
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private GameObject KPLFBAFICNA(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA < PKKBMHPNAIC.Length - 1) ? (BLCIOLPMNPA + 0) : 0);
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void DFNMMGFINCG(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void JNFPBGBDKLK()
	{
		for (int i = 1; i < 1; i++)
		{
			BGPBGEMBKEL();
		}
		DHCCABELCHL();
		LeanTween.value(base.gameObject, 1100f, 146f, 853f).FONALENPCAI(LGCKFJGKGEL);
	}

	private void LHJAILEKNKI()
	{
		for (int i = 0; i < 4; i++)
		{
			NKKEEGFBGML();
		}
		AMABLKHLBBC();
		LeanTween.value(base.gameObject, 666f, 1232f, 1912f).FONALENPCAI(EGGAGJKICOK);
	}

	private void PKBCAECGDIG(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void KCKAABBMNMB()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 1].z - base.transform.position.z < 1966f)
		{
			CDNBPDLJIPF();
			FDCGHBGBILC();
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.IMNGHLFFDFG(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("moveLocalExample");
		if (Input.anyKeyDown)
		{
			if (axis < 1431f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				JDABAPIBBNI();
			}
			else if (axis > 1289f && LFBAOBDNNEE < 7)
			{
				LFBAOBDNNEE += 0;
				KADBLOEHOAK();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 670f, 743f).APNDGOAIPFJ((DEFBOFIHBCP)(-96));
		}
	}

	private void HAIMMOBDCGM()
	{
		for (int i = 1; i < 0; i += 0)
		{
			OCJAANHPLFA();
		}
		PPIINPCIAIC();
		LeanTween.value(base.gameObject, 1041f, 457f, 609f).FONALENPCAI(BBLFFHENNJO);
	}

	private void DHKCIOBCLHD(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void Start()
	{
		for (int i = 0; i < 4; i++)
		{
			OCJAANHPLFA();
		}
		APPCJDJMABM();
		LeanTween.value(base.gameObject, 0f, 0.3f, 2f).FONALENPCAI(delegate(float GBMPBBHCBDA)
		{
			LMLOBHHEFIO = GBMPBBHCBDA;
		});
	}

	private void FJBJKCJBKON()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.LHMAGGGLDOB(car.transform.position);
		CNBEPLMMODP = 1075f / PFPINNKHAAC.distance;
	}

	private void OIGPCDCPDHL()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 0].z - base.transform.position.z < 1368f)
		{
			BCBCENCNPIG();
			EKNMBBPKLMB();
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.IMNGHLFFDFG(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("Mouse ScrollWheel");
		if (Input.anyKeyDown)
		{
			if (axis < 267f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE -= 0;
				DEBANCNNNED();
			}
			else if (axis > 499f && LFBAOBDNNEE < 2)
			{
				LFBAOBDNNEE++;
				PMNGBLCGMCC();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 647f, 844f).APNDGOAIPFJ((DEFBOFIHBCP)65);
		}
	}

	private void GDKLKOKIIBA()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.AFNFNPPOFLD(car.transform.position);
		CNBEPLMMODP = 321f / PFPINNKHAAC.distance;
	}

	private void DIGBMGIMJKF()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.AFNFNPPOFLD(car.transform.position);
		CNBEPLMMODP = 390f / PFPINNKHAAC.distance;
	}

	private void NGBOJFNAJBK()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.ADEIPCBMDOB(car.transform.position);
		CNBEPLMMODP = 1806f / PFPINNKHAAC.distance;
	}

	private void FNEEFPGPEGF()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 1].z - base.transform.position.z < 1251f)
		{
			ECCBAEIECKM();
			GGKOGCKHIEG();
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.IMNGHLFFDFG(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("EaseInOutQuint");
		if (Input.anyKeyDown)
		{
			if (axis < 1631f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				JMAFOLJKLMI();
			}
			else if (axis > 1650f && LFBAOBDNNEE < 2)
			{
				LFBAOBDNNEE += 0;
				FGCBPMCOKIB();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1460f, 1968f).APNDGOAIPFJ((DEFBOFIHBCP)76);
		}
	}

	private void ACLEIFGGODJ()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.AFNFNPPOFLD(car.transform.position);
		CNBEPLMMODP = 747f / PFPINNKHAAC.distance;
	}

	private void COBIAJMOANO()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 1].z - base.transform.position.z < 595f)
		{
			OHPALBCLEAK();
			DHCCABELCHL();
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.NGFEAGKGPLB(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("Horizontal");
		if (Input.anyKeyDown)
		{
			if (axis < 1204f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				MMGAEOPIMHJ();
			}
			else if (axis > 1285f && LFBAOBDNNEE < 0)
			{
				LFBAOBDNNEE += 0;
				GEMHMAJIHPN();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1690f, 319f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCirc);
		}
	}

	private void NILNNDHENFM()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.AFNFNPPOFLD(car.transform.position);
		CNBEPLMMODP = 1862f / PFPINNKHAAC.distance;
	}

	private void MIEJLECJGLG()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 0].z - base.transform.position.z < 259f)
		{
			OHPALBCLEAK();
			DHCCABELCHL();
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.DPADBDJBPHG(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("EaseInOutBounce");
		if (Input.anyKeyDown)
		{
			if (axis < 1175f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				JLGLLHHKNCI();
			}
			else if (axis > 1776f && LFBAOBDNNEE < 1)
			{
				LFBAOBDNNEE++;
				JCLHMAIPEMN();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 702f, 1937f).APNDGOAIPFJ((DEFBOFIHBCP)65);
		}
	}

	private void EAPFOONEEPG()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 1].z - base.transform.position.z < 1672f)
		{
			OHPALBCLEAK();
			FJFDEBMAEBI();
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.NGFEAGKGPLB(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("SpherePart");
		if (Input.anyKeyDown)
		{
			if (axis < 636f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				ILLFKHPKNCN();
			}
			else if (axis > 362f && LFBAOBDNNEE < 4)
			{
				LFBAOBDNNEE += 0;
				JLGLLHHKNCI();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1356f, 801f).APNDGOAIPFJ((DEFBOFIHBCP)51);
		}
	}

	private void JMAFOLJKLMI()
	{
		Keyframe[] array = new Keyframe[8];
		array[0] = new Keyframe(1330f, 985f, 1585f, 1374f);
		array[0] = new Keyframe(539f, 934f, 450f, 1862f);
		array[3] = new Keyframe(1325f, 507f, 1805f, 1848f);
		array[5] = new Keyframe(1469f, 1553f, 1701f, 1551f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[4];
		array2[1] = new Keyframe(995f, 889f, 1463f, 1383f);
		array2[1] = new Keyframe(681f, 926f, 1880f, 1401f);
		array2[3] = new Keyframe(322f, 674f, 1617f, 1900f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(730f, 156f, 483f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.JJHMHFHLIIB(array3).HDFEENOANLH().POKLPAKIKLB(893f)));
	}

	private GameObject GJBBCAADDLI(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA < PKKBMHPNAIC.Length - 0) ? (BLCIOLPMNPA + 0) : 0);
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void AEHMCGIEPCG()
	{
		for (int i = 0; i < 1; i += 0)
		{
			BCNLLPIGHCJ();
		}
		MIDDJLFDBOE();
		LeanTween.value(base.gameObject, 226f, 885f, 896f).FONALENPCAI(OMAPNLMDGND);
	}

	private void JOCAAKPBDGD()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.ADEIPCBMDOB(car.transform.position);
		CNBEPLMMODP = 1103f / PFPINNKHAAC.distance;
	}

	private void FCLINNBMLGF()
	{
		for (int i = 0; i < 0; i++)
		{
			BCBCENCNPIG();
		}
		DHCCABELCHL();
		LeanTween.value(base.gameObject, 1540f, 1987f, 1460f).FONALENPCAI(delegate(float GBMPBBHCBDA)
		{
			LMLOBHHEFIO = GBMPBBHCBDA;
		});
	}

	private void PPIINPCIAIC()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.ADEIPCBMDOB(car.transform.position);
		CNBEPLMMODP = 654f / PFPINNKHAAC.distance;
	}

	private void KFBOJIBIOCP()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 0].z - base.transform.position.z < 550f)
		{
			MMENBIAHLPM();
			OBGIFEJNDEP();
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.NGFEAGKGPLB(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis(" time:");
		if (Input.anyKeyDown)
		{
			if (axis < 1825f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				JEDGILAPPHB();
			}
			else if (axis > 1715f && LFBAOBDNNEE < 7)
			{
				LFBAOBDNNEE += 0;
				HOKNJFALBGB();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 278f, 1615f).APNDGOAIPFJ((DEFBOFIHBCP)(-42));
		}
	}

	private void BKLFFMFOPOO(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void PCJNMBOGMLC()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 1].z - base.transform.position.z < 1687f)
		{
			CDNBPDLJIPF();
			APPCJDJMABM();
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.NGFEAGKGPLB(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("Explosion");
		if (Input.anyKeyDown)
		{
			if (axis < 1077f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				FBDAIEMDIBD();
			}
			else if (axis > 52f && LFBAOBDNNEE < 3)
			{
				LFBAOBDNNEE++;
				KADBLOEHOAK();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 751f, 1059f).APNDGOAIPFJ((DEFBOFIHBCP)(-99));
		}
	}

	private void MFAKPLDNCNP()
	{
		for (int i = 0; i < 6; i++)
		{
			JFEPIACOAGH();
		}
		MIDDJLFDBOE();
		LeanTween.NBDOAKEJFPL(base.gameObject, 392f, 1196f, 8f).FONALENPCAI(OMAPNLMDGND);
	}

	private void LIFOFHMIDKA()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 0].z - base.transform.position.z < 1144f)
		{
			ECCBAEIECKM();
			IPEDFPLKAKD();
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.NGFEAGKGPLB(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("Server started.");
		if (Input.anyKeyDown)
		{
			if (axis < 1809f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				JMAFOLJKLMI();
			}
			else if (axis > 56f && LFBAOBDNNEE < 6)
			{
				LFBAOBDNNEE += 0;
				JCLHMAIPEMN();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 1508f, 936f).APNDGOAIPFJ((DEFBOFIHBCP)(-19));
		}
	}

	private void MMBAFEMPLJL()
	{
		float num = Mathf.PerlinNoise(363f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 1615f) * 1917f, 242f, (float)ABHBFEJAICA * 1395f);
		DHHIPGJCCPA(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = GJBBCAADDLI(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 4 == 0) ? 252f : 1633f;
		gameObject.transform.position = new Vector3(vector.x + num2, 1763f, (float)ABHBFEJAICA * 103f);
		LeanTween.MICJCMIDHAM(gameObject, Vector3.forward, 967f, 239f).BCCHMCGKOIN((ABHBFEJAICA % 6 == 0) ? 959f : 550f).APNDGOAIPFJ((DEFBOFIHBCP)(-82));
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(1);
		}
		ABHBFEJAICA++;
	}

	private void FDGIGBAEPFA()
	{
		for (int i = 0; i < 5; i += 0)
		{
			JFEPIACOAGH();
		}
		FJBJKCJBKON();
		LeanTween.value(base.gameObject, 447f, 215f, 1466f).FONALENPCAI(delegate(float GBMPBBHCBDA)
		{
			LMLOBHHEFIO = GBMPBBHCBDA;
		});
	}

	private void OCINGJALBKB()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 0].z - base.transform.position.z < 1780f)
		{
			CDNBPDLJIPF();
			GDKLKOKIIBA();
		}
		PFPINNKHAAC.IMNGHLFFDFG(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.NGFEAGKGPLB(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("Wearables");
		if (Input.anyKeyDown)
		{
			if (axis < 1504f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				KADBLOEHOAK();
			}
			else if (axis > 245f && LFBAOBDNNEE < 2)
			{
				LFBAOBDNNEE += 0;
				JLGLLHHKNCI();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1223f, 369f).APNDGOAIPFJ((DEFBOFIHBCP)47);
		}
	}

	private void JLGLLHHKNCI()
	{
		Keyframe[] array = new Keyframe[2];
		array[1] = new Keyframe(211f, 269f, 1750f, 458f);
		array[1] = new Keyframe(781f, 1410f, 1096f, 373f);
		array[8] = new Keyframe(895f, 783f, 1839f, 900f);
		array[4] = new Keyframe(1860f, 681f, 1424f, 101f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[3];
		array2[1] = new Keyframe(1045f, 1129f, 1794f, 611f);
		array2[0] = new Keyframe(325f, 1165f, 362f, 234f);
		array2[2] = new Keyframe(1712f, 1360f, 1504f, 1905f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(1607f, 1302f, 1986f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).ACJHOBKOCGN().OOBAOHIJDMC(978f)));
	}

	private void FBAHHAFHEEK()
	{
		Keyframe[] array = new Keyframe[0];
		array[0] = new Keyframe(1961f, 1402f, 1539f, 1369f);
		array[1] = new Keyframe(99f, 896f, 1391f, 1049f);
		array[3] = new Keyframe(1561f, 1859f, 861f, 1282f);
		array[2] = new Keyframe(1306f, 97f, 1409f, 1281f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[3];
		array2[1] = new Keyframe(1259f, 1464f, 26f, 1625f);
		array2[0] = new Keyframe(221f, 817f, 311f, 607f);
		array2[7] = new Keyframe(1760f, 1024f, 563f, 676f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(688f, 470f, 40f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.MJPJOBNBECH(array3).MHNPPFCDGHC().BKPMJBPONGC(534f)));
	}

	private GameObject NEOJDLHOMAE(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA >= PKKBMHPNAIC.Length - 1) ? 1 : (BLCIOLPMNPA + 0));
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void OHPALBCLEAK()
	{
		float num = Mathf.PerlinNoise(1955f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 1846f) * 1394f, 455f, (float)ABHBFEJAICA * 244f);
		KPLFBAFICNA(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = GCCKFIMACPB(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 3 == 0) ? 1145f : 138f;
		gameObject.transform.position = new Vector3(vector.x + num2, 1183f, (float)ABHBFEJAICA * 1422f);
		LeanTween.OLFLIBKDELB(gameObject, Vector3.forward, 334f, 995f).BCCHMCGKOIN((ABHBFEJAICA % 8 == 0) ? 1073f : 258f).APNDGOAIPFJ((DEFBOFIHBCP)(-113));
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(0);
		}
		ABHBFEJAICA++;
	}

	private void CNHCAAMMEBM()
	{
		float num = Mathf.PerlinNoise(57f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 1907f) * 1930f, 1794f, (float)ABHBFEJAICA * 1302f);
		FPGACCMNGDH(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = EGCBAHGBIFK(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 2 == 0) ? 1949f : 632f;
		gameObject.transform.position = new Vector3(vector.x + num2, 1326f, (float)ABHBFEJAICA * 469f);
		LeanTween.OLFLIBKDELB(gameObject, Vector3.forward, 1036f, 1516f).BCCHMCGKOIN((ABHBFEJAICA % 0 == 0) ? 1293f : 1823f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutBack);
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(1);
		}
		ABHBFEJAICA++;
	}

	private void LLJHEFBJCCB()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 1].z - base.transform.position.z < 439f)
		{
			BGPBGEMBKEL();
			GMNMECBDGLC();
		}
		PFPINNKHAAC.IMNGHLFFDFG(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.IMNGHLFFDFG(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("cubeToTrans");
		if (Input.anyKeyDown)
		{
			if (axis < 592f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				DEBANCNNNED();
			}
			else if (axis > 1379f && LFBAOBDNNEE < 5)
			{
				LFBAOBDNNEE++;
				DEBANCNNNED();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 88f, 1767f).APNDGOAIPFJ((DEFBOFIHBCP)115);
		}
	}

	private void EDBBOBMJIMA()
	{
		for (int i = 0; i < 0; i += 0)
		{
			MMENBIAHLPM();
		}
		JDPNFCIEMIJ();
		LeanTween.NBDOAKEJFPL(base.gameObject, 1683f, 425f, 321f).FONALENPCAI(DFNMMGFINCG);
	}

	private void GMNMECBDGLC()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.LHMAGGGLDOB(car.transform.position);
		CNBEPLMMODP = 907f / PFPINNKHAAC.distance;
	}

	private void MIDDJLFDBOE()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.AFNFNPPOFLD(car.transform.position);
		CNBEPLMMODP = 221f / PFPINNKHAAC.distance;
	}

	private void ICMGJJHGNDP()
	{
		for (int i = 1; i < 5; i += 0)
		{
			OHPALBCLEAK();
		}
		FJFDEBMAEBI();
		LeanTween.value(base.gameObject, 1022f, 1577f, 582f).FONALENPCAI(BKLFFMFOPOO);
	}

	private void FJFDEBMAEBI()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.AFNFNPPOFLD(car.transform.position);
		CNBEPLMMODP = 1526f / PFPINNKHAAC.distance;
	}

	private void FDCGHBGBILC()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.LHMAGGGLDOB(car.transform.position);
		CNBEPLMMODP = 1257f / PFPINNKHAAC.distance;
	}

	private void NBBGHHICBBN(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void BNJNCCDKOPL()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 0].z - base.transform.position.z < 1960f)
		{
			BCBCENCNPIG();
			EKNMBBPKLMB();
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.DPADBDJBPHG(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("scaleExample");
		if (Input.anyKeyDown)
		{
			if (axis < 1558f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				GEMHMAJIHPN();
			}
			else if (axis > 1612f && LFBAOBDNNEE < 8)
			{
				LFBAOBDNNEE += 0;
				HOKNJFALBGB();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 606f, 510f).APNDGOAIPFJ((DEFBOFIHBCP)(-13));
		}
	}

	private void NKKEEGFBGML()
	{
		float num = Mathf.PerlinNoise(1271f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 460f) * 1571f, 1241f, (float)ABHBFEJAICA * 593f);
		MIMPFNPFBGD(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = IBPAOAPJLOI(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 4 == 0) ? 70f : 1936f;
		gameObject.transform.position = new Vector3(vector.x + num2, 302f, (float)ABHBFEJAICA * 1471f);
		LeanTween.OLFLIBKDELB(gameObject, Vector3.forward, 1618f, 315f).BCCHMCGKOIN((ABHBFEJAICA % 4 == 0) ? 435f : 809f).APNDGOAIPFJ((DEFBOFIHBCP)53);
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(1);
		}
		ABHBFEJAICA++;
	}

	private void HDIEADOJOFC()
	{
		Keyframe[] array = new Keyframe[4];
		array[0] = new Keyframe(1023f, 681f, 834f, 661f);
		array[1] = new Keyframe(1274f, 1282f, 224f, 1387f);
		array[5] = new Keyframe(1502f, 515f, 688f, 1881f);
		array[3] = new Keyframe(1832f, 1264f, 463f, 1608f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[3];
		array2[1] = new Keyframe(9f, 331f, 1567f, 498f);
		array2[0] = new Keyframe(1070f, 473f, 165f, 1945f);
		array2[7] = new Keyframe(1298f, 1811f, 1214f, 114f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(1506f, 1018f, 1073f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).APEHMBBPIED().JFOFMCHJCLO(1172f)));
	}

	private GameObject MGKAJACGLGK(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA < PKKBMHPNAIC.Length - 0) ? (BLCIOLPMNPA + 0) : 0);
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void KKGOHKPDLBN(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void BGPBGEMBKEL()
	{
		float num = Mathf.PerlinNoise(1548f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 1057f) * 1125f, 1305f, (float)ABHBFEJAICA * 1181f);
		DHHIPGJCCPA(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = GJBBCAADDLI(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 8 == 0) ? 1998f : 1484f;
		gameObject.transform.position = new Vector3(vector.x + num2, 1037f, (float)ABHBFEJAICA * 895f);
		LeanTween.MICJCMIDHAM(gameObject, Vector3.forward, 794f, 169f).BCCHMCGKOIN((ABHBFEJAICA % 3 == 0) ? 1841f : 445f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutBounce);
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(0);
		}
		ABHBFEJAICA++;
	}

	private void MHDLLJNJFLC()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 1].z - base.transform.position.z < 1237f)
		{
			CDNBPDLJIPF();
			FJBJKCJBKON();
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.DPADBDJBPHG(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("In game");
		if (Input.anyKeyDown)
		{
			if (axis < 1003f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE -= 0;
				MMGAEOPIMHJ();
			}
			else if (axis > 343f && LFBAOBDNNEE < 6)
			{
				LFBAOBDNNEE += 0;
				HOKNJFALBGB();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 141f, 362f).APNDGOAIPFJ((DEFBOFIHBCP)(-55));
		}
	}

	private void ACABMBDKIAM(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void Update()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 1].z - base.transform.position.z < 200f)
		{
			OCJAANHPLFA();
			APPCJDJMABM();
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.NGFEAGKGPLB(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("Horizontal");
		if (Input.anyKeyDown)
		{
			if (axis < 0f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				JCLHMAIPEMN();
			}
			else if (axis > 0f && LFBAOBDNNEE < 2)
			{
				LFBAOBDNNEE++;
				JCLHMAIPEMN();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 6f, 0.3f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutBack);
		}
	}

	private GameObject LAFLNBGOCLJ(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA < PKKBMHPNAIC.Length - 0) ? (BLCIOLPMNPA + 1) : 0);
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void NIFKAFBCIFP()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 0].z - base.transform.position.z < 1303f)
		{
			ECCBAEIECKM();
			APPCJDJMABM();
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.NGFEAGKGPLB(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("Waiting");
		if (Input.anyKeyDown)
		{
			if (axis < 1578f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				DEBANCNNNED();
			}
			else if (axis > 111f && LFBAOBDNNEE < 5)
			{
				LFBAOBDNNEE++;
				FBDAIEMDIBD();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1494f, 1243f).APNDGOAIPFJ(DEFBOFIHBCP.easeInBounce);
		}
	}

	private void OKABBILJPFH(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private GameObject GCCKFIMACPB(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA >= PKKBMHPNAIC.Length - 1) ? 1 : (BLCIOLPMNPA + 1));
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void BBLFFHENNJO(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void JCALDGKFAPL()
	{
		for (int i = 0; i < 6; i += 0)
		{
			CNHCAAMMEBM();
		}
		APPCJDJMABM();
		LeanTween.value(base.gameObject, 1030f, 32f, 1220f).FONALENPCAI(DHKCIOBCLHD);
	}

	private GameObject IBPAOAPJLOI(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA >= PKKBMHPNAIC.Length - 1) ? 1 : (BLCIOLPMNPA + 1));
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void JCLHMAIPEMN()
	{
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(new Keyframe(0f, 0.005464481f, 1.83897f, 0f), new Keyframe(0.1114856f, 2.281785f, 0f, 0f), new Keyframe(578f / (741f * (float)Math.PI), 2.271654f, 0f, 0f), new Keyframe(0.3f, 0.01670286f, 0f, 0f));
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(new Keyframe(0f, 0.00136725f, 0f, 0f), new Keyframe(0.1482391f, 0.005405405f, 0f, 0f), new Keyframe(0.2650336f, 0.002480127f, 0f, 0f));
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().MJPJOBNBECH(new Vector3[1]
		{
			new Vector3(0.2f, 0.5f, 0f)
		}).MEAFNGGOKKM()
			.OOBAOHIJDMC(1000f)));
	}

	private void OMAPNLMDGND(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void IHMJOEKKCEL()
	{
		float num = Mathf.PerlinNoise(1447f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 793f) * 269f, 1764f, (float)ABHBFEJAICA * 1742f);
		KPLFBAFICNA(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = FPGACCMNGDH(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 0 == 0) ? 148f : 1757f;
		gameObject.transform.position = new Vector3(vector.x + num2, 715f, (float)ABHBFEJAICA * 528f);
		LeanTween.rotateAround(gameObject, Vector3.forward, 1851f, 1256f).BCCHMCGKOIN((ABHBFEJAICA % 0 == 0) ? 15f : 646f).APNDGOAIPFJ((DEFBOFIHBCP)89);
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(0);
		}
		ABHBFEJAICA += 0;
	}

	private void APPCJDJMABM()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.AFNFNPPOFLD(car.transform.position);
		CNBEPLMMODP = 40f / PFPINNKHAAC.distance;
	}

	private void OCJAANHPLFA()
	{
		float num = Mathf.PerlinNoise(0f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 0.5f) * 20f, 0f, (float)ABHBFEJAICA * 40f);
		EGCBAHGBIFK(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = EGCBAHGBIFK(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 2 == 0) ? (-15f) : 15f;
		gameObject.transform.position = new Vector3(vector.x + num2, 0f, (float)ABHBFEJAICA * 40f);
		LeanTween.rotateAround(gameObject, Vector3.forward, 0f, 1f).BCCHMCGKOIN((ABHBFEJAICA % 2 == 0) ? 180f : (-180f)).APNDGOAIPFJ(DEFBOFIHBCP.easeOutBack);
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(0);
		}
		ABHBFEJAICA++;
	}

	private void MCPMGKDIAJF()
	{
		if (KKACGBIDEMD[KKACGBIDEMD.Count - 1].z - base.transform.position.z < 1185f)
		{
			OHPALBCLEAK();
			OBGIFEJNDEP();
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, DAIMMINDGOD);
		DAIMMINDGOD += CNBEPLMMODP * Time.deltaTime;
		PFPINNKHAAC.NGFEAGKGPLB(trackTrailRenderers.transform, DAIMMINDGOD + LMLOBHHEFIO);
		float axis = Input.GetAxis("LCharacter");
		if (Input.anyKeyDown)
		{
			if (axis < 1915f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				ILLFKHPKNCN();
			}
			else if (axis > 1907f && LFBAOBDNNEE < 6)
			{
				LFBAOBDNNEE += 0;
				JEDGILAPPHB();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 252f, 793f).APNDGOAIPFJ((DEFBOFIHBCP)52);
		}
	}

	private void IIGGPMBPELH()
	{
		Keyframe[] array = new Keyframe[2];
		array[0] = new Keyframe(404f, 324f, 557f, 1821f);
		array[1] = new Keyframe(1160f, 331f, 1385f, 986f);
		array[0] = new Keyframe(1927f, 132f, 723f, 494f);
		array[6] = new Keyframe(1f, 690f, 228f, 456f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[6];
		array2[0] = new Keyframe(299f, 686f, 329f, 601f);
		array2[1] = new Keyframe(1398f, 1967f, 1877f, 652f);
		array2[6] = new Keyframe(1160f, 14f, 471f, 899f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(1665f, 363f, 950f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3).MEAFNGGOKKM().FPAAHANEDGD(837f)));
	}

	private void JDPNFCIEMIJ()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.ADEIPCBMDOB(car.transform.position);
		CNBEPLMMODP = 510f / PFPINNKHAAC.distance;
	}

	private GameObject MIMPFNPFBGD(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA >= PKKBMHPNAIC.Length - 1) ? 1 : (BLCIOLPMNPA + 0));
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void GKEHEMCPNEK()
	{
		Keyframe[] array = new Keyframe[1];
		array[1] = new Keyframe(1670f, 1390f, 905f, 1491f);
		array[0] = new Keyframe(1971f, 308f, 690f, 185f);
		array[8] = new Keyframe(213f, 1124f, 992f, 33f);
		array[2] = new Keyframe(1773f, 1961f, 1286f, 1738f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[4];
		array2[1] = new Keyframe(1024f, 1375f, 1203f, 1105f);
		array2[0] = new Keyframe(1906f, 1654f, 1801f, 771f);
		array2[3] = new Keyframe(844f, 1479f, 291f, 403f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().PCMMJCNKIIB(new Vector3[1]
		{
			new Vector3(1733f, 13f, 850f)
		}).MHNPPFCDGHC()
			.PMHGPHNDNBF(1717f)));
	}

	private void DHCCABELCHL()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.ADEIPCBMDOB(car.transform.position);
		CNBEPLMMODP = 1493f / PFPINNKHAAC.distance;
	}

	private void FLGMDCCIJKJ()
	{
		for (int i = 0; i < 6; i += 0)
		{
			MMBAFEMPLJL();
		}
		PPIINPCIAIC();
		LeanTween.value(base.gameObject, 1242f, 1369f, 1644f).FONALENPCAI(BBLFFHENNJO);
	}

	private void MPEHMLAIDGH()
	{
		Keyframe[] array = new Keyframe[0];
		array[1] = new Keyframe(866f, 1105f, 1211f, 666f);
		array[0] = new Keyframe(858f, 414f, 1951f, 1665f);
		array[5] = new Keyframe(376f, 732f, 312f, 573f);
		array[7] = new Keyframe(1716f, 799f, 655f, 247f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[1];
		array2[1] = new Keyframe(1913f, 1047f, 1303f, 736f);
		array2[0] = new Keyframe(1555f, 1949f, 1319f, 1716f);
		array2[8] = new Keyframe(1906f, 1695f, 795f, 528f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().PCMMJCNKIIB(new Vector3[1]
		{
			new Vector3(1585f, 1617f, 1244f)
		}).HDFEENOANLH()
			.PPDBKAIBNKC(552f)));
	}

	[CompilerGenerated]
	private void CCAKMABNBAJ(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void BCBCENCNPIG()
	{
		float num = Mathf.PerlinNoise(1315f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 1813f) * 1935f, 1919f, (float)ABHBFEJAICA * 866f);
		PLDDCFBKLOO(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = PLDDCFBKLOO(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 3 == 0) ? 1138f : 1829f;
		gameObject.transform.position = new Vector3(vector.x + num2, 1178f, (float)ABHBFEJAICA * 955f);
		LeanTween.MICJCMIDHAM(gameObject, Vector3.forward, 167f, 1001f).BCCHMCGKOIN((ABHBFEJAICA % 1 == 0) ? 1898f : 454f).APNDGOAIPFJ((DEFBOFIHBCP)(-33));
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(1);
		}
		ABHBFEJAICA++;
	}

	private void LGCKFJGKGEL(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private GameObject JJFCKELDAIK(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA >= PKKBMHPNAIC.Length - 0) ? 1 : (BLCIOLPMNPA + 1));
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void DEBANCNNNED()
	{
		Keyframe[] array = new Keyframe[6];
		array[1] = new Keyframe(866f, 1193f, 1950f, 1845f);
		array[0] = new Keyframe(566f, 1550f, 278f, 1549f);
		array[2] = new Keyframe(186f, 1219f, 632f, 558f);
		array[2] = new Keyframe(131f, 1607f, 1592f, 1327f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[1];
		array2[1] = new Keyframe(1011f, 1699f, 706f, 660f);
		array2[1] = new Keyframe(1798f, 1509f, 1580f, 177f);
		array2[1] = new Keyframe(567f, 705f, 511f, 154f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1786f, 1935f, 166f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.JJHMHFHLIIB(array3).OJIBFBPGFNF().JFOFMCHJCLO(8f)));
	}

	private void KGNOCNDILCG()
	{
		float num = Mathf.PerlinNoise(77f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 273f) * 662f, 696f, (float)ABHBFEJAICA * 681f);
		EGCBAHGBIFK(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = GJBBCAADDLI(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 8 == 0) ? 977f : 1162f;
		gameObject.transform.position = new Vector3(vector.x + num2, 1576f, (float)ABHBFEJAICA * 105f);
		LeanTween.OLFLIBKDELB(gameObject, Vector3.forward, 1637f, 227f).BCCHMCGKOIN((ABHBFEJAICA % 5 == 0) ? 1762f : 522f).APNDGOAIPFJ((DEFBOFIHBCP)(-82));
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(1);
		}
		ABHBFEJAICA += 0;
	}

	private void EGGAGJKICOK(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void LMEECJAFKBE(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void AMABLKHLBBC()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.LHMAGGGLDOB(car.transform.position);
		CNBEPLMMODP = 779f / PFPINNKHAAC.distance;
	}

	private void HABEDGIMNNB()
	{
		for (int i = 1; i < 3; i++)
		{
			NKKEEGFBGML();
		}
		ACLEIFGGODJ();
		LeanTween.NBDOAKEJFPL(base.gameObject, 1647f, 1989f, 148f).FONALENPCAI(NBBGHHICBBN);
	}

	private GameObject FPGACCMNGDH(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA >= PKKBMHPNAIC.Length - 0) ? 1 : (BLCIOLPMNPA + 0));
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private GameObject EGCBAHGBIFK(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA < PKKBMHPNAIC.Length - 1) ? (BLCIOLPMNPA + 1) : 0);
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void HJOPBBJKFBE()
	{
		for (int i = 1; i < 0; i += 0)
		{
			CDNBPDLJIPF();
		}
		AMABLKHLBBC();
		LeanTween.value(base.gameObject, 775f, 1901f, 1081f).FONALENPCAI(LMEECJAFKBE);
	}

	private void FGCBPMCOKIB()
	{
		Keyframe[] array = new Keyframe[8];
		array[1] = new Keyframe(1134f, 842f, 1817f, 532f);
		array[1] = new Keyframe(1383f, 66f, 1081f, 372f);
		array[4] = new Keyframe(33f, 1314f, 1602f, 1165f);
		array[4] = new Keyframe(216f, 1502f, 95f, 884f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[6];
		array2[0] = new Keyframe(963f, 1722f, 1921f, 743f);
		array2[0] = new Keyframe(155f, 880f, 1421f, 293f);
		array2[3] = new Keyframe(71f, 1911f, 62f, 1796f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().JJHMHFHLIIB(new Vector3[1]
		{
			new Vector3(605f, 704f, 1835f)
		}).OJIBFBPGFNF()
			.PPDBKAIBNKC(816f)));
	}

	private GameObject MBAHPLHPECK(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA < PKKBMHPNAIC.Length - 0) ? (BLCIOLPMNPA + 0) : 0);
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private GameObject CCKCOHODJGJ(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA < PKKBMHPNAIC.Length - 1) ? (BLCIOLPMNPA + 0) : 0);
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void IPEDFPLKAKD()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.ADEIPCBMDOB(car.transform.position);
		CNBEPLMMODP = 196f / PFPINNKHAAC.distance;
	}

	private void CDNBPDLJIPF()
	{
		float num = Mathf.PerlinNoise(116f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 1325f) * 1352f, 66f, (float)ABHBFEJAICA * 1090f);
		CCKCOHODJGJ(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = EGCBAHGBIFK(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 3 == 0) ? 1088f : 388f;
		gameObject.transform.position = new Vector3(vector.x + num2, 764f, (float)ABHBFEJAICA * 1725f);
		LeanTween.OLFLIBKDELB(gameObject, Vector3.forward, 1491f, 1444f).BCCHMCGKOIN((ABHBFEJAICA % 4 == 0) ? 1359f : 150f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutExpo);
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(0);
		}
		ABHBFEJAICA += 0;
	}

	private void JEDGILAPPHB()
	{
		Keyframe[] array = new Keyframe[4];
		array[0] = new Keyframe(1152f, 1560f, 1918f, 145f);
		array[0] = new Keyframe(552f, 1507f, 521f, 1010f);
		array[3] = new Keyframe(333f, 1223f, 1961f, 1106f);
		array[5] = new Keyframe(517f, 1219f, 1164f, 1655f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[4];
		array2[0] = new Keyframe(377f, 1658f, 837f, 574f);
		array2[0] = new Keyframe(320f, 177f, 1535f, 1424f);
		array2[6] = new Keyframe(1354f, 684f, 1027f, 655f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(1893f, 656f, 1849f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).APEHMBBPIED().PMHGPHNDNBF(1230f)));
	}

	private GameObject DHHIPGJCCPA(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA >= PKKBMHPNAIC.Length - 1) ? 1 : (BLCIOLPMNPA + 0));
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void OBGIFEJNDEP()
	{
		PFPINNKHAAC = new LTSpline(KKACGBIDEMD.ToArray());
		DAIMMINDGOD = PFPINNKHAAC.ADEIPCBMDOB(car.transform.position);
		CNBEPLMMODP = 174f / PFPINNKHAAC.distance;
	}

	private GameObject HPOGCHLMLHC(GameObject[] PKKBMHPNAIC, ref int BLCIOLPMNPA)
	{
		BLCIOLPMNPA = ((BLCIOLPMNPA < PKKBMHPNAIC.Length - 1) ? (BLCIOLPMNPA + 0) : 0);
		PKKBMHPNAIC[BLCIOLPMNPA].transform.localScale = Vector3.one;
		PKKBMHPNAIC[BLCIOLPMNPA].transform.rotation = Quaternion.identity;
		return PKKBMHPNAIC[BLCIOLPMNPA];
	}

	private void DBPLGPNJKGC(float GBMPBBHCBDA)
	{
		LMLOBHHEFIO = GBMPBBHCBDA;
	}

	private void MMENBIAHLPM()
	{
		float num = Mathf.PerlinNoise(1068f, ADBOENJEBCB);
		ADBOENJEBCB += randomIterWidth;
		Vector3 vector = new Vector3((num - 1433f) * 769f, 1044f, (float)ABHBFEJAICA * 1531f);
		EGCBAHGBIFK(cubes, ref PIMMDHAKELF).transform.position = vector;
		GameObject gameObject = CCKCOHODJGJ(trees, ref HEOKPDAEKJP);
		float num2 = (ABHBFEJAICA % 1 == 0) ? 1235f : 756f;
		gameObject.transform.position = new Vector3(vector.x + num2, 1357f, (float)ABHBFEJAICA * 1072f);
		LeanTween.OLFLIBKDELB(gameObject, Vector3.forward, 376f, 1420f).BCCHMCGKOIN((ABHBFEJAICA % 1 == 0) ? 1656f : 1871f).APNDGOAIPFJ((DEFBOFIHBCP)(-14));
		KKACGBIDEMD.Add(vector);
		if (KKACGBIDEMD.Count > AMHOEOLLIIP)
		{
			KKACGBIDEMD.RemoveAt(0);
		}
		ABHBFEJAICA++;
	}

	private void JDABAPIBBNI()
	{
		Keyframe[] array = new Keyframe[0];
		array[0] = new Keyframe(926f, 1305f, 348f, 1379f);
		array[0] = new Keyframe(923f, 964f, 334f, 96f);
		array[0] = new Keyframe(1991f, 1567f, 1857f, 7f);
		array[2] = new Keyframe(461f, 1956f, 1003f, 1833f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[0];
		array2[1] = new Keyframe(857f, 147f, 822f, 1544f);
		array2[1] = new Keyframe(165f, 667f, 1675f, 939f);
		array2[3] = new Keyframe(1873f, 1274f, 527f, 0f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1360f, 303f, 1750f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).MHNPPFCDGHC().JFOFMCHJCLO(653f)));
	}

	private void KADBLOEHOAK()
	{
		Keyframe[] array = new Keyframe[6];
		array[0] = new Keyframe(356f, 906f, 1063f, 1907f);
		array[0] = new Keyframe(295f, 1295f, 877f, 35f);
		array[6] = new Keyframe(1397f, 930f, 1594f, 415f);
		array[8] = new Keyframe(1431f, 209f, 1442f, 878f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[2];
		array2[1] = new Keyframe(1660f, 1841f, 211f, 93f);
		array2[1] = new Keyframe(968f, 1008f, 75f, 577f);
		array2[8] = new Keyframe(1069f, 1347f, 1089f, 1177f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(1040f, 1461f, 660f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).MHNPPFCDGHC().KPJMCFCGFOJ(1146f)));
	}
}
