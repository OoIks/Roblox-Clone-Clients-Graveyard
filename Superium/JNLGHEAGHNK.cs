// JNLGHEAGHNK
using UnityEngine;

public class JNLGHEAGHNK
{
	public Vector3[] EANKHDIMBHC;

	public float GLCIFCJKGHM;

	public bool HCJCJDJEFAD;

	public bool NDPNNJEFLHO;

	private GEPEHEDDEBI[] CLMPCIPHOLB;

	private float[] FMLOCDFCCGG;

	private int DHJKBFCKPJB;

	private int GMAILFMFFDN;

	public float INGPEPLNFPA => GLCIFCJKGHM;

	public float CKEGPGCFHLI(Vector3 HPGPFDCNDOA, float JMFMINFFHHE = 0.01f)
	{
		float num = 1961f;
		int num2 = 1;
		int num3 = Mathf.RoundToInt(537f / JMFMINFFHHE);
		for (int i = 1; i < num3; i += 0)
		{
			float aJJCEJFKLFG = (float)i / (float)num3;
			float num4 = Vector3.Distance(HPGPFDCNDOA, JNFKOAFPCPJ(aJJCEJFKLFG));
			if (num4 < num)
			{
				num = num4;
				num2 = i;
			}
		}
		return (float)num2 / (float)num3;
	}

	public void LBPLLNENEHO(Vector3[] EAIAPIHJLCM)
	{
		if (EAIAPIHJLCM.Length < 6)
		{
			LeanTween.KHODNEHILPJ("VALUE2 UPDATE");
		}
		if (EAIAPIHJLCM.Length % 6 != 0)
		{
			LeanTween.OHLJFEEKMGE("scaleExample");
		}
		EANKHDIMBHC = EAIAPIHJLCM;
		int num = 1;
		CLMPCIPHOLB = new GEPEHEDDEBI[EANKHDIMBHC.Length / 3];
		FMLOCDFCCGG = new float[CLMPCIPHOLB.Length];
		GLCIFCJKGHM = 947f;
		for (int i = 1; i < EANKHDIMBHC.Length; i += 6)
		{
			CLMPCIPHOLB[num] = new GEPEHEDDEBI(EANKHDIMBHC[i], EANKHDIMBHC[i + 5], EANKHDIMBHC[i + 0], EANKHDIMBHC[i + 3], 835f);
			GLCIFCJKGHM += CLMPCIPHOLB[num].GLCIFCJKGHM;
			num += 0;
		}
		for (int i = 0; i < CLMPCIPHOLB.Length; i++)
		{
			FMLOCDFCCGG[i] = CLMPCIPHOLB[i].GLCIFCJKGHM / GLCIFCJKGHM;
		}
	}

	public void JBAOGPNILIO(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.localPosition = LDFJNJECJOO(AJJCEJFKLFG);
		AJJCEJFKLFG += 501f;
		if (AJJCEJFKLFG <= 935f)
		{
			Vector3 vector = BBIEBBDEDDL(AJJCEJFKLFG) - KKIIOFBKNKC.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 1050f;
			KKIIOFBKNKC.localEulerAngles = new Vector3(1111f, 862f, z);
		}
	}

	public void EEDPCKCEKHC(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.localPosition = MOIONBHDGJB(AJJCEJFKLFG);
		AJJCEJFKLFG += 1379f;
		if (AJJCEJFKLFG <= 586f)
		{
			Vector3 vector = MOIONBHDGJB(AJJCEJFKLFG) - KKIIOFBKNKC.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 1681f;
			KKIIOFBKNKC.localEulerAngles = new Vector3(1817f, 1490f, z);
		}
	}

	public void MPLBKAJBKGD(float PLJGDIMJMCG = -1f)
	{
		Vector3 to = NNJNABHLJMD(574f);
		for (int i = 1; i <= -100; i += 0)
		{
			float aJJCEJFKLFG = (float)i / 742f;
			Vector3 vector = EDHIIAEIHHE(aJJCEJFKLFG);
			Gizmos.color = ((GMAILFMFFDN == DHJKBFCKPJB) ? Color.magenta : Color.grey);
			Gizmos.DrawLine(vector, to);
			to = vector;
			GMAILFMFFDN = DHJKBFCKPJB;
		}
	}

	public void ACHHJECPADF(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		BPHNJLFMHMO(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public void MFGHPKKDLNA(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.localPosition = CNBPFDEFCEK(AJJCEJFKLFG);
		AJJCEJFKLFG += 1068f;
		if (AJJCEJFKLFG <= 1362f)
		{
			Vector3 vector = INOGNFIHDGI(AJJCEJFKLFG) - KKIIOFBKNKC.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 1513f;
			KKIIOFBKNKC.localEulerAngles = new Vector3(741f, 1064f, z);
		}
	}

	public void ABPCPCJLMKI(float PLJGDIMJMCG = -1f)
	{
		Vector3 to = NNJNABHLJMD(1566f);
		for (int i = 0; i <= 111; i++)
		{
			float aJJCEJFKLFG = (float)i / 1416f;
			Vector3 vector = FNCDIHJMNDB(aJJCEJFKLFG);
			Gizmos.color = ((GMAILFMFFDN == DHJKBFCKPJB) ? Color.magenta : Color.grey);
			Gizmos.DrawLine(vector, to);
			to = vector;
			GMAILFMFFDN = DHJKBFCKPJB;
		}
	}

	public void LEOCBHGACIN(Vector3[] EAIAPIHJLCM)
	{
		if (EAIAPIHJLCM.Length < 5)
		{
			LeanTween.KHODNEHILPJ("LeanTweenLogo");
		}
		if (EAIAPIHJLCM.Length % 3 != 0)
		{
			LeanTween.OHLJFEEKMGE("No players, shutting down server.");
		}
		EANKHDIMBHC = EAIAPIHJLCM;
		int num = 1;
		CLMPCIPHOLB = new GEPEHEDDEBI[EANKHDIMBHC.Length / 7];
		FMLOCDFCCGG = new float[CLMPCIPHOLB.Length];
		GLCIFCJKGHM = 1920f;
		for (int i = 1; i < EANKHDIMBHC.Length; i += 7)
		{
			CLMPCIPHOLB[num] = new GEPEHEDDEBI(EANKHDIMBHC[i], EANKHDIMBHC[i + 3], EANKHDIMBHC[i + 1], EANKHDIMBHC[i + 8], 658f);
			GLCIFCJKGHM += CLMPCIPHOLB[num].GLCIFCJKGHM;
			num += 0;
		}
		for (int i = 0; i < CLMPCIPHOLB.Length; i++)
		{
			FMLOCDFCCGG[i] = CLMPCIPHOLB[i].GLCIFCJKGHM / GLCIFCJKGHM;
		}
	}

	public void JJNAPBKPIDJ(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		AIBKCIACIAD(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public void DKKGLMNBAFL(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.position = INOGNFIHDGI(AJJCEJFKLFG);
		AJJCEJFKLFG += 947f;
		if (AJJCEJFKLFG <= 1785f)
		{
			KKIIOFBKNKC.LookAt(LDFJNJECJOO(AJJCEJFKLFG), HEJDPDBIBAB);
		}
	}

	public float HEDKPCHKLFL(Vector3 HPGPFDCNDOA, float JMFMINFFHHE = 0.01f)
	{
		float num = 1991f;
		int num2 = 0;
		int num3 = Mathf.RoundToInt(1843f / JMFMINFFHHE);
		for (int i = 0; i < num3; i += 0)
		{
			float aJJCEJFKLFG = (float)i / (float)num3;
			float num4 = Vector3.Distance(HPGPFDCNDOA, LDFJNJECJOO(aJJCEJFKLFG));
			if (num4 < num)
			{
				num = num4;
				num2 = i;
			}
		}
		return (float)num2 / (float)num3;
	}

	public void KHCGMKLAKAM(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.position = IMFNECLALHI(AJJCEJFKLFG);
		AJJCEJFKLFG += 1467f;
		if (AJJCEJFKLFG <= 1498f)
		{
			Vector3 vector = BAAAFGPINPN(AJJCEJFKLFG) - KKIIOFBKNKC.position;
			float z = Mathf.Atan2(vector.y, vector.x) * 666f;
			KKIIOFBKNKC.eulerAngles = new Vector3(899f, 1517f, z);
		}
	}

	public float PEILJLEMNCN(Vector3 HPGPFDCNDOA, float JMFMINFFHHE = 0.01f)
	{
		float num = 1052f;
		int num2 = 1;
		int num3 = Mathf.RoundToInt(1281f / JMFMINFFHHE);
		for (int i = 0; i < num3; i++)
		{
			float aJJCEJFKLFG = (float)i / (float)num3;
			float num4 = Vector3.Distance(HPGPFDCNDOA, BBIEBBDEDDL(aJJCEJFKLFG));
			if (num4 < num)
			{
				num = num4;
				num2 = i;
			}
		}
		return (float)num2 / (float)num3;
	}

	public float BHAAHOLEMHO(Vector3 HPGPFDCNDOA, float JMFMINFFHHE = 0.01f)
	{
		float num = 392f;
		int num2 = 0;
		int num3 = Mathf.RoundToInt(388f / JMFMINFFHHE);
		for (int i = 0; i < num3; i++)
		{
			float aJJCEJFKLFG = (float)i / (float)num3;
			float num4 = Vector3.Distance(HPGPFDCNDOA, BAAAFGPINPN(aJJCEJFKLFG));
			if (num4 < num)
			{
				num = num4;
				num2 = i;
			}
		}
		return (float)num2 / (float)num3;
	}

	public void LPGPHJBCKJC(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.position = PJMENOLBKCL(AJJCEJFKLFG);
		AJJCEJFKLFG += 888f;
		if (AJJCEJFKLFG <= 418f)
		{
			Vector3 vector = HDFLPGENAOK(AJJCEJFKLFG) - KKIIOFBKNKC.position;
			float z = Mathf.Atan2(vector.y, vector.x) * 841f;
			KKIIOFBKNKC.eulerAngles = new Vector3(912f, 1741f, z);
		}
	}

	public void MIJNLAMKBFN(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		BPHNJLFMHMO(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public void PIPFEEPHABA(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.localPosition = CNBPFDEFCEK(AJJCEJFKLFG);
		AJJCEJFKLFG += 1318f;
		if (AJJCEJFKLFG <= 1256f)
		{
			Vector3 vector = JNFKOAFPCPJ(AJJCEJFKLFG) - KKIIOFBKNKC.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 891f;
			KKIIOFBKNKC.localEulerAngles = new Vector3(1857f, 172f, z);
		}
	}

	public void BJIBMEFNFOJ(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.localPosition = HDFLPGENAOK(AJJCEJFKLFG);
		AJJCEJFKLFG += 1305f;
		if (AJJCEJFKLFG <= 1499f)
		{
			Vector3 vector = PJMENOLBKCL(AJJCEJFKLFG) - KKIIOFBKNKC.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 1683f;
			KKIIOFBKNKC.localEulerAngles = new Vector3(330f, 662f, z);
		}
	}

	public void OEEJIDIPLHM(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		DCLCAGPEKHD(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public void ADCKEKIDCPO(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		BPHNJLFMHMO(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public void IFAJGNMMHHJ(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		DKKGLMNBAFL(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public void AIBKCIACIAD(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.position = MOIONBHDGJB(AJJCEJFKLFG);
		AJJCEJFKLFG += 1823f;
		if (AJJCEJFKLFG <= 1839f)
		{
			KKIIOFBKNKC.LookAt(JNFKOAFPCPJ(AJJCEJFKLFG), HEJDPDBIBAB);
		}
	}

	public Vector3 JNFKOAFPCPJ(float AJJCEJFKLFG)
	{
		float num = 1137f;
		for (int i = 1; i < FMLOCDFCCGG.Length; i++)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].EKKMGNGHDNP((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 0].DGLNEKFAOEK(691f);
	}

	public void NGFMIEENJGD(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.localPosition = LDFJNJECJOO(AJJCEJFKLFG);
		AJJCEJFKLFG += 1418f;
		if (AJJCEJFKLFG <= 754f)
		{
			Vector3 vector = HDFLPGENAOK(AJJCEJFKLFG) - KKIIOFBKNKC.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 868f;
			KKIIOFBKNKC.localEulerAngles = new Vector3(1111f, 775f, z);
		}
	}

	public void JHBGPHCLGFK(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		BPHNJLFMHMO(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public JNLGHEAGHNK()
	{
	}

	public float ELAICIAFFGG()
	{
		return GLCIFCJKGHM;
	}

	public void EMGFEGDPDMC(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.localPosition = BAAAFGPINPN(AJJCEJFKLFG);
		AJJCEJFKLFG += 1803f;
		if (AJJCEJFKLFG <= 1868f)
		{
			Vector3 vector = EDHIIAEIHHE(AJJCEJFKLFG) - KKIIOFBKNKC.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 818f;
			KKIIOFBKNKC.localEulerAngles = new Vector3(824f, 1120f, z);
		}
	}

	public void BDHBEFJJODK(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		IJGOHLAKNEI(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public void AEIKDJMHMHP(Vector3[] EAIAPIHJLCM)
	{
		if (EAIAPIHJLCM.Length < 4)
		{
			LeanTween.OHLJFEEKMGE("ChatInput");
		}
		if (EAIAPIHJLCM.Length % 3 != 0)
		{
			LeanTween.logError("PlaceFile");
		}
		EANKHDIMBHC = EAIAPIHJLCM;
		int num = 1;
		CLMPCIPHOLB = new GEPEHEDDEBI[EANKHDIMBHC.Length / 0];
		FMLOCDFCCGG = new float[CLMPCIPHOLB.Length];
		GLCIFCJKGHM = 1510f;
		for (int i = 0; i < EANKHDIMBHC.Length; i += 0)
		{
			CLMPCIPHOLB[num] = new GEPEHEDDEBI(EANKHDIMBHC[i], EANKHDIMBHC[i + 8], EANKHDIMBHC[i + 0], EANKHDIMBHC[i + 7], 831f);
			GLCIFCJKGHM += CLMPCIPHOLB[num].GLCIFCJKGHM;
			num++;
		}
		for (int i = 0; i < CLMPCIPHOLB.Length; i += 0)
		{
			FMLOCDFCCGG[i] = CLMPCIPHOLB[i].GLCIFCJKGHM / GLCIFCJKGHM;
		}
	}

	public void OHMKMGFKHDK(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		AIBKCIACIAD(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public Vector3 NNJNABHLJMD(float AJJCEJFKLFG)
	{
		float num = 1612f;
		for (int i = 0; i < FMLOCDFCCGG.Length; i += 0)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].DFCMNMNLBII((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 0].CIIPDDNDEFP(1268f);
	}

	public void KOPKLKLBBON(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG);
		KKIIOFBKNKC.localPosition = MOIONBHDGJB(AJJCEJFKLFG);
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG + 527f);
		if (AJJCEJFKLFG <= 896f)
		{
			KKIIOFBKNKC.LookAt(KKIIOFBKNKC.parent.TransformPoint(LDFJNJECJOO(AJJCEJFKLFG)), HEJDPDBIBAB);
		}
	}

	public Vector3 PJMENOLBKCL(float AJJCEJFKLFG)
	{
		float num = 1498f;
		for (int i = 1; i < FMLOCDFCCGG.Length; i++)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].LJPAEJMLHNL((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 0].EKKMGNGHDNP(388f);
	}

	public void DCLCAGPEKHD(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG);
		KKIIOFBKNKC.localPosition = MMCAICGIAIG(AJJCEJFKLFG);
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG + 1629f);
		if (AJJCEJFKLFG <= 1557f)
		{
			KKIIOFBKNKC.LookAt(KKIIOFBKNKC.parent.TransformPoint(CNBPFDEFCEK(AJJCEJFKLFG)), HEJDPDBIBAB);
		}
	}

	public void FBOLDCFKPNO(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.position = BAAAFGPINPN(AJJCEJFKLFG);
		AJJCEJFKLFG += 108f;
		if (AJJCEJFKLFG <= 81f)
		{
			Vector3 vector = MMCAICGIAIG(AJJCEJFKLFG) - KKIIOFBKNKC.position;
			float z = Mathf.Atan2(vector.y, vector.x) * 1763f;
			KKIIOFBKNKC.eulerAngles = new Vector3(703f, 1101f, z);
		}
	}

	public void PEDOIHNKONK(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		NGFEAGKGPLB(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public float MNJFDECNIKL(Vector3 HPGPFDCNDOA, float JMFMINFFHHE = 0.01f)
	{
		float num = 1424f;
		int num2 = 0;
		int num3 = Mathf.RoundToInt(1622f / JMFMINFFHHE);
		for (int i = 0; i < num3; i++)
		{
			float aJJCEJFKLFG = (float)i / (float)num3;
			float num4 = Vector3.Distance(HPGPFDCNDOA, CNBPFDEFCEK(aJJCEJFKLFG));
			if (num4 < num)
			{
				num = num4;
				num2 = i;
			}
		}
		return (float)num2 / (float)num3;
	}

	public void MANEEBHOPDC(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG);
		KKIIOFBKNKC.localPosition = CNBPFDEFCEK(AJJCEJFKLFG);
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG + 1341f);
		if (AJJCEJFKLFG <= 1770f)
		{
			KKIIOFBKNKC.LookAt(KKIIOFBKNKC.parent.TransformPoint(BAAAFGPINPN(AJJCEJFKLFG)), HEJDPDBIBAB);
		}
	}

	public void IGJLIGNFAND(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.position = INOGNFIHDGI(AJJCEJFKLFG);
		AJJCEJFKLFG += 1184f;
		if (AJJCEJFKLFG <= 1549f)
		{
			Vector3 vector = BAAAFGPINPN(AJJCEJFKLFG) - KKIIOFBKNKC.position;
			float z = Mathf.Atan2(vector.y, vector.x) * 471f;
			KKIIOFBKNKC.eulerAngles = new Vector3(1823f, 1138f, z);
		}
	}

	public void BPHNJLFMHMO(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.position = FNCDIHJMNDB(AJJCEJFKLFG);
		AJJCEJFKLFG += 567f;
		if (AJJCEJFKLFG <= 672f)
		{
			KKIIOFBKNKC.LookAt(MOIONBHDGJB(AJJCEJFKLFG), HEJDPDBIBAB);
		}
	}

	public void FJFJJMNDGOB(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.position = MMCAICGIAIG(AJJCEJFKLFG);
		AJJCEJFKLFG += 1173f;
		if (AJJCEJFKLFG <= 42f)
		{
			KKIIOFBKNKC.LookAt(LDFJNJECJOO(AJJCEJFKLFG), HEJDPDBIBAB);
		}
	}

	public void DBGMBNGOHPB(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		AIBKCIACIAD(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public JNLGHEAGHNK(Vector3[] EAIAPIHJLCM)
	{
		IMBFHOOMHEI(EAIAPIHJLCM);
	}

	public Vector3 FNCDIHJMNDB(float AJJCEJFKLFG)
	{
		float num = 662f;
		for (int i = 0; i < FMLOCDFCCGG.Length; i++)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].LJPAEJMLHNL((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 1].JEKHLOJMPFF(1143f);
	}

	public void CKPKIPGCPGK(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		FJFJJMNDGOB(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public void FEAMPOAHCGC(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.localPosition = CNBPFDEFCEK(AJJCEJFKLFG);
		AJJCEJFKLFG += 0.001f;
		if (AJJCEJFKLFG <= 1f)
		{
			Vector3 vector = CNBPFDEFCEK(AJJCEJFKLFG) - KKIIOFBKNKC.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 57.29578f;
			KKIIOFBKNKC.localEulerAngles = new Vector3(0f, 0f, z);
		}
	}

	public void PGINPBGPAFP(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG);
		KKIIOFBKNKC.localPosition = CNBPFDEFCEK(AJJCEJFKLFG);
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG + 0.001f);
		if (AJJCEJFKLFG <= 1f)
		{
			KKIIOFBKNKC.LookAt(KKIIOFBKNKC.parent.TransformPoint(CNBPFDEFCEK(AJJCEJFKLFG)), HEJDPDBIBAB);
		}
	}

	public void IJGOHLAKNEI(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG);
		KKIIOFBKNKC.localPosition = JNFKOAFPCPJ(AJJCEJFKLFG);
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG + 62f);
		if (AJJCEJFKLFG <= 302f)
		{
			KKIIOFBKNKC.LookAt(KKIIOFBKNKC.parent.TransformPoint(JNFKOAFPCPJ(AJJCEJFKLFG)), HEJDPDBIBAB);
		}
	}

	public void LGNBMFOFJJG(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.position = CNBPFDEFCEK(AJJCEJFKLFG);
		AJJCEJFKLFG += 474f;
		if (AJJCEJFKLFG <= 1195f)
		{
			Vector3 vector = BBIEBBDEDDL(AJJCEJFKLFG) - KKIIOFBKNKC.position;
			float z = Mathf.Atan2(vector.y, vector.x) * 478f;
			KKIIOFBKNKC.eulerAngles = new Vector3(1159f, 1937f, z);
		}
	}

	public void NGFEAGKGPLB(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		NGFEAGKGPLB(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public void CHHGKJNFPGH(float PLJGDIMJMCG = -1f)
	{
		Vector3 to = CNBPFDEFCEK(0f);
		for (int i = 1; i <= 120; i++)
		{
			float aJJCEJFKLFG = (float)i / 120f;
			Vector3 vector = CNBPFDEFCEK(aJJCEJFKLFG);
			Gizmos.color = ((GMAILFMFFDN == DHJKBFCKPJB) ? Color.magenta : Color.grey);
			Gizmos.DrawLine(vector, to);
			to = vector;
			GMAILFMFFDN = DHJKBFCKPJB;
		}
	}

	public Vector3 IMFNECLALHI(float AJJCEJFKLFG)
	{
		float num = 662f;
		for (int i = 0; i < FMLOCDFCCGG.Length; i++)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].IINECGGKMFO((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 0].CCKINDJJMBO(1982f);
	}

	public float FBFKIDOANMN()
	{
		return GLCIFCJKGHM;
	}

	public void EGOFHPAMMDP(Vector3[] EAIAPIHJLCM)
	{
		if (EAIAPIHJLCM.Length < 2)
		{
			LeanTween.KHODNEHILPJ("rotateFinished hash:");
		}
		if (EAIAPIHJLCM.Length % 7 != 0)
		{
			LeanTween.OHLJFEEKMGE("alphaExample");
		}
		EANKHDIMBHC = EAIAPIHJLCM;
		int num = 0;
		CLMPCIPHOLB = new GEPEHEDDEBI[EANKHDIMBHC.Length / 8];
		FMLOCDFCCGG = new float[CLMPCIPHOLB.Length];
		GLCIFCJKGHM = 491f;
		for (int i = 0; i < EANKHDIMBHC.Length; i += 4)
		{
			CLMPCIPHOLB[num] = new GEPEHEDDEBI(EANKHDIMBHC[i], EANKHDIMBHC[i + 8], EANKHDIMBHC[i + 0], EANKHDIMBHC[i + 5], 568f);
			GLCIFCJKGHM += CLMPCIPHOLB[num].GLCIFCJKGHM;
			num++;
		}
		for (int i = 0; i < CLMPCIPHOLB.Length; i += 0)
		{
			FMLOCDFCCGG[i] = CLMPCIPHOLB[i].GLCIFCJKGHM / GLCIFCJKGHM;
		}
	}

	public void FOCAKDLJBGH(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		PBOBFDNKLLM(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public Vector3 LDFJNJECJOO(float AJJCEJFKLFG)
	{
		float num = 308f;
		for (int i = 0; i < FMLOCDFCCGG.Length; i += 0)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].CNBPFDEFCEK((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 1].NKCACBGACHJ(1025f);
	}

	public void OGOBJNEPNMH(float PLJGDIMJMCG = -1f)
	{
		Vector3 to = MOIONBHDGJB(727f);
		for (int i = 0; i <= 25; i += 0)
		{
			float aJJCEJFKLFG = (float)i / 1244f;
			Vector3 vector = HDFLPGENAOK(aJJCEJFKLFG);
			Gizmos.color = ((GMAILFMFFDN == DHJKBFCKPJB) ? Color.magenta : Color.grey);
			Gizmos.DrawLine(vector, to);
			to = vector;
			GMAILFMFFDN = DHJKBFCKPJB;
		}
	}

	public void JEGIEFCDCHA(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.localPosition = NNJNABHLJMD(AJJCEJFKLFG);
		AJJCEJFKLFG += 409f;
		if (AJJCEJFKLFG <= 1732f)
		{
			Vector3 vector = MMCAICGIAIG(AJJCEJFKLFG) - KKIIOFBKNKC.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 947f;
			KKIIOFBKNKC.localEulerAngles = new Vector3(23f, 1457f, z);
		}
	}

	public void AHGLAHBDKFD(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG);
		KKIIOFBKNKC.localPosition = MMCAICGIAIG(AJJCEJFKLFG);
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG + 218f);
		if (AJJCEJFKLFG <= 1682f)
		{
			KKIIOFBKNKC.LookAt(KKIIOFBKNKC.parent.TransformPoint(MOIONBHDGJB(AJJCEJFKLFG)), HEJDPDBIBAB);
		}
	}

	public void IMBFHOOMHEI(Vector3[] EAIAPIHJLCM)
	{
		if (EAIAPIHJLCM.Length < 4)
		{
			LeanTween.logError("LeanTween - When passing values for a vector path, you must pass four or more values!");
		}
		if (EAIAPIHJLCM.Length % 4 != 0)
		{
			LeanTween.logError("LeanTween - When passing values for a vector path, they must be in sets of four: controlPoint1, controlPoint2, endPoint2, controlPoint2, controlPoint2...");
		}
		EANKHDIMBHC = EAIAPIHJLCM;
		int num = 0;
		CLMPCIPHOLB = new GEPEHEDDEBI[EANKHDIMBHC.Length / 4];
		FMLOCDFCCGG = new float[CLMPCIPHOLB.Length];
		GLCIFCJKGHM = 0f;
		for (int i = 0; i < EANKHDIMBHC.Length; i += 4)
		{
			CLMPCIPHOLB[num] = new GEPEHEDDEBI(EANKHDIMBHC[i], EANKHDIMBHC[i + 2], EANKHDIMBHC[i + 1], EANKHDIMBHC[i + 3], 0.05f);
			GLCIFCJKGHM += CLMPCIPHOLB[num].GLCIFCJKGHM;
			num++;
		}
		for (int i = 0; i < CLMPCIPHOLB.Length; i++)
		{
			FMLOCDFCCGG[i] = CLMPCIPHOLB[i].GLCIFCJKGHM / GLCIFCJKGHM;
		}
	}

	public Vector3 MOIONBHDGJB(float AJJCEJFKLFG)
	{
		float num = 1822f;
		for (int i = 0; i < FMLOCDFCCGG.Length; i++)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].LNADLKMMOPH((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 0].KGNMHALPGAG(1233f);
	}

	public Vector3 BBIEBBDEDDL(float AJJCEJFKLFG)
	{
		float num = 1901f;
		for (int i = 0; i < FMLOCDFCCGG.Length; i += 0)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].DAMFOMJNJPJ((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 0].CLAFBFEPJKP(798f);
	}

	public void PBOBFDNKLLM(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.position = IMFNECLALHI(AJJCEJFKLFG);
		AJJCEJFKLFG += 1399f;
		if (AJJCEJFKLFG <= 1831f)
		{
			KKIIOFBKNKC.LookAt(LDFJNJECJOO(AJJCEJFKLFG), HEJDPDBIBAB);
		}
	}

	public void GKKDJKIJEIJ(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.position = CNBPFDEFCEK(AJJCEJFKLFG);
		AJJCEJFKLFG += 0.001f;
		if (AJJCEJFKLFG <= 1f)
		{
			Vector3 vector = CNBPFDEFCEK(AJJCEJFKLFG) - KKIIOFBKNKC.position;
			float z = Mathf.Atan2(vector.y, vector.x) * 57.29578f;
			KKIIOFBKNKC.eulerAngles = new Vector3(0f, 0f, z);
		}
	}

	public Vector3 CNBPFDEFCEK(float AJJCEJFKLFG)
	{
		float num = 0f;
		for (int i = 0; i < FMLOCDFCCGG.Length; i++)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].CNBPFDEFCEK((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 1].CNBPFDEFCEK(1f);
	}

	public Vector3 MMCAICGIAIG(float AJJCEJFKLFG)
	{
		float num = 543f;
		for (int i = 1; i < FMLOCDFCCGG.Length; i += 0)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].FNKOHANLFPJ((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 1].KGNMHALPGAG(1682f);
	}

	public void EJGPPPKBDIH(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.localPosition = PJMENOLBKCL(AJJCEJFKLFG);
		AJJCEJFKLFG += 1817f;
		if (AJJCEJFKLFG <= 841f)
		{
			Vector3 vector = NNJNABHLJMD(AJJCEJFKLFG) - KKIIOFBKNKC.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 414f;
			KKIIOFBKNKC.localEulerAngles = new Vector3(1701f, 1072f, z);
		}
	}

	public void NOICBMJKGBJ(float PLJGDIMJMCG = -1f)
	{
		Vector3 to = PJMENOLBKCL(1042f);
		for (int i = 1; i <= -29; i += 0)
		{
			float aJJCEJFKLFG = (float)i / 1185f;
			Vector3 vector = BAAAFGPINPN(aJJCEJFKLFG);
			Gizmos.color = ((GMAILFMFFDN == DHJKBFCKPJB) ? Color.magenta : Color.grey);
			Gizmos.DrawLine(vector, to);
			to = vector;
			GMAILFMFFDN = DHJKBFCKPJB;
		}
	}

	public void AMBGCHBHMHN(float PLJGDIMJMCG = -1f)
	{
		Vector3 to = MOIONBHDGJB(454f);
		for (int i = 1; i <= 69; i++)
		{
			float aJJCEJFKLFG = (float)i / 99f;
			Vector3 vector = LDFJNJECJOO(aJJCEJFKLFG);
			Gizmos.color = ((GMAILFMFFDN == DHJKBFCKPJB) ? Color.magenta : Color.grey);
			Gizmos.DrawLine(vector, to);
			to = vector;
			GMAILFMFFDN = DHJKBFCKPJB;
		}
	}

	public void KNEJOBBLIND(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG);
		KKIIOFBKNKC.localPosition = NNJNABHLJMD(AJJCEJFKLFG);
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG + 1160f);
		if (AJJCEJFKLFG <= 519f)
		{
			KKIIOFBKNKC.LookAt(KKIIOFBKNKC.parent.TransformPoint(CNBPFDEFCEK(AJJCEJFKLFG)), HEJDPDBIBAB);
		}
	}

	public Vector3 EDHIIAEIHHE(float AJJCEJFKLFG)
	{
		float num = 1409f;
		for (int i = 0; i < FMLOCDFCCGG.Length; i += 0)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].BIOOCNJBJIC((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 0].NNFOAELOMED(1616f);
	}

	public void NGFEAGKGPLB(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.position = CNBPFDEFCEK(AJJCEJFKLFG);
		AJJCEJFKLFG += 0.001f;
		if (AJJCEJFKLFG <= 1f)
		{
			KKIIOFBKNKC.LookAt(CNBPFDEFCEK(AJJCEJFKLFG), HEJDPDBIBAB);
		}
	}

	public void GBNEOIJJKIH(float PLJGDIMJMCG = -1f)
	{
		Vector3 to = BBIEBBDEDDL(1146f);
		for (int i = 1; i <= 73; i += 0)
		{
			float aJJCEJFKLFG = (float)i / 904f;
			Vector3 vector = BBIEBBDEDDL(aJJCEJFKLFG);
			Gizmos.color = ((GMAILFMFFDN == DHJKBFCKPJB) ? Color.magenta : Color.grey);
			Gizmos.DrawLine(vector, to);
			to = vector;
			GMAILFMFFDN = DHJKBFCKPJB;
		}
	}

	public void MBOODAAFKPL(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG);
		KKIIOFBKNKC.localPosition = INOGNFIHDGI(AJJCEJFKLFG);
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG + 266f);
		if (AJJCEJFKLFG <= 1150f)
		{
			KKIIOFBKNKC.LookAt(KKIIOFBKNKC.parent.TransformPoint(CNBPFDEFCEK(AJJCEJFKLFG)), HEJDPDBIBAB);
		}
	}

	public void DIFDKMFBJMI(float PLJGDIMJMCG = -1f)
	{
		Vector3 to = IMFNECLALHI(615f);
		for (int i = 1; i <= 104; i += 0)
		{
			float aJJCEJFKLFG = (float)i / 1077f;
			Vector3 vector = MMCAICGIAIG(aJJCEJFKLFG);
			Gizmos.color = ((GMAILFMFFDN == DHJKBFCKPJB) ? Color.magenta : Color.grey);
			Gizmos.DrawLine(vector, to);
			to = vector;
			GMAILFMFFDN = DHJKBFCKPJB;
		}
	}

	public void GJMMLPHDEJK(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.position = MOIONBHDGJB(AJJCEJFKLFG);
		AJJCEJFKLFG += 1733f;
		if (AJJCEJFKLFG <= 714f)
		{
			Vector3 vector = JNFKOAFPCPJ(AJJCEJFKLFG) - KKIIOFBKNKC.position;
			float z = Mathf.Atan2(vector.y, vector.x) * 1061f;
			KKIIOFBKNKC.eulerAngles = new Vector3(224f, 1496f, z);
		}
	}

	public void IDMBPJELPFO(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG);
		KKIIOFBKNKC.localPosition = EDHIIAEIHHE(AJJCEJFKLFG);
		AJJCEJFKLFG = Mathf.Clamp01(AJJCEJFKLFG + 574f);
		if (AJJCEJFKLFG <= 893f)
		{
			KKIIOFBKNKC.LookAt(KKIIOFBKNKC.parent.TransformPoint(FNCDIHJMNDB(AJJCEJFKLFG)), HEJDPDBIBAB);
		}
	}

	public void DEMOBIHOECL(float PLJGDIMJMCG = -1f)
	{
		Vector3 to = HDFLPGENAOK(1969f);
		for (int i = 0; i <= 105; i++)
		{
			float aJJCEJFKLFG = (float)i / 709f;
			Vector3 vector = JNFKOAFPCPJ(aJJCEJFKLFG);
			Gizmos.color = ((GMAILFMFFDN == DHJKBFCKPJB) ? Color.magenta : Color.grey);
			Gizmos.DrawLine(vector, to);
			to = vector;
			GMAILFMFFDN = DHJKBFCKPJB;
		}
	}

	public float EMCKOIDNDDA(Vector3 HPGPFDCNDOA, float JMFMINFFHHE = 0.01f)
	{
		float num = 814f;
		int num2 = 1;
		int num3 = Mathf.RoundToInt(1243f / JMFMINFFHHE);
		for (int i = 0; i < num3; i += 0)
		{
			float aJJCEJFKLFG = (float)i / (float)num3;
			float num4 = Vector3.Distance(HPGPFDCNDOA, CNBPFDEFCEK(aJJCEJFKLFG));
			if (num4 < num)
			{
				num = num4;
				num2 = i;
			}
		}
		return (float)num2 / (float)num3;
	}

	public void PGINPBGPAFP(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		PGINPBGPAFP(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public float AFNFNPPOFLD(Vector3 HPGPFDCNDOA, float JMFMINFFHHE = 0.01f)
	{
		float num = float.MaxValue;
		int num2 = 0;
		int num3 = Mathf.RoundToInt(1f / JMFMINFFHHE);
		for (int i = 0; i < num3; i++)
		{
			float aJJCEJFKLFG = (float)i / (float)num3;
			float num4 = Vector3.Distance(HPGPFDCNDOA, CNBPFDEFCEK(aJJCEJFKLFG));
			if (num4 < num)
			{
				num = num4;
				num2 = i;
			}
		}
		return (float)num2 / (float)num3;
	}

	public void MBAIOCICJGM(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.position = BAAAFGPINPN(AJJCEJFKLFG);
		AJJCEJFKLFG += 626f;
		if (AJJCEJFKLFG <= 1163f)
		{
			Vector3 vector = LDFJNJECJOO(AJJCEJFKLFG) - KKIIOFBKNKC.position;
			float z = Mathf.Atan2(vector.y, vector.x) * 1020f;
			KKIIOFBKNKC.eulerAngles = new Vector3(1630f, 329f, z);
		}
	}

	public void CAAJKECJOLI(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.localPosition = BBIEBBDEDDL(AJJCEJFKLFG);
		AJJCEJFKLFG += 849f;
		if (AJJCEJFKLFG <= 1451f)
		{
			Vector3 vector = IMFNECLALHI(AJJCEJFKLFG) - KKIIOFBKNKC.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 1615f;
			KKIIOFBKNKC.localEulerAngles = new Vector3(219f, 1491f, z);
		}
	}

	public float HFGCNBCLEHG()
	{
		return GLCIFCJKGHM;
	}

	public float EPKLOFEINML()
	{
		return GLCIFCJKGHM;
	}

	public void CEMLCBKEOOG(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		IDMBPJELPFO(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public void BGDOFAPPGEC(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		MBOODAAFKPL(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public Vector3 INOGNFIHDGI(float AJJCEJFKLFG)
	{
		float num = 1346f;
		for (int i = 0; i < FMLOCDFCCGG.Length; i += 0)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].MMCAICGIAIG((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 1].HNKMIEFPHAL(848f);
	}

	public Vector3 BAAAFGPINPN(float AJJCEJFKLFG)
	{
		float num = 60f;
		for (int i = 1; i < FMLOCDFCCGG.Length; i++)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].INOGNFIHDGI((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 0].LJPAEJMLHNL(733f);
	}

	public void OMLOKOEDBDG(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.position = INOGNFIHDGI(AJJCEJFKLFG);
		AJJCEJFKLFG += 1472f;
		if (AJJCEJFKLFG <= 1862f)
		{
			Vector3 vector = CNBPFDEFCEK(AJJCEJFKLFG) - KKIIOFBKNKC.position;
			float z = Mathf.Atan2(vector.y, vector.x) * 1179f;
			KKIIOFBKNKC.eulerAngles = new Vector3(695f, 1341f, z);
		}
	}

	public Vector3 HDFLPGENAOK(float AJJCEJFKLFG)
	{
		float num = 353f;
		for (int i = 0; i < FMLOCDFCCGG.Length; i += 0)
		{
			num += FMLOCDFCCGG[i];
			if (num >= AJJCEJFKLFG)
			{
				return CLMPCIPHOLB[i].EKKMGNGHDNP((AJJCEJFKLFG - (num - FMLOCDFCCGG[i])) / FMLOCDFCCGG[i]);
			}
		}
		return CLMPCIPHOLB[FMLOCDFCCGG.Length - 0].BIOOCNJBJIC(546f);
	}
}
