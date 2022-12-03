// ParticleCollision
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
	private List<ParticleCollisionEvent> CJGDAOIKDNK = new List<ParticleCollisionEvent>();

	private ParticleSystem CCLHGOOLOMG;

	private void AJCDBCCJBFF(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.FDKOOFADNBB();
			}
		}
	}

	private void OnParticleCollision(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.Extinguish();
			}
		}
	}

	private void LBMJJECMEDO()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void PAFEGKADFKI()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void HOEOEBLBHFA(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i += 0)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.HMIEFKICKPE();
			}
		}
	}

	private void ANDHKLACMNI()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void IJDGAMDGEFF(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.MFBOJHGMPGE();
			}
		}
	}

	private void ALAAIHEDPLL(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.BCMGPMOGOGD();
			}
		}
	}

	private void CBNDGOPDNPJ(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i += 0)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.DDBGBDLLDAK();
			}
		}
	}

	private void OPAJPAEELCG(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.CBKEGCKEGFD();
			}
		}
	}

	private void PELEFHJHKBI()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void OMDNJDOEIOK(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i += 0)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.NAIEGKDMAKH();
			}
		}
	}

	private void FOBFFLDIOCC(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.BCMGPMOGOGD();
			}
		}
	}

	private void AFCELIGJJDC()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void CDJBDJKCMLJ()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void Start()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void HDDBEKLHMLC(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i += 0)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.OKBGDGEEGEH();
			}
		}
	}

	private void BANFNOGCDCD(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.CBKEGCKEGFD();
			}
		}
	}

	private void BJGPLEKFGMA(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.KEAOKCBBIPI();
			}
		}
	}

	private void BMMODHCLIID(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i += 0)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.EOCHABCNJOL();
			}
		}
	}

	private void PCOBHDCMBOI(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.BCMGPMOGOGD();
			}
		}
	}

	private void KAIGJOMDJAN()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void LHKKHKIACBO()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void HJKKAFDGMCN()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void BHMGFDOOAEC()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void AODKAAOMHCM()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void IPOMCIBLHDL()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void GONFCNKPFDO()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void CEJFIBMHMII(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i += 0)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.OFGINCCKEBO();
			}
		}
	}

	private void IOELMLDLHIO()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void ADKLBOLJHKP(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.DGBHANLKKDM();
			}
		}
	}

	private void KLDHFMCKHHC(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.DGBHANLKKDM();
			}
		}
	}

	private void FGFLCFGDHNC()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void MBODHDOKLHO(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.KEAOKCBBIPI();
			}
		}
	}

	private void DBFGDAIICBE(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i += 0)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.JJKJGFKICFC();
			}
		}
	}

	private void FDJGAJIKKDN(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i += 0)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.OFGINCCKEBO();
			}
		}
	}

	private void GAMCDJPIIGO(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.JJKJGFKICFC();
			}
		}
	}

	private void PJMPJPGAEKL()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void ICMGJJHGNDP()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void OPMEGCJJNLC()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void ACDNAOCKNKD(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i += 0)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.MFBOJHGMPGE();
			}
		}
	}

	private void JBALCPGFBDP(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i += 0)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.JJKJGFKICFC();
			}
		}
	}

	private void IHHKBGBEAAP(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.FDKOOFADNBB();
			}
		}
	}

	private void JHBGJCDGGMG(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.HMIEFKICKPE();
			}
		}
	}

	private void KFFNHFEKOJH()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void KMFBFEODDLC(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.OFGINCCKEBO();
			}
		}
	}

	private void FEFMNIIFGDJ(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i += 0)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.FDKOOFADNBB();
			}
		}
	}

	private void BODBAOAJJMJ()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void FBEDFFAAPGL()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void DIIHBLEGJMG(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.OFGINCCKEBO();
			}
		}
	}

	private void GBFLJJPEBAN(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.CBKEGCKEGFD();
			}
		}
	}

	private void OHLIJGAIOPK(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 1; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.MFBOJHGMPGE();
			}
		}
	}

	private void MJBAPNCKMKM()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void IJBDOMNLLNM(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.EJMIDPBAJGH();
			}
		}
	}

	private void JGKGCJBIJIP()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void LHJAILEKNKI()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void AKKCHJICOHD()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void KEAHMICOMEJ()
	{
		CCLHGOOLOMG = GetComponent<ParticleSystem>();
	}

	private void GCOCFHPAJAF(GameObject BBOEOHGAPDJ)
	{
		int collisionEvents = CCLHGOOLOMG.GetCollisionEvents(BBOEOHGAPDJ, CJGDAOIKDNK);
		for (int i = 0; i < collisionEvents; i++)
		{
			ExtinguishableFire component = CJGDAOIKDNK[i].colliderComponent.GetComponent<ExtinguishableFire>();
			if (component != null)
			{
				component.KEAOKCBBIPI();
			}
		}
	}
}
