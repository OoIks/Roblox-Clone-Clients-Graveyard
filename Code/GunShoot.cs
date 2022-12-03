// GunShoot
using UnityEngine;

public class GunShoot : MonoBehaviour
{
	public float fireRate = 0.25f;

	public float weaponRange = 20f;

	public Transform gunEnd;

	public ParticleSystem muzzleFlash;

	public ParticleSystem cartridgeEjection;

	public GameObject metalHitEffect;

	public GameObject sandHitEffect;

	public GameObject stoneHitEffect;

	public GameObject waterLeakEffect;

	public GameObject waterLeakExtinguishEffect;

	public GameObject[] fleshHitEffects;

	public GameObject woodHitEffect;

	private float BMIAAAJPDLO;

	private Animator INIPPOFFMDK;

	private GunAim JJCBIKBDBFO;

	private void CGLIFNLFLAC(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		if (num <= 4294967131u)
		{
			if (num <= 4294967211u)
			{
				switch (num)
				{
				case 4294967220u:
					if (name == "   ")
					{
						JCDFNPFPDOO(IDIHIBBFELK, woodHitEffect);
					}
					break;
				case 4294967248u:
					if (name == "PlaceID")
					{
						PNEMNPNEJFL(IDIHIBBFELK, waterLeakExtinguishEffect);
						LPJNDFBNPKA(IDIHIBBFELK, metalHitEffect);
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 4294967114u:
				if (name == "Leaderboard")
				{
					CIGFIBMMBAH(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 4294967239u:
				if (name == "LeanAudio has reached it's processing cap. To avoid this error increase the number of iterations ex: LeanAudio.PROCESSING_ITERATIONS_MAX = ")
				{
					BBCFOEECNPB(IDIHIBBFELK, waterLeakEffect);
					CIGFIBMMBAH(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			return;
		}
		if (num <= 4294967192u)
		{
			switch (num)
			{
			case 4294967273u:
				if (name == "I")
				{
					JCDFNPFPDOO(IDIHIBBFELK, metalHitEffect);
				}
				break;
			case 4294967287u:
				if (name == "Loading...")
				{
					JCDFNPFPDOO(IDIHIBBFELK, stoneHitEffect);
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967253u:
			if (name == "EaseInOutElastic")
			{
				PNEMNPNEJFL(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		case 133u:
			if (name == "<b>")
			{
				LPJNDFBNPKA(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		}
	}

	private void OPMEGCJJNLC()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void FGFLCFGDHNC()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void MIDFABMDPPM(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
		case 25u:
		case 26u:
		case 27u:
		case 28u:
		case 29u:
		case 30u:
		case 31u:
		case 32u:
		case 33u:
		case 34u:
		case 35u:
		case 36u:
		case 37u:
		case 38u:
		case 39u:
		case 40u:
		case 41u:
		case 42u:
		case 43u:
		case 44u:
		case 45u:
		case 46u:
		case 47u:
		case 48u:
		case 49u:
		case 50u:
			switch (num)
			{
			case 0u:
			case 1u:
			case 2u:
			case 3u:
			case 4u:
			case 5u:
			case 6u:
			case 7u:
			case 8u:
			case 9u:
			case 10u:
			case 11u:
			case 12u:
			case 13u:
			case 14u:
			case 15u:
			case 16u:
			case 17u:
			case 18u:
			case 19u:
			case 20u:
			case 21u:
			case 22u:
			case 23u:
			case 24u:
			case 25u:
			case 26u:
			case 27u:
			case 28u:
			case 29u:
			case 30u:
			case 31u:
			case 32u:
			case 33u:
			case 34u:
			case 35u:
			case 36u:
			case 37u:
			case 38u:
			case 39u:
			case 40u:
			case 41u:
			case 42u:
			case 43u:
			case 44u:
			case 45u:
			case 46u:
			case 47u:
			case 48u:
			case 49u:
			case 50u:
			case 51u:
			case 52u:
			case 53u:
			case 54u:
			case 55u:
			case 56u:
			case 57u:
			case 58u:
			case 59u:
			case 60u:
			case 61u:
			case 62u:
			case 63u:
			case 64u:
			case 65u:
			case 66u:
			case 67u:
			case 68u:
			case 69u:
			case 70u:
			case 71u:
			case 72u:
			case 73u:
			case 74u:
			case 75u:
				switch (num)
				{
				case 143u:
					if (name == "mp_auth")
					{
						GKILLOBGKJG(IDIHIBBFELK, woodHitEffect);
					}
					break;
				case 4294967115u:
					if (name == "cubeDest")
					{
						CIGFIBMMBAH(IDIHIBBFELK, waterLeakExtinguishEffect);
						LPJNDFBNPKA(IDIHIBBFELK, metalHitEffect);
					}
					break;
				}
				break;
			case 4294967245u:
				if (name == "Lighting")
				{
					JCDFNPFPDOO(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 4294967114u:
				if (name == "LCharacter")
				{
					PNEMNPNEJFL(IDIHIBBFELK, waterLeakEffect);
					PNEMNPNEJFL(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			break;
		case 51u:
		case 52u:
		case 53u:
		case 54u:
		case 55u:
		case 56u:
		case 57u:
		case 58u:
		case 59u:
		case 60u:
		case 61u:
		case 62u:
		case 63u:
		case 64u:
		case 65u:
		case 66u:
		case 67u:
		case 68u:
		case 69u:
		case 70u:
		case 71u:
		case 72u:
		case 73u:
		case 74u:
		case 75u:
		case 76u:
		case 77u:
		case 78u:
		case 79u:
		case 80u:
		case 81u:
		case 82u:
		case 83u:
		case 84u:
		case 85u:
		case 86u:
		case 87u:
		case 88u:
		case 89u:
		case 90u:
		case 91u:
		case 92u:
		case 93u:
		case 94u:
		case 95u:
		case 96u:
		case 97u:
		case 98u:
		case 99u:
		case 100u:
		case 101u:
		case 102u:
		case 103u:
		case 104u:
		case 105u:
		case 106u:
		case 107u:
		case 108u:
		case 109u:
		case 110u:
		case 111u:
		case 112u:
		case 113u:
		case 114u:
		case 115u:
		case 116u:
		case 117u:
		case 118u:
		case 119u:
		case 120u:
		case 121u:
		case 122u:
		case 123u:
		case 124u:
		case 125u:
		case 126u:
		case 127u:
		case 128u:
		case 129u:
		case 130u:
		case 131u:
		case 132u:
		case 133u:
		case 134u:
		case 135u:
		case 136u:
		case 137u:
		case 138u:
		case 139u:
		case 140u:
		case 141u:
			switch (num)
			{
			case 4294967275u:
				if (name == "")
				{
					BBCFOEECNPB(IDIHIBBFELK, metalHitEffect);
				}
				break;
			case 144u:
				if (name == ".png")
				{
					GFMEMPDDNAC(IDIHIBBFELK, stoneHitEffect);
				}
				break;
			}
			break;
		default:
			if (num == 114 && name == "_TintColor")
			{
				CIGFIBMMBAH(IDIHIBBFELK, fleshHitEffects[Random.Range(0, fleshHitEffects.Length)]);
			}
			break;
		case 4294967167u:
			if (name == "LeanTweenLogo")
			{
				CIGFIBMMBAH(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		}
	}

	private void KMFPKKKCEJO()
	{
		if (Input.GetButtonDown("LeanTweenLogo2") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.LOJEEPHEILM())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("BodyColors");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				NNIHOECDDCL(hitInfo);
			}
		}
	}

	private void Start()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void KOEJHABBJMJ()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void PELEFHJHKBI()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void LJOMIIDBGFG(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		if (num <= 4294967105u)
		{
			if (num <= 39)
			{
				switch (num)
				{
				case 84u:
					if (name == "cubeToTrans")
					{
						PLDLBPJDHLI(IDIHIBBFELK, woodHitEffect);
					}
					break;
				case 139u:
					if (name == "torso")
					{
						EHFGBBKNKNG(IDIHIBBFELK, waterLeakExtinguishEffect);
						PEJKPIGIGPF(IDIHIBBFELK, metalHitEffect);
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 4294967104u:
				if (name == "onStartPos:")
				{
					CIGFIBMMBAH(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 3u:
				if (name == "CHANGING TIME DOESN'T JUMP AHEAD")
				{
					LPJNDFBNPKA(IDIHIBBFELK, waterLeakEffect);
					PNEMNPNEJFL(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			return;
		}
		if (num <= 4294967116u)
		{
			switch (num)
			{
			case 105u:
				if (name == "GROUP FINISH")
				{
					JCDFNPFPDOO(IDIHIBBFELK, metalHitEffect);
				}
				break;
			case 4294967187u:
				if (name == "GameController")
				{
					NIKCEBMCDJB(IDIHIBBFELK, stoneHitEffect);
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967144u:
			if (name == "Wearables")
			{
				CIGFIBMMBAH(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		case 72u:
			if (name == "\r\n        return function()\r\n            ")
			{
				JCDFNPFPDOO(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		}
	}

	private void DPKDAPGGBBH()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void BGHIFCGKDPE()
	{
		if (Input.GetButtonDown("Launch token: ") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.BLEGILPPPLJ())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("delayedCallExample");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				FDJOMMLEEKP(hitInfo);
			}
		}
	}

	private void PEIIGOHMMNE()
	{
		if (Input.GetButtonDown("moveOnACurveExample Time:") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.HNINCOCPEKA())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("hat3");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				KGMEAPCFKLP(hitInfo);
			}
		}
	}

	private void BBCFOEECNPB(RaycastHit IDIHIBBFELK, GameObject FHAFGFOHNBI)
	{
		Object.Instantiate(FHAFGFOHNBI, IDIHIBBFELK.point, Quaternion.LookRotation(IDIHIBBFELK.normal)).transform.SetParent(IDIHIBBFELK.collider.transform);
	}

	private void PLDLBPJDHLI(RaycastHit IDIHIBBFELK, GameObject FHAFGFOHNBI)
	{
		Object.Instantiate(FHAFGFOHNBI, IDIHIBBFELK.point, Quaternion.LookRotation(IDIHIBBFELK.normal)).transform.SetParent(IDIHIBBFELK.collider.transform);
	}

	private void ICALPAGEIDN()
	{
		if (Input.GetButtonDown("moveExample") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.LOJEEPHEILM())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("\r\n        end");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				FKHDBFIADLL(hitInfo);
			}
		}
	}

	private void NIKCEBMCDJB(RaycastHit IDIHIBBFELK, GameObject FHAFGFOHNBI)
	{
		Object.Instantiate(FHAFGFOHNBI, IDIHIBBFELK.point, Quaternion.LookRotation(IDIHIBBFELK.normal)).transform.SetParent(IDIHIBBFELK.collider.transform);
	}

	private void PNEMNPNEJFL(RaycastHit IDIHIBBFELK, GameObject FHAFGFOHNBI)
	{
		Object.Instantiate(FHAFGFOHNBI, IDIHIBBFELK.point, Quaternion.LookRotation(IDIHIBBFELK.normal)).transform.SetParent(IDIHIBBFELK.collider.transform);
	}

	private void EHFGBBKNKNG(RaycastHit IDIHIBBFELK, GameObject FHAFGFOHNBI)
	{
		Object.Instantiate(FHAFGFOHNBI, IDIHIBBFELK.point, Quaternion.LookRotation(IDIHIBBFELK.normal)).transform.SetParent(IDIHIBBFELK.collider.transform);
	}

	private void NIFCICDBJMN()
	{
		if (Input.GetButtonDown("sphere") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.JHMHJLHCFDH())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("gameid");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				LJOMIIDBGFG(hitInfo);
			}
		}
	}

	private void AJKHKJOIAOO()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void PEJKPIGIGPF(RaycastHit IDIHIBBFELK, GameObject FHAFGFOHNBI)
	{
		Object.Instantiate(FHAFGFOHNBI, IDIHIBBFELK.point, Quaternion.LookRotation(IDIHIBBFELK.normal)).transform.SetParent(IDIHIBBFELK.collider.transform);
	}

	private void NHIHBGFGCOI(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		if (num <= 4294967243u)
		{
			if (num <= 4294967133u)
			{
				switch (num)
				{
				case 4294967126u:
					if (name == ".obj")
					{
						ICFLJGFBIEH(IDIHIBBFELK, woodHitEffect);
					}
					break;
				case 4294967166u:
					if (name == "script")
					{
						PLDLBPJDHLI(IDIHIBBFELK, waterLeakExtinguishEffect);
						PLDLBPJDHLI(IDIHIBBFELK, metalHitEffect);
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 146u:
				if (name == "Cube2")
				{
					EHFGBBKNKNG(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 4294967170u:
				if (name == "SPLINE CLOSED LOOP SHOULD END AT START")
				{
					GKILLOBGKJG(IDIHIBBFELK, waterLeakEffect);
					ICFLJGFBIEH(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
			switch (num)
			{
			case 4294967253u:
				if (name == "Cube2")
				{
					LPJNDFBNPKA(IDIHIBBFELK, metalHitEffect);
				}
				break;
			case 44u:
				if (name == "Delayed function was called")
				{
					BBCFOEECNPB(IDIHIBBFELK, stoneHitEffect);
				}
				break;
			}
			break;
		case 28u:
			if (name == "AvatarScale")
			{
				JCDFNPFPDOO(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		case 4294967270u:
			if (name == "BodyColors")
			{
				GFMEMPDDNAC(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		}
	}

	private void FDJOMMLEEKP(RaycastHit IDIHIBBFELK)
	{
		if (IDIHIBBFELK.collider.sharedMaterial != null)
		{
			switch (IDIHIBBFELK.collider.sharedMaterial.name)
			{
			case "Metal":
				PEJKPIGIGPF(IDIHIBBFELK, metalHitEffect);
				break;
			case "Sand":
				PEJKPIGIGPF(IDIHIBBFELK, sandHitEffect);
				break;
			case "Stone":
				PEJKPIGIGPF(IDIHIBBFELK, stoneHitEffect);
				break;
			case "WaterFilled":
				PEJKPIGIGPF(IDIHIBBFELK, waterLeakEffect);
				PEJKPIGIGPF(IDIHIBBFELK, metalHitEffect);
				break;
			case "Wood":
				PEJKPIGIGPF(IDIHIBBFELK, woodHitEffect);
				break;
			case "Meat":
				PEJKPIGIGPF(IDIHIBBFELK, fleshHitEffects[Random.Range(0, fleshHitEffects.Length)]);
				break;
			case "Character":
				PEJKPIGIGPF(IDIHIBBFELK, fleshHitEffects[Random.Range(0, fleshHitEffects.Length)]);
				break;
			case "WaterFilledExtinguish":
				PEJKPIGIGPF(IDIHIBBFELK, waterLeakExtinguishEffect);
				PEJKPIGIGPF(IDIHIBBFELK, metalHitEffect);
				break;
			}
		}
	}

	private void MHLPDBMIFMO()
	{
		if (Input.GetButtonDown("moveOnACurveExample") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.JEPOFLKJJIB())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("VALUE2 UPDATE");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				NDOHHGOEMKD(hitInfo);
			}
		}
	}

	private void GFMEMPDDNAC(RaycastHit IDIHIBBFELK, GameObject FHAFGFOHNBI)
	{
		Object.Instantiate(FHAFGFOHNBI, IDIHIBBFELK.point, Quaternion.LookRotation(IDIHIBBFELK.normal)).transform.SetParent(IDIHIBBFELK.collider.transform);
	}

	private void HEPACNIHKPP()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void BFADADBGNOP()
	{
		if (Input.GetButtonDown("host:") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.BALJLBNOEIA())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger(" returned:");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				NNIHOECDDCL(hitInfo);
			}
		}
	}

	private void Update()
	{
		if (Input.GetButtonDown("Fire1") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.GetIsOutOfBounds())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("Fire");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				FDJOMMLEEKP(hitInfo);
			}
		}
	}

	private void GCPGLJDABDI(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		switch (num)
		{
		default:
			if (num == 4294967243u && name == "J")
			{
				BBCFOEECNPB(IDIHIBBFELK, waterLeakExtinguishEffect);
				PEJKPIGIGPF(IDIHIBBFELK, metalHitEffect);
			}
			break;
		case 4294967227u:
		case 4294967228u:
		case 4294967229u:
		case 4294967230u:
		case 4294967231u:
		case 4294967232u:
		case 4294967233u:
		case 4294967234u:
		case 4294967235u:
		case 4294967236u:
		case 4294967237u:
		case 4294967238u:
		case 4294967239u:
		case 4294967240u:
		case 4294967241u:
		case 4294967242u:
		case 4294967243u:
		case 4294967244u:
		case 4294967245u:
		case 4294967246u:
		case 4294967247u:
		case 4294967248u:
		case 4294967249u:
		case 4294967250u:
		case 4294967251u:
		case 4294967252u:
		case 4294967253u:
		case 4294967254u:
		case 4294967255u:
		case 4294967256u:
		case 4294967257u:
		case 4294967258u:
		case 4294967259u:
		case 4294967260u:
		case 4294967261u:
		case 4294967262u:
		case 4294967263u:
		case 4294967264u:
		case 4294967265u:
		case 4294967266u:
		case 4294967267u:
		case 4294967268u:
		case 4294967269u:
		case 4294967270u:
		case 4294967271u:
		case 4294967272u:
		case 4294967273u:
		case 4294967274u:
		case 4294967275u:
		case 4294967276u:
		case 4294967277u:
		case 4294967278u:
		case 4294967279u:
		case 4294967280u:
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
			switch (num)
			{
			case 4294967269u:
				if (name == "PlaceID")
				{
					ICFLJGFBIEH(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 186u:
				if (name == "SCALED ENDING POSITION")
				{
					ICFLJGFBIEH(IDIHIBBFELK, waterLeakEffect);
					JCDFNPFPDOO(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			break;
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			if (num <= 4294967214u)
			{
				switch (num)
				{
				case 4u:
					if (name == "SpherePart")
					{
						JCDFNPFPDOO(IDIHIBBFELK, metalHitEffect);
					}
					break;
				case 4294967266u:
					if (name == "><b>")
					{
						CIGFIBMMBAH(IDIHIBBFELK, stoneHitEffect);
					}
					break;
				}
				break;
			}
			switch (num)
			{
			case 12u:
				if (name == "LCharacter")
				{
					NIKCEBMCDJB(IDIHIBBFELK, fleshHitEffects[Random.Range(0, fleshHitEffects.Length)]);
				}
				break;
			case 4294967146u:
				if (name == "_TintColor")
				{
					PNEMNPNEJFL(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
				}
				break;
			}
			break;
		case 186u:
			if (name == "moveExample")
			{
				EHFGBBKNKNG(IDIHIBBFELK, woodHitEffect);
			}
			break;
		}
	}

	private void HJOPBBJKFBE()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void KIMKEHNABCD()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void CIGFIBMMBAH(RaycastHit IDIHIBBFELK, GameObject FHAFGFOHNBI)
	{
		Object.Instantiate(FHAFGFOHNBI, IDIHIBBFELK.point, Quaternion.LookRotation(IDIHIBBFELK.normal)).transform.SetParent(IDIHIBBFELK.collider.transform);
	}

	private void JCDFNPFPDOO(RaycastHit IDIHIBBFELK, GameObject FHAFGFOHNBI)
	{
		Object.Instantiate(FHAFGFOHNBI, IDIHIBBFELK.point, Quaternion.LookRotation(IDIHIBBFELK.normal)).transform.SetParent(IDIHIBBFELK.collider.transform);
	}

	private void HOMPMLKKGFP(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
		case 25u:
		case 26u:
		case 27u:
		case 28u:
		case 29u:
		case 30u:
			if (num <= 122)
			{
				switch (num)
				{
				case 4294967134u:
					if (name == "rotator")
					{
						GKILLOBGKJG(IDIHIBBFELK, woodHitEffect);
					}
					break;
				case 4294967162u:
					if (name == "scale")
					{
						JCDFNPFPDOO(IDIHIBBFELK, waterLeakExtinguishEffect);
						PNEMNPNEJFL(IDIHIBBFELK, metalHitEffect);
					}
					break;
				}
				break;
			}
			switch (num)
			{
			case 161u:
				if (name == "J")
				{
					GKILLOBGKJG(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 4294967239u:
				if (name == "Fire1")
				{
					LPJNDFBNPKA(IDIHIBBFELK, waterLeakEffect);
					EHFGBBKNKNG(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			break;
		case 31u:
		case 32u:
		case 33u:
		case 34u:
		case 35u:
		case 36u:
		case 37u:
		case 38u:
		case 39u:
		case 40u:
		case 41u:
		case 42u:
		case 43u:
			switch (num)
			{
			case 4294967104u:
				if (name == "Failed to set Discord activity")
				{
					PLDLBPJDHLI(IDIHIBBFELK, metalHitEffect);
				}
				break;
			case 4294967240u:
				if (name == "customTweenExample starting pos:")
				{
					GKILLOBGKJG(IDIHIBBFELK, stoneHitEffect);
				}
				break;
			}
			break;
		case 4294967110u:
			if (name == "move x:")
			{
				NIKCEBMCDJB(IDIHIBBFELK, fleshHitEffects[Random.Range(0, fleshHitEffects.Length)]);
			}
			break;
		case 72u:
			if (name == " time:")
			{
				EHFGBBKNKNG(IDIHIBBFELK, fleshHitEffects[Random.Range(0, fleshHitEffects.Length)]);
			}
			break;
		}
	}

	private void AKKCHJICOHD()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void OJNBDNKOJOM()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void JEDBEELLACK()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void MGLKGPLEAPH()
	{
		if (Input.GetButtonDown(" times") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.MDDAIFEPKMK())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("name:");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				HOMPMLKKGFP(hitInfo);
			}
		}
	}

	private void ICMGJJHGNDP()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void FKHDBFIADLL(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		if (num <= 4294967278u)
		{
			if (num <= 187)
			{
				switch (num)
				{
				case 128u:
					if (name == "EaseInOutQuart")
					{
						PLDLBPJDHLI(IDIHIBBFELK, woodHitEffect);
					}
					break;
				case 71u:
					if (name == "EaseInQuad")
					{
						EHFGBBKNKNG(IDIHIBBFELK, waterLeakExtinguishEffect);
						CIGFIBMMBAH(IDIHIBBFELK, metalHitEffect);
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 139u:
				if (name == "Cube1")
				{
					LPJNDFBNPKA(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 17u:
				if (name == "timeScale:")
				{
					CIGFIBMMBAH(IDIHIBBFELK, waterLeakEffect);
					ICFLJGFBIEH(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 93u:
			if (name == "EaseShake")
			{
				CIGFIBMMBAH(IDIHIBBFELK, metalHitEffect);
			}
			break;
		case 76u:
			if (name == "LCharacter")
			{
				GKILLOBGKJG(IDIHIBBFELK, stoneHitEffect);
			}
			break;
		case 140u:
			if (name == "BodyColors")
			{
				ICFLJGFBIEH(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		case 4294967143u:
			if (name == "GROUP POSITION FINISH")
			{
				PLDLBPJDHLI(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		}
	}

	private void OIGPCDCPDHL()
	{
		if (Input.GetButtonDown("Leaderboard") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.HJPDMBFGDJL())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("AvatarMove");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				FDJOMMLEEKP(hitInfo);
			}
		}
	}

	private void BKDOHCHMGAB()
	{
		if (Input.GetButtonDown("OBJECT NOT TWEEENING AT BEGINNING") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.OKNLCBBDBAC())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("gameObject:null");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				KGMEAPCFKLP(hitInfo);
			}
		}
	}

	private void KGMEAPCFKLP(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		if (num <= 143)
		{
			switch (num)
			{
			case 4294967245u:
				if (name == "leftarm")
				{
					BBCFOEECNPB(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 4294967192u:
				if (name == "final")
				{
					LPJNDFBNPKA(IDIHIBBFELK, waterLeakEffect);
					JCDFNPFPDOO(IDIHIBBFELK, metalHitEffect);
				}
				break;
			case 86u:
				if (name == "EVENT GAMEOBJECT NOT REMOVED")
				{
					LPJNDFBNPKA(IDIHIBBFELK, woodHitEffect);
				}
				break;
			case 160u:
				if (name == "alphaExample")
				{
					GKILLOBGKJG(IDIHIBBFELK, waterLeakExtinguishEffect);
					PEJKPIGIGPF(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
		case 25u:
		case 26u:
		case 27u:
		case 28u:
		case 29u:
		case 30u:
		case 31u:
		case 32u:
		case 33u:
		case 34u:
			switch (num)
			{
			case 4294967196u:
				if (name == "\r\n        end")
				{
					PLDLBPJDHLI(IDIHIBBFELK, metalHitEffect);
				}
				break;
			case 4294967279u:
				if (name == "yyyyMMdd-hhmmss")
				{
					BBCFOEECNPB(IDIHIBBFELK, stoneHitEffect);
				}
				break;
			}
			break;
		case 130u:
			if (name == "_")
			{
				NIKCEBMCDJB(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		case 4294967213u:
			if (name == " ]")
			{
				EHFGBBKNKNG(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		}
	}

	private void BLANFEOIEHH()
	{
		if (Input.GetButtonDown("   ") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.OOGLEIKLAEO())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("BodyColors");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				NNIHOECDDCL(hitInfo);
			}
		}
	}

	private void LPJNDFBNPKA(RaycastHit IDIHIBBFELK, GameObject FHAFGFOHNBI)
	{
		Object.Instantiate(FHAFGFOHNBI, IDIHIBBFELK.point, Quaternion.LookRotation(IDIHIBBFELK.normal)).transform.SetParent(IDIHIBBFELK.collider.transform);
	}

	private void NNIHOECDDCL(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
		case 25u:
		case 26u:
		case 27u:
		case 28u:
		case 29u:
		case 30u:
		case 31u:
		case 32u:
		case 33u:
		case 34u:
		case 35u:
		case 36u:
			if (num <= 4294967124u)
			{
				switch (num)
				{
				case 4294967287u:
					if (name == "PlaceFile")
					{
						GKILLOBGKJG(IDIHIBBFELK, woodHitEffect);
					}
					break;
				case 53u:
					if (name == "avatarMove")
					{
						EHFGBBKNKNG(IDIHIBBFELK, waterLeakExtinguishEffect);
						PLDLBPJDHLI(IDIHIBBFELK, metalHitEffect);
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 25u:
				if (name == "")
				{
					ICFLJGFBIEH(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 109u:
				if (name == "EaseInCubic")
				{
					GKILLOBGKJG(IDIHIBBFELK, waterLeakEffect);
					GFMEMPDDNAC(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			return;
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			switch (num)
			{
			case 4294967219u:
				if (name == "RESET CORRECTLY CLEANS UP")
				{
					CIGFIBMMBAH(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
				}
				break;
			case 4294967218u:
				if (name == "Cube1")
				{
					BBCFOEECNPB(IDIHIBBFELK, fleshHitEffects[Random.Range(0, fleshHitEffects.Length)]);
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967155u:
			if (name == "MOVE LOCAL Z")
			{
				PNEMNPNEJFL(IDIHIBBFELK, metalHitEffect);
			}
			break;
		case 4294967291u:
			if (name == " useEstimatedTime:")
			{
				LPJNDFBNPKA(IDIHIBBFELK, stoneHitEffect);
			}
			break;
		}
	}

	private void ICFLJGFBIEH(RaycastHit IDIHIBBFELK, GameObject FHAFGFOHNBI)
	{
		Object.Instantiate(FHAFGFOHNBI, IDIHIBBFELK.point, Quaternion.LookRotation(IDIHIBBFELK.normal)).transform.SetParent(IDIHIBBFELK.collider.transform);
	}

	private void NDOHHGOEMKD(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		if (num <= 4294967275u)
		{
			if (num <= 146)
			{
				switch (num)
				{
				case 4294967183u:
					if (name == "")
					{
						GFMEMPDDNAC(IDIHIBBFELK, woodHitEffect);
					}
					break;
				case 171u:
					if (name == "EaseLinear")
					{
						ICFLJGFBIEH(IDIHIBBFELK, waterLeakExtinguishEffect);
						EHFGBBKNKNG(IDIHIBBFELK, metalHitEffect);
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 4294967182u:
				if (name == "move x:")
				{
					JCDFNPFPDOO(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 4294967133u:
				if (name == "Environment")
				{
					CIGFIBMMBAH(IDIHIBBFELK, waterLeakEffect);
					JCDFNPFPDOO(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967234u:
		case 4294967235u:
		case 4294967236u:
		case 4294967237u:
		case 4294967238u:
		case 4294967239u:
		case 4294967240u:
		case 4294967241u:
		case 4294967242u:
		case 4294967243u:
		case 4294967244u:
		case 4294967245u:
		case 4294967246u:
		case 4294967247u:
		case 4294967248u:
		case 4294967249u:
		case 4294967250u:
		case 4294967251u:
		case 4294967252u:
		case 4294967253u:
		case 4294967254u:
		case 4294967255u:
		case 4294967256u:
		case 4294967257u:
		case 4294967258u:
		case 4294967259u:
		case 4294967260u:
		case 4294967261u:
		case 4294967262u:
		case 4294967263u:
		case 4294967264u:
		case 4294967265u:
		case 4294967266u:
		case 4294967267u:
		case 4294967268u:
		case 4294967269u:
		case 4294967270u:
		case 4294967271u:
		case 4294967272u:
		case 4294967273u:
		case 4294967274u:
		case 4294967275u:
		case 4294967276u:
		case 4294967277u:
		case 4294967278u:
		case 4294967279u:
		case 4294967280u:
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			switch (num)
			{
			case 124u:
				if (name == "Fire1")
				{
					PNEMNPNEJFL(IDIHIBBFELK, fleshHitEffects[Random.Range(0, fleshHitEffects.Length)]);
				}
				break;
			case 47u:
				if (name == "https://superium.net/assets/thumbnails/games/banners/")
				{
					BBCFOEECNPB(IDIHIBBFELK, fleshHitEffects[Random.Range(0, fleshHitEffects.Length)]);
				}
				break;
			}
			break;
		case 84u:
			if (name == "hi")
			{
				ICFLJGFBIEH(IDIHIBBFELK, metalHitEffect);
			}
			break;
		case 40u:
			if (name == "final")
			{
				PNEMNPNEJFL(IDIHIBBFELK, stoneHitEffect);
			}
			break;
		}
	}

	private void GONFCNKPFDO()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void KBCEINLPBCG(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		if (num <= 4294967103u)
		{
			if (num <= 129)
			{
				switch (num)
				{
				case 54u:
					if (name == "moveLocalExample")
					{
						ICFLJGFBIEH(IDIHIBBFELK, woodHitEffect);
					}
					break;
				case 4294967212u:
					if (name == "BEZIER CLOSED LOOP SHOULD END AT START")
					{
						EHFGBBKNKNG(IDIHIBBFELK, waterLeakExtinguishEffect);
						PEJKPIGIGPF(IDIHIBBFELK, metalHitEffect);
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 14u:
				if (name == "delayedCallExample")
				{
					BBCFOEECNPB(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 21u:
				if (name == "ui_ChatContainer")
				{
					PLDLBPJDHLI(IDIHIBBFELK, waterLeakEffect);
					GFMEMPDDNAC(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
		case 25u:
		case 26u:
		case 27u:
		case 28u:
		case 29u:
		case 30u:
		case 31u:
		case 32u:
		case 33u:
		case 34u:
		case 35u:
		case 36u:
		case 37u:
		case 38u:
		case 39u:
		case 40u:
		case 41u:
		case 42u:
		case 43u:
		case 44u:
		case 45u:
		case 46u:
		case 47u:
		case 48u:
		case 49u:
		case 50u:
		case 51u:
		case 52u:
		case 53u:
		case 54u:
		case 55u:
		case 56u:
		case 57u:
		case 58u:
		case 59u:
		case 60u:
		case 61u:
		case 62u:
		case 63u:
		case 64u:
		case 65u:
		case 66u:
		case 67u:
		case 68u:
		case 69u:
		case 70u:
		case 71u:
		case 72u:
		case 73u:
		case 74u:
		case 75u:
		case 76u:
			switch (num)
			{
			case 4294967243u:
				if (name == "moveOnACurveExample Time:")
				{
					PLDLBPJDHLI(IDIHIBBFELK, metalHitEffect);
				}
				break;
			case 4294967191u:
				if (name == "moveLocalExample")
				{
					GKILLOBGKJG(IDIHIBBFELK, stoneHitEffect);
				}
				break;
			}
			break;
		case 169u:
			if (name == "OBJECT NOT TWEEENING AT BEGINNING")
			{
				GKILLOBGKJG(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		case 4294967181u:
			if (name == "GROUP IDS MATCH")
			{
				EHFGBBKNKNG(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		}
	}

	private void JFEKGAMBHJN()
	{
		if (Input.GetButtonDown(" returned:") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.KHBGJLADELI())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("cPaused");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				CGLIFNLFLAC(hitInfo);
			}
		}
	}

	private void NKCMNFMALKK(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		switch (num)
		{
		case 4294967131u:
		case 4294967132u:
		case 4294967133u:
		case 4294967134u:
		case 4294967135u:
		case 4294967136u:
		case 4294967137u:
		case 4294967138u:
		case 4294967139u:
		case 4294967140u:
		case 4294967141u:
		case 4294967142u:
		case 4294967143u:
		case 4294967144u:
		case 4294967145u:
		case 4294967146u:
		case 4294967147u:
		case 4294967148u:
		case 4294967149u:
		case 4294967150u:
		case 4294967151u:
		case 4294967152u:
		case 4294967153u:
		case 4294967154u:
		case 4294967155u:
		case 4294967156u:
		case 4294967157u:
		case 4294967158u:
		case 4294967159u:
		case 4294967160u:
		case 4294967161u:
		case 4294967162u:
		case 4294967163u:
		case 4294967164u:
		case 4294967165u:
			switch (num)
			{
			case 4294967237u:
				if (name == "final x:")
				{
					NIKCEBMCDJB(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 4294967238u:
				if (name == "Mouse X")
				{
					JCDFNPFPDOO(IDIHIBBFELK, waterLeakEffect);
					LPJNDFBNPKA(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			return;
		case 4294967166u:
		case 4294967167u:
		case 4294967168u:
		case 4294967169u:
		case 4294967170u:
		case 4294967171u:
		case 4294967172u:
		case 4294967173u:
		case 4294967174u:
		case 4294967175u:
		case 4294967176u:
		case 4294967177u:
		case 4294967178u:
		case 4294967179u:
		case 4294967180u:
		case 4294967181u:
		case 4294967182u:
		case 4294967183u:
		case 4294967184u:
		case 4294967185u:
		case 4294967186u:
		case 4294967187u:
		case 4294967188u:
		case 4294967189u:
		case 4294967190u:
		case 4294967191u:
		case 4294967192u:
		case 4294967193u:
		case 4294967194u:
		case 4294967195u:
		case 4294967196u:
		case 4294967197u:
		case 4294967198u:
		case 4294967199u:
		case 4294967200u:
		case 4294967201u:
		case 4294967202u:
		case 4294967203u:
		case 4294967204u:
		case 4294967205u:
		case 4294967206u:
		case 4294967207u:
		case 4294967208u:
		case 4294967209u:
		case 4294967210u:
		case 4294967211u:
		case 4294967212u:
		case 4294967213u:
		case 4294967214u:
		case 4294967215u:
		case 4294967216u:
		case 4294967217u:
		case 4294967218u:
		case 4294967219u:
		case 4294967220u:
		case 4294967221u:
		case 4294967222u:
		case 4294967223u:
		case 4294967224u:
		case 4294967225u:
		case 4294967226u:
		case 4294967227u:
		case 4294967228u:
		case 4294967229u:
		case 4294967230u:
		case 4294967231u:
		case 4294967232u:
		case 4294967233u:
		case 4294967234u:
		case 4294967235u:
		case 4294967236u:
		case 4294967237u:
		case 4294967238u:
		case 4294967239u:
		case 4294967240u:
		case 4294967241u:
		case 4294967242u:
			switch (num)
			{
			case 4294967231u:
				if (name == ";;")
				{
					BBCFOEECNPB(IDIHIBBFELK, metalHitEffect);
				}
				break;
			case 189u:
				if (name == "https://superium.net/api/GetCharacterAppearanceById?id=")
				{
					PEJKPIGIGPF(IDIHIBBFELK, stoneHitEffect);
				}
				break;
			}
			return;
		case 4294967243u:
		case 4294967244u:
		case 4294967245u:
		case 4294967246u:
		case 4294967247u:
		case 4294967248u:
		case 4294967249u:
		case 4294967250u:
		case 4294967251u:
		case 4294967252u:
		case 4294967253u:
		case 4294967254u:
		case 4294967255u:
		case 4294967256u:
		case 4294967257u:
		case 4294967258u:
		case 4294967259u:
		case 4294967260u:
		case 4294967261u:
		case 4294967262u:
		case 4294967263u:
		case 4294967264u:
		case 4294967265u:
		case 4294967266u:
		case 4294967267u:
		case 4294967268u:
		case 4294967269u:
		case 4294967270u:
		case 4294967271u:
		case 4294967272u:
		case 4294967273u:
		case 4294967274u:
		case 4294967275u:
		case 4294967276u:
		case 4294967277u:
		case 4294967278u:
		case 4294967279u:
		case 4294967280u:
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			switch (num)
			{
			case 97u:
				if (name == "AvatarBig")
				{
					BBCFOEECNPB(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
				}
				break;
			case 91u:
				if (name == "ROTATE AROUND 360")
				{
					LPJNDFBNPKA(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967167u:
			if (name == "moving")
			{
				GKILLOBGKJG(IDIHIBBFELK, woodHitEffect);
			}
			break;
		case 4294967099u:
			if (name == "message")
			{
				ICFLJGFBIEH(IDIHIBBFELK, waterLeakExtinguishEffect);
				GFMEMPDDNAC(IDIHIBBFELK, metalHitEffect);
			}
			break;
		}
	}

	private void JGLNKJCOEEN(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		if (num <= 4294967292u)
		{
			if (num <= 4294967108u)
			{
				switch (num)
				{
				case 106u:
					if (name == "creator")
					{
						EHFGBBKNKNG(IDIHIBBFELK, woodHitEffect);
					}
					break;
				case 21u:
					if (name == "Environment")
					{
						LPJNDFBNPKA(IDIHIBBFELK, waterLeakExtinguishEffect);
						ICFLJGFBIEH(IDIHIBBFELK, metalHitEffect);
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 4294967243u:
				if (name == "EasePunch")
				{
					PLDLBPJDHLI(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 53u:
				if (name == "https://superium.net/api/users/getbytoken?t=")
				{
					BBCFOEECNPB(IDIHIBBFELK, waterLeakEffect);
					CIGFIBMMBAH(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967206u:
		case 4294967207u:
		case 4294967208u:
		case 4294967209u:
		case 4294967210u:
		case 4294967211u:
		case 4294967212u:
		case 4294967213u:
		case 4294967214u:
		case 4294967215u:
		case 4294967216u:
		case 4294967217u:
		case 4294967218u:
		case 4294967219u:
		case 4294967220u:
		case 4294967221u:
		case 4294967222u:
		case 4294967223u:
		case 4294967224u:
		case 4294967225u:
		case 4294967226u:
		case 4294967227u:
		case 4294967228u:
		case 4294967229u:
		case 4294967230u:
		case 4294967231u:
		case 4294967232u:
		case 4294967233u:
		case 4294967234u:
		case 4294967235u:
		case 4294967236u:
		case 4294967237u:
		case 4294967238u:
		case 4294967239u:
		case 4294967240u:
		case 4294967241u:
		case 4294967242u:
		case 4294967243u:
		case 4294967244u:
		case 4294967245u:
		case 4294967246u:
		case 4294967247u:
		case 4294967248u:
		case 4294967249u:
		case 4294967250u:
		case 4294967251u:
		case 4294967252u:
		case 4294967253u:
		case 4294967254u:
		case 4294967255u:
		case 4294967256u:
		case 4294967257u:
		case 4294967258u:
		case 4294967259u:
		case 4294967260u:
		case 4294967261u:
		case 4294967262u:
		case 4294967263u:
		case 4294967264u:
		case 4294967265u:
		case 4294967266u:
		case 4294967267u:
		case 4294967268u:
		case 4294967269u:
		case 4294967270u:
		case 4294967271u:
		case 4294967272u:
		case 4294967273u:
		case 4294967274u:
		case 4294967275u:
		case 4294967276u:
		case 4294967277u:
		case 4294967278u:
		case 4294967279u:
		case 4294967280u:
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			switch (num)
			{
			case 4294967245u:
				if (name == "position is:")
				{
					BBCFOEECNPB(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
				}
				break;
			case 38u:
				if (name == "Host data port:")
				{
					ICFLJGFBIEH(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
				}
				break;
			}
			break;
		case 81u:
			if (name == "EaseInOutBounce")
			{
				LPJNDFBNPKA(IDIHIBBFELK, metalHitEffect);
			}
			break;
		case 121u:
			if (name == "Cube1")
			{
				ICFLJGFBIEH(IDIHIBBFELK, stoneHitEffect);
			}
			break;
		}
	}

	private void LLJHEFBJCCB()
	{
		if (Input.GetButtonDown(" [ ") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.JEPOFLKJJIB())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("cube");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				KGMEAPCFKLP(hitInfo);
			}
		}
	}

	private void GKILLOBGKJG(RaycastHit IDIHIBBFELK, GameObject FHAFGFOHNBI)
	{
		Object.Instantiate(FHAFGFOHNBI, IDIHIBBFELK.point, Quaternion.LookRotation(IDIHIBBFELK.normal)).transform.SetParent(IDIHIBBFELK.collider.transform);
	}

	private void LNCCHKHMKFL(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		if (num <= 4294967238u)
		{
			switch (num)
			{
			case uint.MaxValue:
				switch (num)
				{
				case uint.MaxValue:
					if (name == "CmdUpdateUserData")
					{
						JCDFNPFPDOO(IDIHIBBFELK, sandHitEffect);
					}
					break;
				case 85u:
					if (name == "Player")
					{
						JCDFNPFPDOO(IDIHIBBFELK, waterLeakEffect);
						NIKCEBMCDJB(IDIHIBBFELK, metalHitEffect);
					}
					break;
				}
				break;
			case 4294967153u:
				if (name == "Host data port:")
				{
					CIGFIBMMBAH(IDIHIBBFELK, woodHitEffect);
				}
				break;
			case 4294967115u:
				if (name == "COLOR")
				{
					BBCFOEECNPB(IDIHIBBFELK, waterLeakExtinguishEffect);
					ICFLJGFBIEH(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			return;
		}
		if (num <= 4294967104u)
		{
			switch (num)
			{
			case 4294967158u:
				if (name == "ChatInput")
				{
					EHFGBBKNKNG(IDIHIBBFELK, metalHitEffect);
				}
				break;
			case 4294967097u:
				if (name == "DESTROY ON COMPLETE")
				{
					NIKCEBMCDJB(IDIHIBBFELK, stoneHitEffect);
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967145u:
			if (name == "Starting to tween...")
			{
				ICFLJGFBIEH(IDIHIBBFELK, fleshHitEffects[Random.Range(0, fleshHitEffects.Length)]);
			}
			break;
		case 167u:
			if (name == "EaseInOutElastic")
			{
				BBCFOEECNPB(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
			}
			break;
		}
	}

	private void FLGMDCCIJKJ()
	{
		INIPPOFFMDK = GetComponent<Animator>();
		JJCBIKBDBFO = GetComponentInParent<GunAim>();
	}

	private void HFMOPLBNNPO()
	{
		if (Input.GetButtonDown("http://www.starscenesoftware.com/objtest/Spot.obj") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.KHBGJLADELI())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("avatarRotate");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				KGMEAPCFKLP(hitInfo);
			}
		}
	}

	private void CMKLLDPHOEL()
	{
		if (Input.GetButtonDown("ui_HealthAmount") && Time.time > BMIAAAJPDLO && !JJCBIKBDBFO.LAHOPKOJIPF())
		{
			BMIAAAJPDLO = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			INIPPOFFMDK.SetTrigger("Prefabs/");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out RaycastHit hitInfo, weaponRange))
			{
				KBCEINLPBCG(hitInfo);
			}
		}
	}

	private void APOMIAGHMPH(RaycastHit IDIHIBBFELK)
	{
		if (!(IDIHIBBFELK.collider.sharedMaterial != null))
		{
			return;
		}
		string name = IDIHIBBFELK.collider.sharedMaterial.name;
		uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
		switch (num)
		{
		case 4294967179u:
		case 4294967180u:
		case 4294967181u:
		case 4294967182u:
		case 4294967183u:
		case 4294967184u:
		case 4294967185u:
		case 4294967186u:
		case 4294967187u:
		case 4294967188u:
		case 4294967189u:
		case 4294967190u:
		case 4294967191u:
		case 4294967192u:
		case 4294967193u:
		case 4294967194u:
		case 4294967195u:
		case 4294967196u:
		case 4294967197u:
		case 4294967198u:
		case 4294967199u:
		case 4294967200u:
		case 4294967201u:
		case 4294967202u:
		case 4294967203u:
		case 4294967204u:
		case 4294967205u:
		case 4294967206u:
		case 4294967207u:
		case 4294967208u:
		case 4294967209u:
		case 4294967210u:
		case 4294967211u:
		case 4294967212u:
		case 4294967213u:
		case 4294967214u:
		case 4294967215u:
		case 4294967216u:
		case 4294967217u:
		case 4294967218u:
		case 4294967219u:
		case 4294967220u:
		case 4294967221u:
			switch (num)
			{
			case 192u:
				if (name == "set")
				{
					EHFGBBKNKNG(IDIHIBBFELK, sandHitEffect);
				}
				break;
			case 4294967125u:
				if (name == "GROUP POSITION FINISH")
				{
					CIGFIBMMBAH(IDIHIBBFELK, waterLeakEffect);
					NIKCEBMCDJB(IDIHIBBFELK, metalHitEffect);
				}
				break;
			}
			return;
		case 4294967222u:
		case 4294967223u:
		case 4294967224u:
		case 4294967225u:
		case 4294967226u:
		case 4294967227u:
		case 4294967228u:
		case 4294967229u:
		case 4294967230u:
		case 4294967231u:
		case 4294967232u:
		case 4294967233u:
		case 4294967234u:
		case 4294967235u:
		case 4294967236u:
		case 4294967237u:
		case 4294967238u:
		case 4294967239u:
		case 4294967240u:
		case 4294967241u:
		case 4294967242u:
		case 4294967243u:
		case 4294967244u:
		case 4294967245u:
		case 4294967246u:
		case 4294967247u:
		case 4294967248u:
		case 4294967249u:
		case 4294967250u:
		case 4294967251u:
		case 4294967252u:
		case 4294967253u:
		case 4294967254u:
		case 4294967255u:
		case 4294967257u:
		case 4294967258u:
		case 4294967259u:
		case 4294967260u:
		case 4294967261u:
		case 4294967262u:
		case 4294967263u:
		case 4294967264u:
		case 4294967265u:
			if (num == 4294967143u && name == "expected rotate z:")
			{
				LPJNDFBNPKA(IDIHIBBFELK, metalHitEffect);
			}
			return;
		case 4294967266u:
		case 4294967267u:
		case 4294967268u:
		case 4294967269u:
		case 4294967270u:
		case 4294967271u:
		case 4294967272u:
		case 4294967273u:
		case 4294967274u:
		case 4294967275u:
		case 4294967276u:
		case 4294967277u:
		case 4294967278u:
		case 4294967279u:
		case 4294967280u:
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			switch (num)
			{
			case 4294967118u:
				if (name == "https://superium.net/api/get_leaderboard_icon_url?username=")
				{
					NIKCEBMCDJB(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
				}
				break;
			case 4294967138u:
				if (name == "Player auth token not set.")
				{
					LPJNDFBNPKA(IDIHIBBFELK, fleshHitEffects[Random.Range(1, fleshHitEffects.Length)]);
				}
				break;
			}
			return;
		case 4294967256u:
			if (name == "Cube1")
			{
				NIKCEBMCDJB(IDIHIBBFELK, stoneHitEffect);
			}
			return;
		}
		switch (num)
		{
		case 4294967220u:
			if (name == "https://superium.net/images/transparent.png")
			{
				GFMEMPDDNAC(IDIHIBBFELK, woodHitEffect);
			}
			break;
		case 4294967210u:
			if (name == "https://superium.net/images/transparent.png")
			{
				BBCFOEECNPB(IDIHIBBFELK, waterLeakExtinguishEffect);
				NIKCEBMCDJB(IDIHIBBFELK, metalHitEffect);
			}
			break;
		}
	}
}
