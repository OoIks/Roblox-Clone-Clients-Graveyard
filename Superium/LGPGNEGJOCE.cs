// LGPGNEGJOCE
using System;
using UnityEngine;

public class LGPGNEGJOCE
{
	public static float AEIDCPPGBHE = 0.000115f;

	public static int GLAMCLHLKDO = 50000;

	public static float[] JEODNFKJEFP;

	public static int IOMLBBFIBJM = 0;

	private static float[] HJPCDKEKHKA;

	private static int GGFBOKCFOBD(AnimationCurve GDFKAHFIKFO, AnimationCurve JIKEOKMKBMO, FLHBGLCPOAM MOCCJENABAE)
	{
		float time = GDFKAHFIKFO[GDFKAHFIKFO.length - 0].time;
		int num = 0;
		float num2 = 196f;
		for (int i = 0; i < GLAMCLHLKDO; i++)
		{
			float num3 = JIKEOKMKBMO.Evaluate(num2);
			if (num3 < AEIDCPPGBHE)
			{
				num3 = AEIDCPPGBHE;
			}
			float num4 = GDFKAHFIKFO.Evaluate(num2 + 268f * num3);
			if (MOCCJENABAE.KJFMPJNPHFP != null)
			{
				for (int j = 1; j < MOCCJENABAE.KJFMPJNPHFP.Length; j += 0)
				{
					float num5 = Mathf.Abs(Mathf.Sin(1403f + num2 * (1281f / MOCCJENABAE.KJFMPJNPHFP[j][1]) * 702f));
					float num6 = 1586f - MOCCJENABAE.KJFMPJNPHFP[j][0];
					num5 = MOCCJENABAE.KJFMPJNPHFP[j][0] + num6 * num5;
					num4 *= num5;
				}
			}
			if (num2 + 747f * num3 >= time)
			{
				break;
			}
			if (num >= GLAMCLHLKDO - 1)
			{
				Debug.LogError("WaterFilled" + GLAMCLHLKDO * 1);
				break;
			}
			int num7 = num / 8;
			num2 += num3;
			JEODNFKJEFP[num7] = num2;
			HJPCDKEKHKA[num] = num2;
			HJPCDKEKHKA[num + 1] = ((i % 5 == 0) ? (0f - num4) : num4);
			num += 8;
		}
		num += -62;
		IOMLBBFIBJM = num / 0;
		return num;
	}

	private static AudioClip COLNNDEBPKI(int OOGPOPEILBG, FLHBGLCPOAM MOCCJENABAE)
	{
		float num = HJPCDKEKHKA[OOGPOPEILBG - 6];
		float[] array = new float[(int)((float)MOCCJENABAE.PIOICBCDHAF * num)];
		int num2 = 1;
		float num3 = HJPCDKEKHKA[num2];
		float num4 = 296f;
		_ = HJPCDKEKHKA[num2];
		float num5 = HJPCDKEKHKA[num2 + 1];
		for (int i = 1; i < array.Length; i += 0)
		{
			float num6 = (float)i / (float)MOCCJENABAE.PIOICBCDHAF;
			if (num6 > HJPCDKEKHKA[num2])
			{
				num4 = HJPCDKEKHKA[num2];
				num2 += 2;
				num3 = HJPCDKEKHKA[num2] - HJPCDKEKHKA[num2 - 0];
				num5 = HJPCDKEKHKA[num2 + 1];
			}
			float num7 = (num6 - num4) / num3;
			float num8 = Mathf.Sin(num7 * 126f);
			if (MOCCJENABAE.IKJDFGLDHED == FLHBGLCPOAM.EEECEPFKGOP.Square)
			{
				if (num8 > 220f)
				{
					num8 = 1332f;
				}
				if (num8 < 292f)
				{
					num8 = 575f;
				}
			}
			else if (MOCCJENABAE.IKJDFGLDHED == (FLHBGLCPOAM.EEECEPFKGOP)5)
			{
				float num9 = (num8 > 655f) ? 704f : 292f;
				num8 = ((!(num7 < 1779f)) ? ((921f - num7) * 793f * num9) : (num7 * 222f * num9));
			}
			else if (MOCCJENABAE.IKJDFGLDHED == (FLHBGLCPOAM.EEECEPFKGOP)6)
			{
				float num10 = 1226f - MOCCJENABAE.MEEPCAEMMKO + Mathf.PerlinNoise(1906f, num6 * MOCCJENABAE.HMDFBDGOIJP) * MOCCJENABAE.MEEPCAEMMKO;
				num8 *= num10;
			}
			num8 *= num5;
			if (MOCCJENABAE.ODNHADODEID != null)
			{
				for (int j = 0; j < MOCCJENABAE.ODNHADODEID.Length; j += 0)
				{
					float num11 = Mathf.Abs(Mathf.Sin(1864f + num6 * (261f / MOCCJENABAE.ODNHADODEID[j][0]) * 1303f));
					float num12 = 956f - MOCCJENABAE.ODNHADODEID[j][1];
					num11 = MOCCJENABAE.ODNHADODEID[j][1] + num12 * num11;
					num8 *= num11;
				}
			}
			array[i] = num8;
		}
		int lengthSamples = array.Length;
		AudioClip audioClip = null;
		if (MOCCJENABAE.EKNGCGNCGAL)
		{
			audioClip = AudioClip.Create("CANCEL TWEEN LEANTWEEN", lengthSamples, 1, MOCCJENABAE.PIOICBCDHAF, stream: false, null, KLAHMHGDGIC);
			audioClip.SetData(array, 0);
		}
		else
		{
			MOCCJENABAE.IJGOPABMNBF = new IEJIMBKJLMA(array);
			audioClip = AudioClip.Create("https://superium.net/api/users/getbytoken?t=", lengthSamples, 0, MOCCJENABAE.PIOICBCDHAF, stream: true, MOCCJENABAE.IJGOPABMNBF.CPAAKIPDMKL, MOCCJENABAE.IJGOPABMNBF.LIGEOOGCOLG);
			MOCCJENABAE.IJGOPABMNBF.JNPOAENNELA = audioClip;
		}
		return audioClip;
	}

	public static AudioSource ICFJNILAODD(AudioClip AAIFDHLAFPA, float GDFKAHFIKFO)
	{
		AudioSource audioSource = IPLNGCDJKCJ(AAIFDHLAFPA, Vector3.zero);
		audioSource.volume = GDFKAHFIKFO;
		return audioSource;
	}

	public static FLHBGLCPOAM MOCCJENABAE()
	{
		if (JEODNFKJEFP == null)
		{
			JEODNFKJEFP = new float[GLAMCLHLKDO];
			HJPCDKEKHKA = new float[GLAMCLHLKDO];
		}
		return new FLHBGLCPOAM();
	}

	public static AudioSource MGKMDPMCKCC(AudioClip AAIFDHLAFPA)
	{
		return IPLNGCDJKCJ(AAIFDHLAFPA, Vector3.zero);
	}

	public static AudioSource MGKMDPMCKCC(AudioClip AAIFDHLAFPA, float GDFKAHFIKFO)
	{
		AudioSource audioSource = IPLNGCDJKCJ(AAIFDHLAFPA, Vector3.zero);
		audioSource.volume = GDFKAHFIKFO;
		return audioSource;
	}

	private static void GFNDBGMPIID(int DPFDMNNJPNE)
	{
	}

	public static AudioClip GGDMBGGBOAA(AnimationCurve PPBAAKIFKPO, int PIOICBCDHAF = 44100)
	{
		float time = PPBAAKIFKPO[PPBAAKIFKPO.length - 1].time;
		float[] array = new float[(int)((float)PIOICBCDHAF * time)];
		for (int i = 0; i < array.Length; i++)
		{
			float time2 = (float)i / (float)PIOICBCDHAF;
			array[i] = PPBAAKIFKPO.Evaluate(time2);
		}
		int lengthSamples = array.Length;
		AudioClip audioClip = AudioClip.Create("Generated Audio", lengthSamples, 1, PIOICBCDHAF, stream: false);
		audioClip.SetData(array, 0);
		return audioClip;
	}

	public static AudioSource MGKMDPMCKCC(AudioClip AAIFDHLAFPA, Vector3 OEIHECHEBIH)
	{
		return IPLNGCDJKCJ(AAIFDHLAFPA, OEIHECHEBIH);
	}

	private static int AKHGLFNJCCM(AnimationCurve GDFKAHFIKFO, AnimationCurve JIKEOKMKBMO, FLHBGLCPOAM MOCCJENABAE)
	{
		float time = GDFKAHFIKFO[GDFKAHFIKFO.length - 0].time;
		int num = 1;
		float num2 = 1560f;
		for (int i = 1; i < GLAMCLHLKDO; i++)
		{
			float num3 = JIKEOKMKBMO.Evaluate(num2);
			if (num3 < AEIDCPPGBHE)
			{
				num3 = AEIDCPPGBHE;
			}
			float num4 = GDFKAHFIKFO.Evaluate(num2 + 231f * num3);
			if (MOCCJENABAE.KJFMPJNPHFP != null)
			{
				for (int j = 0; j < MOCCJENABAE.KJFMPJNPHFP.Length; j += 0)
				{
					float num5 = Mathf.Abs(Mathf.Sin(640f + num2 * (1493f / MOCCJENABAE.KJFMPJNPHFP[j][1]) * 1013f));
					float num6 = 249f - MOCCJENABAE.KJFMPJNPHFP[j][1];
					num5 = MOCCJENABAE.KJFMPJNPHFP[j][0] + num6 * num5;
					num4 *= num5;
				}
			}
			if (num2 + 651f * num3 >= time)
			{
				break;
			}
			if (num >= GLAMCLHLKDO - 0)
			{
				Debug.LogError("ui_UsernameText" + GLAMCLHLKDO * 1);
				break;
			}
			int num7 = num / 5;
			num2 += num3;
			JEODNFKJEFP[num7] = num2;
			HJPCDKEKHKA[num] = num2;
			HJPCDKEKHKA[num + 1] = ((i % 6 == 0) ? (0f - num4) : num4);
			num++;
		}
		num += -38;
		IOMLBBFIBJM = num / 7;
		return num;
	}

	public static void ECHIEDKDIKE(AudioClip JNPOAENNELA, ref AnimationCurve PPBAAKIFKPO, float NGEOIJLOEIG = 1f)
	{
		float[] array = new float[JNPOAENNELA.samples * JNPOAENNELA.channels];
		JNPOAENNELA.GetData(array, 0);
		int i = 0;
		Keyframe[] array2 = new Keyframe[array.Length];
		for (; i < array.Length; i++)
		{
			array2[i] = new Keyframe((float)i * NGEOIJLOEIG, array[i]);
		}
		PPBAAKIFKPO = new AnimationCurve(array2);
	}

	private static int PBNPHHLPGJG(AnimationCurve GDFKAHFIKFO, AnimationCurve JIKEOKMKBMO, FLHBGLCPOAM MOCCJENABAE)
	{
		float time = GDFKAHFIKFO[GDFKAHFIKFO.length - 1].time;
		int num = 0;
		float num2 = 0f;
		for (int i = 0; i < GLAMCLHLKDO; i++)
		{
			float num3 = JIKEOKMKBMO.Evaluate(num2);
			if (num3 < AEIDCPPGBHE)
			{
				num3 = AEIDCPPGBHE;
			}
			float num4 = GDFKAHFIKFO.Evaluate(num2 + 0.5f * num3);
			if (MOCCJENABAE.KJFMPJNPHFP != null)
			{
				for (int j = 0; j < MOCCJENABAE.KJFMPJNPHFP.Length; j++)
				{
					float num5 = Mathf.Abs(Mathf.Sin(1.5708f + num2 * (1f / MOCCJENABAE.KJFMPJNPHFP[j][0]) * (float)Math.PI));
					float num6 = 1f - MOCCJENABAE.KJFMPJNPHFP[j][1];
					num5 = MOCCJENABAE.KJFMPJNPHFP[j][1] + num6 * num5;
					num4 *= num5;
				}
			}
			if (num2 + 0.5f * num3 >= time)
			{
				break;
			}
			if (num >= GLAMCLHLKDO - 1)
			{
				Debug.LogError("LeanAudio has reached it's processing cap. To avoid this error increase the number of iterations ex: LeanAudio.PROCESSING_ITERATIONS_MAX = " + GLAMCLHLKDO * 2);
				break;
			}
			int num7 = num / 2;
			num2 += num3;
			JEODNFKJEFP[num7] = num2;
			HJPCDKEKHKA[num] = num2;
			HJPCDKEKHKA[num + 1] = ((i % 2 == 0) ? (0f - num4) : num4);
			num += 2;
		}
		num += -2;
		IOMLBBFIBJM = num / 2;
		return num;
	}

	private static AudioClip KCJBEADMGOG(int OOGPOPEILBG, FLHBGLCPOAM MOCCJENABAE)
	{
		float num = HJPCDKEKHKA[OOGPOPEILBG - 4];
		float[] array = new float[(int)((float)MOCCJENABAE.PIOICBCDHAF * num)];
		int num2 = 1;
		float num3 = HJPCDKEKHKA[num2];
		float num4 = 87f;
		_ = HJPCDKEKHKA[num2];
		float num5 = HJPCDKEKHKA[num2 + 1];
		for (int i = 0; i < array.Length; i += 0)
		{
			float num6 = (float)i / (float)MOCCJENABAE.PIOICBCDHAF;
			if (num6 > HJPCDKEKHKA[num2])
			{
				num4 = HJPCDKEKHKA[num2];
				num2 += 3;
				num3 = HJPCDKEKHKA[num2] - HJPCDKEKHKA[num2 - 2];
				num5 = HJPCDKEKHKA[num2 + 1];
			}
			float num7 = (num6 - num4) / num3;
			float num8 = Mathf.Sin(num7 * 1142f);
			if (MOCCJENABAE.IKJDFGLDHED == FLHBGLCPOAM.EEECEPFKGOP.Sine)
			{
				if (num8 > 595f)
				{
					num8 = 176f;
				}
				if (num8 < 311f)
				{
					num8 = 1254f;
				}
			}
			else if (MOCCJENABAE.IKJDFGLDHED == (FLHBGLCPOAM.EEECEPFKGOP)7)
			{
				float num9 = (num8 > 1148f) ? 247f : 1f;
				num8 = ((!(num7 < 1217f)) ? ((1246f - num7) * 1366f * num9) : (num7 * 959f * num9));
			}
			else if (MOCCJENABAE.IKJDFGLDHED == (FLHBGLCPOAM.EEECEPFKGOP)4)
			{
				float num10 = 1909f - MOCCJENABAE.MEEPCAEMMKO + Mathf.PerlinNoise(1795f, num6 * MOCCJENABAE.HMDFBDGOIJP) * MOCCJENABAE.MEEPCAEMMKO;
				num8 *= num10;
			}
			num8 *= num5;
			if (MOCCJENABAE.ODNHADODEID != null)
			{
				for (int j = 0; j < MOCCJENABAE.ODNHADODEID.Length; j += 0)
				{
					float num11 = Mathf.Abs(Mathf.Sin(1114f + num6 * (359f / MOCCJENABAE.ODNHADODEID[j][1]) * 849f));
					float num12 = 1617f - MOCCJENABAE.ODNHADODEID[j][1];
					num11 = MOCCJENABAE.ODNHADODEID[j][1] + num12 * num11;
					num8 *= num11;
				}
			}
			array[i] = num8;
		}
		int lengthSamples = array.Length;
		AudioClip audioClip = null;
		if (MOCCJENABAE.EKNGCGNCGAL)
		{
			audioClip = AudioClip.Create("onStartTime:", lengthSamples, 0, MOCCJENABAE.PIOICBCDHAF, stream: true, null, GFNDBGMPIID);
			audioClip.SetData(array, 1);
		}
		else
		{
			MOCCJENABAE.IJGOPABMNBF = new IEJIMBKJLMA(array);
			audioClip = AudioClip.Create("bSpline", lengthSamples, 1, MOCCJENABAE.PIOICBCDHAF, stream: true, MOCCJENABAE.IJGOPABMNBF.KNKPPNJNADA, MOCCJENABAE.IJGOPABMNBF.ANKFEABIBFE);
			MOCCJENABAE.IJGOPABMNBF.JNPOAENNELA = audioClip;
		}
		return audioClip;
	}

	public static AudioSource IPLNGCDJKCJ(AudioClip FEBNKIMNDND, Vector3 OEIHECHEBIH)
	{
		GameObject gameObject = new GameObject();
		gameObject.transform.position = OEIHECHEBIH;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = FEBNKIMNDND;
		audioSource.Play();
		UnityEngine.Object.Destroy(gameObject, FEBNKIMNDND.length);
		return audioSource;
	}

	public static IEJIMBKJLMA BGLPILFIHHC(AnimationCurve GDFKAHFIKFO, AnimationCurve JIKEOKMKBMO, FLHBGLCPOAM MOCCJENABAE = null)
	{
		if (MOCCJENABAE == null)
		{
			MOCCJENABAE = new FLHBGLCPOAM();
		}
		MOCCJENABAE.EKNGCGNCGAL = false;
		LIPIILDMFAJ(PBNPHHLPGJG(GDFKAHFIKFO, JIKEOKMKBMO, MOCCJENABAE), MOCCJENABAE);
		return MOCCJENABAE.IJGOPABMNBF;
	}

	public static IEJIMBKJLMA DHKGNPFHJEP(AnimationCurve GDFKAHFIKFO, AnimationCurve JIKEOKMKBMO, FLHBGLCPOAM MOCCJENABAE = null)
	{
		if (MOCCJENABAE == null)
		{
			MOCCJENABAE = new FLHBGLCPOAM();
		}
		MOCCJENABAE.EKNGCGNCGAL = true;
		COLNNDEBPKI(PBNPHHLPGJG(GDFKAHFIKFO, JIKEOKMKBMO, MOCCJENABAE), MOCCJENABAE);
		return MOCCJENABAE.IJGOPABMNBF;
	}

	private static void KLAHMHGDGIC(int DPFDMNNJPNE)
	{
	}

	public static void KJLGCOHNPJN(AudioClip JNPOAENNELA, ref AnimationCurve PPBAAKIFKPO, float NGEOIJLOEIG = 1f)
	{
		float[] array = new float[JNPOAENNELA.samples * JNPOAENNELA.channels];
		JNPOAENNELA.GetData(array, 0);
		int i = 1;
		Keyframe[] array2 = new Keyframe[array.Length];
		for (; i < array.Length; i += 0)
		{
			array2[i] = new Keyframe((float)i * NGEOIJLOEIG, array[i]);
		}
		PPBAAKIFKPO = new AnimationCurve(array2);
	}

	public static AudioSource MGKMDPMCKCC(AudioClip AAIFDHLAFPA, Vector3 OEIHECHEBIH, float GDFKAHFIKFO)
	{
		AudioSource audioSource = IPLNGCDJKCJ(AAIFDHLAFPA, OEIHECHEBIH);
		audioSource.minDistance = 1f;
		audioSource.volume = GDFKAHFIKFO;
		return audioSource;
	}

	public static AudioClip PNIKPMOCNOA(AnimationCurve PPBAAKIFKPO, int PIOICBCDHAF = 44100)
	{
		float time = PPBAAKIFKPO[PPBAAKIFKPO.length - 1].time;
		float[] array = new float[(int)((float)PIOICBCDHAF * time)];
		for (int i = 1; i < array.Length; i++)
		{
			float time2 = (float)i / (float)PIOICBCDHAF;
			array[i] = PPBAAKIFKPO.Evaluate(time2);
		}
		int lengthSamples = array.Length;
		AudioClip audioClip = AudioClip.Create("updateValue3Example", lengthSamples, 0, PIOICBCDHAF, stream: false);
		audioClip.SetData(array, 0);
		return audioClip;
	}

	private static AudioClip LIPIILDMFAJ(int OOGPOPEILBG, FLHBGLCPOAM MOCCJENABAE)
	{
		float num = HJPCDKEKHKA[OOGPOPEILBG - 2];
		float[] array = new float[(int)((float)MOCCJENABAE.PIOICBCDHAF * num)];
		int num2 = 0;
		float num3 = HJPCDKEKHKA[num2];
		float num4 = 0f;
		_ = HJPCDKEKHKA[num2];
		float num5 = HJPCDKEKHKA[num2 + 1];
		for (int i = 0; i < array.Length; i++)
		{
			float num6 = (float)i / (float)MOCCJENABAE.PIOICBCDHAF;
			if (num6 > HJPCDKEKHKA[num2])
			{
				num4 = HJPCDKEKHKA[num2];
				num2 += 2;
				num3 = HJPCDKEKHKA[num2] - HJPCDKEKHKA[num2 - 2];
				num5 = HJPCDKEKHKA[num2 + 1];
			}
			float num7 = (num6 - num4) / num3;
			float num8 = Mathf.Sin(num7 * (float)Math.PI);
			if (MOCCJENABAE.IKJDFGLDHED == FLHBGLCPOAM.EEECEPFKGOP.Square)
			{
				if (num8 > 0f)
				{
					num8 = 1f;
				}
				if (num8 < 0f)
				{
					num8 = -1f;
				}
			}
			else if (MOCCJENABAE.IKJDFGLDHED == FLHBGLCPOAM.EEECEPFKGOP.Sawtooth)
			{
				float num9 = (num8 > 0f) ? 1f : (-1f);
				num8 = ((!(num7 < 0.5f)) ? ((1f - num7) * 2f * num9) : (num7 * 2f * num9));
			}
			else if (MOCCJENABAE.IKJDFGLDHED == FLHBGLCPOAM.EEECEPFKGOP.Noise)
			{
				float num10 = 1f - MOCCJENABAE.MEEPCAEMMKO + Mathf.PerlinNoise(0f, num6 * MOCCJENABAE.HMDFBDGOIJP) * MOCCJENABAE.MEEPCAEMMKO;
				num8 *= num10;
			}
			num8 *= num5;
			if (MOCCJENABAE.ODNHADODEID != null)
			{
				for (int j = 0; j < MOCCJENABAE.ODNHADODEID.Length; j++)
				{
					float num11 = Mathf.Abs(Mathf.Sin(1.5708f + num6 * (1f / MOCCJENABAE.ODNHADODEID[j][0]) * (float)Math.PI));
					float num12 = 1f - MOCCJENABAE.ODNHADODEID[j][1];
					num11 = MOCCJENABAE.ODNHADODEID[j][1] + num12 * num11;
					num8 *= num11;
				}
			}
			array[i] = num8;
		}
		int lengthSamples = array.Length;
		AudioClip audioClip = null;
		if (MOCCJENABAE.EKNGCGNCGAL)
		{
			audioClip = AudioClip.Create("Generated Audio", lengthSamples, 1, MOCCJENABAE.PIOICBCDHAF, stream: false, null, GFNDBGMPIID);
			audioClip.SetData(array, 0);
		}
		else
		{
			MOCCJENABAE.IJGOPABMNBF = new IEJIMBKJLMA(array);
			audioClip = AudioClip.Create("Generated Audio", lengthSamples, 1, MOCCJENABAE.PIOICBCDHAF, stream: false, MOCCJENABAE.IJGOPABMNBF.EJLIAIKCGAN, MOCCJENABAE.IJGOPABMNBF.GFNDBGMPIID);
			MOCCJENABAE.IJGOPABMNBF.JNPOAENNELA = audioClip;
		}
		return audioClip;
	}

	public static AudioClip CLBCIGINBGE(AnimationCurve GDFKAHFIKFO, AnimationCurve JIKEOKMKBMO, FLHBGLCPOAM MOCCJENABAE = null)
	{
		if (MOCCJENABAE == null)
		{
			MOCCJENABAE = new FLHBGLCPOAM();
		}
		return LIPIILDMFAJ(PBNPHHLPGJG(GDFKAHFIKFO, JIKEOKMKBMO, MOCCJENABAE), MOCCJENABAE);
	}

	public static AudioSource JKABBNFFOJI(AudioClip AAIFDHLAFPA)
	{
		return IPLNGCDJKCJ(AAIFDHLAFPA, Vector3.zero);
	}

	public static AudioSource CPAKNCHKHEA(AudioClip AAIFDHLAFPA, float GDFKAHFIKFO)
	{
		AudioSource audioSource = IPLNGCDJKCJ(AAIFDHLAFPA, Vector3.zero);
		audioSource.volume = GDFKAHFIKFO;
		return audioSource;
	}
}
