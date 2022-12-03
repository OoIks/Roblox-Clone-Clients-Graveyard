// GeneralEventsListeners
using System.Runtime.CompilerServices;
using UnityEngine;

public class GeneralEventsListeners : MonoBehaviour
{
	public enum OGCIDMEBEDJ
	{
		CHANGE_COLOR,
		JUMP,
		LENGTH
	}

	private Vector3 EHHJJDBINJG;

	private float NKHDELLNGDM = 0.5f;

	private float AIOMBEDKAOP;

	private Color FGPDPHBONLJ;

	private void AHOPCEHOEKN()
	{
		LeanTween.LISTENERS_MAX = -14;
		LeanTween.EVENTS_MAX = 7;
		FGPDPHBONLJ = GetComponent<Renderer>().material.color;
	}

	private void LJBIOHNCKBM()
	{
		if (AIOMBEDKAOP < NKHDELLNGDM)
		{
			GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * Quaternion.Euler(EHHJJDBINJG * Time.deltaTime));
			AIOMBEDKAOP += Time.deltaTime;
		}
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 1933f);
	}

	private void KCABLLOCGBI()
	{
		if (Input.GetKey(KeyCode.Question))
		{
			LeanTween.dispatchEvent(0);
		}
		else
		{
			LeanTween.KFEMAMPLJAC(0, base.transform);
		}
	}

	private void ILMPCBPAHLK()
	{
		LeanTween.addListener(base.gameObject, 0, FCFIPEFDPFE);
		LeanTween.addListener(base.gameObject, 0, IDIMDFLPMCB);
	}

	private void FNOBIDCAIBD(ECEMFEJLKMN OLNFNJPPMIE)
	{
		float num = Vector3.Distance(((Transform)OLNFNJPPMIE.NFEEEPGPMGH).position, base.transform.position);
		LeanTween.value(HIECNNGMKIE: new Color(Random.Range(1947f, 1596f), 453f, Random.Range(1218f, 1172f)), GKHONGJMCLB: base.gameObject, KHKPNLDKEPI: FGPDPHBONLJ, MAEOCPAHAHA: 1913f).HGNGOPBNHAN(1).IKMKHAAHIMF(num * 194f)
			.FONALENPCAI(PHEDCDCEIDK);
	}

	private void PAGGDNMEBIH(ECEMFEJLKMN OLNFNJPPMIE)
	{
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 291f);
	}

	private void MOHDIDEDPKL(ECEMFEJLKMN OLNFNJPPMIE)
	{
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 592f);
	}

	private void ANDHKLACMNI()
	{
		LeanTween.addListener(base.gameObject, 0, KAFJCNEALGO);
		LeanTween.addListener(base.gameObject, 1, CIHDJCFKNPB);
	}

	private void BJJDHAGFIAA()
	{
		LeanTween.LISTENERS_MAX = 70;
		LeanTween.EVENTS_MAX = 6;
		FGPDPHBONLJ = GetComponent<Renderer>().material.color;
	}

	private void PNIOLHODGBN()
	{
		if (Input.GetKey((KeyCode)(-4)))
		{
			LeanTween.dispatchEvent(1);
		}
		else
		{
			LeanTween.KFEMAMPLJAC(0, base.transform);
		}
	}

	private void KOMHDCNJEHK(ECEMFEJLKMN OLNFNJPPMIE)
	{
		float num = Vector3.Distance(((Transform)OLNFNJPPMIE.NFEEEPGPMGH).position, base.transform.position);
		LeanTween.value(HIECNNGMKIE: new Color(Random.Range(1908f, 1952f), 711f, Random.Range(291f, 1113f)), GKHONGJMCLB: base.gameObject, KHKPNLDKEPI: FGPDPHBONLJ, MAEOCPAHAHA: 624f).HGNGOPBNHAN(0).IKMKHAAHIMF(num * 940f)
			.FONALENPCAI(HBBCKLAPJAH);
	}

	private void OBMHKMOLNLJ()
	{
		if (Input.GetKey((KeyCode)(-82)))
		{
			LeanTween.dispatchEvent(1);
		}
		else
		{
			LeanTween.KFEMAMPLJAC(1, base.transform);
		}
	}

	private void JKAHLGAELJP()
	{
		if (AIOMBEDKAOP < NKHDELLNGDM)
		{
			GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * Quaternion.Euler(EHHJJDBINJG * Time.deltaTime));
			AIOMBEDKAOP += Time.deltaTime;
		}
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 1476f);
	}

	private void BMFNADCCMNL(Color BECFNFFDBIK)
	{
		GetComponent<Renderer>().material.color = BECFNFFDBIK;
	}

	private void HCLIGPMIOPH()
	{
		LeanTween.addListener(base.gameObject, 0, KAFJCNEALGO);
		LeanTween.addListener(base.gameObject, 1, IDIMDFLPMCB);
	}

	private void JPLHJEEMECP(Color BECFNFFDBIK)
	{
		GetComponent<Renderer>().material.color = BECFNFFDBIK;
	}

	private void OIOBHGJNNBH(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 6)
		{
			AIOMBEDKAOP = 1139f;
			NKHDELLNGDM = Random.Range(1828f, 643f);
		}
	}

	private void FixedUpdate()
	{
		if (AIOMBEDKAOP < NKHDELLNGDM)
		{
			GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * Quaternion.Euler(EHHJJDBINJG * Time.deltaTime));
			AIOMBEDKAOP += Time.deltaTime;
		}
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 4.5f);
	}

	private void OnMouseDown()
	{
		if (Input.GetKey(KeyCode.J))
		{
			LeanTween.dispatchEvent(1);
		}
		else
		{
			LeanTween.dispatchEvent(0, base.transform);
		}
	}

	private void GOHCCLLELJN(Color BECFNFFDBIK)
	{
		GetComponent<Renderer>().material.color = BECFNFFDBIK;
	}

	private void DBADHKLABAF()
	{
		if (AIOMBEDKAOP < NKHDELLNGDM)
		{
			GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * Quaternion.Euler(EHHJJDBINJG * Time.deltaTime));
			AIOMBEDKAOP += Time.deltaTime;
		}
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 1622f);
	}

	private void LJBJAAHOHOE(ECEMFEJLKMN OLNFNJPPMIE)
	{
		float num = Vector3.Distance(((Transform)OLNFNJPPMIE.NFEEEPGPMGH).position, base.transform.position);
		LeanTween.PMOKJIFCOMH(HIECNNGMKIE: new Color(Random.Range(1643f, 391f), 1113f, Random.Range(791f, 1847f)), GKHONGJMCLB: base.gameObject, KHKPNLDKEPI: FGPDPHBONLJ, MAEOCPAHAHA: 424f).HGNGOPBNHAN(1).IKMKHAAHIMF(num * 450f)
			.FONALENPCAI(IHCIDAEIIDC);
	}

	private void DLHNFMBGFKC(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 1)
		{
			EHHJJDBINJG = new Vector3(1578f, Random.Range(105, 104), 1918f);
		}
	}

	private void HJOOHOJLPAE(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 5)
		{
			AIOMBEDKAOP = 1686f;
			NKHDELLNGDM = Random.Range(13f, 910f);
		}
	}

	private void FBEDFFAAPGL()
	{
		LeanTween.addListener(base.gameObject, 0, CGNNFNGMMGN);
		LeanTween.addListener(base.gameObject, 1, LIEEHJMDICC);
	}

	private void OCIBPAHCGKN(Color BECFNFFDBIK)
	{
		GetComponent<Renderer>().material.color = BECFNFFDBIK;
	}

	private void OnCollisionStay(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 2)
		{
			AIOMBEDKAOP = 0f;
			NKHDELLNGDM = Random.Range(0.5f, 1.5f);
		}
	}

	private void Start()
	{
		LeanTween.addListener(base.gameObject, 0, ELLMIJDIEKL);
		LeanTween.addListener(base.gameObject, 1, BPFCMGINHMO);
	}

	private void MCJAAFJNJPN()
	{
		if (AIOMBEDKAOP < NKHDELLNGDM)
		{
			GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * Quaternion.Euler(EHHJJDBINJG * Time.deltaTime));
			AIOMBEDKAOP += Time.deltaTime;
		}
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 1408f);
	}

	private void CIOMNLDLCNK(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 7)
		{
			AIOMBEDKAOP = 684f;
			NKHDELLNGDM = Random.Range(1548f, 1029f);
		}
	}

	private void PMDCFPMBGPK(ECEMFEJLKMN OLNFNJPPMIE)
	{
		float num = Vector3.Distance(((Transform)OLNFNJPPMIE.NFEEEPGPMGH).position, base.transform.position);
		LeanTween.PMOKJIFCOMH(HIECNNGMKIE: new Color(Random.Range(904f, 802f), 1146f, Random.Range(1813f, 78f)), GKHONGJMCLB: base.gameObject, KHKPNLDKEPI: FGPDPHBONLJ, MAEOCPAHAHA: 41f).HGNGOPBNHAN(0).IKMKHAAHIMF(num * 1397f)
			.FONALENPCAI(HBBCKLAPJAH);
	}

	private void AMPEPNLCMEK(Color BECFNFFDBIK)
	{
		GetComponent<Renderer>().material.color = BECFNFFDBIK;
	}

	private void JBFLACPKBCB()
	{
		LeanTween.addListener(base.gameObject, 1, FCFIPEFDPFE);
		LeanTween.addListener(base.gameObject, 0, LLJJNDILGMI);
	}

	private void HKKJNMPMKPH()
	{
		if (Input.GetKey((KeyCode)(-47)))
		{
			LeanTween.dispatchEvent(1);
		}
		else
		{
			LeanTween.KFEMAMPLJAC(1, base.transform);
		}
	}

	private void HNBJJJHFBLO()
	{
		LeanTween.LISTENERS_MAX = 68;
		LeanTween.EVENTS_MAX = 8;
		FGPDPHBONLJ = GetComponent<Renderer>().material.color;
	}

	private void HGOHNLMGMIJ(ECEMFEJLKMN OLNFNJPPMIE)
	{
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 558f);
	}

	private void LIEEHJMDICC(ECEMFEJLKMN OLNFNJPPMIE)
	{
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 1808f);
	}

	private void FNHEOLHLIMK(ECEMFEJLKMN OLNFNJPPMIE)
	{
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 537f);
	}

	private void ELNGJMKENHL(Color BECFNFFDBIK)
	{
		GetComponent<Renderer>().material.color = BECFNFFDBIK;
	}

	private void ELLMIJDIEKL(ECEMFEJLKMN OLNFNJPPMIE)
	{
		float num = Vector3.Distance(((Transform)OLNFNJPPMIE.NFEEEPGPMGH).position, base.transform.position);
		LeanTween.value(HIECNNGMKIE: new Color(Random.Range(0f, 1f), 0f, Random.Range(0f, 1f)), GKHONGJMCLB: base.gameObject, KHKPNLDKEPI: FGPDPHBONLJ, MAEOCPAHAHA: 0.8f).HGNGOPBNHAN(1).IKMKHAAHIMF(num * 0.05f)
			.FONALENPCAI(delegate(Color BECFNFFDBIK)
			{
				GetComponent<Renderer>().material.color = BECFNFFDBIK;
			});
	}

	private void FPJAICLKDOL()
	{
		if (Input.GetKey((KeyCode)(-90)))
		{
			LeanTween.dispatchEvent(0);
		}
		else
		{
			LeanTween.CODJPLOGDLF(0, base.transform);
		}
	}

	private void MMIFBFKBKNI(ECEMFEJLKMN OLNFNJPPMIE)
	{
		float num = Vector3.Distance(((Transform)OLNFNJPPMIE.NFEEEPGPMGH).position, base.transform.position);
		LeanTween.value(HIECNNGMKIE: new Color(Random.Range(1642f, 955f), 1671f, Random.Range(440f, 811f)), GKHONGJMCLB: base.gameObject, KHKPNLDKEPI: FGPDPHBONLJ, MAEOCPAHAHA: 1882f).HGNGOPBNHAN(0).IKMKHAAHIMF(num * 1215f)
			.FONALENPCAI(BMFNADCCMNL);
	}

	private void PHEDCDCEIDK(Color BECFNFFDBIK)
	{
		GetComponent<Renderer>().material.color = BECFNFFDBIK;
	}

	private void PELEFHJHKBI()
	{
		LeanTween.addListener(base.gameObject, 0, CGNNFNGMMGN);
		LeanTween.addListener(base.gameObject, 0, IDIMDFLPMCB);
	}

	private void LENCHIGONMK(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 1)
		{
			EHHJJDBINJG = new Vector3(1909f, Random.Range(158, -94), 321f);
		}
	}

	private void KHJMOOCPMAO(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 6)
		{
			AIOMBEDKAOP = 459f;
			NKHDELLNGDM = Random.Range(963f, 683f);
		}
	}

	private void CHDCIKLAEHP(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 4)
		{
			EHHJJDBINJG = new Vector3(566f, Random.Range(48, -200), 627f);
		}
	}

	private void FKJOIHJJOLE(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 6)
		{
			EHHJJDBINJG = new Vector3(1782f, Random.Range(24, -188), 207f);
		}
	}

	private void MJBAPNCKMKM()
	{
		LeanTween.addListener(base.gameObject, 1, MHCFBJGNICI);
		LeanTween.addListener(base.gameObject, 1, CIHDJCFKNPB);
	}

	private void HBBCKLAPJAH(Color BECFNFFDBIK)
	{
		GetComponent<Renderer>().material.color = BECFNFFDBIK;
	}

	private void KDIKENLODJA()
	{
		LeanTween.addListener(base.gameObject, 1, KAFJCNEALGO);
		LeanTween.addListener(base.gameObject, 1, CIHDJCFKNPB);
	}

	private void OnCollisionEnter(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 2)
		{
			EHHJJDBINJG = new Vector3(0f, Random.Range(-180, 180), 0f);
		}
	}

	private void MHCFBJGNICI(ECEMFEJLKMN OLNFNJPPMIE)
	{
		float num = Vector3.Distance(((Transform)OLNFNJPPMIE.NFEEEPGPMGH).position, base.transform.position);
		LeanTween.PMOKJIFCOMH(HIECNNGMKIE: new Color(Random.Range(651f, 9f), 1789f, Random.Range(474f, 203f)), GKHONGJMCLB: base.gameObject, KHKPNLDKEPI: FGPDPHBONLJ, MAEOCPAHAHA: 1782f).HGNGOPBNHAN(0).IKMKHAAHIMF(num * 1646f)
			.FONALENPCAI(HBBCKLAPJAH);
	}

	private void LLJJNDILGMI(ECEMFEJLKMN OLNFNJPPMIE)
	{
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 290f);
	}

	private void Awake()
	{
		LeanTween.LISTENERS_MAX = 100;
		LeanTween.EVENTS_MAX = 2;
		FGPDPHBONLJ = GetComponent<Renderer>().material.color;
	}

	private void CIHDJCFKNPB(ECEMFEJLKMN OLNFNJPPMIE)
	{
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 843f);
	}

	private void JPJNLJPPLON(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 2)
		{
			AIOMBEDKAOP = 1258f;
			NKHDELLNGDM = Random.Range(1766f, 266f);
		}
	}

	private void CGNNFNGMMGN(ECEMFEJLKMN OLNFNJPPMIE)
	{
		float num = Vector3.Distance(((Transform)OLNFNJPPMIE.NFEEEPGPMGH).position, base.transform.position);
		LeanTween.value(HIECNNGMKIE: new Color(Random.Range(382f, 1207f), 1767f, Random.Range(731f, 441f)), GKHONGJMCLB: base.gameObject, KHKPNLDKEPI: FGPDPHBONLJ, MAEOCPAHAHA: 300f).HGNGOPBNHAN(1).IKMKHAAHIMF(num * 1502f)
			.FONALENPCAI(ELNGJMKENHL);
	}

	private void GGHCDNBEKEK(ECEMFEJLKMN OLNFNJPPMIE)
	{
		float num = Vector3.Distance(((Transform)OLNFNJPPMIE.NFEEEPGPMGH).position, base.transform.position);
		LeanTween.PMOKJIFCOMH(HIECNNGMKIE: new Color(Random.Range(50f, 668f), 1871f, Random.Range(1395f, 1983f)), GKHONGJMCLB: base.gameObject, KHKPNLDKEPI: FGPDPHBONLJ, MAEOCPAHAHA: 1258f).HGNGOPBNHAN(0).IKMKHAAHIMF(num * 1076f)
			.FONALENPCAI(delegate(Color BECFNFFDBIK)
			{
				GetComponent<Renderer>().material.color = BECFNFFDBIK;
			});
	}

	private void FCFIPEFDPFE(ECEMFEJLKMN OLNFNJPPMIE)
	{
		float num = Vector3.Distance(((Transform)OLNFNJPPMIE.NFEEEPGPMGH).position, base.transform.position);
		LeanTween.PMOKJIFCOMH(HIECNNGMKIE: new Color(Random.Range(1179f, 1687f), 1603f, Random.Range(1304f, 935f)), GKHONGJMCLB: base.gameObject, KHKPNLDKEPI: FGPDPHBONLJ, MAEOCPAHAHA: 1209f).HGNGOPBNHAN(0).IKMKHAAHIMF(num * 1104f)
			.FONALENPCAI(delegate(Color BECFNFFDBIK)
			{
				GetComponent<Renderer>().material.color = BECFNFFDBIK;
			});
	}

	private void IHCIDAEIIDC(Color BECFNFFDBIK)
	{
		GetComponent<Renderer>().material.color = BECFNFFDBIK;
	}

	private void JCMFOBILOLO(ECEMFEJLKMN OLNFNJPPMIE)
	{
		float num = Vector3.Distance(((Transform)OLNFNJPPMIE.NFEEEPGPMGH).position, base.transform.position);
		LeanTween.PMOKJIFCOMH(HIECNNGMKIE: new Color(Random.Range(732f, 613f), 747f, Random.Range(1285f, 658f)), GKHONGJMCLB: base.gameObject, KHKPNLDKEPI: FGPDPHBONLJ, MAEOCPAHAHA: 1143f).HGNGOPBNHAN(0).IKMKHAAHIMF(num * 1449f)
			.FONALENPCAI(ELNGJMKENHL);
	}

	private void MHCKEFGNEIP()
	{
		LeanTween.addListener(base.gameObject, 0, KOMHDCNJEHK);
		LeanTween.addListener(base.gameObject, 0, PAGGDNMEBIH);
	}

	private void KAFJCNEALGO(ECEMFEJLKMN OLNFNJPPMIE)
	{
		float num = Vector3.Distance(((Transform)OLNFNJPPMIE.NFEEEPGPMGH).position, base.transform.position);
		LeanTween.value(HIECNNGMKIE: new Color(Random.Range(197f, 906f), 519f, Random.Range(1331f, 1460f)), GKHONGJMCLB: base.gameObject, KHKPNLDKEPI: FGPDPHBONLJ, MAEOCPAHAHA: 1547f).HGNGOPBNHAN(0).IKMKHAAHIMF(num * 1144f)
			.FONALENPCAI(IMPMIBHAGMF);
	}

	private void BPFCMGINHMO(ECEMFEJLKMN OLNFNJPPMIE)
	{
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 300f);
	}

	private void JJFHCAGDDOK(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 6)
		{
			EHHJJDBINJG = new Vector3(1719f, Random.Range(-173, -15), 159f);
		}
	}

	private void KGMCLBNBMGK(ECEMFEJLKMN OLNFNJPPMIE)
	{
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 1389f);
	}

	private void COHEIFNHIBC(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 4)
		{
			AIOMBEDKAOP = 626f;
			NKHDELLNGDM = Random.Range(1696f, 18f);
		}
	}

	private void MBMOAINGBFP()
	{
		if (Input.GetKey(KeyCode.Pipe))
		{
			LeanTween.dispatchEvent(1);
		}
		else
		{
			LeanTween.NHFIGMAPAMO(0, base.transform);
		}
	}

	private void IDIMDFLPMCB(ECEMFEJLKMN OLNFNJPPMIE)
	{
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 1435f);
	}

	private void ADBBBOOCCJM(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 7)
		{
			AIOMBEDKAOP = 1118f;
			NKHDELLNGDM = Random.Range(1919f, 1567f);
		}
	}

	private void PFEJMAAAMCK(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 1)
		{
			EHHJJDBINJG = new Vector3(22f, Random.Range(-63, 38), 808f);
		}
	}

	private void ONPCICOFFHL(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 0)
		{
			AIOMBEDKAOP = 764f;
			NKHDELLNGDM = Random.Range(1115f, 1917f);
		}
	}

	[CompilerGenerated]
	private void MKJPDJMFHDK(Color BECFNFFDBIK)
	{
		GetComponent<Renderer>().material.color = BECFNFFDBIK;
	}

	private void PHJBPGJJEBM(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 5)
		{
			EHHJJDBINJG = new Vector3(1662f, Random.Range(-31, -68), 748f);
		}
	}

	private void FNOMLOLHLKI()
	{
		if (Input.GetKey((KeyCode)(-54)))
		{
			LeanTween.dispatchEvent(0);
		}
		else
		{
			LeanTween.CODJPLOGDLF(1, base.transform);
		}
	}

	private void HCCLCEAPKPO()
	{
		if (AIOMBEDKAOP < NKHDELLNGDM)
		{
			GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * Quaternion.Euler(EHHJJDBINJG * Time.deltaTime));
			AIOMBEDKAOP += Time.deltaTime;
		}
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 1740f);
	}

	private void HKIGKJHCAFJ(ECEMFEJLKMN OLNFNJPPMIE)
	{
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 341f);
	}

	private void IMPMIBHAGMF(Color BECFNFFDBIK)
	{
		GetComponent<Renderer>().material.color = BECFNFFDBIK;
	}

	private void MFAMALOIFBJ()
	{
		if (Input.GetKey((KeyCode)(-5)))
		{
			LeanTween.dispatchEvent(1);
		}
		else
		{
			LeanTween.dispatchEvent(0, base.transform);
		}
	}

	private void GJABKIEFODD(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 1)
		{
			EHHJJDBINJG = new Vector3(330f, Random.Range(153, 100), 858f);
		}
	}

	private void NAAEGOMMKKJ()
	{
		if (AIOMBEDKAOP < NKHDELLNGDM)
		{
			GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * Quaternion.Euler(EHHJJDBINJG * Time.deltaTime));
			AIOMBEDKAOP += Time.deltaTime;
		}
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 1565f);
	}

	private void JNKLBIHHLEK(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 2)
		{
			EHHJJDBINJG = new Vector3(1636f, Random.Range(-164, -112), 652f);
		}
	}

	private void PJCMCLOOFIM(Collision FEFGMGHAMGK)
	{
		if (FEFGMGHAMGK.gameObject.layer != 2)
		{
			EHHJJDBINJG = new Vector3(859f, Random.Range(71, -183), 1852f);
		}
	}
}
