// ExtinguishableFire
using System.Collections;
using UnityEngine;

public class ExtinguishableFire : MonoBehaviour
{
	public ParticleSystem fireParticleSystem;

	public ParticleSystem smokeParticleSystem;

	protected bool DNCLPJHGBAA;

	private const float NOGGGFJIKPG = 2f;

	public void FDKOOFADNBB()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(GFMGKNEBJJE());
		}
	}

	private IEnumerator FIPIKGFJHMA()
	{
		fireParticleSystem.Stop();
		smokeParticleSystem.time = 0f;
		smokeParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Max(0f, 1f - num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		yield return new WaitForSeconds(2f);
		smokeParticleSystem.Stop();
		fireParticleSystem.transform.localScale = Vector3.one;
		yield return new WaitForSeconds(4f);
		StartCoroutine(LAANBIPLJNJ());
	}

	private void AFJDIBFOBPH()
	{
		DNCLPJHGBAA = false;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(HFIFGCOGPKF());
	}

	private IEnumerator HHJLCHCPNDP()
	{
		return new BBPLACBOCBN(1)
		{
			OINCCKIFOLH = this
		};
	}

	private IEnumerator DJGOFFFJNNH()
	{
		return new GMNIKPPDHOF(1)
		{
			OINCCKIFOLH = this
		};
	}

	private IEnumerator KNNNOKEEDND()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	private IEnumerator MDIFIOMPKAA()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	private void JBFLACPKBCB()
	{
		DNCLPJHGBAA = true;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(HEGNJPCLIDP());
	}

	private IEnumerator GFMGKNEBJJE()
	{
		return new GMNIKPPDHOF(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void AODKAAOMHCM()
	{
		DNCLPJHGBAA = true;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(MDIFIOMPKAA());
	}

	private IEnumerator NMABBCAJOAA()
	{
		fireParticleSystem.Stop();
		smokeParticleSystem.time = 0f;
		smokeParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Max(0f, 1f - num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		yield return new WaitForSeconds(2f);
		smokeParticleSystem.Stop();
		fireParticleSystem.transform.localScale = Vector3.one;
		yield return new WaitForSeconds(4f);
		StartCoroutine(LAANBIPLJNJ());
	}

	public void OKBGDGEEGEH()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = true;
			StartCoroutine(GALLIHCBDBN());
		}
	}

	private void JEDBEELLACK()
	{
		DNCLPJHGBAA = false;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(LAANBIPLJNJ());
	}

	public void EOCHABCNJOL()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(DGJEKBCBFOC());
		}
	}

	private IEnumerator CPBHINDLHMG()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	private IEnumerator BNAGNHFEEAF()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	private IEnumerator PADNGKLLCKK()
	{
		return new GMNIKPPDHOF(1)
		{
			OINCCKIFOLH = this
		};
	}

	private void PELEFHJHKBI()
	{
		DNCLPJHGBAA = false;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(MDIFIOMPKAA());
	}

	private IEnumerator POHOFENNNCA()
	{
		return new GMNIKPPDHOF(1)
		{
			OINCCKIFOLH = this
		};
	}

	private IEnumerator MLGBMJEBPAL()
	{
		return new BBPLACBOCBN(1)
		{
			OINCCKIFOLH = this
		};
	}

	public void LKAIPPKNABD()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(GCDFOLDGJLJ());
		}
	}

	public void PFHKAPEDCNB()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(GALLIHCBDBN());
		}
	}

	private IEnumerator OBBDKKHHNKJ()
	{
		fireParticleSystem.Stop();
		smokeParticleSystem.time = 0f;
		smokeParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Max(0f, 1f - num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		yield return new WaitForSeconds(2f);
		smokeParticleSystem.Stop();
		fireParticleSystem.transform.localScale = Vector3.one;
		yield return new WaitForSeconds(4f);
		StartCoroutine(LAANBIPLJNJ());
	}

	public void JJKJGFKICFC()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = true;
			StartCoroutine(PADNGKLLCKK());
		}
	}

	private void Start()
	{
		DNCLPJHGBAA = true;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(LAANBIPLJNJ());
	}

	private void AFJCIJEKLEA()
	{
		DNCLPJHGBAA = true;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(HIMDCAPINCH());
	}

	public void HNHEGLHACNN()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(GFMGKNEBJJE());
		}
	}

	private void ILMPCBPAHLK()
	{
		DNCLPJHGBAA = true;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(MLGBMJEBPAL());
	}

	public void BCMGPMOGOGD()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(NMABBCAJOAA());
		}
	}

	private IEnumerator MAFDODDANKL()
	{
		fireParticleSystem.Stop();
		smokeParticleSystem.time = 0f;
		smokeParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Max(0f, 1f - num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		yield return new WaitForSeconds(2f);
		smokeParticleSystem.Stop();
		fireParticleSystem.transform.localScale = Vector3.one;
		yield return new WaitForSeconds(4f);
		StartCoroutine(LAANBIPLJNJ());
	}

	private IEnumerator CLNLMEKEDFP()
	{
		fireParticleSystem.Stop();
		smokeParticleSystem.time = 0f;
		smokeParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Max(0f, 1f - num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		yield return new WaitForSeconds(2f);
		smokeParticleSystem.Stop();
		fireParticleSystem.transform.localScale = Vector3.one;
		yield return new WaitForSeconds(4f);
		StartCoroutine(LAANBIPLJNJ());
	}

	private IEnumerator DGJEKBCBFOC()
	{
		fireParticleSystem.Stop();
		smokeParticleSystem.time = 0f;
		smokeParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Max(0f, 1f - num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		yield return new WaitForSeconds(2f);
		smokeParticleSystem.Stop();
		fireParticleSystem.transform.localScale = Vector3.one;
		yield return new WaitForSeconds(4f);
		StartCoroutine(LAANBIPLJNJ());
	}

	public void EJMIDPBAJGH()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = true;
			StartCoroutine(FIPIKGFJHMA());
		}
	}

	private void PJMPJPGAEKL()
	{
		DNCLPJHGBAA = true;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(IIJFMAHKHGA());
	}

	private IEnumerator MCCDAOGFAAK()
	{
		fireParticleSystem.Stop();
		smokeParticleSystem.time = 0f;
		smokeParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Max(0f, 1f - num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		yield return new WaitForSeconds(2f);
		smokeParticleSystem.Stop();
		fireParticleSystem.transform.localScale = Vector3.one;
		yield return new WaitForSeconds(4f);
		StartCoroutine(LAANBIPLJNJ());
	}

	private IEnumerator BBGKJCBBBGJ()
	{
		return new BBPLACBOCBN(1)
		{
			OINCCKIFOLH = this
		};
	}

	private IEnumerator LAANBIPLJNJ()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	private IEnumerator GCDFOLDGJLJ()
	{
		return new GMNIKPPDHOF(1)
		{
			OINCCKIFOLH = this
		};
	}

	public void PAIJICPIGGD()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(POHOFENNNCA());
		}
	}

	private IEnumerator BGLDCKHFMDM()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	private void GDAAILEMIFM()
	{
		DNCLPJHGBAA = true;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(JFOEGIJCAIG());
	}

	private IEnumerator OKENINIJDFC()
	{
		return new BBPLACBOCBN(1)
		{
			OINCCKIFOLH = this
		};
	}

	public void GEBCJFKPPEP()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = true;
			StartCoroutine(CICJCMBIKMN());
		}
	}

	private IEnumerator FJOLDDHCPPN()
	{
		return new GMNIKPPDHOF(1)
		{
			OINCCKIFOLH = this
		};
	}

	private IEnumerator JFOEGIJCAIG()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	private IEnumerator CICJCMBIKMN()
	{
		fireParticleSystem.Stop();
		smokeParticleSystem.time = 0f;
		smokeParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Max(0f, 1f - num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		yield return new WaitForSeconds(2f);
		smokeParticleSystem.Stop();
		fireParticleSystem.transform.localScale = Vector3.one;
		yield return new WaitForSeconds(4f);
		StartCoroutine(LAANBIPLJNJ());
	}

	private IEnumerator JKOKBMOPHKD()
	{
		fireParticleSystem.Stop();
		smokeParticleSystem.time = 0f;
		smokeParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Max(0f, 1f - num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		yield return new WaitForSeconds(2f);
		smokeParticleSystem.Stop();
		fireParticleSystem.transform.localScale = Vector3.one;
		yield return new WaitForSeconds(4f);
		StartCoroutine(LAANBIPLJNJ());
	}

	private IEnumerator HEGNJPCLIDP()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	public void DDBGBDLLDAK()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = true;
			StartCoroutine(LAODKHEBMDO());
		}
	}

	private IEnumerator LDKMPCOICME()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	public void CBKEGCKEGFD()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(CICJCMBIKMN());
		}
	}

	public void KEAOKCBBIPI()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = true;
			StartCoroutine(DJGOFFFJNNH());
		}
	}

	private void KOMDNPOBLHC()
	{
		DNCLPJHGBAA = false;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(HFIFGCOGPKF());
	}

	public void DGBHANLKKDM()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = true;
			StartCoroutine(LAODKHEBMDO());
		}
	}

	private IEnumerator HFIFGCOGPKF()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	private IEnumerator OFHNEFHBPOP()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	private void IPOMCIBLHDL()
	{
		DNCLPJHGBAA = true;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(LAANBIPLJNJ());
	}

	private IEnumerator LAODKHEBMDO()
	{
		return new GMNIKPPDHOF(1)
		{
			OINCCKIFOLH = this
		};
	}

	public void HMIEFKICKPE()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(FIPIKGFJHMA());
		}
	}

	private void LHKKHKIACBO()
	{
		DNCLPJHGBAA = false;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(LAANBIPLJNJ());
	}

	private void KDIKENLODJA()
	{
		DNCLPJHGBAA = false;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(BBGKJCBBBGJ());
	}

	private IEnumerator HIMDCAPINCH()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	public void OJPPOIJNFGN()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(LAODKHEBMDO());
		}
	}

	public void OFGINCCKEBO()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(GFMGKNEBJJE());
		}
	}

	private IEnumerator IIJFMAHKHGA()
	{
		return new BBPLACBOCBN(1)
		{
			OINCCKIFOLH = this
		};
	}

	private IEnumerator CAHNIHFPEKC()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	private void MJBAPNCKMKM()
	{
		DNCLPJHGBAA = false;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(JFOEGIJCAIG());
	}

	private IEnumerator NNKGPAFHJMO()
	{
		fireParticleSystem.Stop();
		smokeParticleSystem.time = 0f;
		smokeParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Max(0f, 1f - num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		yield return new WaitForSeconds(2f);
		smokeParticleSystem.Stop();
		fireParticleSystem.transform.localScale = Vector3.one;
		yield return new WaitForSeconds(4f);
		StartCoroutine(LAANBIPLJNJ());
	}

	public void MFBOJHGMPGE()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(IMBAINKOKKL());
		}
	}

	private void KEAHMICOMEJ()
	{
		DNCLPJHGBAA = true;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(HIMDCAPINCH());
	}

	private void AFCELIGJJDC()
	{
		DNCLPJHGBAA = false;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(CPBHINDLHMG());
	}

	public void Extinguish()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = true;
			StartCoroutine(FIPIKGFJHMA());
		}
	}

	private IEnumerator IMBAINKOKKL()
	{
		return new GMNIKPPDHOF(1)
		{
			OINCCKIFOLH = this
		};
	}

	public void NOMKABOJKFL()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(CICJCMBIKMN());
		}
	}

	private IEnumerator GELFDJMFLAE()
	{
		return new BBPLACBOCBN(1)
		{
			OINCCKIFOLH = this
		};
	}

	public void NAIEGKDMAKH()
	{
		if (!DNCLPJHGBAA)
		{
			DNCLPJHGBAA = false;
			StartCoroutine(DJGOFFFJNNH());
		}
	}

	private void KFFNHFEKOJH()
	{
		DNCLPJHGBAA = false;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(HFIFGCOGPKF());
	}

	private void IOJCPGBLDNK()
	{
		DNCLPJHGBAA = true;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(BGLDCKHFMDM());
	}

	private void NKHNFBMBCPP()
	{
		DNCLPJHGBAA = true;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(BGLDCKHFMDM());
	}

	private IEnumerator AOKJFOHGEAK()
	{
		return new GMNIKPPDHOF(1)
		{
			OINCCKIFOLH = this
		};
	}

	private IEnumerator GALLIHCBDBN()
	{
		return new GMNIKPPDHOF(1)
		{
			OINCCKIFOLH = this
		};
	}

	private IEnumerator JIFJEFMCCEB()
	{
		smokeParticleSystem.Stop();
		fireParticleSystem.time = 0f;
		fireParticleSystem.Play();
		for (float num = 0f; num < 2f; num += Time.deltaTime)
		{
			float d = Mathf.Min(1f, num / 2f);
			fireParticleSystem.transform.localScale = Vector3.one * d;
			yield return null;
		}
		fireParticleSystem.transform.localScale = Vector3.one;
		DNCLPJHGBAA = false;
	}

	private void HEPAMDACOJD()
	{
		DNCLPJHGBAA = false;
		smokeParticleSystem.Stop();
		fireParticleSystem.Stop();
		StartCoroutine(BNAGNHFEEAF());
	}

	private IEnumerator IPEJFAPPOCD()
	{
		return new BBPLACBOCBN(1)
		{
			OINCCKIFOLH = this
		};
	}
}
