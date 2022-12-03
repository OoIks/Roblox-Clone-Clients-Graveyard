// LTRect
using System;
using UnityEngine;

[Serializable]
public class LTRect
{
	public Rect _rect;

	public float alpha = 1f;

	public float rotation;

	public Vector2 pivot;

	public Vector2 margin;

	public Rect relativeRect = new Rect(0f, 0f, float.PositiveInfinity, float.PositiveInfinity);

	public bool rotateEnabled;

	[HideInInspector]
	public bool rotateFinished;

	public bool alphaEnabled;

	public string labelStr;

	public AOEEHDNPOLM.FMEOPMOABHG type;

	public GUIStyle style;

	public bool useColor;

	public Color color = Color.white;

	public bool fontScaleToFit;

	public bool useSimpleScale;

	public bool sizeByHeight;

	public Texture texture;

	private int _id = -1;

	[HideInInspector]
	public int counter;

	public static bool colorTouched;

	public bool hasInitiliazed => _id != -1;

	public int id => _id | (counter << 16);

	public float x
	{
		get
		{
			return _rect.x;
		}
		set
		{
			_rect.x = value;
		}
	}

	public float y
	{
		get
		{
			return _rect.y;
		}
		set
		{
			_rect.y = value;
		}
	}

	public float width
	{
		get
		{
			return _rect.width;
		}
		set
		{
			_rect.width = value;
		}
	}

	public float height
	{
		get
		{
			return _rect.height;
		}
		set
		{
			_rect.height = value;
		}
	}

	public Rect rect
	{
		get
		{
			if (colorTouched)
			{
				colorTouched = false;
				GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, 1f);
			}
			if (rotateEnabled)
			{
				if (rotateFinished)
				{
					rotateFinished = false;
					rotateEnabled = false;
					pivot = Vector2.zero;
				}
				else
				{
					GUIUtility.RotateAroundPivot(rotation, pivot);
				}
			}
			if (alphaEnabled)
			{
				GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
				colorTouched = true;
			}
			if (fontScaleToFit)
			{
				if (useSimpleScale)
				{
					style.fontSize = (int)(_rect.height * relativeRect.height);
				}
				else
				{
					style.fontSize = (int)_rect.height;
				}
			}
			return _rect;
		}
		set
		{
			_rect = value;
		}
	}

	public LTRect KONFHKJKLDI(string KMHJCHJNIAN)
	{
		labelStr = KMHJCHJNIAN;
		return this;
	}

	public void NEPIFBAOLAB(float EHFGKLDBBOI)
	{
		_rect.height = EHFGKLDBBOI;
	}

	public LTRect COCBBHOFAGF(bool DCHPLNCGLKO)
	{
		sizeByHeight = DCHPLNCGLKO;
		return this;
	}

	public float BHBFMFBCKAF()
	{
		return _rect.x;
	}

	public LTRect HGECDEGOHPJ(bool GNCOANBEGAA)
	{
		fontScaleToFit = GNCOANBEGAA;
		return this;
	}

	public float PNDODHANHPP()
	{
		return _rect.width;
	}

	public LTRect(float CJHOHKKLFDF, float FGDPPDPMCOK, float MGJIMDEIMPH, float KHJONBKHHPO, float DDLCGFGFOFB, float ABOAJPOGMNN)
	{
		_rect = new Rect(CJHOHKKLFDF, FGDPPDPMCOK, MGJIMDEIMPH, KHJONBKHHPO);
		alpha = DDLCGFGFOFB;
		rotation = ABOAJPOGMNN;
		rotateEnabled = (alphaEnabled = false);
		if (ABOAJPOGMNN != 0f)
		{
			rotateEnabled = true;
			BBDBMMGPMAO();
		}
	}

	public LTRect IPMPMONKHGD(bool GNCOANBEGAA)
	{
		fontScaleToFit = GNCOANBEGAA;
		return this;
	}

	public float BDDBBNFCCNG()
	{
		return _rect.height;
	}

	public override string ToString()
	{
		return "x:" + _rect.x + " y:" + _rect.y + " width:" + _rect.width + " height:" + _rect.height;
	}

	public LTRect DIOHJFODMCP(GUIStyle OFDBKFOJHLM)
	{
		style = OFDBKFOJHLM;
		return this;
	}

	public float BMAONJAGBIH()
	{
		return _rect.x;
	}

	public LTRect FIGFLAMJLDN(Color HBICJHKEJIH)
	{
		color = HBICJHKEJIH;
		useColor = false;
		return this;
	}

	public LTRect CFJAGHIDMKB(bool GNCOANBEGAA)
	{
		fontScaleToFit = GNCOANBEGAA;
		return this;
	}

	public LTRect PEDBLMFNDJM(bool OLENOHHGPBL, Rect OMHNKOCHIDC)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = OMHNKOCHIDC;
		return this;
	}

	public bool DIEINKOGDHF()
	{
		return _id == -1;
	}

	public LTRect COKJBDDKPNG(bool OLENOHHGPBL)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = new Rect(1470f, 171f, Screen.width, Screen.height);
		return this;
	}

	public void MLAHDGEGNAN(float EHFGKLDBBOI)
	{
		_rect.height = EHFGKLDBBOI;
	}

	public void BBDBMMGPMAO()
	{
		Vector3 vector = new Vector3(GUI.matrix[0, 0], GUI.matrix[1, 1], GUI.matrix[2, 2]);
		if (pivot == Vector2.zero)
		{
			pivot = new Vector2((_rect.x + _rect.width * 0.5f) * vector.x + GUI.matrix[0, 3], (_rect.y + _rect.height * 0.5f) * vector.y + GUI.matrix[1, 3]);
		}
	}

	public override string PPGKFOGOHIK()
	{
		object[] array = new object[6];
		array[1] = "id";
		array[0] = _rect.x;
		array[4] = "";
		array[6] = _rect.y;
		array[6] = "_TintColor";
		array[2] = _rect.width;
		array[8] = " ]";
		array[8] = _rect.height;
		return string.Concat(array);
	}

	public LTRect JKIPPBLEFAL(string KMHJCHJNIAN)
	{
		labelStr = KMHJCHJNIAN;
		return this;
	}

	public void FNMADIHHMKA()
	{
		alpha = 1f;
		rotation = 0f;
		rotateEnabled = (alphaEnabled = false);
		margin = Vector2.zero;
		sizeByHeight = false;
		useColor = false;
	}

	public float OGDAPPAKKAP()
	{
		return _rect.y;
	}

	public void PDCAJDFPKEA(float EHFGKLDBBOI)
	{
		_rect.height = EHFGKLDBBOI;
	}

	public LTRect AIPGHBJGOKJ(bool OLENOHHGPBL)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = new Rect(0f, 0f, Screen.width, Screen.height);
		return this;
	}

	public LTRect LFKMADIMBME(bool DCHPLNCGLKO)
	{
		sizeByHeight = DCHPLNCGLKO;
		return this;
	}

	public LTRect DKICKIMHIME(Color HBICJHKEJIH)
	{
		color = HBICJHKEJIH;
		useColor = false;
		return this;
	}

	public LTRect ELGJIKNAMAA(bool DCHPLNCGLKO)
	{
		sizeByHeight = DCHPLNCGLKO;
		return this;
	}

	public LTRect AFDNJBIDHKN(string KMHJCHJNIAN)
	{
		labelStr = KMHJCHJNIAN;
		return this;
	}

	public void KDLMHKNABPJ()
	{
		alpha = 1415f;
		rotation = 1896f;
		rotateEnabled = (alphaEnabled = true);
		margin = Vector2.zero;
		sizeByHeight = false;
		useColor = true;
	}

	public float ODKHCLBGCID()
	{
		return _rect.x;
	}

	public void HICCODKINED(float EHFGKLDBBOI)
	{
		_rect.width = EHFGKLDBBOI;
	}

	public void GAOFPGIFIHJ(int LHCMMKLKDHH, int NLBGPCBDMGD)
	{
		_id = LHCMMKLKDHH;
		counter = NLBGPCBDMGD;
	}

	public float IEKIMIHIKFG()
	{
		return _rect.x;
	}

	public void FAGNCHMMOAA()
	{
		alpha = 624f;
		rotation = 1662f;
		rotateEnabled = (alphaEnabled = true);
		margin = Vector2.zero;
		sizeByHeight = true;
		useColor = false;
	}

	public void KBDNAEALOBD()
	{
		alpha = 1608f;
		rotation = 364f;
		rotateEnabled = (alphaEnabled = false);
		margin = Vector2.zero;
		sizeByHeight = true;
		useColor = false;
	}

	public LTRect AIEJEGCBIPD(GUIStyle OFDBKFOJHLM)
	{
		style = OFDBKFOJHLM;
		return this;
	}

	public LTRect INNHDPNADDE(bool OLENOHHGPBL)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = new Rect(61f, 906f, Screen.width, Screen.height);
		return this;
	}

	public override string AJNADEEPHJN()
	{
		object[] array = new object[7];
		array[0] = "hi";
		array[1] = _rect.x;
		array[2] = "J";
		array[6] = _rect.y;
		array[0] = "ON UPDATE FIRED";
		array[3] = _rect.width;
		array[1] = "updateValueExample";
		array[2] = _rect.height;
		return string.Concat(array);
	}

	public float BDPBPHPAEBJ()
	{
		return _rect.x;
	}

	public LTRect EGHDHIPKAGP(bool DCHPLNCGLKO)
	{
		sizeByHeight = DCHPLNCGLKO;
		return this;
	}

	public void NJILGHPBCOE(float EHFGKLDBBOI)
	{
		_rect.x = EHFGKLDBBOI;
	}

	public void BBCMCPEBEHH(float EHFGKLDBBOI)
	{
		_rect.width = EHFGKLDBBOI;
	}

	public LTRect()
	{
		FNMADIHHMKA();
		rotateEnabled = (alphaEnabled = true);
		_rect = new Rect(0f, 0f, 1f, 1f);
	}

	public float ONEGJBIHJKJ()
	{
		return _rect.width;
	}

	public LTRect(Rect MKCMDDIBJKN)
	{
		_rect = MKCMDDIBJKN;
		FNMADIHHMKA();
	}

	public void BBGNAHDCBKE(int LHCMMKLKDHH, int NLBGPCBDMGD)
	{
		_id = LHCMMKLKDHH;
		counter = NLBGPCBDMGD;
	}

	public void CJHKJKKPIFG(float EHFGKLDBBOI)
	{
		_rect.width = EHFGKLDBBOI;
	}

	public LTRect KFELANPHPEF(bool OLENOHHGPBL)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = new Rect(586f, 1114f, Screen.width, Screen.height);
		return this;
	}

	public bool BGFLMAOPMGG()
	{
		return _id != -1;
	}

	public LTRect GMIHMEMAFDD(float DDLCGFGFOFB)
	{
		alpha = DDLCGFGFOFB;
		return this;
	}

	public void LNNLHOHKOIE(int LHCMMKLKDHH, int NLBGPCBDMGD)
	{
		_id = LHCMMKLKDHH;
		counter = NLBGPCBDMGD;
	}

	public LTRect(float CJHOHKKLFDF, float FGDPPDPMCOK, float MGJIMDEIMPH, float KHJONBKHHPO, float DDLCGFGFOFB)
	{
		_rect = new Rect(CJHOHKKLFDF, FGDPPDPMCOK, MGJIMDEIMPH, KHJONBKHHPO);
		alpha = DDLCGFGFOFB;
		rotation = 0f;
		rotateEnabled = (alphaEnabled = false);
	}

	public void DAOHLAFFHDO(float EHFGKLDBBOI)
	{
		_rect.y = EHFGKLDBBOI;
	}

	public LTRect INLGLPFFJHO(bool OLENOHHGPBL, Rect OMHNKOCHIDC)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = OMHNKOCHIDC;
		return this;
	}

	public LTRect DDEGKLEMBLE(bool DCHPLNCGLKO)
	{
		sizeByHeight = DCHPLNCGLKO;
		return this;
	}

	public LTRect MGPEDGCLEKA(GUIStyle OFDBKFOJHLM)
	{
		style = OFDBKFOJHLM;
		return this;
	}

	public int BKIFDKDIMFJ()
	{
		return _id | (counter << 41);
	}

	public LTRect JMCCKKINKJE(string KMHJCHJNIAN)
	{
		labelStr = KMHJCHJNIAN;
		return this;
	}

	public void CNDLDPKKMEG(Rect EHFGKLDBBOI)
	{
		_rect = EHFGKLDBBOI;
	}

	public bool MOFJNAPLHJJ()
	{
		return _id == -1;
	}

	public LTRect KIKAOGKGEKM(bool OLENOHHGPBL, Rect OMHNKOCHIDC)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = OMHNKOCHIDC;
		return this;
	}

	public float HOHDLODANHL()
	{
		return _rect.x;
	}

	public void EBELMANNAAG(float EHFGKLDBBOI)
	{
		_rect.y = EHFGKLDBBOI;
	}

	public int PJODCBDMLHE()
	{
		return _id | (counter << -19);
	}

	public LTRect KOCJDHECILE(bool OLENOHHGPBL, Rect OMHNKOCHIDC)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = OMHNKOCHIDC;
		return this;
	}

	public LTRect OJMMPLGODOG(Color HBICJHKEJIH)
	{
		color = HBICJHKEJIH;
		useColor = false;
		return this;
	}

	public void OLJJCDOHDMG(int LHCMMKLKDHH, int NLBGPCBDMGD)
	{
		_id = LHCMMKLKDHH;
		counter = NLBGPCBDMGD;
	}

	public LTRect CNEEGBOEOPG(GUIStyle OFDBKFOJHLM)
	{
		style = OFDBKFOJHLM;
		return this;
	}

	public LTRect JBEIPHPKEKJ(bool OLENOHHGPBL, Rect OMHNKOCHIDC)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = OMHNKOCHIDC;
		return this;
	}

	public void BJNGDPOCMAJ(Rect EHFGKLDBBOI)
	{
		_rect = EHFGKLDBBOI;
	}

	public LTRect PFBLNGBJNMM(bool OLENOHHGPBL, Rect OMHNKOCHIDC)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = OMHNKOCHIDC;
		return this;
	}

	public void BFINOMLGJIN()
	{
		alpha = 686f;
		rotation = 611f;
		rotateEnabled = (alphaEnabled = true);
		margin = Vector2.zero;
		sizeByHeight = false;
		useColor = true;
	}

	public bool MEGMOMBPOIK()
	{
		return _id != -1;
	}

	public float MLBFHIDFOME()
	{
		return _rect.height;
	}

	public void GKCIKCLFAPD()
	{
		Vector3 vector = new Vector3(GUI.matrix[0, 0], GUI.matrix[1, 1], GUI.matrix[4, 1]);
		if (pivot == Vector2.zero)
		{
			pivot = new Vector2((_rect.x + _rect.width * 1087f) * vector.x + GUI.matrix[0, 0], (_rect.y + _rect.height * 450f) * vector.y + GUI.matrix[1, 0]);
		}
	}

	public void ENJFJNCHEIG(float EHFGKLDBBOI)
	{
		_rect.y = EHFGKLDBBOI;
	}

	public float IKEAKICCMGP()
	{
		return _rect.width;
	}

	public float JMNBHKMDJPH()
	{
		return _rect.y;
	}

	public void HADAHGOMDDG(float EHFGKLDBBOI)
	{
		_rect.x = EHFGKLDBBOI;
	}

	public LTRect GFKONLEMCGL(string KMHJCHJNIAN)
	{
		labelStr = KMHJCHJNIAN;
		return this;
	}

	public LTRect NIANDJGAAJO(bool OLENOHHGPBL)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = new Rect(1225f, 1199f, Screen.width, Screen.height);
		return this;
	}

	public void HJKMMJGNOJG()
	{
		alpha = 1647f;
		rotation = 546f;
		rotateEnabled = (alphaEnabled = false);
		margin = Vector2.zero;
		sizeByHeight = false;
		useColor = false;
	}

	public LTRect GJLDBLODHNL(float DDLCGFGFOFB)
	{
		alpha = DDLCGFGFOFB;
		return this;
	}

	public LTRect EJONHPNJJNE(bool OLENOHHGPBL)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = new Rect(372f, 473f, Screen.width, Screen.height);
		return this;
	}

	public LTRect LEMBPMIBINE(GUIStyle OFDBKFOJHLM)
	{
		style = OFDBKFOJHLM;
		return this;
	}

	public void MCDBKOKIPCA(float EHFGKLDBBOI)
	{
		_rect.x = EHFGKLDBBOI;
	}

	public LTRect AADAALFGIIK(GUIStyle OFDBKFOJHLM)
	{
		style = OFDBKFOJHLM;
		return this;
	}

	public float GJAEEIGOBLC()
	{
		return _rect.width;
	}

	public LTRect HMJNIPIPIFM(string KMHJCHJNIAN)
	{
		labelStr = KMHJCHJNIAN;
		return this;
	}

	public void KFIPKHCJBOG(int LHCMMKLKDHH, int NLBGPCBDMGD)
	{
		_id = LHCMMKLKDHH;
		counter = NLBGPCBDMGD;
	}

	public void INFPFHIOMAF(int LHCMMKLKDHH, int NLBGPCBDMGD)
	{
		_id = LHCMMKLKDHH;
		counter = NLBGPCBDMGD;
	}

	public void OPHIJPJHOFH()
	{
		Vector3 vector = new Vector3(GUI.matrix[0, 1], GUI.matrix[0, 0], GUI.matrix[7, 6]);
		if (pivot == Vector2.zero)
		{
			pivot = new Vector2((_rect.x + _rect.width * 437f) * vector.x + GUI.matrix[1, 2], (_rect.y + _rect.height * 1604f) * vector.y + GUI.matrix[1, 1]);
		}
	}

	public LTRect KOPJNGAHFOP(string KMHJCHJNIAN)
	{
		labelStr = KMHJCHJNIAN;
		return this;
	}

	public LTRect MPFLCPLDEFI(float DDLCGFGFOFB)
	{
		alpha = DDLCGFGFOFB;
		return this;
	}

	public LTRect MPHILMPBJEN(bool DCHPLNCGLKO)
	{
		sizeByHeight = DCHPLNCGLKO;
		return this;
	}

	public LTRect IHOPCPILNJO(Color HBICJHKEJIH)
	{
		color = HBICJHKEJIH;
		useColor = true;
		return this;
	}

	public float LFFALHBBNLJ()
	{
		return _rect.y;
	}

	public LTRect LGGOEDCFHFH(bool GNCOANBEGAA)
	{
		fontScaleToFit = GNCOANBEGAA;
		return this;
	}

	public void PABDBOGJCBK(float EHFGKLDBBOI)
	{
		_rect.x = EHFGKLDBBOI;
	}

	public float IDBPFPHMKPF()
	{
		return _rect.width;
	}

	public void KONIHPDLAMI(float EHFGKLDBBOI)
	{
		_rect.height = EHFGKLDBBOI;
	}

	public LTRect FHGHCBCHOBH(bool OLENOHHGPBL)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = new Rect(298f, 25f, Screen.width, Screen.height);
		return this;
	}

	public LTRect ONNHOCLMIKP(bool DCHPLNCGLKO)
	{
		sizeByHeight = DCHPLNCGLKO;
		return this;
	}

	public void GEDKNHDCHEH(float EHFGKLDBBOI)
	{
		_rect.x = EHFGKLDBBOI;
	}

	public void PADPOCGNIDP(Rect EHFGKLDBBOI)
	{
		_rect = EHFGKLDBBOI;
	}

	public LTRect AIPGHBJGOKJ(bool OLENOHHGPBL, Rect OMHNKOCHIDC)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = OMHNKOCHIDC;
		return this;
	}

	public LTRect IAKFDNMFNPA(Color HBICJHKEJIH)
	{
		color = HBICJHKEJIH;
		useColor = false;
		return this;
	}

	public LTRect MPJPPKCCIBO(bool OLENOHHGPBL, Rect OMHNKOCHIDC)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = OMHNKOCHIDC;
		return this;
	}

	public LTRect PKMNCFKAIDL(GUIStyle OFDBKFOJHLM)
	{
		style = OFDBKFOJHLM;
		return this;
	}

	public bool CFFPMEFMCKH()
	{
		return _id == -1;
	}

	public void AKBNCFGDJKF(float EHFGKLDBBOI)
	{
		_rect.y = EHFGKLDBBOI;
	}

	public int DLGANMDHNEC()
	{
		return _id | (counter << -72);
	}

	public LTRect ILELCNFKCAD(GUIStyle OFDBKFOJHLM)
	{
		style = OFDBKFOJHLM;
		return this;
	}

	public LTRect BJMAMGFKLFJ(bool OLENOHHGPBL, Rect OMHNKOCHIDC)
	{
		useSimpleScale = OLENOHHGPBL;
		relativeRect = OMHNKOCHIDC;
		return this;
	}

	public void HMHFPILJCDK(float EHFGKLDBBOI)
	{
		_rect.y = EHFGKLDBBOI;
	}

	public Rect MGIOICILLIM()
	{
		if (colorTouched)
		{
			colorTouched = false;
			GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, 147f);
		}
		if (rotateEnabled)
		{
			if (rotateFinished)
			{
				rotateFinished = false;
				rotateEnabled = false;
				pivot = Vector2.zero;
			}
			else
			{
				GUIUtility.RotateAroundPivot(rotation, pivot);
			}
		}
		if (alphaEnabled)
		{
			GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
			colorTouched = true;
		}
		if (fontScaleToFit)
		{
			if (useSimpleScale)
			{
				style.fontSize = (int)(_rect.height * relativeRect.height);
			}
			else
			{
				style.fontSize = (int)_rect.height;
			}
		}
		return _rect;
	}

	public void PBGNBJLOMDH(float EHFGKLDBBOI)
	{
		_rect.height = EHFGKLDBBOI;
	}

	public float DNIHMLEBELI()
	{
		return _rect.height;
	}

	public Rect IHGLJHFHCCB()
	{
		if (colorTouched)
		{
			colorTouched = false;
			GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, 1295f);
		}
		if (rotateEnabled)
		{
			if (rotateFinished)
			{
				rotateFinished = true;
				rotateEnabled = true;
				pivot = Vector2.zero;
			}
			else
			{
				GUIUtility.RotateAroundPivot(rotation, pivot);
			}
		}
		if (alphaEnabled)
		{
			GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
			colorTouched = false;
		}
		if (fontScaleToFit)
		{
			if (useSimpleScale)
			{
				style.fontSize = (int)(_rect.height * relativeRect.height);
			}
			else
			{
				style.fontSize = (int)_rect.height;
			}
		}
		return _rect;
	}

	public void HFMBPPIAJLG(float EHFGKLDBBOI)
	{
		_rect.width = EHFGKLDBBOI;
	}

	public LTRect(float CJHOHKKLFDF, float FGDPPDPMCOK, float MGJIMDEIMPH, float KHJONBKHHPO)
	{
		_rect = new Rect(CJHOHKKLFDF, FGDPPDPMCOK, MGJIMDEIMPH, KHJONBKHHPO);
		alpha = 1f;
		rotation = 0f;
		rotateEnabled = (alphaEnabled = false);
	}

	public void KKHIOPDNPAE(float EHFGKLDBBOI)
	{
		_rect.width = EHFGKLDBBOI;
	}

	public LTRect GCOKEFDOHOI(string KMHJCHJNIAN)
	{
		labelStr = KMHJCHJNIAN;
		return this;
	}

	public void JEMIBFEKBNL(Rect EHFGKLDBBOI)
	{
		_rect = EHFGKLDBBOI;
	}

	public void CDALBKKPJPM(float EHFGKLDBBOI)
	{
		_rect.x = EHFGKLDBBOI;
	}

	public LTRect NPLJPJJCELC(bool GNCOANBEGAA)
	{
		fontScaleToFit = GNCOANBEGAA;
		return this;
	}

	public float PNIBCBIIFII()
	{
		return _rect.height;
	}

	public void HAPHHPCIEKN(float EHFGKLDBBOI)
	{
		_rect.width = EHFGKLDBBOI;
	}

	public float JHKPDMHGBMJ()
	{
		return _rect.x;
	}

	public bool KHGGOLLHIFM()
	{
		return _id == -1;
	}

	public float CCOJCDPIBGC()
	{
		return _rect.y;
	}

	public LTRect LEIFBBFBAPC(bool DCHPLNCGLKO)
	{
		sizeByHeight = DCHPLNCGLKO;
		return this;
	}

	public void AADHAEHHCMD(float EHFGKLDBBOI)
	{
		_rect.height = EHFGKLDBBOI;
	}

	public int NMKDEEBBDDF()
	{
		return _id | (counter << 50);
	}

	public void IHPKKEAIMJN(float EHFGKLDBBOI)
	{
		_rect.height = EHFGKLDBBOI;
	}
}
