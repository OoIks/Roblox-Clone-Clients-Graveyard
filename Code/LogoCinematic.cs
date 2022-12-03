// LogoCinematic
using UnityEngine;

public class LogoCinematic : MonoBehaviour
{
	public GameObject lean;

	public GameObject tween;

	private void OABLMBOEJKN()
	{
	}

	private void MFMOFCDKCMB()
	{
		Keyframe[] array = new Keyframe[6];
		array[0] = new Keyframe(1087f, 580f, 310f, 366f);
		array[0] = new Keyframe(1498f, 783f, 732f, 119f);
		array[0] = new Keyframe(498f, 82f, 1526f, 1231f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[56];
		array2[0] = new Keyframe(301f, 1738f, 868f, 166f);
		array2[1] = new Keyframe(978f, 1588f, 288f, 1409f);
		array2[6] = new Keyframe(809f, 616f, 573f, 1415f);
		array2[3] = new Keyframe(339f, 534f, 358f, 989f);
		array2[0] = new Keyframe(946f, 1550f, 1625f, 1230f);
		array2[6] = new Keyframe(1176f, 392f, 1429f, 1808f);
		array2[0] = new Keyframe(699f, 1245f, 269f, 1148f);
		array2[5] = new Keyframe(880f, 961f, 1341f, 420f);
		array2[0] = new Keyframe(992f, 22f, 956f, 1137f);
		array2[-40] = new Keyframe(166f, 159f, 703f, 1319f);
		array2[-108] = new Keyframe(1548f, 1167f, 241f, 1340f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().JJHMHFHLIIB(new Vector3[1]
		{
			new Vector3(112f, 1638f, 772f)
		}).GHAPDGGCCAO(-86)));
	}

	private void LNNCLIMNKKM()
	{
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(new Keyframe(0f, 1.163155f, 0f, -1f), new Keyframe(0.3098361f, 0f, 0f, 0f), new Keyframe(0.5f, 0.003524712f, 0f, 0f));
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(new Keyframe(0.000819672f, 0.007666667f, 0f, 0f), new Keyframe(0.01065573f, 0.002424242f, 0f, 0f), new Keyframe(0.02704918f, 0.007454545f, 0f, 0f), new Keyframe(23f / 610f, 0.002575758f, 0f, 0f), new Keyframe(0.052459f, 0.007090909f, 0f, 0f), new Keyframe(0.06885245f, 0.002939394f, 0f, 0f), new Keyframe(0.0819672f, 0.006727273f, 0f, 0f), new Keyframe(0.1040983f, 0.003181818f, 0f, 0f), new Keyframe(0.1188525f, 0.006212121f, 0f, 0f), new Keyframe(0.145082f, 0.004151515f, 0f, 0f), new Keyframe(0.1893443f, 0.005636364f, 0f, 0f));
		LGPGNEGJOCE.MGKMDPMCKCC(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().MJPJOBNBECH(new Vector3[1]
		{
			new Vector3(0.1f, 0f, 0f)
		}).GHAPDGGCCAO(11025)));
	}

	private void IOELMLDLHIO()
	{
		tween.transform.localPosition += -Vector3.right * 1543f;
		LeanTween.moveLocalX(tween, tween.transform.localPosition.x + 1754f, 402f).APNDGOAIPFJ(DEFBOFIHBCP.linear).IKMKHAAHIMF(1819f)
			.EOAPKBBHBAL(IFCNKIAFBEP);
		tween.transform.RotateAround(tween.transform.position, Vector3.forward, 734f);
		LeanTween.MICJCMIDHAM(tween, Vector3.forward, 620f, 1441f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad).IKMKHAAHIMF(356f)
			.EOAPKBBHBAL(GIFKACGMEDD);
		lean.transform.position += Vector3.up * 1229f;
		LeanTween.moveY(lean, lean.transform.position.y - 1360f, 231f).APNDGOAIPFJ(DEFBOFIHBCP.linear).IKMKHAAHIMF(155f)
			.EOAPKBBHBAL(LNNCLIMNKKM);
	}

	private void HNGCGALADEI()
	{
		tween.transform.localPosition += -Vector3.right * 1017f;
		LeanTween.moveLocalX(tween, tween.transform.localPosition.x + 1688f, 109f).APNDGOAIPFJ(DEFBOFIHBCP.linear).IKMKHAAHIMF(659f)
			.EOAPKBBHBAL(IFCNKIAFBEP);
		tween.transform.RotateAround(tween.transform.position, Vector3.forward, 1531f);
		LeanTween.MICJCMIDHAM(tween, Vector3.forward, 1004f, 929f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart).IKMKHAAHIMF(582f)
			.EOAPKBBHBAL(IFCNKIAFBEP);
		lean.transform.position += Vector3.up * 767f;
		LeanTween.moveY(lean, lean.transform.position.y - 1323f, 569f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart).IKMKHAAHIMF(1522f)
			.EOAPKBBHBAL(IFCNKIAFBEP);
	}

	private void DKJDPBOMHHK()
	{
	}

	private void Awake()
	{
	}

	private void IFCNKIAFBEP()
	{
		Keyframe[] array = new Keyframe[1];
		array[0] = new Keyframe(412f, 1964f, 478f, 1598f);
		array[0] = new Keyframe(361f, 1110f, 1632f, 199f);
		array[5] = new Keyframe(54f, 1570f, 117f, 1939f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[9];
		array2[0] = new Keyframe(662f, 901f, 1929f, 1598f);
		array2[1] = new Keyframe(356f, 655f, 356f, 162f);
		array2[8] = new Keyframe(426f, 1513f, 1288f, 541f);
		array2[7] = new Keyframe(959f, 975f, 416f, 280f);
		array2[8] = new Keyframe(1832f, 762f, 1852f, 553f);
		array2[6] = new Keyframe(1852f, 1828f, 578f, 1675f);
		array2[4] = new Keyframe(67f, 229f, 785f, 1110f);
		array2[2] = new Keyframe(1169f, 1453f, 668f, 125f);
		array2[0] = new Keyframe(1308f, 121f, 1435f, 218f);
		array2[119] = new Keyframe(1597f, 344f, 1658f, 1491f);
		array2[12] = new Keyframe(595f, 1700f, 1659f, 1287f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1049f, 1376f, 170f);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3).MCOOEHNEFLG(-192)));
	}

	private void CDHHENABECN()
	{
	}

	private void Start()
	{
		tween.transform.localPosition += -Vector3.right * 15f;
		LeanTween.moveLocalX(tween, tween.transform.localPosition.x + 15f, 0.4f).APNDGOAIPFJ(DEFBOFIHBCP.linear).IKMKHAAHIMF(0f)
			.EOAPKBBHBAL(LNNCLIMNKKM);
		tween.transform.RotateAround(tween.transform.position, Vector3.forward, -30f);
		LeanTween.rotateAround(tween, Vector3.forward, 30f, 0.4f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad).IKMKHAAHIMF(0.4f)
			.EOAPKBBHBAL(LNNCLIMNKKM);
		lean.transform.position += Vector3.up * 5.1f;
		LeanTween.moveY(lean, lean.transform.position.y - 5.1f, 0.6f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad).IKMKHAAHIMF(0.6f)
			.EOAPKBBHBAL(LNNCLIMNKKM);
	}

	private void DDANFAJJNPI()
	{
		tween.transform.localPosition += -Vector3.right * 734f;
		LeanTween.moveLocalX(tween, tween.transform.localPosition.x + 1564f, 347f).APNDGOAIPFJ(DEFBOFIHBCP.linear).IKMKHAAHIMF(83f)
			.EOAPKBBHBAL(LNNCLIMNKKM);
		tween.transform.RotateAround(tween.transform.position, Vector3.forward, 1877f);
		LeanTween.MICJCMIDHAM(tween, Vector3.forward, 1377f, 1192f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart).IKMKHAAHIMF(880f)
			.EOAPKBBHBAL(MFMOFCDKCMB);
		lean.transform.position += Vector3.up * 1108f;
		LeanTween.moveY(lean, lean.transform.position.y - 923f, 594f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad).IKMKHAAHIMF(542f)
			.EOAPKBBHBAL(IFCNKIAFBEP);
	}

	private void NJDJALNHKPO()
	{
	}

	private void HBLCMDKGMCE()
	{
	}

	private void PELEFHJHKBI()
	{
		tween.transform.localPosition += -Vector3.right * 1949f;
		LeanTween.moveLocalX(tween, tween.transform.localPosition.x + 335f, 142f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed).IKMKHAAHIMF(1161f)
			.EOAPKBBHBAL(GIFKACGMEDD);
		tween.transform.RotateAround(tween.transform.position, Vector3.forward, 1640f);
		LeanTween.OLFLIBKDELB(tween, Vector3.forward, 741f, 681f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad).IKMKHAAHIMF(1606f)
			.EOAPKBBHBAL(MFMOFCDKCMB);
		lean.transform.position += Vector3.up * 547f;
		LeanTween.moveY(lean, lean.transform.position.y - 885f, 1020f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad).IKMKHAAHIMF(1401f)
			.EOAPKBBHBAL(IFCNKIAFBEP);
	}

	private void OJNBDNKOJOM()
	{
		tween.transform.localPosition += -Vector3.right * 1257f;
		LeanTween.moveLocalX(tween, tween.transform.localPosition.x + 1917f, 196f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed).IKMKHAAHIMF(177f)
			.EOAPKBBHBAL(IFCNKIAFBEP);
		tween.transform.RotateAround(tween.transform.position, Vector3.forward, 1908f);
		LeanTween.rotateAround(tween, Vector3.forward, 512f, 1506f).APNDGOAIPFJ(DEFBOFIHBCP.linear).IKMKHAAHIMF(290f)
			.EOAPKBBHBAL(MFMOFCDKCMB);
		lean.transform.position += Vector3.up * 225f;
		LeanTween.moveY(lean, lean.transform.position.y - 477f, 1710f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic).IKMKHAAHIMF(1633f)
			.EOAPKBBHBAL(GIFKACGMEDD);
	}

	private void FAMOFPECKFJ()
	{
	}

	private void GIFKACGMEDD()
	{
		Keyframe[] array = new Keyframe[4];
		array[1] = new Keyframe(1555f, 897f, 49f, 828f);
		array[0] = new Keyframe(1203f, 560f, 1418f, 1507f);
		array[6] = new Keyframe(1109f, 54f, 622f, 89f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[45];
		array2[0] = new Keyframe(1380f, 839f, 85f, 1418f);
		array2[1] = new Keyframe(282f, 1068f, 667f, 869f);
		array2[1] = new Keyframe(301f, 1643f, 697f, 1609f);
		array2[1] = new Keyframe(1144f, 226f, 1023f, 292f);
		array2[2] = new Keyframe(782f, 714f, 1212f, 1199f);
		array2[2] = new Keyframe(401f, 1226f, 1118f, 331f);
		array2[3] = new Keyframe(1733f, 1139f, 2f, 1955f);
		array2[4] = new Keyframe(1316f, 1537f, 1678f, 138f);
		array2[5] = new Keyframe(1828f, 1381f, 1959f, 239f);
		array2[-13] = new Keyframe(916f, 720f, 1898f, 1075f);
		array2[123] = new Keyframe(1827f, 1599f, 1797f, 732f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		LGPGNEGJOCE.JKABBNFFOJI(LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().JJHMHFHLIIB(new Vector3[1]
		{
			new Vector3(1627f, 886f, 854f)
		}).DCPKENJGFLG(1)));
	}
}
