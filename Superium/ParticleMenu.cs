// ParticleMenu
using UnityEngine;
using UnityEngine.UI;

public class ParticleMenu : MonoBehaviour
{
	public ParticleExamples[] particleSystems;

	public GameObject gunGameObject;

	private int GBOPLGEHMLD;

	private GameObject FBJKLDMCDNP;

	public Transform spawnLocation;

	public Text title;

	public Text description;

	public Text navigationDetails;

	private void JBFLACPKBCB()
	{
		BKJJOLBIMJH(0);
		GBOPLGEHMLD = 1;
	}

	public void AFCAMMKLDHB(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "rotateAroundExample" + particleSystems.Length.ToString();
	}

	public void PHNEFLABGNP(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "Line" + particleSystems.Length.ToString();
	}

	private void HAIMMOBDCGM()
	{
		KHODBHDCCEJ(1);
		GBOPLGEHMLD = 0;
	}

	public void JPHAIKPEFOH(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "Cube1" + particleSystems.Length.ToString();
	}

	public void GPFINCANNJO(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "GameAuthorText" + particleSystems.Length.ToString();
	}

	public void HMBJFIHGIDD(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "yo" + particleSystems.Length.ToString();
	}

	public void Navigate(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + " out of " + particleSystems.Length.ToString();
	}

	public void NLABCOLDIGI(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "rotateExample" + particleSystems.Length.ToString();
	}

	private void CDJBDJKCMLJ()
	{
		DEBIAMEDNKJ(1);
		GBOPLGEHMLD = 1;
	}

	public void FCFBEHCCIBF(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "GROUP POSITION FINISH" + particleSystems.Length.ToString();
	}

	private void LBMJJECMEDO()
	{
		HMBJFIHGIDD(0);
		GBOPLGEHMLD = 1;
	}

	private void KFFNHFEKOJH()
	{
		FMPGAGBPPLC(0);
		GBOPLGEHMLD = 0;
	}

	public void KDGPPHDMDCM(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "exported curve:" + particleSystems.Length.ToString();
	}

	private void MJBAPNCKMKM()
	{
		GPFINCANNJO(0);
		GBOPLGEHMLD = 0;
	}

	private void HJKKAFDGMCN()
	{
		PCNCFNJAONK(1);
		GBOPLGEHMLD = 0;
	}

	public void GFPOEKIJJFK(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "face" + particleSystems.Length.ToString();
	}

	private void AJKHKJOIAOO()
	{
		JNFJMBKKLJG(1);
		GBOPLGEHMLD = 1;
	}

	public void CPBHLONGNNO(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "MOVE Y" + particleSystems.Length.ToString();
	}

	public void BBBAOPJEKPJ(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "DirectionalLight" + particleSystems.Length.ToString();
	}

	public void BKJJOLBIMJH(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "Playing as Player" + particleSystems.Length.ToString();
	}

	private void ANDHKLACMNI()
	{
		PHPIBLHBKLH(0);
		GBOPLGEHMLD = 0;
	}

	private void FLGMDCCIJKJ()
	{
		JNFJMBKKLJG(1);
		GBOPLGEHMLD = 0;
	}

	public void IABBKIBJCCN(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "creator" + particleSystems.Length.ToString();
	}

	public void PPJEMGKHDKA(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "AnimationCurve" + particleSystems.Length.ToString();
	}

	public void PHPIBLHBKLH(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + " ay:" + particleSystems.Length.ToString();
	}

	private void FFONODKBHGM()
	{
		PPJEMGKHDKA(1);
		GBOPLGEHMLD = 1;
	}

	private void KOEJHABBJMJ()
	{
		NLABCOLDIGI(0);
		GBOPLGEHMLD = 0;
	}

	private void GDAAILEMIFM()
	{
		FMPGAGBPPLC(1);
		GBOPLGEHMLD = 0;
	}

	private void LNDNCLLAANE()
	{
		FLEBNDJPAOD(1);
		GBOPLGEHMLD = 0;
	}

	private void DHEMIFCONIB()
	{
		JLLHJMKOCJB(1);
		GBOPLGEHMLD = 1;
	}

	private void EBMLEALCJEB()
	{
		DEBIAMEDNKJ(1);
		GBOPLGEHMLD = 0;
	}

	private void IOJCPGBLDNK()
	{
		LIPJHMGHAHG(0);
		GBOPLGEHMLD = 0;
	}

	private void EGNHAAJONDF()
	{
		IPMLGJKINKD(0);
		GBOPLGEHMLD = 0;
	}

	public void EFGNOGLFCAB(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "plr_container" + particleSystems.Length.ToString();
	}

	public void FLEBNDJPAOD(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "ScriptService" + particleSystems.Length.ToString();
	}

	private void DHDIFNJEMGK()
	{
		FMPGAGBPPLC(1);
		GBOPLGEHMLD = 0;
	}

	public void FMPGAGBPPLC(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "Wearables" + particleSystems.Length.ToString();
	}

	public void AHPMPMOPKDF(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + ">" + particleSystems.Length.ToString();
	}

	public void AKGCGEELGMD(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "PlaceID" + particleSystems.Length.ToString();
	}

	public void AAMIONKAMAA(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "cube" + particleSystems.Length.ToString();
	}

	private void PJMPJPGAEKL()
	{
		IPMLGJKINKD(1);
		GBOPLGEHMLD = 0;
	}

	public void PCNCFNJAONK(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + " toggle:" + particleSystems.Length.ToString();
	}

	private void IOELMLDLHIO()
	{
		EFGNOGLFCAB(0);
		GBOPLGEHMLD = 0;
	}

	private void AFCELIGJJDC()
	{
		FLEBNDJPAOD(1);
		GBOPLGEHMLD = 1;
	}

	public void DKFJFHNLGOK(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + " but got " + particleSystems.Length.ToString();
	}

	private void GONFCNKPFDO()
	{
		AFCAMMKLDHB(1);
		GBOPLGEHMLD = 0;
	}

	private void OJNBDNKOJOM()
	{
		DKFJFHNLGOK(0);
		GBOPLGEHMLD = 0;
	}

	private void BDMGKLPALJN()
	{
		GMJDAIAFIBF(0);
		GBOPLGEHMLD = 1;
	}

	private void JCALDGKFAPL()
	{
		NMENJJMMBBM(0);
		GBOPLGEHMLD = 1;
	}

	private void BHMGFDOOAEC()
	{
		LIPJHMGHAHG(1);
		GBOPLGEHMLD = 1;
	}

	private void FGFLCFGDHNC()
	{
		BBBAOPJEKPJ(0);
		GBOPLGEHMLD = 1;
	}

	public void IMCNGDMEFMF(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "CANCEL TWEEN LTDESCR" + particleSystems.Length.ToString();
	}

	private void GAJDENHGMCC()
	{
		CAJMLEACJNP(0);
		GBOPLGEHMLD = 0;
	}

	private void Start()
	{
		Navigate(0);
		GBOPLGEHMLD = 0;
	}

	public void FBOPCKOMIJL(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + " but should be:(10f,0f,0f)" + particleSystems.Length.ToString();
	}

	public void KHODBHDCCEJ(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "LCharacter" + particleSystems.Length.ToString();
	}

	public void JNFJMBKKLJG(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "mp_auth" + particleSystems.Length.ToString();
	}

	private void LHKKHKIACBO()
	{
		CAJMLEACJNP(1);
		GBOPLGEHMLD = 1;
	}

	public void GCCAPFPBDAH(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "new Keyframe(" + particleSystems.Length.ToString();
	}

	public void EKLGIGPGHKM(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "ChatInput" + particleSystems.Length.ToString();
	}

	private void AJLGLIJDIAK()
	{
		Navigate(1);
		GBOPLGEHMLD = 1;
	}

	private void KAIGJOMDJAN()
	{
		LIPJHMGHAHG(1);
		GBOPLGEHMLD = 0;
	}

	public void GMJDAIAFIBF(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "logo" + particleSystems.Length.ToString();
	}

	private void AKKCHJICOHD()
	{
		GCCAPFPBDAH(0);
		GBOPLGEHMLD = 1;
	}

	public void OOIKOOLHOIJ(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "none" + particleSystems.Length.ToString();
	}

	private void LHJAILEKNKI()
	{
		GCCAPFPBDAH(0);
		GBOPLGEHMLD = 1;
	}

	public void NMENJJMMBBM(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "LCharacter" + particleSystems.Length.ToString();
	}

	private void KDKGJPEEIAD()
	{
		Navigate(1);
		GBOPLGEHMLD = 0;
	}

	private void JBKNIODHJFP()
	{
		PFBIBPANGNB(0);
		GBOPLGEHMLD = 1;
	}

	public void LIPJHMGHAHG(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "_TintColor" + particleSystems.Length.ToString();
	}

	public void PFBIBPANGNB(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "ROTATE AROUND 360" + particleSystems.Length.ToString();
	}

	public void MCKELHFIEJM(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "Playing " + particleSystems.Length.ToString();
	}

	public void DEBIAMEDNKJ(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "onStartTime:" + particleSystems.Length.ToString();
	}

	public void CAJMLEACJNP(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "By <b>" + particleSystems.Length.ToString();
	}

	private void DBHAOAFNKEB()
	{
		CAJMLEACJNP(1);
		GBOPLGEHMLD = 0;
	}

	private void KEAHMICOMEJ()
	{
		BBBAOPJEKPJ(1);
		GBOPLGEHMLD = 0;
	}

	public void MIHEIOHMAPP(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "cubeScale" + particleSystems.Length.ToString();
	}

	private void FGIPNFFOHFN()
	{
		CPBHLONGNNO(1);
		GBOPLGEHMLD = 1;
	}

	public void LCDLDPAGOGI(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + "cubeToTrans" + particleSystems.Length.ToString();
	}

	private void PGEDHLOFFMI()
	{
		HMBJFIHGIDD(1);
		GBOPLGEHMLD = 0;
	}

	private void PAFEGKADFKI()
	{
		MCKELHFIEJM(1);
		GBOPLGEHMLD = 1;
	}

	private void JNFPBGBDKLK()
	{
		IPMLGJKINKD(0);
		GBOPLGEHMLD = 0;
	}

	public void JLLHJMKOCJB(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + "delayedCallExample" + particleSystems.Length.ToString();
	}

	private void DHBAIDGHNCG()
	{
		EFGNOGLFCAB(1);
		GBOPLGEHMLD = 0;
	}

	private void HEPACNIHKPP()
	{
		FCFBEHCCIBF(1);
		GBOPLGEHMLD = 1;
	}

	private void EODENBEOJID()
	{
		DEBIAMEDNKJ(0);
		GBOPLGEHMLD = 1;
	}

	private void ICMGJJHGNDP()
	{
		PHPIBLHBKLH(1);
		GBOPLGEHMLD = 0;
	}

	private void KPEJAJKLCBH()
	{
		MCKELHFIEJM(0);
		GBOPLGEHMLD = 0;
	}

	public void HBJJDOPFLGH(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 0 + " returned:" + particleSystems.Length.ToString();
	}

	public void IPMLGJKINKD(int IIFOOLDKBEH)
	{
		GBOPLGEHMLD = (particleSystems.Length + GBOPLGEHMLD + IIFOOLDKBEH) % particleSystems.Length;
		if (FBJKLDMCDNP != null)
		{
			Object.Destroy(FBJKLDMCDNP);
		}
		FBJKLDMCDNP = Object.Instantiate(particleSystems[GBOPLGEHMLD].particleSystemGO, spawnLocation.position + particleSystems[GBOPLGEHMLD].particlePosition, Quaternion.Euler(particleSystems[GBOPLGEHMLD].particleRotation));
		gunGameObject.SetActive(particleSystems[GBOPLGEHMLD].isWeaponEffect);
		title.text = particleSystems[GBOPLGEHMLD].title;
		description.text = particleSystems[GBOPLGEHMLD].description;
		navigationDetails.text = GBOPLGEHMLD + 1 + " to:" + particleSystems.Length.ToString();
	}
}
