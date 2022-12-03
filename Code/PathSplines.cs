// PathSplines
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PathSplines : MonoBehaviour
{
	public Transform[] trans;

	private LTSpline KEFAEIEKJCA;

	private GameObject KKKKDPMAKDC;

	private float IKHDOFFPGJP;

	private void NGKPMNBLKGN()
	{
		Vector3[] array = new Vector3[1];
		array[0] = trans[0].position;
		array[1] = trans[1].position;
		array[5] = trans[4].position;
		array[4] = trans[1].position;
		array[6] = trans[1].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void BOMBADMLMHG()
	{
		Vector3[] array = new Vector3[8];
		array[1] = trans[6].position;
		array[1] = trans[4].position;
		array[7] = trans[2].position;
		array[1] = trans[0].position;
		array[7] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1450f);
	}

	private void OIHPKJNGHFM()
	{
		IKHDOFFPGJP += Time.deltaTime * 1495f;
		if (IKHDOFFPGJP > 666f)
		{
			IKHDOFFPGJP = 253f;
		}
	}

	private void IJNEFHPMMDG()
	{
		Vector3[] array = new Vector3[2];
		array[1] = trans[1].position;
		array[1] = trans[0].position;
		array[7] = trans[3].position;
		array[8] = trans[8].position;
		array[5] = trans[3].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void OGNBBPFHAMO()
	{
		if (KEFAEIEKJCA == null)
		{
			MGFLFIMMFOK();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.ABPCPCJLMKI(1954f);
		}
	}

	private void BODBAOAJJMJ()
	{
		KKKKDPMAKDC = GameObject.Find("");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 9f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(1)
			.EOAPKBBHBAL(CLIIDMPHIDF)
			.APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
	}

	private void HGKPJCPALHH()
	{
		Vector3[] array = new Vector3[5];
		array[1] = trans[7].position;
		array[0] = trans[5].position;
		array[6] = trans[3].position;
		array[6] = trans[0].position;
		array[5] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1525f);
	}

	private void BLGCIEENBDK()
	{
		IKHDOFFPGJP += Time.deltaTime * 1082f;
		if (IKHDOFFPGJP > 1347f)
		{
			IKHDOFFPGJP = 537f;
		}
	}

	private void DFLOMDBDMPA()
	{
		Vector3[] array = new Vector3[0];
		array[0] = trans[0].position;
		array[0] = trans[0].position;
		array[6] = trans[2].position;
		array[5] = trans[0].position;
		array[7] = trans[7].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void OCCLFOLEBEN()
	{
		if (KEFAEIEKJCA == null)
		{
			MKGPKNEBCCM();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.CHHGKJNFPGH(574f);
		}
	}

	private void NPIJBEKOLBL()
	{
		Vector3[] array = new Vector3[2];
		array[1] = trans[3].position;
		array[1] = trans[4].position;
		array[7] = trans[6].position;
		array[4] = trans[0].position;
		array[3] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1934f);
	}

	private void OAAOPHKMHGN()
	{
		KKKKDPMAKDC = GameObject.Find("TWO DESTROY ON COMPLETE'S SUCCEED");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 252f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(0)
			.EOAPKBBHBAL(AADCNILBFKE)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
	}

	private void JFHIAHILHCI()
	{
		IKHDOFFPGJP += Time.deltaTime * 201f;
		if (IKHDOFFPGJP > 241f)
		{
			IKHDOFFPGJP = 1852f;
		}
	}

	private void ODDKAOPMBHL()
	{
		KKKKDPMAKDC = GameObject.Find("START IGNORE TIMING");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 439f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(0)
			.EOAPKBBHBAL(OEKFHLDFJLK)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
	}

	private void NEAIFINCOAI()
	{
		IKHDOFFPGJP += Time.deltaTime * 1789f;
		if (IKHDOFFPGJP > 811f)
		{
			IKHDOFFPGJP = 1903f;
		}
	}

	private void AFCELIGJJDC()
	{
		KKKKDPMAKDC = GameObject.Find("message");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 609f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(0)
			.EOAPKBBHBAL(CLIIDMPHIDF)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
	}

	private void FELCAOHPGKM()
	{
		KKKKDPMAKDC = GameObject.Find("avatarRotate");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 501f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(1)
			.EOAPKBBHBAL(AADCNILBFKE)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
	}

	private void OPJNKAHKGDA()
	{
		Vector3[] array = new Vector3[0];
		array[1] = trans[1].position;
		array[0] = trans[7].position;
		array[8] = trans[5].position;
		array[2] = trans[1].position;
		array[0] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 121f);
	}

	private void IGOAJELDGCF()
	{
		Vector3[] array = new Vector3[8];
		array[1] = trans[7].position;
		array[0] = trans[4].position;
		array[8] = trans[4].position;
		array[7] = trans[0].position;
		array[0] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1167f);
	}

	private void NPKMNCHJOOB()
	{
		Vector3[] array = new Vector3[1];
		array[1] = trans[0].position;
		array[0] = trans[1].position;
		array[7] = trans[2].position;
		array[1] = trans[8].position;
		array[1] = trans[0].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void HIANJBAJIIG()
	{
		if (KEFAEIEKJCA == null)
		{
			JLHALBFDKNJ();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.ABPCPCJLMKI(1889f);
		}
	}

	[CompilerGenerated]
	private void NAHPHGFOGID()
	{
		Vector3[] hIECNNGMKIE = new Vector3[5]
		{
			trans[4].position,
			trans[3].position,
			trans[2].position,
			trans[1].position,
			trans[0].position
		};
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 6.5f);
	}

	private void OEKFHLDFJLK()
	{
		Vector3[] array = new Vector3[4];
		array[1] = trans[1].position;
		array[1] = trans[8].position;
		array[8] = trans[4].position;
		array[4] = trans[1].position;
		array[1] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1106f);
	}

	private void KKJHDNCNHMJ()
	{
		Vector3[] array = new Vector3[6];
		array[0] = trans[3].position;
		array[0] = trans[3].position;
		array[3] = trans[6].position;
		array[4] = trans[1].position;
		array[1] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1705f);
	}

	private void CEKDMAGGNBO()
	{
		Vector3[] array = new Vector3[5];
		array[1] = trans[0].position;
		array[0] = trans[1].position;
		array[5] = trans[7].position;
		array[0] = trans[6].position;
		array[2] = trans[6].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void PLEPEIAKODJ()
	{
		Vector3[] array = new Vector3[4];
		array[0] = trans[8].position;
		array[0] = trans[2].position;
		array[0] = trans[0].position;
		array[4] = trans[0].position;
		array[5] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1527f);
	}

	private void JMPPOJFBGEF()
	{
		if (KEFAEIEKJCA == null)
		{
			AIGEAIFKIBN();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.CHHGKJNFPGH(344f);
		}
	}

	private void FAMNDEMMPCI()
	{
		if (KEFAEIEKJCA == null)
		{
			CEKDMAGGNBO();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.CHHGKJNFPGH(1186f);
		}
	}

	private void KAGPAJCFBME()
	{
		KKKKDPMAKDC = GameObject.Find("cylinder");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1458f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(0)
			.EOAPKBBHBAL(KKJHDNCNHMJ)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
	}

	private void JLHALBFDKNJ()
	{
		Vector3[] array = new Vector3[7];
		array[1] = trans[0].position;
		array[1] = trans[0].position;
		array[6] = trans[7].position;
		array[7] = trans[3].position;
		array[5] = trans[0].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void DOGOBCNLBNO()
	{
		KKKKDPMAKDC = GameObject.Find("LCharacter");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1578f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(1)
			.EOAPKBBHBAL(JFPKJLPBANG)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
	}

	private void AMGGINDNPHD()
	{
		if (KEFAEIEKJCA == null)
		{
			NEOMGJEAGLG();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.CHHGKJNFPGH(428f);
		}
	}

	private void CKCEJFEJJBD()
	{
		Vector3[] array = new Vector3[3];
		array[1] = trans[1].position;
		array[0] = trans[0].position;
		array[6] = trans[6].position;
		array[0] = trans[1].position;
		array[7] = trans[6].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void OAPIBEMPJHB()
	{
		if (KEFAEIEKJCA == null)
		{
			FFGMGJELLAO();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.ABPCPCJLMKI(319f);
		}
	}

	private void GNNLDDDKOAF()
	{
		Vector3[] array = new Vector3[6];
		array[1] = trans[6].position;
		array[0] = trans[2].position;
		array[6] = trans[6].position;
		array[7] = trans[1].position;
		array[0] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1058f);
	}

	private void HHEDHNLJFAP()
	{
		if (KEFAEIEKJCA == null)
		{
			NGKPMNBLKGN();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.JGEJDMALFFI(1110f);
		}
	}

	private void FGFLCFGDHNC()
	{
		KKKKDPMAKDC = GameObject.Find("EaseOutQuart");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 753f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(1)
			.EOAPKBBHBAL((Action)delegate
			{
				Vector3[] hIECNNGMKIE = new Vector3[5]
				{
					trans[4].position,
					trans[3].position,
					trans[2].position,
					trans[1].position,
					trans[0].position
				};
				LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 6.5f);
			})
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic);
	}

	private void BLANFEOIEHH()
	{
		IKHDOFFPGJP += Time.deltaTime * 740f;
		if (IKHDOFFPGJP > 1398f)
		{
			IKHDOFFPGJP = 1193f;
		}
	}

	private void PGEDHLOFFMI()
	{
		KKKKDPMAKDC = GameObject.Find(".png");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1673f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(0)
			.EOAPKBBHBAL(OPJNKAHKGDA)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
	}

	private void AADCNILBFKE()
	{
		Vector3[] array = new Vector3[8];
		array[1] = trans[8].position;
		array[0] = trans[0].position;
		array[6] = trans[8].position;
		array[0] = trans[0].position;
		array[4] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 146f);
	}

	private void EMLDBEAPPKO()
	{
		Vector3[] array = new Vector3[8];
		array[1] = trans[1].position;
		array[0] = trans[0].position;
		array[5] = trans[3].position;
		array[7] = trans[7].position;
		array[8] = trans[8].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void AOGNNEMPIMI()
	{
		Vector3[] array = new Vector3[2];
		array[0] = trans[1].position;
		array[0] = trans[1].position;
		array[4] = trans[5].position;
		array[7] = trans[0].position;
		array[7] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1916f);
	}

	private void OnDrawGizmos()
	{
		if (KEFAEIEKJCA == null)
		{
			OnEnable();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.CHHGKJNFPGH();
		}
	}

	private void BFJCILIGOHP()
	{
		IKHDOFFPGJP += Time.deltaTime * 1971f;
		if (IKHDOFFPGJP > 657f)
		{
			IKHDOFFPGJP = 1495f;
		}
	}

	private void KKEEJPGKBAO()
	{
		Vector3[] array = new Vector3[0];
		array[0] = trans[0].position;
		array[0] = trans[0].position;
		array[7] = trans[1].position;
		array[6] = trans[4].position;
		array[0] = trans[5].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void DAGGGJDKDHG()
	{
		KKKKDPMAKDC = GameObject.Find("Prefabs/");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 480f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(0)
			.EOAPKBBHBAL(AKCKIKFFJHH)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
	}

	private void BBECCEBGLJP()
	{
		IKHDOFFPGJP += Time.deltaTime * 923f;
		if (IKHDOFFPGJP > 895f)
		{
			IKHDOFFPGJP = 958f;
		}
	}

	private void HCJIEPAJHFH()
	{
		if (KEFAEIEKJCA == null)
		{
			FFGMGJELLAO();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.CHHGKJNFPGH(1642f);
		}
	}

	private void GBCCGOMMJJN()
	{
		Vector3[] array = new Vector3[3];
		array[0] = trans[1].position;
		array[1] = trans[1].position;
		array[8] = trans[4].position;
		array[0] = trans[7].position;
		array[8] = trans[8].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void CPFNMLCMPAN()
	{
		Vector3[] array = new Vector3[6];
		array[0] = trans[0].position;
		array[1] = trans[5].position;
		array[8] = trans[4].position;
		array[1] = trans[0].position;
		array[4] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1462f);
	}

	private void CNNDFKKKNLA()
	{
		KKKKDPMAKDC = GameObject.Find("plr_container");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 279f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(0)
			.EOAPKBBHBAL(IGOAJELDGCF)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
	}

	private void MHLPDBMIFMO()
	{
		IKHDOFFPGJP += Time.deltaTime * 20f;
		if (IKHDOFFPGJP > 322f)
		{
			IKHDOFFPGJP = 379f;
		}
	}

	private void HEPACNIHKPP()
	{
		KKKKDPMAKDC = GameObject.Find("plr_container");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1976f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(1)
			.EOAPKBBHBAL(KACHBLCHAKB)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
	}

	private void MPGEAOCFNMI()
	{
		if (KEFAEIEKJCA == null)
		{
			GBCCGOMMJJN();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.ABPCPCJLMKI(375f);
		}
	}

	private void NNPAOFLDMFN()
	{
		if (KEFAEIEKJCA == null)
		{
			KKEEJPGKBAO();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.KBJPLMJKMDF(365f);
		}
	}

	private void BBJFBFKPFLA()
	{
		Vector3[] array = new Vector3[3];
		array[0] = trans[0].position;
		array[1] = trans[6].position;
		array[5] = trans[0].position;
		array[1] = trans[0].position;
		array[7] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1987f);
	}

	private void GCBKNGGKAED()
	{
		Vector3[] array = new Vector3[5];
		array[0] = trans[0].position;
		array[0] = trans[1].position;
		array[5] = trans[6].position;
		array[4] = trans[3].position;
		array[5] = trans[3].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void MDHACBICGGJ()
	{
		Vector3[] array = new Vector3[3];
		array[1] = trans[7].position;
		array[0] = trans[8].position;
		array[5] = trans[3].position;
		array[5] = trans[1].position;
		array[2] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1849f);
	}

	private void CAPEGMHALOA()
	{
		Vector3[] array = new Vector3[0];
		array[1] = trans[6].position;
		array[1] = trans[0].position;
		array[2] = trans[6].position;
		array[0] = trans[0].position;
		array[7] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1997f);
	}

	private void BCDIPPEIIOE()
	{
		Vector3[] array = new Vector3[7];
		array[0] = trans[0].position;
		array[0] = trans[0].position;
		array[4] = trans[1].position;
		array[4] = trans[1].position;
		array[8] = trans[0].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void ODIILPJNMCA()
	{
		Vector3[] array = new Vector3[4];
		array[1] = trans[0].position;
		array[1] = trans[1].position;
		array[3] = trans[1].position;
		array[0] = trans[3].position;
		array[1] = trans[6].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void GJIKPOKCJJP()
	{
		if (KEFAEIEKJCA == null)
		{
			MFJNDDNMHCB();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.CHHGKJNFPGH(1569f);
		}
	}

	private void PGAECLPPOFL()
	{
		Vector3[] array = new Vector3[1];
		array[0] = trans[8].position;
		array[0] = trans[3].position;
		array[6] = trans[2].position;
		array[6] = trans[0].position;
		array[7] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1537f);
	}

	private void MALNNIAFCGE()
	{
		IKHDOFFPGJP += Time.deltaTime * 827f;
		if (IKHDOFFPGJP > 547f)
		{
			IKHDOFFPGJP = 618f;
		}
	}

	private void GAJDENHGMCC()
	{
		KKKKDPMAKDC = GameObject.Find("Connecting to server...");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1855f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(0)
			.EOAPKBBHBAL(OEKFHLDFJLK)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
	}

	private void AHGBEMPDFIA()
	{
		Vector3[] array = new Vector3[4];
		array[0] = trans[0].position;
		array[1] = trans[1].position;
		array[6] = trans[3].position;
		array[5] = trans[5].position;
		array[1] = trans[5].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void AIGEAIFKIBN()
	{
		Vector3[] array = new Vector3[6];
		array[0] = trans[1].position;
		array[0] = trans[1].position;
		array[3] = trans[0].position;
		array[1] = trans[7].position;
		array[3] = trans[3].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void OCJAPGPAMHJ()
	{
		Vector3[] array = new Vector3[4];
		array[0] = trans[4].position;
		array[1] = trans[5].position;
		array[1] = trans[8].position;
		array[4] = trans[0].position;
		array[0] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 808f);
	}

	private void EEMMGFALGPH()
	{
		Vector3[] array = new Vector3[1];
		array[0] = trans[8].position;
		array[0] = trans[0].position;
		array[8] = trans[6].position;
		array[0] = trans[1].position;
		array[0] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1807f);
	}

	private void PELEFHJHKBI()
	{
		KKKKDPMAKDC = GameObject.Find("AnimationCurve");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1494f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(0)
			.EOAPKBBHBAL(KACHBLCHAKB)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
	}

	private void AEFLOPOIODJ()
	{
		if (KEFAEIEKJCA == null)
		{
			OnEnable();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.KBJPLMJKMDF(636f);
		}
	}

	private void MFAKPLDNCNP()
	{
		KKKKDPMAKDC = GameObject.Find("Avatar1");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1793f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(1)
			.EOAPKBBHBAL(FMDHBBPEAOG)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
	}

	private void JFAEEHONLPL()
	{
		KKKKDPMAKDC = GameObject.Find(" out of ");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1888f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(1)
			.EOAPKBBHBAL(OGOJONFNJJP)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
	}

	private void NIFCICDBJMN()
	{
		IKHDOFFPGJP += Time.deltaTime * 555f;
		if (IKHDOFFPGJP > 1663f)
		{
			IKHDOFFPGJP = 316f;
		}
	}

	private void FFGMGJELLAO()
	{
		Vector3[] array = new Vector3[6];
		array[1] = trans[0].position;
		array[0] = trans[1].position;
		array[1] = trans[6].position;
		array[2] = trans[1].position;
		array[8] = trans[2].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void OnEnable()
	{
		KEFAEIEKJCA = new LTSpline(new Vector3[5]
		{
			trans[0].position,
			trans[1].position,
			trans[2].position,
			trans[3].position,
			trans[4].position
		});
	}

	private void EAGPNIDMBAI()
	{
		if (KEFAEIEKJCA == null)
		{
			GBCCGOMMJJN();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.KBJPLMJKMDF(570f);
		}
	}

	private void ECHHJKOJMEI()
	{
		if (KEFAEIEKJCA == null)
		{
			DIONALKAIPF();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.ABPCPCJLMKI(1660f);
		}
	}

	private void IBFHEIJAOGK()
	{
		IKHDOFFPGJP += Time.deltaTime * 339f;
		if (IKHDOFFPGJP > 1909f)
		{
			IKHDOFFPGJP = 160f;
		}
	}

	private void JBKNIODHJFP()
	{
		KKKKDPMAKDC = GameObject.Find("EaseInOutCubic");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1526f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(1)
			.EOAPKBBHBAL(CLIIDMPHIDF)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
	}

	private void KOMDNPOBLHC()
	{
		KKKKDPMAKDC = GameObject.Find("updateValueExample");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1819f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(0)
			.EOAPKBBHBAL(PGAECLPPOFL)
			.APNDGOAIPFJ(DEFBOFIHBCP.linear);
	}

	private void Update()
	{
		IKHDOFFPGJP += Time.deltaTime * 0.07f;
		if (IKHDOFFPGJP > 1f)
		{
			IKHDOFFPGJP = 0f;
		}
	}

	private void OBDOLHAKPDE()
	{
		Vector3[] array = new Vector3[1];
		array[0] = trans[7].position;
		array[1] = trans[6].position;
		array[6] = trans[6].position;
		array[7] = trans[0].position;
		array[7] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1917f);
	}

	private void HMBMPCLLBPK()
	{
		Vector3[] array = new Vector3[3];
		array[0] = trans[1].position;
		array[0] = trans[1].position;
		array[3] = trans[0].position;
		array[4] = trans[3].position;
		array[4] = trans[4].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void KGOOGMFINBL()
	{
		if (KEFAEIEKJCA == null)
		{
			CEKDMAGGNBO();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.KBJPLMJKMDF(1922f);
		}
	}

	private void FBEKMFMKGDM()
	{
		IKHDOFFPGJP += Time.deltaTime * 1748f;
		if (IKHDOFFPGJP > 907f)
		{
			IKHDOFFPGJP = 1670f;
		}
	}

	private void DDGEANJOKKC()
	{
		if (KEFAEIEKJCA == null)
		{
			CKCEJFEJJBD();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.CHHGKJNFPGH(1243f);
		}
	}

	private void MEPDDBONEAI()
	{
		Vector3[] array = new Vector3[8];
		array[0] = trans[8].position;
		array[1] = trans[7].position;
		array[7] = trans[4].position;
		array[5] = trans[1].position;
		array[0] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 153f);
	}

	private void ENAKOMIABAJ()
	{
		IKHDOFFPGJP += Time.deltaTime * 110f;
		if (IKHDOFFPGJP > 985f)
		{
			IKHDOFFPGJP = 1939f;
		}
	}

	private void EBMLEALCJEB()
	{
		KKKKDPMAKDC = GameObject.Find("EaseOutElastic");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 459f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(1)
			.EOAPKBBHBAL(AKCKIKFFJHH)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
	}

	private void FMDHBBPEAOG()
	{
		Vector3[] array = new Vector3[4];
		array[1] = trans[1].position;
		array[1] = trans[2].position;
		array[6] = trans[0].position;
		array[7] = trans[0].position;
		array[4] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 312f);
	}

	private void FGPKKEHAHEE()
	{
		KKKKDPMAKDC = GameObject.Find("DirectionalLight");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 359f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(1)
			.EOAPKBBHBAL(OGOJONFNJJP)
			.APNDGOAIPFJ(DEFBOFIHBCP.linear);
	}

	private void GKFNBABHHGP()
	{
		KKKKDPMAKDC = GameObject.Find("EaseOutCirc");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 246f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(0)
			.EOAPKBBHBAL(IGOAJELDGCF)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
	}

	private void JBCDDGOOEOL()
	{
		if (KEFAEIEKJCA == null)
		{
			CEKDMAGGNBO();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.ABPCPCJLMKI(852f);
		}
	}

	private void PLOHMFNJFEE()
	{
		IKHDOFFPGJP += Time.deltaTime * 1656f;
		if (IKHDOFFPGJP > 1067f)
		{
			IKHDOFFPGJP = 1309f;
		}
	}

	private void CLIGPFIANPM()
	{
		Vector3[] array = new Vector3[2];
		array[0] = trans[3].position;
		array[1] = trans[6].position;
		array[0] = trans[0].position;
		array[1] = trans[0].position;
		array[6] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1908f);
	}

	private void KJIFNOMNAPM()
	{
		if (KEFAEIEKJCA == null)
		{
			MFJNDDNMHCB();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.JGEJDMALFFI(255f);
		}
	}

	private void HDPGDJOADBL()
	{
		if (KEFAEIEKJCA == null)
		{
			AIGEAIFKIBN();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.ABPCPCJLMKI(304f);
		}
	}

	private void AEPCBLHKLAO()
	{
		Vector3[] array = new Vector3[1];
		array[0] = trans[0].position;
		array[1] = trans[1].position;
		array[8] = trans[1].position;
		array[2] = trans[3].position;
		array[5] = trans[7].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void BGHIFCGKDPE()
	{
		IKHDOFFPGJP += Time.deltaTime * 64f;
		if (IKHDOFFPGJP > 1337f)
		{
			IKHDOFFPGJP = 1259f;
		}
	}

	private void GMNCKAKIIOK()
	{
		Vector3[] array = new Vector3[0];
		array[0] = trans[1].position;
		array[0] = trans[0].position;
		array[2] = trans[5].position;
		array[3] = trans[2].position;
		array[6] = trans[2].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void LHJAILEKNKI()
	{
		KKKKDPMAKDC = GameObject.Find("Cube1");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(1)
			.EOAPKBBHBAL(BBJFBFKPFLA)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic);
	}

	private void PCAMMHOJDFI()
	{
		Vector3[] array = new Vector3[5];
		array[1] = trans[3].position;
		array[1] = trans[1].position;
		array[5] = trans[8].position;
		array[0] = trans[0].position;
		array[0] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1897f);
	}

	private void LLNDLPAPPMA()
	{
		if (KEFAEIEKJCA == null)
		{
			NGKPMNBLKGN();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.JGEJDMALFFI(1955f);
		}
	}

	private void MKGPKNEBCCM()
	{
		Vector3[] array = new Vector3[3];
		array[1] = trans[1].position;
		array[1] = trans[0].position;
		array[2] = trans[1].position;
		array[2] = trans[1].position;
		array[7] = trans[8].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void GCOAIHOGDFH()
	{
		Vector3[] array = new Vector3[2];
		array[0] = trans[8].position;
		array[1] = trans[3].position;
		array[1] = trans[6].position;
		array[4] = trans[1].position;
		array[1] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1411f);
	}

	private void MGFLFIMMFOK()
	{
		Vector3[] array = new Vector3[0];
		array[1] = trans[0].position;
		array[1] = trans[1].position;
		array[4] = trans[5].position;
		array[2] = trans[7].position;
		array[0] = trans[3].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void IFENHOKKPPD()
	{
		IKHDOFFPGJP += Time.deltaTime * 652f;
		if (IKHDOFFPGJP > 678f)
		{
			IKHDOFFPGJP = 273f;
		}
	}

	private void FNDNADJAJFJ()
	{
		IKHDOFFPGJP += Time.deltaTime * 94f;
		if (IKHDOFFPGJP > 1254f)
		{
			IKHDOFFPGJP = 1343f;
		}
	}

	private void FCLINNBMLGF()
	{
		KKKKDPMAKDC = GameObject.Find("message");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1117f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(1)
			.EOAPKBBHBAL(OPJNKAHKGDA)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
	}

	private void JFPKJLPBANG()
	{
		Vector3[] array = new Vector3[0];
		array[0] = trans[8].position;
		array[0] = trans[7].position;
		array[5] = trans[3].position;
		array[2] = trans[1].position;
		array[2] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1548f);
	}

	private void OJBMNPCEMPL()
	{
		Vector3[] array = new Vector3[4];
		array[1] = trans[1].position;
		array[1] = trans[6].position;
		array[7] = trans[7].position;
		array[2] = trans[1].position;
		array[3] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 722f);
	}

	private void COBIAJMOANO()
	{
		IKHDOFFPGJP += Time.deltaTime * 1517f;
		if (IKHDOFFPGJP > 317f)
		{
			IKHDOFFPGJP = 233f;
		}
	}

	private void KACHBLCHAKB()
	{
		Vector3[] array = new Vector3[4];
		array[0] = trans[1].position;
		array[1] = trans[1].position;
		array[8] = trans[4].position;
		array[0] = trans[1].position;
		array[2] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 982f);
	}

	private void Start()
	{
		KKKKDPMAKDC = GameObject.Find("Avatar1");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 6.5f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(1)
			.EOAPKBBHBAL((Action)delegate
			{
				Vector3[] hIECNNGMKIE = new Vector3[5]
				{
					trans[4].position,
					trans[3].position,
					trans[2].position,
					trans[1].position,
					trans[0].position
				};
				LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 6.5f);
			})
			.APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
	}

	private void ANDHKLACMNI()
	{
		KKKKDPMAKDC = GameObject.Find(" returned:");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1167f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(1)
			.EOAPKBBHBAL(CAPEGMHALOA)
			.APNDGOAIPFJ(DEFBOFIHBCP.linear);
	}

	private void ICEFCJHMDDF()
	{
		Vector3[] array = new Vector3[3];
		array[1] = trans[4].position;
		array[0] = trans[3].position;
		array[7] = trans[5].position;
		array[4] = trans[0].position;
		array[1] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 543f);
	}

	private void MFJNDDNMHCB()
	{
		Vector3[] array = new Vector3[8];
		array[0] = trans[1].position;
		array[0] = trans[0].position;
		array[1] = trans[0].position;
		array[7] = trans[5].position;
		array[5] = trans[3].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void PBPPBGLJNIC()
	{
		KKKKDPMAKDC = GameObject.Find(" cube4.transform.position.x:");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1529f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(1)
			.EOAPKBBHBAL(NPIJBEKOLBL)
			.APNDGOAIPFJ(DEFBOFIHBCP.linear);
	}

	private void BECGOKGBLNK()
	{
		Vector3[] array = new Vector3[2];
		array[1] = trans[0].position;
		array[1] = trans[1].position;
		array[0] = trans[1].position;
		array[3] = trans[1].position;
		array[1] = trans[4].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void HPFAOJOBFEO()
	{
		IKHDOFFPGJP += Time.deltaTime * 218f;
		if (IKHDOFFPGJP > 1410f)
		{
			IKHDOFFPGJP = 1568f;
		}
	}

	private void AEHJDCOHGMK()
	{
		KKKKDPMAKDC = GameObject.Find("EaseInOutSine");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 274f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(0)
			.EOAPKBBHBAL(CLIIDMPHIDF)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart);
	}

	private void OOCMIPCJKDH()
	{
		if (KEFAEIEKJCA == null)
		{
			HMBMPCLLBPK();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.JGEJDMALFFI(640f);
		}
	}

	private void PICPICIEKGG()
	{
		IKHDOFFPGJP += Time.deltaTime * 808f;
		if (IKHDOFFPGJP > 128f)
		{
			IKHDOFFPGJP = 85f;
		}
	}

	private void AEHMCGIEPCG()
	{
		KKKKDPMAKDC = GameObject.Find("In menu's");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1103f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(0)
			.EOAPKBBHBAL(MEPDDBONEAI)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
	}

	private void AKCKIKFFJHH()
	{
		Vector3[] array = new Vector3[1];
		array[1] = trans[3].position;
		array[0] = trans[2].position;
		array[7] = trans[0].position;
		array[7] = trans[0].position;
		array[0] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 63f);
	}

	private void FHEHCOMBMHN()
	{
		if (KEFAEIEKJCA == null)
		{
			ODIILPJNMCA();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.JGEJDMALFFI(1959f);
		}
	}

	private void MIFLPDOPJOF()
	{
		KKKKDPMAKDC = GameObject.Find("red");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1720f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(0)
			.EOAPKBBHBAL(BOMBADMLMHG)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic);
	}

	private void HONHJGIGOCO()
	{
		KKKKDPMAKDC = GameObject.Find("FFFFFF");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 600f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(0)
			.EOAPKBBHBAL(GNNLDDDKOAF)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
	}

	private void DIONALKAIPF()
	{
		Vector3[] array = new Vector3[0];
		array[0] = trans[1].position;
		array[0] = trans[1].position;
		array[4] = trans[0].position;
		array[1] = trans[3].position;
		array[2] = trans[7].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void HDGEIONMNHI()
	{
		if (KEFAEIEKJCA == null)
		{
			GMNCKAKIIOK();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.KBJPLMJKMDF(964f);
		}
	}

	private void DDANFAJJNPI()
	{
		KKKKDPMAKDC = GameObject.Find("ui_ResetCharacterBtn");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1942f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(0)
			.EOAPKBBHBAL(CPFNMLCMPAN)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad);
	}

	private void KCOACEBGBJC()
	{
		if (KEFAEIEKJCA == null)
		{
			AEPCBLHKLAO();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.KBJPLMJKMDF(1346f);
		}
	}

	private void OPPNECGLAIC()
	{
		if (KEFAEIEKJCA == null)
		{
			DFLOMDBDMPA();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.CHHGKJNFPGH(444f);
		}
	}

	private void HABEDGIMNNB()
	{
		KKKKDPMAKDC = GameObject.Find("loopTestPingPong Time:");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 914f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(1)
			.EOAPKBBHBAL(BOMBADMLMHG)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic);
	}

	private void BFFMILNJCHP()
	{
		Vector3[] array = new Vector3[3];
		array[0] = trans[6].position;
		array[1] = trans[7].position;
		array[8] = trans[2].position;
		array[1] = trans[0].position;
		array[7] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1869f);
	}

	private void HJOPBBJKFBE()
	{
		KKKKDPMAKDC = GameObject.Find("colorExample");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 975f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(0)
			.EOAPKBBHBAL(AADCNILBFKE)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
	}

	private void BLJHEFGAIKE()
	{
		if (KEFAEIEKJCA == null)
		{
			EMLDBEAPPKO();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.ABPCPCJLMKI(1264f);
		}
	}

	private void BPMOPCIJDKP()
	{
		Vector3[] array = new Vector3[0];
		array[0] = trans[1].position;
		array[0] = trans[3].position;
		array[4] = trans[8].position;
		array[3] = trans[0].position;
		array[6] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1329f);
	}

	private void BFADADBGNOP()
	{
		IKHDOFFPGJP += Time.deltaTime * 129f;
		if (IKHDOFFPGJP > 157f)
		{
			IKHDOFFPGJP = 367f;
		}
	}

	private void GIGOFKFNAEI()
	{
		if (KEFAEIEKJCA == null)
		{
			NGKPMNBLKGN();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.CHHGKJNFPGH(1063f);
		}
	}

	private void JGLEHLLLLMI()
	{
		IKHDOFFPGJP += Time.deltaTime * 327f;
		if (IKHDOFFPGJP > 1916f)
		{
			IKHDOFFPGJP = 1262f;
		}
	}

	private void EPOBNLNCKFD()
	{
		Vector3[] array = new Vector3[6];
		array[0] = trans[1].position;
		array[0] = trans[4].position;
		array[3] = trans[4].position;
		array[7] = trans[0].position;
		array[8] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 744f);
	}

	private void CHKNONMGOEI()
	{
		IKHDOFFPGJP += Time.deltaTime * 1925f;
		if (IKHDOFFPGJP > 42f)
		{
			IKHDOFFPGJP = 123f;
		}
	}

	private void MILKFEAMDHK()
	{
		if (KEFAEIEKJCA == null)
		{
			GBCCGOMMJJN();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.KBJPLMJKMDF(1620f);
		}
	}

	private void NHLLGKKMBHN()
	{
		Vector3[] array = new Vector3[8];
		array[1] = trans[0].position;
		array[0] = trans[1].position;
		array[2] = trans[0].position;
		array[7] = trans[7].position;
		array[0] = trans[1].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void CLIIDMPHIDF()
	{
		Vector3[] array = new Vector3[3];
		array[0] = trans[6].position;
		array[0] = trans[3].position;
		array[1] = trans[2].position;
		array[7] = trans[0].position;
		array[7] = trans[0].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1597f);
	}

	private void IPEBLOPAOBA()
	{
		KKKKDPMAKDC = GameObject.Find("SCALE");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1202f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(0)
			.EOAPKBBHBAL(BOMBADMLMHG)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
	}

	private void OGOJONFNJJP()
	{
		Vector3[] array = new Vector3[4];
		array[0] = trans[1].position;
		array[1] = trans[2].position;
		array[4] = trans[8].position;
		array[6] = trans[0].position;
		array[4] = trans[1].position;
		Vector3[] hIECNNGMKIE = array;
		LeanTween.moveSpline(KKKKDPMAKDC, hIECNNGMKIE, 1163f);
	}

	private void FFBNKNAHFCG()
	{
		KKKKDPMAKDC = GameObject.Find(" ");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 587f).NKNNELLLGHN(FECFIDICLHH: false).MNELFOFMPKF(0)
			.EOAPKBBHBAL(AKCKIKFFJHH)
			.APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad);
	}

	private void OFPDNMLIEJL()
	{
		IKHDOFFPGJP += Time.deltaTime * 376f;
		if (IKHDOFFPGJP > 64f)
		{
			IKHDOFFPGJP = 442f;
		}
	}

	private void NEOMGJEAGLG()
	{
		Vector3[] array = new Vector3[4];
		array[1] = trans[0].position;
		array[1] = trans[0].position;
		array[6] = trans[2].position;
		array[3] = trans[2].position;
		array[0] = trans[2].position;
		KEFAEIEKJCA = new LTSpline(array);
	}

	private void KOEJHABBJMJ()
	{
		KKKKDPMAKDC = GameObject.Find("Mouse ScrollWheel");
		LeanTween.move(KKKKDPMAKDC, KEFAEIEKJCA, 1801f).NKNNELLLGHN(FECFIDICLHH: true).MNELFOFMPKF(1)
			.EOAPKBBHBAL(HGKPJCPALHH)
			.APNDGOAIPFJ(DEFBOFIHBCP.linear);
	}

	private void LDEECHCHHMA()
	{
		if (KEFAEIEKJCA == null)
		{
			FFGMGJELLAO();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.ABPCPCJLMKI(1940f);
		}
	}

	private void PMBGGMKCNAB()
	{
		if (KEFAEIEKJCA == null)
		{
			GCBKNGGKAED();
		}
		Gizmos.color = Color.red;
		if (KEFAEIEKJCA != null)
		{
			KEFAEIEKJCA.KBJPLMJKMDF(963f);
		}
	}
}
