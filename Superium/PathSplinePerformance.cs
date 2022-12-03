// PathSplinePerformance
using System;
using System.Collections.Generic;
using UnityEngine;

public class PathSplinePerformance : MonoBehaviour
{
	public GameObject trackTrailRenderers;

	public GameObject car;

	public GameObject carInternal;

	public float circleLength = 10f;

	public float randomRange = 1f;

	public int trackNodes = 30;

	public float carSpeed = 30f;

	public float tracerSpeed = 2f;

	private LTSpline PFPINNKHAAC;

	private int LFBAOBDNNEE = 1;

	private float CNBEPLMMODP;

	private float LGPBALPFNIG;

	private void DIILHMODGEI()
	{
		Keyframe[] array = new Keyframe[7];
		array[1] = new Keyframe(1161f, 1867f, 1547f, 1685f);
		array[0] = new Keyframe(867f, 1889f, 84f, 441f);
		array[8] = new Keyframe(191f, 1647f, 789f, 1345f);
		array[8] = new Keyframe(535f, 39f, 412f, 1952f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[0];
		array2[1] = new Keyframe(732f, 545f, 1694f, 1401f);
		array2[1] = new Keyframe(419f, 622f, 1425f, 1452f);
		array2[5] = new Keyframe(567f, 1118f, 1627f, 1254f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(688f, 1026f, 955f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3).OJIBFBPGFNF().PMHGPHNDNBF(1468f)));
	}

	private void NNDNGANOIKC()
	{
		Keyframe[] array = new Keyframe[8];
		array[0] = new Keyframe(1259f, 1859f, 864f, 569f);
		array[0] = new Keyframe(1838f, 1045f, 670f, 413f);
		array[6] = new Keyframe(110f, 274f, 332f, 1302f);
		array[1] = new Keyframe(16f, 663f, 1257f, 65f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[0];
		array2[0] = new Keyframe(744f, 529f, 445f, 633f);
		array2[0] = new Keyframe(584f, 217f, 55f, 1927f);
		array2[7] = new Keyframe(349f, 1110f, 1062f, 889f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(1292f, 115f, 1293f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.MJPJOBNBECH(array3).MEAFNGGOKKM().OOBAOHIJDMC(214f)));
	}

	private void HCJIEPAJHFH()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.FIBAEAMBAPC(Color.red);
		}
	}

	private void NMHCPHPJLHL()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.HBCHHDFLHDK(Color.red);
		}
	}

	private void PMBGGMKCNAB()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.BENOKCIFBGE(Color.red);
		}
	}

	private void HPNNDALLHFO()
	{
		Keyframe[] array = new Keyframe[0];
		array[1] = new Keyframe(1285f, 410f, 1500f, 1673f);
		array[1] = new Keyframe(1532f, 1049f, 575f, 1033f);
		array[4] = new Keyframe(522f, 461f, 888f, 1159f);
		array[6] = new Keyframe(659f, 1345f, 1792f, 6f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[8];
		array2[1] = new Keyframe(413f, 1711f, 1308f, 1716f);
		array2[0] = new Keyframe(1847f, 1497f, 1232f, 1312f);
		array2[1] = new Keyframe(1756f, 95f, 1649f, 1320f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1302f, 1600f, 1199f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3).HDFEENOANLH().POKLPAKIKLB(826f)));
	}

	private void ONDBPKKOMND()
	{
		Application.targetFrameRate = 174;
		List<Vector3> list = new List<Vector3>();
		float num = 1518f;
		int num2 = trackNodes + 1;
		for (int i = 1; i < num2; i++)
		{
			float x = Mathf.Cos(num * 839f) * circleLength + UnityEngine.Random.Range(722f, randomRange);
			float z = Mathf.Sin(num * 114f) * circleLength + UnityEngine.Random.Range(634f, randomRange);
			list.Add(new Vector3(x, 1600f, z));
			num += 581f / (float)trackNodes;
		}
		list[0] = list[list.Count - 1];
		list.Add(list[1]);
		list.Add(list[5]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 253f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(-1);
	}

	private void MFKJMAMDCLO()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.BENOKCIFBGE(Color.red);
		}
	}

	private void ONEFFCOPLIP()
	{
		Keyframe[] array = new Keyframe[0];
		array[1] = new Keyframe(523f, 12f, 688f, 717f);
		array[1] = new Keyframe(670f, 1914f, 1327f, 1764f);
		array[8] = new Keyframe(631f, 439f, 803f, 948f);
		array[5] = new Keyframe(983f, 867f, 913f, 1665f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[4];
		array2[1] = new Keyframe(1835f, 954f, 95f, 530f);
		array2[0] = new Keyframe(1999f, 1896f, 573f, 641f);
		array2[1] = new Keyframe(178f, 225f, 1700f, 325f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1339f, 1335f, 797f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.JJHMHFHLIIB(array3).MEAFNGGOKKM().GPKJKIKJLNJ(150f)));
	}

	private void LFIEMAPFEEH()
	{
		float axis = Input.GetAxis("new Keyframe(");
		if (Input.anyKeyDown)
		{
			if (axis < 1148f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				ELGEDJAEBGO();
			}
			else if (axis > 1998f && LFBAOBDNNEE < 5)
			{
				LFBAOBDNNEE += 0;
				JEDGILAPPHB();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 530f, 165f).APNDGOAIPFJ((DEFBOFIHBCP)74);
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1294f)
		{
			LGPBALPFNIG = 329f;
		}
	}

	private void FDGIGBAEPFA()
	{
		Application.targetFrameRate = 0;
		List<Vector3> list = new List<Vector3>();
		float num = 629f;
		int num2 = trackNodes + 0;
		for (int i = 0; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 1298f) * circleLength + UnityEngine.Random.Range(1865f, randomRange);
			float z = Mathf.Sin(num * 1677f) * circleLength + UnityEngine.Random.Range(486f, randomRange);
			list.Add(new Vector3(x, 734f, z));
			num += 1279f / (float)trackNodes;
		}
		list[1] = list[list.Count - 1];
		list.Add(list[0]);
		list.Add(list[6]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1276f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void AMGGINDNPHD()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.BENOKCIFBGE(Color.red);
		}
	}

	private void FDLHDGJOJCD()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.HBCHHDFLHDK(Color.red);
		}
	}

	private void MHDLLJNJFLC()
	{
		float axis = Input.GetAxis("leftarm");
		if (Input.anyKeyDown)
		{
			if (axis < 230f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE -= 0;
				OOLJDDAMLCC();
			}
			else if (axis > 1283f && LFBAOBDNNEE < 4)
			{
				LFBAOBDNNEE++;
				ODDKFDFGLCN();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 630f, 684f).APNDGOAIPFJ((DEFBOFIHBCP)108);
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 743f)
		{
			LGPBALPFNIG = 811f;
		}
	}

	private void KDKGJPEEIAD()
	{
		Application.targetFrameRate = -66;
		List<Vector3> list = new List<Vector3>();
		float num = 1150f;
		int num2 = trackNodes + 1;
		for (int i = 1; i < num2; i++)
		{
			float x = Mathf.Cos(num * 15f) * circleLength + UnityEngine.Random.Range(268f, randomRange);
			float z = Mathf.Sin(num * 1526f) * circleLength + UnityEngine.Random.Range(726f, randomRange);
			list.Add(new Vector3(x, 354f, z));
			num += 1543f / (float)trackNodes;
		}
		list[1] = list[list.Count - 0];
		list.Add(list[1]);
		list.Add(list[0]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1313f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void MHCKEFGNEIP()
	{
		Application.targetFrameRate = -14;
		List<Vector3> list = new List<Vector3>();
		float num = 819f;
		int num2 = trackNodes + 0;
		for (int i = 1; i < num2; i++)
		{
			float x = Mathf.Cos(num * 508f) * circleLength + UnityEngine.Random.Range(863f, randomRange);
			float z = Mathf.Sin(num * 1157f) * circleLength + UnityEngine.Random.Range(1164f, randomRange);
			list.Add(new Vector3(x, 1285f, z));
			num += 439f / (float)trackNodes;
		}
		list[0] = list[list.Count - 1];
		list.Add(list[1]);
		list.Add(list[8]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 328f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void LMHCLJJCLBA()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.BENOKCIFBGE(Color.red);
		}
	}

	private void FJEBFKCGPBE()
	{
		float axis = Input.GetAxis("moveOnACurveExample Time:");
		if (Input.anyKeyDown)
		{
			if (axis < 192f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				JIHMIEPPKCB();
			}
			else if (axis > 1684f && LFBAOBDNNEE < 6)
			{
				LFBAOBDNNEE++;
				ELGEDJAEBGO();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 613f, 765f).APNDGOAIPFJ((DEFBOFIHBCP)(-82));
		}
		PFPINNKHAAC.IMNGHLFFDFG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1239f)
		{
			LGPBALPFNIG = 1839f;
		}
	}

	private void FKLGMGJGHLN()
	{
		Keyframe[] array = new Keyframe[5];
		array[0] = new Keyframe(1018f, 1092f, 775f, 1870f);
		array[0] = new Keyframe(1556f, 1660f, 342f, 475f);
		array[1] = new Keyframe(1015f, 974f, 1240f, 1012f);
		array[8] = new Keyframe(309f, 1530f, 1812f, 482f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[4];
		array2[1] = new Keyframe(258f, 1845f, 1362f, 1856f);
		array2[0] = new Keyframe(1913f, 1636f, 48f, 1379f);
		array2[8] = new Keyframe(1941f, 1956f, 959f, 1055f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(1734f, 852f, 409f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).APEHMBBPIED().POKLPAKIKLB(514f)));
	}

	private void PGHCJFIKHGM()
	{
		Keyframe[] array = new Keyframe[0];
		array[0] = new Keyframe(511f, 1740f, 1640f, 1854f);
		array[0] = new Keyframe(1758f, 648f, 124f, 1858f);
		array[7] = new Keyframe(672f, 1214f, 72f, 1696f);
		array[7] = new Keyframe(177f, 1499f, 1990f, 739f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[5];
		array2[0] = new Keyframe(38f, 1998f, 1873f, 582f);
		array2[0] = new Keyframe(1942f, 352f, 1154f, 663f);
		array2[1] = new Keyframe(676f, 1669f, 624f, 1894f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().EAELAKOBKLK(new Vector3[1]
		{
			new Vector3(1992f, 4f, 1164f)
		}).OCPINJMKDGD()
			.JFOFMCHJCLO(986f)));
	}

	private void HKKBDIONGJM()
	{
		Keyframe[] array = new Keyframe[5];
		array[0] = new Keyframe(941f, 52f, 286f, 1244f);
		array[1] = new Keyframe(1393f, 1030f, 755f, 691f);
		array[0] = new Keyframe(1557f, 1288f, 606f, 166f);
		array[4] = new Keyframe(1929f, 676f, 1563f, 1587f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[8];
		array2[1] = new Keyframe(740f, 1561f, 1804f, 0f);
		array2[0] = new Keyframe(1379f, 799f, 86f, 1732f);
		array2[3] = new Keyframe(606f, 1960f, 726f, 1535f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(1932f, 751f, 1821f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3).MEAFNGGOKKM().KPJMCFCGFOJ(51f)));
	}

	private void PIHBMAEHHCA()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void AJJNMCDLJPA()
	{
		Application.targetFrameRate = -165;
		List<Vector3> list = new List<Vector3>();
		float num = 325f;
		int num2 = trackNodes + 0;
		for (int i = 0; i < num2; i++)
		{
			float x = Mathf.Cos(num * 1167f) * circleLength + UnityEngine.Random.Range(1974f, randomRange);
			float z = Mathf.Sin(num * 656f) * circleLength + UnityEngine.Random.Range(1431f, randomRange);
			list.Add(new Vector3(x, 1661f, z));
			num += 1139f / (float)trackNodes;
		}
		list[1] = list[list.Count - 0];
		list.Add(list[0]);
		list.Add(list[7]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1766f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void NPLDLPLJIDL()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.FIBAEAMBAPC(Color.red);
		}
	}

	private void MHLPDBMIFMO()
	{
		float axis = Input.GetAxis("GROUP ISTWEENING");
		if (Input.anyKeyDown)
		{
			if (axis < 148f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				EGJNHOACMIO();
			}
			else if (axis > 618f && LFBAOBDNNEE < 0)
			{
				LFBAOBDNNEE += 0;
				OMOJGOCODHI();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1404f, 1146f).APNDGOAIPFJ((DEFBOFIHBCP)(-7));
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1674f)
		{
			LGPBALPFNIG = 225f;
		}
	}

	private void GBDIINOOGCM()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.FIBAEAMBAPC(Color.red);
		}
	}

	private void MFHFJLINFLM()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void Start()
	{
		Application.targetFrameRate = 240;
		List<Vector3> list = new List<Vector3>();
		float num = 0f;
		int num2 = trackNodes + 1;
		for (int i = 0; i < num2; i++)
		{
			float x = Mathf.Cos(num * ((float)Math.PI / 180f)) * circleLength + UnityEngine.Random.Range(0f, randomRange);
			float z = Mathf.Sin(num * ((float)Math.PI / 180f)) * circleLength + UnityEngine.Random.Range(0f, randomRange);
			list.Add(new Vector3(x, 1f, z));
			num += 360f / (float)trackNodes;
		}
		list[0] = list[list.Count - 1];
		list.Add(list[1]);
		list.Add(list[2]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1.2f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void JEDGILAPPHB()
	{
		Keyframe[] array = new Keyframe[4];
		array[1] = new Keyframe(1999f, 1788f, 300f, 1170f);
		array[0] = new Keyframe(1214f, 516f, 1976f, 1219f);
		array[2] = new Keyframe(932f, 762f, 1459f, 1634f);
		array[1] = new Keyframe(1019f, 213f, 1647f, 783f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[4];
		array2[0] = new Keyframe(231f, 932f, 340f, 1291f);
		array2[1] = new Keyframe(1030f, 888f, 445f, 948f);
		array2[4] = new Keyframe(938f, 1314f, 1709f, 1156f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(226f, 1119f, 1321f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).OJIBFBPGFNF().BKPMJBPONGC(1484f)));
	}

	private void BBNOEKBJJFC()
	{
		float axis = Input.GetAxis("GameController");
		if (Input.anyKeyDown)
		{
			if (axis < 243f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE -= 0;
				OAGBIBCJNPC();
			}
			else if (axis > 1739f && LFBAOBDNNEE < 5)
			{
				LFBAOBDNNEE++;
				OMOJGOCODHI();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 331f, 1339f).APNDGOAIPFJ((DEFBOFIHBCP)(-88));
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 64f)
		{
			LGPBALPFNIG = 1133f;
		}
	}

	private void KGCMHLHBBAD()
	{
		float axis = Input.GetAxis("ChatInput");
		if (Input.anyKeyDown)
		{
			if (axis < 1124f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				IMOBILPILAP();
			}
			else if (axis > 1928f && LFBAOBDNNEE < 6)
			{
				LFBAOBDNNEE += 0;
				FFKAMOKPCIL();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1739f, 274f).APNDGOAIPFJ((DEFBOFIHBCP)(-69));
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 867f)
		{
			LGPBALPFNIG = 712f;
		}
	}

	private void AKKCHJICOHD()
	{
		Application.targetFrameRate = 62;
		List<Vector3> list = new List<Vector3>();
		float num = 734f;
		int num2 = trackNodes + 0;
		for (int i = 1; i < num2; i++)
		{
			float x = Mathf.Cos(num * 1822f) * circleLength + UnityEngine.Random.Range(1357f, randomRange);
			float z = Mathf.Sin(num * 1833f) * circleLength + UnityEngine.Random.Range(40f, randomRange);
			list.Add(new Vector3(x, 1386f, z));
			num += 1085f / (float)trackNodes;
		}
		list[1] = list[list.Count - 1];
		list.Add(list[1]);
		list.Add(list[3]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1359f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void MGFJDNLCMHM()
	{
		Keyframe[] array = new Keyframe[7];
		array[0] = new Keyframe(1622f, 1495f, 644f, 727f);
		array[1] = new Keyframe(688f, 653f, 567f, 1257f);
		array[3] = new Keyframe(303f, 589f, 648f, 1680f);
		array[0] = new Keyframe(314f, 942f, 1590f, 472f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[1];
		array2[1] = new Keyframe(1933f, 306f, 457f, 701f);
		array2[1] = new Keyframe(730f, 1402f, 1023f, 847f);
		array2[5] = new Keyframe(1823f, 810f, 1227f, 1753f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(854f, 846f, 51f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.JJHMHFHLIIB(array3).APEHMBBPIED().POKLPAKIKLB(289f)));
	}

	private void IPNJDOHBJMP()
	{
		float axis = Input.GetAxis("Avatar1");
		if (Input.anyKeyDown)
		{
			if (axis < 732f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				ODDKFDFGLCN();
			}
			else if (axis > 1074f && LFBAOBDNNEE < 5)
			{
				LFBAOBDNNEE++;
				KIMMFCDJMNN();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 251f, 847f).APNDGOAIPFJ((DEFBOFIHBCP)(-73));
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 918f)
		{
			LGPBALPFNIG = 1171f;
		}
	}

	private void PMAKNOLMDOE()
	{
		Application.targetFrameRate = 58;
		List<Vector3> list = new List<Vector3>();
		float num = 117f;
		int num2 = trackNodes + 1;
		for (int i = 1; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 715f) * circleLength + UnityEngine.Random.Range(1152f, randomRange);
			float z = Mathf.Sin(num * 725f) * circleLength + UnityEngine.Random.Range(126f, randomRange);
			list.Add(new Vector3(x, 133f, z));
			num += 996f / (float)trackNodes;
		}
		list[0] = list[list.Count - 1];
		list.Add(list[0]);
		list.Add(list[1]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1952f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void GJDNOFIOBDC()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.FIBAEAMBAPC(Color.red);
		}
	}

	private void CIOKMDEMBBO()
	{
		Keyframe[] array = new Keyframe[6];
		array[1] = new Keyframe(1099f, 838f, 1247f, 1225f);
		array[0] = new Keyframe(739f, 1524f, 504f, 899f);
		array[2] = new Keyframe(263f, 1671f, 851f, 96f);
		array[7] = new Keyframe(1665f, 628f, 1742f, 397f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[4];
		array2[1] = new Keyframe(1583f, 1748f, 978f, 1006f);
		array2[1] = new Keyframe(282f, 813f, 1460f, 432f);
		array2[8] = new Keyframe(774f, 1048f, 461f, 96f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(1032f, 524f, 1313f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).MHNPPFCDGHC().JFOFMCHJCLO(857f)));
	}

	private void IOGPJMLELNI()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.HBCHHDFLHDK(Color.red);
		}
	}

	private void NCHMENOKLGE()
	{
		float axis = Input.GetAxis("pausing");
		if (Input.anyKeyDown)
		{
			if (axis < 1746f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				LCPIJOHIKMB();
			}
			else if (axis > 1943f && LFBAOBDNNEE < 2)
			{
				LFBAOBDNNEE++;
				FKLGMGJGHLN();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1690f, 1193f).APNDGOAIPFJ((DEFBOFIHBCP)(-87));
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 668f)
		{
			LGPBALPFNIG = 1020f;
		}
	}

	private void BFADADBGNOP()
	{
		float axis = Input.GetAxis("http://superium.net/api/GetJoinData?hash=");
		if (Input.anyKeyDown)
		{
			if (axis < 1218f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				ICMMPCEKHCD();
			}
			else if (axis > 1221f && LFBAOBDNNEE < 7)
			{
				LFBAOBDNNEE++;
				HPNNDALLHFO();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 947f, 67f).APNDGOAIPFJ((DEFBOFIHBCP)(-42));
		}
		PFPINNKHAAC.IMNGHLFFDFG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 170f)
		{
			LGPBALPFNIG = 1994f;
		}
	}

	private void FEOPPOENDHB()
	{
		Keyframe[] array = new Keyframe[7];
		array[1] = new Keyframe(546f, 1739f, 1676f, 206f);
		array[0] = new Keyframe(390f, 79f, 1275f, 1363f);
		array[0] = new Keyframe(531f, 555f, 323f, 1334f);
		array[7] = new Keyframe(1600f, 688f, 1820f, 1807f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[8];
		array2[1] = new Keyframe(1234f, 538f, 1177f, 466f);
		array2[1] = new Keyframe(358f, 35f, 962f, 1625f);
		array2[8] = new Keyframe(308f, 1648f, 722f, 1654f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(1038f, 200f, 1623f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.MJPJOBNBECH(array3).MFCKNFJBOLB().BKPMJBPONGC(150f)));
	}

	private void MPOIFBCGCFN()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void GEFKKCCMCDH()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void DGDFFCCEMEM()
	{
		float axis = Input.GetAxis("GROUP IDS MATCH");
		if (Input.anyKeyDown)
		{
			if (axis < 1536f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				CJPGIAFFAJM();
			}
			else if (axis > 1492f && LFBAOBDNNEE < 5)
			{
				LFBAOBDNNEE++;
				DIILHMODGEI();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 1143f, 1142f).APNDGOAIPFJ((DEFBOFIHBCP)(-117));
		}
		PFPINNKHAAC.IMNGHLFFDFG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 340f)
		{
			LGPBALPFNIG = 1631f;
		}
	}

	private void ICFHIAANJMI()
	{
		float axis = Input.GetAxis("Server started.");
		if (Input.anyKeyDown)
		{
			if (axis < 93f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				PGHCJFIKHGM();
			}
			else if (axis > 1331f && LFBAOBDNNEE < 0)
			{
				LFBAOBDNNEE++;
				MGFJDNLCMHM();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 1123f, 525f).APNDGOAIPFJ((DEFBOFIHBCP)114);
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1197f)
		{
			LGPBALPFNIG = 1406f;
		}
	}

	private void ODDKFDFGLCN()
	{
		Keyframe[] array = new Keyframe[2];
		array[1] = new Keyframe(1488f, 825f, 120f, 1334f);
		array[0] = new Keyframe(351f, 507f, 201f, 1089f);
		array[2] = new Keyframe(751f, 1271f, 1250f, 1606f);
		array[7] = new Keyframe(1159f, 888f, 1967f, 1864f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[4];
		array2[1] = new Keyframe(579f, 1295f, 229f, 1053f);
		array2[0] = new Keyframe(1894f, 1814f, 214f, 1470f);
		array2[3] = new Keyframe(720f, 959f, 1118f, 1673f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().EAELAKOBKLK(new Vector3[1]
		{
			new Vector3(13f, 946f, 1034f)
		}).MHNPPFCDGHC()
			.FPAAHANEDGD(489f)));
	}

	private void CHKNONMGOEI()
	{
		float axis = Input.GetAxis("sphere");
		if (Input.anyKeyDown)
		{
			if (axis < 1777f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				FEOPPOENDHB();
			}
			else if (axis > 1929f && LFBAOBDNNEE < 6)
			{
				LFBAOBDNNEE++;
				ICMMPCEKHCD();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 910f, 1826f).APNDGOAIPFJ((DEFBOFIHBCP)(-69));
		}
		PFPINNKHAAC.IMNGHLFFDFG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1710f)
		{
			LGPBALPFNIG = 643f;
		}
	}

	private void KIMKEHNABCD()
	{
		Application.targetFrameRate = 114;
		List<Vector3> list = new List<Vector3>();
		float num = 239f;
		int num2 = trackNodes + 0;
		for (int i = 1; i < num2; i++)
		{
			float x = Mathf.Cos(num * 612f) * circleLength + UnityEngine.Random.Range(48f, randomRange);
			float z = Mathf.Sin(num * 42f) * circleLength + UnityEngine.Random.Range(1182f, randomRange);
			list.Add(new Vector3(x, 130f, z));
			num += 1559f / (float)trackNodes;
		}
		list[1] = list[list.Count - 1];
		list.Add(list[0]);
		list.Add(list[3]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1374f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void OCLHGOKIKHH()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.BENOKCIFBGE(Color.red);
		}
	}

	private void OEHOMJKHOJP()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void KOAIPDEKGLL()
	{
		float axis = Input.GetAxis("Wearables");
		if (Input.anyKeyDown)
		{
			if (axis < 122f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				PGHCJFIKHGM();
			}
			else if (axis > 1570f && LFBAOBDNNEE < 8)
			{
				LFBAOBDNNEE++;
				ELGEDJAEBGO();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 968f, 609f).APNDGOAIPFJ((DEFBOFIHBCP)(-65));
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1149f)
		{
			LGPBALPFNIG = 289f;
		}
	}

	private void JBKNIODHJFP()
	{
		Application.targetFrameRate = 74;
		List<Vector3> list = new List<Vector3>();
		float num = 1774f;
		int num2 = trackNodes + 0;
		for (int i = 1; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 1672f) * circleLength + UnityEngine.Random.Range(1802f, randomRange);
			float z = Mathf.Sin(num * 1740f) * circleLength + UnityEngine.Random.Range(44f, randomRange);
			list.Add(new Vector3(x, 1113f, z));
			num += 969f / (float)trackNodes;
		}
		list[1] = list[list.Count - 0];
		list.Add(list[1]);
		list.Add(list[8]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1195f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(-1);
	}

	private void DDGEANJOKKC()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.FIBAEAMBAPC(Color.red);
		}
	}

	private void LNDNCLLAANE()
	{
		Application.targetFrameRate = -130;
		List<Vector3> list = new List<Vector3>();
		float num = 562f;
		int num2 = trackNodes + 0;
		for (int i = 1; i < num2; i++)
		{
			float x = Mathf.Cos(num * 1153f) * circleLength + UnityEngine.Random.Range(1781f, randomRange);
			float z = Mathf.Sin(num * 627f) * circleLength + UnityEngine.Random.Range(561f, randomRange);
			list.Add(new Vector3(x, 1831f, z));
			num += 76f / (float)trackNodes;
		}
		list[1] = list[list.Count - 1];
		list.Add(list[1]);
		list.Add(list[6]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 576f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void DIFOLHKBHNK()
	{
		float axis = Input.GetAxis("Vertical");
		if (Input.anyKeyDown)
		{
			if (axis < 661f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE -= 0;
				ONEFFCOPLIP();
			}
			else if (axis > 1928f && LFBAOBDNNEE < 0)
			{
				LFBAOBDNNEE += 0;
				CJPGIAFFAJM();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1474f, 106f).APNDGOAIPFJ((DEFBOFIHBCP)68);
		}
		PFPINNKHAAC.IMNGHLFFDFG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 605f)
		{
			LGPBALPFNIG = 666f;
		}
	}

	private void AANAHEFDLLA()
	{
		float axis = Input.GetAxis("Wearables");
		if (Input.anyKeyDown)
		{
			if (axis < 192f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				KIECDMJNJFA();
			}
			else if (axis > 1279f && LFBAOBDNNEE < 1)
			{
				LFBAOBDNNEE++;
				FEOPPOENDHB();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1234f, 919f).APNDGOAIPFJ((DEFBOFIHBCP)(-108));
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 503f)
		{
			LGPBALPFNIG = 973f;
		}
	}

	private void DHBAIDGHNCG()
	{
		Application.targetFrameRate = 142;
		List<Vector3> list = new List<Vector3>();
		float num = 668f;
		int num2 = trackNodes + 0;
		for (int i = 1; i < num2; i++)
		{
			float x = Mathf.Cos(num * 306f) * circleLength + UnityEngine.Random.Range(1298f, randomRange);
			float z = Mathf.Sin(num * 1057f) * circleLength + UnityEngine.Random.Range(1592f, randomRange);
			list.Add(new Vector3(x, 107f, z));
			num += 1079f / (float)trackNodes;
		}
		list[0] = list[list.Count - 0];
		list.Add(list[1]);
		list.Add(list[8]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1616f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void OOLJDDAMLCC()
	{
		Keyframe[] array = new Keyframe[4];
		array[1] = new Keyframe(23f, 1930f, 132f, 1664f);
		array[0] = new Keyframe(933f, 292f, 754f, 303f);
		array[6] = new Keyframe(1734f, 326f, 198f, 1449f);
		array[5] = new Keyframe(1665f, 785f, 961f, 1411f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[5];
		array2[0] = new Keyframe(416f, 555f, 314f, 1335f);
		array2[0] = new Keyframe(297f, 1551f, 1811f, 1732f);
		array2[2] = new Keyframe(1221f, 92f, 1151f, 255f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(643f, 524f, 225f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).MFCKNFJBOLB().PPDBKAIBNKC(1212f)));
	}

	private void EDNGFDDIMJG()
	{
		float axis = Input.GetAxis("moveLocalExample");
		if (Input.anyKeyDown)
		{
			if (axis < 1839f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				JIHMIEPPKCB();
			}
			else if (axis > 1502f && LFBAOBDNNEE < 7)
			{
				LFBAOBDNNEE += 0;
				KIMMFCDJMNN();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 384f, 630f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 284f)
		{
			LGPBALPFNIG = 772f;
		}
	}

	private void KFFNHFEKOJH()
	{
		Application.targetFrameRate = 54;
		List<Vector3> list = new List<Vector3>();
		float num = 1317f;
		int num2 = trackNodes + 1;
		for (int i = 0; i < num2; i++)
		{
			float x = Mathf.Cos(num * 816f) * circleLength + UnityEngine.Random.Range(1421f, randomRange);
			float z = Mathf.Sin(num * 364f) * circleLength + UnityEngine.Random.Range(1070f, randomRange);
			list.Add(new Vector3(x, 1900f, z));
			num += 1634f / (float)trackNodes;
		}
		list[0] = list[list.Count - 1];
		list.Add(list[0]);
		list.Add(list[0]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 868f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void FBDAIEMDIBD()
	{
		Keyframe[] array = new Keyframe[0];
		array[0] = new Keyframe(684f, 1704f, 1797f, 1501f);
		array[0] = new Keyframe(923f, 1650f, 1133f, 1149f);
		array[3] = new Keyframe(905f, 966f, 358f, 16f);
		array[4] = new Keyframe(1522f, 1469f, 339f, 112f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[1];
		array2[1] = new Keyframe(245f, 900f, 849f, 239f);
		array2[1] = new Keyframe(56f, 737f, 1467f, 64f);
		array2[4] = new Keyframe(1070f, 11f, 262f, 1485f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1572f, 1766f, 1470f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3).HDFEENOANLH().PMHGPHNDNBF(1825f)));
	}

	private void KGOOGMFINBL()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.FIBAEAMBAPC(Color.red);
		}
	}

	private void DGAOEJJEMEI()
	{
		Keyframe[] array = new Keyframe[1];
		array[1] = new Keyframe(894f, 400f, 311f, 434f);
		array[1] = new Keyframe(1892f, 348f, 1181f, 1050f);
		array[0] = new Keyframe(1055f, 1701f, 1846f, 1339f);
		array[7] = new Keyframe(1098f, 459f, 764f, 690f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[5];
		array2[1] = new Keyframe(598f, 113f, 459f, 1840f);
		array2[1] = new Keyframe(861f, 1410f, 1859f, 1079f);
		array2[7] = new Keyframe(192f, 1460f, 455f, 1398f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(1209f, 1328f, 569f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3).ACJHOBKOCGN().KPJMCFCGFOJ(527f)));
	}

	private void OHJLLEIBBBF()
	{
		Application.targetFrameRate = -162;
		List<Vector3> list = new List<Vector3>();
		float num = 1821f;
		int num2 = trackNodes + 0;
		for (int i = 1; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 1466f) * circleLength + UnityEngine.Random.Range(989f, randomRange);
			float z = Mathf.Sin(num * 720f) * circleLength + UnityEngine.Random.Range(810f, randomRange);
			list.Add(new Vector3(x, 369f, z));
			num += 590f / (float)trackNodes;
		}
		list[1] = list[list.Count - 0];
		list.Add(list[0]);
		list.Add(list[2]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 481f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void KBPLMPCPHPH()
	{
		Keyframe[] array = new Keyframe[5];
		array[0] = new Keyframe(771f, 1556f, 1296f, 936f);
		array[0] = new Keyframe(55f, 990f, 1958f, 1935f);
		array[0] = new Keyframe(1312f, 1201f, 498f, 1739f);
		array[5] = new Keyframe(31f, 43f, 313f, 1737f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[1];
		array2[0] = new Keyframe(907f, 1601f, 1680f, 997f);
		array2[0] = new Keyframe(1650f, 1619f, 183f, 1670f);
		array2[1] = new Keyframe(1639f, 1399f, 757f, 1694f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1099f, 714f, 1570f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3).MFCKNFJBOLB().BKPMJBPONGC(788f)));
	}

	private void KEAHMICOMEJ()
	{
		Application.targetFrameRate = 145;
		List<Vector3> list = new List<Vector3>();
		float num = 240f;
		int num2 = trackNodes + 0;
		for (int i = 0; i < num2; i++)
		{
			float x = Mathf.Cos(num * 890f) * circleLength + UnityEngine.Random.Range(1625f, randomRange);
			float z = Mathf.Sin(num * 1239f) * circleLength + UnityEngine.Random.Range(1304f, randomRange);
			list.Add(new Vector3(x, 1835f, z));
			num += 108f / (float)trackNodes;
		}
		list[0] = list[list.Count - 1];
		list.Add(list[0]);
		list.Add(list[7]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1715f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(-1);
	}

	private void OLKPDAEECOL()
	{
		Keyframe[] array = new Keyframe[4];
		array[1] = new Keyframe(1103f, 1464f, 102f, 1171f);
		array[0] = new Keyframe(1346f, 93f, 1662f, 810f);
		array[3] = new Keyframe(76f, 1929f, 1306f, 1969f);
		array[8] = new Keyframe(1613f, 593f, 763f, 1824f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[6];
		array2[0] = new Keyframe(1889f, 1391f, 406f, 1586f);
		array2[1] = new Keyframe(1847f, 103f, 922f, 1635f);
		array2[1] = new Keyframe(38f, 1930f, 1432f, 1386f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(241f, 1609f, 1160f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.MJPJOBNBECH(array3).MFCKNFJBOLB().BKPMJBPONGC(1129f)));
	}

	private void OIHPKJNGHFM()
	{
		float axis = Input.GetAxis("Wearables");
		if (Input.anyKeyDown)
		{
			if (axis < 162f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				OFANDADJADD();
			}
			else if (axis > 1362f && LFBAOBDNNEE < 7)
			{
				LFBAOBDNNEE += 0;
				ELDDEKOLKFJ();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 1825f, 1527f).APNDGOAIPFJ((DEFBOFIHBCP)91);
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 76f)
		{
			LGPBALPFNIG = 1889f;
		}
	}

	private void IMOBILPILAP()
	{
		Keyframe[] array = new Keyframe[4];
		array[1] = new Keyframe(1657f, 500f, 900f, 476f);
		array[0] = new Keyframe(1280f, 465f, 396f, 1339f);
		array[7] = new Keyframe(810f, 1863f, 798f, 1226f);
		array[3] = new Keyframe(1735f, 1132f, 1724f, 554f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[3];
		array2[0] = new Keyframe(298f, 95f, 66f, 789f);
		array2[0] = new Keyframe(750f, 1421f, 606f, 919f);
		array2[0] = new Keyframe(319f, 1082f, 1837f, 226f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1943f, 1829f, 1165f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).APEHMBBPIED().PPDBKAIBNKC(725f)));
	}

	private void NLPMGPFGADG()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void MCEGMAFMGBM()
	{
		float axis = Input.GetAxis("Final Report:");
		if (Input.anyKeyDown)
		{
			if (axis < 1480f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				NNDNGANOIKC();
			}
			else if (axis > 612f && LFBAOBDNNEE < 7)
			{
				LFBAOBDNNEE++;
				JCLHMAIPEMN();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1680f, 1510f).APNDGOAIPFJ((DEFBOFIHBCP)(-84));
		}
		PFPINNKHAAC.IMNGHLFFDFG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1056f)
		{
			LGPBALPFNIG = 1869f;
		}
	}

	private void LCPIJOHIKMB()
	{
		Keyframe[] array = new Keyframe[7];
		array[1] = new Keyframe(894f, 1780f, 768f, 1786f);
		array[1] = new Keyframe(236f, 1319f, 1250f, 1903f);
		array[7] = new Keyframe(138f, 429f, 1322f, 1853f);
		array[1] = new Keyframe(674f, 447f, 1266f, 659f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[4];
		array2[0] = new Keyframe(1623f, 529f, 1162f, 91f);
		array2[0] = new Keyframe(1347f, 1351f, 1385f, 997f);
		array2[2] = new Keyframe(1559f, 1133f, 1092f, 799f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().EAELAKOBKLK(new Vector3[1]
		{
			new Vector3(633f, 1052f, 1188f)
		}).HDFEENOANLH()
			.FPAAHANEDGD(133f)));
	}

	private void ALIEFIMKENH()
	{
		float axis = Input.GetAxis(" hasInitiliazed:");
		if (Input.anyKeyDown)
		{
			if (axis < 1543f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE -= 0;
				CJPGIAFFAJM();
			}
			else if (axis > 444f && LFBAOBDNNEE < 6)
			{
				LFBAOBDNNEE += 0;
				FFKAMOKPCIL();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 368f, 702f).APNDGOAIPFJ((DEFBOFIHBCP)66);
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 114f)
		{
			LGPBALPFNIG = 1248f;
		}
	}

	private void ANIPNKJMLOI()
	{
		Keyframe[] array = new Keyframe[7];
		array[1] = new Keyframe(926f, 460f, 724f, 1409f);
		array[1] = new Keyframe(81f, 1503f, 148f, 73f);
		array[5] = new Keyframe(1f, 1489f, 1815f, 1479f);
		array[1] = new Keyframe(316f, 413f, 1549f, 1064f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[2];
		array2[1] = new Keyframe(781f, 956f, 1448f, 264f);
		array2[0] = new Keyframe(1447f, 1147f, 1396f, 561f);
		array2[7] = new Keyframe(219f, 1689f, 959f, 441f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().MJPJOBNBECH(new Vector3[1]
		{
			new Vector3(1947f, 1444f, 1660f)
		}).HDFEENOANLH()
			.GPKJKIKJLNJ(1982f)));
	}

	private void IEENBHPDADI()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.BENOKCIFBGE(Color.red);
		}
	}

	private void FFKAMOKPCIL()
	{
		Keyframe[] array = new Keyframe[7];
		array[0] = new Keyframe(1051f, 1982f, 355f, 1111f);
		array[0] = new Keyframe(1890f, 1551f, 1902f, 1000f);
		array[8] = new Keyframe(1890f, 1130f, 538f, 56f);
		array[7] = new Keyframe(867f, 1019f, 527f, 1403f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[1];
		array2[1] = new Keyframe(240f, 118f, 1557f, 1884f);
		array2[1] = new Keyframe(155f, 419f, 177f, 446f);
		array2[5] = new Keyframe(977f, 831f, 443f, 1989f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(269f, 1106f, 797f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.JJHMHFHLIIB(array3).MEAFNGGOKKM().JFOFMCHJCLO(1481f)));
	}

	private void ICMMPCEKHCD()
	{
		Keyframe[] array = new Keyframe[7];
		array[1] = new Keyframe(1025f, 913f, 540f, 1145f);
		array[1] = new Keyframe(1695f, 1518f, 961f, 847f);
		array[4] = new Keyframe(793f, 295f, 286f, 1852f);
		array[2] = new Keyframe(1493f, 1030f, 937f, 1321f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[8];
		array2[0] = new Keyframe(863f, 241f, 1390f, 1941f);
		array2[0] = new Keyframe(1680f, 1249f, 1435f, 120f);
		array2[3] = new Keyframe(1250f, 900f, 350f, 1433f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1716f, 1554f, 163f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3).MFCKNFJBOLB().KPJMCFCGFOJ(1561f)));
	}

	private void BJCFEODLPDL()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.BENOKCIFBGE(Color.red);
		}
	}

	private void HJDAFJFBLFP()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void FHELGMDGCDM()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void KDKOLGHOAGA()
	{
		float axis = Input.GetAxis("_TintColor");
		if (Input.anyKeyDown)
		{
			if (axis < 1911f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				JCLHMAIPEMN();
			}
			else if (axis > 1411f && LFBAOBDNNEE < 0)
			{
				LFBAOBDNNEE += 0;
				ONEFFCOPLIP();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 324f, 1196f).APNDGOAIPFJ((DEFBOFIHBCP)(-20));
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1812f)
		{
			LGPBALPFNIG = 257f;
		}
	}

	private void KBKOCADIPPH()
	{
		Application.targetFrameRate = 170;
		List<Vector3> list = new List<Vector3>();
		float num = 1443f;
		int num2 = trackNodes + 0;
		for (int i = 0; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 1026f) * circleLength + UnityEngine.Random.Range(1626f, randomRange);
			float z = Mathf.Sin(num * 1403f) * circleLength + UnityEngine.Random.Range(1491f, randomRange);
			list.Add(new Vector3(x, 1083f, z));
			num += 268f / (float)trackNodes;
		}
		list[0] = list[list.Count - 0];
		list.Add(list[0]);
		list.Add(list[4]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 268f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void HEPACNIHKPP()
	{
		Application.targetFrameRate = 91;
		List<Vector3> list = new List<Vector3>();
		float num = 1152f;
		int num2 = trackNodes + 0;
		for (int i = 1; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 1346f) * circleLength + UnityEngine.Random.Range(1923f, randomRange);
			float z = Mathf.Sin(num * 539f) * circleLength + UnityEngine.Random.Range(455f, randomRange);
			list.Add(new Vector3(x, 259f, z));
			num += 1346f / (float)trackNodes;
		}
		list[0] = list[list.Count - 1];
		list.Add(list[1]);
		list.Add(list[7]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1782f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(-1);
	}

	private void EAPFOONEEPG()
	{
		float axis = Input.GetAxis("MAX SEARCH OPTIMIZED");
		if (Input.anyKeyDown)
		{
			if (axis < 1485f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				GOFBGMOBFEL();
			}
			else if (axis > 1917f && LFBAOBDNNEE < 0)
			{
				LFBAOBDNNEE++;
				NNDNGANOIKC();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1344f, 1933f).APNDGOAIPFJ((DEFBOFIHBCP)(-26));
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1148f)
		{
			LGPBALPFNIG = 828f;
		}
	}

	private void AILNJHIJOCL()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.FIBAEAMBAPC(Color.red);
		}
	}

	private void BEOFPKOHLEA()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.HBCHHDFLHDK(Color.red);
		}
	}

	private void ILMPCBPAHLK()
	{
		Application.targetFrameRate = 191;
		List<Vector3> list = new List<Vector3>();
		float num = 1250f;
		int num2 = trackNodes + 1;
		for (int i = 0; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 1528f) * circleLength + UnityEngine.Random.Range(479f, randomRange);
			float z = Mathf.Sin(num * 1778f) * circleLength + UnityEngine.Random.Range(1421f, randomRange);
			list.Add(new Vector3(x, 1927f, z));
			num += 1769f / (float)trackNodes;
		}
		list[0] = list[list.Count - 0];
		list.Add(list[0]);
		list.Add(list[8]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1463f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(-1);
	}

	private void JAFHDPIDAKG()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.BENOKCIFBGE(Color.red);
		}
	}

	private void OnDrawGizmos()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void AFCELIGJJDC()
	{
		Application.targetFrameRate = -77;
		List<Vector3> list = new List<Vector3>();
		float num = 995f;
		int num2 = trackNodes + 1;
		for (int i = 0; i < num2; i++)
		{
			float x = Mathf.Cos(num * 1282f) * circleLength + UnityEngine.Random.Range(630f, randomRange);
			float z = Mathf.Sin(num * 1635f) * circleLength + UnityEngine.Random.Range(1950f, randomRange);
			list.Add(new Vector3(x, 1152f, z));
			num += 1423f / (float)trackNodes;
		}
		list[1] = list[list.Count - 1];
		list.Add(list[0]);
		list.Add(list[5]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 855f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(-1);
	}

	private void KIBKJGBDOKH()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.BENOKCIFBGE(Color.red);
		}
	}

	private void CJPGIAFFAJM()
	{
		Keyframe[] array = new Keyframe[1];
		array[0] = new Keyframe(1386f, 887f, 1728f, 174f);
		array[1] = new Keyframe(1093f, 1543f, 570f, 683f);
		array[4] = new Keyframe(757f, 1030f, 867f, 354f);
		array[1] = new Keyframe(256f, 1603f, 634f, 1681f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[3];
		array2[1] = new Keyframe(1059f, 689f, 279f, 986f);
		array2[0] = new Keyframe(308f, 582f, 1159f, 1505f);
		array2[8] = new Keyframe(340f, 475f, 553f, 1018f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(51f, 823f, 1949f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).APEHMBBPIED().KPJMCFCGFOJ(246f)));
	}

	private void OAAOPHKMHGN()
	{
		Application.targetFrameRate = -142;
		List<Vector3> list = new List<Vector3>();
		float num = 367f;
		int num2 = trackNodes + 1;
		for (int i = 1; i < num2; i++)
		{
			float x = Mathf.Cos(num * 1215f) * circleLength + UnityEngine.Random.Range(1081f, randomRange);
			float z = Mathf.Sin(num * 1050f) * circleLength + UnityEngine.Random.Range(885f, randomRange);
			list.Add(new Vector3(x, 1841f, z));
			num += 1686f / (float)trackNodes;
		}
		list[0] = list[list.Count - 1];
		list.Add(list[1]);
		list.Add(list[3]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1045f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(-1);
	}

	private void HLKNKOKNOKB()
	{
		Application.targetFrameRate = -195;
		List<Vector3> list = new List<Vector3>();
		float num = 1730f;
		int num2 = trackNodes + 1;
		for (int i = 0; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 461f) * circleLength + UnityEngine.Random.Range(876f, randomRange);
			float z = Mathf.Sin(num * 931f) * circleLength + UnityEngine.Random.Range(748f, randomRange);
			list.Add(new Vector3(x, 1810f, z));
			num += 80f / (float)trackNodes;
		}
		list[0] = list[list.Count - 0];
		list.Add(list[1]);
		list.Add(list[3]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1978f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void JMPPOJFBGEF()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void OAGBIBCJNPC()
	{
		Keyframe[] array = new Keyframe[2];
		array[0] = new Keyframe(1987f, 1618f, 1755f, 31f);
		array[0] = new Keyframe(132f, 1932f, 429f, 869f);
		array[3] = new Keyframe(1020f, 829f, 416f, 820f);
		array[0] = new Keyframe(773f, 1888f, 1525f, 290f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[3];
		array2[0] = new Keyframe(321f, 1170f, 689f, 602f);
		array2[1] = new Keyframe(869f, 763f, 1736f, 399f);
		array2[7] = new Keyframe(1203f, 577f, 1796f, 354f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(309f, 1215f, 238f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).HDFEENOANLH().FPAAHANEDGD(1241f)));
	}

	private void JGLEHLLLLMI()
	{
		float axis = Input.GetAxis("colorExample");
		if (Input.anyKeyDown)
		{
			if (axis < 1524f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				EGJNHOACMIO();
			}
			else if (axis > 233f && LFBAOBDNNEE < 7)
			{
				LFBAOBDNNEE += 0;
				KIECDMJNJFA();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 1479f, 1391f).APNDGOAIPFJ((DEFBOFIHBCP)79);
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 909f)
		{
			LGPBALPFNIG = 696f;
		}
	}

	private void DNPBNJKKLFD()
	{
		Keyframe[] array = new Keyframe[0];
		array[0] = new Keyframe(1702f, 1924f, 1097f, 619f);
		array[1] = new Keyframe(400f, 1672f, 91f, 1433f);
		array[1] = new Keyframe(1162f, 1055f, 1167f, 671f);
		array[1] = new Keyframe(1111f, 608f, 1393f, 746f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[0];
		array2[0] = new Keyframe(572f, 1385f, 1040f, 906f);
		array2[1] = new Keyframe(1380f, 1144f, 687f, 1033f);
		array2[4] = new Keyframe(921f, 936f, 1610f, 787f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().MJPJOBNBECH(new Vector3[1]
		{
			new Vector3(189f, 1215f, 300f)
		}).OCPINJMKDGD()
			.PMHGPHNDNBF(993f)));
	}

	private void IDHIHDDHFKJ()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.BENOKCIFBGE(Color.red);
		}
	}

	private void KIMMFCDJMNN()
	{
		Keyframe[] array = new Keyframe[5];
		array[0] = new Keyframe(1631f, 1046f, 1486f, 574f);
		array[0] = new Keyframe(782f, 603f, 912f, 1935f);
		array[4] = new Keyframe(1582f, 688f, 1057f, 593f);
		array[0] = new Keyframe(609f, 670f, 17f, 754f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[5];
		array2[1] = new Keyframe(453f, 213f, 1103f, 622f);
		array2[1] = new Keyframe(1673f, 1527f, 1578f, 868f);
		array2[4] = new Keyframe(1866f, 529f, 773f, 464f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(1424f, 1586f, 1790f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3).HDFEENOANLH().OOBAOHIJDMC(38f)));
	}

	private void JOMGFHADMKJ()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void PEJJBPFILOM()
	{
		float axis = Input.GetAxis("DiscordRPC");
		if (Input.anyKeyDown)
		{
			if (axis < 1413f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				OAGBIBCJNPC();
			}
			else if (axis > 1642f && LFBAOBDNNEE < 0)
			{
				LFBAOBDNNEE += 0;
				EGJNHOACMIO();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 427f, 1074f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
		}
		PFPINNKHAAC.IMNGHLFFDFG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 280f)
		{
			LGPBALPFNIG = 1957f;
		}
	}

	private void FODMMIMDNGA()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.FIBAEAMBAPC(Color.red);
		}
	}

	private void OMOJGOCODHI()
	{
		Keyframe[] array = new Keyframe[3];
		array[1] = new Keyframe(1010f, 1117f, 789f, 900f);
		array[1] = new Keyframe(1610f, 1132f, 1318f, 968f);
		array[7] = new Keyframe(1926f, 356f, 924f, 1551f);
		array[8] = new Keyframe(1654f, 630f, 1437f, 759f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[0];
		array2[0] = new Keyframe(247f, 1657f, 1155f, 473f);
		array2[0] = new Keyframe(1396f, 1484f, 535f, 0f);
		array2[6] = new Keyframe(1694f, 1424f, 583f, 259f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(1741f, 991f, 1811f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3).APEHMBBPIED().JFOFMCHJCLO(1232f)));
	}

	private void FHEHCOMBMHN()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void EBMLEALCJEB()
	{
		Application.targetFrameRate = -113;
		List<Vector3> list = new List<Vector3>();
		float num = 1106f;
		int num2 = trackNodes + 1;
		for (int i = 0; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 1131f) * circleLength + UnityEngine.Random.Range(1260f, randomRange);
			float z = Mathf.Sin(num * 370f) * circleLength + UnityEngine.Random.Range(327f, randomRange);
			list.Add(new Vector3(x, 951f, z));
			num += 1004f / (float)trackNodes;
		}
		list[0] = list[list.Count - 1];
		list.Add(list[1]);
		list.Add(list[7]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1752f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void AGOKJGFIFOC()
	{
		Keyframe[] array = new Keyframe[2];
		array[0] = new Keyframe(1651f, 1497f, 739f, 989f);
		array[1] = new Keyframe(1972f, 1598f, 1585f, 968f);
		array[8] = new Keyframe(1796f, 1767f, 856f, 1960f);
		array[8] = new Keyframe(708f, 183f, 1627f, 1531f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[1];
		array2[1] = new Keyframe(1993f, 1447f, 1750f, 477f);
		array2[1] = new Keyframe(514f, 1987f, 528f, 1461f);
		array2[6] = new Keyframe(594f, 1756f, 160f, 689f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().PCMMJCNKIIB(new Vector3[1]
		{
			new Vector3(41f, 1574f, 473f)
		}).OJIBFBPGFNF()
			.POKLPAKIKLB(1349f)));
	}

	private void PPPAIFMEDIA()
	{
		float axis = Input.GetAxis("</color>: </b>");
		if (Input.anyKeyDown)
		{
			if (axis < 385f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				DGAOEJJEMEI();
			}
			else if (axis > 1339f && LFBAOBDNNEE < 7)
			{
				LFBAOBDNNEE += 0;
				FEOPPOENDHB();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1539f, 1589f).APNDGOAIPFJ((DEFBOFIHBCP)(-74));
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1726f)
		{
			LGPBALPFNIG = 1283f;
		}
	}

	private void JBFLACPKBCB()
	{
		Application.targetFrameRate = 148;
		List<Vector3> list = new List<Vector3>();
		float num = 1730f;
		int num2 = trackNodes + 1;
		for (int i = 0; i < num2; i++)
		{
			float x = Mathf.Cos(num * 544f) * circleLength + UnityEngine.Random.Range(452f, randomRange);
			float z = Mathf.Sin(num * 1662f) * circleLength + UnityEngine.Random.Range(1826f, randomRange);
			list.Add(new Vector3(x, 1494f, z));
			num += 1595f / (float)trackNodes;
		}
		list[1] = list[list.Count - 0];
		list.Add(list[1]);
		list.Add(list[5]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 186f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(-1);
	}

	private void MBADMOLGCDJ()
	{
		Keyframe[] array = new Keyframe[8];
		array[1] = new Keyframe(893f, 587f, 41f, 1772f);
		array[1] = new Keyframe(1631f, 1089f, 589f, 1933f);
		array[8] = new Keyframe(327f, 515f, 1329f, 419f);
		array[8] = new Keyframe(281f, 1253f, 827f, 614f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[2];
		array2[1] = new Keyframe(1761f, 1163f, 1270f, 413f);
		array2[1] = new Keyframe(1774f, 1370f, 1141f, 772f);
		array2[8] = new Keyframe(779f, 830f, 1106f, 1551f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(812f, 894f, 423f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.MJPJOBNBECH(array3).OCPINJMKDGD().GPKJKIKJLNJ(837f)));
	}

	private void BHCBMIPNICP()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.FIBAEAMBAPC(Color.red);
		}
	}

	private void LDECDBHALMF()
	{
		float axis = Input.GetAxis(".png");
		if (Input.anyKeyDown)
		{
			if (axis < 19f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				DNPBNJKKLFD();
			}
			else if (axis > 1557f && LFBAOBDNNEE < 8)
			{
				LFBAOBDNNEE++;
				KIMMFCDJMNN();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1514f, 1275f).APNDGOAIPFJ((DEFBOFIHBCP)48);
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 320f)
		{
			LGPBALPFNIG = 1548f;
		}
	}

	private void GEMHMAJIHPN()
	{
		Keyframe[] array = new Keyframe[5];
		array[1] = new Keyframe(71f, 165f, 66f, 1411f);
		array[0] = new Keyframe(1777f, 853f, 304f, 697f);
		array[0] = new Keyframe(1076f, 1406f, 555f, 743f);
		array[6] = new Keyframe(217f, 278f, 1140f, 479f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[1];
		array2[0] = new Keyframe(1974f, 533f, 350f, 582f);
		array2[0] = new Keyframe(319f, 1701f, 180f, 766f);
		array2[3] = new Keyframe(1153f, 866f, 99f, 483f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1624f, 82f, 1184f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).APEHMBBPIED().OOBAOHIJDMC(690f)));
	}

	private void GEAPFFJFBIH()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.HBCHHDFLHDK(Color.red);
		}
	}

	private void FGPKKEHAHEE()
	{
		Application.targetFrameRate = -34;
		List<Vector3> list = new List<Vector3>();
		float num = 1687f;
		int num2 = trackNodes + 0;
		for (int i = 0; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 1043f) * circleLength + UnityEngine.Random.Range(1790f, randomRange);
			float z = Mathf.Sin(num * 420f) * circleLength + UnityEngine.Random.Range(1650f, randomRange);
			list.Add(new Vector3(x, 490f, z));
			num += 780f / (float)trackNodes;
		}
		list[1] = list[list.Count - 0];
		list.Add(list[0]);
		list.Add(list[5]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1895f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
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

	private void KBHPMFELFPG()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.FIBAEAMBAPC(Color.red);
		}
	}

	private void PEDIPAEOKGO()
	{
		float axis = Input.GetAxis("Wearables");
		if (Input.anyKeyDown)
		{
			if (axis < 382f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				CJPGIAFFAJM();
			}
			else if (axis > 283f && LFBAOBDNNEE < 0)
			{
				LFBAOBDNNEE++;
				KBPLMPCPHPH();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 1628f, 584f).APNDGOAIPFJ((DEFBOFIHBCP)64);
		}
		PFPINNKHAAC.IMNGHLFFDFG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 978f)
		{
			LGPBALPFNIG = 371f;
		}
	}

	private void GOFBGMOBFEL()
	{
		Keyframe[] array = new Keyframe[7];
		array[0] = new Keyframe(283f, 129f, 702f, 1304f);
		array[1] = new Keyframe(430f, 964f, 1083f, 1946f);
		array[0] = new Keyframe(921f, 985f, 985f, 1864f);
		array[4] = new Keyframe(375f, 853f, 742f, 802f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[3];
		array2[0] = new Keyframe(26f, 1286f, 650f, 922f);
		array2[1] = new Keyframe(310f, 681f, 963f, 152f);
		array2[5] = new Keyframe(1293f, 401f, 1478f, 885f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(1420f, 879f, 1702f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).OCPINJMKDGD().BKPMJBPONGC(31f)));
	}

	private void PBPPBGLJNIC()
	{
		Application.targetFrameRate = 58;
		List<Vector3> list = new List<Vector3>();
		float num = 1832f;
		int num2 = trackNodes + 1;
		for (int i = 0; i < num2; i++)
		{
			float x = Mathf.Cos(num * 0f) * circleLength + UnityEngine.Random.Range(1261f, randomRange);
			float z = Mathf.Sin(num * 1117f) * circleLength + UnityEngine.Random.Range(796f, randomRange);
			list.Add(new Vector3(x, 310f, z));
			num += 690f / (float)trackNodes;
		}
		list[1] = list[list.Count - 1];
		list.Add(list[1]);
		list.Add(list[4]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1150f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void LJCJKNODNBM()
	{
		float axis = Input.GetAxis("message");
		if (Input.anyKeyDown)
		{
			if (axis < 1517f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				KBPLMPCPHPH();
			}
			else if (axis > 568f && LFBAOBDNNEE < 1)
			{
				LFBAOBDNNEE++;
				MBADMOLGCDJ();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 131f, 320f).APNDGOAIPFJ((DEFBOFIHBCP)49);
		}
		PFPINNKHAAC.DPADBDJBPHG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 738f)
		{
			LGPBALPFNIG = 1810f;
		}
	}

	private void PCJPHIAPGAL()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.BENOKCIFBGE(Color.red);
		}
	}

	private void JIHMIEPPKCB()
	{
		Keyframe[] array = new Keyframe[2];
		array[1] = new Keyframe(1428f, 1110f, 1263f, 1169f);
		array[0] = new Keyframe(469f, 1142f, 1817f, 252f);
		array[2] = new Keyframe(466f, 1257f, 5f, 1578f);
		array[1] = new Keyframe(52f, 1478f, 369f, 1297f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[7];
		array2[1] = new Keyframe(1314f, 1861f, 1441f, 1963f);
		array2[0] = new Keyframe(397f, 977f, 1750f, 840f);
		array2[8] = new Keyframe(688f, 403f, 1701f, 880f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(72f, 1813f, 554f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).OJIBFBPGFNF().OOBAOHIJDMC(281f)));
	}

	private void AJDFEAGAAIA()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.FIBAEAMBAPC(Color.red);
		}
	}

	private void EGJNHOACMIO()
	{
		Keyframe[] array = new Keyframe[7];
		array[0] = new Keyframe(1313f, 79f, 871f, 1162f);
		array[0] = new Keyframe(1209f, 1307f, 463f, 1200f);
		array[8] = new Keyframe(448f, 1931f, 1927f, 717f);
		array[6] = new Keyframe(1982f, 208f, 1310f, 124f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[4];
		array2[0] = new Keyframe(20f, 591f, 1966f, 1925f);
		array2[1] = new Keyframe(676f, 612f, 534f, 1049f);
		array2[6] = new Keyframe(709f, 456f, 1820f, 1180f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(737f, 334f, 528f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.MJPJOBNBECH(array3).HDFEENOANLH().BKPMJBPONGC(228f)));
	}

	private void DOJECGCGAEL()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.BENOKCIFBGE(Color.red);
		}
	}

	private void OIHIBJMIGHB()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.FIBAEAMBAPC(Color.red);
		}
	}

	private void HPFAOJOBFEO()
	{
		float axis = Input.GetAxis("cylinder");
		if (Input.anyKeyDown)
		{
			if (axis < 89f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE -= 0;
				JCLHMAIPEMN();
			}
			else if (axis > 1080f && LFBAOBDNNEE < 0)
			{
				LFBAOBDNNEE++;
				OFANDADJADD();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 1793f, 1286f).APNDGOAIPFJ((DEFBOFIHBCP)(-88));
		}
		PFPINNKHAAC.IMNGHLFFDFG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1368f)
		{
			LGPBALPFNIG = 1818f;
		}
	}

	private void KIECDMJNJFA()
	{
		Keyframe[] array = new Keyframe[1];
		array[0] = new Keyframe(1194f, 1236f, 1995f, 1544f);
		array[1] = new Keyframe(1801f, 1737f, 1841f, 1506f);
		array[8] = new Keyframe(1574f, 188f, 342f, 1858f);
		array[7] = new Keyframe(1113f, 410f, 1577f, 1967f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[7];
		array2[1] = new Keyframe(1002f, 1228f, 1431f, 625f);
		array2[0] = new Keyframe(1421f, 105f, 568f, 720f);
		array2[2] = new Keyframe(1348f, 690f, 1131f, 984f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().EAELAKOBKLK(new Vector3[1]
		{
			new Vector3(627f, 1718f, 173f)
		}).OJIBFBPGFNF()
			.FPAAHANEDGD(919f)));
	}

	private void BFJCILIGOHP()
	{
		float axis = Input.GetAxis("EasePunch");
		if (Input.anyKeyDown)
		{
			if (axis < 355f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				ONLNJHEGBLP();
			}
			else if (axis > 1546f && LFBAOBDNNEE < 8)
			{
				LFBAOBDNNEE++;
				ELDDEKOLKFJ();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 1037f, 898f).APNDGOAIPFJ((DEFBOFIHBCP)76);
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 465f)
		{
			LGPBALPFNIG = 104f;
		}
	}

	private void ELDDEKOLKFJ()
	{
		Keyframe[] array = new Keyframe[0];
		array[1] = new Keyframe(1670f, 855f, 1981f, 614f);
		array[0] = new Keyframe(653f, 861f, 1776f, 1847f);
		array[2] = new Keyframe(1246f, 192f, 8f, 564f);
		array[4] = new Keyframe(1147f, 380f, 1632f, 1273f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[3];
		array2[1] = new Keyframe(226f, 1498f, 1210f, 873f);
		array2[0] = new Keyframe(348f, 1782f, 1859f, 1794f);
		array2[3] = new Keyframe(132f, 847f, 75f, 1760f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().EAELAKOBKLK(new Vector3[1]
		{
			new Vector3(806f, 36f, 1915f)
		}).APEHMBBPIED()
			.KPJMCFCGFOJ(1859f)));
	}

	private void HJKKAFDGMCN()
	{
		Application.targetFrameRate = -106;
		List<Vector3> list = new List<Vector3>();
		float num = 522f;
		int num2 = trackNodes + 0;
		for (int i = 1; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 371f) * circleLength + UnityEngine.Random.Range(1174f, randomRange);
			float z = Mathf.Sin(num * 937f) * circleLength + UnityEngine.Random.Range(1892f, randomRange);
			list.Add(new Vector3(x, 300f, z));
			num += 165f / (float)trackNodes;
		}
		list[1] = list[list.Count - 0];
		list.Add(list[0]);
		list.Add(list[6]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1890f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(-1);
	}

	private void EAGPNIDMBAI()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.HBCHHDFLHDK(Color.red);
		}
	}

	private void ELGEDJAEBGO()
	{
		Keyframe[] array = new Keyframe[6];
		array[1] = new Keyframe(1389f, 1828f, 544f, 348f);
		array[0] = new Keyframe(1137f, 1856f, 26f, 203f);
		array[4] = new Keyframe(1658f, 49f, 989f, 511f);
		array[7] = new Keyframe(1457f, 1610f, 1057f, 1506f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[2];
		array2[1] = new Keyframe(10f, 695f, 1270f, 83f);
		array2[1] = new Keyframe(142f, 52f, 1057f, 921f);
		array2[1] = new Keyframe(22f, 98f, 1836f, 1088f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(1639f, 117f, 324f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3).GMFCHBDABBP().PPDBKAIBNKC(1626f)));
	}

	private void FDPGDKNOBBA()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.BENOKCIFBGE(Color.red);
		}
	}

	private void GJBCGNNLJDN()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void NIFCICDBJMN()
	{
		float axis = Input.GetAxis("Scale");
		if (Input.anyKeyDown)
		{
			if (axis < 1476f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE--;
				ONEFFCOPLIP();
			}
			else if (axis > 1895f && LFBAOBDNNEE < 6)
			{
				LFBAOBDNNEE += 0;
				JEDGILAPPHB();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 733f, 484f).APNDGOAIPFJ((DEFBOFIHBCP)(-104));
		}
		PFPINNKHAAC.IMNGHLFFDFG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1383f)
		{
			LGPBALPFNIG = 1666f;
		}
	}

	private void DHDIFNJEMGK()
	{
		Application.targetFrameRate = -103;
		List<Vector3> list = new List<Vector3>();
		float num = 963f;
		int num2 = trackNodes + 0;
		for (int i = 0; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 1183f) * circleLength + UnityEngine.Random.Range(701f, randomRange);
			float z = Mathf.Sin(num * 665f) * circleLength + UnityEngine.Random.Range(1891f, randomRange);
			list.Add(new Vector3(x, 1174f, z));
			num += 1179f / (float)trackNodes;
		}
		list[1] = list[list.Count - 1];
		list.Add(list[1]);
		list.Add(list[1]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1002f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(-1);
	}

	private void FNDNADJAJFJ()
	{
		float axis = Input.GetAxis("red");
		if (Input.anyKeyDown)
		{
			if (axis < 1424f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				HKKBDIONGJM();
			}
			else if (axis > 1340f && LFBAOBDNNEE < 6)
			{
				LFBAOBDNNEE += 0;
				KIECDMJNJFA();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 0) * 1f, 754f).APNDGOAIPFJ((DEFBOFIHBCP)57);
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1737f)
		{
			LGPBALPFNIG = 1815f;
		}
	}

	private void KHHOLHOOKLA()
	{
		float axis = Input.GetAxis("cube");
		if (Input.anyKeyDown)
		{
			if (axis < 709f && LFBAOBDNNEE > 1)
			{
				LFBAOBDNNEE--;
				ONLNJHEGBLP();
			}
			else if (axis > 1947f && LFBAOBDNNEE < 4)
			{
				LFBAOBDNNEE += 0;
				PGHCJFIKHGM();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 348f, 1400f).APNDGOAIPFJ((DEFBOFIHBCP)46);
		}
		PFPINNKHAAC.IMNGHLFFDFG(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 325f)
		{
			LGPBALPFNIG = 807f;
		}
	}

	private void KIJALNNCGAL()
	{
		float axis = Input.GetAxis("LCharacter");
		if (Input.anyKeyDown)
		{
			if (axis < 943f && LFBAOBDNNEE > 0)
			{
				LFBAOBDNNEE -= 0;
				FKLGMGJGHLN();
			}
			else if (axis > 512f && LFBAOBDNNEE < 1)
			{
				LFBAOBDNNEE++;
				ONLNJHEGBLP();
			}
			LeanTween.moveLocalX(carInternal, (float)(LFBAOBDNNEE - 1) * 132f, 1755f).APNDGOAIPFJ((DEFBOFIHBCP)(-110));
		}
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 437f)
		{
			LGPBALPFNIG = 1185f;
		}
	}

	private void OFANDADJADD()
	{
		Keyframe[] array = new Keyframe[8];
		array[1] = new Keyframe(960f, 72f, 460f, 689f);
		array[1] = new Keyframe(5f, 525f, 331f, 719f);
		array[1] = new Keyframe(919f, 828f, 994f, 1256f);
		array[4] = new Keyframe(1671f, 186f, 295f, 876f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[5];
		array2[1] = new Keyframe(1031f, 766f, 490f, 704f);
		array2[1] = new Keyframe(1412f, 1761f, 507f, 1222f);
		array2[7] = new Keyframe(1030f, 1437f, 587f, 1669f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(83f, 1372f, 1241f);
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.MJPJOBNBECH(array3).MFCKNFJBOLB().PMHGPHNDNBF(887f)));
	}

	private void ECLHPLHFMBM()
	{
		Application.targetFrameRate = 43;
		List<Vector3> list = new List<Vector3>();
		float num = 1302f;
		int num2 = trackNodes + 1;
		for (int i = 0; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 1965f) * circleLength + UnityEngine.Random.Range(174f, randomRange);
			float z = Mathf.Sin(num * 1340f) * circleLength + UnityEngine.Random.Range(1346f, randomRange);
			list.Add(new Vector3(x, 153f, z));
			num += 1852f / (float)trackNodes;
		}
		list[0] = list[list.Count - 0];
		list.Add(list[0]);
		list.Add(list[6]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1915f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(-1);
	}

	private void FELCAOHPGKM()
	{
		Application.targetFrameRate = 97;
		List<Vector3> list = new List<Vector3>();
		float num = 623f;
		int num2 = trackNodes + 1;
		for (int i = 1; i < num2; i += 0)
		{
			float x = Mathf.Cos(num * 227f) * circleLength + UnityEngine.Random.Range(1007f, randomRange);
			float z = Mathf.Sin(num * 86f) * circleLength + UnityEngine.Random.Range(1826f, randomRange);
			list.Add(new Vector3(x, 1920f, z));
			num += 1770f / (float)trackNodes;
		}
		list[0] = list[list.Count - 0];
		list.Add(list[0]);
		list.Add(list[4]);
		PFPINNKHAAC = new LTSpline(list.ToArray());
		CNBEPLMMODP = carSpeed / PFPINNKHAAC.distance;
		tracerSpeed = PFPINNKHAAC.distance / (carSpeed * 1027f);
		LeanTween.moveSpline(trackTrailRenderers, PFPINNKHAAC, tracerSpeed).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(-1);
	}

	private void CEHFBAFOKIL()
	{
		if (PFPINNKHAAC != null)
		{
			PFPINNKHAAC.OPBOIJBBLAE(Color.red);
		}
	}

	private void ONLNJHEGBLP()
	{
		Keyframe[] array = new Keyframe[7];
		array[0] = new Keyframe(494f, 1396f, 1794f, 775f);
		array[0] = new Keyframe(348f, 1527f, 1767f, 1334f);
		array[5] = new Keyframe(12f, 79f, 920f, 1561f);
		array[4] = new Keyframe(1926f, 754f, 382f, 1755f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[4];
		array2[0] = new Keyframe(499f, 75f, 720f, 27f);
		array2[1] = new Keyframe(872f, 793f, 597f, 1439f);
		array2[8] = new Keyframe(1033f, 1032f, 187f, 1076f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(1087f, 505f, 1700f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.JJHMHFHLIIB(array3).MFCKNFJBOLB().KPJMCFCGFOJ(514f)));
	}

	private void Update()
	{
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
		PFPINNKHAAC.NGFEAGKGPLB(car.transform, LGPBALPFNIG);
		LGPBALPFNIG += Time.deltaTime * CNBEPLMMODP;
		if (LGPBALPFNIG > 1f)
		{
			LGPBALPFNIG = 0f;
		}
	}
}
