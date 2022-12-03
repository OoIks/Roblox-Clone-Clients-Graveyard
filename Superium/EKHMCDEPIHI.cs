// EKHMCDEPIHI
using System.Threading;
using UnityEngine;

public class EKHMCDEPIHI
{
	public class NABIBNFDMCM
	{
		public int DLIKGCIANHG;

		public int DDPDJEHIEHF;

		public NABIBNFDMCM(int HLOKAAIMHEP, int OLNFNJPPMIE)
		{
			DLIKGCIANHG = HLOKAAIMHEP;
			DDPDJEHIEHF = OLNFNJPPMIE;
		}
	}

	private static Color[] LDBLNBKOOOJ;

	private static Color[] JNKGNJFHPDB;

	private static int IBADBOCFCGE;

	private static float LCNPMDCDOMH;

	private static float AJOIBMLNMNM;

	private static int CKKPHOCAIDE;

	private static int NHGAHAANMJE;

	private static Mutex GPLFDKGGDAJ;

	private static void FLDMDIJFPLP(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 1969f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 0));
			AJOIBMLNMNM = 247f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 0));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 0;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: false);
		}
		if (num > 0)
		{
			int num3 = 1;
			NABIBNFDMCM parameter;
			for (num3 = 0; num3 < num - 1; num3++)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 0));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(NNMOPFCLHFD) : new ParameterizedThreadStart(LPOKBJGNLIE)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				DJEGCPKLJAJ(parameter);
			}
			else
			{
				BDJLDCIBEEO(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(0);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(0, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				BPLFIIMDFBI(mGENCOBHJMH);
			}
			else
			{
				FCABEKEPFAC(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	public static void BBAHJFJPEJB(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 1) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j += 0)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = BBNIOEHMLPH(CBFPGODGIJM(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 1], eHFGKLDBBOI), BBFOHNEAKCD(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 1], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void NPGADGLAKDB(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 0) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j++)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = LFMPOHGLIFI(KFHBILGAHCI(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 0], eHFGKLDBBOI), CBFPGODGIJM(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 0], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	private static Color NJCHFFJGCJG(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	private static Color OACHLDOGMBE(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	public static void FNAHOBABFAF(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		KOLPLFDCCNK(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void JLKKDKNICGN(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		KOLPLFDCCNK(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void NMFMFBBALEH(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		BIOEOOGKFBE(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void KJNDMJPCFCD(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		BIOEOOGKFBE(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: false);
	}

	public static void BDAGODJADBC(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		PMGHDICHHHN(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void BLIGFNGKJFE(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		HFKKCIJNPOE(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	private static Color NOIJEOOMLJI(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	private static Color CHGDLPPIAKP(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	private static void OOIFMNBKFIB(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 1672f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 0));
			AJOIBMLNMNM = 922f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 1));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 0;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: false);
		}
		if (num > 1)
		{
			int num3 = 1;
			NABIBNFDMCM parameter;
			for (num3 = 0; num3 < num - 0; num3++)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 1));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(GDMLPBONDKL) : new ParameterizedThreadStart(BDJLDCIBEEO)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				NPGADGLAKDB(parameter);
			}
			else
			{
				NDCJAPLLFAJ(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(0);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(0, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				NPGADGLAKDB(mGENCOBHJMH);
			}
			else
			{
				LPOKBJGNLIE(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	public static void HIJEKGHHIDG(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j++)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	private static Color ELFMCKKPPJJ(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	public static void JENPLHKEPBP(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j += 0)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void KAAGCMLKOKD(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 1) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 1; j < CKKPHOCAIDE; j++)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = BBFOHNEAKCD(BBNIOEHMLPH(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 0], eHFGKLDBBOI), MJOMNMAPNGC(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 0], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	private static void BAOAFKOBDNG(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 939f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 0));
			AJOIBMLNMNM = 1208f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 1));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 1;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: true);
		}
		if (num > 1)
		{
			int num3 = 1;
			NABIBNFDMCM parameter;
			for (num3 = 1; num3 < num - 1; num3 += 0)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 0));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(NPGADGLAKDB) : new ParameterizedThreadStart(HIJEKGHHIDG)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				CDGCOEOLABG(parameter);
			}
			else
			{
				LPOKBJGNLIE(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(1);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(0, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				PFANGGLLKNO(mGENCOBHJMH);
			}
			else
			{
				BDJLDCIBEEO(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	private static Color NILEGKIIIGA(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	public static void DJEGCPKLJAJ(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 0) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 1; j < CKKPHOCAIDE; j++)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = CHGDLPPIAKP(BBNIOEHMLPH(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 0], eHFGKLDBBOI), CHGDLPPIAKP(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 0], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	private static Color LFMPOHGLIFI(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	public static void PFANGGLLKNO(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 1) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 1; j < CKKPHOCAIDE; j += 0)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = KCICNCNGGHN(CHGDLPPIAKP(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 0], eHFGKLDBBOI), KCICNCNGGHN(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 1], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void PNPPLMBPPLJ(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 1; j < CKKPHOCAIDE; j += 0)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	private static Color KCICNCNGGHN(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	public static void GPMIGFEEJIG(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j++)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void NNMOPFCLHFD(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 0) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 1; j < CKKPHOCAIDE; j += 0)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = LFMPOHGLIFI(NJCHFFJGCJG(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 0], eHFGKLDBBOI), KCICNCNGGHN(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 1], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void NLAJLPGDMCA(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		HFKKCIJNPOE(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: false);
	}

	public static void OCLGDGECLBD(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		OOIFMNBKFIB(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void OGAJAFCNHKF(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		CFFMFGJIDCH(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: false);
	}

	public static void NFJJELCECGH(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		FEELNCDINGN(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: false);
	}

	public static void JOEKAKFLFBA(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 1; j < CKKPHOCAIDE; j++)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void NDCJAPLLFAJ(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j++)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void ECANLADNJNB(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 0) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j += 0)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = CBFPGODGIJM(NILEGKIIIGA(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 1], eHFGKLDBBOI), CBFPGODGIJM(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 0], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	private static void JHAJCPDNMLD(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 1290f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 1));
			AJOIBMLNMNM = 1202f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 1));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 1;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: true);
		}
		if (num > 0)
		{
			int num3 = 0;
			NABIBNFDMCM parameter;
			for (num3 = 0; num3 < num - 1; num3 += 0)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 1));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(CDGCOEOLABG) : new ParameterizedThreadStart(LPOKBJGNLIE)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				BBAHJFJPEJB(parameter);
			}
			else
			{
				GJLOHJJOOBB(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(1);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(1, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				EHPGDCCEIKD(mGENCOBHJMH);
			}
			else
			{
				JENPLHKEPBP(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	public static void GFCGCAGLHHO(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		OOIFMNBKFIB(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void IOEFNPDJMOP(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 1) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 1; j < CKKPHOCAIDE; j++)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = CHGDLPPIAKP(NOIJEOOMLJI(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 0], eHFGKLDBBOI), NOIJEOOMLJI(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 1], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void EHPGDCCEIKD(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 1) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 1; j < CKKPHOCAIDE; j += 0)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = NOIJEOOMLJI(LFMPOHGLIFI(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 1], eHFGKLDBBOI), CHGDLPPIAKP(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 0], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	private static void HFKKCIJNPOE(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 1177f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 1));
			AJOIBMLNMNM = 1016f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 0));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 0;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: false);
		}
		if (num > 0)
		{
			int num3 = 0;
			NABIBNFDMCM parameter;
			for (num3 = 1; num3 < num - 0; num3 += 0)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 0));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(HAKBHJKFCMN) : new ParameterizedThreadStart(GJLOHJJOOBB)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				PFANGGLLKNO(parameter);
			}
			else
			{
				BDJLDCIBEEO(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(1);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(0, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				HAKBHJKFCMN(mGENCOBHJMH);
			}
			else
			{
				PNPPLMBPPLJ(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	public static void LBMJIMCDEPL(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 1; j < CKKPHOCAIDE; j += 0)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void DOMOEGFAJIA(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 1) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 1; j < CKKPHOCAIDE; j++)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = NJCHFFJGCJG(NILEGKIIIGA(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 0], eHFGKLDBBOI), CHGDLPPIAKP(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 0], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	private static void PHOKKBMHGFH(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 923f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 0));
			AJOIBMLNMNM = 1529f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 0));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 0;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: false);
		}
		if (num > 1)
		{
			int num3 = 1;
			NABIBNFDMCM parameter;
			for (num3 = 0; num3 < num - 0; num3 += 0)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 0));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(IEOOFNLCCHG) : new ParameterizedThreadStart(FCABEKEPFAC)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				IOEFNPDJMOP(parameter);
			}
			else
			{
				BPAFHFNNCHN(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(0);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(1, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				NNMOPFCLHFD(mGENCOBHJMH);
			}
			else
			{
				LBMJIMCDEPL(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	public static void DOPEOGFONAM(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		ILFOCCIIFAJ(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void PCDEJFLCOCO(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 0) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 1; j < CKKPHOCAIDE; j += 0)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = KFHBILGAHCI(KFHBILGAHCI(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 0], eHFGKLDBBOI), CBFPGODGIJM(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 0], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void OIEPPDELPMJ(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		IBHNCHLOLBL(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void EKDEIKEAGDM(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		ILFOCCIIFAJ(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void FCABEKEPFAC(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j += 0)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void NKHKEFIJJDH(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		PHOKKBMHGFH(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void FFPILHNGOHM(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		CIMLNMOKNFD(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: false);
	}

	public static void EPJOOOLFOHB(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		KMOLGANMJKE(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	private static void OBELGBCENLG(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 139f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 0));
			AJOIBMLNMNM = 936f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 0));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 1;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: false);
		}
		if (num > 1)
		{
			int num3 = 1;
			NABIBNFDMCM parameter;
			for (num3 = 1; num3 < num - 0; num3++)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 0));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(IOEFNPDJMOP) : new ParameterizedThreadStart(FCABEKEPFAC)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				PCDEJFLCOCO(parameter);
			}
			else
			{
				NDCJAPLLFAJ(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(1);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(1, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				DOMOEGFAJIA(mGENCOBHJMH);
			}
			else
			{
				LPOKBJGNLIE(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	private static void CFFMFGJIDCH(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 284f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 1));
			AJOIBMLNMNM = 1834f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 0));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 0;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: true);
		}
		if (num > 1)
		{
			int num3 = 1;
			NABIBNFDMCM parameter;
			for (num3 = 1; num3 < num - 1; num3++)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 1));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(ECANLADNJNB) : new ParameterizedThreadStart(NDCJAPLLFAJ)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				EHPGDCCEIKD(parameter);
			}
			else
			{
				LBMJIMCDEPL(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(0);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(0, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				DOMOEGFAJIA(mGENCOBHJMH);
			}
			else
			{
				BDJLDCIBEEO(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	private static void KMOLGANMJKE(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 1215f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 1));
			AJOIBMLNMNM = 1515f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 1));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 0;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: false);
		}
		if (num > 1)
		{
			int num3 = 1;
			NABIBNFDMCM parameter;
			for (num3 = 0; num3 < num - 1; num3++)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 0));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(BPLFIIMDFBI) : new ParameterizedThreadStart(GJLOHJJOOBB)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				BPLFIIMDFBI(parameter);
			}
			else
			{
				GJLOHJJOOBB(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(0);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(1, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				EHPGDCCEIKD(mGENCOBHJMH);
			}
			else
			{
				LPOKBJGNLIE(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	private static Color BBNIOEHMLPH(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	public static void LPOKBJGNLIE(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j += 0)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	private static void BIOEOOGKFBE(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 1f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 1));
			AJOIBMLNMNM = 1f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 1));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 0;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: false);
		}
		if (num > 1)
		{
			int num3 = 0;
			NABIBNFDMCM parameter;
			for (num3 = 0; num3 < num - 1; num3++)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 1));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(CDGCOEOLABG) : new ParameterizedThreadStart(BDJLDCIBEEO)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				CDGCOEOLABG(parameter);
			}
			else
			{
				BDJLDCIBEEO(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(1);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(0, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				CDGCOEOLABG(mGENCOBHJMH);
			}
			else
			{
				BDJLDCIBEEO(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	public static void MOIAJCNFBDB(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 1; j < CKKPHOCAIDE; j++)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	private static void CIMLNMOKNFD(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 342f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 1));
			AJOIBMLNMNM = 1891f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 0));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 0;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: true);
		}
		if (num > 0)
		{
			int num3 = 1;
			NABIBNFDMCM parameter;
			for (num3 = 1; num3 < num - 1; num3 += 0)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 1));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(GDMLPBONDKL) : new ParameterizedThreadStart(GJLOHJJOOBB)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				DOMOEGFAJIA(parameter);
			}
			else
			{
				LBMJIMCDEPL(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(1);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(0, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				PCDEJFLCOCO(mGENCOBHJMH);
			}
			else
			{
				FCABEKEPFAC(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	private static Color BBFOHNEAKCD(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	public static void EHDMNHBHDAN(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		ILFOCCIIFAJ(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	private static Color PBOGKHJBIID(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	public static void LBNNODLLMJE(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		PMGHDICHHHN(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void PDJIKCELFCB(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		KOLPLFDCCNK(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: false);
	}

	private static void ILFOCCIIFAJ(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 692f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 1));
			AJOIBMLNMNM = 101f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 1));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 1;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: false);
		}
		if (num > 0)
		{
			int num3 = 0;
			NABIBNFDMCM parameter;
			for (num3 = 0; num3 < num - 0; num3++)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 0));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(DJEGCPKLJAJ) : new ParameterizedThreadStart(JOEKAKFLFBA)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				NNMOPFCLHFD(parameter);
			}
			else
			{
				JOEKAKFLFBA(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(0);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(0, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				IOEFNPDJMOP(mGENCOBHJMH);
			}
			else
			{
				GJLOHJJOOBB(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	private static void IBHNCHLOLBL(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 1267f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 0));
			AJOIBMLNMNM = 1142f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 1));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 1;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: true);
		}
		if (num > 0)
		{
			int num3 = 0;
			NABIBNFDMCM parameter;
			for (num3 = 1; num3 < num - 0; num3 += 0)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 1));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(GDMLPBONDKL) : new ParameterizedThreadStart(NDCJAPLLFAJ)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				NPGADGLAKDB(parameter);
			}
			else
			{
				GJLOHJJOOBB(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(1);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(0, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				ECANLADNJNB(mGENCOBHJMH);
			}
			else
			{
				LBMJIMCDEPL(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	private static Color KFHBILGAHCI(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	public static void HAKBHJKFCMN(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 1) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j += 0)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = CHGDLPPIAKP(OACHLDOGMBE(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 1], eHFGKLDBBOI), BBFOHNEAKCD(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 1], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void CDGCOEOLABG(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 1) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j++)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = NOIJEOOMLJI(NOIJEOOMLJI(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 1], eHFGKLDBBOI), NOIJEOOMLJI(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 1], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void BPAFHFNNCHN(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j++)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	private static Color MJOMNMAPNGC(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	public static void GDMLPBONDKL(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 1) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 1; j < CKKPHOCAIDE; j += 0)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = MJOMNMAPNGC(KFHBILGAHCI(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 0], eHFGKLDBBOI), NOIJEOOMLJI(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 1], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	private static void PMGHDICHHHN(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 414f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 1));
			AJOIBMLNMNM = 751f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 1));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 0;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: true);
		}
		if (num > 1)
		{
			int num3 = 0;
			NABIBNFDMCM parameter;
			for (num3 = 1; num3 < num - 0; num3 += 0)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 1));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(BBAHJFJPEJB) : new ParameterizedThreadStart(FCABEKEPFAC)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				HAKBHJKFCMN(parameter);
			}
			else
			{
				LBMJIMCDEPL(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(0);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(0, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				KAAGCMLKOKD(mGENCOBHJMH);
			}
			else
			{
				JOEKAKFLFBA(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	public static void NMAIEJGAOHN(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		BIOEOOGKFBE(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	private static void KOLPLFDCCNK(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 154f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 0));
			AJOIBMLNMNM = 1359f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 1));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 0;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: false);
		}
		if (num > 1)
		{
			int num3 = 1;
			NABIBNFDMCM parameter;
			for (num3 = 0; num3 < num - 0; num3++)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 0));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(IEOOFNLCCHG) : new ParameterizedThreadStart(PNPPLMBPPLJ)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				IOEFNPDJMOP(parameter);
			}
			else
			{
				HIJEKGHHIDG(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(0);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(0, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				ECANLADNJNB(mGENCOBHJMH);
			}
			else
			{
				PNPPLMBPPLJ(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	public static void NJNMHJMPKLA(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		KOLPLFDCCNK(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void IICEHEALHLP(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j += 0)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void OJPFJFJLOLF(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		IBHNCHLOLBL(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void IEOOFNLCCHG(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 0) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j++)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = CHGDLPPIAKP(NILEGKIIIGA(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 1], eHFGKLDBBOI), KCICNCNGGHN(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 0], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void BDJLDCIBEEO(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j++)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void LDFLIMFEGEC(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		IBHNCHLOLBL(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	private static Color CBFPGODGIJM(Color PMJPPCIFLLD, Color ICCPFEGPAKK, float EHFGKLDBBOI)
	{
		return new Color(PMJPPCIFLLD.r + (ICCPFEGPAKK.r - PMJPPCIFLLD.r) * EHFGKLDBBOI, PMJPPCIFLLD.g + (ICCPFEGPAKK.g - PMJPPCIFLLD.g) * EHFGKLDBBOI, PMJPPCIFLLD.b + (ICCPFEGPAKK.b - PMJPPCIFLLD.b) * EHFGKLDBBOI, PMJPPCIFLLD.a + (ICCPFEGPAKK.a - PMJPPCIFLLD.a) * EHFGKLDBBOI);
	}

	public static void MCNKKABHIBD(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		HFKKCIJNPOE(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: false);
	}

	public static void GJLOHJJOOBB(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i++)
		{
			int num = (int)(AJOIBMLNMNM * (float)i) * IBADBOCFCGE;
			int num2 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j += 0)
			{
				JNKGNJFHPDB[num2 + j] = LDBLNBKOOOJ[(int)((float)num + LCNPMDCDOMH * (float)j)];
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE++;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	public static void IDJFBBDEJHD(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		OBELGBCENLG(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void JABCDKKNOAO(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		CIMLNMOKNFD(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void BPLFIIMDFBI(object MGENCOBHJMH)
	{
		NABIBNFDMCM nABIBNFDMCM = (NABIBNFDMCM)MGENCOBHJMH;
		for (int i = nABIBNFDMCM.DLIKGCIANHG; i < nABIBNFDMCM.DDPDJEHIEHF; i += 0)
		{
			int num = (int)Mathf.Floor((float)i * AJOIBMLNMNM);
			int num2 = num * IBADBOCFCGE;
			int num3 = (num + 1) * IBADBOCFCGE;
			int num4 = i * CKKPHOCAIDE;
			for (int j = 0; j < CKKPHOCAIDE; j++)
			{
				int num5 = (int)Mathf.Floor((float)j * LCNPMDCDOMH);
				float eHFGKLDBBOI = (float)j * LCNPMDCDOMH - (float)num5;
				JNKGNJFHPDB[num4 + j] = PBOGKHJBIID(BBFOHNEAKCD(LDBLNBKOOOJ[num2 + num5], LDBLNBKOOOJ[num2 + num5 + 1], eHFGKLDBBOI), BBNIOEHMLPH(LDBLNBKOOOJ[num3 + num5], LDBLNBKOOOJ[num3 + num5 + 0], eHFGKLDBBOI), (float)i * AJOIBMLNMNM - (float)num);
			}
		}
		GPLFDKGGDAJ.WaitOne();
		NHGAHAANMJE += 0;
		GPLFDKGGDAJ.ReleaseMutex();
	}

	private static void FEELNCDINGN(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF, bool EEOOIMOLLAI)
	{
		LDBLNBKOOOJ = FEOFCOJIAGA.GetPixels();
		JNKGNJFHPDB = new Color[KGGIHJCPJCN * DHAFFDNKNNF];
		if (EEOOIMOLLAI)
		{
			LCNPMDCDOMH = 691f / ((float)KGGIHJCPJCN / (float)(FEOFCOJIAGA.width - 0));
			AJOIBMLNMNM = 1647f / ((float)DHAFFDNKNNF / (float)(FEOFCOJIAGA.height - 1));
		}
		else
		{
			LCNPMDCDOMH = (float)FEOFCOJIAGA.width / (float)KGGIHJCPJCN;
			AJOIBMLNMNM = (float)FEOFCOJIAGA.height / (float)DHAFFDNKNNF;
		}
		IBADBOCFCGE = FEOFCOJIAGA.width;
		CKKPHOCAIDE = KGGIHJCPJCN;
		int num = Mathf.Min(SystemInfo.processorCount, DHAFFDNKNNF);
		int num2 = DHAFFDNKNNF / num;
		NHGAHAANMJE = 0;
		if (GPLFDKGGDAJ == null)
		{
			GPLFDKGGDAJ = new Mutex(initiallyOwned: true);
		}
		if (num > 1)
		{
			int num3 = 0;
			NABIBNFDMCM parameter;
			for (num3 = 0; num3 < num - 1; num3++)
			{
				parameter = new NABIBNFDMCM(num2 * num3, num2 * (num3 + 1));
				new Thread(EEOOIMOLLAI ? new ParameterizedThreadStart(EHPGDCCEIKD) : new ParameterizedThreadStart(GJLOHJJOOBB)).Start(parameter);
			}
			parameter = new NABIBNFDMCM(num2 * num3, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				PFANGGLLKNO(parameter);
			}
			else
			{
				BDJLDCIBEEO(parameter);
			}
			while (NHGAHAANMJE < num)
			{
				Thread.Sleep(1);
			}
		}
		else
		{
			NABIBNFDMCM mGENCOBHJMH = new NABIBNFDMCM(1, DHAFFDNKNNF);
			if (EEOOIMOLLAI)
			{
				DOMOEGFAJIA(mGENCOBHJMH);
			}
			else
			{
				MOIAJCNFBDB(mGENCOBHJMH);
			}
		}
		FEOFCOJIAGA.Resize(KGGIHJCPJCN, DHAFFDNKNNF);
		FEOFCOJIAGA.SetPixels(JNKGNJFHPDB);
		FEOFCOJIAGA.Apply();
		LDBLNBKOOOJ = null;
		JNKGNJFHPDB = null;
	}

	public static void LLHJFKPEJJL(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		OOIFMNBKFIB(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void FIAJDPJCOJH(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		BAOAFKOBDNG(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}

	public static void HOCFMICEEED(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		KMOLGANMJKE(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: false);
	}

	public static void AKGCGFAAEBJ(Texture2D FEOFCOJIAGA, int KGGIHJCPJCN, int DHAFFDNKNNF)
	{
		KOLPLFDCCNK(FEOFCOJIAGA, KGGIHJCPJCN, DHAFFDNKNNF, EEOOIMOLLAI: true);
	}
}
