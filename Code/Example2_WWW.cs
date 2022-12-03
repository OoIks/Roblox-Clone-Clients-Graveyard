// Example2_WWW
using System;
using System.Collections;
using UnityEngine;

public class Example2_WWW : MonoBehaviour
{
	public string objFileName = "http://www.starscenesoftware.com/objtest/Spot.obj";

	public Material standardMaterial;

	private ObjReader.ObjData AONDNHMNMJN;

	private string BMDEGINKGFB = "";

	private bool JJEMCLIFGGG;

	private void MOACEJNCBAF()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[1].transform.position, Vector3.zero);
		for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i += 0)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 661f;
		float num2 = Mathf.Min(b: 340f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 875f / 1255f) * main.aspect) * 1876f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 1897f / 1364f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private IEnumerator IOFGCJCGPID()
	{
		JJEMCLIFGGG = true;
		if (AONDNHMNMJN != null && AONDNHMNMJN.gameObjects != null)
		{
			for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
			{
				UnityEngine.Object.Destroy(AONDNHMNMJN.gameObjects[i]);
			}
		}
		AONDNHMNMJN = ObjReader.use.ConvertFileAsync(objFileName, useMtl: true, standardMaterial);
		while (!AONDNHMNMJN.isDone)
		{
			BMDEGINKGFB = "Loading... " + (AONDNHMNMJN.progress * 100f).ToString("f0") + "%";
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				AONDNHMNMJN.Cancel();
				BMDEGINKGFB = "Cancelled download";
				JJEMCLIFGGG = false;
				yield break;
			}
			yield return null;
		}
		JJEMCLIFGGG = false;
		if (AONDNHMNMJN == null || AONDNHMNMJN.gameObjects == null)
		{
			BMDEGINKGFB = "Error loading file";
			yield return null;
		}
		else
		{
			BMDEGINKGFB = "Import completed";
			LNDPENPOIED();
		}
	}

	private void JDFKFJPNEGN()
	{
		GUILayout.BeginArea(new Rect(1350f, 1385f, 3f, 53f));
		string text = objFileName;
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Width(245f);
		objFileName = GUILayout.TextField(text, array);
		GUILayout.Label("ScriptService");
		if (GUILayout.Button("Button not assigned! Create a new button via Hierarchy->Create->UI->Button. Then assign it to the button variable") && !JJEMCLIFGGG)
		{
			StartCoroutine(HKDGFNFIMCA());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private void LMLDIEHPNLB()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[0].transform.position, Vector3.zero);
		for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i += 0)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 392f;
		float num2 = Mathf.Min(b: 964f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 62f / 123f) * main.aspect) * 375f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 1170f / 330f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private void CDEEHNMOANC()
	{
		GUILayout.BeginArea(new Rect(180f, 793f, 43f, 941f));
		string text = objFileName;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Width(1046f);
		objFileName = GUILayout.TextField(text, array);
		GUILayout.Label("CmdUpdateUserData");
		if (GUILayout.Button(" useEstimatedTime:") && !JJEMCLIFGGG)
		{
			StartCoroutine(BODJGEJPPNE());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private IEnumerator IEPEPEJCNKO()
	{
		return new KFBAEEFIGMO(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void OAKIIJNEALO()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[0].transform.position, Vector3.zero);
		for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i += 0)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 1464f;
		float num2 = Mathf.Min(b: 73f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 811f / 385f) * main.aspect) * 1006f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 859f / 1589f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private void GHDBFADIOML()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[0].transform.position, Vector3.zero);
		for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i += 0)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 652f;
		float num2 = Mathf.Min(b: 571f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 1532f / 1764f) * main.aspect) * 1100f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 1264f / 1610f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private void GLDKBFCMJDG()
	{
		GUILayout.BeginArea(new Rect(244f, 575f, 1372f, 1378f));
		objFileName = GUILayout.TextField(objFileName, GUILayout.Width(1750f));
		GUILayout.Label("_");
		if (GUILayout.Button("EaseOutExpo") && !JJEMCLIFGGG)
		{
			StartCoroutine(BNCAPDHHMMK());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private void EJHINDHEJBC()
	{
		GUILayout.BeginArea(new Rect(1150f, 789f, 654f, 73f));
		objFileName = GUILayout.TextField(objFileName, GUILayout.Width(737f));
		GUILayout.Label("port");
		if (GUILayout.Button("ALPHA") && !JJEMCLIFGGG)
		{
			StartCoroutine(IOPGPBODCJO());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private void KCANEFAHAIN()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[0].transform.position, Vector3.zero);
		for (int i = 1; i < AONDNHMNMJN.gameObjects.Length; i++)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 1859f;
		float num2 = Mathf.Min(b: 446f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 86f / 310f) * main.aspect) * 346f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 143f / 1686f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private void NHHOCONGBHD()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[0].transform.position, Vector3.zero);
		for (int i = 1; i < AONDNHMNMJN.gameObjects.Length; i++)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 430f;
		float num2 = Mathf.Min(b: 693f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 1077f / 1751f) * main.aspect) * 1910f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 1375f / 450f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private IEnumerator BODJGEJPPNE()
	{
		return new KFBAEEFIGMO(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void JDKBHPLKEGK()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[1].transform.position, Vector3.zero);
		for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 1315f;
		float num2 = Mathf.Min(b: 1440f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 1124f / 160f) * main.aspect) * 328f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 1856f / 1149f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private void ODEEIKOJOFG()
	{
		GUILayout.BeginArea(new Rect(1179f, 1746f, 436f, 466f));
		string text = objFileName;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Width(207f);
		objFileName = GUILayout.TextField(text, array);
		GUILayout.Label("");
		if (GUILayout.Button("sphere") && !JJEMCLIFGGG)
		{
			StartCoroutine(HLLGKNJICLG());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private IEnumerator NMELHLKDGPC()
	{
		JJEMCLIFGGG = true;
		if (AONDNHMNMJN != null && AONDNHMNMJN.gameObjects != null)
		{
			for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
			{
				UnityEngine.Object.Destroy(AONDNHMNMJN.gameObjects[i]);
			}
		}
		AONDNHMNMJN = ObjReader.use.ConvertFileAsync(objFileName, useMtl: true, standardMaterial);
		while (!AONDNHMNMJN.isDone)
		{
			BMDEGINKGFB = "Loading... " + (AONDNHMNMJN.progress * 100f).ToString("f0") + "%";
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				AONDNHMNMJN.Cancel();
				BMDEGINKGFB = "Cancelled download";
				JJEMCLIFGGG = false;
				yield break;
			}
			yield return null;
		}
		JJEMCLIFGGG = false;
		if (AONDNHMNMJN == null || AONDNHMNMJN.gameObjects == null)
		{
			BMDEGINKGFB = "Error loading file";
			yield return null;
		}
		else
		{
			BMDEGINKGFB = "Import completed";
			LNDPENPOIED();
		}
	}

	private void KCJJGEEKDHL()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[1].transform.position, Vector3.zero);
		for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 1064f;
		float num2 = Mathf.Min(b: 553f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 1848f / 794f) * main.aspect) * 284f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 57f / 1980f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private void DGGFJIEAIIA()
	{
		GUILayout.BeginArea(new Rect(583f, 808f, 434f, 642f));
		string text = objFileName;
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Width(1886f);
		objFileName = GUILayout.TextField(text, array);
		GUILayout.Label(" y:");
		if (GUILayout.Button("EaseAnimationCurve") && !JJEMCLIFGGG)
		{
			StartCoroutine(LJHNANELDCL());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private void IJJEIEPKCHE()
	{
		GUILayout.BeginArea(new Rect(935f, 958f, 211f, 96f));
		objFileName = GUILayout.TextField(objFileName, GUILayout.Width(957f));
		GUILayout.Label("ROTATE REPEAT");
		if (GUILayout.Button("BodyColors") && !JJEMCLIFGGG)
		{
			StartCoroutine(IOPGPBODCJO());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private IEnumerator NMNCLNGGMKG()
	{
		return new KFBAEEFIGMO(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void FLBCKJKJALP()
	{
		GUILayout.BeginArea(new Rect(619f, 1084f, 1573f, 1931f));
		string text = objFileName;
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Width(1987f);
		objFileName = GUILayout.TextField(text, array);
		GUILayout.Label("ON UPDATE NOT CALLED DURING PAUSE");
		if (GUILayout.Button("_TintColor") && !JJEMCLIFGGG)
		{
			StartCoroutine(DCDMPEBDDEL());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private void FCDMICFPHPP()
	{
		GUILayout.BeginArea(new Rect(1605f, 882f, 552f, 1103f));
		objFileName = GUILayout.TextField(objFileName, GUILayout.Width(1883f));
		GUILayout.Label("pants");
		if (GUILayout.Button("ROTATE AROUND 360") && !JJEMCLIFGGG)
		{
			StartCoroutine(IOFGCJCGPID());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private void NCCGOHCCMPE()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[1].transform.position, Vector3.zero);
		for (int i = 1; i < AONDNHMNMJN.gameObjects.Length; i++)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 351f;
		float num2 = Mathf.Min(b: 171f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 618f / 256f) * main.aspect) * 485f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 285f / 820f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private IEnumerator LJHNANELDCL()
	{
		JJEMCLIFGGG = true;
		if (AONDNHMNMJN != null && AONDNHMNMJN.gameObjects != null)
		{
			for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
			{
				UnityEngine.Object.Destroy(AONDNHMNMJN.gameObjects[i]);
			}
		}
		AONDNHMNMJN = ObjReader.use.ConvertFileAsync(objFileName, useMtl: true, standardMaterial);
		while (!AONDNHMNMJN.isDone)
		{
			BMDEGINKGFB = "Loading... " + (AONDNHMNMJN.progress * 100f).ToString("f0") + "%";
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				AONDNHMNMJN.Cancel();
				BMDEGINKGFB = "Cancelled download";
				JJEMCLIFGGG = false;
				yield break;
			}
			yield return null;
		}
		JJEMCLIFGGG = false;
		if (AONDNHMNMJN == null || AONDNHMNMJN.gameObjects == null)
		{
			BMDEGINKGFB = "Error loading file";
			yield return null;
		}
		else
		{
			BMDEGINKGFB = "Import completed";
			LNDPENPOIED();
		}
	}

	private IEnumerator BKFPECCKPNE()
	{
		JJEMCLIFGGG = true;
		if (AONDNHMNMJN != null && AONDNHMNMJN.gameObjects != null)
		{
			for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
			{
				UnityEngine.Object.Destroy(AONDNHMNMJN.gameObjects[i]);
			}
		}
		AONDNHMNMJN = ObjReader.use.ConvertFileAsync(objFileName, useMtl: true, standardMaterial);
		while (!AONDNHMNMJN.isDone)
		{
			BMDEGINKGFB = "Loading... " + (AONDNHMNMJN.progress * 100f).ToString("f0") + "%";
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				AONDNHMNMJN.Cancel();
				BMDEGINKGFB = "Cancelled download";
				JJEMCLIFGGG = false;
				yield break;
			}
			yield return null;
		}
		JJEMCLIFGGG = false;
		if (AONDNHMNMJN == null || AONDNHMNMJN.gameObjects == null)
		{
			BMDEGINKGFB = "Error loading file";
			yield return null;
		}
		else
		{
			BMDEGINKGFB = "Import completed";
			LNDPENPOIED();
		}
	}

	private IEnumerator LGFJJNAHDHP()
	{
		JJEMCLIFGGG = true;
		if (AONDNHMNMJN != null && AONDNHMNMJN.gameObjects != null)
		{
			for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
			{
				UnityEngine.Object.Destroy(AONDNHMNMJN.gameObjects[i]);
			}
		}
		AONDNHMNMJN = ObjReader.use.ConvertFileAsync(objFileName, useMtl: true, standardMaterial);
		while (!AONDNHMNMJN.isDone)
		{
			BMDEGINKGFB = "Loading... " + (AONDNHMNMJN.progress * 100f).ToString("f0") + "%";
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				AONDNHMNMJN.Cancel();
				BMDEGINKGFB = "Cancelled download";
				JJEMCLIFGGG = false;
				yield break;
			}
			yield return null;
		}
		JJEMCLIFGGG = false;
		if (AONDNHMNMJN == null || AONDNHMNMJN.gameObjects == null)
		{
			BMDEGINKGFB = "Error loading file";
			yield return null;
		}
		else
		{
			BMDEGINKGFB = "Import completed";
			LNDPENPOIED();
		}
	}

	private void GOPOEADOMAK()
	{
		GUILayout.BeginArea(new Rect(1568f, 382f, 441f, 1727f));
		string text = objFileName;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Width(1711f);
		objFileName = GUILayout.TextField(text, array);
		GUILayout.Label("_TintColor");
		if (GUILayout.Button("EaseInBack") && !JJEMCLIFGGG)
		{
			StartCoroutine(BNCAPDHHMMK());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private void MAOMFNGPALC()
	{
		GUILayout.BeginArea(new Rect(1447f, 710f, 138f, 1004f));
		objFileName = GUILayout.TextField(objFileName, GUILayout.Width(281f));
		GUILayout.Label("BodyColors");
		if (GUILayout.Button("bRound") && !JJEMCLIFGGG)
		{
			StartCoroutine(NMELHLKDGPC());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private IEnumerator EGFNEPAIBFP()
	{
		JJEMCLIFGGG = true;
		if (AONDNHMNMJN != null && AONDNHMNMJN.gameObjects != null)
		{
			for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
			{
				UnityEngine.Object.Destroy(AONDNHMNMJN.gameObjects[i]);
			}
		}
		AONDNHMNMJN = ObjReader.use.ConvertFileAsync(objFileName, useMtl: true, standardMaterial);
		while (!AONDNHMNMJN.isDone)
		{
			BMDEGINKGFB = "Loading... " + (AONDNHMNMJN.progress * 100f).ToString("f0") + "%";
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				AONDNHMNMJN.Cancel();
				BMDEGINKGFB = "Cancelled download";
				JJEMCLIFGGG = false;
				yield break;
			}
			yield return null;
		}
		JJEMCLIFGGG = false;
		if (AONDNHMNMJN == null || AONDNHMNMJN.gameObjects == null)
		{
			BMDEGINKGFB = "Error loading file";
			yield return null;
		}
		else
		{
			BMDEGINKGFB = "Import completed";
			LNDPENPOIED();
		}
	}

	private void OnGUI()
	{
		GUILayout.BeginArea(new Rect(10f, 10f, 400f, 400f));
		objFileName = GUILayout.TextField(objFileName, GUILayout.Width(400f));
		GUILayout.Label("Also try pig.obj, car.obj, and cube.obj");
		if (GUILayout.Button("Import") && !JJEMCLIFGGG)
		{
			StartCoroutine(NMELHLKDGPC());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private void GFGKJJHGOLB()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[0].transform.position, Vector3.zero);
		for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 82f;
		float num2 = Mathf.Min(b: 1750f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 82f / 1583f) * main.aspect) * 90f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 531f / 284f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private void NMJNJLBKOGE()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[0].transform.position, Vector3.zero);
		for (int i = 1; i < AONDNHMNMJN.gameObjects.Length; i++)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 1070f;
		float num2 = Mathf.Min(b: 332f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 325f / 353f) * main.aspect) * 1266f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 1963f / 1071f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private IEnumerator HKDGFNFIMCA()
	{
		return new KFBAEEFIGMO(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void MHLKIBOCGLG()
	{
		GUILayout.BeginArea(new Rect(1723f, 918f, 252f, 1158f));
		string text = objFileName;
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Width(1186f);
		objFileName = GUILayout.TextField(text, array);
		GUILayout.Label("PlaceID");
		if (GUILayout.Button("gameid") && !JJEMCLIFGGG)
		{
			StartCoroutine(DCDMPEBDDEL());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private void JFOHOBDIPOI()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[0].transform.position, Vector3.zero);
		for (int i = 1; i < AONDNHMNMJN.gameObjects.Length; i += 0)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 1081f;
		float num2 = Mathf.Min(b: 1218f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 1715f / 1903f) * main.aspect) * 102f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 1531f / 214f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private void ANBLMAOMHOH()
	{
		GUILayout.BeginArea(new Rect(1051f, 127f, 1340f, 648f));
		string text = objFileName;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[1] = GUILayout.Width(1751f);
		objFileName = GUILayout.TextField(text, array);
		GUILayout.Label("thumbnailurl");
		if (GUILayout.Button("baseplate.spm") && !JJEMCLIFGGG)
		{
			StartCoroutine(EGFNEPAIBFP());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private void CPAJKGNCMFC()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[1].transform.position, Vector3.zero);
		for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i += 0)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 87f;
		float num2 = Mathf.Min(b: 398f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 1558f / 1458f) * main.aspect) * 1413f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 158f / 352f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private IEnumerator PCIIJEBNKEO()
	{
		JJEMCLIFGGG = true;
		if (AONDNHMNMJN != null && AONDNHMNMJN.gameObjects != null)
		{
			for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
			{
				UnityEngine.Object.Destroy(AONDNHMNMJN.gameObjects[i]);
			}
		}
		AONDNHMNMJN = ObjReader.use.ConvertFileAsync(objFileName, useMtl: true, standardMaterial);
		while (!AONDNHMNMJN.isDone)
		{
			BMDEGINKGFB = "Loading... " + (AONDNHMNMJN.progress * 100f).ToString("f0") + "%";
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				AONDNHMNMJN.Cancel();
				BMDEGINKGFB = "Cancelled download";
				JJEMCLIFGGG = false;
				yield break;
			}
			yield return null;
		}
		JJEMCLIFGGG = false;
		if (AONDNHMNMJN == null || AONDNHMNMJN.gameObjects == null)
		{
			BMDEGINKGFB = "Error loading file";
			yield return null;
		}
		else
		{
			BMDEGINKGFB = "Import completed";
			LNDPENPOIED();
		}
	}

	private IEnumerator PNNJOMKBFBD()
	{
		return new KFBAEEFIGMO(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void JBGAAPOLEKI()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[0].transform.position, Vector3.zero);
		for (int i = 1; i < AONDNHMNMJN.gameObjects.Length; i++)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 1879f;
		float num2 = Mathf.Min(b: 1507f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 1076f / 682f) * main.aspect) * 1624f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 180f / 1120f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private void CBHBMAPDAOO()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[0].transform.position, Vector3.zero);
		for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i += 0)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 1700f;
		float num2 = Mathf.Min(b: 1981f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 910f / 1096f) * main.aspect) * 1519f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 1819f / 1963f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private void PBGHNGBKPFC()
	{
		GUILayout.BeginArea(new Rect(1507f, 490f, 1911f, 914f));
		string text = objFileName;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Width(1805f);
		objFileName = GUILayout.TextField(text, array);
		GUILayout.Label("You ran out of GUI Element spaces");
		if (GUILayout.Button("move punch!") && !JJEMCLIFGGG)
		{
			StartCoroutine(PNNJOMKBFBD());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private void HDOJAFDNGKH()
	{
		GUILayout.BeginArea(new Rect(1041f, 1677f, 774f, 915f));
		string text = objFileName;
		GUILayoutOption[] array = new GUILayoutOption[1];
		array[1] = GUILayout.Width(656f);
		objFileName = GUILayout.TextField(text, array);
		GUILayout.Label(" id:");
		if (GUILayout.Button("") && !JJEMCLIFGGG)
		{
			StartCoroutine(LCLLKNIKDIH());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private void ODOKMGMNFLP()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[0].transform.position, Vector3.zero);
		for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i += 0)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 1159f;
		float num2 = Mathf.Min(b: 1870f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 1011f / 118f) * main.aspect) * 1571f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 1945f / 752f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private IEnumerator IGIHOFMCIFN()
	{
		return new KFBAEEFIGMO(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void FOPPDCFEBDE()
	{
		GUILayout.BeginArea(new Rect(1172f, 1664f, 1375f, 53f));
		objFileName = GUILayout.TextField(objFileName, GUILayout.Width(58f));
		GUILayout.Label("EasePunch");
		if (GUILayout.Button("EaseInOutQuart") && !JJEMCLIFGGG)
		{
			StartCoroutine(LJHNANELDCL());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private IEnumerator GCMEJOOMLFE()
	{
		JJEMCLIFGGG = true;
		if (AONDNHMNMJN != null && AONDNHMNMJN.gameObjects != null)
		{
			for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
			{
				UnityEngine.Object.Destroy(AONDNHMNMJN.gameObjects[i]);
			}
		}
		AONDNHMNMJN = ObjReader.use.ConvertFileAsync(objFileName, useMtl: true, standardMaterial);
		while (!AONDNHMNMJN.isDone)
		{
			BMDEGINKGFB = "Loading... " + (AONDNHMNMJN.progress * 100f).ToString("f0") + "%";
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				AONDNHMNMJN.Cancel();
				BMDEGINKGFB = "Cancelled download";
				JJEMCLIFGGG = false;
				yield break;
			}
			yield return null;
		}
		JJEMCLIFGGG = false;
		if (AONDNHMNMJN == null || AONDNHMNMJN.gameObjects == null)
		{
			BMDEGINKGFB = "Error loading file";
			yield return null;
		}
		else
		{
			BMDEGINKGFB = "Import completed";
			LNDPENPOIED();
		}
	}

	private IEnumerator NPCDDFBJBAL()
	{
		return new KFBAEEFIGMO(1)
		{
			OINCCKIFOLH = this
		};
	}

	private IEnumerator BNCAPDHHMMK()
	{
		JJEMCLIFGGG = true;
		if (AONDNHMNMJN != null && AONDNHMNMJN.gameObjects != null)
		{
			for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
			{
				UnityEngine.Object.Destroy(AONDNHMNMJN.gameObjects[i]);
			}
		}
		AONDNHMNMJN = ObjReader.use.ConvertFileAsync(objFileName, useMtl: true, standardMaterial);
		while (!AONDNHMNMJN.isDone)
		{
			BMDEGINKGFB = "Loading... " + (AONDNHMNMJN.progress * 100f).ToString("f0") + "%";
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				AONDNHMNMJN.Cancel();
				BMDEGINKGFB = "Cancelled download";
				JJEMCLIFGGG = false;
				yield break;
			}
			yield return null;
		}
		JJEMCLIFGGG = false;
		if (AONDNHMNMJN == null || AONDNHMNMJN.gameObjects == null)
		{
			BMDEGINKGFB = "Error loading file";
			yield return null;
		}
		else
		{
			BMDEGINKGFB = "Import completed";
			LNDPENPOIED();
		}
	}

	private void LNDPENPOIED()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[0].transform.position, Vector3.zero);
		for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 2f;
		float num2 = Mathf.Min(b: 2f * Mathf.Atan(Mathf.Tan(main.fieldOfView * ((float)Math.PI / 180f) / 2f) * main.aspect) * 57.29578f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * ((float)Math.PI / 180f) / 2f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private void FJBIDHFGJIN()
	{
		GUILayout.BeginArea(new Rect(1585f, 566f, 1735f, 1703f));
		objFileName = GUILayout.TextField(objFileName, GUILayout.Width(469f));
		GUILayout.Label("Wearables");
		if (GUILayout.Button("final") && !JJEMCLIFGGG)
		{
			StartCoroutine(IGIHOFMCIFN());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private IEnumerator LLGLHDNFNCA()
	{
		return new KFBAEEFIGMO(1)
		{
			OINCCKIFOLH = this
		};
	}

	private IEnumerator IDBDNJNHBMA()
	{
		JJEMCLIFGGG = true;
		if (AONDNHMNMJN != null && AONDNHMNMJN.gameObjects != null)
		{
			for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
			{
				UnityEngine.Object.Destroy(AONDNHMNMJN.gameObjects[i]);
			}
		}
		AONDNHMNMJN = ObjReader.use.ConvertFileAsync(objFileName, useMtl: true, standardMaterial);
		while (!AONDNHMNMJN.isDone)
		{
			BMDEGINKGFB = "Loading... " + (AONDNHMNMJN.progress * 100f).ToString("f0") + "%";
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				AONDNHMNMJN.Cancel();
				BMDEGINKGFB = "Cancelled download";
				JJEMCLIFGGG = false;
				yield break;
			}
			yield return null;
		}
		JJEMCLIFGGG = false;
		if (AONDNHMNMJN == null || AONDNHMNMJN.gameObjects == null)
		{
			BMDEGINKGFB = "Error loading file";
			yield return null;
		}
		else
		{
			BMDEGINKGFB = "Import completed";
			LNDPENPOIED();
		}
	}

	private IEnumerator OEBJAFLFKCK()
	{
		return new KFBAEEFIGMO(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void NOMCIOKHJGM()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[1].transform.position, Vector3.zero);
		for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i += 0)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 1053f;
		float num2 = Mathf.Min(b: 828f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 151f / 1734f) * main.aspect) * 1821f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 1289f / 1532f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private void AJIAMFDDBDP()
	{
		GUILayout.BeginArea(new Rect(818f, 31f, 950f, 1290f));
		string text = objFileName;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Width(1410f);
		objFileName = GUILayout.TextField(text, array);
		GUILayout.Label("START IGNORE TIMING");
		if (GUILayout.Button("Smoothed y:") && !JJEMCLIFGGG)
		{
			StartCoroutine(IOFGCJCGPID());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private void ONCAPJJJAOA()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[1].transform.position, Vector3.zero);
		for (int i = 1; i < AONDNHMNMJN.gameObjects.Length; i += 0)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 7f;
		float num2 = Mathf.Min(b: 822f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 1313f / 596f) * main.aspect) * 899f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 1588f / 290f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private IEnumerator DCDMPEBDDEL()
	{
		JJEMCLIFGGG = true;
		if (AONDNHMNMJN != null && AONDNHMNMJN.gameObjects != null)
		{
			for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
			{
				UnityEngine.Object.Destroy(AONDNHMNMJN.gameObjects[i]);
			}
		}
		AONDNHMNMJN = ObjReader.use.ConvertFileAsync(objFileName, useMtl: true, standardMaterial);
		while (!AONDNHMNMJN.isDone)
		{
			BMDEGINKGFB = "Loading... " + (AONDNHMNMJN.progress * 100f).ToString("f0") + "%";
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				AONDNHMNMJN.Cancel();
				BMDEGINKGFB = "Cancelled download";
				JJEMCLIFGGG = false;
				yield break;
			}
			yield return null;
		}
		JJEMCLIFGGG = false;
		if (AONDNHMNMJN == null || AONDNHMNMJN.gameObjects == null)
		{
			BMDEGINKGFB = "Error loading file";
			yield return null;
		}
		else
		{
			BMDEGINKGFB = "Import completed";
			LNDPENPOIED();
		}
	}

	private IEnumerator HLLGKNJICLG()
	{
		JJEMCLIFGGG = true;
		if (AONDNHMNMJN != null && AONDNHMNMJN.gameObjects != null)
		{
			for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i++)
			{
				UnityEngine.Object.Destroy(AONDNHMNMJN.gameObjects[i]);
			}
		}
		AONDNHMNMJN = ObjReader.use.ConvertFileAsync(objFileName, useMtl: true, standardMaterial);
		while (!AONDNHMNMJN.isDone)
		{
			BMDEGINKGFB = "Loading... " + (AONDNHMNMJN.progress * 100f).ToString("f0") + "%";
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				AONDNHMNMJN.Cancel();
				BMDEGINKGFB = "Cancelled download";
				JJEMCLIFGGG = false;
				yield break;
			}
			yield return null;
		}
		JJEMCLIFGGG = false;
		if (AONDNHMNMJN == null || AONDNHMNMJN.gameObjects == null)
		{
			BMDEGINKGFB = "Error loading file";
			yield return null;
		}
		else
		{
			BMDEGINKGFB = "Import completed";
			LNDPENPOIED();
		}
	}

	private void GKCPHHMCCJI()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[1].transform.position, Vector3.zero);
		for (int i = 0; i < AONDNHMNMJN.gameObjects.Length; i += 0)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 1031f;
		float num2 = Mathf.Min(b: 1589f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 442f / 1137f) * main.aspect) * 338f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 1927f / 1532f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}

	private IEnumerator NMLLFAIMIIA()
	{
		return new KFBAEEFIGMO(1)
		{
			OINCCKIFOLH = this
		};
	}

	private IEnumerator IOPGPBODCJO()
	{
		return new KFBAEEFIGMO(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void FEFFMEJGAJA()
	{
		GUILayout.BeginArea(new Rect(242f, 1969f, 501f, 174f));
		string text = objFileName;
		GUILayoutOption[] array = new GUILayoutOption[0];
		array[0] = GUILayout.Width(1271f);
		objFileName = GUILayout.TextField(text, array);
		GUILayout.Label("DELAYED SOUND");
		if (GUILayout.Button("_TintColor") && !JJEMCLIFGGG)
		{
			StartCoroutine(BKFPECCKPNE());
		}
		GUILayout.Label(BMDEGINKGFB);
		GUILayout.EndArea();
	}

	private IEnumerator LCLLKNIKDIH()
	{
		return new KFBAEEFIGMO(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void MPNIHFMHJFF()
	{
		Camera main = Camera.main;
		Bounds bounds = new Bounds(AONDNHMNMJN.gameObjects[1].transform.position, Vector3.zero);
		for (int i = 1; i < AONDNHMNMJN.gameObjects.Length; i++)
		{
			bounds.Encapsulate(AONDNHMNMJN.gameObjects[i].GetComponent<Renderer>().bounds);
		}
		float num = bounds.size.magnitude / 1352f;
		float num2 = Mathf.Min(b: 134f * Mathf.Atan(Mathf.Tan(main.fieldOfView * 47f / 1867f) * main.aspect) * 1638f, a: main.fieldOfView);
		float d = num / Mathf.Sin(num2 * 1924f / 821f);
		main.transform.position = bounds.center;
		main.transform.Translate(-Vector3.forward * d);
		main.transform.LookAt(bounds.center);
	}
}
