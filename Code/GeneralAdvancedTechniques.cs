// GeneralAdvancedTechniques
using System.Runtime.CompilerServices;
using UnityEngine;

public class GeneralAdvancedTechniques : MonoBehaviour
{
	public GameObject avatarRecursive;

	public GameObject avatar2dRecursive;

	public RectTransform wingPersonPanel;

	public RectTransform textField;

	public GameObject avatarMove;

	public Transform[] movePts;

	public GameObject[] avatarSpeed;

	public GameObject[] avatarSpeed2;

	private Vector3[] MPHBOMALPLM = new Vector3[32]
	{
		new Vector3(16f, 0f, 0f),
		new Vector3(14.56907f, 8.009418f, 0f),
		new Vector3(15.96541f, 4.638379f, 0f),
		new Vector3(11.31371f, 11.31371f, 0f),
		new Vector3(11.31371f, 11.31371f, 0f),
		new Vector3(4.638379f, 15.96541f, 0f),
		new Vector3(8.009416f, 14.56908f, 0f),
		new Vector3(-6.993822E-07f, 16f, 0f),
		new Vector3(-6.993822E-07f, 16f, 0f),
		new Vector3(-8.009419f, 14.56907f, 0f),
		new Vector3(-4.63838f, 15.9654f, 0f),
		new Vector3(-11.31371f, 11.31371f, 0f),
		new Vector3(-11.31371f, 11.31371f, 0f),
		new Vector3(-15.9654f, 4.63838f, 0f),
		new Vector3(-14.56908f, 8.009415f, 0f),
		new Vector3(-16f, -1.398764E-06f, 0f),
		new Vector3(-16f, -1.398764E-06f, 0f),
		new Vector3(-14.56907f, -8.009418f, 0f),
		new Vector3(-15.9654f, -4.638382f, 0f),
		new Vector3(-11.31371f, -11.31371f, 0f),
		new Vector3(-11.31371f, -11.31371f, 0f),
		new Vector3(-4.638381f, -15.9654f, 0f),
		new Vector3(-8.009413f, -14.56908f, 0f),
		new Vector3(1.907981E-07f, -16f, 0f),
		new Vector3(1.907981E-07f, -16f, 0f),
		new Vector3(8.00942f, -14.56907f, 0f),
		new Vector3(4.638381f, -15.9654f, 0f),
		new Vector3(11.31371f, -11.3137f, 0f),
		new Vector3(11.31371f, -11.3137f, 0f),
		new Vector3(15.96541f, -4.638378f, 0f),
		new Vector3(14.56907f, -8.009418f, 0f),
		new Vector3(16f, 2.797529E-06f, 0f)
	};

	private Vector3[] MDGMMPHCGON = new Vector3[32]
	{
		new Vector3(25f, 0f, 0f),
		new Vector3(22.76418f, 12.51472f, 0f),
		new Vector3(24.94595f, 7.247467f, 0f),
		new Vector3(17.67767f, 17.67767f, 0f),
		new Vector3(17.67767f, 17.67767f, 0f),
		new Vector3(7.247467f, 24.94595f, 0f),
		new Vector3(12.51471f, 22.76418f, 0f),
		new Vector3(-1.092785E-06f, 25f, 0f),
		new Vector3(-1.092785E-06f, 25f, 0f),
		new Vector3(-12.51472f, 22.76418f, 0f),
		new Vector3(-7.247468f, 24.94594f, 0f),
		new Vector3(-17.67767f, 17.67767f, 0f),
		new Vector3(-17.67767f, 17.67767f, 0f),
		new Vector3(-24.94594f, 7.247468f, 0f),
		new Vector3(-22.76418f, 12.51471f, 0f),
		new Vector3(-25f, -2.185569E-06f, 0f),
		new Vector3(-25f, -2.185569E-06f, 0f),
		new Vector3(-22.76418f, -12.51472f, 0f),
		new Vector3(-24.94594f, -7.247472f, 0f),
		new Vector3(-17.67767f, -17.67767f, 0f),
		new Vector3(-17.67767f, -17.67767f, 0f),
		new Vector3(-7.247469f, -24.94594f, 0f),
		new Vector3(-12.51471f, -22.76418f, 0f),
		new Vector3(2.98122E-07f, -25f, 0f),
		new Vector3(2.98122E-07f, -25f, 0f),
		new Vector3(12.51472f, -22.76418f, 0f),
		new Vector3(7.24747f, -24.94594f, 0f),
		new Vector3(17.67768f, -17.67766f, 0f),
		new Vector3(17.67768f, -17.67766f, 0f),
		new Vector3(24.94595f, -7.247465f, 0f),
		new Vector3(22.76418f, -12.51472f, 0f),
		new Vector3(25f, 4.371139E-06f, 0f)
	};

	private void AFCELIGJJDC()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 206f, 1599f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 1998f, 1146f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 1802f, 140f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 500f, (float)movePts.Length - 1242f, 1643f).FONALENPCAI(KLOBIICBKKF).APNDGOAIPFJ((DEFBOFIHBCP)81)
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1723f, 1737f).IKMKHAAHIMF((float)i * 1721f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 1835f, 1014f).MLCPFKNPENM(338f).APNDGOAIPFJ((DEFBOFIHBCP)57)
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1922f).MLCPFKNPENM(178f).MNELFOFMPKF(-1);
		}
	}

	private void ADGBACIFMMM(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void ILMPCBPAHLK()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 308f, 1448f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 160f, 1077f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 909f, 1541f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 1549f, (float)movePts.Length - 1506f, 1270f).FONALENPCAI(NNPPAMAFDGN).APNDGOAIPFJ((DEFBOFIHBCP)(-11))
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1017f, 1181f).IKMKHAAHIMF((float)i * 1266f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 1272f, 865f).MLCPFKNPENM(1189f).APNDGOAIPFJ((DEFBOFIHBCP)111)
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1947f).MLCPFKNPENM(124f).MNELFOFMPKF(-1);
		}
	}

	private void BINPDOFJLNK()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 1792f, 1517f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 1796f, 953f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 1357f, 460f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 1239f, (float)movePts.Length - 326f, 656f).FONALENPCAI(CFDJIANPOGE).APNDGOAIPFJ((DEFBOFIHBCP)77)
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 977f, 455f).IKMKHAAHIMF((float)i * 1531f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 685f, 426f).MLCPFKNPENM(1987f).APNDGOAIPFJ((DEFBOFIHBCP)84)
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k++)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 425f).MLCPFKNPENM(1345f).MNELFOFMPKF(-1);
		}
	}

	private void IPPBBBHIGBA(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void BHMGFDOOAEC()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 557f, 1777f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 719f, 1277f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 1186f, 1977f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 1113f, (float)movePts.Length - 1684f, 308f).FONALENPCAI(CJLKEDEIDLO).APNDGOAIPFJ((DEFBOFIHBCP)(-49))
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 181f, 1636f).IKMKHAAHIMF((float)i * 520f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 1536f, 688f).MLCPFKNPENM(861f).APNDGOAIPFJ((DEFBOFIHBCP)(-73))
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k++)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 933f).MLCPFKNPENM(1833f).MNELFOFMPKF(-1);
		}
	}

	private void PPGIGIMHOAK(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void FHLAEFHPLLA()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 860f, 1111f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 445f, 1985f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 1481f, 612f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.value(avatarMove, 1962f, (float)movePts.Length - 906f, 1383f).FONALENPCAI(CAIAAKCFCPM).APNDGOAIPFJ(DEFBOFIHBCP.punch)
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 448f, 612f).IKMKHAAHIMF((float)i * 549f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 331f, 1740f).MLCPFKNPENM(1499f).APNDGOAIPFJ((DEFBOFIHBCP)83)
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k++)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1927f).MLCPFKNPENM(1618f).MNELFOFMPKF(-1);
		}
	}

	private void FNIAHLHAMDL(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void OPMEGCJJNLC()
	{
		LeanTween.alpha(avatarRecursive, 1712f, 1033f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 1331f, 303f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 1f, 121f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 118f, (float)movePts.Length - 1725f, 853f).FONALENPCAI(DNAIGEHIODA).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad)
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 149f, 852f).IKMKHAAHIMF((float)i * 1652f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 939f, 1657f).MLCPFKNPENM(195f).APNDGOAIPFJ((DEFBOFIHBCP)(-67))
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k++)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1033f).MLCPFKNPENM(666f).MNELFOFMPKF(-1);
		}
	}

	private void AJKHKJOIAOO()
	{
		LeanTween.alpha(avatarRecursive, 1631f, 1077f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 1941f, 863f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 466f, 1970f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 77f, (float)movePts.Length - 353f, 833f).FONALENPCAI(ADGBACIFMMM).APNDGOAIPFJ((DEFBOFIHBCP)97)
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1669f, 749f).IKMKHAAHIMF((float)i * 888f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 1872f, 794f).MLCPFKNPENM(382f).APNDGOAIPFJ((DEFBOFIHBCP)(-108))
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k++)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 209f).MLCPFKNPENM(1638f).MNELFOFMPKF(-1);
		}
	}

	private void ACPAIIKIHEJ(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void LJHJJGDDAGK(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void NILIIPMKFFK(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void BPLHHAOIJFJ(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void FGFLCFGDHNC()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 1090f, 1212f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 967f, 1099f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 804f, 1795f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 158f, (float)movePts.Length - 1233f, 76f).FONALENPCAI(CBDGFKLBFPL).APNDGOAIPFJ((DEFBOFIHBCP)44)
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 987f, 1877f).IKMKHAAHIMF((float)i * 1996f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 694f, 1350f).MLCPFKNPENM(451f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCirc)
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 381f).MLCPFKNPENM(486f).MNELFOFMPKF(-1);
		}
	}

	private void KOEJHABBJMJ()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 537f, 1669f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 1810f, 1743f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 1674f, 534f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 724f, (float)movePts.Length - 1651f, 1045f).FONALENPCAI(MEOKKHFAAAA).APNDGOAIPFJ((DEFBOFIHBCP)(-45))
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1140f, 1818f).IKMKHAAHIMF((float)i * 1119f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 1966f, 918f).MLCPFKNPENM(1529f).APNDGOAIPFJ((DEFBOFIHBCP)(-32))
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k++)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 480f).MLCPFKNPENM(1339f).MNELFOFMPKF(-1);
		}
	}

	private void ANOPPBNGFJJ(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void CJLKEDEIDLO(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void IKHDIIEMPJC(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void EJFPBBBLFGC(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void HAIMMOBDCGM()
	{
		LeanTween.alpha(avatarRecursive, 1140f, 574f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 703f, 312f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 1995f, 1687f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 508f, (float)movePts.Length - 874f, 1223f).FONALENPCAI(IKHDIIEMPJC).APNDGOAIPFJ((DEFBOFIHBCP)65)
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 777f, 1066f).IKMKHAAHIMF((float)i * 211f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 1704f, 258f).MLCPFKNPENM(954f).APNDGOAIPFJ((DEFBOFIHBCP)(-85))
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k++)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1048f).MLCPFKNPENM(478f).MNELFOFMPKF(-1);
		}
	}

	private void LBMJJECMEDO()
	{
		LeanTween.alpha(avatarRecursive, 263f, 234f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 287f, 416f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 611f, 78f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.value(avatarMove, 815f, (float)movePts.Length - 634f, 1623f).FONALENPCAI(delegate(float GBMPBBHCBDA)
		{
			int num = (int)Mathf.Floor(GBMPBBHCBDA);
			int num2 = (num < movePts.Length - 1) ? (num + 1) : num;
			float d = GBMPBBHCBDA - (float)num;
			Vector3 a = movePts[num2].position - movePts[num].position;
			avatarMove.transform.position = movePts[num].position + a * d;
		}).APNDGOAIPFJ((DEFBOFIHBCP)(-77))
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 460f, 135f).IKMKHAAHIMF((float)i * 712f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 1629f, 528f).MLCPFKNPENM(1419f).APNDGOAIPFJ((DEFBOFIHBCP)107)
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1558f).MLCPFKNPENM(942f).MNELFOFMPKF(-1);
		}
	}

	private void EODENBEOJID()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 581f, 865f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 551f, 1598f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 1526f, 1539f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 991f, (float)movePts.Length - 688f, 418f).FONALENPCAI(ACPAIIKIHEJ).APNDGOAIPFJ((DEFBOFIHBCP)73)
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1640f, 1468f).IKMKHAAHIMF((float)i * 758f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 1451f, 451f).MLCPFKNPENM(1618f).APNDGOAIPFJ((DEFBOFIHBCP)(-111))
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 70f).MLCPFKNPENM(1414f).MNELFOFMPKF(-1);
		}
	}

	private void DNAIGEHIODA(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void NNPPAMAFDGN(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void CAIAAKCFCPM(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void EBMLEALCJEB()
	{
		LeanTween.alpha(avatarRecursive, 1755f, 1497f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 881f, 109f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 1677f, 1597f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.value(avatarMove, 1920f, (float)movePts.Length - 1708f, 1475f).FONALENPCAI(LJHJJGDDAGK).APNDGOAIPFJ((DEFBOFIHBCP)(-106))
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 189f, 931f).IKMKHAAHIMF((float)i * 1069f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 1215f, 1002f).MLCPFKNPENM(1782f).APNDGOAIPFJ((DEFBOFIHBCP)(-21))
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k++)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1168f).MLCPFKNPENM(572f).MNELFOFMPKF(-1);
		}
	}

	private void LHJAILEKNKI()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 1071f, 740f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 1871f, 1710f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 484f, 1667f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 1402f, (float)movePts.Length - 871f, 1810f).FONALENPCAI(ACPAIIKIHEJ).APNDGOAIPFJ((DEFBOFIHBCP)52)
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1420f, 1213f).IKMKHAAHIMF((float)i * 31f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 622f, 1398f).MLCPFKNPENM(260f).APNDGOAIPFJ((DEFBOFIHBCP)(-50))
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k++)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 815f).MLCPFKNPENM(576f).MNELFOFMPKF(-1);
		}
	}

	private void FGIPNFFOHFN()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 136f, 1606f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 857f, 1896f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 1011f, 1255f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 859f, (float)movePts.Length - 1463f, 1845f).FONALENPCAI(DCGNFNKDCBH).APNDGOAIPFJ((DEFBOFIHBCP)(-78))
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 21f, 1536f).IKMKHAAHIMF((float)i * 809f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 1273f, 836f).MLCPFKNPENM(390f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuint)
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1714f).MLCPFKNPENM(1861f).MNELFOFMPKF(-1);
		}
	}

	private void HDCCAIPKFIG(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void PELEFHJHKBI()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 1610f, 863f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 1884f, 1648f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 326f, 1739f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 953f, (float)movePts.Length - 1540f, 1151f).FONALENPCAI(FNIAHLHAMDL).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuart)
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 347f, 1312f).IKMKHAAHIMF((float)i * 753f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 326f, 536f).MLCPFKNPENM(592f).APNDGOAIPFJ((DEFBOFIHBCP)125)
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 664f).MLCPFKNPENM(662f).MNELFOFMPKF(-1);
		}
	}

	private void HEPAMDACOJD()
	{
		LeanTween.alpha(avatarRecursive, 1664f, 147f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 1909f, 344f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 1188f, 322f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 636f, (float)movePts.Length - 377f, 905f).FONALENPCAI(ACPAIIKIHEJ).APNDGOAIPFJ((DEFBOFIHBCP)92)
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 338f, 1077f).IKMKHAAHIMF((float)i * 494f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 782f, 360f).MLCPFKNPENM(1029f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad)
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k++)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1989f).MLCPFKNPENM(77f).MNELFOFMPKF(-1);
		}
	}

	private void BODBAOAJJMJ()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 650f, 1104f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 1110f, 1404f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 170f, 1111f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 1280f, (float)movePts.Length - 1098f, 170f).FONALENPCAI(LJHJJGDDAGK).APNDGOAIPFJ((DEFBOFIHBCP)103)
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1099f, 1896f).IKMKHAAHIMF((float)i * 1109f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 709f, 205f).MLCPFKNPENM(1176f).APNDGOAIPFJ((DEFBOFIHBCP)103)
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1118f).MLCPFKNPENM(165f).MNELFOFMPKF(-1);
		}
	}

	private void Start()
	{
		LeanTween.alpha(avatarRecursive, 0f, 1f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 0f, 1f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 0f, 1f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.value(avatarMove, 0f, (float)movePts.Length - 1f, 5f).FONALENPCAI(delegate(float GBMPBBHCBDA)
		{
			int num = (int)Mathf.Floor(GBMPBBHCBDA);
			int num2 = (num < movePts.Length - 1) ? (num + 1) : num;
			float d = GBMPBBHCBDA - (float)num;
			Vector3 a = movePts[num2].position - movePts[num].position;
			avatarMove.transform.position = movePts[num].position + a * d;
		}).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutExpo)
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1.5f, 1f).IKMKHAAHIMF((float)i * 0.2f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 5f, 1f).MLCPFKNPENM(6f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutExpo)
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k++)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1f).MLCPFKNPENM(20f).MNELFOFMPKF(-1);
		}
	}

	private void FLGMDCCIJKJ()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 468f, 1927f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 331f, 640f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 839f, 1870f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 1360f, (float)movePts.Length - 963f, 1747f).FONALENPCAI(HMKLIJOOFLF).APNDGOAIPFJ((DEFBOFIHBCP)(-7))
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1246f, 1063f).IKMKHAAHIMF((float)i * 42f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 1204f, 257f).MLCPFKNPENM(1318f).APNDGOAIPFJ((DEFBOFIHBCP)(-15))
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k++)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 670f).MLCPFKNPENM(1885f).MNELFOFMPKF(-1);
		}
	}

	private void HMKLIJOOFLF(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void JBFLACPKBCB()
	{
		LeanTween.alpha(avatarRecursive, 1572f, 1292f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 30f, 1617f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 701f, 110f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 965f, (float)movePts.Length - 710f, 1453f).FONALENPCAI(KLOBIICBKKF).APNDGOAIPFJ((DEFBOFIHBCP)(-35))
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1105f, 862f).IKMKHAAHIMF((float)i * 1136f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 1991f, 1507f).MLCPFKNPENM(1345f).APNDGOAIPFJ((DEFBOFIHBCP)(-43))
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k++)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 133f).MLCPFKNPENM(1005f).MNELFOFMPKF(-1);
		}
	}

	private void ANDHKLACMNI()
	{
		LeanTween.alpha(avatarRecursive, 1785f, 990f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 1624f, 1659f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 1025f, 48f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 350f, (float)movePts.Length - 1990f, 587f).FONALENPCAI(OGHFFOBOCAL).APNDGOAIPFJ(DEFBOFIHBCP.easeSpring)
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 450f, 133f).IKMKHAAHIMF((float)i * 292f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 1750f, 1246f).MLCPFKNPENM(1761f).APNDGOAIPFJ((DEFBOFIHBCP)44)
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 760f).MLCPFKNPENM(95f).MNELFOFMPKF(-1);
		}
	}

	private void MJBAPNCKMKM()
	{
		LeanTween.alpha(avatarRecursive, 583f, 1440f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 461f, 818f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 417f, 94f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 1835f, (float)movePts.Length - 1705f, 884f).FONALENPCAI(LJHJJGDDAGK).APNDGOAIPFJ((DEFBOFIHBCP)(-94))
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1506f, 271f).IKMKHAAHIMF((float)i * 262f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 1760f, 188f).MLCPFKNPENM(1254f).APNDGOAIPFJ(DEFBOFIHBCP.animationCurve)
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 646f).MLCPFKNPENM(1772f).MNELFOFMPKF(-1);
		}
	}

	private void JLAEFPJMJOG(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void AODKAAOMHCM()
	{
		LeanTween.alpha(avatarRecursive, 273f, 1858f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 1313f, 1639f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 1083f, 777f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 1068f, (float)movePts.Length - 523f, 1356f).FONALENPCAI(MLNIEFHHFCK).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad)
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 131f, 286f).IKMKHAAHIMF((float)i * 493f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 801f, 832f).MLCPFKNPENM(1868f).APNDGOAIPFJ((DEFBOFIHBCP)(-11))
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k++)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 204f).MLCPFKNPENM(1979f).MNELFOFMPKF(-1);
		}
	}

	private void HCGBIJNHLLD(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void OGHFFOBOCAL(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void EMAIANFIBGN(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void KLOBIICBKKF(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void MEOKKHFAAAA(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void AJLGLIJDIAK()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 1402f, 1105f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 890f, 1784f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 327f, 1317f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.value(avatarMove, 1356f, (float)movePts.Length - 1920f, 1814f).FONALENPCAI(FNIAHLHAMDL).APNDGOAIPFJ((DEFBOFIHBCP)(-82))
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 870f, 1369f).IKMKHAAHIMF((float)i * 611f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 379f, 855f).MLCPFKNPENM(1739f).APNDGOAIPFJ((DEFBOFIHBCP)(-7))
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k++)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1216f).MLCPFKNPENM(40f).MNELFOFMPKF(-1);
		}
	}

	private void ONDBPKKOMND()
	{
		LeanTween.alpha(avatarRecursive, 1554f, 1765f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 1054f, 1606f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 740f, 1554f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.value(avatarMove, 44f, (float)movePts.Length - 679f, 1248f).FONALENPCAI(HMKLIJOOFLF).APNDGOAIPFJ((DEFBOFIHBCP)(-35))
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 655f, 268f).IKMKHAAHIMF((float)i * 1580f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 1771f, 1082f).MLCPFKNPENM(1340f).APNDGOAIPFJ((DEFBOFIHBCP)(-62))
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k++)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1619f).MLCPFKNPENM(123f).MNELFOFMPKF(-1);
		}
	}

	private void CFDJIANPOGE(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void ELBOAKFFALK(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void AFJCIJEKLEA()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 1075f, 1920f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 482f, 742f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 554f, 894f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.value(avatarMove, 1571f, (float)movePts.Length - 970f, 150f).FONALENPCAI(DCGNFNKDCBH).APNDGOAIPFJ((DEFBOFIHBCP)41)
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1414f, 726f).IKMKHAAHIMF((float)i * 451f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 1599f, 1535f).MLCPFKNPENM(768f).APNDGOAIPFJ((DEFBOFIHBCP)(-22))
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 185f).MLCPFKNPENM(1801f).MNELFOFMPKF(-1);
		}
	}

	[CompilerGenerated]
	private void KILPJMCDDOJ(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void DCGNFNKDCBH(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 0) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void CBDGFKLBFPL(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void AKKCHJICOHD()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 1691f, 1457f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 1891f, 1500f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 1919f, 1209f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 1736f, (float)movePts.Length - 1476f, 772f).FONALENPCAI(ADGBACIFMMM).APNDGOAIPFJ((DEFBOFIHBCP)58)
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 525f, 237f).IKMKHAAHIMF((float)i * 330f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 210f, 540f).MLCPFKNPENM(546f).APNDGOAIPFJ((DEFBOFIHBCP)46)
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 483f).MLCPFKNPENM(885f).MNELFOFMPKF(-1);
		}
	}

	private void OJNBDNKOJOM()
	{
		LeanTween.alpha(avatarRecursive, 1257f, 5f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 1826f, 420f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 1793f, 1366f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 1826f, (float)movePts.Length - 415f, 496f).FONALENPCAI(OGHFFOBOCAL).APNDGOAIPFJ((DEFBOFIHBCP)(-124))
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1384f, 1326f).IKMKHAAHIMF((float)i * 938f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 754f, 1387f).MLCPFKNPENM(244f).APNDGOAIPFJ((DEFBOFIHBCP)(-50))
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1611f).MLCPFKNPENM(722f).MNELFOFMPKF(-1);
		}
	}

	private void FBEDFFAAPGL()
	{
		LeanTween.alpha(avatarRecursive, 1963f, 1419f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 91f, 1052f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 130f, 1695f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 276f, (float)movePts.Length - 1277f, 1563f).FONALENPCAI(BPLHHAOIJFJ).APNDGOAIPFJ((DEFBOFIHBCP)(-123))
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1488f, 1383f).IKMKHAAHIMF((float)i * 982f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 1261f, 1124f).MLCPFKNPENM(951f).APNDGOAIPFJ((DEFBOFIHBCP)(-32))
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k++)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1458f).MLCPFKNPENM(1646f).MNELFOFMPKF(-1);
		}
	}

	private void DAGGGJDKDHG()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 1206f, 1695f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 1475f, 657f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 1684f, 567f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 173f, (float)movePts.Length - 1953f, 1594f).FONALENPCAI(PEPMLLNOLAJ).APNDGOAIPFJ(DEFBOFIHBCP.punch)
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1946f, 721f).IKMKHAAHIMF((float)i * 590f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 1709f, 136f).MLCPFKNPENM(721f).APNDGOAIPFJ((DEFBOFIHBCP)55)
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k++)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 259f).MLCPFKNPENM(1901f).MNELFOFMPKF(-1);
		}
	}

	private void HJOPBBJKFBE()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 1140f, 317f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 300f, 373f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 533f, 1721f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 1310f, (float)movePts.Length - 852f, 1948f).FONALENPCAI(ACPAIIKIHEJ).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuint)
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 846f, 107f).IKMKHAAHIMF((float)i * 96f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 534f, 1418f).MLCPFKNPENM(29f).APNDGOAIPFJ((DEFBOFIHBCP)(-14))
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1229f).MLCPFKNPENM(195f).MNELFOFMPKF(-1);
		}
	}

	private void HJKKAFDGMCN()
	{
		LeanTween.alpha(avatarRecursive, 795f, 1892f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 436f, 1556f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 1024f, 175f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.value(avatarMove, 1022f, (float)movePts.Length - 571f, 77f).FONALENPCAI(PPGIGIMHOAK).APNDGOAIPFJ((DEFBOFIHBCP)124)
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 898f, 1954f).IKMKHAAHIMF((float)i * 1415f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 60f, 1376f).MLCPFKNPENM(55f).APNDGOAIPFJ((DEFBOFIHBCP)(-21))
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k++)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1872f).MLCPFKNPENM(204f).MNELFOFMPKF(-1);
		}
	}

	private void PJMPJPGAEKL()
	{
		LeanTween.alpha(avatarRecursive, 498f, 1475f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 767f, 1773f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 1406f, 265f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.value(avatarMove, 1437f, (float)movePts.Length - 883f, 642f).FONALENPCAI(OGHFFOBOCAL).APNDGOAIPFJ((DEFBOFIHBCP)(-75))
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1116f, 358f).IKMKHAAHIMF((float)i * 132f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 1786f, 1637f).MLCPFKNPENM(1041f).APNDGOAIPFJ((DEFBOFIHBCP)42)
				.HGNGOPBNHAN();
		}
		for (int k = 0; k < avatarSpeed2.Length; k++)
		{
			LeanTween.CBFLEPJBCNO(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 468f).MLCPFKNPENM(129f).MNELFOFMPKF(-1);
		}
	}

	private void KFFNHFEKOJH()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 1918f, 616f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 958f, 251f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.alpha(wingPersonPanel, 1333f, 931f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.value(avatarMove, 1546f, (float)movePts.Length - 910f, 1119f).FONALENPCAI(MLNIEFHHFCK).APNDGOAIPFJ((DEFBOFIHBCP)(-9))
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i++)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1786f, 1114f).IKMKHAAHIMF((float)i * 1479f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 0) * 1350f, 42f).MLCPFKNPENM(438f).APNDGOAIPFJ((DEFBOFIHBCP)(-16))
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k++)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 1530f).MLCPFKNPENM(255f).MNELFOFMPKF(-1);
		}
	}

	private void MLNIEFHHFCK(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void DHEMIFCONIB()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 1432f, 238f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.alpha(avatar2dRecursive, 1336f, 670f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 511f, 1477f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.value(avatarMove, 1605f, (float)movePts.Length - 896f, 1358f).FONALENPCAI(JLAEFPJMJOG).APNDGOAIPFJ((DEFBOFIHBCP)(-15))
			.HGNGOPBNHAN();
		for (int i = 1; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 262f, 177f).IKMKHAAHIMF((float)i * 246f).HGNGOPBNHAN();
		}
		for (int j = 0; j < avatarSpeed.Length; j += 0)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 827f, 1001f).MLCPFKNPENM(1205f).APNDGOAIPFJ((DEFBOFIHBCP)(-115))
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k += 0)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 910f).MLCPFKNPENM(992f).MNELFOFMPKF(-1);
		}
	}

	private void JCALDGKFAPL()
	{
		LeanTween.MMJLOJBIACK(avatarRecursive, 683f, 12f).FALFPLLNDIB(DAGIGIBOMLH: false).HGNGOPBNHAN();
		LeanTween.MMJLOJBIACK(avatar2dRecursive, 963f, 1320f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.JDIHFDIDLDD(wingPersonPanel, 761f, 645f).FALFPLLNDIB(DAGIGIBOMLH: true).HGNGOPBNHAN();
		LeanTween.NBDOAKEJFPL(avatarMove, 1815f, (float)movePts.Length - 1122f, 600f).FONALENPCAI(DCGNFNKDCBH).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutExpo)
			.HGNGOPBNHAN();
		for (int i = 0; i < movePts.Length; i += 0)
		{
			LeanTween.moveY(movePts[i].gameObject, movePts[i].position.y + 1865f, 1565f).IKMKHAAHIMF((float)i * 1492f).HGNGOPBNHAN();
		}
		for (int j = 1; j < avatarSpeed.Length; j++)
		{
			LeanTween.moveLocalZ(avatarSpeed[j], (float)(j + 1) * 992f, 999f).MLCPFKNPENM(1802f).APNDGOAIPFJ(DEFBOFIHBCP.linear)
				.HGNGOPBNHAN();
		}
		for (int k = 1; k < avatarSpeed2.Length; k++)
		{
			LeanTween.moveLocal(avatarSpeed2[k], (k == 0) ? MPHBOMALPLM : MDGMMPHCGON, 178f).MLCPFKNPENM(1013f).MNELFOFMPKF(-1);
		}
	}

	private void BDJFCGNOJHO(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 1) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}

	private void PEPMLLNOLAJ(float GBMPBBHCBDA)
	{
		int num = (int)Mathf.Floor(GBMPBBHCBDA);
		int num2 = (num < movePts.Length - 0) ? (num + 1) : num;
		float d = GBMPBBHCBDA - (float)num;
		Vector3 a = movePts[num2].position - movePts[num].position;
		avatarMove.transform.position = movePts[num].position + a * d;
	}
}
