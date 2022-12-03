// BMDIMDNILIM
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class BMDIMDNILIM
{
	public delegate Vector3 JBNBGMLJIKC();

	public delegate void LPDKOIPJBFK();

	public bool IBNEHJPJFIL;

	public bool KLLAFBMNKKM;

	public bool KNMBKPJJEAO;

	public bool FLDOAKJEMNC;

	public bool LCJODMHCGIB;

	public bool MOBCAPKOLKP;

	public bool MNJLPBBGPJI;

	public bool AKPPOKNPMDG;

	public bool HJDDJJDCPGC;

	public bool JEAAIGMHMGI;

	public bool DAGIGIBOMLH;

	public float MMOFNOOHHDM;

	public float GANCKAFBCGO;

	public float FNJNKEADGAM;

	public float MAEOCPAHAHA;

	public float AACJOJOJMOH;

	public float IMIHNEKGMPK;

	private uint LFMLPGGGPMK;

	public int PGFGAOFOAOG;

	public uint NLBGPCBDMGD = uint.MaxValue;

	public float GPEBLBKJFHC;

	public float FLIGOJKJBEF;

	public float DFBOMFPMKEF;

	public float GFOKPCHDPMI;

	public float KIKJLHMONDO;

	public bool HNALLPLCLKE;

	public Transform LOEHKHINJAH;

	internal Vector3 PLAKEDCBHGH;

	internal Vector3 NLBHGGANDMI;

	internal Vector3 OBEJEJKJNAB;

	internal Vector3 LOJJNGOHPKJ;

	public GFMDPMOPLPO PKKHGLGLFMK;

	private DEFBOFIHBCP KGDBBGGCBKE;

	public DEFBOFIHBCP HOFNENKKLMO;

	public bool KKPJGPKIEBI;

	public JBNBGMLJIKC JCPNNEMGBIG;

	public SpriteRenderer FKAKCFNGDGL;

	public RectTransform DHCIKBOPGNF;

	public Text DOLLBOPGEPK;

	public Image ADFBMONHJCI;

	public RawImage JLECGOEFCFE;

	public Sprite[] OMLBFIOPPNI;

	public MLAFAIADMMK DFBBNCIMAFE = new MLAFAIADMMK();

	public static float GBMPBBHCBDA;

	public static float KAFGFEOJLAM;

	public static Vector3 DMCLLHJDNLG;

	public Vector3 KHKPNLDKEPI
	{
		get
		{
			return PLAKEDCBHGH;
		}
		set
		{
			PLAKEDCBHGH = value;
		}
	}

	public Vector3 HIECNNGMKIE
	{
		get
		{
			return NLBHGGANDMI;
		}
		set
		{
			NLBHGGANDMI = value;
		}
	}

	public LPDKOIPJBFK ALECMEFEFIE
	{
		get;
		set;
	}

	public LPDKOIPJBFK CPCNFMJIGNM
	{
		get;
		set;
	}

	public Transform NGAFDIIEGJK => JINOBHJPJAE.NGAFDIIEGJK;

	public int EPAEGFCEIIG => (int)(LFMLPGGGPMK | (NLBGPCBDMGD << 16));

	public int LHCMMKLKDHH => EPAEGFCEIIG;

	public MLAFAIADMMK JINOBHJPJAE
	{
		get
		{
			return DFBBNCIMAFE;
		}
		set
		{
			DFBBNCIMAFE = value;
		}
	}

	[CompilerGenerated]
	private void LHHJPCOCNLD()
	{
		DOLLBOPGEPK = LOEHKHINJAH.GetComponent<Text>();
		MCEKKFHGKIP((DOLLBOPGEPK != null) ? DOLLBOPGEPK.color : Color.white);
	}

	public BMDIMDNILIM FONALENPCAI(Action<Vector3, object> KDHFAGIFKAK, object KPFPEAIAJMO = null)
	{
		DFBBNCIMAFE.CNDBAFLMKMG = KDHFAGIFKAK;
		KKPJGPKIEBI = true;
		if (KPFPEAIAJMO != null)
		{
			DFBBNCIMAFE.KPFPEAIAJMO = KPFPEAIAJMO;
		}
		return this;
	}

	public BMDIMDNILIM IADGAKNCMIC()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeOutElastic;
		JCPNNEMGBIG = LHKMGAHOOHO;
		return this;
	}

	private Vector3 IDKMGDKDDME()
	{
		GBMPBBHCBDA = MMOFNOOHHDM - 1f;
		GBMPBBHCBDA = Mathf.Sqrt(1f - GBMPBBHCBDA * GBMPBBHCBDA);
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	public BMDIMDNILIM PLFAHIMEGLC()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInOutBack;
		JCPNNEMGBIG = MCKNIKBLDBG;
		return this;
	}

	public BMDIMDNILIM EOAPKBBHBAL(Action NBBHOMIKJIL)
	{
		DFBBNCIMAFE.NBBHOMIKJIL = NBBHOMIKJIL;
		MNJLPBBGPJI = true;
		return this;
	}

	[CompilerGenerated]
	private void OMHCANCNCHC()
	{
		LOEHKHINJAH.localPosition = new Vector3(LOEHKHINJAH.localPosition.x, LOEHKHINJAH.localPosition.y, JCPNNEMGBIG().x);
	}

	public BMDIMDNILIM PPPLNDBLONE()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.ROTATE_LOCAL;
		CPCNFMJIGNM = delegate
		{
			KHKPNLDKEPI = LOEHKHINJAH.localEulerAngles;
			HIECNNGMKIE = new Vector3(LeanTween.closestRot(PLAKEDCBHGH.x, NLBHGGANDMI.x), LeanTween.closestRot(KHKPNLDKEPI.y, HIECNNGMKIE.y), LeanTween.closestRot(KHKPNLDKEPI.z, HIECNNGMKIE.z));
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			LOEHKHINJAH.localEulerAngles = DMCLLHJDNLG;
		};
		return this;
	}

	private void MGAOPOMCOGE()
	{
		Vector3 anchoredPosition3D = DHCIKBOPGNF.anchoredPosition3D;
		DHCIKBOPGNF.anchoredPosition3D = new Vector3(anchoredPosition3D.x, anchoredPosition3D.y, JCPNNEMGBIG().x);
	}

	public BMDIMDNILIM BCEBLONBDLH()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.GUI_ALPHA;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = DFBBNCIMAFE.KLEBOFBEKJJ.alpha;
		};
		ALECMEFEFIE = delegate
		{
			DFBBNCIMAFE.KLEBOFBEKJJ.alpha = JCPNNEMGBIG().x;
		};
		return this;
	}

	public BMDIMDNILIM KKJDBPHNFGC(bool DIJDMFFJBMH)
	{
		MOBCAPKOLKP = DIJDMFFJBMH;
		return this;
	}

	public BMDIMDNILIM AFLMDJINPMP(Sprite[] OMLBFIOPPNI)
	{
		this.OMLBFIOPPNI = OMLBFIOPPNI;
		return this;
	}

	[CompilerGenerated]
	private void DEDAOPPAPKF()
	{
		LOEHKHINJAH.GetComponent<CanvasGroup>().alpha = JCPNNEMGBIG().x;
	}

	private Vector3 AKBHEAEPLOB()
	{
		GBMPBBHCBDA = MMOFNOOHHDM * 2f;
		if (GBMPBBHCBDA < 1f)
		{
			GBMPBBHCBDA = 0f - (Mathf.Sqrt(1f - GBMPBBHCBDA * GBMPBBHCBDA) - 1f);
			return new Vector3(LOJJNGOHPKJ.x * GBMPBBHCBDA + KHKPNLDKEPI.x, LOJJNGOHPKJ.y * GBMPBBHCBDA + KHKPNLDKEPI.y, LOJJNGOHPKJ.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
		}
		GBMPBBHCBDA -= 2f;
		GBMPBBHCBDA = Mathf.Sqrt(1f - GBMPBBHCBDA * GBMPBBHCBDA) + 1f;
		return new Vector3(LOJJNGOHPKJ.x * GBMPBBHCBDA + KHKPNLDKEPI.x, LOJJNGOHPKJ.y * GBMPBBHCBDA + KHKPNLDKEPI.y, LOJJNGOHPKJ.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	[CompilerGenerated]
	private void JFDLMIOLJNF()
	{
		KHKPNLDKEPI = DHCIKBOPGNF.sizeDelta;
	}

	private Vector3 NIKFCFNFOHH()
	{
		GBMPBBHCBDA = MMOFNOOHHDM - 1f;
		GBMPBBHCBDA = GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA + 1f;
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	public BMDIMDNILIM AAGELHDNACF()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE_LOCAL_Z;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.localPosition.z;
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.localPosition = new Vector3(LOEHKHINJAH.localPosition.x, LOEHKHINJAH.localPosition.y, JCPNNEMGBIG().x);
		};
		return this;
	}

	private Vector3 BHAPALBHPHJ()
	{
		GBMPBBHCBDA = 0f - Mathf.Cos(MMOFNOOHHDM * LeanTween.PI_DIV2);
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + OBEJEJKJNAB.x + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + OBEJEJKJNAB.y + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + OBEJEJKJNAB.z + KHKPNLDKEPI.z);
	}

	public BMDIMDNILIM HIEMJOFJGCL()
	{
		PAOBFLPOJIC();
		return this;
	}

	public BMDIMDNILIM ODEHNDGIOKO()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE_X;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.position.y;
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.position = new Vector3(LOEHKHINJAH.position.x, JCPNNEMGBIG().x, LOEHKHINJAH.position.z);
		};
		return this;
	}

	public BMDIMDNILIM MMBBOPDHONE()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInOutElastic;
		JCPNNEMGBIG = LHEPECCFMEB;
		return this;
	}

	[CompilerGenerated]
	private void MCDKLBHKDPA()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		if (DFBBNCIMAFE.PFKHAKGHKPK.HCJCJDJEFAD)
		{
			if (DFBBNCIMAFE.PFKHAKGHKPK.NDPNNJEFLHO)
			{
				DFBBNCIMAFE.PFKHAKGHKPK.GKKDJKIJEIJ(LOEHKHINJAH, GBMPBBHCBDA);
			}
			else
			{
				DFBBNCIMAFE.PFKHAKGHKPK.NGFEAGKGPLB(LOEHKHINJAH, GBMPBBHCBDA);
			}
		}
		else
		{
			LOEHKHINJAH.position = DFBBNCIMAFE.PFKHAKGHKPK.CNBPFDEFCEK(GBMPBBHCBDA);
		}
	}

	public BMDIMDNILIM LIEFGJKDOAN(Vector3 HIECNNGMKIE)
	{
		if (MOBCAPKOLKP)
		{
			this.HIECNNGMKIE = HIECNNGMKIE;
			OBEJEJKJNAB = HIECNNGMKIE - KHKPNLDKEPI;
		}
		else
		{
			this.HIECNNGMKIE = HIECNNGMKIE;
		}
		return this;
	}

	public BMDIMDNILIM PCLAIHEEEDP()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeOutSine;
		JCPNNEMGBIG = NBPGCIMNOCO;
		return this;
	}

	private void FDNMODCICKH()
	{
		DOLLBOPGEPK = LOEHKHINJAH.GetComponent<Text>();
		MCEKKFHGKIP((DOLLBOPGEPK != null) ? DOLLBOPGEPK.color : Color.white);
	}

	public BMDIMDNILIM FONALENPCAI(Action<Vector3> KDHFAGIFKAK, object KPFPEAIAJMO = null)
	{
		DFBBNCIMAFE.EIEOAFKMBGM = KDHFAGIFKAK;
		KKPJGPKIEBI = true;
		if (KPFPEAIAJMO != null)
		{
			DFBBNCIMAFE.KPFPEAIAJMO = KPFPEAIAJMO;
		}
		return this;
	}

	public BMDIMDNILIM LKPABJGLLKI()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CANVAS_MOVE;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH = DHCIKBOPGNF.anchoredPosition3D;
		};
		ALECMEFEFIE = delegate
		{
			DHCIKBOPGNF.anchoredPosition3D = JCPNNEMGBIG();
		};
		return this;
	}

	public BMDIMDNILIM PJGOPLDCIFK()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE_Y;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.position.y;
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.position = new Vector3(LOEHKHINJAH.position.x, JCPNNEMGBIG().x, LOEHKHINJAH.position.z);
		};
		return this;
	}

	public BMDIMDNILIM AFKEABNJOLK(JNLGHEAGHNK PFKHAKGHKPK)
	{
		DFBBNCIMAFE.PFKHAKGHKPK = PFKHAKGHKPK;
		return this;
	}

	[CompilerGenerated]
	private void LKGGNKAPNLL()
	{
		LOEHKHINJAH.position = new Vector3(LOEHKHINJAH.position.x, JCPNNEMGBIG().x, LOEHKHINJAH.position.z);
	}

	private Vector3 HDFHCLKBCIM()
	{
		GBMPBBHCBDA = MMOFNOOHHDM * 2f;
		if (GBMPBBHCBDA < 1f)
		{
			GBMPBBHCBDA = GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA;
			return new Vector3(LOJJNGOHPKJ.x * GBMPBBHCBDA + KHKPNLDKEPI.x, LOJJNGOHPKJ.y * GBMPBBHCBDA + KHKPNLDKEPI.y, LOJJNGOHPKJ.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
		}
		GBMPBBHCBDA -= 2f;
		GBMPBBHCBDA = GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA + 2f;
		return new Vector3(LOJJNGOHPKJ.x * GBMPBBHCBDA + KHKPNLDKEPI.x, LOJJNGOHPKJ.y * GBMPBBHCBDA + KHKPNLDKEPI.y, LOJJNGOHPKJ.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	private Vector3 EHCAECDGJCA()
	{
		GBMPBBHCBDA = Mathf.Clamp01(MMOFNOOHHDM);
		GBMPBBHCBDA = (Mathf.Sin(GBMPBBHCBDA * (float)Math.PI * (0.2f + 2.5f * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA)) * Mathf.Pow(1f - GBMPBBHCBDA, 2.2f) + GBMPBBHCBDA) * (1f + 1.2f * (1f - GBMPBBHCBDA));
		return KHKPNLDKEPI + OBEJEJKJNAB * GBMPBBHCBDA;
	}

	[CompilerGenerated]
	private void GBEEHJDDEDC()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		if (DFBBNCIMAFE.PFKHAKGHKPK.HCJCJDJEFAD)
		{
			if (DFBBNCIMAFE.PFKHAKGHKPK.NDPNNJEFLHO)
			{
				DFBBNCIMAFE.PFKHAKGHKPK.FEAMPOAHCGC(LOEHKHINJAH, GBMPBBHCBDA);
			}
			else
			{
				DFBBNCIMAFE.PFKHAKGHKPK.PGINPBGPAFP(LOEHKHINJAH, GBMPBBHCBDA);
			}
		}
		else
		{
			LOEHKHINJAH.localPosition = DFBBNCIMAFE.PFKHAKGHKPK.CNBPFDEFCEK(GBMPBBHCBDA);
		}
	}

	public BMDIMDNILIM HEINKIBDMDN()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.GUI_MOVE;
		CPCNFMJIGNM = delegate
		{
			KHKPNLDKEPI = new Vector3(DFBBNCIMAFE.KLEBOFBEKJJ.rect.x, DFBBNCIMAFE.KLEBOFBEKJJ.rect.y, 0f);
		};
		ALECMEFEFIE = delegate
		{
			Vector3 vector = JCPNNEMGBIG();
			DFBBNCIMAFE.KLEBOFBEKJJ.rect = new Rect(vector.x, vector.y, DFBBNCIMAFE.KLEBOFBEKJJ.rect.width, DFBBNCIMAFE.KLEBOFBEKJJ.rect.height);
		};
		return this;
	}

	[CompilerGenerated]
	private void HCHBBFJGBLN()
	{
		KHKPNLDKEPI = DHCIKBOPGNF.localScale;
	}

	[CompilerGenerated]
	private void ILIKPDOLPEM()
	{
		KHKPNLDKEPI = LOEHKHINJAH.localEulerAngles;
		HIECNNGMKIE = new Vector3(LeanTween.closestRot(PLAKEDCBHGH.x, NLBHGGANDMI.x), LeanTween.closestRot(KHKPNLDKEPI.y, HIECNNGMKIE.y), LeanTween.closestRot(KHKPNLDKEPI.z, HIECNNGMKIE.z));
	}

	[CompilerGenerated]
	private void DONIGPGFCIJ()
	{
		PLAKEDCBHGH = DHCIKBOPGNF.anchoredPosition3D;
	}

	public BMDIMDNILIM BBLEKPJILCB(Action<float, object> KDHFAGIFKAK)
	{
		DFBBNCIMAFE.FCCMGLEHNJA = KDHFAGIFKAK;
		KKPJGPKIEBI = true;
		return this;
	}

	public BMDIMDNILIM MOGFPOAAECP()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInOutSine;
		JCPNNEMGBIG = DBEIHEEGIDF;
		return this;
	}

	public BMDIMDNILIM PDJBNALFDOC()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.ROTATE;
		CPCNFMJIGNM = delegate
		{
			KHKPNLDKEPI = LOEHKHINJAH.eulerAngles;
			HIECNNGMKIE = new Vector3(LeanTween.closestRot(PLAKEDCBHGH.x, NLBHGGANDMI.x), LeanTween.closestRot(KHKPNLDKEPI.y, HIECNNGMKIE.y), LeanTween.closestRot(KHKPNLDKEPI.z, HIECNNGMKIE.z));
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			LOEHKHINJAH.eulerAngles = DMCLLHJDNLG;
		};
		return this;
	}

	[CompilerGenerated]
	private void BANHNAPOOLK()
	{
		ADFBMONHJCI = LOEHKHINJAH.GetComponent<Image>();
		if (ADFBMONHJCI == null)
		{
			JLECGOEFCFE = LOEHKHINJAH.GetComponent<RawImage>();
			MCEKKFHGKIP((JLECGOEFCFE != null) ? JLECGOEFCFE.color : Color.white);
		}
		else
		{
			MCEKKFHGKIP(ADFBMONHJCI.color);
		}
	}

	public BMDIMDNILIM OHKJJOLHFGC()
	{
		KGDBBGGCBKE = (DEFBOFIHBCP)(-71);
		JCPNNEMGBIG = DKMGJMNOLFL;
		return this;
	}

	public BMDIMDNILIM PKHDJFJBHFC(Vector3 CNBPFDEFCEK)
	{
		DFBBNCIMAFE.CNBPFDEFCEK = CNBPFDEFCEK;
		return this;
	}

	private void NHAJIDEIJGP()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		RectTransform dHCIKBOPGNF = DHCIKBOPGNF;
		Vector3 localPosition = dHCIKBOPGNF.localPosition;
		dHCIKBOPGNF.RotateAround(dHCIKBOPGNF.TransformPoint(DFBBNCIMAFE.DENHHOKNBMG()), dHCIKBOPGNF.TransformDirection(DFBBNCIMAFE.CFFHLNBKKEM()), 0f - GBMPBBHCBDA);
		Vector3 b = localPosition - dHCIKBOPGNF.localPosition;
		dHCIKBOPGNF.localPosition = localPosition - b;
		dHCIKBOPGNF.rotation = DFBBNCIMAFE.HMINCLEHAAE;
		dHCIKBOPGNF.RotateAround(dHCIKBOPGNF.TransformPoint(DFBBNCIMAFE.GODJDLECKHE()), dHCIKBOPGNF.TransformDirection(DFBBNCIMAFE.LOMFAKBCFGG()), GBMPBBHCBDA);
	}

	public BMDIMDNILIM FLFKCANIGKJ()
	{
		PKKHGLGLFMK = (GFMDPMOPLPO)67;
		CPCNFMJIGNM = delegate
		{
			DOLLBOPGEPK = LOEHKHINJAH.GetComponent<Text>();
			MCEKKFHGKIP((DOLLBOPGEPK != null) ? DOLLBOPGEPK.color : Color.white);
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			Color color = BMCJJHIBLGJ(this, GBMPBBHCBDA);
			DOLLBOPGEPK.color = color;
			if (KAFGFEOJLAM != 0f && DFBBNCIMAFE.CNGNFPILFIH != null)
			{
				DFBBNCIMAFE.CNGNFPILFIH(color);
			}
			if (DAGIGIBOMLH && LOEHKHINJAH.childCount > 0)
			{
				KHOFOAMIMFH(LOEHKHINJAH, color);
			}
		};
		return this;
	}

	public BMDIMDNILIM BCCHMCGKOIN(float KHKPNLDKEPI)
	{
		return BCCHMCGKOIN(new Vector3(KHKPNLDKEPI, 0f, 0f));
	}

	public BMDIMDNILIM EIFLJGGABIL()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.linear;
		JCPNNEMGBIG = MPLHGKDDEPN;
		return this;
	}

	public BMDIMDNILIM EBKMJJEAINJ(float GFOKPCHDPMI)
	{
		this.GFOKPCHDPMI = GFOKPCHDPMI;
		return this;
	}

	public BMDIMDNILIM LNKOCCHNPFD()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CANVAS_PLAYSPRITE;
		CPCNFMJIGNM = delegate
		{
			ADFBMONHJCI = LOEHKHINJAH.GetComponent<Image>();
			PLAKEDCBHGH.x = 0f;
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			int num = (int)Mathf.Round(GBMPBBHCBDA);
			ADFBMONHJCI.sprite = OMLBFIOPPNI[num];
		};
		return this;
	}

	private Vector3 OCDJGKICCDC()
	{
		GBMPBBHCBDA = MMOFNOOHHDM * MMOFNOOHHDM;
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	private void IAHBBIPGNIB()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		if (DFBBNCIMAFE.MCHOBONCGAB().orientToPath)
		{
			if (DFBBNCIMAFE.OGNIKCKMDGB().orientToPath2d)
			{
				DFBBNCIMAFE.OGNIKCKMDGB().GKKDJKIJEIJ(LOEHKHINJAH, GBMPBBHCBDA);
			}
			else
			{
				DFBBNCIMAFE.OGNIKCKMDGB().IMNGHLFFDFG(LOEHKHINJAH, GBMPBBHCBDA);
			}
		}
		else
		{
			LOEHKHINJAH.position = DFBBNCIMAFE.MCHOBONCGAB().GLKAEPPNIOP(GBMPBBHCBDA);
		}
	}

	public BMDIMDNILIM EOAPKBBHBAL(Action<object> NBBHOMIKJIL, object JDIELBGOPJD)
	{
		DFBBNCIMAFE.CLJPNGGBPOC = NBBHOMIKJIL;
		MNJLPBBGPJI = true;
		if (JDIELBGOPJD != null)
		{
			DFBBNCIMAFE.JDIELBGOPJD = JDIELBGOPJD;
		}
		return this;
	}

	[CompilerGenerated]
	private void IBCENMBDCMO()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.eulerAngles.z;
		NLBHGGANDMI.x = LeanTween.closestRot(PLAKEDCBHGH.x, NLBHGGANDMI.x);
	}

	private void EPEINABNPCL()
	{
		IMIHNEKGMPK = 1429f;
		PLAKEDCBHGH.x = 52f;
		DFBBNCIMAFE.HMINCLEHAAE = DHCIKBOPGNF.rotation;
	}

	[CompilerGenerated]
	private void KBLBKNNPCNN()
	{
		DFBBNCIMAFE.KLEBOFBEKJJ.rotation = JCPNNEMGBIG().x;
	}

	public BMDIMDNILIM EPOMBLCFDKL()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.ROTATE_AROUND;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = 0f;
			DFBBNCIMAFE.HMINCLEHAAE = LOEHKHINJAH.rotation;
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			Vector3 localPosition = LOEHKHINJAH.localPosition;
			Vector3 point = LOEHKHINJAH.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK);
			LOEHKHINJAH.RotateAround(point, DFBBNCIMAFE.HDNOFOIOENF, 0f - DFBBNCIMAFE.IMIHNEKGMPK);
			Vector3 b = localPosition - LOEHKHINJAH.localPosition;
			LOEHKHINJAH.localPosition = localPosition - b;
			LOEHKHINJAH.rotation = DFBBNCIMAFE.HMINCLEHAAE;
			point = LOEHKHINJAH.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK);
			LOEHKHINJAH.RotateAround(point, DFBBNCIMAFE.HDNOFOIOENF, GBMPBBHCBDA);
			DFBBNCIMAFE.IMIHNEKGMPK = GBMPBBHCBDA;
		};
		return this;
	}

	private Vector3 LKMHAKIGMFK()
	{
		GBMPBBHCBDA = MMOFNOOHHDM - 1f;
		GBMPBBHCBDA = GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA + 1f;
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	public BMDIMDNILIM LEMLIMNIEOF()
	{
		PKKHGLGLFMK = (GFMDPMOPLPO)(-78);
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = 0f;
			DFBBNCIMAFE.HMINCLEHAAE = LOEHKHINJAH.localRotation;
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			Vector3 localPosition = LOEHKHINJAH.localPosition;
			LOEHKHINJAH.RotateAround(LOEHKHINJAH.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK), LOEHKHINJAH.TransformDirection(DFBBNCIMAFE.HDNOFOIOENF), 0f - DFBBNCIMAFE.IMIHNEKGMPK);
			Vector3 b = localPosition - LOEHKHINJAH.localPosition;
			LOEHKHINJAH.localPosition = localPosition - b;
			LOEHKHINJAH.localRotation = DFBBNCIMAFE.HMINCLEHAAE;
			Vector3 point = LOEHKHINJAH.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK);
			LOEHKHINJAH.RotateAround(point, LOEHKHINJAH.TransformDirection(DFBBNCIMAFE.HDNOFOIOENF), GBMPBBHCBDA);
			DFBBNCIMAFE.IMIHNEKGMPK = GBMPBBHCBDA;
		};
		return this;
	}

	public BMDIMDNILIM ILOJLNOMBEI(float MAEOCPAHAHA)
	{
		float num = GANCKAFBCGO / this.MAEOCPAHAHA;
		GANCKAFBCGO = MAEOCPAHAHA * num;
		this.MAEOCPAHAHA = MAEOCPAHAHA;
		return this;
	}

	public BMDIMDNILIM PEOLHNFDBOF()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.TEXT_COLOR;
		CPCNFMJIGNM = delegate
		{
			DOLLBOPGEPK = LOEHKHINJAH.GetComponent<Text>();
			MCEKKFHGKIP((DOLLBOPGEPK != null) ? DOLLBOPGEPK.color : Color.white);
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			Color color = BMCJJHIBLGJ(this, GBMPBBHCBDA);
			DOLLBOPGEPK.color = color;
			if (KAFGFEOJLAM != 0f && DFBBNCIMAFE.CNGNFPILFIH != null)
			{
				DFBBNCIMAFE.CNGNFPILFIH(color);
			}
			if (DAGIGIBOMLH && LOEHKHINJAH.childCount > 0)
			{
				KHOFOAMIMFH(LOEHKHINJAH, color);
			}
		};
		return this;
	}

	public BMDIMDNILIM JMHNKGBOLLN()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInOutBounce;
		JCPNNEMGBIG = NJNBIDKMMIP;
		return this;
	}

	public BMDIMDNILIM FONALENPCAI(Action<Color, object> KDHFAGIFKAK)
	{
		DFBBNCIMAFE.IBHANHJONKC = KDHFAGIFKAK;
		KKPJGPKIEBI = true;
		return this;
	}

	private Vector3 GJHLBNHMDOM()
	{
		GBMPBBHCBDA = MMOFNOOHHDM;
		float num2;
		float num;
		if (GBMPBBHCBDA < (num = 1f - 1.75f * DFBOMFPMKEF / 2.75f))
		{
			GBMPBBHCBDA = 1f / num / num * GBMPBBHCBDA * GBMPBBHCBDA;
		}
		else if (GBMPBBHCBDA < (num2 = 1f - 0.75f * DFBOMFPMKEF / 2.75f))
		{
			GBMPBBHCBDA -= (num + num2) / 2f;
			GBMPBBHCBDA = 7.5625f * GBMPBBHCBDA * GBMPBBHCBDA + 1f - 0.25f * DFBOMFPMKEF * DFBOMFPMKEF;
		}
		else if (GBMPBBHCBDA < (num = 1f - 0.25f * DFBOMFPMKEF / 2.75f))
		{
			GBMPBBHCBDA -= (num + num2) / 2f;
			GBMPBBHCBDA = 7.5625f * GBMPBBHCBDA * GBMPBBHCBDA + 1f - 0.0625f * DFBOMFPMKEF * DFBOMFPMKEF;
		}
		else
		{
			GBMPBBHCBDA -= (num + 1f) / 2f;
			GBMPBBHCBDA = 7.5625f * GBMPBBHCBDA * GBMPBBHCBDA + 1f - 0.015625f * DFBOMFPMKEF * DFBOMFPMKEF;
		}
		return OBEJEJKJNAB * GBMPBBHCBDA + KHKPNLDKEPI;
	}

	public BMDIMDNILIM FHEKMEELODA(Action<Color> KDHFAGIFKAK)
	{
		DFBBNCIMAFE.CNGNFPILFIH = KDHFAGIFKAK;
		KKPJGPKIEBI = true;
		return this;
	}

	private Vector3 KAAHGPCAEEL()
	{
		return new Vector3(KHKPNLDKEPI.x + OBEJEJKJNAB.x * DFBBNCIMAFE.AFEDAGPKMIE.Evaluate(MMOFNOOHHDM), KHKPNLDKEPI.y + OBEJEJKJNAB.y * DFBBNCIMAFE.AFEDAGPKMIE.Evaluate(MMOFNOOHHDM), KHKPNLDKEPI.z + OBEJEJKJNAB.z * DFBBNCIMAFE.AFEDAGPKMIE.Evaluate(MMOFNOOHHDM));
	}

	[CompilerGenerated]
	private void OLHKHGLPIDN()
	{
		PLAKEDCBHGH.x = DHCIKBOPGNF.anchoredPosition3D.x;
	}

	public BMDIMDNILIM MANKHCNNGHK(Action NMDGKEFOHPO)
	{
		DFBBNCIMAFE.NMDGKEFOHPO = NMDGKEFOHPO;
		return this;
	}

	public BMDIMDNILIM OMLNAPJHKEJ()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInCirc;
		JCPNNEMGBIG = MNDDELLIKIA;
		return this;
	}

	public BMDIMDNILIM OMDPEGNPOKH()
	{
		GPEBLBKJFHC = FLIGOJKJBEF;
		return this;
	}

	public BMDIMDNILIM FFBKNIHEFJF(object KPFPEAIAJMO)
	{
		DFBBNCIMAFE.KPFPEAIAJMO = KPFPEAIAJMO;
		return this;
	}

	private Vector3 DBEIHEEGIDF()
	{
		GBMPBBHCBDA = 0f - (Mathf.Cos((float)Math.PI * MMOFNOOHHDM) - 1f);
		return new Vector3(LOJJNGOHPKJ.x * GBMPBBHCBDA + KHKPNLDKEPI.x, LOJJNGOHPKJ.y * GBMPBBHCBDA + KHKPNLDKEPI.y, LOJJNGOHPKJ.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	public BMDIMDNILIM AAIPGNKCPGI()
	{
		DFBBNCIMAFE.AFEDAGPKMIE = LeanTween.punch;
		NLBHGGANDMI.x = KHKPNLDKEPI.x + HIECNNGMKIE.x;
		JCPNNEMGBIG = KAAHGPCAEEL;
		return this;
	}

	[CompilerGenerated]
	private void DFHDKBECHHO()
	{
		Vector3 vector = JCPNNEMGBIG();
		DFBBNCIMAFE.KLEBOFBEKJJ.rect = new Rect(vector.x, vector.y, DFBBNCIMAFE.KLEBOFBEKJJ.rect.width, DFBBNCIMAFE.KLEBOFBEKJJ.rect.height);
	}

	public BMDIMDNILIM BBBJEJOOEJP()
	{
		KGDBBGGCBKE = (DEFBOFIHBCP)(-100);
		JCPNNEMGBIG = EHCAECDGJCA;
		return this;
	}

	public BMDIMDNILIM DKKMFEJAIAK(bool KLLAFBMNKKM)
	{
		this.KLLAFBMNKKM = KLLAFBMNKKM;
		LCJODMHCGIB = false;
		return this;
	}

	[CompilerGenerated]
	private void ICLIEHKBAAM()
	{
		DOLLBOPGEPK = LOEHKHINJAH.GetComponent<Text>();
		PLAKEDCBHGH.x = ((DOLLBOPGEPK != null) ? DOLLBOPGEPK.color.a : 1f);
	}

	public BMDIMDNILIM EIADFAILOFD()
	{
		PKKHGLGLFMK = (GFMDPMOPLPO)93;
		CPCNFMJIGNM = delegate
		{
			SpriteRenderer component = LOEHKHINJAH.GetComponent<SpriteRenderer>();
			if (component != null)
			{
				PLAKEDCBHGH.x = component.color.a;
			}
			else if (LOEHKHINJAH.GetComponent<Renderer>() != null && LOEHKHINJAH.GetComponent<Renderer>().material.HasProperty("_Color"))
			{
				PLAKEDCBHGH.x = LOEHKHINJAH.GetComponent<Renderer>().material.color.a;
			}
			else if (LOEHKHINJAH.GetComponent<Renderer>() != null && LOEHKHINJAH.GetComponent<Renderer>().material.HasProperty("_TintColor"))
			{
				Color color = LOEHKHINJAH.GetComponent<Renderer>().material.GetColor("_TintColor");
				PLAKEDCBHGH.x = color.a;
			}
			else if (LOEHKHINJAH.childCount > 0)
			{
				foreach (Transform item in LOEHKHINJAH)
				{
					if (item.gameObject.GetComponent<Renderer>() != null)
					{
						Color color2 = item.gameObject.GetComponent<Renderer>().material.color;
						PLAKEDCBHGH.x = color2.a;
						break;
					}
				}
			}
			ALECMEFEFIE = delegate
			{
				GBMPBBHCBDA = JCPNNEMGBIG().x;
				if (FKAKCFNGDGL != null)
				{
					FKAKCFNGDGL.color = new Color(FKAKCFNGDGL.color.r, FKAKCFNGDGL.color.g, FKAKCFNGDGL.color.b, GBMPBBHCBDA);
					KMIABEEOBCN(LOEHKHINJAH, GBMPBBHCBDA);
				}
				else
				{
					AFOIANIOMBH(LOEHKHINJAH, GBMPBBHCBDA, DAGIGIBOMLH);
				}
			};
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			if (FKAKCFNGDGL != null)
			{
				FKAKCFNGDGL.color = new Color(FKAKCFNGDGL.color.r, FKAKCFNGDGL.color.g, FKAKCFNGDGL.color.b, GBMPBBHCBDA);
				KMIABEEOBCN(LOEHKHINJAH, GBMPBBHCBDA);
			}
			else
			{
				AFOIANIOMBH(LOEHKHINJAH, GBMPBBHCBDA, DAGIGIBOMLH);
			}
		};
		return this;
	}

	[CompilerGenerated]
	private void OOMCDPMGENE()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.localScale.y;
	}

	[CompilerGenerated]
	private void EAKLGDFGMHD()
	{
		LOEHKHINJAH.localScale = new Vector3(LOEHKHINJAH.localScale.x, JCPNNEMGBIG().x, LOEHKHINJAH.localScale.z);
	}

	public BMDIMDNILIM EFCCPEOLAHL()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE_SPLINE_LOCAL;
		CPCNFMJIGNM = AGPEIMKKHML;
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			if (DFBBNCIMAFE.LMEJPKDKMEN.orientToPath)
			{
				if (DFBBNCIMAFE.LMEJPKDKMEN.orientToPath2d)
				{
					DFBBNCIMAFE.LMEJPKDKMEN.FEAMPOAHCGC(LOEHKHINJAH, GBMPBBHCBDA);
				}
				else
				{
					DFBBNCIMAFE.LMEJPKDKMEN.PGINPBGPAFP(LOEHKHINJAH, GBMPBBHCBDA);
				}
			}
			else
			{
				LOEHKHINJAH.localPosition = DFBBNCIMAFE.LMEJPKDKMEN.CNBPFDEFCEK(GBMPBBHCBDA);
			}
		};
		return this;
	}

	public BMDIMDNILIM PFDIBHBCKDP()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.ALPHA_VERTEX;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = (int)LOEHKHINJAH.GetComponent<MeshFilter>().mesh.colors32[0].a;
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			Mesh mesh = LOEHKHINJAH.GetComponent<MeshFilter>().mesh;
			Vector3[] vertices = mesh.vertices;
			Color32[] array = new Color32[vertices.Length];
			if (array.Length == 0)
			{
				Color32 color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0);
				array = new Color32[mesh.vertices.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = color;
				}
				mesh.colors32 = array;
			}
			Color32 color2 = mesh.colors32[0];
			color2 = new Color((int)color2.r, (int)color2.g, (int)color2.b, GBMPBBHCBDA);
			for (int j = 0; j < vertices.Length; j++)
			{
				array[j] = color2;
			}
			mesh.colors32 = array;
		};
		return this;
	}

	public BMDIMDNILIM NHMBFKFADAH(float KIKJLHMONDO)
	{
		this.KIKJLHMONDO = KIKJLHMONDO;
		return this;
	}

	public BMDIMDNILIM KLADPNNGKAH()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.SCALE_Z;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.localScale.z;
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.localScale = new Vector3(LOEHKHINJAH.localScale.x, LOEHKHINJAH.localScale.y, JCPNNEMGBIG().x);
		};
		return this;
	}

	private Vector3 HOOILOEKCKC()
	{
		GBMPBBHCBDA = MMOFNOOHHDM * MMOFNOOHHDM * MMOFNOOHHDM;
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	[CompilerGenerated]
	private void MPNMJAPFIAB()
	{
		HIECNNGMKIE = DFBBNCIMAFE.NGAFDIIEGJK.position;
		OBEJEJKJNAB = HIECNNGMKIE - KHKPNLDKEPI;
		LOJJNGOHPKJ = OBEJEJKJNAB * 0.5f;
		DMCLLHJDNLG = JCPNNEMGBIG();
		LOEHKHINJAH.position = DMCLLHJDNLG;
	}

	private void MHLNMMGDOJB()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		int num = (int)Mathf.Round(GBMPBBHCBDA);
		ADFBMONHJCI.sprite = OMLBFIOPPNI[num];
	}

	public BMDIMDNILIM IJLDJAKBIHE(Vector3 HDNOFOIOENF)
	{
		DFBBNCIMAFE.HDNOFOIOENF = HDNOFOIOENF;
		return this;
	}

	private void BJMMOOGDEMO()
	{
		IMIHNEKGMPK = 0f;
		PLAKEDCBHGH.x = 0f;
		DFBBNCIMAFE.HMINCLEHAAE = DHCIKBOPGNF.rotation;
	}

	[CompilerGenerated]
	private void FNPMFJGIJPL()
	{
		LOEHKHINJAH.eulerAngles = new Vector3(JCPNNEMGBIG().x, LOEHKHINJAH.eulerAngles.y, LOEHKHINJAH.eulerAngles.z);
	}

	private Vector3 CODLLCEKBIN()
	{
		GBMPBBHCBDA = Mathf.Pow(2f, 10f * (MMOFNOOHHDM - 1f));
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	[CompilerGenerated]
	private void IFKHHLEDNLC()
	{
		KHKPNLDKEPI = LOEHKHINJAH.position;
	}

	public void FNMADIHHMKA()
	{
		IBNEHJPJFIL = (DAGIGIBOMLH = (LCJODMHCGIB = true));
		LOEHKHINJAH = null;
		FKAKCFNGDGL = null;
		GANCKAFBCGO = (FNJNKEADGAM = (IMIHNEKGMPK = 0f));
		KKPJGPKIEBI = (KLLAFBMNKKM = (KNMBKPJJEAO = (MOBCAPKOLKP = (HJDDJJDCPGC = (HNALLPLCLKE = (JEAAIGMHMGI = (FLDOAKJEMNC = (MNJLPBBGPJI = false))))))));
		KGDBBGGCBKE = DEFBOFIHBCP.linear;
		HOFNENKKLMO = DEFBOFIHBCP.once;
		PGFGAOFOAOG = 0;
		GPEBLBKJFHC = (FLIGOJKJBEF = (DFBOMFPMKEF = (KIKJLHMONDO = 1f)));
		GFOKPCHDPMI = 0.3f;
		AACJOJOJMOH = -1f;
		JCPNNEMGBIG = HIOCCPOPKKK;
		Vector3 vector2 = KHKPNLDKEPI = (HIECNNGMKIE = Vector3.zero);
		DFBBNCIMAFE.FNMADIHHMKA();
	}

	public BMDIMDNILIM LGGEJMOEAAN()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.GUI_MOVE_MARGIN;
		CPCNFMJIGNM = delegate
		{
			KHKPNLDKEPI = new Vector2(DFBBNCIMAFE.KLEBOFBEKJJ.margin.x, DFBBNCIMAFE.KLEBOFBEKJJ.margin.y);
		};
		ALECMEFEFIE = delegate
		{
			Vector3 vector = JCPNNEMGBIG();
			DFBBNCIMAFE.KLEBOFBEKJJ.margin = new Vector2(vector.x, vector.y);
		};
		return this;
	}

	[CompilerGenerated]
	private void PGJGMIENKKO()
	{
		KHKPNLDKEPI = LOEHKHINJAH.position;
	}

	public BMDIMDNILIM NHMBFKFADAH()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.SCALE;
		CPCNFMJIGNM = delegate
		{
			KHKPNLDKEPI = LOEHKHINJAH.localScale;
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			LOEHKHINJAH.localScale = DMCLLHJDNLG;
		};
		return this;
	}

	public BMDIMDNILIM GNJDLINHKMH()
	{
		HOFNENKKLMO = DEFBOFIHBCP.clamp;
		if (PGFGAOFOAOG == 0)
		{
			PGFGAOFOAOG = -1;
		}
		return this;
	}

	public BMDIMDNILIM LFIGHNHNNDB(float GPEBLBKJFHC)
	{
		if (this.GPEBLBKJFHC != -1f && this.GPEBLBKJFHC != 1f)
		{
			Debug.LogWarning("You have passed an incorrect direction of '" + GPEBLBKJFHC + "', direction must be -1f or 1f");
			return this;
		}
		if (this.GPEBLBKJFHC != GPEBLBKJFHC)
		{
			if (MOBCAPKOLKP)
			{
				this.GPEBLBKJFHC = GPEBLBKJFHC;
			}
			else if (DFBBNCIMAFE.PFKHAKGHKPK != null)
			{
				DFBBNCIMAFE.PFKHAKGHKPK = new JNLGHEAGHNK(GGPMGEPBLJO.DLBHBNBLGKB(DFBBNCIMAFE.PFKHAKGHKPK.EANKHDIMBHC));
			}
			else if (DFBBNCIMAFE.LMEJPKDKMEN != null)
			{
				DFBBNCIMAFE.LMEJPKDKMEN = new LTSpline(GGPMGEPBLJO.DLBHBNBLGKB(DFBBNCIMAFE.LMEJPKDKMEN.pts));
			}
		}
		return this;
	}

	public BMDIMDNILIM NLPFFJCEOKG()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.TEXT_ALPHA;
		CPCNFMJIGNM = delegate
		{
			DOLLBOPGEPK = LOEHKHINJAH.GetComponent<Text>();
			PLAKEDCBHGH.x = ((DOLLBOPGEPK != null) ? DOLLBOPGEPK.color.a : 1f);
		};
		ALECMEFEFIE = delegate
		{
			IMICOALLJCH(LOEHKHINJAH, JCPNNEMGBIG().x, DAGIGIBOMLH);
		};
		return this;
	}

	[CompilerGenerated]
	private void FEEFFMBMILM()
	{
		KHKPNLDKEPI = new Vector3(DFBBNCIMAFE.KLEBOFBEKJJ.rect.x, DFBBNCIMAFE.KLEBOFBEKJJ.rect.y, 0f);
	}

	public BMDIMDNILIM FALFPLLNDIB(bool DAGIGIBOMLH)
	{
		this.DAGIGIBOMLH = DAGIGIBOMLH;
		return this;
	}

	public BMDIMDNILIM EKCDBNIOPBB()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.GUI_ROTATE;
		CPCNFMJIGNM = delegate
		{
			if (!DFBBNCIMAFE.KLEBOFBEKJJ.rotateEnabled)
			{
				DFBBNCIMAFE.KLEBOFBEKJJ.rotateEnabled = true;
				DFBBNCIMAFE.KLEBOFBEKJJ.BBDBMMGPMAO();
			}
			PLAKEDCBHGH.x = DFBBNCIMAFE.KLEBOFBEKJJ.rotation;
		};
		ALECMEFEFIE = delegate
		{
			DFBBNCIMAFE.KLEBOFBEKJJ.rotation = JCPNNEMGBIG().x;
		};
		return this;
	}

	public BMDIMDNILIM AFPIHAJCMOK(bool PPFLOLOAKIC)
	{
		NKNNELLLGHN(PPFLOLOAKIC);
		if (PKKHGLGLFMK == GFMDPMOPLPO.MOVE_CURVED || PKKHGLGLFMK == GFMDPMOPLPO.MOVE_CURVED_LOCAL)
		{
			DFBBNCIMAFE.PFKHAKGHKPK.NDPNNJEFLHO = PPFLOLOAKIC;
		}
		else
		{
			DFBBNCIMAFE.LMEJPKDKMEN.orientToPath2d = PPFLOLOAKIC;
		}
		return this;
	}

	public BMDIMDNILIM HGNGOPBNHAN()
	{
		HOFNENKKLMO = DEFBOFIHBCP.pingPong;
		if (PGFGAOFOAOG == 0)
		{
			PGFGAOFOAOG = -1;
		}
		return this;
	}

	public BMDIMDNILIM HKLIIBJDIBB(Sprite[] OMLBFIOPPNI)
	{
		this.OMLBFIOPPNI = OMLBFIOPPNI;
		return this;
	}

	public BMDIMDNILIM MNELFOFMPKF(int DEIOEDAILJO)
	{
		PGFGAOFOAOG = DEIOEDAILJO;
		if ((DEIOEDAILJO > 1 && HOFNENKKLMO == DEFBOFIHBCP.once) || (DEIOEDAILJO < 0 && HOFNENKKLMO == DEFBOFIHBCP.once))
		{
			HOFNENKKLMO = DEFBOFIHBCP.clamp;
		}
		if (PKKHGLGLFMK == GFMDPMOPLPO.CALLBACK || PKKHGLGLFMK == GFMDPMOPLPO.CALLBACK_COLOR)
		{
			EMAAGNHKFDE(HBMCHLOEDKF: true);
		}
		return this;
	}

	[CompilerGenerated]
	private void MDGLNEGNMBC()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		LOEHKHINJAH.eulerAngles = DMCLLHJDNLG;
	}

	private Vector3 JHNIDILGELJ()
	{
		GBMPBBHCBDA = MMOFNOOHHDM * 2f;
		if (GBMPBBHCBDA < 1f)
		{
			GBMPBBHCBDA *= GBMPBBHCBDA;
			return new Vector3(LOJJNGOHPKJ.x * GBMPBBHCBDA + KHKPNLDKEPI.x, LOJJNGOHPKJ.y * GBMPBBHCBDA + KHKPNLDKEPI.y, LOJJNGOHPKJ.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
		}
		GBMPBBHCBDA = (1f - GBMPBBHCBDA) * (GBMPBBHCBDA - 3f) + 1f;
		return new Vector3(LOJJNGOHPKJ.x * GBMPBBHCBDA + KHKPNLDKEPI.x, LOJJNGOHPKJ.y * GBMPBBHCBDA + KHKPNLDKEPI.y, LOJJNGOHPKJ.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	public BMDIMDNILIM PEMLGMNDACP()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInElastic;
		JCPNNEMGBIG = DKMGJMNOLFL;
		return this;
	}

	public BMDIMDNILIM CDGJGKHLCOO(float DFBOMFPMKEF)
	{
		this.DFBOMFPMKEF = DFBOMFPMKEF;
		return this;
	}

	public BMDIMDNILIM EKOOKPENPDF()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.linear;
		JCPNNEMGBIG = HIOCCPOPKKK;
		return this;
	}

	[CompilerGenerated]
	private void CGJDLLHODGM()
	{
		DHCIKBOPGNF.anchoredPosition3D = JCPNNEMGBIG();
	}

	private static void KMIABEEOBCN(Transform KKIIOFBKNKC, float GBMPBBHCBDA)
	{
		if (KKIIOFBKNKC.childCount <= 0)
		{
			return;
		}
		foreach (Transform item in KKIIOFBKNKC)
		{
			SpriteRenderer component = item.GetComponent<SpriteRenderer>();
			if (component != null)
			{
				component.color = new Color(component.color.r, component.color.g, component.color.b, GBMPBBHCBDA);
			}
			KMIABEEOBCN(item, GBMPBBHCBDA);
		}
	}

	public BMDIMDNILIM POJCNHMJPDF()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.ROTATE_Z;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.eulerAngles.z;
			NLBHGGANDMI.x = LeanTween.closestRot(PLAKEDCBHGH.x, NLBHGGANDMI.x);
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.eulerAngles = new Vector3(LOEHKHINJAH.eulerAngles.x, LOEHKHINJAH.eulerAngles.y, JCPNNEMGBIG().x);
		};
		return this;
	}

	public BMDIMDNILIM AKMNKDDCNMO()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeOutCirc;
		JCPNNEMGBIG = IDKMGDKDDME;
		return this;
	}

	private void LDHPCMKDEAO()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
	}

	public BMDIMDNILIM DMIGHJBGJPP(Action<Vector3> KDHFAGIFKAK)
	{
		DFBBNCIMAFE.EIEOAFKMBGM = KDHFAGIFKAK;
		KKPJGPKIEBI = true;
		return this;
	}

	[CompilerGenerated]
	private void CKLNCFOBLHA()
	{
		KHKPNLDKEPI = LOEHKHINJAH.eulerAngles;
		HIECNNGMKIE = new Vector3(LeanTween.closestRot(PLAKEDCBHGH.x, NLBHGGANDMI.x), LeanTween.closestRot(KHKPNLDKEPI.y, HIECNNGMKIE.y), LeanTween.closestRot(KHKPNLDKEPI.z, HIECNNGMKIE.z));
	}

	public BMDIMDNILIM OPKNAJPGNBK()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInOutExpo;
		JCPNNEMGBIG = IKFPJFOJMGP;
		return this;
	}

	public BMDIMDNILIM IPNKDHBCKJP(Transform LOEHKHINJAH)
	{
		JINOBHJPJAE.NGAFDIIEGJK = LOEHKHINJAH;
		return this;
	}

	public BMDIMDNILIM AAFAKALHCFM(object AAIFDHLAFPA)
	{
		DFBBNCIMAFE.JDIELBGOPJD = AAIFDHLAFPA;
		return this;
	}

	public BMDIMDNILIM FEIMAKEICNK()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CANVAS_ROTATEAROUND_LOCAL;
		CPCNFMJIGNM = BJMMOOGDEMO;
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			RectTransform dHCIKBOPGNF = DHCIKBOPGNF;
			Vector3 localPosition = dHCIKBOPGNF.localPosition;
			dHCIKBOPGNF.RotateAround(dHCIKBOPGNF.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK), dHCIKBOPGNF.TransformDirection(DFBBNCIMAFE.HDNOFOIOENF), 0f - GBMPBBHCBDA);
			Vector3 b = localPosition - dHCIKBOPGNF.localPosition;
			dHCIKBOPGNF.localPosition = localPosition - b;
			dHCIKBOPGNF.rotation = DFBBNCIMAFE.HMINCLEHAAE;
			dHCIKBOPGNF.RotateAround(dHCIKBOPGNF.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK), dHCIKBOPGNF.TransformDirection(DFBBNCIMAFE.HDNOFOIOENF), GBMPBBHCBDA);
		};
		return this;
	}

	public BMDIMDNILIM EMAAGNHKFDE(bool HBMCHLOEDKF)
	{
		HJDDJJDCPGC = HBMCHLOEDKF;
		return this;
	}

	public BMDIMDNILIM ICDPFCGAEGH()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInOutQuint;
		JCPNNEMGBIG = ENPJPDHLFIG;
		return this;
	}

	[CompilerGenerated]
	private void APFKFDMIJJA()
	{
		KHKPNLDKEPI = new Vector2(DFBBNCIMAFE.KLEBOFBEKJJ.margin.x, DFBBNCIMAFE.KLEBOFBEKJJ.margin.y);
	}

	public override string ToString()
	{
		return string.Concat((LOEHKHINJAH != null) ? ("name:" + LOEHKHINJAH.gameObject.name) : "gameObject:null", " toggle:", IBNEHJPJFIL.ToString(), " passed:", GANCKAFBCGO, " time:", MAEOCPAHAHA, " delay:", FNJNKEADGAM, " direction:", GPEBLBKJFHC, " from:", KHKPNLDKEPI, " to:", HIECNNGMKIE, " diff:", OBEJEJKJNAB, " type:", PKKHGLGLFMK, " ease:", KGDBBGGCBKE, " useEstimatedTime:", KLLAFBMNKKM.ToString(), " id:", LHCMMKLKDHH, " hasInitiliazed:", MOBCAPKOLKP.ToString());
	}

	[CompilerGenerated]
	private void PNEEGCKAEJG()
	{
		SpriteRenderer component = LOEHKHINJAH.GetComponent<SpriteRenderer>();
		if (component != null)
		{
			PLAKEDCBHGH.x = component.color.a;
		}
		else if (LOEHKHINJAH.GetComponent<Renderer>() != null && LOEHKHINJAH.GetComponent<Renderer>().material.HasProperty("_Color"))
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.GetComponent<Renderer>().material.color.a;
		}
		else if (LOEHKHINJAH.GetComponent<Renderer>() != null && LOEHKHINJAH.GetComponent<Renderer>().material.HasProperty("_TintColor"))
		{
			Color color = LOEHKHINJAH.GetComponent<Renderer>().material.GetColor("_TintColor");
			PLAKEDCBHGH.x = color.a;
		}
		else if (LOEHKHINJAH.childCount > 0)
		{
			foreach (Transform item in LOEHKHINJAH)
			{
				if (item.gameObject.GetComponent<Renderer>() != null)
				{
					Color color2 = item.gameObject.GetComponent<Renderer>().material.color;
					PLAKEDCBHGH.x = color2.a;
					break;
				}
			}
		}
		ALECMEFEFIE = delegate
		{
			GBMPBBHCBDA = JCPNNEMGBIG().x;
			if (FKAKCFNGDGL != null)
			{
				FKAKCFNGDGL.color = new Color(FKAKCFNGDGL.color.r, FKAKCFNGDGL.color.g, FKAKCFNGDGL.color.b, GBMPBBHCBDA);
				KMIABEEOBCN(LOEHKHINJAH, GBMPBBHCBDA);
			}
			else
			{
				AFOIANIOMBH(LOEHKHINJAH, GBMPBBHCBDA, DAGIGIBOMLH);
			}
		};
	}

	public BMDIMDNILIM HLGHPAAEJDK()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeOutQuad;
		JCPNNEMGBIG = NIKFCFNFOHH;
		return this;
	}

	[CompilerGenerated]
	private void INMCAHGNFIO()
	{
		PLAKEDCBHGH.x = 0f;
		DFBBNCIMAFE.HMINCLEHAAE = LOEHKHINJAH.localRotation;
	}

	public BMDIMDNILIM ACLAHMJGPBE()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInSine;
		JCPNNEMGBIG = BHAPALBHPHJ;
		return this;
	}

	public BMDIMDNILIM FONALENPCAI(Action<Vector2> KDHFAGIFKAK, object KPFPEAIAJMO = null)
	{
		DFBBNCIMAFE.IOGCAEHLCHD = KDHFAGIFKAK;
		KKPJGPKIEBI = true;
		if (KPFPEAIAJMO != null)
		{
			DFBBNCIMAFE.KPFPEAIAJMO = KPFPEAIAJMO;
		}
		return this;
	}

	[CompilerGenerated]
	private void LHPHAIKNDMJ()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		LOEHKHINJAH.position = DMCLLHJDNLG;
	}

	public BMDIMDNILIM LIEFGJKDOAN(Transform HIECNNGMKIE)
	{
		DFBBNCIMAFE.NGAFDIIEGJK = HIECNNGMKIE;
		return this;
	}

	private void ACLLPLIJFCE()
	{
		MOBCAPKOLKP = false;
		LCJODMHCGIB = (KLLAFBMNKKM || FLDOAKJEMNC || KNMBKPJJEAO);
		if (KNMBKPJJEAO)
		{
			JINOBHJPJAE.GPIHNCEGIEA = Time.frameCount;
		}
		if (MAEOCPAHAHA <= 1567f)
		{
			MAEOCPAHAHA = Mathf.Epsilon;
		}
		if (CPCNFMJIGNM != null)
		{
			CPCNFMJIGNM();
		}
		OBEJEJKJNAB = HIECNNGMKIE - KHKPNLDKEPI;
		LOJJNGOHPKJ = OBEJEJKJNAB * 587f;
		if (DFBBNCIMAFE.NMDGKEFOHPO != null)
		{
			DFBBNCIMAFE.OPPGEFLENIO()();
		}
		if (JEAAIGMHMGI)
		{
			FDNEENFMBMP();
		}
		if (AACJOJOJMOH >= 1184f)
		{
			GOAKCHMHPJL();
		}
	}

	public BMDIMDNILIM BMLMNAMBJCH()
	{
		PKKHGLGLFMK = (GFMDPMOPLPO)(-37);
		CPCNFMJIGNM = delegate
		{
		};
		ALECMEFEFIE = IOEEGIMFEIJ;
		return this;
	}

	public BMDIMDNILIM FONALENPCAI(Action<Color> KDHFAGIFKAK)
	{
		DFBBNCIMAFE.CNGNFPILFIH = KDHFAGIFKAK;
		KKPJGPKIEBI = true;
		return this;
	}

	[CompilerGenerated]
	private void KCHCEEGNDLA()
	{
		Vector3 anchoredPosition3D = DHCIKBOPGNF.anchoredPosition3D;
		DHCIKBOPGNF.anchoredPosition3D = new Vector3(anchoredPosition3D.x, JCPNNEMGBIG().x, anchoredPosition3D.z);
	}

	public BMDIMDNILIM OGHIDPAPOEN()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeOutQuint;
		JCPNNEMGBIG = LKMHAKIGMFK;
		return this;
	}

	public BMDIMDNILIM JOBDNPJMBJD()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.ROTATE_Y;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.eulerAngles.y;
			NLBHGGANDMI.x = LeanTween.closestRot(PLAKEDCBHGH.x, NLBHGGANDMI.x);
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.eulerAngles = new Vector3(LOEHKHINJAH.eulerAngles.x, JCPNNEMGBIG().x, LOEHKHINJAH.eulerAngles.z);
		};
		return this;
	}

	private static void KHOFOAMIMFH(Transform LOEHKHINJAH, Color LFEINPFBBOL)
	{
		if (LOEHKHINJAH.childCount <= 0)
		{
			return;
		}
		foreach (Transform item in LOEHKHINJAH)
		{
			Text component = item.GetComponent<Text>();
			if (component != null)
			{
				component.color = LFEINPFBBOL;
			}
			KHOFOAMIMFH(item, LFEINPFBBOL);
		}
	}

	[CompilerGenerated]
	private void CJHMLCCAKKM()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		if (ADFBMONHJCI != null)
		{
			Color color = ADFBMONHJCI.color;
			color.a = GBMPBBHCBDA;
			ADFBMONHJCI.color = color;
		}
		else if (JLECGOEFCFE != null)
		{
			Color color2 = JLECGOEFCFE.color;
			color2.a = GBMPBBHCBDA;
			JLECGOEFCFE.color = color2;
		}
		if (DAGIGIBOMLH)
		{
			AFOIANIOMBH(DHCIKBOPGNF, GBMPBBHCBDA);
			LHMKLBBDGDM(DHCIKBOPGNF, GBMPBBHCBDA);
		}
	}

	public BMDIMDNILIM ADADINLPDEA()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInQuart;
		JCPNNEMGBIG = MPLHGKDDEPN;
		return this;
	}

	private static void LIPNAADDJDD(Transform LOEHKHINJAH, Color LFEINPFBBOL)
	{
		if (LOEHKHINJAH.childCount <= 0)
		{
			return;
		}
		foreach (Transform item in LOEHKHINJAH)
		{
			Text component = item.GetComponent<Text>();
			if (component != null)
			{
				component.color = LFEINPFBBOL;
			}
			LIPNAADDJDD(item, LFEINPFBBOL);
		}
	}

	public BMDIMDNILIM FHEKMEELODA(Action<Color, object> KDHFAGIFKAK)
	{
		DFBBNCIMAFE.IBHANHJONKC = KDHFAGIFKAK;
		KKPJGPKIEBI = true;
		return this;
	}

	private static void CKNEACGDKJA(Transform KKIIOFBKNKC, Color LFEINPFBBOL, bool DAGIGIBOMLH = true)
	{
		Renderer component = KKIIOFBKNKC.gameObject.GetComponent<Renderer>();
		if (component != null)
		{
			Material[] materials = component.materials;
			for (int i = 0; i < materials.Length; i++)
			{
				materials[i].color = LFEINPFBBOL;
			}
		}
		if (!DAGIGIBOMLH || KKIIOFBKNKC.childCount <= 0)
		{
			return;
		}
		foreach (Transform item in KKIIOFBKNKC)
		{
			CKNEACGDKJA(item, LFEINPFBBOL);
		}
	}

	public BMDIMDNILIM FOJNBIEPKBA()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CANVAS_MOVE_Z;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = DHCIKBOPGNF.anchoredPosition3D.z;
		};
		ALECMEFEFIE = delegate
		{
			Vector3 anchoredPosition3D = DHCIKBOPGNF.anchoredPosition3D;
			DHCIKBOPGNF.anchoredPosition3D = new Vector3(anchoredPosition3D.x, anchoredPosition3D.y, JCPNNEMGBIG().x);
		};
		return this;
	}

	public BMDIMDNILIM CLNHDOOGNJH(float HPNMABOBEJB)
	{
		MAEOCPAHAHA = (float)OMLBFIOPPNI.Length / HPNMABOBEJB;
		return this;
	}

	public BMDIMDNILIM FLBCNONGLML()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.SCALE_X;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.localScale.x;
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.localScale = new Vector3(JCPNNEMGBIG().x, LOEHKHINJAH.localScale.y, LOEHKHINJAH.localScale.z);
		};
		return this;
	}

	public BMDIMDNILIM KILHNHHGJCD()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE_LOCAL;
		CPCNFMJIGNM = delegate
		{
			KHKPNLDKEPI = LOEHKHINJAH.localPosition;
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			LOEHKHINJAH.localPosition = DMCLLHJDNLG;
		};
		return this;
	}

	[CompilerGenerated]
	private void CCPCHFBNBHM()
	{
		DFBBNCIMAFE.KLEBOFBEKJJ.alpha = JCPNNEMGBIG().x;
	}

	public BMDIMDNILIM CAJMMFCONJA(Vector3 LJMAMFOPIKE)
	{
		NLBHGGANDMI = LJMAMFOPIKE;
		return this;
	}

	public BMDIMDNILIM FMGJHGIPOKE()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInOutQuad;
		JCPNNEMGBIG = JHNIDILGELJ;
		return this;
	}

	public BMDIMDNILIM OKBELODKELH()
	{
		HOFNENKKLMO = DEFBOFIHBCP.once;
		return this;
	}

	private Vector3 NJNBIDKMMIP()
	{
		GBMPBBHCBDA = MMOFNOOHHDM * 2f;
		if (GBMPBBHCBDA < 1f)
		{
			return new Vector3(LeanTween.easeInBounce(0f, OBEJEJKJNAB.x, GBMPBBHCBDA) * 0.5f + KHKPNLDKEPI.x, LeanTween.easeInBounce(0f, OBEJEJKJNAB.y, GBMPBBHCBDA) * 0.5f + KHKPNLDKEPI.y, LeanTween.easeInBounce(0f, OBEJEJKJNAB.z, GBMPBBHCBDA) * 0.5f + KHKPNLDKEPI.z);
		}
		GBMPBBHCBDA -= 1f;
		return new Vector3(LeanTween.easeOutBounce(0f, OBEJEJKJNAB.x, GBMPBBHCBDA) * 0.5f + LOJJNGOHPKJ.x + KHKPNLDKEPI.x, LeanTween.easeOutBounce(0f, OBEJEJKJNAB.y, GBMPBBHCBDA) * 0.5f + LOJJNGOHPKJ.y + KHKPNLDKEPI.y, LeanTween.easeOutBounce(0f, OBEJEJKJNAB.z, GBMPBBHCBDA) * 0.5f + LOJJNGOHPKJ.z + KHKPNLDKEPI.z);
	}

	[CompilerGenerated]
	private void BEEIMLKDDDM()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.localPosition.x;
	}

	private Vector3 EMCAIJABFHJ()
	{
		GBMPBBHCBDA = MMOFNOOHHDM;
		GBMPBBHCBDA /= 1f;
		float num = 1.70158f * DFBOMFPMKEF;
		return OBEJEJKJNAB * GBMPBBHCBDA * GBMPBBHCBDA * ((num + 1f) * GBMPBBHCBDA - num) + KHKPNLDKEPI;
	}

	private void PFFPFLDPBEF()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.localScale.x;
	}

	public BMDIMDNILIM AGDFBFFEEKM()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeOutQuad;
		JCPNNEMGBIG = BNACJBECDDO;
		return this;
	}

	[CompilerGenerated]
	private void MPBAABFCAGH()
	{
		LOEHKHINJAH.localScale = new Vector3(JCPNNEMGBIG().x, LOEHKHINJAH.localScale.y, LOEHKHINJAH.localScale.z);
	}

	[CompilerGenerated]
	private void OMNGCAMLAAK()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		int num = (int)Mathf.Round(GBMPBBHCBDA);
		ADFBMONHJCI.sprite = OMLBFIOPPNI[num];
	}

	public BMDIMDNILIM OMNGGFGCENG()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInOutQuart;
		JCPNNEMGBIG = NBCEHJOOEMG;
		return this;
	}

	private Vector3 ENPJPDHLFIG()
	{
		GBMPBBHCBDA = MMOFNOOHHDM * 2f;
		if (GBMPBBHCBDA < 1f)
		{
			GBMPBBHCBDA = GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA;
			return new Vector3(LOJJNGOHPKJ.x * GBMPBBHCBDA + KHKPNLDKEPI.x, LOJJNGOHPKJ.y * GBMPBBHCBDA + KHKPNLDKEPI.y, LOJJNGOHPKJ.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
		}
		GBMPBBHCBDA -= 2f;
		GBMPBBHCBDA = GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA + 2f;
		return new Vector3(LOJJNGOHPKJ.x * GBMPBBHCBDA + KHKPNLDKEPI.x, LOJJNGOHPKJ.y * GBMPBBHCBDA + KHKPNLDKEPI.y, LOJJNGOHPKJ.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	[CompilerGenerated]
	private void AOPKGFABOPI()
	{
		LOEHKHINJAH.eulerAngles = new Vector3(LOEHKHINJAH.eulerAngles.x, JCPNNEMGBIG().x, LOEHKHINJAH.eulerAngles.z);
	}

	public BMDIMDNILIM KDHNAGNJMLA()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CANVAS_COLOR;
		CPCNFMJIGNM = delegate
		{
			ADFBMONHJCI = LOEHKHINJAH.GetComponent<Image>();
			if (ADFBMONHJCI == null)
			{
				JLECGOEFCFE = LOEHKHINJAH.GetComponent<RawImage>();
				MCEKKFHGKIP((JLECGOEFCFE != null) ? JLECGOEFCFE.color : Color.white);
			}
			else
			{
				MCEKKFHGKIP(ADFBMONHJCI.color);
			}
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			Color color = BMCJJHIBLGJ(this, GBMPBBHCBDA);
			if (ADFBMONHJCI != null)
			{
				ADFBMONHJCI.color = color;
			}
			else if (JLECGOEFCFE != null)
			{
				JLECGOEFCFE.color = color;
			}
			if (KAFGFEOJLAM != 0f && DFBBNCIMAFE.CNGNFPILFIH != null)
			{
				DFBBNCIMAFE.CNGNFPILFIH(color);
			}
			if (DAGIGIBOMLH)
			{
				CKNEACGDKJA(DHCIKBOPGNF, color);
			}
		};
		return this;
	}

	[CompilerGenerated]
	private void OLGKOHDOLMK()
	{
		PLAKEDCBHGH.x = (int)LOEHKHINJAH.GetComponent<MeshFilter>().mesh.colors32[0].a;
	}

	public BMDIMDNILIM DJMALJJPPKD(bool KLLAFBMNKKM)
	{
		this.KLLAFBMNKKM = KLLAFBMNKKM;
		LCJODMHCGIB = false;
		return this;
	}

	public BMDIMDNILIM JMLNHLEEFHB(Rect MKCMDDIBJKN)
	{
		DFBBNCIMAFE.KLEBOFBEKJJ = new LTRect(MKCMDDIBJKN);
		return this;
	}

	public BMDIMDNILIM KEAHKHFFKAM()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeOutCubic;
		JCPNNEMGBIG = NIKFCFNFOHH;
		return this;
	}

	private void GOAKCHMHPJL()
	{
		if (PKKHGLGLFMK == GFMDPMOPLPO.MOVE_CURVED || PKKHGLGLFMK == GFMDPMOPLPO.MOVE_CURVED_LOCAL)
		{
			MAEOCPAHAHA = DFBBNCIMAFE.PFKHAKGHKPK.INGPEPLNFPA / AACJOJOJMOH;
		}
		else if (PKKHGLGLFMK == GFMDPMOPLPO.MOVE_SPLINE || PKKHGLGLFMK == GFMDPMOPLPO.MOVE_SPLINE_LOCAL)
		{
			MAEOCPAHAHA = DFBBNCIMAFE.LMEJPKDKMEN.distance / AACJOJOJMOH;
		}
		else
		{
			MAEOCPAHAHA = (HIECNNGMKIE - KHKPNLDKEPI).magnitude / AACJOJOJMOH;
		}
	}

	[CompilerGenerated]
	private void HJAMJMAJHHD()
	{
		PLAKEDCBHGH.x = DHCIKBOPGNF.anchoredPosition3D.z;
	}

	private Vector3 BNACJBECDDO()
	{
		GBMPBBHCBDA = MMOFNOOHHDM;
		GBMPBBHCBDA = (0f - GBMPBBHCBDA) * (GBMPBBHCBDA - 2f);
		return OBEJEJKJNAB * GBMPBBHCBDA + KHKPNLDKEPI;
	}

	private void BMDFHEHKMFM()
	{
		MOBCAPKOLKP = true;
		LCJODMHCGIB = (!KLLAFBMNKKM && !FLDOAKJEMNC && !KNMBKPJJEAO);
		if (KNMBKPJJEAO)
		{
			JINOBHJPJAE.GPIHNCEGIEA = Time.frameCount;
		}
		if (MAEOCPAHAHA <= 0f)
		{
			MAEOCPAHAHA = Mathf.Epsilon;
		}
		if (CPCNFMJIGNM != null)
		{
			CPCNFMJIGNM();
		}
		OBEJEJKJNAB = HIECNNGMKIE - KHKPNLDKEPI;
		LOJJNGOHPKJ = OBEJEJKJNAB * 0.5f;
		if (DFBBNCIMAFE.NMDGKEFOHPO != null)
		{
			DFBBNCIMAFE.NMDGKEFOHPO();
		}
		if (JEAAIGMHMGI)
		{
			FDNEENFMBMP();
		}
		if (AACJOJOJMOH >= 0f)
		{
			GOAKCHMHPJL();
		}
	}

	[CompilerGenerated]
	private void DGNKHKJJKCO()
	{
		SpriteRenderer component = LOEHKHINJAH.GetComponent<SpriteRenderer>();
		if (component != null)
		{
			MCEKKFHGKIP(component.color);
		}
		else if (LOEHKHINJAH.GetComponent<Renderer>() != null && LOEHKHINJAH.GetComponent<Renderer>().material.HasProperty("_Color"))
		{
			Color color = LOEHKHINJAH.GetComponent<Renderer>().material.color;
			MCEKKFHGKIP(color);
		}
		else if (LOEHKHINJAH.GetComponent<Renderer>() != null && LOEHKHINJAH.GetComponent<Renderer>().material.HasProperty("_TintColor"))
		{
			Color color2 = LOEHKHINJAH.GetComponent<Renderer>().material.GetColor("_TintColor");
			MCEKKFHGKIP(color2);
		}
		else
		{
			if (LOEHKHINJAH.childCount <= 0)
			{
				return;
			}
			foreach (Transform item in LOEHKHINJAH)
			{
				if (item.gameObject.GetComponent<Renderer>() != null)
				{
					Color color3 = item.gameObject.GetComponent<Renderer>().material.color;
					MCEKKFHGKIP(color3);
					break;
				}
			}
		}
	}

	public BMDIMDNILIM DPNCPOGHHLF()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE_CURVED;
		CPCNFMJIGNM = AGPEIMKKHML;
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			if (DFBBNCIMAFE.PFKHAKGHKPK.HCJCJDJEFAD)
			{
				if (DFBBNCIMAFE.PFKHAKGHKPK.NDPNNJEFLHO)
				{
					DFBBNCIMAFE.PFKHAKGHKPK.GKKDJKIJEIJ(LOEHKHINJAH, GBMPBBHCBDA);
				}
				else
				{
					DFBBNCIMAFE.PFKHAKGHKPK.NGFEAGKGPLB(LOEHKHINJAH, GBMPBBHCBDA);
				}
			}
			else
			{
				LOEHKHINJAH.position = DFBBNCIMAFE.PFKHAKGHKPK.CNBPFDEFCEK(GBMPBBHCBDA);
			}
		};
		return this;
	}

	private Vector3 MCKNIKBLDBG()
	{
		float num = 1.70158f * DFBOMFPMKEF;
		GBMPBBHCBDA = MMOFNOOHHDM * 2f;
		if (GBMPBBHCBDA < 1f)
		{
			num *= 1.525f * DFBOMFPMKEF;
			return LOJJNGOHPKJ * (GBMPBBHCBDA * GBMPBBHCBDA * ((num + 1f) * GBMPBBHCBDA - num)) + KHKPNLDKEPI;
		}
		GBMPBBHCBDA -= 2f;
		num *= 1.525f * DFBOMFPMKEF;
		GBMPBBHCBDA = GBMPBBHCBDA * GBMPBBHCBDA * ((num + 1f) * GBMPBBHCBDA + num) + 2f;
		return LOJJNGOHPKJ * GBMPBBHCBDA + KHKPNLDKEPI;
	}

	public BMDIMDNILIM DLFMPNFCEFM()
	{
		if (GPEBLBKJFHC != 0f)
		{
			FLIGOJKJBEF = GPEBLBKJFHC;
			GPEBLBKJFHC = 0f;
		}
		return this;
	}

	public BMDIMDNILIM NEOMEAEOJCA()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.GUI_SCALE;
		CPCNFMJIGNM = delegate
		{
			KHKPNLDKEPI = new Vector3(DFBBNCIMAFE.KLEBOFBEKJJ.rect.width, DFBBNCIMAFE.KLEBOFBEKJJ.rect.height, 0f);
		};
		ALECMEFEFIE = delegate
		{
			Vector3 vector = JCPNNEMGBIG();
			DFBBNCIMAFE.KLEBOFBEKJJ.rect = new Rect(DFBBNCIMAFE.KLEBOFBEKJJ.rect.x, DFBBNCIMAFE.KLEBOFBEKJJ.rect.y, vector.x, vector.y);
		};
		return this;
	}

	public BMDIMDNILIM MFCCAFFHJMN()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.SCALE_Y;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.localScale.y;
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.localScale = new Vector3(LOEHKHINJAH.localScale.x, JCPNNEMGBIG().x, LOEHKHINJAH.localScale.z);
		};
		return this;
	}

	[CompilerGenerated]
	private void MGFOCFAFCAH()
	{
		GBMPBBHCBDA = JCPNNEMGBIG().x;
		if (FKAKCFNGDGL != null)
		{
			FKAKCFNGDGL.color = new Color(FKAKCFNGDGL.color.r, FKAKCFNGDGL.color.g, FKAKCFNGDGL.color.b, GBMPBBHCBDA);
			KMIABEEOBCN(LOEHKHINJAH, GBMPBBHCBDA);
		}
		else
		{
			AFOIANIOMBH(LOEHKHINJAH, GBMPBBHCBDA, DAGIGIBOMLH);
		}
	}

	public BMDIMDNILIM APNDGOAIPFJ(AnimationCurve CIFNHCHOAHA)
	{
		DFBBNCIMAFE.AFEDAGPKMIE = CIFNHCHOAHA;
		JCPNNEMGBIG = KAAHGPCAEEL;
		KGDBBGGCBKE = DEFBOFIHBCP.animationCurve;
		return this;
	}

	[CompilerGenerated]
	private void CNOEJPBPKFI()
	{
		LOEHKHINJAH.localPosition = new Vector3(JCPNNEMGBIG().x, LOEHKHINJAH.localPosition.y, LOEHKHINJAH.localPosition.z);
	}

	[CompilerGenerated]
	private void COALJCLLAOB()
	{
		KHKPNLDKEPI = LOEHKHINJAH.localPosition;
	}

	[CompilerGenerated]
	private void BALDJLOKCOK()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		LOEHKHINJAH.localScale = DMCLLHJDNLG;
	}

	private static Color BMCJJHIBLGJ(BMDIMDNILIM OHBOANFANHJ, float GBMPBBHCBDA)
	{
		Vector3 vector = OHBOANFANHJ.DFBBNCIMAFE.CNBPFDEFCEK - OHBOANFANHJ.DFBBNCIMAFE.HDNOFOIOENF;
		float num = OHBOANFANHJ.HIECNNGMKIE.y - OHBOANFANHJ.KHKPNLDKEPI.y;
		return new Color(OHBOANFANHJ.DFBBNCIMAFE.HDNOFOIOENF.x + vector.x * GBMPBBHCBDA, OHBOANFANHJ.DFBBNCIMAFE.HDNOFOIOENF.y + vector.y * GBMPBBHCBDA, OHBOANFANHJ.DFBBNCIMAFE.HDNOFOIOENF.z + vector.z * GBMPBBHCBDA, OHBOANFANHJ.KHKPNLDKEPI.y + num * GBMPBBHCBDA);
	}

	public BMDIMDNILIM NCIOPMHFIEK()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInCubic;
		JCPNNEMGBIG = HOOILOEKCKC;
		return this;
	}

	public BMDIMDNILIM CKFINBBONEK()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeOutExpo;
		JCPNNEMGBIG = OJPEFNAKLPE;
		return this;
	}

	[Obsolete("Use 'LeanTween.cancel( id )' instead")]
	public BMDIMDNILIM OPLPOEGCPAE(GameObject GKHONGJMCLB)
	{
		if (GKHONGJMCLB == LOEHKHINJAH.gameObject)
		{
			LeanTween.removeTween((int)LFMLPGGGPMK, EPAEGFCEIIG);
		}
		return this;
	}

	public BMDIMDNILIM CCOAIGABCPH()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeOutBounce;
		JCPNNEMGBIG = GJHLBNHMDOM;
		return this;
	}

	public BMDIMDNILIM MLCPFKNPENM(float AACJOJOJMOH)
	{
		this.AACJOJOJMOH = AACJOJOJMOH;
		if (MOBCAPKOLKP)
		{
			GOAKCHMHPJL();
		}
		return this;
	}

	[CompilerGenerated]
	private void OPDPMNCCKJI()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.localPosition.y;
	}

	public BMDIMDNILIM HGNGOPBNHAN(int OLBLCDEMIEM)
	{
		HOFNENKKLMO = DEFBOFIHBCP.pingPong;
		PGFGAOFOAOG = ((OLBLCDEMIEM == -1) ? OLBLCDEMIEM : (OLBLCDEMIEM * 2));
		return this;
	}

	[CompilerGenerated]
	private void JBMBCKPOBBM()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		Vector3 localPosition = LOEHKHINJAH.localPosition;
		Vector3 point = LOEHKHINJAH.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK);
		LOEHKHINJAH.RotateAround(point, DFBBNCIMAFE.HDNOFOIOENF, 0f - DFBBNCIMAFE.IMIHNEKGMPK);
		Vector3 b = localPosition - LOEHKHINJAH.localPosition;
		LOEHKHINJAH.localPosition = localPosition - b;
		LOEHKHINJAH.rotation = DFBBNCIMAFE.HMINCLEHAAE;
		point = LOEHKHINJAH.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK);
		LOEHKHINJAH.RotateAround(point, DFBBNCIMAFE.HDNOFOIOENF, GBMPBBHCBDA);
		DFBBNCIMAFE.IMIHNEKGMPK = GBMPBBHCBDA;
	}

	public BMDIMDNILIM NKHOIHPKCPK()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeOutQuart;
		JCPNNEMGBIG = DHBPOKJCEGP;
		return this;
	}

	private Vector3 NIKFPOLJNNP()
	{
		GBMPBBHCBDA = MMOFNOOHHDM;
		GBMPBBHCBDA = GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA;
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	private Vector3 DHBPOKJCEGP()
	{
		GBMPBBHCBDA = MMOFNOOHHDM - 1f;
		GBMPBBHCBDA = 0f - (GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA - 1f);
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	[CompilerGenerated]
	private void MEHFDJHGIMN()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.localScale.x;
	}

	[CompilerGenerated]
	private void PGKJKOHBJFB()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		LOEHKHINJAH.localEulerAngles = DMCLLHJDNLG;
	}

	[CompilerGenerated]
	private void BHBEKIEEGOK()
	{
		Vector3 vector = JCPNNEMGBIG();
		DFBBNCIMAFE.KLEBOFBEKJJ.rect = new Rect(DFBBNCIMAFE.KLEBOFBEKJJ.rect.x, DFBBNCIMAFE.KLEBOFBEKJJ.rect.y, vector.x, vector.y);
	}

	private static void HJDEEAPKIGB(Transform KKIIOFBKNKC, Color LFEINPFBBOL)
	{
		if (KKIIOFBKNKC.childCount <= 0)
		{
			return;
		}
		foreach (Transform item in KKIIOFBKNKC)
		{
			SpriteRenderer component = KKIIOFBKNKC.gameObject.GetComponent<SpriteRenderer>();
			if (component != null)
			{
				component.color = LFEINPFBBOL;
			}
			HJDEEAPKIGB(item, LFEINPFBBOL);
		}
	}

	public BMDIMDNILIM PAOMHBEMPAJ(bool HBMCHLOEDKF)
	{
		JEAAIGMHMGI = HBMCHLOEDKF;
		return this;
	}

	public BMDIMDNILIM NBMNLEHNJBH()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeSpring;
		JCPNNEMGBIG = EHCAECDGJCA;
		return this;
	}

	public BMDIMDNILIM KFBDOGPJMEE()
	{
		PKKHGLGLFMK = (GFMDPMOPLPO)92;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = DHCIKBOPGNF.anchoredPosition3D.y;
		};
		ALECMEFEFIE = delegate
		{
			Vector3 anchoredPosition3D = DHCIKBOPGNF.anchoredPosition3D;
			DHCIKBOPGNF.anchoredPosition3D = new Vector3(anchoredPosition3D.x, JCPNNEMGBIG().x, anchoredPosition3D.z);
		};
		return this;
	}

	private Vector3 IKFPJFOJMGP()
	{
		GBMPBBHCBDA = MMOFNOOHHDM * 2f;
		if (GBMPBBHCBDA < 1f)
		{
			return LOJJNGOHPKJ * Mathf.Pow(2f, 10f * (GBMPBBHCBDA - 1f)) + KHKPNLDKEPI;
		}
		GBMPBBHCBDA -= 1f;
		return LOJJNGOHPKJ * (0f - Mathf.Pow(2f, -10f * GBMPBBHCBDA) + 2f) + KHKPNLDKEPI;
	}

	public BMDIMDNILIM HAHDJIKDABG(int PGFGAOFOAOG)
	{
		HOFNENKKLMO = DEFBOFIHBCP.clamp;
		this.PGFGAOFOAOG = PGFGAOFOAOG;
		return this;
	}

	private void HEDIICGEAAA()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		if (DFBBNCIMAFE.EKHCIFPNJIM().HCJCJDJEFAD)
		{
			if (DFBBNCIMAFE.PFKHAKGHKPK.NDPNNJEFLHO)
			{
				DFBBNCIMAFE.EKHCIFPNJIM().LPGPHJBCKJC(LOEHKHINJAH, GBMPBBHCBDA);
			}
			else
			{
				DFBBNCIMAFE.PFKHAKGHKPK.JHBGPHCLGFK(LOEHKHINJAH, GBMPBBHCBDA);
			}
		}
		else
		{
			LOEHKHINJAH.position = DFBBNCIMAFE.PFKHAKGHKPK.INOGNFIHDGI(GBMPBBHCBDA);
		}
	}

	public BMDIMDNILIM NKNNELLLGHN(bool FECFIDICLHH)
	{
		if (PKKHGLGLFMK == GFMDPMOPLPO.MOVE_CURVED || PKKHGLGLFMK == GFMDPMOPLPO.MOVE_CURVED_LOCAL)
		{
			if (DFBBNCIMAFE.PFKHAKGHKPK == null)
			{
				DFBBNCIMAFE.PFKHAKGHKPK = new JNLGHEAGHNK();
			}
			DFBBNCIMAFE.PFKHAKGHKPK.HCJCJDJEFAD = FECFIDICLHH;
		}
		else
		{
			DFBBNCIMAFE.LMEJPKDKMEN.orientToPath = FECFIDICLHH;
		}
		return this;
	}

	private Vector3 DKMGJMNOLFL()
	{
		return new Vector3(LeanTween.easeInElastic(KHKPNLDKEPI.x, HIECNNGMKIE.x, MMOFNOOHHDM, DFBOMFPMKEF, GFOKPCHDPMI), LeanTween.easeInElastic(KHKPNLDKEPI.y, HIECNNGMKIE.y, MMOFNOOHHDM, DFBOMFPMKEF, GFOKPCHDPMI), LeanTween.easeInElastic(KHKPNLDKEPI.z, HIECNNGMKIE.z, MMOFNOOHHDM, DFBOMFPMKEF, GFOKPCHDPMI));
	}

	private void GLJNONMNFEL()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		int num = (int)Mathf.Round(GBMPBBHCBDA);
		ADFBMONHJCI.sprite = OMLBFIOPPNI[num];
	}

	public BMDIMDNILIM NJPLJADPKAG()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInBack;
		JCPNNEMGBIG = EMCAIJABFHJ;
		return this;
	}

	public bool PAOBFLPOJIC()
	{
		float gPEBLBKJFHC = GPEBLBKJFHC;
		if (LCJODMHCGIB)
		{
			KAFGFEOJLAM = LeanTween.dtActual;
		}
		else if (KLLAFBMNKKM)
		{
			KAFGFEOJLAM = LeanTween.dtEstimated;
		}
		else if (KNMBKPJJEAO)
		{
			KAFGFEOJLAM = ((JINOBHJPJAE.GPIHNCEGIEA != 0) ? 1 : 0);
			JINOBHJPJAE.GPIHNCEGIEA = Time.frameCount;
		}
		else if (FLDOAKJEMNC)
		{
			KAFGFEOJLAM = LeanTween.dtManual;
		}
		if (FNJNKEADGAM <= 0f && gPEBLBKJFHC != 0f)
		{
			if (LOEHKHINJAH == null)
			{
				return true;
			}
			if (!MOBCAPKOLKP)
			{
				BMDFHEHKMFM();
			}
			KAFGFEOJLAM *= gPEBLBKJFHC;
			GANCKAFBCGO += KAFGFEOJLAM;
			GANCKAFBCGO = Mathf.Clamp(GANCKAFBCGO, 0f, MAEOCPAHAHA);
			MMOFNOOHHDM = GANCKAFBCGO / MAEOCPAHAHA;
			ALECMEFEFIE();
			if (KKPJGPKIEBI)
			{
				DFBBNCIMAFE.KJDMKFLBELF(GBMPBBHCBDA, MMOFNOOHHDM);
			}
			if ((gPEBLBKJFHC > 0f) ? (GANCKAFBCGO >= MAEOCPAHAHA) : (GANCKAFBCGO <= 0f))
			{
				PGFGAOFOAOG--;
				if (HOFNENKKLMO == DEFBOFIHBCP.pingPong)
				{
					GPEBLBKJFHC = 0f - gPEBLBKJFHC;
				}
				else
				{
					GANCKAFBCGO = Mathf.Epsilon;
				}
				bool num = PGFGAOFOAOG == 0 || HOFNENKKLMO == DEFBOFIHBCP.once;
				if (!num && HJDDJJDCPGC && MNJLPBBGPJI)
				{
					FDNEENFMBMP();
				}
				return num;
			}
		}
		else
		{
			FNJNKEADGAM -= KAFGFEOJLAM;
		}
		return false;
	}

	public BMDIMDNILIM NBIAIGACNGK(bool DIJDMFFJBMH)
	{
		MOBCAPKOLKP = DIJDMFFJBMH;
		return this;
	}

	public BMDIMDNILIM EIBDAABHLOO()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CALLBACK;
		CPCNFMJIGNM = delegate
		{
		};
		ALECMEFEFIE = LDHPCMKDEAO;
		return this;
	}

	private void IOEEGIMFEIJ()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
	}

	private Vector3 MPLHGKDDEPN()
	{
		GBMPBBHCBDA = MMOFNOOHHDM * MMOFNOOHHDM * MMOFNOOHHDM * MMOFNOOHHDM;
		return OBEJEJKJNAB * GBMPBBHCBDA + KHKPNLDKEPI;
	}

	[CompilerGenerated]
	private void LDJPPKNKECN()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		if (FKAKCFNGDGL != null)
		{
			FKAKCFNGDGL.color = new Color(FKAKCFNGDGL.color.r, FKAKCFNGDGL.color.g, FKAKCFNGDGL.color.b, GBMPBBHCBDA);
			KMIABEEOBCN(LOEHKHINJAH, GBMPBBHCBDA);
		}
		else
		{
			AFOIANIOMBH(LOEHKHINJAH, GBMPBBHCBDA, DAGIGIBOMLH);
		}
	}

	[CompilerGenerated]
	private void NEGHFNNPGLP()
	{
		LOEHKHINJAH.position = new Vector3(JCPNNEMGBIG().x, LOEHKHINJAH.position.y, LOEHKHINJAH.position.z);
	}

	[CompilerGenerated]
	private void GMEBHAIPDCN()
	{
		Vector3 vector = JCPNNEMGBIG();
		DFBBNCIMAFE.KLEBOFBEKJJ.margin = new Vector2(vector.x, vector.y);
	}

	private void DOPAKHCPNKF()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.eulerAngles.z;
		NLBHGGANDMI.x = LeanTween.closestRot(PLAKEDCBHGH.x, NLBHGGANDMI.x);
	}

	private Vector3 PIHECCBKFJG()
	{
		float num = 1.70158f * DFBOMFPMKEF;
		GBMPBBHCBDA = MMOFNOOHHDM / 1f - 1f;
		GBMPBBHCBDA = GBMPBBHCBDA * GBMPBBHCBDA * ((num + 1f) * GBMPBBHCBDA + num) + 1f;
		return OBEJEJKJNAB * GBMPBBHCBDA + KHKPNLDKEPI;
	}

	[CompilerGenerated]
	private void HIBAPHHLHLD()
	{
		LOEHKHINJAH.eulerAngles = new Vector3(LOEHKHINJAH.eulerAngles.x, LOEHKHINJAH.eulerAngles.y, JCPNNEMGBIG().x);
	}

	public BMDIMDNILIM PHJCDLFIJHK(object JDIELBGOPJD)
	{
		DFBBNCIMAFE.JDIELBGOPJD = JDIELBGOPJD;
		MNJLPBBGPJI = true;
		return this;
	}

	public BMDIMDNILIM FBAFBFNEABH(Vector3 HIECNNGMKIE)
	{
		if (MOBCAPKOLKP)
		{
			this.HIECNNGMKIE = HIECNNGMKIE;
			OBEJEJKJNAB = HIECNNGMKIE - KHKPNLDKEPI;
		}
		else
		{
			this.HIECNNGMKIE = HIECNNGMKIE;
		}
		return this;
	}

	[CompilerGenerated]
	private void PLAAKALEHHP()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		Color color = BMCJJHIBLGJ(this, GBMPBBHCBDA);
		DOLLBOPGEPK.color = color;
		if (KAFGFEOJLAM != 0f && DFBBNCIMAFE.CNGNFPILFIH != null)
		{
			DFBBNCIMAFE.CNGNFPILFIH(color);
		}
		if (DAGIGIBOMLH && LOEHKHINJAH.childCount > 0)
		{
			KHOFOAMIMFH(LOEHKHINJAH, color);
		}
	}

	public BMDIMDNILIM ENFPGJEHEOP()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CANVAS_MOVE_X;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = DHCIKBOPGNF.anchoredPosition3D.x;
		};
		ALECMEFEFIE = delegate
		{
			Vector3 anchoredPosition3D = DHCIKBOPGNF.anchoredPosition3D;
			DHCIKBOPGNF.anchoredPosition3D = new Vector3(JCPNNEMGBIG().x, anchoredPosition3D.y, anchoredPosition3D.z);
		};
		return this;
	}

	[CompilerGenerated]
	private void KPMOAMAJCKC()
	{
		PLAKEDCBHGH.x = DFBBNCIMAFE.KLEBOFBEKJJ.alpha;
	}

	public BMDIMDNILIM HFCKAOPNPBG(bool FLDOAKJEMNC)
	{
		this.FLDOAKJEMNC = FLDOAKJEMNC;
		LCJODMHCGIB = false;
		return this;
	}

	private Vector3 OJPEFNAKLPE()
	{
		GBMPBBHCBDA = 0f - Mathf.Pow(2f, -10f * MMOFNOOHHDM) + 1f;
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	public BMDIMDNILIM GJLDBLODHNL()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.ALPHA;
		CPCNFMJIGNM = delegate
		{
			SpriteRenderer component = LOEHKHINJAH.GetComponent<SpriteRenderer>();
			if (component != null)
			{
				PLAKEDCBHGH.x = component.color.a;
			}
			else if (LOEHKHINJAH.GetComponent<Renderer>() != null && LOEHKHINJAH.GetComponent<Renderer>().material.HasProperty("_Color"))
			{
				PLAKEDCBHGH.x = LOEHKHINJAH.GetComponent<Renderer>().material.color.a;
			}
			else if (LOEHKHINJAH.GetComponent<Renderer>() != null && LOEHKHINJAH.GetComponent<Renderer>().material.HasProperty("_TintColor"))
			{
				Color color = LOEHKHINJAH.GetComponent<Renderer>().material.GetColor("_TintColor");
				PLAKEDCBHGH.x = color.a;
			}
			else if (LOEHKHINJAH.childCount > 0)
			{
				foreach (Transform item in LOEHKHINJAH)
				{
					if (item.gameObject.GetComponent<Renderer>() != null)
					{
						Color color2 = item.gameObject.GetComponent<Renderer>().material.color;
						PLAKEDCBHGH.x = color2.a;
						break;
					}
				}
			}
			ALECMEFEFIE = delegate
			{
				GBMPBBHCBDA = JCPNNEMGBIG().x;
				if (FKAKCFNGDGL != null)
				{
					FKAKCFNGDGL.color = new Color(FKAKCFNGDGL.color.r, FKAKCFNGDGL.color.g, FKAKCFNGDGL.color.b, GBMPBBHCBDA);
					KMIABEEOBCN(LOEHKHINJAH, GBMPBBHCBDA);
				}
				else
				{
					AFOIANIOMBH(LOEHKHINJAH, GBMPBBHCBDA, DAGIGIBOMLH);
				}
			};
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			if (FKAKCFNGDGL != null)
			{
				FKAKCFNGDGL.color = new Color(FKAKCFNGDGL.color.r, FKAKCFNGDGL.color.g, FKAKCFNGDGL.color.b, GBMPBBHCBDA);
				KMIABEEOBCN(LOEHKHINJAH, GBMPBBHCBDA);
			}
			else
			{
				AFOIANIOMBH(LOEHKHINJAH, GBMPBBHCBDA, DAGIGIBOMLH);
			}
		};
		return this;
	}

	public BMDIMDNILIM IKFNBIBBKOJ()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE_X;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.position.x;
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.position = new Vector3(JCPNNEMGBIG().x, LOEHKHINJAH.position.y, LOEHKHINJAH.position.z);
		};
		return this;
	}

	[CompilerGenerated]
	private void LIFAHJDJMNI()
	{
		LOEHKHINJAH.localPosition = new Vector3(LOEHKHINJAH.localPosition.x, JCPNNEMGBIG().x, LOEHKHINJAH.localPosition.z);
	}

	private Vector3 FIJJFFAGLBM()
	{
		GBMPBBHCBDA = MMOFNOOHHDM * MMOFNOOHHDM;
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	public BMDIMDNILIM LLOKKFKDOPA()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CANVAS_ROTATEAROUND;
		CPCNFMJIGNM = BJMMOOGDEMO;
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			RectTransform dHCIKBOPGNF = DHCIKBOPGNF;
			Vector3 localPosition = dHCIKBOPGNF.localPosition;
			dHCIKBOPGNF.RotateAround(dHCIKBOPGNF.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK), DFBBNCIMAFE.HDNOFOIOENF, 0f - GBMPBBHCBDA);
			Vector3 b = localPosition - dHCIKBOPGNF.localPosition;
			dHCIKBOPGNF.localPosition = localPosition - b;
			dHCIKBOPGNF.rotation = DFBBNCIMAFE.HMINCLEHAAE;
			dHCIKBOPGNF.RotateAround(dHCIKBOPGNF.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK), DFBBNCIMAFE.HDNOFOIOENF, GBMPBBHCBDA);
		};
		return this;
	}

	[CompilerGenerated]
	private void PJMKDCDGJNO()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		LOEHKHINJAH.localPosition = DMCLLHJDNLG;
	}

	public BMDIMDNILIM DDCIADAKLGA()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.ROTATE_X;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.eulerAngles.x;
			NLBHGGANDMI.x = LeanTween.closestRot(PLAKEDCBHGH.x, NLBHGGANDMI.x);
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.eulerAngles = new Vector3(JCPNNEMGBIG().x, LOEHKHINJAH.eulerAngles.y, LOEHKHINJAH.eulerAngles.z);
		};
		return this;
	}

	public BMDIMDNILIM GDILFKDJNAJ()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CANVASGROUP_ALPHA;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.GetComponent<CanvasGroup>().alpha;
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.GetComponent<CanvasGroup>().alpha = JCPNNEMGBIG().x;
		};
		return this;
	}

	[CompilerGenerated]
	private void ADCFDJOOBOH()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		Color color = BMCJJHIBLGJ(this, GBMPBBHCBDA);
		if (FKAKCFNGDGL != null)
		{
			FKAKCFNGDGL.color = color;
			HJDEEAPKIGB(LOEHKHINJAH, color);
		}
		else if (PKKHGLGLFMK == GFMDPMOPLPO.COLOR)
		{
			CKNEACGDKJA(LOEHKHINJAH, color, DAGIGIBOMLH);
		}
		if (KAFGFEOJLAM != 0f && DFBBNCIMAFE.CNGNFPILFIH != null)
		{
			DFBBNCIMAFE.CNGNFPILFIH(color);
		}
		else if (KAFGFEOJLAM != 0f && DFBBNCIMAFE.IBHANHJONKC != null)
		{
			DFBBNCIMAFE.IBHANHJONKC(color, DFBBNCIMAFE.KPFPEAIAJMO);
		}
	}

	private Vector3 MNDDELLIKIA()
	{
		GBMPBBHCBDA = 0f - (Mathf.Sqrt(1f - MMOFNOOHHDM * MMOFNOOHHDM) - 1f);
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	public BMDIMDNILIM ALDPFKNMKMC()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInExpo;
		JCPNNEMGBIG = CODLLCEKBIN;
		return this;
	}

	private Vector3 NBCEHJOOEMG()
	{
		GBMPBBHCBDA = MMOFNOOHHDM * 2f;
		if (GBMPBBHCBDA < 1f)
		{
			GBMPBBHCBDA = GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA;
			return new Vector3(LOJJNGOHPKJ.x * GBMPBBHCBDA + KHKPNLDKEPI.x, LOJJNGOHPKJ.y * GBMPBBHCBDA + KHKPNLDKEPI.y, LOJJNGOHPKJ.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
		}
		GBMPBBHCBDA -= 2f;
		return -LOJJNGOHPKJ * (GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA - 2f) + KHKPNLDKEPI;
	}

	[CompilerGenerated]
	private void DNCCMLBNHFH()
	{
		OBEJEJKJNAB = new Vector3(1f, 0f, 0f);
	}

	[CompilerGenerated]
	private void FIBMADOHACK()
	{
		MNJLPBBGPJI = true;
	}

	public BMDIMDNILIM FMJJALAAPEL()
	{
		PKKHGLGLFMK = (GFMDPMOPLPO)117;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = (int)LOEHKHINJAH.GetComponent<MeshFilter>().mesh.colors32[0].a;
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			Mesh mesh = LOEHKHINJAH.GetComponent<MeshFilter>().mesh;
			Vector3[] vertices = mesh.vertices;
			Color32[] array = new Color32[vertices.Length];
			if (array.Length == 0)
			{
				Color32 color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0);
				array = new Color32[mesh.vertices.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = color;
				}
				mesh.colors32 = array;
			}
			Color32 color2 = mesh.colors32[0];
			color2 = new Color((int)color2.r, (int)color2.g, (int)color2.b, GBMPBBHCBDA);
			for (int j = 0; j < vertices.Length; j++)
			{
				array[j] = color2;
			}
			mesh.colors32 = array;
		};
		return this;
	}

	public void FDNEENFMBMP()
	{
		if (PKKHGLGLFMK == GFMDPMOPLPO.GUI_ROTATE)
		{
			DFBBNCIMAFE.KLEBOFBEKJJ.rotateFinished = true;
		}
		if (PKKHGLGLFMK == GFMDPMOPLPO.DELAYED_SOUND)
		{
			AudioSource.PlayClipAtPoint((AudioClip)DFBBNCIMAFE.JDIELBGOPJD, HIECNNGMKIE, KHKPNLDKEPI.x);
		}
		if (DFBBNCIMAFE.NBBHOMIKJIL != null)
		{
			DFBBNCIMAFE.NBBHOMIKJIL();
		}
		else if (DFBBNCIMAFE.CLJPNGGBPOC != null)
		{
			DFBBNCIMAFE.CLJPNGGBPOC(DFBBNCIMAFE.JDIELBGOPJD);
		}
	}

	[CompilerGenerated]
	private void PKDLDFKGCIC()
	{
		LOEHKHINJAH.localScale = new Vector3(LOEHKHINJAH.localScale.x, LOEHKHINJAH.localScale.y, JCPNNEMGBIG().x);
	}

	public BMDIMDNILIM APNDGOAIPFJ(DEFBOFIHBCP KGDBBGGCBKE)
	{
		switch (KGDBBGGCBKE)
		{
		case DEFBOFIHBCP.linear:
			EKOOKPENPDF();
			break;
		case DEFBOFIHBCP.easeOutQuad:
			AGDFBFFEEKM();
			break;
		case DEFBOFIHBCP.easeInQuad:
			LHAGNILGJOB();
			break;
		case DEFBOFIHBCP.easeInOutQuad:
			FMGJHGIPOKE();
			break;
		case DEFBOFIHBCP.easeInCubic:
			NCIOPMHFIEK();
			break;
		case DEFBOFIHBCP.easeOutCubic:
			KEAHKHFFKAM();
			break;
		case DEFBOFIHBCP.easeInOutCubic:
			IPNCNOLINLE();
			break;
		case DEFBOFIHBCP.easeInQuart:
			ADADINLPDEA();
			break;
		case DEFBOFIHBCP.easeOutQuart:
			NKHOIHPKCPK();
			break;
		case DEFBOFIHBCP.easeInOutQuart:
			OMNGGFGCENG();
			break;
		case DEFBOFIHBCP.easeInQuint:
			HPCLDLMLPMN();
			break;
		case DEFBOFIHBCP.easeOutQuint:
			OGHIDPAPOEN();
			break;
		case DEFBOFIHBCP.easeInOutQuint:
			ICDPFCGAEGH();
			break;
		case DEFBOFIHBCP.easeInSine:
			ACLAHMJGPBE();
			break;
		case DEFBOFIHBCP.easeOutSine:
			PCLAIHEEEDP();
			break;
		case DEFBOFIHBCP.easeInOutSine:
			MOGFPOAAECP();
			break;
		case DEFBOFIHBCP.easeInExpo:
			ALDPFKNMKMC();
			break;
		case DEFBOFIHBCP.easeOutExpo:
			CKFINBBONEK();
			break;
		case DEFBOFIHBCP.easeInOutExpo:
			OPKNAJPGNBK();
			break;
		case DEFBOFIHBCP.easeInCirc:
			OMLNAPJHKEJ();
			break;
		case DEFBOFIHBCP.easeOutCirc:
			AKMNKDDCNMO();
			break;
		case DEFBOFIHBCP.easeInOutCirc:
			PHPEEDJBMAA();
			break;
		case DEFBOFIHBCP.easeInBounce:
			BJGOJFCGJCC();
			break;
		case DEFBOFIHBCP.easeOutBounce:
			CCOAIGABCPH();
			break;
		case DEFBOFIHBCP.easeInOutBounce:
			JMHNKGBOLLN();
			break;
		case DEFBOFIHBCP.easeInBack:
			NJPLJADPKAG();
			break;
		case DEFBOFIHBCP.easeOutBack:
			ECIIDIMPJNA();
			break;
		case DEFBOFIHBCP.easeInOutBack:
			PLFAHIMEGLC();
			break;
		case DEFBOFIHBCP.easeInElastic:
			PEMLGMNDACP();
			break;
		case DEFBOFIHBCP.easeOutElastic:
			IADGAKNCMIC();
			break;
		case DEFBOFIHBCP.easeInOutElastic:
			MMBBOPDHONE();
			break;
		case DEFBOFIHBCP.punch:
			AAIPGNKCPGI();
			break;
		case DEFBOFIHBCP.easeShake:
			DBBFHPJDFJL();
			break;
		case DEFBOFIHBCP.easeSpring:
			NBMNLEHNJBH();
			break;
		default:
			EKOOKPENPDF();
			break;
		}
		return this;
	}

	[CompilerGenerated]
	private void HFNFDEFNCLD()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		Mesh mesh = LOEHKHINJAH.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color32[] array = new Color32[vertices.Length];
		if (array.Length == 0)
		{
			Color32 color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0);
			array = new Color32[mesh.vertices.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = color;
			}
			mesh.colors32 = array;
		}
		Color32 color2 = mesh.colors32[0];
		color2 = new Color((int)color2.r, (int)color2.g, (int)color2.b, GBMPBBHCBDA);
		for (int j = 0; j < vertices.Length; j++)
		{
			array[j] = color2;
		}
		mesh.colors32 = array;
	}

	private static void GFKFNJPGHLK(Transform LOEHKHINJAH, float GBMPBBHCBDA, bool DAGIGIBOMLH = true)
	{
		Text component = LOEHKHINJAH.GetComponent<Text>();
		if (component != null)
		{
			Color color = component.color;
			color.a = GBMPBBHCBDA;
			component.color = color;
		}
		if (!DAGIGIBOMLH || LOEHKHINJAH.childCount <= 0)
		{
			return;
		}
		foreach (Transform item in LOEHKHINJAH)
		{
			GFKFNJPGHLK(item, GBMPBBHCBDA, DAGIGIBOMLH: false);
		}
	}

	private static void AFOIANIOMBH(Transform KKIIOFBKNKC, float GBMPBBHCBDA, bool DAGIGIBOMLH = true)
	{
		Renderer component = KKIIOFBKNKC.gameObject.GetComponent<Renderer>();
		if (component != null)
		{
			Material[] materials = component.materials;
			foreach (Material material in materials)
			{
				if (material.HasProperty("_Color"))
				{
					material.color = new Color(material.color.r, material.color.g, material.color.b, GBMPBBHCBDA);
				}
				else if (material.HasProperty("_TintColor"))
				{
					Color color = material.GetColor("_TintColor");
					material.SetColor("_TintColor", new Color(color.r, color.g, color.b, GBMPBBHCBDA));
				}
			}
		}
		if (!DAGIGIBOMLH || KKIIOFBKNKC.childCount <= 0)
		{
			return;
		}
		foreach (Transform item in KKIIOFBKNKC)
		{
			AFOIANIOMBH(item, GBMPBBHCBDA);
		}
	}

	[CompilerGenerated]
	private void OPBHMBIFPJB()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		Color color = BMCJJHIBLGJ(this, GBMPBBHCBDA);
		if (ADFBMONHJCI != null)
		{
			ADFBMONHJCI.color = color;
		}
		else if (JLECGOEFCFE != null)
		{
			JLECGOEFCFE.color = color;
		}
		if (KAFGFEOJLAM != 0f && DFBBNCIMAFE.CNGNFPILFIH != null)
		{
			DFBBNCIMAFE.CNGNFPILFIH(color);
		}
		if (DAGIGIBOMLH)
		{
			CKNEACGDKJA(DHCIKBOPGNF, color);
		}
	}

	[CompilerGenerated]
	private void MEABIECJOIA()
	{
		PLAKEDCBHGH.x = DHCIKBOPGNF.anchoredPosition3D.y;
	}

	public BMDIMDNILIM ELPKHAJJFFI()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.COLOR;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.eulerAngles.x;
			NLBHGGANDMI.x = LeanTween.closestRot(PLAKEDCBHGH.x, NLBHGGANDMI.x);
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.eulerAngles = new Vector3(JCPNNEMGBIG().x, LOEHKHINJAH.eulerAngles.y, LOEHKHINJAH.eulerAngles.z);
		};
		return this;
	}

	private Vector3 NBPGCIMNOCO()
	{
		GBMPBBHCBDA = Mathf.Sin(MMOFNOOHHDM * LeanTween.PI_DIV2);
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	public BMDIMDNILIM ABDLHLCHEOA(Action<Vector2> KDHFAGIFKAK)
	{
		DFBBNCIMAFE.IOGCAEHLCHD = KDHFAGIFKAK;
		KKPJGPKIEBI = true;
		return this;
	}

	public BMDIMDNILIM IKMKHAAHIMF(float FNJNKEADGAM)
	{
		this.FNJNKEADGAM = FNJNKEADGAM;
		return this;
	}

	public BMDIMDNILIM PMBADCHCGOH()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.ROTATE_AROUND_LOCAL;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = 0f;
			DFBBNCIMAFE.HMINCLEHAAE = LOEHKHINJAH.localRotation;
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			Vector3 localPosition = LOEHKHINJAH.localPosition;
			LOEHKHINJAH.RotateAround(LOEHKHINJAH.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK), LOEHKHINJAH.TransformDirection(DFBBNCIMAFE.HDNOFOIOENF), 0f - DFBBNCIMAFE.IMIHNEKGMPK);
			Vector3 b = localPosition - LOEHKHINJAH.localPosition;
			LOEHKHINJAH.localPosition = localPosition - b;
			LOEHKHINJAH.localRotation = DFBBNCIMAFE.HMINCLEHAAE;
			Vector3 point = LOEHKHINJAH.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK);
			LOEHKHINJAH.RotateAround(point, LOEHKHINJAH.TransformDirection(DFBBNCIMAFE.HDNOFOIOENF), GBMPBBHCBDA);
			DFBBNCIMAFE.IMIHNEKGMPK = GBMPBBHCBDA;
		};
		return this;
	}

	public BMDIMDNILIM MHDBMHFNEKD()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE_TO_TRANSFORM;
		CPCNFMJIGNM = delegate
		{
			KHKPNLDKEPI = LOEHKHINJAH.position;
		};
		ALECMEFEFIE = delegate
		{
			HIECNNGMKIE = DFBBNCIMAFE.NGAFDIIEGJK.position;
			OBEJEJKJNAB = HIECNNGMKIE - KHKPNLDKEPI;
			LOJJNGOHPKJ = OBEJEJKJNAB * 0.5f;
			DMCLLHJDNLG = JCPNNEMGBIG();
			LOEHKHINJAH.position = DMCLLHJDNLG;
		};
		return this;
	}

	[CompilerGenerated]
	private void IMGNPLDKDLE()
	{
		LOEHKHINJAH.position = new Vector3(LOEHKHINJAH.position.x, LOEHKHINJAH.position.y, JCPNNEMGBIG().x);
	}

	public BMDIMDNILIM BJGOJFCGJCC()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInBounce;
		JCPNNEMGBIG = DHLDFAEGHCO;
		return this;
	}

	public BMDIMDNILIM IFNMLELAPMG()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE_SPLINE;
		CPCNFMJIGNM = AGPEIMKKHML;
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			if (DFBBNCIMAFE.LMEJPKDKMEN.orientToPath)
			{
				if (DFBBNCIMAFE.LMEJPKDKMEN.orientToPath2d)
				{
					DFBBNCIMAFE.LMEJPKDKMEN.GKKDJKIJEIJ(LOEHKHINJAH, GBMPBBHCBDA);
				}
				else
				{
					DFBBNCIMAFE.LMEJPKDKMEN.NGFEAGKGPLB(LOEHKHINJAH, GBMPBBHCBDA);
				}
			}
			else
			{
				LOEHKHINJAH.position = DFBBNCIMAFE.LMEJPKDKMEN.CNBPFDEFCEK(GBMPBBHCBDA);
			}
		};
		return this;
	}

	public BMDIMDNILIM IPNCNOLINLE()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInOutCubic;
		JCPNNEMGBIG = HDFHCLKBCIM;
		return this;
	}

	public BMDIMDNILIM PFCCIDAEFBK()
	{
		PKKHGLGLFMK = (GFMDPMOPLPO)(-62);
		CPCNFMJIGNM = delegate
		{
		};
		ALECMEFEFIE = IOEEGIMFEIJ;
		return this;
	}

	[CompilerGenerated]
	private void KDEIMDMEMPO()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		Vector3 localPosition = LOEHKHINJAH.localPosition;
		LOEHKHINJAH.RotateAround(LOEHKHINJAH.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK), LOEHKHINJAH.TransformDirection(DFBBNCIMAFE.HDNOFOIOENF), 0f - DFBBNCIMAFE.IMIHNEKGMPK);
		Vector3 b = localPosition - LOEHKHINJAH.localPosition;
		LOEHKHINJAH.localPosition = localPosition - b;
		LOEHKHINJAH.localRotation = DFBBNCIMAFE.HMINCLEHAAE;
		Vector3 point = LOEHKHINJAH.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK);
		LOEHKHINJAH.RotateAround(point, LOEHKHINJAH.TransformDirection(DFBBNCIMAFE.HDNOFOIOENF), GBMPBBHCBDA);
		DFBBNCIMAFE.IMIHNEKGMPK = GBMPBBHCBDA;
	}

	[CompilerGenerated]
	private void CMGEDHOEAHA()
	{
		DHCIKBOPGNF.sizeDelta = JCPNNEMGBIG();
	}

	[CompilerGenerated]
	private void CEGDFLMOIIP()
	{
		ADFBMONHJCI = LOEHKHINJAH.GetComponent<Image>();
		if (ADFBMONHJCI != null)
		{
			PLAKEDCBHGH.x = ADFBMONHJCI.color.a;
			return;
		}
		JLECGOEFCFE = LOEHKHINJAH.GetComponent<RawImage>();
		if (JLECGOEFCFE != null)
		{
			PLAKEDCBHGH.x = JLECGOEFCFE.color.a;
		}
		else
		{
			PLAKEDCBHGH.x = 1f;
		}
	}

	public BMDIMDNILIM DBBFHPJDFJL()
	{
		DFBBNCIMAFE.AFEDAGPKMIE = LeanTween.shake;
		NLBHGGANDMI.x = KHKPNLDKEPI.x + HIECNNGMKIE.x;
		JCPNNEMGBIG = KAAHGPCAEEL;
		return this;
	}

	[CompilerGenerated]
	private void NAFFBPLBPCN()
	{
		DHCIKBOPGNF.localScale = JCPNNEMGBIG();
	}

	public BMDIMDNILIM OMGANBJKLJH()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.VALUE3;
		CPCNFMJIGNM = delegate
		{
		};
		ALECMEFEFIE = LDHPCMKDEAO;
		return this;
	}

	private Vector3 DJNIANBLNHM()
	{
		return new Vector3(LeanTween.easeInElastic(KHKPNLDKEPI.x, HIECNNGMKIE.x, MMOFNOOHHDM, DFBOMFPMKEF, GFOKPCHDPMI), LeanTween.easeInElastic(KHKPNLDKEPI.y, HIECNNGMKIE.y, MMOFNOOHHDM, DFBOMFPMKEF, GFOKPCHDPMI), LeanTween.easeInElastic(KHKPNLDKEPI.z, HIECNNGMKIE.z, MMOFNOOHHDM, DFBOMFPMKEF, GFOKPCHDPMI));
	}

	public BMDIMDNILIM PIIPKFMMOMJ()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CANVAS_MOVE_Y;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = DHCIKBOPGNF.anchoredPosition3D.y;
		};
		ALECMEFEFIE = delegate
		{
			Vector3 anchoredPosition3D = DHCIKBOPGNF.anchoredPosition3D;
			DHCIKBOPGNF.anchoredPosition3D = new Vector3(anchoredPosition3D.x, JCPNNEMGBIG().x, anchoredPosition3D.z);
		};
		return this;
	}

	public BMDIMDNILIM GNJDLINHKMH(int OLBLCDEMIEM)
	{
		PGFGAOFOAOG = OLBLCDEMIEM;
		return this;
	}

	public BMDIMDNILIM MPBIKNDJFMO(bool KNMBKPJJEAO)
	{
		this.KNMBKPJJEAO = KNMBKPJJEAO;
		LCJODMHCGIB = false;
		return this;
	}

	[CompilerGenerated]
	private void GBFBIDEBGFK()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.eulerAngles.x;
		NLBHGGANDMI.x = LeanTween.closestRot(PLAKEDCBHGH.x, NLBHGGANDMI.x);
	}

	[CompilerGenerated]
	private void CANJNCBLLIB()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		RectTransform dHCIKBOPGNF = DHCIKBOPGNF;
		Vector3 localPosition = dHCIKBOPGNF.localPosition;
		dHCIKBOPGNF.RotateAround(dHCIKBOPGNF.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK), DFBBNCIMAFE.HDNOFOIOENF, 0f - GBMPBBHCBDA);
		Vector3 b = localPosition - dHCIKBOPGNF.localPosition;
		dHCIKBOPGNF.localPosition = localPosition - b;
		dHCIKBOPGNF.rotation = DFBBNCIMAFE.HMINCLEHAAE;
		dHCIKBOPGNF.RotateAround(dHCIKBOPGNF.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK), DFBBNCIMAFE.HDNOFOIOENF, GBMPBBHCBDA);
	}

	public BMDIMDNILIM BINFLEILHNP(float GANCKAFBCGO)
	{
		this.GANCKAFBCGO = GANCKAFBCGO;
		return this;
	}

	public BMDIMDNILIM FONALENPCAI(Action<float> KDHFAGIFKAK)
	{
		DFBBNCIMAFE.LAHLCJADJLH = KDHFAGIFKAK;
		KKPJGPKIEBI = true;
		return this;
	}

	public BMDIMDNILIM MCIFPPIOCBJ(bool HCHIHNKHPAO)
	{
		KLLAFBMNKKM = HCHIHNKHPAO;
		LCJODMHCGIB = false;
		return this;
	}

	public BMDIMDNILIM JMLNHLEEFHB(LTRect MKCMDDIBJKN)
	{
		DFBBNCIMAFE.KLEBOFBEKJJ = MKCMDDIBJKN;
		return this;
	}

	[CompilerGenerated]
	private void OEBKJIKGLAP()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		RectTransform dHCIKBOPGNF = DHCIKBOPGNF;
		Vector3 localPosition = dHCIKBOPGNF.localPosition;
		dHCIKBOPGNF.RotateAround(dHCIKBOPGNF.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK), dHCIKBOPGNF.TransformDirection(DFBBNCIMAFE.HDNOFOIOENF), 0f - GBMPBBHCBDA);
		Vector3 b = localPosition - dHCIKBOPGNF.localPosition;
		dHCIKBOPGNF.localPosition = localPosition - b;
		dHCIKBOPGNF.rotation = DFBBNCIMAFE.HMINCLEHAAE;
		dHCIKBOPGNF.RotateAround(dHCIKBOPGNF.TransformPoint(DFBBNCIMAFE.CNBPFDEFCEK), dHCIKBOPGNF.TransformDirection(DFBBNCIMAFE.HDNOFOIOENF), GBMPBBHCBDA);
	}

	public BMDIMDNILIM KFIPKHCJBOG(uint LHCMMKLKDHH, uint DFAPMIMGIKM)
	{
		LFMLPGGGPMK = LHCMMKLKDHH;
		NLBGPCBDMGD = DFAPMIMGIKM;
		return this;
	}

	public BMDIMDNILIM JJINKFLLJLA()
	{
		PKKHGLGLFMK = (GFMDPMOPLPO)83;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.GetComponent<CanvasGroup>().alpha;
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.GetComponent<CanvasGroup>().alpha = JCPNNEMGBIG().x;
		};
		return this;
	}

	private static void CKNEACGDKJA(RectTransform DHCIKBOPGNF, Color LFEINPFBBOL)
	{
		if (DHCIKBOPGNF.childCount <= 0)
		{
			return;
		}
		foreach (RectTransform item in DHCIKBOPGNF)
		{
			MaskableGraphic component = item.GetComponent<Image>();
			if (component != null)
			{
				component.color = LFEINPFBBOL;
			}
			else
			{
				component = item.GetComponent<RawImage>();
				if (component != null)
				{
					component.color = LFEINPFBBOL;
				}
			}
			CKNEACGDKJA(item, LFEINPFBBOL);
		}
	}

	[CompilerGenerated]
	private void GIOECALILMK()
	{
		ADFBMONHJCI = LOEHKHINJAH.GetComponent<Image>();
		PLAKEDCBHGH.x = 0f;
	}

	private Vector3 LHKMGAHOOHO()
	{
		return new Vector3(LeanTween.easeOutElastic(KHKPNLDKEPI.x, HIECNNGMKIE.x, MMOFNOOHHDM, DFBOMFPMKEF, GFOKPCHDPMI), LeanTween.easeOutElastic(KHKPNLDKEPI.y, HIECNNGMKIE.y, MMOFNOOHHDM, DFBOMFPMKEF, GFOKPCHDPMI), LeanTween.easeOutElastic(KHKPNLDKEPI.z, HIECNNGMKIE.z, MMOFNOOHHDM, DFBOMFPMKEF, GFOKPCHDPMI));
	}

	[CompilerGenerated]
	private void KNOOMOPPOPI()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		Color color = BMCJJHIBLGJ(this, GBMPBBHCBDA);
		if (FKAKCFNGDGL != null)
		{
			FKAKCFNGDGL.color = color;
			HJDEEAPKIGB(LOEHKHINJAH, color);
		}
		else if (PKKHGLGLFMK == GFMDPMOPLPO.COLOR)
		{
			CKNEACGDKJA(LOEHKHINJAH, color, DAGIGIBOMLH);
		}
		if (KAFGFEOJLAM != 0f && DFBBNCIMAFE.CNGNFPILFIH != null)
		{
			DFBBNCIMAFE.CNGNFPILFIH(color);
		}
		else if (KAFGFEOJLAM != 0f && DFBBNCIMAFE.IBHANHJONKC != null)
		{
			DFBBNCIMAFE.IBHANHJONKC(color, DFBBNCIMAFE.KPFPEAIAJMO);
		}
	}

	public BMDIMDNILIM MCEKKFHGKIP(Color BECFNFFDBIK)
	{
		KHKPNLDKEPI = new Vector3(0f, BECFNFFDBIK.a, 0f);
		OBEJEJKJNAB = new Vector3(1f, 0f, 0f);
		DFBBNCIMAFE.HDNOFOIOENF = new Vector3(BECFNFFDBIK.r, BECFNFFDBIK.g, BECFNFFDBIK.b);
		return this;
	}

	public BMDIMDNILIM CJACNCNEFKN()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE_Z;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.position.z;
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.position = new Vector3(LOEHKHINJAH.position.x, LOEHKHINJAH.position.y, JCPNNEMGBIG().x);
		};
		return this;
	}

	[CompilerGenerated]
	private void GHOKECBEAJP()
	{
		KHKPNLDKEPI = new Vector3(DFBBNCIMAFE.KLEBOFBEKJJ.rect.width, DFBBNCIMAFE.KLEBOFBEKJJ.rect.height, 0f);
	}

	public BMDIMDNILIM JMLNHLEEFHB(RectTransform MKCMDDIBJKN)
	{
		DHCIKBOPGNF = MKCMDDIBJKN;
		return this;
	}

	public BMDIMDNILIM IDDICEOPPIK()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CANVAS_ALPHA;
		CPCNFMJIGNM = delegate
		{
			ADFBMONHJCI = LOEHKHINJAH.GetComponent<Image>();
			if (ADFBMONHJCI != null)
			{
				PLAKEDCBHGH.x = ADFBMONHJCI.color.a;
			}
			else
			{
				JLECGOEFCFE = LOEHKHINJAH.GetComponent<RawImage>();
				if (JLECGOEFCFE != null)
				{
					PLAKEDCBHGH.x = JLECGOEFCFE.color.a;
				}
				else
				{
					PLAKEDCBHGH.x = 1f;
				}
			}
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			if (ADFBMONHJCI != null)
			{
				Color color = ADFBMONHJCI.color;
				color.a = GBMPBBHCBDA;
				ADFBMONHJCI.color = color;
			}
			else if (JLECGOEFCFE != null)
			{
				Color color2 = JLECGOEFCFE.color;
				color2.a = GBMPBBHCBDA;
				JLECGOEFCFE.color = color2;
			}
			if (DAGIGIBOMLH)
			{
				AFOIANIOMBH(DHCIKBOPGNF, GBMPBBHCBDA);
				LHMKLBBDGDM(DHCIKBOPGNF, GBMPBBHCBDA);
			}
		};
		return this;
	}

	[CompilerGenerated]
	private void CADLHNCOCCE()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.localScale.z;
	}

	[CompilerGenerated]
	private void NLBEEMAAHGF()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.position.x;
	}

	public BMDIMDNILIM FONALENPCAI(Action<float, object> KDHFAGIFKAK, object KPFPEAIAJMO = null)
	{
		DFBBNCIMAFE.FCCMGLEHNJA = KDHFAGIFKAK;
		KKPJGPKIEBI = true;
		if (KPFPEAIAJMO != null)
		{
			DFBBNCIMAFE.KPFPEAIAJMO = KPFPEAIAJMO;
		}
		return this;
	}

	private void AGPEIMKKHML()
	{
		PLAKEDCBHGH.x = 0f;
	}

	private static void AFOIANIOMBH(RectTransform DHCIKBOPGNF, float GBMPBBHCBDA, int CPIFOGPODFL = 0)
	{
		if (DHCIKBOPGNF.childCount <= 0)
		{
			return;
		}
		foreach (RectTransform item in DHCIKBOPGNF)
		{
			MaskableGraphic component = item.GetComponent<Image>();
			if (component != null)
			{
				Color color = component.color;
				color.a = GBMPBBHCBDA;
				component.color = color;
			}
			else
			{
				component = item.GetComponent<RawImage>();
				if (component != null)
				{
					Color color2 = component.color;
					color2.a = GBMPBBHCBDA;
					component.color = color2;
				}
			}
			AFOIANIOMBH(item, GBMPBBHCBDA, CPIFOGPODFL + 1);
		}
	}

	private Vector3 HIOCCPOPKKK()
	{
		GBMPBBHCBDA = MMOFNOOHHDM;
		return new Vector3(KHKPNLDKEPI.x + OBEJEJKJNAB.x * GBMPBBHCBDA, KHKPNLDKEPI.y + OBEJEJKJNAB.y * GBMPBBHCBDA, KHKPNLDKEPI.z + OBEJEJKJNAB.z * GBMPBBHCBDA);
	}

	public BMDIMDNILIM ADPMJDOHICB(Sprite[] OMLBFIOPPNI)
	{
		this.OMLBFIOPPNI = OMLBFIOPPNI;
		return this;
	}

	private Vector3 KFEAJMMLLFK()
	{
		GBMPBBHCBDA = MMOFNOOHHDM * MMOFNOOHHDM * MMOFNOOHHDM * MMOFNOOHHDM;
		return OBEJEJKJNAB * GBMPBBHCBDA + KHKPNLDKEPI;
	}

	[CompilerGenerated]
	private void GEILJOJNNBL()
	{
		if (!DFBBNCIMAFE.KLEBOFBEKJJ.rotateEnabled)
		{
			DFBBNCIMAFE.KLEBOFBEKJJ.rotateEnabled = true;
			DFBBNCIMAFE.KLEBOFBEKJJ.BBDBMMGPMAO();
		}
		PLAKEDCBHGH.x = DFBBNCIMAFE.KLEBOFBEKJJ.rotation;
	}

	[CompilerGenerated]
	private void HDFJOINGNNP()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		if (DFBBNCIMAFE.LMEJPKDKMEN.orientToPath)
		{
			if (DFBBNCIMAFE.LMEJPKDKMEN.orientToPath2d)
			{
				DFBBNCIMAFE.LMEJPKDKMEN.FEAMPOAHCGC(LOEHKHINJAH, GBMPBBHCBDA);
			}
			else
			{
				DFBBNCIMAFE.LMEJPKDKMEN.PGINPBGPAFP(LOEHKHINJAH, GBMPBBHCBDA);
			}
		}
		else
		{
			LOEHKHINJAH.localPosition = DFBBNCIMAFE.LMEJPKDKMEN.CNBPFDEFCEK(GBMPBBHCBDA);
		}
	}

	public BMDIMDNILIM EJIJJKPOEMO()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.DELAYED_SOUND;
		CPCNFMJIGNM = delegate
		{
			MNJLPBBGPJI = true;
		};
		ALECMEFEFIE = LDHPCMKDEAO;
		return this;
	}

	public BMDIMDNILIM GINMMEKAKLO(Action<float, float> KDHFAGIFKAK)
	{
		DFBBNCIMAFE.DMIJOHHGJNF = KDHFAGIFKAK;
		KKPJGPKIEBI = true;
		return this;
	}

	private static void LHMKLBBDGDM(Transform LOEHKHINJAH, float GBMPBBHCBDA, bool DAGIGIBOMLH = true)
	{
		if (!DAGIGIBOMLH || LOEHKHINJAH.childCount <= 0)
		{
			return;
		}
		foreach (Transform item in LOEHKHINJAH)
		{
			Text component = item.GetComponent<Text>();
			if (component != null)
			{
				Color color = component.color;
				color.a = GBMPBBHCBDA;
				component.color = color;
			}
			LHMKLBBDGDM(item, GBMPBBHCBDA);
		}
	}

	private Vector3 MOLEIAPJFFC()
	{
		GBMPBBHCBDA = MMOFNOOHHDM;
		GBMPBBHCBDA = GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA * GBMPBBHCBDA;
		return new Vector3(OBEJEJKJNAB.x * GBMPBBHCBDA + KHKPNLDKEPI.x, OBEJEJKJNAB.y * GBMPBBHCBDA + KHKPNLDKEPI.y, OBEJEJKJNAB.z * GBMPBBHCBDA + KHKPNLDKEPI.z);
	}

	[CompilerGenerated]
	private void IHLJDFDDFNL()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.eulerAngles.y;
		NLBHGGANDMI.x = LeanTween.closestRot(PLAKEDCBHGH.x, NLBHGGANDMI.x);
	}

	[CompilerGenerated]
	private void BEFLCLBIKIC()
	{
		IMICOALLJCH(LOEHKHINJAH, JCPNNEMGBIG().x, DAGIGIBOMLH);
	}

	public BMDIMDNILIM PHCJFCEMLKO(DEFBOFIHBCP HOFNENKKLMO)
	{
		this.HOFNENKKLMO = HOFNENKKLMO;
		return this;
	}

	public BMDIMDNILIM HCCPEGOIBPI()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE;
		CPCNFMJIGNM = delegate
		{
			KHKPNLDKEPI = LOEHKHINJAH.position;
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			LOEHKHINJAH.position = DMCLLHJDNLG;
		};
		return this;
	}

	[CompilerGenerated]
	private void IPPNCGCMKIA()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.position.y;
	}

	[CompilerGenerated]
	private void ODLIOOIHDOE()
	{
		PLAKEDCBHGH.x = 0f;
		DFBBNCIMAFE.HMINCLEHAAE = LOEHKHINJAH.rotation;
	}

	public BMDIMDNILIM DNCLJKKMGGD()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.FOLLOW;
		return this;
	}

	public BMDIMDNILIM BCDOAFIHKFG(Vector3 OBEJEJKJNAB)
	{
		this.OBEJEJKJNAB = OBEJEJKJNAB;
		return this;
	}

	[CompilerGenerated]
	private void CEKOOMMGAJK()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.position.z;
	}

	public BMDIMDNILIM PHPEEDJBMAA()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInOutCirc;
		JCPNNEMGBIG = AKBHEAEPLOB;
		return this;
	}

	[CompilerGenerated]
	private void DMLHCBLDMLH()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.localPosition.z;
	}

	private void KPIKGGBCLEK()
	{
		KHKPNLDKEPI = DHCIKBOPGNF.sizeDelta;
	}

	public BMDIMDNILIM LHAGNILGJOB()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInQuad;
		JCPNNEMGBIG = FIJJFFAGLBM;
		return this;
	}

	public BMDIMDNILIM HFBOCECOIPA()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInQuart;
		JCPNNEMGBIG = OJPEFNAKLPE;
		return this;
	}

	[CompilerGenerated]
	private void AOALKOMLGDB()
	{
		Vector3 anchoredPosition3D = DHCIKBOPGNF.anchoredPosition3D;
		DHCIKBOPGNF.anchoredPosition3D = new Vector3(JCPNNEMGBIG().x, anchoredPosition3D.y, anchoredPosition3D.z);
	}

	private static void IMICOALLJCH(Transform LOEHKHINJAH, float GBMPBBHCBDA, bool DAGIGIBOMLH = true)
	{
		Text component = LOEHKHINJAH.GetComponent<Text>();
		if (component != null)
		{
			Color color = component.color;
			color.a = GBMPBBHCBDA;
			component.color = color;
		}
		if (!DAGIGIBOMLH || LOEHKHINJAH.childCount <= 0)
		{
			return;
		}
		foreach (Transform item in LOEHKHINJAH)
		{
			IMICOALLJCH(item, GBMPBBHCBDA);
		}
	}

	public BMDIMDNILIM HPCLDLMLPMN()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeInQuint;
		JCPNNEMGBIG = MOLEIAPJFFC;
		return this;
	}

	public BMDIMDNILIM IJHDNKNJJCE()
	{
		PKKHGLGLFMK = (GFMDPMOPLPO)(-54);
		CPCNFMJIGNM = delegate
		{
			KHKPNLDKEPI = new Vector2(DFBBNCIMAFE.KLEBOFBEKJJ.margin.x, DFBBNCIMAFE.KLEBOFBEKJJ.margin.y);
		};
		ALECMEFEFIE = delegate
		{
			Vector3 vector = JCPNNEMGBIG();
			DFBBNCIMAFE.KLEBOFBEKJJ.margin = new Vector2(vector.x, vector.y);
		};
		return this;
	}

	[CompilerGenerated]
	private void HMHLACGHPDF()
	{
		Vector3 anchoredPosition3D = DHCIKBOPGNF.anchoredPosition3D;
		DHCIKBOPGNF.anchoredPosition3D = new Vector3(anchoredPosition3D.x, anchoredPosition3D.y, JCPNNEMGBIG().x);
	}

	public BMDIMDNILIM ECIIDIMPJNA()
	{
		KGDBBGGCBKE = DEFBOFIHBCP.easeOutBack;
		JCPNNEMGBIG = PIHECCBKFJG;
		return this;
	}

	public BMDIMDNILIM DNDNAAAPMGC()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE_LOCAL_Y;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.localPosition.y;
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.localPosition = new Vector3(LOEHKHINJAH.localPosition.x, JCPNNEMGBIG().x, LOEHKHINJAH.localPosition.z);
		};
		return this;
	}

	public BMDIMDNILIM IJJNALNGNNN()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CALLBACK_COLOR;
		CPCNFMJIGNM = delegate
		{
			OBEJEJKJNAB = new Vector3(1f, 0f, 0f);
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			Color color = BMCJJHIBLGJ(this, GBMPBBHCBDA);
			if (FKAKCFNGDGL != null)
			{
				FKAKCFNGDGL.color = color;
				HJDEEAPKIGB(LOEHKHINJAH, color);
			}
			else if (PKKHGLGLFMK == GFMDPMOPLPO.COLOR)
			{
				CKNEACGDKJA(LOEHKHINJAH, color, DAGIGIBOMLH);
			}
			if (KAFGFEOJLAM != 0f && DFBBNCIMAFE.CNGNFPILFIH != null)
			{
				DFBBNCIMAFE.CNGNFPILFIH(color);
			}
			else if (KAFGFEOJLAM != 0f && DFBBNCIMAFE.IBHANHJONKC != null)
			{
				DFBBNCIMAFE.IBHANHJONKC(color, DFBBNCIMAFE.KPFPEAIAJMO);
			}
		};
		return this;
	}

	public BMDIMDNILIM KCKOHPJJKDG()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CANVAS_SIZEDELTA;
		CPCNFMJIGNM = delegate
		{
			KHKPNLDKEPI = DHCIKBOPGNF.sizeDelta;
		};
		ALECMEFEFIE = delegate
		{
			DHCIKBOPGNF.sizeDelta = JCPNNEMGBIG();
		};
		return this;
	}

	[CompilerGenerated]
	private void GJFPHMINPAL()
	{
		PLAKEDCBHGH.x = LOEHKHINJAH.GetComponent<CanvasGroup>().alpha;
	}

	public BMDIMDNILIM BHGEHKMCNDN()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE_CURVED_LOCAL;
		CPCNFMJIGNM = AGPEIMKKHML;
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			if (DFBBNCIMAFE.PFKHAKGHKPK.HCJCJDJEFAD)
			{
				if (DFBBNCIMAFE.PFKHAKGHKPK.NDPNNJEFLHO)
				{
					DFBBNCIMAFE.PFKHAKGHKPK.FEAMPOAHCGC(LOEHKHINJAH, GBMPBBHCBDA);
				}
				else
				{
					DFBBNCIMAFE.PFKHAKGHKPK.PGINPBGPAFP(LOEHKHINJAH, GBMPBBHCBDA);
				}
			}
			else
			{
				LOEHKHINJAH.localPosition = DFBBNCIMAFE.PFKHAKGHKPK.CNBPFDEFCEK(GBMPBBHCBDA);
			}
		};
		return this;
	}

	public BMDIMDNILIM EOAPKBBHBAL(Action<object> NBBHOMIKJIL)
	{
		DFBBNCIMAFE.CLJPNGGBPOC = NBBHOMIKJIL;
		MNJLPBBGPJI = true;
		return this;
	}

	public BMDIMDNILIM JLDBPLIDIKN(bool NJJOLGPIPHJ)
	{
		HNALLPLCLKE = NJJOLGPIPHJ;
		return this;
	}

	public BMDIMDNILIM MEJCJCLEHHI()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CANVAS_COLOR;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH = DHCIKBOPGNF.anchoredPosition3D;
		};
		ALECMEFEFIE = delegate
		{
			DHCIKBOPGNF.anchoredPosition3D = JCPNNEMGBIG();
		};
		return this;
	}

	[CompilerGenerated]
	private void KGLPHNMLILK()
	{
		DMCLLHJDNLG = JCPNNEMGBIG();
		GBMPBBHCBDA = DMCLLHJDNLG.x;
		if (DFBBNCIMAFE.LMEJPKDKMEN.orientToPath)
		{
			if (DFBBNCIMAFE.LMEJPKDKMEN.orientToPath2d)
			{
				DFBBNCIMAFE.LMEJPKDKMEN.GKKDJKIJEIJ(LOEHKHINJAH, GBMPBBHCBDA);
			}
			else
			{
				DFBBNCIMAFE.LMEJPKDKMEN.NGFEAGKGPLB(LOEHKHINJAH, GBMPBBHCBDA);
			}
		}
		else
		{
			LOEHKHINJAH.position = DFBBNCIMAFE.LMEJPKDKMEN.CNBPFDEFCEK(GBMPBBHCBDA);
		}
	}

	private Vector3 LHEPECCFMEB()
	{
		return new Vector3(LeanTween.easeInOutElastic(KHKPNLDKEPI.x, HIECNNGMKIE.x, MMOFNOOHHDM, DFBOMFPMKEF, GFOKPCHDPMI), LeanTween.easeInOutElastic(KHKPNLDKEPI.y, HIECNNGMKIE.y, MMOFNOOHHDM, DFBOMFPMKEF, GFOKPCHDPMI), LeanTween.easeInOutElastic(KHKPNLDKEPI.z, HIECNNGMKIE.z, MMOFNOOHHDM, DFBOMFPMKEF, GFOKPCHDPMI));
	}

	public BMDIMDNILIM BCCHMCGKOIN(Vector3 KHKPNLDKEPI)
	{
		if ((bool)LOEHKHINJAH)
		{
			BMDFHEHKMFM();
		}
		this.KHKPNLDKEPI = KHKPNLDKEPI;
		OBEJEJKJNAB = HIECNNGMKIE - this.KHKPNLDKEPI;
		LOJJNGOHPKJ = OBEJEJKJNAB * 0.5f;
		return this;
	}

	public BMDIMDNILIM ENCPIGGNFGA()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.CANVAS_SCALE;
		CPCNFMJIGNM = delegate
		{
			KHKPNLDKEPI = DHCIKBOPGNF.localScale;
		};
		ALECMEFEFIE = delegate
		{
			DHCIKBOPGNF.localScale = JCPNNEMGBIG();
		};
		return this;
	}

	public BMDIMDNILIM POHNNBPBACP()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.MOVE_LOCAL_X;
		CPCNFMJIGNM = delegate
		{
			PLAKEDCBHGH.x = LOEHKHINJAH.localPosition.x;
		};
		ALECMEFEFIE = delegate
		{
			LOEHKHINJAH.localPosition = new Vector3(JCPNNEMGBIG().x, LOEHKHINJAH.localPosition.y, LOEHKHINJAH.localPosition.z);
		};
		return this;
	}

	[CompilerGenerated]
	private void IMPBOCIDFBM()
	{
		KHKPNLDKEPI = LOEHKHINJAH.localScale;
	}

	private Vector3 DHLDFAEGHCO()
	{
		GBMPBBHCBDA = MMOFNOOHHDM;
		GBMPBBHCBDA = 1f - GBMPBBHCBDA;
		return new Vector3(OBEJEJKJNAB.x - LeanTween.easeOutBounce(0f, OBEJEJKJNAB.x, GBMPBBHCBDA) + KHKPNLDKEPI.x, OBEJEJKJNAB.y - LeanTween.easeOutBounce(0f, OBEJEJKJNAB.y, GBMPBBHCBDA) + KHKPNLDKEPI.y, OBEJEJKJNAB.z - LeanTween.easeOutBounce(0f, OBEJEJKJNAB.z, GBMPBBHCBDA) + KHKPNLDKEPI.z);
	}

	private void IIMFIAJPACD()
	{
		LOEHKHINJAH.localScale = new Vector3(JCPNNEMGBIG().x, LOEHKHINJAH.localScale.y, LOEHKHINJAH.localScale.z);
	}

	public BMDIMDNILIM IHOPCPILNJO()
	{
		PKKHGLGLFMK = GFMDPMOPLPO.COLOR;
		CPCNFMJIGNM = delegate
		{
			SpriteRenderer component = LOEHKHINJAH.GetComponent<SpriteRenderer>();
			if (component != null)
			{
				MCEKKFHGKIP(component.color);
			}
			else if (LOEHKHINJAH.GetComponent<Renderer>() != null && LOEHKHINJAH.GetComponent<Renderer>().material.HasProperty("_Color"))
			{
				Color color2 = LOEHKHINJAH.GetComponent<Renderer>().material.color;
				MCEKKFHGKIP(color2);
			}
			else if (LOEHKHINJAH.GetComponent<Renderer>() != null && LOEHKHINJAH.GetComponent<Renderer>().material.HasProperty("_TintColor"))
			{
				Color color3 = LOEHKHINJAH.GetComponent<Renderer>().material.GetColor("_TintColor");
				MCEKKFHGKIP(color3);
			}
			else if (LOEHKHINJAH.childCount > 0)
			{
				foreach (Transform item in LOEHKHINJAH)
				{
					if (item.gameObject.GetComponent<Renderer>() != null)
					{
						Color color4 = item.gameObject.GetComponent<Renderer>().material.color;
						MCEKKFHGKIP(color4);
						break;
					}
				}
			}
		};
		ALECMEFEFIE = delegate
		{
			DMCLLHJDNLG = JCPNNEMGBIG();
			GBMPBBHCBDA = DMCLLHJDNLG.x;
			Color color = BMCJJHIBLGJ(this, GBMPBBHCBDA);
			if (FKAKCFNGDGL != null)
			{
				FKAKCFNGDGL.color = color;
				HJDEEAPKIGB(LOEHKHINJAH, color);
			}
			else if (PKKHGLGLFMK == GFMDPMOPLPO.COLOR)
			{
				CKNEACGDKJA(LOEHKHINJAH, color, DAGIGIBOMLH);
			}
			if (KAFGFEOJLAM != 0f && DFBBNCIMAFE.CNGNFPILFIH != null)
			{
				DFBBNCIMAFE.CNGNFPILFIH(color);
			}
			else if (KAFGFEOJLAM != 0f && DFBBNCIMAFE.IBHANHJONKC != null)
			{
				DFBBNCIMAFE.IBHANHJONKC(color, DFBBNCIMAFE.KPFPEAIAJMO);
			}
		};
		return this;
	}
}
