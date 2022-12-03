// FreeCam
using UnityEngine;

public class FreeCam : MonoBehaviour
{
	public float movementSpeed = 10f;

	public float fastMovementSpeed = 100f;

	public float freeLookSensitivity = 3f;

	public float zoomSensitivity = 10f;

	public float fastZoomSensitivity = 50f;

	private bool GJCMGGBIDHC;

	private void OMENECJLIBM()
	{
		OFFDLPOEHJD();
	}

	private void BDMEFOKKKPN()
	{
		NICLMLKJPKJ();
	}

	public void ENNFPIAGAKA()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void PKGLEKBHHPO()
	{
		GKKDEPBBCJN();
	}

	private void HFMOPLBNNPO()
	{
		bool flag = Input.GetKey((KeyCode)(-58)) || Input.GetKey((KeyCode)(-118));
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)(-36)) || Input.GetKey((KeyCode)(-35)))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-31)) || Input.GetKey((KeyCode)(-143)))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-35)) || Input.GetKey((KeyCode)(-174)))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-101)) || Input.GetKey((KeyCode)(-81)))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightCurlyBracket))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.L))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-63)) || Input.GetKey((KeyCode)(-64)))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Alpha7) || Input.GetKey((KeyCode)199))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("Flip Tile") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("port") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 758f);
		}
		float axis = Input.GetAxis("ChatInput");
		if (axis != 595f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)185))
		{
			AJOFHEHBBBK();
		}
		else if (Input.GetKeyUp((KeyCode)(-50)))
		{
			BEKMBNHDONO();
		}
	}

	private void PEDIPAEOKGO()
	{
		bool flag = Input.GetKey(KeyCode.Semicolon) || Input.GetKey((KeyCode)(-16));
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey(KeyCode.Asterisk) || Input.GetKey(KeyCode.Question))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-10)) || Input.GetKey((KeyCode)(-62)))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-58)) || Input.GetKey(KeyCode.Y))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Percent) || Input.GetKey((KeyCode)(-156)))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Question))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-58)))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-31)) || Input.GetKey((KeyCode)(-115)))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)3) || Input.GetKey((KeyCode)(-20)))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("expect pause count of 0, but got ") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("go") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 86f);
		}
		float axis = Input.GetAxis("pos x:");
		if (axis != 1573f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)(-134)))
		{
			BKAOMOHKILO();
		}
		else if (Input.GetKeyUp((KeyCode)(-155)))
		{
			GKKDEPBBCJN();
		}
	}

	private void PPEDNLOJBBN()
	{
		NICLMLKJPKJ();
	}

	private void JNEEKFHGOPN()
	{
		JEIFAKIMCOH();
	}

	public void MMLHDMOJCJH()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	private void LLJHEFBJCCB()
	{
		bool flag = Input.GetKey((KeyCode)24) || Input.GetKey(KeyCode.B);
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)(-35)) || Input.GetKey((KeyCode)(-178)))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)86) || Input.GetKey((KeyCode)(-167)))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-117)) || Input.GetKey((KeyCode)(-124)))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DoubleQuote) || Input.GetKey(KeyCode.Delete))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-30)))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)73))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-20)) || Input.GetKey((KeyCode)(-108)))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.N) || Input.GetKey((KeyCode)71))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("https://superium.net/assets/catalog/") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("ui_HealthAmount") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 10f);
		}
		float axis = Input.GetAxis("Connecting to port: ");
		if (axis != 291f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)(-18)))
		{
			NEENMIHKKJM();
		}
		else if (Input.GetKeyUp((KeyCode)(-198)))
		{
			EHCPPLAAHGJ();
		}
	}

	public void StopLooking()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	public void GMMBIEODPMM()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void NICLMLKJPKJ()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.None;
	}

	public void PFJMFBJCJGE()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void LFBLCOANKMM()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	public void EMINGLNFHHG()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.None;
	}

	public void JDAFHNEHBNF()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void BKAOMOHKILO()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	private void LFBEPFCLIAM()
	{
		OJEFMOOBOIG();
	}

	private void DIGKHHACCEI()
	{
		NAPNNAHGBBC();
	}

	public void JDHKFMGIOCH()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	private void GHGHOBLIHIN()
	{
		OFFDLPOEHJD();
	}

	public void MDGOMFLPPNM()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.None;
	}

	private void OnDisable()
	{
		StopLooking();
	}

	public void AEACHKDPDHA()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void PKFNPPNDDJC()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void PBAMIECMELI()
	{
		BEKMBNHDONO();
	}

	public void NDHMALBGFCK()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	public void AIPEJJIOPEE()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.None;
	}

	private void PIALDILNOCC()
	{
		NDHMALBGFCK();
	}

	private void BGHIFCGKDPE()
	{
		bool flag = !Input.GetKey((KeyCode)167) && Input.GetKey(KeyCode.D);
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)18) || Input.GetKey((KeyCode)78))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-47)) || Input.GetKey((KeyCode)4))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-44)) || Input.GetKey((KeyCode)(-115)))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Clear) || Input.GetKey((KeyCode)(-115)))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.T))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-118)))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Q) || Input.GetKey((KeyCode)(-53)))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-115)) || Input.GetKey((KeyCode)28))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("By <b>") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis(" times") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 1452f);
		}
		float axis = Input.GetAxis(" - ");
		if (axis != 1013f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)82))
		{
			GMMBIEODPMM();
		}
		else if (Input.GetKeyUp((KeyCode)(-24)))
		{
			JDHKFMGIOCH();
		}
	}

	public void KNHJGCDPJAA()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void IBFHEIJAOGK()
	{
		bool flag = Input.GetKey((KeyCode)(-149)) || Input.GetKey((KeyCode)135);
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey(KeyCode.Plus) || Input.GetKey((KeyCode)(-125)))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-9)) || Input.GetKey((KeyCode)(-8)))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Pause) || Input.GetKey((KeyCode)(-118)))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-117)) || Input.GetKey((KeyCode)(-114)))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.I))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.J))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.G) || Input.GetKey((KeyCode)29))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("ignoreTimeScale") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("&c=") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 1756f);
		}
		float axis = Input.GetAxis("SpawnLocation");
		if (axis != 1501f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)(-118)))
		{
			KNHJGCDPJAA();
		}
		else if (Input.GetKeyUp(KeyCode.I))
		{
			JEIFAKIMCOH();
		}
	}

	public void MBOLONJEHLG()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.None;
	}

	private void PMIDBDFNAID()
	{
		bool flag = Input.GetKey((KeyCode)(-182)) || Input.GetKey(KeyCode.Clear);
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)72) || Input.GetKey((KeyCode)(-52)))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Quote) || Input.GetKey((KeyCode)(-107)))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-82)) || Input.GetKey((KeyCode)131))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)74) || Input.GetKey((KeyCode)(-165)))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.O))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-63)))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-126)) || Input.GetKey((KeyCode)(-33)))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)68) || Input.GetKey((KeyCode)(-111)))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis(" but got ") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("gameObject:null") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 1388f);
		}
		float axis = Input.GetAxis("Smoothed y:");
		if (axis != 324f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)29))
		{
			StartLooking();
		}
		else if (Input.GetKeyUp((KeyCode)(-78)))
		{
			NICLMLKJPKJ();
		}
	}

	private void PGPPIGGMLBE()
	{
		NICLMLKJPKJ();
	}

	private void CCDEAJBLODD()
	{
		JDHKFMGIOCH();
	}

	private void GLECMKJEAHB()
	{
		bool flag = Input.GetKey(KeyCode.None) || Input.GetKey(KeyCode.Alpha5);
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)(-127)) || Input.GetKey((KeyCode)18))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)15) || Input.GetKey((KeyCode)(-110)))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)2) || Input.GetKey((KeyCode)15))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-91)) || Input.GetKey((KeyCode)181))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-27)))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)31))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)72) || Input.GetKey((KeyCode)(-7)))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.U) || Input.GetKey((KeyCode)(-34)))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("EaseInOutQuint") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("chat_color") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 1653f);
		}
		float axis = Input.GetAxis(" by:");
		if (axis != 1190f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)170))
		{
			ENNFPIAGAKA();
		}
		else if (Input.GetKeyUp((KeyCode)26))
		{
			KAHFGHLAADI();
		}
	}

	public void OFFDLPOEHJD()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void EJEPCBINHMB()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.None;
	}

	public void OMHMINLKCMC()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void NEENMIHKKJM()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void JGNKMNNHFLO()
	{
		bool flag = Input.GetKey((KeyCode)(-53)) || Input.GetKey((KeyCode)(-48));
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey(KeyCode.Backspace) || Input.GetKey((KeyCode)(-18)))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftParen) || Input.GetKey((KeyCode)166))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)4) || Input.GetKey((KeyCode)135))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-122)) || Input.GetKey((KeyCode)86))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-113)))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-97)))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-20)) || Input.GetKey(KeyCode.O))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-118)) || Input.GetKey((KeyCode)133))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("You ran out of areas to add listeners, consider increasing LISTENERS_MAX, ex: LeanTween.LISTENERS_MAX = ") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("LCharacter") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 838f);
		}
		float axis = Input.GetAxis("error this function is no longer used");
		if (axis != 33f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)(-153)))
		{
			MDGOMFLPPNM();
		}
		else if (Input.GetKeyUp((KeyCode)30))
		{
			GKKDEPBBCJN();
		}
	}

	private void CMKLLDPHOEL()
	{
		bool flag = Input.GetKey((KeyCode)(-165)) || Input.GetKey((KeyCode)(-81));
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey(KeyCode.Pause) || Input.GetKey((KeyCode)(-57)))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-125)) || Input.GetKey((KeyCode)73))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-119)) || Input.GetKey((KeyCode)(-24)))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Asterisk) || Input.GetKey((KeyCode)(-46)))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-43)))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-25)))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)78) || Input.GetKey((KeyCode)(-120)))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-41)) || Input.GetKey((KeyCode)(-55)))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("creator") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("_TintColor") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 1814f);
		}
		float axis = Input.GetAxis("NOTHING TWEEENING AT BEGINNING");
		if (axis != 1349f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)167))
		{
			NHFEPHDJEHO();
		}
		else if (Input.GetKeyUp((KeyCode)(-38)))
		{
			FNMMKFENCAB();
		}
	}

	private void AINGHHEFDAN()
	{
		JDHKFMGIOCH();
	}

	private void BFADADBGNOP()
	{
		bool flag = !Input.GetKey((KeyCode)(-84)) && Input.GetKey((KeyCode)162);
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)(-116)) || Input.GetKey((KeyCode)7))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-23)) || Input.GetKey((KeyCode)(-182)))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)30) || Input.GetKey((KeyCode)(-38)))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Escape) || Input.GetKey((KeyCode)(-193)))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.V))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.At))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)90) || Input.GetKey(KeyCode.Return))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)7) || Input.GetKey((KeyCode)167))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("Cancelled download") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("EaseAnimationCurve") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 1961f);
		}
		float axis = Input.GetAxis("PlaceID");
		if (axis != 331f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)(-63)))
		{
			StartLooking();
		}
		else if (Input.GetKeyUp(KeyCode.Alpha7))
		{
			JDAFHNEHBNF();
		}
	}

	public void NAPNNAHGBBC()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	public void AJOFHEHBBBK()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.None;
	}

	private void OAECMNAMACO()
	{
		JBBJKHKBCIG();
	}

	public void NCHNFIIJEBG()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void NDLNEEKOALD()
	{
		StopLooking();
	}

	private void BKIJMGLOHHI()
	{
		AEACHKDPDHA();
	}

	public void KNMFGNLPEKI()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void OMHIGBOGFJH()
	{
		StopLooking();
	}

	private void HLFGCIBCEAL()
	{
		EJEPCBINHMB();
	}

	private void HBJJIKNDNAK()
	{
		KAHFGHLAADI();
	}

	private void PAKGEDDFILG()
	{
		bool flag = !Input.GetKey((KeyCode)(-156)) && Input.GetKey((KeyCode)(-106));
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)10) || Input.GetKey((KeyCode)159))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Pipe) || Input.GetKey((KeyCode)155))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-38)) || Input.GetKey((KeyCode)172))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-29)) || Input.GetKey((KeyCode)161))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-29)))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)30))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-119)) || Input.GetKey((KeyCode)131))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-57)) || Input.GetKey((KeyCode)131))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("ZERO TIME FINSHES CORRECTLY") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("shirt") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 567f);
		}
		float axis = Input.GetAxis(" ");
		if (axis != 292f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)157))
		{
			NEENMIHKKJM();
		}
		else if (Input.GetKeyUp(KeyCode.Asterisk))
		{
			NDHMALBGFCK();
		}
	}

	public void FNMMKFENCAB()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void GBJBENDBPPP()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.None;
	}

	private void GACJDKGEKEJ()
	{
		bool flag = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.None);
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)(-2)) || Input.GetKey(KeyCode.None))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-7)) || Input.GetKey((KeyCode)133))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-86)) || Input.GetKey((KeyCode)(-27)))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)29) || Input.GetKey((KeyCode)(-152)))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)68))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)4))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)7) || Input.GetKey((KeyCode)2))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-14)) || Input.GetKey(KeyCode.Pause))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("moving") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("rotateFinished hash:") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 1154f);
		}
		float axis = Input.GetAxis("LCharacter");
		if (axis != 1740f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			PFJMFBJCJGE();
		}
		else if (Input.GetKeyUp((KeyCode)24))
		{
			StopLooking();
		}
	}

	public void FBKKIMHFFME()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void MCAOPIPBHAO()
	{
		bool flag = Input.GetKey((KeyCode)67) || Input.GetKey((KeyCode)(-36));
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)(-12)) || Input.GetKey((KeyCode)(-184)))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)11) || Input.GetKey(KeyCode.LeftParen))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Clear) || Input.GetKey(KeyCode.Alpha5))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)69) || Input.GetKey((KeyCode)(-4)))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-86)))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Alpha9))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-32)) || Input.GetKey(KeyCode.Alpha7))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-125)) || Input.GetKey((KeyCode)(-12)))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("https://superium.net/api/GetCharacterAppearanceById?id=") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("ax:") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 1368f);
		}
		float axis = Input.GetAxis("bSpline");
		if (axis != 1596f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown(KeyCode.Question))
		{
			FBKKIMHFFME();
		}
		else if (Input.GetKeyUp((KeyCode)(-104)))
		{
			KAHFGHLAADI();
		}
	}

	public void JEIFAKIMCOH()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void LKOHDOLFHAO()
	{
		OFFDLPOEHJD();
	}

	private void FBFFPNNHADM()
	{
		EJEPCBINHMB();
	}

	private void OFAGDFKNCNL()
	{
		bool flag = Input.GetKey((KeyCode)(-102)) || Input.GetKey((KeyCode)177);
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)(-84)) || Input.GetKey((KeyCode)(-112)))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-114)) || Input.GetKey(KeyCode.Underscore))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftParen) || Input.GetKey((KeyCode)67))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-116)) || Input.GetKey(KeyCode.Percent))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Colon))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-4)))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)22) || Input.GetKey((KeyCode)(-61)))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Clear) || Input.GetKey((KeyCode)180))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("ui_ResetCharacterBtn") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("_") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 754f);
		}
		float axis = Input.GetAxis("Playing as ");
		if (axis != 1922f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)(-65)))
		{
			AIPEJJIOPEE();
		}
		else if (Input.GetKeyUp(KeyCode.LeftBracket))
		{
			StopLooking();
		}
	}

	public void OEEBDONEPEN()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.None;
	}

	public void BEKMBNHDONO()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void OJEFMOOBOIG()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void GKKDEPBBCJN()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void KAHFGHLAADI()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	private void KKFIGKBFLLC()
	{
		CELGHHPFLOK();
	}

	private void ICALPAGEIDN()
	{
		bool flag = Input.GetKey((KeyCode)182) || Input.GetKey(KeyCode.Greater);
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)(-126)) || Input.GetKey(KeyCode.Pause))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-104)) || Input.GetKey((KeyCode)(-89)))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightBracket) || Input.GetKey((KeyCode)(-144)))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)72) || Input.GetKey((KeyCode)171))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Comma))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Colon))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)70) || Input.GetKey((KeyCode)(-198)))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)83) || Input.GetKey((KeyCode)166))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("EaseInQuart") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 1208f);
		}
		float axis = Input.GetAxis("expected ");
		if (axis != 1153f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)(-197)))
		{
			NHFEPHDJEHO();
		}
		else if (Input.GetKeyUp((KeyCode)198))
		{
			NDHMALBGFCK();
		}
	}

	private void PEIIGOHMMNE()
	{
		bool flag = Input.GetKey((KeyCode)(-29)) || Input.GetKey((KeyCode)(-59));
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)29) || Input.GetKey((KeyCode)(-74)))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-11)) || Input.GetKey((KeyCode)164))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-20)) || Input.GetKey((KeyCode)179))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)10) || Input.GetKey((KeyCode)(-191)))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-17)))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Alpha7))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-111)) || Input.GetKey((KeyCode)(-46)))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)28) || Input.GetKey((KeyCode)173))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("Sphere1") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("move x:") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 287f);
		}
		float axis = Input.GetAxis("moveLocalExample");
		if (axis != 37f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown(KeyCode.Less))
		{
			BKAOMOHKILO();
		}
		else if (Input.GetKeyUp((KeyCode)(-60)))
		{
			JDAFHNEHBNF();
		}
	}

	private void KDLBMDMEEHO()
	{
		KNMFGNLPEKI();
	}

	public void LHOFNGCAEBN()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void AFKPJCMLMDP()
	{
		bool flag = !Input.GetKey((KeyCode)(-174)) && Input.GetKey((KeyCode)192);
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)(-21)) || Input.GetKey((KeyCode)89))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-96)) || Input.GetKey((KeyCode)182))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Alpha4) || Input.GetKey((KeyCode)(-177)))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Escape) || Input.GetKey((KeyCode)14))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-11)))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.P) || Input.GetKey((KeyCode)(-139)))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-31)) || Input.GetKey(KeyCode.Alpha1))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("maxSearch:") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("yo") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 1882f);
		}
		float axis = Input.GetAxis("Character");
		if (axis != 1912f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			EMINGLNFHHG();
		}
		else if (Input.GetKeyUp((KeyCode)(-120)))
		{
			JDHKFMGIOCH();
		}
	}

	private void NCHMENOKLGE()
	{
		bool flag = Input.GetKey((KeyCode)(-113)) || Input.GetKey(KeyCode.Alpha5);
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)87) || Input.GetKey((KeyCode)160))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-45)) || Input.GetKey((KeyCode)(-161)))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)75) || Input.GetKey((KeyCode)163))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-26)) || Input.GetKey(KeyCode.Question))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Pause))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)79))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)89) || Input.GetKey(KeyCode.Ampersand))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Exclaim) || Input.GetKey(KeyCode.O))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("ChatInput") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("game:") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 1134f);
		}
		float axis = Input.GetAxis("WedgePart");
		if (axis != 1131f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)(-41)))
		{
			AIPEJJIOPEE();
		}
		else if (Input.GetKeyUp((KeyCode)(-48)))
		{
			AEACHKDPDHA();
		}
	}

	private void BGOBIEPAPCI()
	{
		bool flag = Input.GetKey((KeyCode)(-155)) || Input.GetKey((KeyCode)73);
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)(-97)) || Input.GetKey((KeyCode)(-17)))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-20)) || Input.GetKey((KeyCode)196))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.X) || Input.GetKey(KeyCode.Comma))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)75) || Input.GetKey(KeyCode.Alpha8))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Alpha4))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Exclaim))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.R) || Input.GetKey((KeyCode)81))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.B) || Input.GetKey((KeyCode)185))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis(" ") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("Playing as ") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 121f);
		}
		float axis = Input.GetAxis(" y:");
		if (axis != 181f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)(-39)))
		{
			NEENMIHKKJM();
		}
		else if (Input.GetKeyUp((KeyCode)(-167)))
		{
			OJEFMOOBOIG();
		}
	}

	public void NHFEPHDJEHO()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void Update()
	{
		bool flag = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Q))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.E))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.R) || Input.GetKey(KeyCode.PageUp))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.F) || Input.GetKey(KeyCode.PageDown))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("Mouse X") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 0f);
		}
		float axis = Input.GetAxis("Mouse ScrollWheel");
		if (axis != 0f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown(KeyCode.Mouse1))
		{
			StartLooking();
		}
		else if (Input.GetKeyUp(KeyCode.Mouse1))
		{
			StopLooking();
		}
	}

	private void IGOMLLEBIFH()
	{
		OFFDLPOEHJD();
	}

	private void ECNBDPDDBLL()
	{
		bool flag = Input.GetKey((KeyCode)(-154)) || Input.GetKey((KeyCode)(-174));
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey(KeyCode.Clear) || Input.GetKey((KeyCode)(-79)))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Tilde) || Input.GetKey((KeyCode)185))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Tilde) || Input.GetKey((KeyCode)(-54)))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-107)) || Input.GetKey((KeyCode)146))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-113)))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Backslash))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-11)) || Input.GetKey((KeyCode)(-28)))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-95)) || Input.GetKey((KeyCode)4))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("Wearables") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("ScriptService") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 566f);
		}
		float axis = Input.GetAxis("Prefabs/");
		if (axis != 1387f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)159))
		{
			ENNFPIAGAKA();
		}
		else if (Input.GetKeyUp((KeyCode)(-25)))
		{
			JEIFAKIMCOH();
		}
	}

	private void KGCGIMNGHFM()
	{
		JDHKFMGIOCH();
	}

	public void JBBJKHKBCIG()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	public void StartLooking()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void OOHPLMDCFDJ()
	{
		GJCMGGBIDHC = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.None;
	}

	private void MIEJLECJGLG()
	{
		bool flag = !Input.GetKey((KeyCode)128) && Input.GetKey((KeyCode)(-145));
		float d = flag ? fastMovementSpeed : movementSpeed;
		if (Input.GetKey((KeyCode)(-74)) || Input.GetKey((KeyCode)(-145)))
		{
			base.transform.position = base.transform.position + -base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.H) || Input.GetKey((KeyCode)(-23)))
		{
			base.transform.position = base.transform.position + base.transform.right * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-48)) || Input.GetKey((KeyCode)18))
		{
			base.transform.position = base.transform.position + base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Alpha4) || Input.GetKey((KeyCode)(-196)))
		{
			base.transform.position = base.transform.position + -base.transform.forward * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)6))
		{
			base.transform.position = base.transform.position + base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Q))
		{
			base.transform.position = base.transform.position + -base.transform.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-100)) || Input.GetKey((KeyCode)173))
		{
			base.transform.position = base.transform.position + Vector3.up * d * Time.deltaTime;
		}
		if (Input.GetKey((KeyCode)(-28)) || Input.GetKey((KeyCode)192))
		{
			base.transform.position = base.transform.position + -Vector3.up * d * Time.deltaTime;
		}
		if (GJCMGGBIDHC)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("http://superium.net/api/server/PingServer?S=retard_hacker&p=") * freeLookSensitivity;
			float x = base.transform.localEulerAngles.x - Input.GetAxis("AvatarBig") * freeLookSensitivity;
			base.transform.localEulerAngles = new Vector3(x, y, 1335f);
		}
		float axis = Input.GetAxis("wedge");
		if (axis != 401f)
		{
			float d2 = flag ? fastZoomSensitivity : zoomSensitivity;
			base.transform.position = base.transform.position + base.transform.forward * axis * d2;
		}
		if (Input.GetKeyDown((KeyCode)162))
		{
			FBKKIMHFFME();
		}
		else if (Input.GetKeyUp((KeyCode)82))
		{
			JDHKFMGIOCH();
		}
	}

	private void DHAGDHHEKKP()
	{
		CELGHHPFLOK();
	}

	private void ANMODGFCJLJ()
	{
		MMLHDMOJCJH();
	}

	public void CELGHHPFLOK()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void EHCPPLAAHGJ()
	{
		GJCMGGBIDHC = true;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Locked;
	}
}
