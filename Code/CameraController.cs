// CameraController
using UnityEngine;

[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
public class CameraController : MonoBehaviour
{
	public Transform target;

	public float distance = 5f;

	public float xSpeed = 120f;

	public float ySpeed = 120f;

	public float yMinLimit = -20f;

	public float yMaxLimit = 80f;

	private float CNFIGHFCKGN = 15f;

	public float minDist = 0.5f;

	public float maxDist = 20f;

	private Rigidbody OFLKPDJDBGD;

	public float scrollSensitivity = 15f;

	private float CJHOHKKLFDF;

	private float FGDPPDPMCOK;

	private bool BMDFHEHKMFM = true;

	public bool clipThroughWalls = true;

	private void OLHNLPEMCHD()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("PAUSE BY TIMESCALE FINISHES") * xSpeed * distance * 1221f;
			FGDPPDPMCOK -= Input.GetAxis("EaseOutBounce") * ySpeed * 1610f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = LCFDBINKOON(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 404f);
		CNFIGHFCKGN -= Input.GetAxis("isSpawn") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 813f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1291f, 990f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	public static float JGNKNPAEJIA(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 1740f)
		{
			IEFCCFPGDMI += 1111f;
		}
		if (IEFCCFPGDMI > 724f)
		{
			IEFCCFPGDMI -= 104f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void BODBAOAJJMJ()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = true;
		}
	}

	private void JCLILLBGIGM()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("Part") * xSpeed * distance * 1670f;
			FGDPPDPMCOK -= Input.GetAxis("port") * ySpeed * 31f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = KPNNIEHFMIB(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1544f);
		CNFIGHFCKGN -= Input.GetAxis("ROTATE REPEAT") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 472f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1587f, 1421f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	public static float CMAJKBICLHH(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 911f)
		{
			IEFCCFPGDMI += 1859f;
		}
		if (IEFCCFPGDMI > 200f)
		{
			IEFCCFPGDMI -= 537f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void LNFLFFLMIOB()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("GameThumbnail") * xSpeed * distance * 1691f;
			FGDPPDPMCOK -= Input.GetAxis(" y:") * ySpeed * 439f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = LCFDBINKOON(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 338f);
		CNFIGHFCKGN -= Input.GetAxis(" previousXlt4:") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1336f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1008f, 97f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	public static float MGEKDOIONIB(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 1836f)
		{
			IEFCCFPGDMI += 782f;
		}
		if (IEFCCFPGDMI > 1134f)
		{
			IEFCCFPGDMI -= 1880f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	public static float PJNGIKIALHI(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 345f)
		{
			IEFCCFPGDMI += 287f;
		}
		if (IEFCCFPGDMI > 717f)
		{
			IEFCCFPGDMI -= 700f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	public static float LCFDBINKOON(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 1877f)
		{
			IEFCCFPGDMI += 1092f;
		}
		if (IEFCCFPGDMI > 756f)
		{
			IEFCCFPGDMI -= 1938f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	public static float MICKBENBMBO(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 884f)
		{
			IEFCCFPGDMI += 1333f;
		}
		if (IEFCCFPGDMI > 999f)
		{
			IEFCCFPGDMI -= 1183f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	public static float NDPOKHMNCOP(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 489f)
		{
			IEFCCFPGDMI += 1899f;
		}
		if (IEFCCFPGDMI > 867f)
		{
			IEFCCFPGDMI -= 1368f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void HEPAMDACOJD()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	public static float HAKOMCHFBEL(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 1426f)
		{
			IEFCCFPGDMI += 1368f;
		}
		if (IEFCCFPGDMI > 1575f)
		{
			IEFCCFPGDMI -= 681f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void KDIKENLODJA()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = true;
		}
	}

	private void HNGCGALADEI()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	public static float ClampAngle(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < -360f)
		{
			IEFCCFPGDMI += 360f;
		}
		if (IEFCCFPGDMI > 360f)
		{
			IEFCCFPGDMI -= 360f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	public static float KPNNIEHFMIB(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 641f)
		{
			IEFCCFPGDMI += 183f;
		}
		if (IEFCCFPGDMI > 1381f)
		{
			IEFCCFPGDMI -= 633f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	public static float FGOFNKEBDHE(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 1028f)
		{
			IEFCCFPGDMI += 1411f;
		}
		if (IEFCCFPGDMI > 746f)
		{
			IEFCCFPGDMI -= 1745f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void HIBGGJNOLCI()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("") * xSpeed * distance * 1779f;
			FGDPPDPMCOK -= Input.GetAxis("Command CmdUpdateUserData called on client.") * ySpeed * 1456f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = FKGDICHKNAG(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 223f);
		CNFIGHFCKGN -= Input.GetAxis("AvatarBig") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 250f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(411f, 1042f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void PMAKNOLMDOE()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	private void EBIBPLNAGMP()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = true;
		}
	}

	private void AODKAAOMHCM()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = true;
		}
	}

	public static float IPNGBHLDHKA(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 619f)
		{
			IEFCCFPGDMI += 1642f;
		}
		if (IEFCCFPGDMI > 74f)
		{
			IEFCCFPGDMI -= 429f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void BDMGKLPALJN()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = true;
		}
	}

	private void HABMAFFJPBG()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("LCharacter") * xSpeed * distance * 1088f;
			FGDPPDPMCOK -= Input.GetAxis("DESTROY ON COMPLETE") * ySpeed * 678f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = FGOFNKEBDHE(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 822f);
		CNFIGHFCKGN -= Input.GetAxis("hat2") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 476f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1660f, 360f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void GMLJPLENODC()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("PlaceID") * xSpeed * distance * 1247f;
			FGDPPDPMCOK -= Input.GetAxis("moveOnACurveExample") * ySpeed * 1698f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = MEGPCCKJOLE(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 567f);
		CNFIGHFCKGN -= Input.GetAxis("expected:") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 458f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(366f, 684f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void DHDIFNJEMGK()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	public static float CLDHOBFOEKK(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 1017f)
		{
			IEFCCFPGDMI += 31f;
		}
		if (IEFCCFPGDMI > 1007f)
		{
			IEFCCFPGDMI -= 931f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void IPOMCIBLHDL()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	private void AOMPLLFLPGK()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis(" from:") * xSpeed * distance * 358f;
			FGDPPDPMCOK -= Input.GetAxis("/ObjReader/Sample Files/") * ySpeed * 1456f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = HAKOMCHFBEL(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1843f);
		CNFIGHFCKGN -= Input.GetAxis("Lighting") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 581f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1055f, 1618f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void OEKLLINGCBB()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("Waiting for a server") * xSpeed * distance * 1170f;
			FGDPPDPMCOK -= Input.GetAxis(" diff:") * ySpeed * 811f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = JIBMGAJAPML(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 252f);
		CNFIGHFCKGN -= Input.GetAxis(" beforeX:") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1993f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(629f, 375f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void AFJCIJEKLEA()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	private void GKFNBABHHGP()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	private void PONIFHJBJEM()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("_") * xSpeed * distance * 773f;
			FGDPPDPMCOK -= Input.GetAxis("logo") * ySpeed * 1523f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = KPNNIEHFMIB(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1901f);
		CNFIGHFCKGN -= Input.GetAxis(" diff:") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 942f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1552f, 264f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void Start()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = true;
		}
	}

	private void EJHIEFBCDPC()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis(".png") * xSpeed * distance * 1812f;
			FGDPPDPMCOK -= Input.GetAxis("LeanTweenLogo") * ySpeed * 1745f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = MICKBENBMBO(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1504f);
		CNFIGHFCKGN -= Input.GetAxis("wedge") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1138f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1943f, 610f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void CKKHPOFHEHG()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("Failed to clear Discord Presence!") * xSpeed * distance * 993f;
			FGDPPDPMCOK -= Input.GetAxis("Discord RPC: Clearing activity") * ySpeed * 1942f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = MEGPCCKJOLE(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 588f);
		CNFIGHFCKGN -= Input.GetAxis(">") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 682f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1602f, 415f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void BDDCPDIOFGK()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("length of path 1:") * xSpeed * distance * 447f;
			FGDPPDPMCOK -= Input.GetAxis("gameObject:null") * ySpeed * 1626f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = NFDJKCGNGIP(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 309f);
		CNFIGHFCKGN -= Input.GetAxis("ip_address") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1702f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1169f, 187f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void PJFNNIMPBHF()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("rotateExample") * xSpeed * distance * 1838f;
			FGDPPDPMCOK -= Input.GetAxis("Prefabs/") * ySpeed * 1483f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = LCFDBINKOON(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1614f);
		CNFIGHFCKGN -= Input.GetAxis("LeanAudio has reached it's processing cap. To avoid this error increase the number of iterations ex: LeanAudio.PROCESSING_ITERATIONS_MAX = ") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 66f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1684f, 56f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void EJIOPMOFHKP()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("Smoothed y:") * xSpeed * distance * 1995f;
			FGDPPDPMCOK -= Input.GetAxis("ROTATE AROUND") * ySpeed * 1619f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = CMAJKBICLHH(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1724f);
		CNFIGHFCKGN -= Input.GetAxis("name:") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1553f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(43f, 1582f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void DDNGKHHMHKK()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("Mouse ScrollWheel") * xSpeed * distance * 1471f;
			FGDPPDPMCOK -= Input.GetAxis("creator") * ySpeed * 1662f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = JGNKNPAEJIA(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 955f);
		CNFIGHFCKGN -= Input.GetAxis("rotateExample") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 535f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1479f, 609f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	public static float OFBKPNAFJON(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 1618f)
		{
			IEFCCFPGDMI += 1120f;
		}
		if (IEFCCFPGDMI > 515f)
		{
			IEFCCFPGDMI -= 66f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void DDANFAJJNPI()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	private void CIGDEIMBKLF()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("Horizontal") * xSpeed * distance * 1085f;
			FGDPPDPMCOK -= Input.GetAxis("scale") * ySpeed * 1173f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = KPNNIEHFMIB(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1937f);
		CNFIGHFCKGN -= Input.GetAxis(" color:") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1159f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1654f, 1174f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void PBLLLOPLJOC()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("LCharacter") * xSpeed * distance * 1176f;
			FGDPPDPMCOK -= Input.GetAxis("SOMETHING IS TWEENING") * ySpeed * 1819f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = NFDJKCGNGIP(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1332f);
		CNFIGHFCKGN -= Input.GetAxis("Mouse ScrollWheel") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1007f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(400f, 825f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void NDBHMPBBOEB()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("id") * xSpeed * distance * 1745f;
			FGDPPDPMCOK -= Input.GetAxis("Part") * ySpeed * 1105f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = MHKBMNKBJLC(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 947f);
		CNFIGHFCKGN -= Input.GetAxis("pants") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 844f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(444f, 1408f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void NFMIBBHIBJO()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("server_token") * xSpeed * distance * 1650f;
			FGDPPDPMCOK -= Input.GetAxis("Failed to set presence.") * ySpeed * 706f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = JGNKNPAEJIA(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 862f);
		CNFIGHFCKGN -= Input.GetAxis("rotateAroundExample") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 623f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(569f, 979f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void OANKFADPICG()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("rotateExample") * xSpeed * distance * 965f;
			FGDPPDPMCOK -= Input.GetAxis(" beforeX:") * ySpeed * 1660f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = PJNGIKIALHI(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 939f);
		CNFIGHFCKGN -= Input.GetAxis("Cube1") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1937f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1661f, 1269f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void BDAPHBBPLBB()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("yo") * xSpeed * distance * 542f;
			FGDPPDPMCOK -= Input.GetAxis("Fire") * ySpeed * 1277f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = IPNGBHLDHKA(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 846f);
		CNFIGHFCKGN -= Input.GetAxis("</b>") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 239f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(445f, 1853f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void BINPDOFJLNK()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	private void OPMEGCJJNLC()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = true;
		}
	}

	private void CDJBDJKCMLJ()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = true;
		}
	}

	private void PJDPBBNKMFH()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("Flip Tile") * xSpeed * distance * 487f;
			FGDPPDPMCOK -= Input.GetAxis("_Color") * ySpeed * 565f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = CMAJKBICLHH(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1672f);
		CNFIGHFCKGN -= Input.GetAxis("arguments: ") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 294f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1339f, 383f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	public static float JIBMGAJAPML(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 736f)
		{
			IEFCCFPGDMI += 729f;
		}
		if (IEFCCFPGDMI > 740f)
		{
			IEFCCFPGDMI -= 542f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	public static float FKGDICHKNAG(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 1120f)
		{
			IEFCCFPGDMI += 1971f;
		}
		if (IEFCCFPGDMI > 921f)
		{
			IEFCCFPGDMI -= 1636f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	public static float NEAHKDPGPPP(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 366f)
		{
			IEFCCFPGDMI += 552f;
		}
		if (IEFCCFPGDMI > 103f)
		{
			IEFCCFPGDMI -= 218f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void CJKLMAPOJBJ()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis(" bx:") * xSpeed * distance * 929f;
			FGDPPDPMCOK -= Input.GetAxis("LCharacter") * ySpeed * 1892f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = MEGPCCKJOLE(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1263f);
		CNFIGHFCKGN -= Input.GetAxis("Mouse Y") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1512f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(494f, 1192f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	public static float GEFFMPDLKAB(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 207f)
		{
			IEFCCFPGDMI += 820f;
		}
		if (IEFCCFPGDMI > 832f)
		{
			IEFCCFPGDMI -= 377f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void PELEFHJHKBI()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	private void DONBEMLJIFH()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = true;
		}
	}

	public static float MEGPCCKJOLE(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 1235f)
		{
			IEFCCFPGDMI += 621f;
		}
		if (IEFCCFPGDMI > 626f)
		{
			IEFCCFPGDMI -= 1534f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void EFBPFCPDFMM()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("endless") * xSpeed * distance * 1668f;
			FGDPPDPMCOK -= Input.GetAxis("RPC RpcSendChatMessageToClient called on server.") * ySpeed * 1844f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = ClampAngle(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 739f);
		CNFIGHFCKGN -= Input.GetAxis("expected rotate z:") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1472f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(675f, 1117f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void KIMKEHNABCD()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = true;
		}
	}

	public static float MHKBMNKBJLC(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 1158f)
		{
			IEFCCFPGDMI += 1610f;
		}
		if (IEFCCFPGDMI > 1832f)
		{
			IEFCCFPGDMI -= 1651f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void AJKHKJOIAOO()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	private void LKNHKLDCNBA()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("delayed call:") * xSpeed * distance * 790f;
			FGDPPDPMCOK -= Input.GetAxis("scale punch!") * ySpeed * 1968f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = NFDJKCGNGIP(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 978f);
		CNFIGHFCKGN -= Input.GetAxis("host:") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 791f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1836f, 186f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void GLCHNIGCDHB()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("mp_auth") * xSpeed * distance * 1096f;
			FGDPPDPMCOK -= Input.GetAxis("yo") * ySpeed * 1296f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = FLHJECGGDLK(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1000f);
		CNFIGHFCKGN -= Input.GetAxis("WaterFilled") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 561f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(962f, 497f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void NKHNFBMBCPP()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	public static float OOJLENLEHBI(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 1521f)
		{
			IEFCCFPGDMI += 1064f;
		}
		if (IEFCCFPGDMI > 1760f)
		{
			IEFCCFPGDMI -= 432f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void AGGGDGOCILA()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("cubeDestroy") * xSpeed * distance * 1207f;
			FGDPPDPMCOK -= Input.GetAxis("plr_container") * ySpeed * 285f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = NDPOKHMNCOP(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 183f);
		CNFIGHFCKGN -= Input.GetAxis("shirt") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1717f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(11f, 115f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void JAJHOFLCBON()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("<") * xSpeed * distance * 1293f;
			FGDPPDPMCOK -= Input.GetAxis("OBJECT NOT TWEEENING AT BEGINNING") * ySpeed * 1932f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = CMAJKBICLHH(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 407f);
		CNFIGHFCKGN -= Input.GetAxis("current_game_playing") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1081f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1997f, 1292f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void JGKGCJBIJIP()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	private void KKFPEKEMMFN()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("Waiting") * xSpeed * distance * 1691f;
			FGDPPDPMCOK -= Input.GetAxis("Rotate") * ySpeed * 649f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = FGOFNKEBDHE(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1061f);
		CNFIGHFCKGN -= Input.GetAxis(" returned:") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1938f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(364f, 1875f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void FNDLHGKEAME()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("DELAYED SOUND") * xSpeed * distance * 1760f;
			FGDPPDPMCOK -= Input.GetAxis("Generated Audio") * ySpeed * 1521f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = CLDHOBFOEKK(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 854f);
		CNFIGHFCKGN -= Input.GetAxis("WE CAN RETRIEVE A DESCRIPTION") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1904f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(530f, 1933f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void IOJCPGBLDNK()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = true;
		}
	}

	private void DFOOJOGACAF()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("\nConnecting to network address: ") * xSpeed * distance * 963f;
			FGDPPDPMCOK -= Input.GetAxis("exported curve:") * ySpeed * 1555f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = NEAHKDPGPPP(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1465f);
		CNFIGHFCKGN -= Input.GetAxis("") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 467f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(365f, 1593f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	public static float NFDJKCGNGIP(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 215f)
		{
			IEFCCFPGDMI += 325f;
		}
		if (IEFCCFPGDMI > 1077f)
		{
			IEFCCFPGDMI -= 1103f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	public static float HHAMEGKNDCM(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 566f)
		{
			IEFCCFPGDMI += 36f;
		}
		if (IEFCCFPGDMI > 15f)
		{
			IEFCCFPGDMI -= 1812f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void GHLLAOBKMHL()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("scaleExample") * xSpeed * distance * 20f;
			FGDPPDPMCOK -= Input.GetAxis("moveLocalExample") * ySpeed * 681f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = JGNKNPAEJIA(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 1120f);
		CNFIGHFCKGN -= Input.GetAxis("rotateExample") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1275f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(755f, 220f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void JEDBEELLACK()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}

	private void FLGMDCCIJKJ()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = true;
		}
	}

	public static float FLHJECGGDLK(float IEFCCFPGDMI, float PJENJPHHKFA, float GHLCKPPENNF)
	{
		if (IEFCCFPGDMI < 657f)
		{
			IEFCCFPGDMI += 1652f;
		}
		if (IEFCCFPGDMI > 623f)
		{
			IEFCCFPGDMI -= 938f;
		}
		return Mathf.Clamp(IEFCCFPGDMI, PJENJPHHKFA, GHLCKPPENNF);
	}

	private void LateUpdate()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(1) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("Mouse X") * xSpeed * distance * 0.02f;
			FGDPPDPMCOK -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = ClampAngle(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 0f);
		CNFIGHFCKGN -= Input.GetAxis("Mouse ScrollWheel") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 0.1f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(0f, 0f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void OHMHNBLKIBO()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("Button not assigned! Create a new button via Hierarchy->Create->UI->Button. Then assign it to the button variable") * xSpeed * distance * 1667f;
			FGDPPDPMCOK -= Input.GetAxis("onStartPos:") * ySpeed * 24f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = PJNGIKIALHI(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 672f);
		CNFIGHFCKGN -= Input.GetAxis("Part") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 114f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(1641f, 526f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void IEPODNLMIAM()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("OBJECT NOT TWEEENING AT BEGINNING") * xSpeed * distance * 1180f;
			FGDPPDPMCOK -= Input.GetAxis("chat_color") * ySpeed * 1933f;
			BMDFHEHKMFM = false;
		}
		FGDPPDPMCOK = NEAHKDPGPPP(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 204f);
		CNFIGHFCKGN -= Input.GetAxis("cancel variable time") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1713f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(289f, 704f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void ALGDMOPCCBC()
	{
		if (!target)
		{
			return;
		}
		if (Input.GetMouseButton(0) || BMDFHEHKMFM)
		{
			CJHOHKKLFDF += Input.GetAxis("rotateAroundExample") * xSpeed * distance * 1241f;
			FGDPPDPMCOK -= Input.GetAxis("By <b>") * ySpeed * 1159f;
			BMDFHEHKMFM = true;
		}
		FGDPPDPMCOK = CMAJKBICLHH(FGDPPDPMCOK, yMinLimit, yMaxLimit);
		Quaternion rotation = Quaternion.Euler(FGDPPDPMCOK, CJHOHKKLFDF, 707f);
		CNFIGHFCKGN -= Input.GetAxis("moveLocalExample") * scrollSensitivity;
		if (CNFIGHFCKGN > maxDist)
		{
			CNFIGHFCKGN = maxDist;
		}
		if (CNFIGHFCKGN < minDist)
		{
			CNFIGHFCKGN = minDist;
		}
		if (!clipThroughWalls)
		{
			if (Physics.Linecast(target.position, base.transform.position - base.transform.forward, out RaycastHit hitInfo))
			{
				if (hitInfo.distance < CNFIGHFCKGN)
				{
					distance = hitInfo.distance + 1850f;
				}
				else
				{
					distance = CNFIGHFCKGN;
				}
			}
			else
			{
				distance = CNFIGHFCKGN;
			}
		}
		Vector3 point = new Vector3(674f, 1984f, 0f - distance);
		Vector3 position = rotation * point + target.position;
		base.transform.rotation = rotation;
		base.transform.position = position;
	}

	private void FFONODKBHGM()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = true;
		}
	}

	private void AJLGLIJDIAK()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		CJHOHKKLFDF = eulerAngles.y;
		FGDPPDPMCOK = eulerAngles.x;
		OFLKPDJDBGD = GetComponent<Rigidbody>();
		if (OFLKPDJDBGD != null)
		{
			OFLKPDJDBGD.freezeRotation = false;
		}
	}
}
