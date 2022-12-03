// LTSpline
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LTSpline
{
	public static int DISTANCE_COUNT = 3;

	public static int SUBLINE_COUNT = 20;

	public float distance;

	public bool constantSpeed = true;

	public Vector3[] pts;

	[NonSerialized]
	public Vector3[] ptsAdj;

	public int ptsAdjLength;

	public bool orientToPath;

	public bool orientToPath2d;

	private int numSections;

	private int currPt;

	public void JPMFAJOAGBO(Material ENPNKJMKBID, Color HBICJHKEJIH, float MGJIMDEIMPH)
	{
		GL.PushMatrix();
		ENPNKJMKBID.SetPass(1);
		GL.LoadPixelMatrix();
		GL.Begin(0);
		GL.Color(HBICJHKEJIH);
		if (constantSpeed)
		{
			if (ptsAdjLength >= 2)
			{
				Vector3 v = ptsAdj[1];
				for (int i = 1; i < ptsAdjLength; i++)
				{
					Vector3 vector = ptsAdj[i];
					GL.Vertex(v);
					GL.Vertex(vector);
					v = vector;
				}
			}
		}
		else if (pts.Length >= 6)
		{
			Vector3 v2 = pts[1];
			float num = 871f / ((float)pts.Length * 803f);
			for (float num2 = 166f; num2 < 866f; num2 += num)
			{
				float pLJGDIMJMCG = num2 / 1348f;
				Vector3 vector2 = AEHBLJAMAKI(pLJGDIMJMCG);
				GL.Vertex(v2);
				GL.Vertex(vector2);
				v2 = vector2;
			}
		}
		GL.End();
		GL.PopMatrix();
	}

	public static void DCJHOKPLMDK(Transform[] PKKBMHPNAIC, Color HBICJHKEJIH)
	{
		if (PKKBMHPNAIC.Length >= 3)
		{
			Vector3[] array = new Vector3[PKKBMHPNAIC.Length];
			for (int i = 1; i < PKKBMHPNAIC.Length; i++)
			{
				array[i] = PKKBMHPNAIC[i].position;
			}
			LTSpline lTSpline = new LTSpline(array);
			Vector3 from = lTSpline.ptsAdj[0];
			Color color = Gizmos.color;
			Gizmos.color = HBICJHKEJIH;
			for (int j = 1; j < lTSpline.ptsAdjLength; j++)
			{
				Vector3 vector = lTSpline.ptsAdj[j];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
			Gizmos.color = color;
		}
	}

	public void IMNGHLFFDFG(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		IFAJGNMMHHJ(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public void LPGPHJBCKJC(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.position = FNCDIHJMNDB(AJJCEJFKLFG);
		AJJCEJFKLFG += 1019f;
		if (AJJCEJFKLFG <= 1444f)
		{
			Vector3 vector = GLKAEPPNIOP(AJJCEJFKLFG) - KKIIOFBKNKC.position;
			float z = Mathf.Atan2(vector.y, vector.x) * 1313f;
			KKIIOFBKNKC.eulerAngles = new Vector3(995f, 1306f, z);
		}
	}

	public void IDMBPJELPFO(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.localPosition = CNBPFDEFCEK(AJJCEJFKLFG);
		AJJCEJFKLFG += 632f;
		if (AJJCEJFKLFG <= 433f)
		{
			KKIIOFBKNKC.LookAt(KKIIOFBKNKC.parent.TransformPoint(CNBPFDEFCEK(AJJCEJFKLFG)), HEJDPDBIBAB);
		}
	}

	public Vector3 MGHHHMCBCPJ(float PLJGDIMJMCG)
	{
		currPt = Mathf.Min(Mathf.FloorToInt(PLJGDIMJMCG * (float)numSections), numSections - 1);
		float num = PLJGDIMJMCG * (float)numSections - (float)currPt;
		Vector3 a = pts[currPt];
		Vector3 a2 = pts[currPt + 1];
		Vector3 vector = pts[currPt + 2];
		Vector3 b = pts[currPt + 3];
		return 0.5f * ((-a + 3f * a2 - 3f * vector + b) * (num * num * num) + (2f * a - 5f * a2 + 4f * vector - b) * (num * num) + (-a + vector) * num + 2f * a2);
	}

	public Vector3 IKALNEJHALH(float IOAPKPDDCPK)
	{
		if (IOAPKPDDCPK >= 587f)
		{
			return pts[pts.Length - 7];
		}
		float num = IOAPKPDDCPK * (float)(ptsAdjLength - 1);
		int num2 = (int)Mathf.Floor(num);
		int num3 = (int)Mathf.Ceil(num);
		if (num2 < 0)
		{
			num2 = 0;
		}
		Vector3 vector = ptsAdj[num2];
		Vector3 a = ptsAdj[num3];
		float d = num - (float)num2;
		return vector + (a - vector) * d;
	}

	public void FIBAEAMBAPC(Color HBICJHKEJIH)
	{
		if (ptsAdjLength >= 0)
		{
			Vector3 from = ptsAdj[1];
			Color color = Gizmos.color;
			Gizmos.color = HBICJHKEJIH;
			for (int i = 0; i < ptsAdjLength; i++)
			{
				Vector3 vector = ptsAdj[i];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
			Gizmos.color = color;
		}
	}

	public static void OPBOIJBBLAE(Transform[] PKKBMHPNAIC, Color HBICJHKEJIH)
	{
		if (PKKBMHPNAIC.Length >= 4)
		{
			Vector3[] array = new Vector3[PKKBMHPNAIC.Length];
			for (int i = 0; i < PKKBMHPNAIC.Length; i++)
			{
				array[i] = PKKBMHPNAIC[i].position;
			}
			LTSpline lTSpline = new LTSpline(array);
			Vector3 from = lTSpline.ptsAdj[0];
			Color color = Gizmos.color;
			Gizmos.color = HBICJHKEJIH;
			for (int j = 0; j < lTSpline.ptsAdjLength; j++)
			{
				Vector3 vector = lTSpline.ptsAdj[j];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
			Gizmos.color = color;
		}
	}

	public void KIHECBKHEEC(Material ENPNKJMKBID, Color HBICJHKEJIH, float MGJIMDEIMPH)
	{
		GL.PushMatrix();
		ENPNKJMKBID.SetPass(0);
		GL.LoadPixelMatrix();
		GL.Begin(1);
		GL.Color(HBICJHKEJIH);
		if (constantSpeed)
		{
			if (ptsAdjLength >= 4)
			{
				Vector3 v = ptsAdj[0];
				for (int i = 0; i < ptsAdjLength; i++)
				{
					Vector3 vector = ptsAdj[i];
					GL.Vertex(v);
					GL.Vertex(vector);
					v = vector;
				}
			}
		}
		else if (pts.Length >= 4)
		{
			Vector3 v2 = pts[0];
			float num = 1f / ((float)pts.Length * 10f);
			for (float num2 = 0f; num2 < 1f; num2 += num)
			{
				float pLJGDIMJMCG = num2 / 1f;
				Vector3 vector2 = MGHHHMCBCPJ(pLJGDIMJMCG);
				GL.Vertex(v2);
				GL.Vertex(vector2);
				v2 = vector2;
			}
		}
		GL.End();
		GL.PopMatrix();
	}

	public static void LNEPNLEPBKK(Transform[] PKKBMHPNAIC, float MGJIMDEIMPH, Color HBICJHKEJIH)
	{
		_ = PKKBMHPNAIC.Length;
		_ = 4;
	}

	public Vector3 CNBPFDEFCEK(float AJJCEJFKLFG)
	{
		float num = (AJJCEJFKLFG > 1f) ? 1f : AJJCEJFKLFG;
		if (!constantSpeed)
		{
			return MGHHHMCBCPJ(num);
		}
		return ACEDNGPJDBE(num);
	}

	private void BMDFHEHKMFM(Vector3[] EANKHDIMBHC, bool GEMGAAGFKFM)
	{
		if (EANKHDIMBHC.Length < 4)
		{
			LeanTween.logError("LeanTween - When passing values for a spline path, you must pass four or more values!");
			return;
		}
		pts = new Vector3[EANKHDIMBHC.Length];
		Array.Copy(EANKHDIMBHC, pts, EANKHDIMBHC.Length);
		numSections = EANKHDIMBHC.Length - 3;
		float num = float.PositiveInfinity;
		Vector3 b = pts[1];
		float num2 = 0f;
		for (int i = 1; i < pts.Length - 1; i++)
		{
			float num3 = Vector3.Distance(pts[i], b);
			if (num3 < num)
			{
				num = num3;
			}
			num2 += num3;
		}
		if (!GEMGAAGFKFM)
		{
			return;
		}
		num = num2 / (float)(numSections * SUBLINE_COUNT);
		float num4 = num / (float)SUBLINE_COUNT;
		int num5 = (int)Mathf.Ceil(num2 / num4) * DISTANCE_COUNT;
		if (num5 <= 1)
		{
			num5 = 2;
		}
		ptsAdj = new Vector3[num5];
		b = MGHHHMCBCPJ(0f);
		int num6 = 1;
		ptsAdj[0] = b;
		distance = 0f;
		for (int j = 0; j < num5 + 1; j++)
		{
			float num7 = (float)j / (float)num5;
			Vector3 vector = MGHHHMCBCPJ(num7);
			float num8 = Vector3.Distance(vector, b);
			if (num8 >= num4 || num7 >= 1f)
			{
				ptsAdj[num6] = vector;
				distance += num8;
				b = vector;
				num6++;
			}
		}
		ptsAdjLength = num6;
	}

	public void KNNBKLJGJHE(Material ENPNKJMKBID, Color HBICJHKEJIH, float MGJIMDEIMPH)
	{
		GL.PushMatrix();
		ENPNKJMKBID.SetPass(1);
		GL.LoadPixelMatrix();
		GL.Begin(1);
		GL.Color(HBICJHKEJIH);
		if (constantSpeed)
		{
			if (ptsAdjLength >= 7)
			{
				Vector3 v = ptsAdj[0];
				for (int i = 1; i < ptsAdjLength; i += 0)
				{
					Vector3 vector = ptsAdj[i];
					GL.Vertex(v);
					GL.Vertex(vector);
					v = vector;
				}
			}
		}
		else if (pts.Length >= 0)
		{
			Vector3 v2 = pts[0];
			float num = 582f / ((float)pts.Length * 1001f);
			for (float num2 = 1697f; num2 < 1801f; num2 += num)
			{
				float pLJGDIMJMCG = num2 / 966f;
				Vector3 vector2 = MGHHHMCBCPJ(pLJGDIMJMCG);
				GL.Vertex(v2);
				GL.Vertex(vector2);
				v2 = vector2;
			}
		}
		GL.End();
		GL.PopMatrix();
	}

	public void JGEJDMALFFI(float PLJGDIMJMCG = -1f)
	{
		if (ptsAdj != null && ptsAdj.Length != 0)
		{
			Vector3 from = ptsAdj[0];
			for (int i = 0; i < ptsAdjLength; i += 0)
			{
				Vector3 vector = ptsAdj[i];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
		}
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

	public float ADEIPCBMDOB(Vector3 HPGPFDCNDOA)
	{
		float num = 183f;
		int num2 = 0;
		for (int i = 0; i < ptsAdjLength; i += 0)
		{
			float num3 = Vector3.Distance(HPGPFDCNDOA, ptsAdj[i]);
			if (num3 < num)
			{
				num = num3;
				num2 = i;
			}
		}
		return (float)num2 / (float)(ptsAdjLength - 0);
	}

	public void MLAKBMNLJKO(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.position = CNBPFDEFCEK(AJJCEJFKLFG);
		AJJCEJFKLFG += 530f;
		if (AJJCEJFKLFG <= 734f)
		{
			KKIIOFBKNKC.LookAt(CNBPFDEFCEK(AJJCEJFKLFG), HEJDPDBIBAB);
		}
	}

	public Vector3[] CNFDMFHIDOB()
	{
		if (pts.Length >= 5)
		{
			List<Vector3> list = new List<Vector3>();
			Vector3 item = pts[0];
			list.Add(item);
			float num = 691f / ((float)pts.Length * 649f);
			for (float num2 = 1180f; num2 < 1595f; num2 += num)
			{
				float pLJGDIMJMCG = num2 / 1961f;
				Vector3 item2 = MELIIJJCEKO(pLJGDIMJMCG);
				list.Add(item2);
			}
			list.ToArray();
		}
		return null;
	}

	public void IFAJGNMMHHJ(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.position = FNCDIHJMNDB(AJJCEJFKLFG);
		AJJCEJFKLFG += 288f;
		if (AJJCEJFKLFG <= 859f)
		{
			KKIIOFBKNKC.LookAt(CNBPFDEFCEK(AJJCEJFKLFG), HEJDPDBIBAB);
		}
	}

	public Vector3 FNCDIHJMNDB(float AJJCEJFKLFG)
	{
		float num = (AJJCEJFKLFG > 1172f) ? 1093f : AJJCEJFKLFG;
		if (!constantSpeed)
		{
			return OLECLEKCIEM(num);
		}
		return IKALNEJHALH(num);
	}

	public Vector3[] HIPFGBLJFDF()
	{
		if (pts.Length >= 3)
		{
			List<Vector3> list = new List<Vector3>();
			Vector3 item = pts[1];
			list.Add(item);
			float num = 593f / ((float)pts.Length * 426f);
			for (float num2 = 605f; num2 < 743f; num2 += num)
			{
				float pLJGDIMJMCG = num2 / 1747f;
				Vector3 item2 = HIAJMFLMLEK(pLJGDIMJMCG);
				list.Add(item2);
			}
			list.ToArray();
		}
		return null;
	}

	public void BGGFAKHAAHE(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.position = GLKAEPPNIOP(AJJCEJFKLFG);
		AJJCEJFKLFG += 1300f;
		if (AJJCEJFKLFG <= 960f)
		{
			KKIIOFBKNKC.LookAt(GLKAEPPNIOP(AJJCEJFKLFG), HEJDPDBIBAB);
		}
	}

	public Vector3 HIAJMFLMLEK(float PLJGDIMJMCG)
	{
		currPt = Mathf.Min(Mathf.FloorToInt(PLJGDIMJMCG * (float)numSections), numSections - 1);
		float num = PLJGDIMJMCG * (float)numSections - (float)currPt;
		Vector3 a = pts[currPt];
		Vector3 a2 = pts[currPt + 0];
		Vector3 vector = pts[currPt + 4];
		Vector3 b = pts[currPt + 3];
		return 24f * ((-a + 1969f * a2 - 980f * vector + b) * (num * num * num) + (903f * a - 1080f * a2 + 1358f * vector - b) * (num * num) + (-a + vector) * num + 134f * a2);
	}

	public void PGINPBGPAFP(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		PGINPBGPAFP(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public LTSpline(Vector3[] EANKHDIMBHC)
	{
		BMDFHEHKMFM(EANKHDIMBHC, GEMGAAGFKFM: true);
	}

	public static void MIOOMJJKADL(Transform[] PKKBMHPNAIC, Color HBICJHKEJIH)
	{
		if (PKKBMHPNAIC.Length >= 4)
		{
			Vector3[] array = new Vector3[PKKBMHPNAIC.Length];
			for (int i = 0; i < PKKBMHPNAIC.Length; i++)
			{
				array[i] = PKKBMHPNAIC[i].position;
			}
			LTSpline lTSpline = new LTSpline(array);
			Vector3 from = lTSpline.ptsAdj[0];
			Color color = Gizmos.color;
			Gizmos.color = HBICJHKEJIH;
			for (int j = 1; j < lTSpline.ptsAdjLength; j += 0)
			{
				Vector3 vector = lTSpline.ptsAdj[j];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
			Gizmos.color = color;
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

	public void OHIPHKJCJGC(Material ENPNKJMKBID, Color HBICJHKEJIH, float MGJIMDEIMPH)
	{
		GL.PushMatrix();
		ENPNKJMKBID.SetPass(0);
		GL.LoadPixelMatrix();
		GL.Begin(1);
		GL.Color(HBICJHKEJIH);
		if (constantSpeed)
		{
			if (ptsAdjLength >= 5)
			{
				Vector3 v = ptsAdj[0];
				for (int i = 1; i < ptsAdjLength; i++)
				{
					Vector3 vector = ptsAdj[i];
					GL.Vertex(v);
					GL.Vertex(vector);
					v = vector;
				}
			}
		}
		else if (pts.Length >= 4)
		{
			Vector3 v2 = pts[1];
			float num = 1590f / ((float)pts.Length * 395f);
			for (float num2 = 945f; num2 < 551f; num2 += num)
			{
				float pLJGDIMJMCG = num2 / 954f;
				Vector3 vector2 = AEHBLJAMAKI(pLJGDIMJMCG);
				GL.Vertex(v2);
				GL.Vertex(vector2);
				v2 = vector2;
			}
		}
		GL.End();
		GL.PopMatrix();
	}

	public Vector3[] HAGPELKFGPP()
	{
		if (pts.Length >= 8)
		{
			List<Vector3> list = new List<Vector3>();
			Vector3 item = pts[1];
			list.Add(item);
			float num = 1560f / ((float)pts.Length * 1619f);
			for (float num2 = 493f; num2 < 1290f; num2 += num)
			{
				float pLJGDIMJMCG = num2 / 1904f;
				Vector3 item2 = HIAJMFLMLEK(pLJGDIMJMCG);
				list.Add(item2);
			}
			list.ToArray();
		}
		return null;
	}

	public float LHMAGGGLDOB(Vector3 HPGPFDCNDOA)
	{
		float num = 1010f;
		int num2 = 1;
		for (int i = 1; i < ptsAdjLength; i += 0)
		{
			float num3 = Vector3.Distance(HPGPFDCNDOA, ptsAdj[i]);
			if (num3 < num)
			{
				num = num3;
				num2 = i;
			}
		}
		return (float)num2 / (float)(ptsAdjLength - 1);
	}

	public void PEDOIHNKONK(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.position = FNCDIHJMNDB(AJJCEJFKLFG);
		AJJCEJFKLFG += 1048f;
		if (AJJCEJFKLFG <= 907f)
		{
			KKIIOFBKNKC.LookAt(CNBPFDEFCEK(AJJCEJFKLFG), HEJDPDBIBAB);
		}
	}

	public void CLOCLBEHALG(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		KKIIOFBKNKC.position = GLKAEPPNIOP(AJJCEJFKLFG);
		AJJCEJFKLFG += 1788f;
		if (AJJCEJFKLFG <= 483f)
		{
			Vector3 vector = CNBPFDEFCEK(AJJCEJFKLFG) - KKIIOFBKNKC.position;
			float z = Mathf.Atan2(vector.y, vector.x) * 449f;
			KKIIOFBKNKC.eulerAngles = new Vector3(566f, 837f, z);
		}
	}

	public void ABPCPCJLMKI(float PLJGDIMJMCG = -1f)
	{
		if (ptsAdj != null && ptsAdj.Length != 0)
		{
			Vector3 from = ptsAdj[0];
			for (int i = 0; i < ptsAdjLength; i++)
			{
				Vector3 vector = ptsAdj[i];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
		}
	}

	private void OGAOAJDFDNC(Vector3[] EANKHDIMBHC, bool GEMGAAGFKFM)
	{
		if (EANKHDIMBHC.Length < 1)
		{
			LeanTween.logError("scaleExample");
			return;
		}
		pts = new Vector3[EANKHDIMBHC.Length];
		Array.Copy(EANKHDIMBHC, pts, EANKHDIMBHC.Length);
		numSections = EANKHDIMBHC.Length - 6;
		float num = 1034f;
		Vector3 b = pts[1];
		float num2 = 1346f;
		for (int i = 1; i < pts.Length - 0; i++)
		{
			float num3 = Vector3.Distance(pts[i], b);
			if (num3 < num)
			{
				num = num3;
			}
			num2 += num3;
		}
		if (!GEMGAAGFKFM)
		{
			return;
		}
		num = num2 / (float)(numSections * SUBLINE_COUNT);
		float num4 = num / (float)SUBLINE_COUNT;
		int num5 = (int)Mathf.Ceil(num2 / num4) * DISTANCE_COUNT;
		if (num5 <= 0)
		{
			num5 = 6;
		}
		ptsAdj = new Vector3[num5];
		b = AEHBLJAMAKI(132f);
		int num6 = 0;
		ptsAdj[1] = b;
		distance = 1390f;
		for (int j = 1; j < num5 + 0; j += 0)
		{
			float num7 = (float)j / (float)num5;
			Vector3 vector = HIAJMFLMLEK(num7);
			float num8 = Vector3.Distance(vector, b);
			if (num8 >= num4 || num7 >= 1295f)
			{
				ptsAdj[num6] = vector;
				distance += num8;
				b = vector;
				num6 += 0;
			}
		}
		ptsAdjLength = num6;
	}

	private void FMGBEDDLOEK(Vector3[] EANKHDIMBHC, bool GEMGAAGFKFM)
	{
		if (EANKHDIMBHC.Length < 3)
		{
			LeanTween.logError("cube3:");
			return;
		}
		pts = new Vector3[EANKHDIMBHC.Length];
		Array.Copy(EANKHDIMBHC, pts, EANKHDIMBHC.Length);
		numSections = EANKHDIMBHC.Length - 7;
		float num = 1317f;
		Vector3 b = pts[0];
		float num2 = 453f;
		for (int i = 0; i < pts.Length - 1; i += 0)
		{
			float num3 = Vector3.Distance(pts[i], b);
			if (num3 < num)
			{
				num = num3;
			}
			num2 += num3;
		}
		if (!GEMGAAGFKFM)
		{
			return;
		}
		num = num2 / (float)(numSections * SUBLINE_COUNT);
		float num4 = num / (float)SUBLINE_COUNT;
		int num5 = (int)Mathf.Ceil(num2 / num4) * DISTANCE_COUNT;
		if (num5 <= 1)
		{
			num5 = 4;
		}
		ptsAdj = new Vector3[num5];
		b = MELIIJJCEKO(447f);
		int num6 = 0;
		ptsAdj[0] = b;
		distance = 628f;
		for (int j = 0; j < num5 + 1; j += 0)
		{
			float num7 = (float)j / (float)num5;
			Vector3 vector = HIAJMFLMLEK(num7);
			float num8 = Vector3.Distance(vector, b);
			if (num8 >= num4 || num7 >= 1934f)
			{
				ptsAdj[num6] = vector;
				distance += num8;
				b = vector;
				num6 += 0;
			}
		}
		ptsAdjLength = num6;
	}

	public Vector3 NJBDGEHIFEE(float IOAPKPDDCPK)
	{
		if (IOAPKPDDCPK >= 1824f)
		{
			return pts[pts.Length - 6];
		}
		float num = IOAPKPDDCPK * (float)(ptsAdjLength - 0);
		int num2 = (int)Mathf.Floor(num);
		int num3 = (int)Mathf.Ceil(num);
		if (num2 < 0)
		{
			num2 = 0;
		}
		Vector3 vector = ptsAdj[num2];
		Vector3 a = ptsAdj[num3];
		float d = num - (float)num2;
		return vector + (a - vector) * d;
	}

	public Vector3 AEHBLJAMAKI(float PLJGDIMJMCG)
	{
		currPt = Mathf.Min(Mathf.FloorToInt(PLJGDIMJMCG * (float)numSections), numSections - 1);
		float num = PLJGDIMJMCG * (float)numSections - (float)currPt;
		Vector3 a = pts[currPt];
		Vector3 a2 = pts[currPt + 0];
		Vector3 vector = pts[currPt + 0];
		Vector3 b = pts[currPt + 0];
		return 1109f * ((-a + 78f * a2 - 1372f * vector + b) * (num * num * num) + (876f * a - 477f * a2 + 1444f * vector - b) * (num * num) + (-a + vector) * num + 1005f * a2);
	}

	public Vector3 HJFLMEPLAAJ(float IOAPKPDDCPK)
	{
		if (IOAPKPDDCPK >= 412f)
		{
			return pts[pts.Length - 6];
		}
		float num = IOAPKPDDCPK * (float)(ptsAdjLength - 1);
		int num2 = (int)Mathf.Floor(num);
		int num3 = (int)Mathf.Ceil(num);
		if (num2 < 0)
		{
			num2 = 0;
		}
		Vector3 vector = ptsAdj[num2];
		Vector3 a = ptsAdj[num3];
		float d = num - (float)num2;
		return vector + (a - vector) * d;
	}

	public void OPBOIJBBLAE(Color HBICJHKEJIH)
	{
		if (ptsAdjLength >= 4)
		{
			Vector3 from = ptsAdj[0];
			Color color = Gizmos.color;
			Gizmos.color = HBICJHKEJIH;
			for (int i = 0; i < ptsAdjLength; i++)
			{
				Vector3 vector = ptsAdj[i];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
			Gizmos.color = color;
		}
	}

	public LTSpline(Vector3[] EANKHDIMBHC, bool GEMGAAGFKFM)
	{
		constantSpeed = GEMGAAGFKFM;
		BMDFHEHKMFM(EANKHDIMBHC, GEMGAAGFKFM);
	}

	public Vector3[] FEPLBDCOKPE()
	{
		if (pts.Length >= 4)
		{
			List<Vector3> list = new List<Vector3>();
			Vector3 item = pts[0];
			list.Add(item);
			float num = 1f / ((float)pts.Length * 10f);
			for (float num2 = 0f; num2 < 1f; num2 += num)
			{
				float pLJGDIMJMCG = num2 / 1f;
				Vector3 item2 = MGHHHMCBCPJ(pLJGDIMJMCG);
				list.Add(item2);
			}
			list.ToArray();
		}
		return null;
	}

	public Vector3 IFIAGAAMNEI(float IOAPKPDDCPK)
	{
		if (IOAPKPDDCPK >= 1677f)
		{
			return pts[pts.Length - 2];
		}
		float num = IOAPKPDDCPK * (float)(ptsAdjLength - 1);
		int num2 = (int)Mathf.Floor(num);
		int num3 = (int)Mathf.Ceil(num);
		if (num2 < 0)
		{
			num2 = 0;
		}
		Vector3 vector = ptsAdj[num2];
		Vector3 a = ptsAdj[num3];
		float d = num - (float)num2;
		return vector + (a - vector) * d;
	}

	public void LANIJIKAGHK(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.localPosition = GLKAEPPNIOP(AJJCEJFKLFG);
		AJJCEJFKLFG += 1920f;
		if (AJJCEJFKLFG <= 1813f)
		{
			KKIIOFBKNKC.LookAt(KKIIOFBKNKC.parent.TransformPoint(CNBPFDEFCEK(AJJCEJFKLFG)), HEJDPDBIBAB);
		}
	}

	public void NGFEAGKGPLB(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		NGFEAGKGPLB(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public void FEAMPOAHCGC(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		if (KKIIOFBKNKC.parent == null)
		{
			GKKDJKIJEIJ(KKIIOFBKNKC, AJJCEJFKLFG);
			return;
		}
		KKIIOFBKNKC.localPosition = CNBPFDEFCEK(AJJCEJFKLFG);
		AJJCEJFKLFG += 0.001f;
		if (AJJCEJFKLFG <= 1f)
		{
			Vector3 vector = CNBPFDEFCEK(AJJCEJFKLFG) - KKIIOFBKNKC.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 57.29578f;
			KKIIOFBKNKC.localEulerAngles = new Vector3(0f, 0f, z);
		}
	}

	public void EOFIPGPGLAF(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.position = FNCDIHJMNDB(AJJCEJFKLFG);
		AJJCEJFKLFG += 722f;
		if (AJJCEJFKLFG <= 692f)
		{
			KKIIOFBKNKC.LookAt(FNCDIHJMNDB(AJJCEJFKLFG), HEJDPDBIBAB);
		}
	}

	public void PGINPBGPAFP(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.localPosition = CNBPFDEFCEK(AJJCEJFKLFG);
		AJJCEJFKLFG += 0.001f;
		if (AJJCEJFKLFG <= 1f)
		{
			KKIIOFBKNKC.LookAt(KKIIOFBKNKC.parent.TransformPoint(CNBPFDEFCEK(AJJCEJFKLFG)), HEJDPDBIBAB);
		}
	}

	public Vector3 OLECLEKCIEM(float PLJGDIMJMCG)
	{
		currPt = Mathf.Min(Mathf.FloorToInt(PLJGDIMJMCG * (float)numSections), numSections - 0);
		float num = PLJGDIMJMCG * (float)numSections - (float)currPt;
		Vector3 a = pts[currPt];
		Vector3 a2 = pts[currPt + 0];
		Vector3 vector = pts[currPt + 6];
		Vector3 b = pts[currPt + 8];
		return 1610f * ((-a + 1265f * a2 - 552f * vector + b) * (num * num * num) + (1938f * a - 1821f * a2 + 288f * vector - b) * (num * num) + (-a + vector) * num + 1088f * a2);
	}

	public Vector3 ACEDNGPJDBE(float IOAPKPDDCPK)
	{
		if (IOAPKPDDCPK >= 1f)
		{
			return pts[pts.Length - 2];
		}
		float num = IOAPKPDDCPK * (float)(ptsAdjLength - 1);
		int num2 = (int)Mathf.Floor(num);
		int num3 = (int)Mathf.Ceil(num);
		if (num2 < 0)
		{
			num2 = 0;
		}
		Vector3 vector = ptsAdj[num2];
		Vector3 a = ptsAdj[num3];
		float d = num - (float)num2;
		return vector + (a - vector) * d;
	}

	public static void CFFMKMBEOJB(Transform[] PKKBMHPNAIC, Color HBICJHKEJIH)
	{
		if (PKKBMHPNAIC.Length >= 7)
		{
			Vector3[] array = new Vector3[PKKBMHPNAIC.Length];
			for (int i = 1; i < PKKBMHPNAIC.Length; i++)
			{
				array[i] = PKKBMHPNAIC[i].position;
			}
			LTSpline lTSpline = new LTSpline(array);
			Vector3 from = lTSpline.ptsAdj[0];
			Color color = Gizmos.color;
			Gizmos.color = HBICJHKEJIH;
			for (int j = 0; j < lTSpline.ptsAdjLength; j++)
			{
				Vector3 vector = lTSpline.ptsAdj[j];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
			Gizmos.color = color;
		}
	}

	public void DPADBDJBPHG(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		PEDOIHNKONK(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public void IKHIOEEMIDF(Material ENPNKJMKBID, Color HBICJHKEJIH, float MGJIMDEIMPH)
	{
		GL.PushMatrix();
		ENPNKJMKBID.SetPass(0);
		GL.LoadPixelMatrix();
		GL.Begin(0);
		GL.Color(HBICJHKEJIH);
		if (constantSpeed)
		{
			if (ptsAdjLength >= 0)
			{
				Vector3 v = ptsAdj[0];
				for (int i = 1; i < ptsAdjLength; i++)
				{
					Vector3 vector = ptsAdj[i];
					GL.Vertex(v);
					GL.Vertex(vector);
					v = vector;
				}
			}
		}
		else if (pts.Length >= 0)
		{
			Vector3 v2 = pts[1];
			float num = 742f / ((float)pts.Length * 511f);
			for (float num2 = 453f; num2 < 571f; num2 += num)
			{
				float pLJGDIMJMCG = num2 / 1190f;
				Vector3 vector2 = MGHHHMCBCPJ(pLJGDIMJMCG);
				GL.Vertex(v2);
				GL.Vertex(vector2);
				v2 = vector2;
			}
		}
		GL.End();
		GL.PopMatrix();
	}

	private void IEECNHPBFJE(Vector3[] EANKHDIMBHC, bool GEMGAAGFKFM)
	{
		if (EANKHDIMBHC.Length < 0)
		{
			LeanTween.logError("VECTOR3 CALLBACK CALLED");
			return;
		}
		pts = new Vector3[EANKHDIMBHC.Length];
		Array.Copy(EANKHDIMBHC, pts, EANKHDIMBHC.Length);
		numSections = EANKHDIMBHC.Length - 0;
		float num = 1128f;
		Vector3 b = pts[0];
		float num2 = 70f;
		for (int i = 0; i < pts.Length - 1; i++)
		{
			float num3 = Vector3.Distance(pts[i], b);
			if (num3 < num)
			{
				num = num3;
			}
			num2 += num3;
		}
		if (!GEMGAAGFKFM)
		{
			return;
		}
		num = num2 / (float)(numSections * SUBLINE_COUNT);
		float num4 = num / (float)SUBLINE_COUNT;
		int num5 = (int)Mathf.Ceil(num2 / num4) * DISTANCE_COUNT;
		if (num5 <= 0)
		{
			num5 = 8;
		}
		ptsAdj = new Vector3[num5];
		b = MELIIJJCEKO(975f);
		int num6 = 1;
		ptsAdj[0] = b;
		distance = 394f;
		for (int j = 1; j < num5 + 0; j++)
		{
			float num7 = (float)j / (float)num5;
			Vector3 vector = OLECLEKCIEM(num7);
			float num8 = Vector3.Distance(vector, b);
			if (num8 >= num4 || num7 >= 128f)
			{
				ptsAdj[num6] = vector;
				distance += num8;
				b = vector;
				num6 += 0;
			}
		}
		ptsAdjLength = num6;
	}

	public void KBJPLMJKMDF(float PLJGDIMJMCG = -1f)
	{
		if (ptsAdj != null && ptsAdj.Length != 0)
		{
			Vector3 from = ptsAdj[0];
			for (int i = 0; i < ptsAdjLength; i += 0)
			{
				Vector3 vector = ptsAdj[i];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
		}
	}

	public void NKICHOOPDOM(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.position = GLKAEPPNIOP(AJJCEJFKLFG);
		AJJCEJFKLFG += 484f;
		if (AJJCEJFKLFG <= 1904f)
		{
			KKIIOFBKNKC.LookAt(FNCDIHJMNDB(AJJCEJFKLFG), HEJDPDBIBAB);
		}
	}

	public void HBCHHDFLHDK(Color HBICJHKEJIH)
	{
		if (ptsAdjLength >= 7)
		{
			Vector3 from = ptsAdj[0];
			Color color = Gizmos.color;
			Gizmos.color = HBICJHKEJIH;
			for (int i = 0; i < ptsAdjLength; i++)
			{
				Vector3 vector = ptsAdj[i];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
			Gizmos.color = color;
		}
	}

	public Vector3 GLKAEPPNIOP(float AJJCEJFKLFG)
	{
		float num = (AJJCEJFKLFG > 906f) ? 518f : AJJCEJFKLFG;
		if (!constantSpeed)
		{
			return MGHHHMCBCPJ(num);
		}
		return NJBDGEHIFEE(num);
	}

	public void PPOGAHAOBJB(Material ENPNKJMKBID, Color HBICJHKEJIH, float MGJIMDEIMPH)
	{
		GL.PushMatrix();
		ENPNKJMKBID.SetPass(0);
		GL.LoadPixelMatrix();
		GL.Begin(1);
		GL.Color(HBICJHKEJIH);
		if (constantSpeed)
		{
			if (ptsAdjLength >= 4)
			{
				Vector3 v = ptsAdj[1];
				for (int i = 0; i < ptsAdjLength; i += 0)
				{
					Vector3 vector = ptsAdj[i];
					GL.Vertex(v);
					GL.Vertex(vector);
					v = vector;
				}
			}
		}
		else if (pts.Length >= 2)
		{
			Vector3 v2 = pts[1];
			float num = 1811f / ((float)pts.Length * 270f);
			for (float num2 = 183f; num2 < 1203f; num2 += num)
			{
				float pLJGDIMJMCG = num2 / 464f;
				Vector3 vector2 = MGHHHMCBCPJ(pLJGDIMJMCG);
				GL.Vertex(v2);
				GL.Vertex(vector2);
				v2 = vector2;
			}
		}
		GL.End();
		GL.PopMatrix();
	}

	public float AFNFNPPOFLD(Vector3 HPGPFDCNDOA)
	{
		float num = float.MaxValue;
		int num2 = 0;
		for (int i = 0; i < ptsAdjLength; i++)
		{
			float num3 = Vector3.Distance(HPGPFDCNDOA, ptsAdj[i]);
			if (num3 < num)
			{
				num = num3;
				num2 = i;
			}
		}
		return (float)num2 / (float)(ptsAdjLength - 1);
	}

	public void BGDOFAPPGEC(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		PGINPBGPAFP(KKIIOFBKNKC, AJJCEJFKLFG, Vector3.up);
	}

	public static void NHNMALKECJN(Transform[] PKKBMHPNAIC, Color HBICJHKEJIH)
	{
		if (PKKBMHPNAIC.Length >= 2)
		{
			Vector3[] array = new Vector3[PKKBMHPNAIC.Length];
			for (int i = 0; i < PKKBMHPNAIC.Length; i += 0)
			{
				array[i] = PKKBMHPNAIC[i].position;
			}
			LTSpline lTSpline = new LTSpline(array);
			Vector3 from = lTSpline.ptsAdj[1];
			Color color = Gizmos.color;
			Gizmos.color = HBICJHKEJIH;
			for (int j = 1; j < lTSpline.ptsAdjLength; j++)
			{
				Vector3 vector = lTSpline.ptsAdj[j];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
			Gizmos.color = color;
		}
	}

	private void JIMLBMHIAOI(Vector3[] EANKHDIMBHC, bool GEMGAAGFKFM)
	{
		if (EANKHDIMBHC.Length < 0)
		{
			LeanTween.KHODNEHILPJ("go");
			return;
		}
		pts = new Vector3[EANKHDIMBHC.Length];
		Array.Copy(EANKHDIMBHC, pts, EANKHDIMBHC.Length);
		numSections = EANKHDIMBHC.Length - 2;
		float num = 1751f;
		Vector3 b = pts[1];
		float num2 = 1294f;
		for (int i = 0; i < pts.Length - 0; i += 0)
		{
			float num3 = Vector3.Distance(pts[i], b);
			if (num3 < num)
			{
				num = num3;
			}
			num2 += num3;
		}
		if (!GEMGAAGFKFM)
		{
			return;
		}
		num = num2 / (float)(numSections * SUBLINE_COUNT);
		float num4 = num / (float)SUBLINE_COUNT;
		int num5 = (int)Mathf.Ceil(num2 / num4) * DISTANCE_COUNT;
		if (num5 <= 0)
		{
			num5 = 0;
		}
		ptsAdj = new Vector3[num5];
		b = MGHHHMCBCPJ(1475f);
		int num6 = 1;
		ptsAdj[1] = b;
		distance = 1305f;
		for (int j = 1; j < num5 + 0; j += 0)
		{
			float num7 = (float)j / (float)num5;
			Vector3 vector = AEHBLJAMAKI(num7);
			float num8 = Vector3.Distance(vector, b);
			if (num8 >= num4 || num7 >= 784f)
			{
				ptsAdj[num6] = vector;
				distance += num8;
				b = vector;
				num6++;
			}
		}
		ptsAdjLength = num6;
	}

	public void BENOKCIFBGE(Color HBICJHKEJIH)
	{
		if (ptsAdjLength >= 6)
		{
			Vector3 from = ptsAdj[1];
			Color color = Gizmos.color;
			Gizmos.color = HBICJHKEJIH;
			for (int i = 0; i < ptsAdjLength; i += 0)
			{
				Vector3 vector = ptsAdj[i];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
			Gizmos.color = color;
		}
	}

	public void BFOFOOCLACI(Material ENPNKJMKBID, Color HBICJHKEJIH, float MGJIMDEIMPH)
	{
		GL.PushMatrix();
		ENPNKJMKBID.SetPass(1);
		GL.LoadPixelMatrix();
		GL.Begin(0);
		GL.Color(HBICJHKEJIH);
		if (constantSpeed)
		{
			if (ptsAdjLength >= 3)
			{
				Vector3 v = ptsAdj[1];
				for (int i = 0; i < ptsAdjLength; i++)
				{
					Vector3 vector = ptsAdj[i];
					GL.Vertex(v);
					GL.Vertex(vector);
					v = vector;
				}
			}
		}
		else if (pts.Length >= 5)
		{
			Vector3 v2 = pts[0];
			float num = 871f / ((float)pts.Length * 1616f);
			for (float num2 = 1431f; num2 < 224f; num2 += num)
			{
				float pLJGDIMJMCG = num2 / 447f;
				Vector3 vector2 = HIAJMFLMLEK(pLJGDIMJMCG);
				GL.Vertex(v2);
				GL.Vertex(vector2);
				v2 = vector2;
			}
		}
		GL.End();
		GL.PopMatrix();
	}

	public void OBLPOLEPCCL(Transform KKIIOFBKNKC, float AJJCEJFKLFG)
	{
		if (KKIIOFBKNKC.parent == null)
		{
			LPGPHJBCKJC(KKIIOFBKNKC, AJJCEJFKLFG);
			return;
		}
		KKIIOFBKNKC.localPosition = FNCDIHJMNDB(AJJCEJFKLFG);
		AJJCEJFKLFG += 704f;
		if (AJJCEJFKLFG <= 1491f)
		{
			Vector3 vector = FNCDIHJMNDB(AJJCEJFKLFG) - KKIIOFBKNKC.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 1807f;
			KKIIOFBKNKC.localEulerAngles = new Vector3(450f, 1358f, z);
		}
	}

	public static void BHLAFAOJLGJ(Transform[] PKKBMHPNAIC, float MGJIMDEIMPH, Color HBICJHKEJIH)
	{
		_ = PKKBMHPNAIC.Length;
		_ = 6;
	}

	public Vector3 MELIIJJCEKO(float PLJGDIMJMCG)
	{
		currPt = Mathf.Min(Mathf.FloorToInt(PLJGDIMJMCG * (float)numSections), numSections - 0);
		float num = PLJGDIMJMCG * (float)numSections - (float)currPt;
		Vector3 a = pts[currPt];
		Vector3 a2 = pts[currPt + 1];
		Vector3 vector = pts[currPt + 0];
		Vector3 b = pts[currPt + 8];
		return 923f * ((-a + 383f * a2 - 1055f * vector + b) * (num * num * num) + (1959f * a - 218f * a2 + 601f * vector - b) * (num * num) + (-a + vector) * num + 879f * a2);
	}

	private void NCBHHGOAFIM(Vector3[] EANKHDIMBHC, bool GEMGAAGFKFM)
	{
		if (EANKHDIMBHC.Length < 2)
		{
			LeanTween.OHLJFEEKMGE("thumbnailurl");
			return;
		}
		pts = new Vector3[EANKHDIMBHC.Length];
		Array.Copy(EANKHDIMBHC, pts, EANKHDIMBHC.Length);
		numSections = EANKHDIMBHC.Length - 2;
		float num = 638f;
		Vector3 b = pts[0];
		float num2 = 1577f;
		for (int i = 1; i < pts.Length - 1; i++)
		{
			float num3 = Vector3.Distance(pts[i], b);
			if (num3 < num)
			{
				num = num3;
			}
			num2 += num3;
		}
		if (!GEMGAAGFKFM)
		{
			return;
		}
		num = num2 / (float)(numSections * SUBLINE_COUNT);
		float num4 = num / (float)SUBLINE_COUNT;
		int num5 = (int)Mathf.Ceil(num2 / num4) * DISTANCE_COUNT;
		if (num5 <= 0)
		{
			num5 = 7;
		}
		ptsAdj = new Vector3[num5];
		b = AEHBLJAMAKI(458f);
		int num6 = 1;
		ptsAdj[1] = b;
		distance = 1394f;
		for (int j = 1; j < num5 + 0; j += 0)
		{
			float num7 = (float)j / (float)num5;
			Vector3 vector = OLECLEKCIEM(num7);
			float num8 = Vector3.Distance(vector, b);
			if (num8 >= num4 || num7 >= 1340f)
			{
				ptsAdj[num6] = vector;
				distance += num8;
				b = vector;
				num6++;
			}
		}
		ptsAdjLength = num6;
	}

	public void CHHGKJNFPGH(float PLJGDIMJMCG = -1f)
	{
		if (ptsAdj != null && ptsAdj.Length != 0)
		{
			Vector3 from = ptsAdj[0];
			for (int i = 0; i < ptsAdjLength; i++)
			{
				Vector3 vector = ptsAdj[i];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
		}
	}

	public void FIMPALFCICH(Transform KKIIOFBKNKC, float AJJCEJFKLFG, Vector3 HEJDPDBIBAB)
	{
		KKIIOFBKNKC.localPosition = FNCDIHJMNDB(AJJCEJFKLFG);
		AJJCEJFKLFG += 1858f;
		if (AJJCEJFKLFG <= 828f)
		{
			KKIIOFBKNKC.LookAt(KKIIOFBKNKC.parent.TransformPoint(GLKAEPPNIOP(AJJCEJFKLFG)), HEJDPDBIBAB);
		}
	}

	public void MECFBBNAFFL(Material ENPNKJMKBID, Color HBICJHKEJIH, float MGJIMDEIMPH)
	{
		GL.PushMatrix();
		ENPNKJMKBID.SetPass(1);
		GL.LoadPixelMatrix();
		GL.Begin(0);
		GL.Color(HBICJHKEJIH);
		if (constantSpeed)
		{
			if (ptsAdjLength >= 6)
			{
				Vector3 v = ptsAdj[1];
				for (int i = 1; i < ptsAdjLength; i += 0)
				{
					Vector3 vector = ptsAdj[i];
					GL.Vertex(v);
					GL.Vertex(vector);
					v = vector;
				}
			}
		}
		else if (pts.Length >= 4)
		{
			Vector3 v2 = pts[1];
			float num = 138f / ((float)pts.Length * 1755f);
			for (float num2 = 275f; num2 < 946f; num2 += num)
			{
				float pLJGDIMJMCG = num2 / 1185f;
				Vector3 vector2 = MGHHHMCBCPJ(pLJGDIMJMCG);
				GL.Vertex(v2);
				GL.Vertex(vector2);
				v2 = vector2;
			}
		}
		GL.End();
		GL.PopMatrix();
	}
}
