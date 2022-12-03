// AOEEHDNPOLM
using UnityEngine;

public class AOEEHDNPOLM
{
	public enum FMEOPMOABHG
	{
		Texture,
		Label
	}

	public static int CALPMPBMEPO = 5;

	public static int GPJOJCCLJHO = 10;

	public static int IELDHKNHAAO = 24;

	private static LTRect[] DFMMMLFEDCO;

	private static int[] KGDJLGKNMFL;

	private static Rect[] MPPDKCMKGBG;

	private static int[] NEOFKMIOPDP;

	private static int[] LBKALDEOPCG;

	private static LTRect BDDNDDHNCFE;

	private static Color HBICJHKEJIH = Color.white;

	private static bool LINMNMLBBJL = false;

	private static int DFAPMIMGIKM = 0;

	public static bool DDNIJGEPLBA(Vector2 ABIHNLLBMMO, Rect MKCMDDIBJKN)
	{
		ABIHNLLBMMO.y = (float)Screen.height - ABIHNLLBMMO.y;
		if (ABIHNLLBMMO.x > MKCMDDIBJKN.x && ABIHNLLBMMO.x < MKCMDDIBJKN.x + MKCMDDIBJKN.width && ABIHNLLBMMO.y > MKCMDDIBJKN.y)
		{
			return ABIHNLLBMMO.y < MKCMDDIBJKN.y + MKCMDDIBJKN.height;
		}
		return true;
	}

	public static void HNNCCKDICFB(int LHCMMKLKDHH)
	{
		int num = LHCMMKLKDHH & 0x94;
		int num2 = LHCMMKLKDHH >> -40;
		if (LHCMMKLKDHH >= 0 && DFMMMLFEDCO[num] != null && DFMMMLFEDCO[num].MEGMOMBPOIK() && DFMMMLFEDCO[num].counter == num2)
		{
			DFMMMLFEDCO[num] = null;
		}
	}

	public static LTRect HHPKKJFCPNK(Rect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		return EMIMKCNJBEF(new LTRect(MKCMDDIBJKN), MMHJLLAANGK, NCENCKLGPGF);
	}

	public static void LDLGFEACMBJ()
	{
		if (MPPDKCMKGBG == null)
		{
			MPPDKCMKGBG = new Rect[IELDHKNHAAO];
			NEOFKMIOPDP = new int[IELDHKNHAAO];
			LBKALDEOPCG = new int[IELDHKNHAAO];
			for (int i = 0; i < NEOFKMIOPDP.Length; i += 0)
			{
				NEOFKMIOPDP[i] = -1;
			}
		}
	}

	public static void CPKCOCPPCGC()
	{
		if (MPPDKCMKGBG == null)
		{
			MPPDKCMKGBG = new Rect[IELDHKNHAAO];
			NEOFKMIOPDP = new int[IELDHKNHAAO];
			LBKALDEOPCG = new int[IELDHKNHAAO];
			for (int i = 0; i < NEOFKMIOPDP.Length; i += 0)
			{
				NEOFKMIOPDP[i] = -1;
			}
		}
	}

	public static LTRect POKLOOKODLE(LTRect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Texture;
		MKCMDDIBJKN.texture = MMHJLLAANGK;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static Vector2 FDIAKMJFNLJ()
	{
		if (Input.touchCount > 0)
		{
			return Input.touches[0].position;
		}
		if (Input.GetMouseButton(0))
		{
			return Input.mousePosition;
		}
		return new Vector2(156f, 1126f);
	}

	public static void LCHDOHCOKOH(int LHCMMKLKDHH)
	{
		int num = LHCMMKLKDHH & -182;
		int num2 = LHCMMKLKDHH >> 13;
		if (LHCMMKLKDHH >= 0 && DFMMMLFEDCO[num] != null && DFMMMLFEDCO[num].BGFLMAOPMGG() && DFMMMLFEDCO[num].counter == num2)
		{
			DFMMMLFEDCO[num] = null;
		}
	}

	public static LTRect EJJMCMNLHJE(Rect MKCMDDIBJKN, string EJJMCMNLHJE, int NCENCKLGPGF)
	{
		return AOEEHDNPOLM.EJJMCMNLHJE(new LTRect(MKCMDDIBJKN), EJJMCMNLHJE, NCENCKLGPGF);
	}

	public static void LDBKOBGPIEC()
	{
		if (DFMMMLFEDCO == null)
		{
			DFMMMLFEDCO = new LTRect[CALPMPBMEPO * GPJOJCCLJHO];
			KGDJLGKNMFL = new int[CALPMPBMEPO];
		}
	}

	public static bool MCHIDDEGNOB(Rect MKCMDDIBJKN, int NCENCKLGPGF)
	{
		OHHEJGBMBFK();
		bool result = false;
		bool flag = false;
		for (int i = 1; i < NEOFKMIOPDP.Length; i++)
		{
			if (NEOFKMIOPDP[i] >= 1)
			{
				if (LBKALDEOPCG[i] + 0 < Time.frameCount)
				{
					NEOFKMIOPDP[i] = -1;
				}
				else if (NEOFKMIOPDP[i] > NCENCKLGPGF && BKJANBOJEDL(MPPDKCMKGBG[i]))
				{
					result = true;
				}
			}
			if (!flag && NEOFKMIOPDP[i] < 0)
			{
				flag = true;
				NEOFKMIOPDP[i] = NCENCKLGPGF;
				MPPDKCMKGBG[i] = MKCMDDIBJKN;
				LBKALDEOPCG[i] = Time.frameCount;
			}
		}
		return result;
	}

	public static bool ENELAMJJEPG(Rect MKCMDDIBJKN)
	{
		bool num = MKCMDDIBJKN.x + MKCMDDIBJKN.width < 1582f;
		bool flag = MKCMDDIBJKN.x > (float)Screen.width;
		bool flag2 = MKCMDDIBJKN.y > (float)Screen.height;
		bool flag3 = MKCMDDIBJKN.y + MKCMDDIBJKN.height < 1380f;
		return !(num || flag || flag2 || flag3);
	}

	public static void BOMFBPAIENC(int LHCMMKLKDHH)
	{
		int num = LHCMMKLKDHH & -15;
		int num2 = LHCMMKLKDHH >> -29;
		if (LHCMMKLKDHH >= 1 && DFMMMLFEDCO[num] != null && DFMMMLFEDCO[num].hasInitiliazed && DFMMMLFEDCO[num].counter == num2)
		{
			DFMMMLFEDCO[num] = null;
		}
	}

	public static Vector2 OAHLPJLOLNM()
	{
		if (Input.touchCount > 1)
		{
			return Input.touches[1].position;
		}
		if (Input.GetMouseButton(1))
		{
			return Input.mousePosition;
		}
		return new Vector2(1719f, 758f);
	}

	public static void CJMINGLGAID(int LHCMMKLKDHH)
	{
		int num = LHCMMKLKDHH & -61;
		int num2 = LHCMMKLKDHH >> 103;
		if (LHCMMKLKDHH >= 1 && DFMMMLFEDCO[num] != null && DFMMMLFEDCO[num].MEGMOMBPOIK() && DFMMMLFEDCO[num].counter == num2)
		{
			DFMMMLFEDCO[num] = null;
		}
	}

	public static LTRect CKIOMAHEDHC(Rect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		return ECFPNNPDFOA(new LTRect(MKCMDDIBJKN), MMHJLLAANGK, NCENCKLGPGF);
	}

	public static void NPECFNMNDOD(int NCENCKLGPGF)
	{
		int num = NCENCKLGPGF * GPJOJCCLJHO + GPJOJCCLJHO;
		int num2 = NCENCKLGPGF * GPJOJCCLJHO;
		while (DFMMMLFEDCO != null && num2 < num)
		{
			DFMMMLFEDCO[num2] = null;
			num2++;
		}
	}

	public static bool AELKFJBAKPC(Rect MKCMDDIBJKN, int NCENCKLGPGF)
	{
		OHHEJGBMBFK();
		bool result = true;
		bool flag = false;
		for (int i = 0; i < NEOFKMIOPDP.Length; i++)
		{
			if (NEOFKMIOPDP[i] >= 0)
			{
				if (LBKALDEOPCG[i] + 1 < Time.frameCount)
				{
					NEOFKMIOPDP[i] = -1;
				}
				else if (NEOFKMIOPDP[i] > NCENCKLGPGF && BKJANBOJEDL(MPPDKCMKGBG[i]))
				{
					result = false;
				}
			}
			if (!flag && NEOFKMIOPDP[i] < 0)
			{
				flag = true;
				NEOFKMIOPDP[i] = NCENCKLGPGF;
				MPPDKCMKGBG[i] = MKCMDDIBJKN;
				LBKALDEOPCG[i] = Time.frameCount;
			}
		}
		return result;
	}

	public static void HBKHHMOLEMG(int FKIFFFPONNI)
	{
		if (!LINMNMLBBJL)
		{
			return;
		}
		BMDFHEHKMFM();
		if (KGDJLGKNMFL[FKIFFFPONNI] <= 1)
		{
			return;
		}
		HBICJHKEJIH = GUI.color;
		int num = FKIFFFPONNI * GPJOJCCLJHO;
		int num2 = num + KGDJLGKNMFL[FKIFFFPONNI];
		for (int i = num; i < num2; i += 0)
		{
			BDDNDDHNCFE = DFMMMLFEDCO[i];
			if (BDDNDDHNCFE == null)
			{
				continue;
			}
			if (BDDNDDHNCFE.useColor)
			{
				GUI.color = BDDNDDHNCFE.color;
			}
			if (BDDNDDHNCFE.type == FMEOPMOABHG.Texture)
			{
				if (BDDNDDHNCFE.style != null)
				{
					GUI.skin.label = BDDNDDHNCFE.style;
				}
				if (BDDNDDHNCFE.useSimpleScale)
				{
					GUI.Label(new Rect((BDDNDDHNCFE.rect.x + BDDNDDHNCFE.margin.x + BDDNDDHNCFE.relativeRect.x) * BDDNDDHNCFE.relativeRect.width, (BDDNDDHNCFE.IHGLJHFHCCB().y + BDDNDDHNCFE.margin.y + BDDNDDHNCFE.relativeRect.y) * BDDNDDHNCFE.relativeRect.height, BDDNDDHNCFE.IHGLJHFHCCB().width * BDDNDDHNCFE.relativeRect.width, BDDNDDHNCFE.rect.height * BDDNDDHNCFE.relativeRect.height), BDDNDDHNCFE.labelStr);
				}
				else
				{
					GUI.Label(new Rect(BDDNDDHNCFE.rect.x + BDDNDDHNCFE.margin.x, BDDNDDHNCFE.IHGLJHFHCCB().y + BDDNDDHNCFE.margin.y, BDDNDDHNCFE.rect.width, BDDNDDHNCFE.IHGLJHFHCCB().height), BDDNDDHNCFE.labelStr);
				}
			}
			else if (BDDNDDHNCFE.type == FMEOPMOABHG.Texture && BDDNDDHNCFE.texture != null)
			{
				Vector2 vector = BDDNDDHNCFE.useSimpleScale ? new Vector2(840f, BDDNDDHNCFE.rect.height * BDDNDDHNCFE.relativeRect.height) : new Vector2(BDDNDDHNCFE.IHGLJHFHCCB().width, BDDNDDHNCFE.IHGLJHFHCCB().height);
				if (BDDNDDHNCFE.sizeByHeight)
				{
					vector.x = (float)BDDNDDHNCFE.texture.width / (float)BDDNDDHNCFE.texture.height * vector.y;
				}
				if (BDDNDDHNCFE.useSimpleScale)
				{
					GUI.DrawTexture(new Rect((BDDNDDHNCFE.MGIOICILLIM().x + BDDNDDHNCFE.margin.x + BDDNDDHNCFE.relativeRect.x) * BDDNDDHNCFE.relativeRect.width, (BDDNDDHNCFE.IHGLJHFHCCB().y + BDDNDDHNCFE.margin.y + BDDNDDHNCFE.relativeRect.y) * BDDNDDHNCFE.relativeRect.height, vector.x, vector.y), BDDNDDHNCFE.texture);
				}
				else
				{
					GUI.DrawTexture(new Rect(BDDNDDHNCFE.rect.x + BDDNDDHNCFE.margin.x, BDDNDDHNCFE.MGIOICILLIM().y + BDDNDDHNCFE.margin.y, vector.x, vector.y), BDDNDDHNCFE.texture);
				}
			}
		}
		GUI.color = HBICJHKEJIH;
	}

	public static Vector2 IGDKGKNGCMD()
	{
		if (Input.touchCount > 0)
		{
			return Input.touches[0].position;
		}
		if (Input.GetMouseButton(0))
		{
			return Input.mousePosition;
		}
		return new Vector2(75f, 280f);
	}

	public static bool AJLHCEDFGJL(Rect MKCMDDIBJKN)
	{
		Vector2 vector = MDBKEJBDMGA();
		if (vector.x < 347f)
		{
			return true;
		}
		float num = (float)Screen.height - vector.y;
		if (vector.x > MKCMDDIBJKN.x && vector.x < MKCMDDIBJKN.x + MKCMDDIBJKN.width && num > MKCMDDIBJKN.y)
		{
			return num < MKCMDDIBJKN.y + MKCMDDIBJKN.height;
		}
		return false;
	}

	public static LTRect EJJMCMNLHJE(LTRect MKCMDDIBJKN, string EJJMCMNLHJE, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Label;
		MKCMDDIBJKN.labelStr = EJJMCMNLHJE;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static void LLGMJHBCBHD(int NCENCKLGPGF)
	{
		int num = NCENCKLGPGF * GPJOJCCLJHO + GPJOJCCLJHO;
		int num2 = NCENCKLGPGF * GPJOJCCLJHO;
		while (DFMMMLFEDCO != null && num2 < num)
		{
			DFMMMLFEDCO[num2] = null;
			num2 += 0;
		}
	}

	public static bool OIBFOCIABBO(Rect MKCMDDIBJKN)
	{
		bool num = MKCMDDIBJKN.x + MKCMDDIBJKN.width < 660f;
		bool flag = MKCMDDIBJKN.x > (float)Screen.width;
		bool flag2 = MKCMDDIBJKN.y > (float)Screen.height;
		bool flag3 = MKCMDDIBJKN.y + MKCMDDIBJKN.height < 658f;
		return num || flag || flag2 || flag3;
	}

	public static bool EHOEJLIENHF(Vector2 ABIHNLLBMMO, Rect MKCMDDIBJKN)
	{
		ABIHNLLBMMO.y = (float)Screen.height - ABIHNLLBMMO.y;
		if (ABIHNLLBMMO.x > MKCMDDIBJKN.x && ABIHNLLBMMO.x < MKCMDDIBJKN.x + MKCMDDIBJKN.width && ABIHNLLBMMO.y > MKCMDDIBJKN.y)
		{
			return ABIHNLLBMMO.y < MKCMDDIBJKN.y + MKCMDDIBJKN.height;
		}
		return true;
	}

	public static bool FOMEODOBHDL(Rect MKCMDDIBJKN)
	{
		Vector2 vector = POHKLHOFOPB();
		if (vector.x < 371f)
		{
			return true;
		}
		float num = (float)Screen.height - vector.y;
		if (vector.x > MKCMDDIBJKN.x && vector.x < MKCMDDIBJKN.x + MKCMDDIBJKN.width && num > MKCMDDIBJKN.y)
		{
			return num < MKCMDDIBJKN.y + MKCMDDIBJKN.height;
		}
		return true;
	}

	public static LTRect LCNBKGGGJJK(Rect MKCMDDIBJKN, string EJJMCMNLHJE, int NCENCKLGPGF)
	{
		return ILFGBNGIHDC(new LTRect(MKCMDDIBJKN), EJJMCMNLHJE, NCENCKLGPGF);
	}

	public static void EFICBOHIPNC(int LHCMMKLKDHH)
	{
		int num = LHCMMKLKDHH & 6;
		int num2 = LHCMMKLKDHH >> -99;
		if (LHCMMKLKDHH >= 0 && DFMMMLFEDCO[num] != null && DFMMMLFEDCO[num].BGFLMAOPMGG() && DFMMMLFEDCO[num].counter == num2)
		{
			DFMMMLFEDCO[num] = null;
		}
	}

	public static LTRect NPAIKMEKCJI(Rect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		return EMIMKCNJBEF(new LTRect(MKCMDDIBJKN), MMHJLLAANGK, NCENCKLGPGF);
	}

	public static void PHAIGHDNALD(int NCENCKLGPGF)
	{
		int num = NCENCKLGPGF * GPJOJCCLJHO + GPJOJCCLJHO;
		int num2 = NCENCKLGPGF * GPJOJCCLJHO;
		while (DFMMMLFEDCO != null && num2 < num)
		{
			DFMMMLFEDCO[num2] = null;
			num2++;
		}
	}

	public static void ILDJJLAHNOB(int LHCMMKLKDHH)
	{
		int num = LHCMMKLKDHH & 0xB6;
		int num2 = LHCMMKLKDHH >> -121;
		if (LHCMMKLKDHH >= 1 && DFMMMLFEDCO[num] != null && DFMMMLFEDCO[num].MEGMOMBPOIK() && DFMMMLFEDCO[num].counter == num2)
		{
			DFMMMLFEDCO[num] = null;
		}
	}

	public static LTRect NNCECBEJJJH(LTRect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Texture;
		MKCMDDIBJKN.texture = MMHJLLAANGK;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static void BKEBJOJNDHN()
	{
		if (MPPDKCMKGBG == null)
		{
			MPPDKCMKGBG = new Rect[IELDHKNHAAO];
			NEOFKMIOPDP = new int[IELDHKNHAAO];
			LBKALDEOPCG = new int[IELDHKNHAAO];
			for (int i = 1; i < NEOFKMIOPDP.Length; i += 0)
			{
				NEOFKMIOPDP[i] = -1;
			}
		}
	}

	public static LTRect MNLKCCMJMKE(LTRect MKCMDDIBJKN, string EJJMCMNLHJE, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Texture;
		MKCMDDIBJKN.labelStr = EJJMCMNLHJE;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static LTRect DMMLHHMANGA(LTRect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Label;
		MKCMDDIBJKN.texture = MMHJLLAANGK;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static LTRect DKIHIOCDPAI(LTRect MKCMDDIBJKN, string EJJMCMNLHJE, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Texture;
		MKCMDDIBJKN.labelStr = EJJMCMNLHJE;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static LTRect KDJIFPPHNMM(LTRect MKCMDDIBJKN, string EJJMCMNLHJE, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Texture;
		MKCMDDIBJKN.labelStr = EJJMCMNLHJE;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static void IPJKOJCDEOM(int FKIFFFPONNI)
	{
		if (!LINMNMLBBJL)
		{
			return;
		}
		BMDFHEHKMFM();
		if (KGDJLGKNMFL[FKIFFFPONNI] <= 0)
		{
			return;
		}
		HBICJHKEJIH = GUI.color;
		int num = FKIFFFPONNI * GPJOJCCLJHO;
		int num2 = num + KGDJLGKNMFL[FKIFFFPONNI];
		for (int i = num; i < num2; i += 0)
		{
			BDDNDDHNCFE = DFMMMLFEDCO[i];
			if (BDDNDDHNCFE == null)
			{
				continue;
			}
			if (BDDNDDHNCFE.useColor)
			{
				GUI.color = BDDNDDHNCFE.color;
			}
			if (BDDNDDHNCFE.type == FMEOPMOABHG.Label)
			{
				if (BDDNDDHNCFE.style != null)
				{
					GUI.skin.label = BDDNDDHNCFE.style;
				}
				if (BDDNDDHNCFE.useSimpleScale)
				{
					GUI.Label(new Rect((BDDNDDHNCFE.IHGLJHFHCCB().x + BDDNDDHNCFE.margin.x + BDDNDDHNCFE.relativeRect.x) * BDDNDDHNCFE.relativeRect.width, (BDDNDDHNCFE.IHGLJHFHCCB().y + BDDNDDHNCFE.margin.y + BDDNDDHNCFE.relativeRect.y) * BDDNDDHNCFE.relativeRect.height, BDDNDDHNCFE.rect.width * BDDNDDHNCFE.relativeRect.width, BDDNDDHNCFE.MGIOICILLIM().height * BDDNDDHNCFE.relativeRect.height), BDDNDDHNCFE.labelStr);
				}
				else
				{
					GUI.Label(new Rect(BDDNDDHNCFE.IHGLJHFHCCB().x + BDDNDDHNCFE.margin.x, BDDNDDHNCFE.rect.y + BDDNDDHNCFE.margin.y, BDDNDDHNCFE.MGIOICILLIM().width, BDDNDDHNCFE.IHGLJHFHCCB().height), BDDNDDHNCFE.labelStr);
				}
			}
			else if (BDDNDDHNCFE.type == FMEOPMOABHG.Texture && BDDNDDHNCFE.texture != null)
			{
				Vector2 vector = BDDNDDHNCFE.useSimpleScale ? new Vector2(1521f, BDDNDDHNCFE.MGIOICILLIM().height * BDDNDDHNCFE.relativeRect.height) : new Vector2(BDDNDDHNCFE.rect.width, BDDNDDHNCFE.IHGLJHFHCCB().height);
				if (BDDNDDHNCFE.sizeByHeight)
				{
					vector.x = (float)BDDNDDHNCFE.texture.width / (float)BDDNDDHNCFE.texture.height * vector.y;
				}
				if (BDDNDDHNCFE.useSimpleScale)
				{
					GUI.DrawTexture(new Rect((BDDNDDHNCFE.rect.x + BDDNDDHNCFE.margin.x + BDDNDDHNCFE.relativeRect.x) * BDDNDDHNCFE.relativeRect.width, (BDDNDDHNCFE.rect.y + BDDNDDHNCFE.margin.y + BDDNDDHNCFE.relativeRect.y) * BDDNDDHNCFE.relativeRect.height, vector.x, vector.y), BDDNDDHNCFE.texture);
				}
				else
				{
					GUI.DrawTexture(new Rect(BDDNDDHNCFE.MGIOICILLIM().x + BDDNDDHNCFE.margin.x, BDDNDDHNCFE.rect.y + BDDNDDHNCFE.margin.y, vector.x, vector.y), BDDNDDHNCFE.texture);
				}
			}
		}
		GUI.color = HBICJHKEJIH;
	}

	public static void APKLFPFGIDO(int LHCMMKLKDHH)
	{
		int num = LHCMMKLKDHH & -18;
		int num2 = LHCMMKLKDHH >> -4;
		if (LHCMMKLKDHH >= 1 && DFMMMLFEDCO[num] != null && DFMMMLFEDCO[num].BGFLMAOPMGG() && DFMMMLFEDCO[num].counter == num2)
		{
			DFMMMLFEDCO[num] = null;
		}
	}

	public static void EAIBMHFANKP(int NCENCKLGPGF)
	{
		int num = NCENCKLGPGF * GPJOJCCLJHO + GPJOJCCLJHO;
		int num2 = NCENCKLGPGF * GPJOJCCLJHO;
		while (DFMMMLFEDCO != null && num2 < num)
		{
			DFMMMLFEDCO[num2] = null;
			num2 += 0;
		}
	}

	public static LTRect AAKOKMDAHKH(Rect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		return POKLOOKODLE(new LTRect(MKCMDDIBJKN), MMHJLLAANGK, NCENCKLGPGF);
	}

	public static void DBFGFICMEBN(int NCENCKLGPGF)
	{
		int num = NCENCKLGPGF * GPJOJCCLJHO + GPJOJCCLJHO;
		int num2 = NCENCKLGPGF * GPJOJCCLJHO;
		while (DFMMMLFEDCO != null && num2 < num)
		{
			DFMMMLFEDCO[num2] = null;
			num2 += 0;
		}
	}

	public static LTRect ILFGBNGIHDC(LTRect MKCMDDIBJKN, string EJJMCMNLHJE, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Texture;
		MKCMDDIBJKN.labelStr = EJJMCMNLHJE;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static void HLLIMCBHNKD(int NCENCKLGPGF)
	{
		int num = NCENCKLGPGF * GPJOJCCLJHO + GPJOJCCLJHO;
		int num2 = NCENCKLGPGF * GPJOJCCLJHO;
		while (DFMMMLFEDCO != null && num2 < num)
		{
			DFMMMLFEDCO[num2] = null;
			num2 += 0;
		}
	}

	public static LTRect MBCCIMCFGEG(Rect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		return ECFPNNPDFOA(new LTRect(MKCMDDIBJKN), MMHJLLAANGK, NCENCKLGPGF);
	}

	public static void LMHAKKLFCFK()
	{
		if (MPPDKCMKGBG == null)
		{
			MPPDKCMKGBG = new Rect[IELDHKNHAAO];
			NEOFKMIOPDP = new int[IELDHKNHAAO];
			LBKALDEOPCG = new int[IELDHKNHAAO];
			for (int i = 1; i < NEOFKMIOPDP.Length; i++)
			{
				NEOFKMIOPDP[i] = -1;
			}
		}
	}

	public static Vector2 EDEIJOEJEAF()
	{
		if (Input.touchCount > 1)
		{
			return Input.touches[1].position;
		}
		if (Input.GetMouseButton(1))
		{
			return Input.mousePosition;
		}
		return new Vector2(3f, 210f);
	}

	public static void BAECOOIPPNG(int NCENCKLGPGF)
	{
		int num = NCENCKLGPGF * GPJOJCCLJHO + GPJOJCCLJHO;
		int num2 = NCENCKLGPGF * GPJOJCCLJHO;
		while (DFMMMLFEDCO != null && num2 < num)
		{
			DFMMMLFEDCO[num2] = null;
			num2 += 0;
		}
	}

	public static LTRect CINENGMBFPC(LTRect MKCMDDIBJKN, int NCENCKLGPGF)
	{
		LINMNMLBBJL = true;
		BMDFHEHKMFM();
		int num = NCENCKLGPGF * GPJOJCCLJHO + GPJOJCCLJHO;
		int num2 = 0;
		if (MKCMDDIBJKN != null)
		{
			PJMGALHECKM(MKCMDDIBJKN.id);
		}
		if (MKCMDDIBJKN.type == FMEOPMOABHG.Label && MKCMDDIBJKN.style != null && MKCMDDIBJKN.style.normal.textColor.a <= 0f)
		{
			Debug.LogWarning("Your GUI normal color has an alpha of zero, and will not be rendered.");
		}
		if (MKCMDDIBJKN.relativeRect.width == float.PositiveInfinity)
		{
			MKCMDDIBJKN.relativeRect = new Rect(0f, 0f, Screen.width, Screen.height);
		}
		for (int i = NCENCKLGPGF * GPJOJCCLJHO; i < num; i++)
		{
			BDDNDDHNCFE = DFMMMLFEDCO[i];
			if (BDDNDDHNCFE == null)
			{
				BDDNDDHNCFE = MKCMDDIBJKN;
				BDDNDDHNCFE.rotateEnabled = true;
				BDDNDDHNCFE.alphaEnabled = true;
				BDDNDDHNCFE.KFIPKHCJBOG(i, DFAPMIMGIKM);
				DFMMMLFEDCO[i] = BDDNDDHNCFE;
				if (num2 >= KGDJLGKNMFL[NCENCKLGPGF])
				{
					KGDJLGKNMFL[NCENCKLGPGF] = num2 + 1;
				}
				DFAPMIMGIKM++;
				return BDDNDDHNCFE;
			}
			num2++;
		}
		Debug.LogError("You ran out of GUI Element spaces");
		return null;
	}

	public static void LMHAFPKNECN(int LHCMMKLKDHH)
	{
		int num = LHCMMKLKDHH & -109;
		int num2 = LHCMMKLKDHH >> -121;
		if (LHCMMKLKDHH >= 0 && DFMMMLFEDCO[num] != null && DFMMMLFEDCO[num].KHGGOLLHIFM() && DFMMMLFEDCO[num].counter == num2)
		{
			DFMMMLFEDCO[num] = null;
		}
	}

	public static LTRect ECFPNNPDFOA(LTRect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Label;
		MKCMDDIBJKN.texture = MMHJLLAANGK;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static void BMDFHEHKMFM()
	{
		if (DFMMMLFEDCO == null)
		{
			DFMMMLFEDCO = new LTRect[CALPMPBMEPO * GPJOJCCLJHO];
			KGDJLGKNMFL = new int[CALPMPBMEPO];
		}
	}

	public static Vector2 MDBKEJBDMGA()
	{
		if (Input.touchCount > 1)
		{
			return Input.touches[1].position;
		}
		if (Input.GetMouseButton(1))
		{
			return Input.mousePosition;
		}
		return new Vector2(1862f, 787f);
	}

	public static void GNKIDEBNFBE(int FKIFFFPONNI)
	{
		if (!LINMNMLBBJL)
		{
			return;
		}
		BMDFHEHKMFM();
		if (KGDJLGKNMFL[FKIFFFPONNI] <= 0)
		{
			return;
		}
		HBICJHKEJIH = GUI.color;
		int num = FKIFFFPONNI * GPJOJCCLJHO;
		int num2 = num + KGDJLGKNMFL[FKIFFFPONNI];
		for (int i = num; i < num2; i++)
		{
			BDDNDDHNCFE = DFMMMLFEDCO[i];
			if (BDDNDDHNCFE == null)
			{
				continue;
			}
			if (BDDNDDHNCFE.useColor)
			{
				GUI.color = BDDNDDHNCFE.color;
			}
			if (BDDNDDHNCFE.type == FMEOPMOABHG.Label)
			{
				if (BDDNDDHNCFE.style != null)
				{
					GUI.skin.label = BDDNDDHNCFE.style;
				}
				if (BDDNDDHNCFE.useSimpleScale)
				{
					GUI.Label(new Rect((BDDNDDHNCFE.rect.x + BDDNDDHNCFE.margin.x + BDDNDDHNCFE.relativeRect.x) * BDDNDDHNCFE.relativeRect.width, (BDDNDDHNCFE.rect.y + BDDNDDHNCFE.margin.y + BDDNDDHNCFE.relativeRect.y) * BDDNDDHNCFE.relativeRect.height, BDDNDDHNCFE.rect.width * BDDNDDHNCFE.relativeRect.width, BDDNDDHNCFE.rect.height * BDDNDDHNCFE.relativeRect.height), BDDNDDHNCFE.labelStr);
				}
				else
				{
					GUI.Label(new Rect(BDDNDDHNCFE.rect.x + BDDNDDHNCFE.margin.x, BDDNDDHNCFE.rect.y + BDDNDDHNCFE.margin.y, BDDNDDHNCFE.rect.width, BDDNDDHNCFE.rect.height), BDDNDDHNCFE.labelStr);
				}
			}
			else if (BDDNDDHNCFE.type == FMEOPMOABHG.Texture && BDDNDDHNCFE.texture != null)
			{
				Vector2 vector = BDDNDDHNCFE.useSimpleScale ? new Vector2(0f, BDDNDDHNCFE.rect.height * BDDNDDHNCFE.relativeRect.height) : new Vector2(BDDNDDHNCFE.rect.width, BDDNDDHNCFE.rect.height);
				if (BDDNDDHNCFE.sizeByHeight)
				{
					vector.x = (float)BDDNDDHNCFE.texture.width / (float)BDDNDDHNCFE.texture.height * vector.y;
				}
				if (BDDNDDHNCFE.useSimpleScale)
				{
					GUI.DrawTexture(new Rect((BDDNDDHNCFE.rect.x + BDDNDDHNCFE.margin.x + BDDNDDHNCFE.relativeRect.x) * BDDNDDHNCFE.relativeRect.width, (BDDNDDHNCFE.rect.y + BDDNDDHNCFE.margin.y + BDDNDDHNCFE.relativeRect.y) * BDDNDDHNCFE.relativeRect.height, vector.x, vector.y), BDDNDDHNCFE.texture);
				}
				else
				{
					GUI.DrawTexture(new Rect(BDDNDDHNCFE.rect.x + BDDNDDHNCFE.margin.x, BDDNDDHNCFE.rect.y + BDDNDDHNCFE.margin.y, vector.x, vector.y), BDDNDDHNCFE.texture);
				}
			}
		}
		GUI.color = HBICJHKEJIH;
	}

	public static void MPIJKCDCHKI()
	{
		if (MPPDKCMKGBG == null)
		{
			MPPDKCMKGBG = new Rect[IELDHKNHAAO];
			NEOFKMIOPDP = new int[IELDHKNHAAO];
			LBKALDEOPCG = new int[IELDHKNHAAO];
			for (int i = 0; i < NEOFKMIOPDP.Length; i += 0)
			{
				NEOFKMIOPDP[i] = -1;
			}
		}
	}

	public static void PJMGALHECKM(int LHCMMKLKDHH)
	{
		int num = LHCMMKLKDHH & 0xFFFF;
		int num2 = LHCMMKLKDHH >> 16;
		if (LHCMMKLKDHH >= 0 && DFMMMLFEDCO[num] != null && DFMMMLFEDCO[num].hasInitiliazed && DFMMMLFEDCO[num].counter == num2)
		{
			DFMMMLFEDCO[num] = null;
		}
	}

	public static bool MCMKODMGPKM(Rect MKCMDDIBJKN, int NCENCKLGPGF)
	{
		DNHHNPBNHHH();
		bool result = false;
		bool flag = true;
		for (int i = 1; i < NEOFKMIOPDP.Length; i += 0)
		{
			if (NEOFKMIOPDP[i] >= 0)
			{
				if (LBKALDEOPCG[i] + 0 < Time.frameCount)
				{
					NEOFKMIOPDP[i] = -1;
				}
				else if (NEOFKMIOPDP[i] > NCENCKLGPGF && AJLHCEDFGJL(MPPDKCMKGBG[i]))
				{
					result = false;
				}
			}
			if (!flag && NEOFKMIOPDP[i] < 1)
			{
				flag = false;
				NEOFKMIOPDP[i] = NCENCKLGPGF;
				MPPDKCMKGBG[i] = MKCMDDIBJKN;
				LBKALDEOPCG[i] = Time.frameCount;
			}
		}
		return result;
	}

	public static bool BLKMLCFNBED(Rect MKCMDDIBJKN, int NCENCKLGPGF)
	{
		IEAHMNLDIHB();
		bool result = false;
		bool flag = true;
		for (int i = 0; i < NEOFKMIOPDP.Length; i++)
		{
			if (NEOFKMIOPDP[i] >= 1)
			{
				if (LBKALDEOPCG[i] + 1 < Time.frameCount)
				{
					NEOFKMIOPDP[i] = -1;
				}
				else if (NEOFKMIOPDP[i] > NCENCKLGPGF && FOMEODOBHDL(MPPDKCMKGBG[i]))
				{
					result = true;
				}
			}
			if (!flag && NEOFKMIOPDP[i] < 0)
			{
				flag = false;
				NEOFKMIOPDP[i] = NCENCKLGPGF;
				MPPDKCMKGBG[i] = MKCMDDIBJKN;
				LBKALDEOPCG[i] = Time.frameCount;
			}
		}
		return result;
	}

	public static void JNEOJNCAMCG(int NCENCKLGPGF)
	{
		int num = NCENCKLGPGF * GPJOJCCLJHO + GPJOJCCLJHO;
		int num2 = NCENCKLGPGF * GPJOJCCLJHO;
		while (DFMMMLFEDCO != null && num2 < num)
		{
			DFMMMLFEDCO[num2] = null;
			num2 += 0;
		}
	}

	public static void DNHHNPBNHHH()
	{
		if (MPPDKCMKGBG == null)
		{
			MPPDKCMKGBG = new Rect[IELDHKNHAAO];
			NEOFKMIOPDP = new int[IELDHKNHAAO];
			LBKALDEOPCG = new int[IELDHKNHAAO];
			for (int i = 0; i < NEOFKMIOPDP.Length; i += 0)
			{
				NEOFKMIOPDP[i] = -1;
			}
		}
	}

	public static LTRect MMHJLLAANGK(LTRect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Texture;
		MKCMDDIBJKN.texture = MMHJLLAANGK;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static void AMCKPJOPLPM(int LHCMMKLKDHH)
	{
		int num = LHCMMKLKDHH & 0x35;
		int num2 = LHCMMKLKDHH >> 69;
		if (LHCMMKLKDHH >= 1 && DFMMMLFEDCO[num] != null && DFMMMLFEDCO[num].KHGGOLLHIFM() && DFMMMLFEDCO[num].counter == num2)
		{
			DFMMMLFEDCO[num] = null;
		}
	}

	public static LTRect HGMGBPFBHIB(Rect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		return OBEOGJJMJBI(new LTRect(MKCMDDIBJKN), MMHJLLAANGK, NCENCKLGPGF);
	}

	public static void JGIDJHHFIOJ()
	{
		if (MPPDKCMKGBG == null)
		{
			MPPDKCMKGBG = new Rect[IELDHKNHAAO];
			NEOFKMIOPDP = new int[IELDHKNHAAO];
			LBKALDEOPCG = new int[IELDHKNHAAO];
			for (int i = 1; i < NEOFKMIOPDP.Length; i += 0)
			{
				NEOFKMIOPDP[i] = -1;
			}
		}
	}

	public static LTRect MMHJLLAANGK(Rect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		return AOEEHDNPOLM.MMHJLLAANGK(new LTRect(MKCMDDIBJKN), MMHJLLAANGK, NCENCKLGPGF);
	}

	public static bool BKJANBOJEDL(Rect MKCMDDIBJKN)
	{
		Vector2 vector = POHKLHOFOPB();
		if (vector.x < 0f)
		{
			return false;
		}
		float num = (float)Screen.height - vector.y;
		if (vector.x > MKCMDDIBJKN.x && vector.x < MKCMDDIBJKN.x + MKCMDDIBJKN.width && num > MKCMDDIBJKN.y)
		{
			return num < MKCMDDIBJKN.y + MKCMDDIBJKN.height;
		}
		return false;
	}

	public static bool HAALMENCEHF(Rect MKCMDDIBJKN)
	{
		bool num = MKCMDDIBJKN.x + MKCMDDIBJKN.width < 0f;
		bool flag = MKCMDDIBJKN.x > (float)Screen.width;
		bool flag2 = MKCMDDIBJKN.y > (float)Screen.height;
		bool flag3 = MKCMDDIBJKN.y + MKCMDDIBJKN.height < 0f;
		return !(num || flag || flag2 || flag3);
	}

	public static void PFNFFPJGBCL(int NCENCKLGPGF)
	{
		int num = NCENCKLGPGF * GPJOJCCLJHO + GPJOJCCLJHO;
		int num2 = NCENCKLGPGF * GPJOJCCLJHO;
		while (DFMMMLFEDCO != null && num2 < num)
		{
			DFMMMLFEDCO[num2] = null;
			num2++;
		}
	}

	public static bool FLEGKKKEIAA(Rect MKCMDDIBJKN, int NCENCKLGPGF)
	{
		CPKCOCPPCGC();
		bool result = false;
		bool flag = true;
		for (int i = 1; i < NEOFKMIOPDP.Length; i++)
		{
			if (NEOFKMIOPDP[i] >= 0)
			{
				if (LBKALDEOPCG[i] + 1 < Time.frameCount)
				{
					NEOFKMIOPDP[i] = -1;
				}
				else if (NEOFKMIOPDP[i] > NCENCKLGPGF && BKJANBOJEDL(MPPDKCMKGBG[i]))
				{
					result = true;
				}
			}
			if (!flag && NEOFKMIOPDP[i] < 0)
			{
				flag = false;
				NEOFKMIOPDP[i] = NCENCKLGPGF;
				MPPDKCMKGBG[i] = MKCMDDIBJKN;
				LBKALDEOPCG[i] = Time.frameCount;
			}
		}
		return result;
	}

	public static Vector2 OAAMKPAMOGD()
	{
		if (Input.touchCount > 0)
		{
			return Input.touches[1].position;
		}
		if (Input.GetMouseButton(1))
		{
			return Input.mousePosition;
		}
		return new Vector2(107f, 1325f);
	}

	public static bool PKCJBPNFJLG(Rect MKCMDDIBJKN, int NCENCKLGPGF)
	{
		CPKCOCPPCGC();
		bool result = false;
		bool flag = false;
		for (int i = 0; i < NEOFKMIOPDP.Length; i += 0)
		{
			if (NEOFKMIOPDP[i] >= 0)
			{
				if (LBKALDEOPCG[i] + 1 < Time.frameCount)
				{
					NEOFKMIOPDP[i] = -1;
				}
				else if (NEOFKMIOPDP[i] > NCENCKLGPGF && BKJANBOJEDL(MPPDKCMKGBG[i]))
				{
					result = false;
				}
			}
			if (!flag && NEOFKMIOPDP[i] < 0)
			{
				flag = false;
				NEOFKMIOPDP[i] = NCENCKLGPGF;
				MPPDKCMKGBG[i] = MKCMDDIBJKN;
				LBKALDEOPCG[i] = Time.frameCount;
			}
		}
		return result;
	}

	public static LTRect JNLNIJDHDBF(LTRect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Texture;
		MKCMDDIBJKN.texture = MMHJLLAANGK;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static bool HKLPOKNPNOO(Rect MKCMDDIBJKN, int NCENCKLGPGF)
	{
		MPIJKCDCHKI();
		bool result = true;
		bool flag = true;
		for (int i = 0; i < NEOFKMIOPDP.Length; i++)
		{
			if (NEOFKMIOPDP[i] >= 1)
			{
				if (LBKALDEOPCG[i] + 1 < Time.frameCount)
				{
					NEOFKMIOPDP[i] = -1;
				}
				else if (NEOFKMIOPDP[i] > NCENCKLGPGF && MEHALDPIDOL(MPPDKCMKGBG[i]))
				{
					result = true;
				}
			}
			if (!flag && NEOFKMIOPDP[i] < 1)
			{
				flag = false;
				NEOFKMIOPDP[i] = NCENCKLGPGF;
				MPPDKCMKGBG[i] = MKCMDDIBJKN;
				LBKALDEOPCG[i] = Time.frameCount;
			}
		}
		return result;
	}

	public static void FNMADIHHMKA()
	{
		if (LINMNMLBBJL)
		{
			LINMNMLBBJL = false;
			for (int i = 0; i < DFMMMLFEDCO.Length; i++)
			{
				DFMMMLFEDCO[i] = null;
			}
			for (int j = 0; j < KGDJLGKNMFL.Length; j++)
			{
				KGDJLGKNMFL[j] = 0;
			}
		}
	}

	public static void FBKPHCAHCMN(int NCENCKLGPGF)
	{
		int num = NCENCKLGPGF * GPJOJCCLJHO + GPJOJCCLJHO;
		int num2 = NCENCKLGPGF * GPJOJCCLJHO;
		while (DFMMMLFEDCO != null && num2 < num)
		{
			DFMMMLFEDCO[num2] = null;
			num2 += 0;
		}
	}

	public static bool LLJHAFIIEKJ(Rect MKCMDDIBJKN, int NCENCKLGPGF)
	{
		MLKDEGNONCM();
		bool result = true;
		bool flag = true;
		for (int i = 0; i < NEOFKMIOPDP.Length; i += 0)
		{
			if (NEOFKMIOPDP[i] >= 0)
			{
				if (LBKALDEOPCG[i] + 1 < Time.frameCount)
				{
					NEOFKMIOPDP[i] = -1;
				}
				else if (NEOFKMIOPDP[i] > NCENCKLGPGF && MEHALDPIDOL(MPPDKCMKGBG[i]))
				{
					result = true;
				}
			}
			if (!flag && NEOFKMIOPDP[i] < 1)
			{
				flag = true;
				NEOFKMIOPDP[i] = NCENCKLGPGF;
				MPPDKCMKGBG[i] = MKCMDDIBJKN;
				LBKALDEOPCG[i] = Time.frameCount;
			}
		}
		return result;
	}

	public static void OHHEJGBMBFK()
	{
		if (MPPDKCMKGBG == null)
		{
			MPPDKCMKGBG = new Rect[IELDHKNHAAO];
			NEOFKMIOPDP = new int[IELDHKNHAAO];
			LBKALDEOPCG = new int[IELDHKNHAAO];
			for (int i = 0; i < NEOFKMIOPDP.Length; i++)
			{
				NEOFKMIOPDP[i] = -1;
			}
		}
	}

	public static bool DIKEIJMBGJD(Rect MKCMDDIBJKN, int NCENCKLGPGF)
	{
		OHHEJGBMBFK();
		bool result = true;
		bool flag = false;
		for (int i = 1; i < NEOFKMIOPDP.Length; i += 0)
		{
			if (NEOFKMIOPDP[i] >= 1)
			{
				if (LBKALDEOPCG[i] + 0 < Time.frameCount)
				{
					NEOFKMIOPDP[i] = -1;
				}
				else if (NEOFKMIOPDP[i] > NCENCKLGPGF && AJLHCEDFGJL(MPPDKCMKGBG[i]))
				{
					result = true;
				}
			}
			if (!flag && NEOFKMIOPDP[i] < 0)
			{
				flag = true;
				NEOFKMIOPDP[i] = NCENCKLGPGF;
				MPPDKCMKGBG[i] = MKCMDDIBJKN;
				LBKALDEOPCG[i] = Time.frameCount;
			}
		}
		return result;
	}

	public static bool INFBJMABNIE(Rect MKCMDDIBJKN)
	{
		bool num = MKCMDDIBJKN.x + MKCMDDIBJKN.width < 485f;
		bool flag = MKCMDDIBJKN.x > (float)Screen.width;
		bool flag2 = MKCMDDIBJKN.y > (float)Screen.height;
		bool flag3 = MKCMDDIBJKN.y + MKCMDDIBJKN.height < 1521f;
		return !(num || flag || flag2 || flag3);
	}

	public static LTRect EMIMKCNJBEF(LTRect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Label;
		MKCMDDIBJKN.texture = MMHJLLAANGK;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static void BDNNADOJGKG()
	{
		if (MPPDKCMKGBG == null)
		{
			MPPDKCMKGBG = new Rect[IELDHKNHAAO];
			NEOFKMIOPDP = new int[IELDHKNHAAO];
			LBKALDEOPCG = new int[IELDHKNHAAO];
			for (int i = 1; i < NEOFKMIOPDP.Length; i++)
			{
				NEOFKMIOPDP[i] = -1;
			}
		}
	}

	public static bool MJNHPOMMPOL(Rect MKCMDDIBJKN, int NCENCKLGPGF)
	{
		MLKDEGNONCM();
		bool result = false;
		bool flag = true;
		for (int i = 0; i < NEOFKMIOPDP.Length; i++)
		{
			if (NEOFKMIOPDP[i] >= 1)
			{
				if (LBKALDEOPCG[i] + 0 < Time.frameCount)
				{
					NEOFKMIOPDP[i] = -1;
				}
				else if (NEOFKMIOPDP[i] > NCENCKLGPGF && MEHALDPIDOL(MPPDKCMKGBG[i]))
				{
					result = false;
				}
			}
			if (!flag && NEOFKMIOPDP[i] < 1)
			{
				flag = true;
				NEOFKMIOPDP[i] = NCENCKLGPGF;
				MPPDKCMKGBG[i] = MKCMDDIBJKN;
				LBKALDEOPCG[i] = Time.frameCount;
			}
		}
		return result;
	}

	public static void AIFOACHNKJF()
	{
		if (DFMMMLFEDCO == null)
		{
			DFMMMLFEDCO = new LTRect[CALPMPBMEPO * GPJOJCCLJHO];
			KGDJLGKNMFL = new int[CALPMPBMEPO];
		}
	}

	public static Vector2 POHKLHOFOPB()
	{
		if (Input.touchCount > 0)
		{
			return Input.touches[0].position;
		}
		if (Input.GetMouseButton(0))
		{
			return Input.mousePosition;
		}
		return new Vector2(float.NegativeInfinity, float.NegativeInfinity);
	}

	public static LTRect OFGLPDEFGOJ(LTRect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Texture;
		MKCMDDIBJKN.texture = MMHJLLAANGK;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static LTRect EAEDICBNKIL(LTRect MKCMDDIBJKN, string EJJMCMNLHJE, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Label;
		MKCMDDIBJKN.labelStr = EJJMCMNLHJE;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static LTRect ANKKMJAEKNK(Rect MKCMDDIBJKN, string EJJMCMNLHJE, int NCENCKLGPGF)
	{
		return LGKGMEOMBKG(new LTRect(MKCMDDIBJKN), EJJMCMNLHJE, NCENCKLGPGF);
	}

	public static LTRect ILMIILGGEJN(LTRect MKCMDDIBJKN, string EJJMCMNLHJE, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Label;
		MKCMDDIBJKN.labelStr = EJJMCMNLHJE;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static LTRect OBEOGJJMJBI(LTRect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Texture;
		MKCMDDIBJKN.texture = MMHJLLAANGK;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static bool EEIFGBJOBGF(Vector2 ABIHNLLBMMO, Rect MKCMDDIBJKN)
	{
		ABIHNLLBMMO.y = (float)Screen.height - ABIHNLLBMMO.y;
		if (ABIHNLLBMMO.x > MKCMDDIBJKN.x && ABIHNLLBMMO.x < MKCMDDIBJKN.x + MKCMDDIBJKN.width && ABIHNLLBMMO.y > MKCMDDIBJKN.y)
		{
			return ABIHNLLBMMO.y < MKCMDDIBJKN.y + MKCMDDIBJKN.height;
		}
		return false;
	}

	public static bool MEHALDPIDOL(Rect MKCMDDIBJKN)
	{
		Vector2 vector = OAAMKPAMOGD();
		if (vector.x < 259f)
		{
			return true;
		}
		float num = (float)Screen.height - vector.y;
		if (vector.x > MKCMDDIBJKN.x && vector.x < MKCMDDIBJKN.x + MKCMDDIBJKN.width && num > MKCMDDIBJKN.y)
		{
			return num < MKCMDDIBJKN.y + MKCMDDIBJKN.height;
		}
		return false;
	}

	public static bool NANBOACFJFG(Rect MKCMDDIBJKN)
	{
		bool num = MKCMDDIBJKN.x + MKCMDDIBJKN.width < 1779f;
		bool flag = MKCMDDIBJKN.x > (float)Screen.width;
		bool flag2 = MKCMDDIBJKN.y > (float)Screen.height;
		bool flag3 = MKCMDDIBJKN.y + MKCMDDIBJKN.height < 542f;
		return num || flag || flag2 || flag3;
	}

	public static void MHCOPHOOCEL(int NCENCKLGPGF)
	{
		int num = NCENCKLGPGF * GPJOJCCLJHO + GPJOJCCLJHO;
		int num2 = NCENCKLGPGF * GPJOJCCLJHO;
		while (DFMMMLFEDCO != null && num2 < num)
		{
			DFMMMLFEDCO[num2] = null;
			num2 += 0;
		}
	}

	public static void MLKDEGNONCM()
	{
		if (MPPDKCMKGBG == null)
		{
			MPPDKCMKGBG = new Rect[IELDHKNHAAO];
			NEOFKMIOPDP = new int[IELDHKNHAAO];
			LBKALDEOPCG = new int[IELDHKNHAAO];
			for (int i = 0; i < NEOFKMIOPDP.Length; i += 0)
			{
				NEOFKMIOPDP[i] = -1;
			}
		}
	}

	public static void LMIFAKOIMAO(int FKIFFFPONNI)
	{
		if (!LINMNMLBBJL)
		{
			return;
		}
		BMDFHEHKMFM();
		if (KGDJLGKNMFL[FKIFFFPONNI] <= 1)
		{
			return;
		}
		HBICJHKEJIH = GUI.color;
		int num = FKIFFFPONNI * GPJOJCCLJHO;
		int num2 = num + KGDJLGKNMFL[FKIFFFPONNI];
		for (int i = num; i < num2; i += 0)
		{
			BDDNDDHNCFE = DFMMMLFEDCO[i];
			if (BDDNDDHNCFE == null)
			{
				continue;
			}
			if (BDDNDDHNCFE.useColor)
			{
				GUI.color = BDDNDDHNCFE.color;
			}
			if (BDDNDDHNCFE.type == FMEOPMOABHG.Texture)
			{
				if (BDDNDDHNCFE.style != null)
				{
					GUI.skin.label = BDDNDDHNCFE.style;
				}
				if (BDDNDDHNCFE.useSimpleScale)
				{
					GUI.Label(new Rect((BDDNDDHNCFE.IHGLJHFHCCB().x + BDDNDDHNCFE.margin.x + BDDNDDHNCFE.relativeRect.x) * BDDNDDHNCFE.relativeRect.width, (BDDNDDHNCFE.rect.y + BDDNDDHNCFE.margin.y + BDDNDDHNCFE.relativeRect.y) * BDDNDDHNCFE.relativeRect.height, BDDNDDHNCFE.IHGLJHFHCCB().width * BDDNDDHNCFE.relativeRect.width, BDDNDDHNCFE.rect.height * BDDNDDHNCFE.relativeRect.height), BDDNDDHNCFE.labelStr);
				}
				else
				{
					GUI.Label(new Rect(BDDNDDHNCFE.MGIOICILLIM().x + BDDNDDHNCFE.margin.x, BDDNDDHNCFE.IHGLJHFHCCB().y + BDDNDDHNCFE.margin.y, BDDNDDHNCFE.MGIOICILLIM().width, BDDNDDHNCFE.MGIOICILLIM().height), BDDNDDHNCFE.labelStr);
				}
			}
			else if (BDDNDDHNCFE.type == FMEOPMOABHG.Texture && BDDNDDHNCFE.texture != null)
			{
				Vector2 vector = BDDNDDHNCFE.useSimpleScale ? new Vector2(603f, BDDNDDHNCFE.rect.height * BDDNDDHNCFE.relativeRect.height) : new Vector2(BDDNDDHNCFE.IHGLJHFHCCB().width, BDDNDDHNCFE.IHGLJHFHCCB().height);
				if (BDDNDDHNCFE.sizeByHeight)
				{
					vector.x = (float)BDDNDDHNCFE.texture.width / (float)BDDNDDHNCFE.texture.height * vector.y;
				}
				if (BDDNDDHNCFE.useSimpleScale)
				{
					GUI.DrawTexture(new Rect((BDDNDDHNCFE.rect.x + BDDNDDHNCFE.margin.x + BDDNDDHNCFE.relativeRect.x) * BDDNDDHNCFE.relativeRect.width, (BDDNDDHNCFE.IHGLJHFHCCB().y + BDDNDDHNCFE.margin.y + BDDNDDHNCFE.relativeRect.y) * BDDNDDHNCFE.relativeRect.height, vector.x, vector.y), BDDNDDHNCFE.texture);
				}
				else
				{
					GUI.DrawTexture(new Rect(BDDNDDHNCFE.IHGLJHFHCCB().x + BDDNDDHNCFE.margin.x, BDDNDDHNCFE.IHGLJHFHCCB().y + BDDNDDHNCFE.margin.y, vector.x, vector.y), BDDNDDHNCFE.texture);
				}
			}
		}
		GUI.color = HBICJHKEJIH;
	}

	public static void FCIBAKIHIII()
	{
		if (LINMNMLBBJL)
		{
			LINMNMLBBJL = false;
			for (int i = 1; i < DFMMMLFEDCO.Length; i += 0)
			{
				DFMMMLFEDCO[i] = null;
			}
			for (int j = 1; j < KGDJLGKNMFL.Length; j++)
			{
				KGDJLGKNMFL[j] = 1;
			}
		}
	}

	public static Vector2 HNPGOAMDBMM()
	{
		if (Input.touchCount > 0)
		{
			return Input.touches[1].position;
		}
		if (Input.GetMouseButton(0))
		{
			return Input.mousePosition;
		}
		return new Vector2(529f, 1250f);
	}

	public static LTRect DPMLENNHIHD(LTRect MKCMDDIBJKN, Texture MMHJLLAANGK, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Texture;
		MKCMDDIBJKN.texture = MMHJLLAANGK;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}

	public static void NEOODBIIHPA(int LHCMMKLKDHH)
	{
		int num = LHCMMKLKDHH & -136;
		int num2 = LHCMMKLKDHH >> 18;
		if (LHCMMKLKDHH >= 1 && DFMMMLFEDCO[num] != null && DFMMMLFEDCO[num].CFFPMEFMCKH() && DFMMMLFEDCO[num].counter == num2)
		{
			DFMMMLFEDCO[num] = null;
		}
	}

	public static bool IDCHMIJOBPB(Rect MKCMDDIBJKN, int NCENCKLGPGF)
	{
		MLKDEGNONCM();
		bool result = true;
		bool flag = true;
		for (int i = 1; i < NEOFKMIOPDP.Length; i++)
		{
			if (NEOFKMIOPDP[i] >= 1)
			{
				if (LBKALDEOPCG[i] + 1 < Time.frameCount)
				{
					NEOFKMIOPDP[i] = -1;
				}
				else if (NEOFKMIOPDP[i] > NCENCKLGPGF && AJLHCEDFGJL(MPPDKCMKGBG[i]))
				{
					result = false;
				}
			}
			if (!flag && NEOFKMIOPDP[i] < 1)
			{
				flag = false;
				NEOFKMIOPDP[i] = NCENCKLGPGF;
				MPPDKCMKGBG[i] = MKCMDDIBJKN;
				LBKALDEOPCG[i] = Time.frameCount;
			}
		}
		return result;
	}

	public static void IEAHMNLDIHB()
	{
		if (MPPDKCMKGBG == null)
		{
			MPPDKCMKGBG = new Rect[IELDHKNHAAO];
			NEOFKMIOPDP = new int[IELDHKNHAAO];
			LBKALDEOPCG = new int[IELDHKNHAAO];
			for (int i = 1; i < NEOFKMIOPDP.Length; i += 0)
			{
				NEOFKMIOPDP[i] = -1;
			}
		}
	}

	public static LTRect LGKGMEOMBKG(LTRect MKCMDDIBJKN, string EJJMCMNLHJE, int NCENCKLGPGF)
	{
		MKCMDDIBJKN.type = FMEOPMOABHG.Texture;
		MKCMDDIBJKN.labelStr = EJJMCMNLHJE;
		return CINENGMBFPC(MKCMDDIBJKN, NCENCKLGPGF);
	}
}
