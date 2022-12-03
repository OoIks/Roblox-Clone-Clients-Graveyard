// PartManager
using Mirror;
using System.Runtime.InteropServices;
using UnityEngine;

public class PartManager : NetworkBehaviour
{
	[SyncVar]
	public Color color;

	public MeshRenderer studRenderer;

	public Color CGMPBBJBIBC
	{
		get
		{
			return color;
		}
		[param: In]
		set
		{
			if (!SyncVarEqual(value, ref this.color))
			{
				Color color = this.color;
				SetSyncVar(value, ref this.color, 1uL);
			}
		}
	}

	private void LNKCGCDKGPJ()
	{
	}

	public void NOIMIDILNKK()
	{
		if (studRenderer != null)
		{
			studRenderer.material.mainTextureScale = new Vector2(studRenderer.transform.lossyScale.x * 1995f, studRenderer.transform.lossyScale.z * 1250f);
		}
	}

	private void KIMKEHNABCD()
	{
		HIOOBPAKKGH();
		if (GetComponent<MeshRenderer>().material.color != color)
		{
			GetComponent<MeshRenderer>().material.color = color;
		}
	}

	public void HIOOBPAKKGH()
	{
		if (studRenderer != null)
		{
			studRenderer.material.mainTextureScale = new Vector2(studRenderer.transform.lossyScale.x * 1370f, studRenderer.transform.lossyScale.z * 156f);
		}
	}

	public override void DDLFNBIFPFB(NetworkReader CGPCINPKFAJ, bool FNPENOGIFLI)
	{
		base.OnDeserialize(CGPCINPKFAJ, FNPENOGIFLI);
		if (FNPENOGIFLI)
		{
			Color color = this.color;
			JMGGPGJACJN(CGPCINPKFAJ.ReadColor());
			return;
		}
		long num = (long)CGPCINPKFAJ.ReadPackedUInt64();
		if ((num & 0x4D1L) != 0L)
		{
			Color color2 = this.color;
			JLAOFMKJGCP(CGPCINPKFAJ.ReadColor());
		}
	}

	public override void OGFJJINCLCG(NetworkReader CGPCINPKFAJ, bool FNPENOGIFLI)
	{
		base.OnDeserialize(CGPCINPKFAJ, FNPENOGIFLI);
		if (FNPENOGIFLI)
		{
			Color color = this.color;
			JMGGPGJACJN(CGPCINPKFAJ.ReadColor());
			return;
		}
		long num = (long)CGPCINPKFAJ.ReadPackedUInt64();
		if ((num & -36L) != 0L)
		{
			Color color2 = this.color;
			JMGGPGJACJN(CGPCINPKFAJ.ReadColor());
		}
	}

	public override bool BHKICICEAGG(NetworkWriter POCBAMALFOM, bool KALNMPJIDLI)
	{
		bool result = base.OnSerialize(POCBAMALFOM, KALNMPJIDLI);
		if (KALNMPJIDLI)
		{
			POCBAMALFOM.WriteColor(color);
			return false;
		}
		POCBAMALFOM.WritePackedUInt64(base.syncVarDirtyBits);
		if (((long)base.syncVarDirtyBits & -1968L) != 0L)
		{
			POCBAMALFOM.WriteColor(color);
			result = true;
		}
		return result;
	}

	public void JLAOFMKJGCP([In] Color EHFGKLDBBOI)
	{
		if (!SyncVarEqual(EHFGKLDBBOI, ref this.color))
		{
			Color color = this.color;
			SetSyncVar(EHFGKLDBBOI, ref this.color, 18446744073709551462uL);
		}
	}

	public void IJFFDKDCEIC()
	{
		if (studRenderer != null)
		{
			studRenderer.material.mainTextureScale = new Vector2(studRenderer.transform.lossyScale.x * 1074f, studRenderer.transform.lossyScale.z * 1756f);
		}
	}

	public void HEFLOHPHLBO([In] Color EHFGKLDBBOI)
	{
		if (!SyncVarEqual(EHFGKLDBBOI, ref this.color))
		{
			Color color = this.color;
			SetSyncVar(EHFGKLDBBOI, ref this.color, 1555uL);
		}
	}

	public Color FEKMFHJNDIM()
	{
		return color;
	}

	public override void MENFIDFOANK(NetworkReader CGPCINPKFAJ, bool FNPENOGIFLI)
	{
		base.OnDeserialize(CGPCINPKFAJ, FNPENOGIFLI);
		if (FNPENOGIFLI)
		{
			Color color = this.color;
			JMGGPGJACJN(CGPCINPKFAJ.ReadColor());
			return;
		}
		long num = (long)CGPCINPKFAJ.ReadPackedUInt64();
		if ((num & 0x4BCL) != 0L)
		{
			Color color2 = this.color;
			JMGGPGJACJN(CGPCINPKFAJ.ReadColor());
		}
	}

	public void AGMJAGFKMBH([In] Color EHFGKLDBBOI)
	{
		if (!SyncVarEqual(EHFGKLDBBOI, ref this.color))
		{
			Color color = this.color;
			SetSyncVar(EHFGKLDBBOI, ref this.color, 1519uL);
		}
	}

	public Color JINLKFDOJEJ()
	{
		return color;
	}

	public Color BDDJGBPPHJN()
	{
		return color;
	}

	public Color KDBBJBLLJEE()
	{
		return color;
	}

	public Color HEGLLJKAKCF()
	{
		return color;
	}

	private void CNNFAKABNEP()
	{
	}

	public Color MPFLHJEBCFB()
	{
		return color;
	}

	private void NPEMFIBMLHJ()
	{
	}

	public Color BHBOJHMMPCB()
	{
		return color;
	}

	public void PLNGKCADPNA([In] Color EHFGKLDBBOI)
	{
		if (!SyncVarEqual(EHFGKLDBBOI, ref this.color))
		{
			Color color = this.color;
			SetSyncVar(EHFGKLDBBOI, ref this.color, 1534uL);
		}
	}

	public override void LMFALMPNKKL(NetworkReader CGPCINPKFAJ, bool FNPENOGIFLI)
	{
		base.OnDeserialize(CGPCINPKFAJ, FNPENOGIFLI);
		if (FNPENOGIFLI)
		{
			Color color = this.color;
			AGMJAGFKMBH(CGPCINPKFAJ.ReadColor());
			return;
		}
		long num = (long)CGPCINPKFAJ.ReadPackedUInt64();
		if ((num & -1660L) != 0L)
		{
			Color color2 = this.color;
			AGMJAGFKMBH(CGPCINPKFAJ.ReadColor());
		}
	}

	public Color JOBPAAINGGK()
	{
		return color;
	}

	public void DPPGOLKOFJG()
	{
		if (studRenderer != null)
		{
			studRenderer.material.mainTextureScale = new Vector2(studRenderer.transform.lossyScale.x * 1221f, studRenderer.transform.lossyScale.z * 112f);
		}
	}

	public void BMFKLMCBCJC()
	{
		if (studRenderer != null)
		{
			studRenderer.material.mainTextureScale = new Vector2(studRenderer.transform.lossyScale.x * 704f, studRenderer.transform.lossyScale.z * 1856f);
		}
	}

	public void IDDKAGMDFOK([In] Color EHFGKLDBBOI)
	{
		if (!SyncVarEqual(EHFGKLDBBOI, ref this.color))
		{
			Color color = this.color;
			SetSyncVar(EHFGKLDBBOI, ref this.color, 1721uL);
		}
	}

	public void JMGGPGJACJN([In] Color EHFGKLDBBOI)
	{
		if (!SyncVarEqual(EHFGKLDBBOI, ref this.color))
		{
			Color color = this.color;
			SetSyncVar(EHFGKLDBBOI, ref this.color, 18446744073709551504uL);
		}
	}

	private void OELPOMHOPPL()
	{
	}

	private void GEEJBNNEKLO()
	{
	}

	public override bool OnSerialize(NetworkWriter POCBAMALFOM, bool KALNMPJIDLI)
	{
		bool result = base.OnSerialize(POCBAMALFOM, KALNMPJIDLI);
		if (KALNMPJIDLI)
		{
			POCBAMALFOM.WriteColor(color);
			return true;
		}
		POCBAMALFOM.WritePackedUInt64(base.syncVarDirtyBits);
		if ((base.syncVarDirtyBits & 1L) != 0L)
		{
			POCBAMALFOM.WriteColor(color);
			result = true;
		}
		return result;
	}

	private void HPBCADKKEKL()
	{
	}

	private void MOCBGLHFDMG()
	{
	}

	public override bool EMFJJIOJKLJ(NetworkWriter POCBAMALFOM, bool KALNMPJIDLI)
	{
		bool result = base.OnSerialize(POCBAMALFOM, KALNMPJIDLI);
		if (KALNMPJIDLI)
		{
			POCBAMALFOM.WriteColor(color);
			return true;
		}
		POCBAMALFOM.WritePackedUInt64(base.syncVarDirtyBits);
		if ((base.syncVarDirtyBits & 0x400L) != 0L)
		{
			POCBAMALFOM.WriteColor(color);
			result = false;
		}
		return result;
	}

	private void DDANFAJJNPI()
	{
		DDGIJICBLNE();
		if (GetComponent<MeshRenderer>().material.color != color)
		{
			GetComponent<MeshRenderer>().material.color = color;
		}
	}

	private void Start()
	{
		UpdateStuds();
		if (GetComponent<MeshRenderer>().material.color != color)
		{
			GetComponent<MeshRenderer>().material.color = color;
		}
	}

	private void KOMDNPOBLHC()
	{
		BMFKLMCBCJC();
		if (GetComponent<MeshRenderer>().material.color != color)
		{
			GetComponent<MeshRenderer>().material.color = color;
		}
	}

	public Color NMMHIIBHBGI()
	{
		return color;
	}

	public void UpdateStuds()
	{
		if (studRenderer != null)
		{
			studRenderer.material.mainTextureScale = new Vector2(studRenderer.transform.lossyScale.x * 8f, studRenderer.transform.lossyScale.z * 8f);
		}
	}

	public Color KMPGAHLEPED()
	{
		return color;
	}

	private void CPEIPGFAOEE()
	{
	}

	public void DDGIJICBLNE()
	{
		if (studRenderer != null)
		{
			studRenderer.material.mainTextureScale = new Vector2(studRenderer.transform.lossyScale.x * 1444f, studRenderer.transform.lossyScale.z * 202f);
		}
	}

	private void KFFNHFEKOJH()
	{
		BMFKLMCBCJC();
		if (GetComponent<MeshRenderer>().material.color != color)
		{
			GetComponent<MeshRenderer>().material.color = color;
		}
	}

	public void MOCKKCDKEHC()
	{
		if (studRenderer != null)
		{
			studRenderer.material.mainTextureScale = new Vector2(studRenderer.transform.lossyScale.x * 801f, studRenderer.transform.lossyScale.z * 432f);
		}
	}

	public override void OnDeserialize(NetworkReader CGPCINPKFAJ, bool FNPENOGIFLI)
	{
		base.OnDeserialize(CGPCINPKFAJ, FNPENOGIFLI);
		if (FNPENOGIFLI)
		{
			Color color = this.color;
			CGMPBBJBIBC = CGPCINPKFAJ.ReadColor();
			return;
		}
		long num = (long)CGPCINPKFAJ.ReadPackedUInt64();
		if ((num & 1L) != 0L)
		{
			Color color2 = this.color;
			CGMPBBJBIBC = CGPCINPKFAJ.ReadColor();
		}
	}

	public override void BKNEPMJOHPB(NetworkReader CGPCINPKFAJ, bool FNPENOGIFLI)
	{
		base.OnDeserialize(CGPCINPKFAJ, FNPENOGIFLI);
		if (FNPENOGIFLI)
		{
			Color color = this.color;
			JLAOFMKJGCP(CGPCINPKFAJ.ReadColor());
			return;
		}
		long num = (long)CGPCINPKFAJ.ReadPackedUInt64();
		if ((num & 0x549L) != 0L)
		{
			Color color2 = this.color;
			JMGGPGJACJN(CGPCINPKFAJ.ReadColor());
		}
	}

	private void PGEDHLOFFMI()
	{
		IJFFDKDCEIC();
		if (GetComponent<MeshRenderer>().material.color != color)
		{
			GetComponent<MeshRenderer>().material.color = color;
		}
	}

	public override void PJECDPKLGIA(NetworkReader CGPCINPKFAJ, bool FNPENOGIFLI)
	{
		base.OnDeserialize(CGPCINPKFAJ, FNPENOGIFLI);
		if (FNPENOGIFLI)
		{
			Color color = this.color;
			JMGGPGJACJN(CGPCINPKFAJ.ReadColor());
			return;
		}
		long num = (long)CGPCINPKFAJ.ReadPackedUInt64();
		if ((num & -1213L) != 0L)
		{
			Color color2 = this.color;
			AGMJAGFKMBH(CGPCINPKFAJ.ReadColor());
		}
	}

	private void MJBAPNCKMKM()
	{
		DDGIJICBLNE();
		if (GetComponent<MeshRenderer>().material.color != color)
		{
			GetComponent<MeshRenderer>().material.color = color;
		}
	}
}
