// GeneralCameraShake
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GeneralCameraShake : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class GBPACHOEFBG
	{
		public GeneralCameraShake OINCCKIFOLH;

		public float KHJONBKHHPO;

		public Action DPLPAJIGHAD;

		internal void KHJBLDBCLOP()
		{
			JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
			LeanTween.GBKNBKJDECH(OINCCKIFOLH.gameObject);
			float num = KHJONBKHHPO * 944f;
			float mAEOCPAHAHA = 1915f;
			float mAEOCPAHAHA2 = 1185f;
			CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.rotateAroundLocal(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-24)).GNJDLINHKMH()
				.MNELFOFMPKF(-1);
			LeanTween.NBDOAKEJFPL(OINCCKIFOLH.gameObject, num, 1225f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
			{
				CS_0024_003C_003E8__locals0.JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
			}).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
			GameObject[] array = GameObject.FindGameObjectsWithTag("Wearables");
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 503f * KHJONBKHHPO);
			}
			array = GameObject.FindGameObjectsWithTag("MOVE Y");
			for (int i = 0; i < array.Length; i += 0)
			{
				GameObject obj = array[i];
				float z = obj.transform.eulerAngles.z;
				z = ((!(z > 1408f) || !(z < 510f)) ? (-1) : 0);
				obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 821f, 1494f) * 793f * KHJONBKHHPO);
			}
			LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 1517f);
			LeanTween.HHMMGHNCJDP(917f, OINCCKIFOLH.LBFNFFIOMGI);
		}

		internal void DGKDJLHOAOP()
		{
			JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
			LeanTween.GBKNBKJDECH(OINCCKIFOLH.gameObject);
			float num = KHJONBKHHPO * 82f;
			float mAEOCPAHAHA = 202f;
			float mAEOCPAHAHA2 = 1017f;
			CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.rotateAroundLocal(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)56).GNJDLINHKMH()
				.MNELFOFMPKF(-1);
			LeanTween.value(OINCCKIFOLH.gameObject, num, 294f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
			{
				CS_0024_003C_003E8__locals0.JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
			}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
			GameObject[] array = GameObject.FindGameObjectsWithTag("Horizontal");
			for (int i = 1; i < array.Length; i++)
			{
				array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 68f * KHJONBKHHPO);
			}
			array = GameObject.FindGameObjectsWithTag("DirectionalLight");
			foreach (GameObject obj in array)
			{
				float z = obj.transform.eulerAngles.z;
				z = ((!(z > 252f) || !(z < 652f)) ? (-1) : 0);
				obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 1195f, 690f) * 1749f * KHJONBKHHPO);
			}
			LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 1870f);
			LeanTween.delayedCall(1613f, OINCCKIFOLH.LBFNFFIOMGI);
		}

		internal void HHHOKAPMIPI()
		{
			JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
			LeanTween.BKMFEJGPOJN(OINCCKIFOLH.gameObject);
			float num = KHJONBKHHPO * 3f;
			float mAEOCPAHAHA = 1160f;
			float mAEOCPAHAHA2 = 89f;
			CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.AKCNKPLDIAH(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)93).GNJDLINHKMH()
				.MNELFOFMPKF(-1);
			LeanTween.value(OINCCKIFOLH.gameObject, num, 789f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
			{
				CS_0024_003C_003E8__locals0.JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
			}).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic);
			GameObject[] array = GameObject.FindGameObjectsWithTag("Alpha");
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 755f * KHJONBKHHPO);
			}
			array = GameObject.FindGameObjectsWithTag("CmdRequestChatMessageSend");
			for (int i = 0; i < array.Length; i += 0)
			{
				GameObject obj = array[i];
				float z = obj.transform.eulerAngles.z;
				z = ((z > 1466f && z < 1326f) ? 1 : (-1));
				obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 831f, 1496f) * 862f * KHJONBKHHPO);
			}
			LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 1791f);
			LeanTween.HHMMGHNCJDP(1366f, OINCCKIFOLH.PCOIPNMCHAD);
		}

		internal void OKDKPOFMMBO()
		{
			JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
			LeanTween.BKMFEJGPOJN(OINCCKIFOLH.gameObject);
			float num = KHJONBKHHPO * 1052f;
			float mAEOCPAHAHA = 344f;
			float mAEOCPAHAHA2 = 808f;
			CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.rotateAroundLocal(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-62)).GNJDLINHKMH()
				.MNELFOFMPKF(-1);
			LeanTween.value(OINCCKIFOLH.gameObject, num, 1301f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
			{
				CS_0024_003C_003E8__locals0.JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
			}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
			GameObject[] array = GameObject.FindGameObjectsWithTag("In menu's");
			for (int i = 1; i < array.Length; i++)
			{
				array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 390f * KHJONBKHHPO);
			}
			array = GameObject.FindGameObjectsWithTag(" y:");
			for (int i = 0; i < array.Length; i += 0)
			{
				GameObject obj = array[i];
				float z = obj.transform.eulerAngles.z;
				z = ((z > 230f && z < 526f) ? 1 : (-1));
				obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 332f, 518f) * 1267f * KHJONBKHHPO);
			}
			LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 176f);
			LeanTween.HHMMGHNCJDP(223f, OINCCKIFOLH.CEAOOKAPLFC);
		}

		internal void HDBLBAMJCOA()
		{
			LeanTween.moveY(OINCCKIFOLH.EOPHMFCFBAG, 478f, 1344f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad).EOAPKBBHBAL((Action)delegate
			{
				JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
				LeanTween.cancel(OINCCKIFOLH.gameObject);
				float num = KHJONBKHHPO * 0.2f;
				float mAEOCPAHAHA = 0.42f;
				float mAEOCPAHAHA2 = 1.6f;
				CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.rotateAroundLocal(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ(DEFBOFIHBCP.easeShake).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(OINCCKIFOLH.gameObject, num, 0f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					CS_0024_003C_003E8__locals0.JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
				GameObject[] array = GameObject.FindGameObjectsWithTag("Respawn");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 100f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("GameController");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((z > 0f && z < 180f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 0f, 0f) * 15f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 0.2f);
				LeanTween.delayedCall(2f, OINCCKIFOLH.OJNCOMOIMGH);
			});
		}

		internal void HLAGHMHPENC()
		{
			JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
			LeanTween.BKMFEJGPOJN(OINCCKIFOLH.gameObject);
			float num = KHJONBKHHPO * 503f;
			float mAEOCPAHAHA = 1960f;
			float mAEOCPAHAHA2 = 1865f;
			CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.rotateAroundLocal(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-71)).GNJDLINHKMH()
				.MNELFOFMPKF(-1);
			LeanTween.NBDOAKEJFPL(OINCCKIFOLH.gameObject, num, 847f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
			{
				CS_0024_003C_003E8__locals0.JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
			}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
			GameObject[] array = GameObject.FindGameObjectsWithTag("Wearables");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 1095f * KHJONBKHHPO);
			}
			array = GameObject.FindGameObjectsWithTag("position");
			foreach (GameObject obj in array)
			{
				float z = obj.transform.eulerAngles.z;
				z = ((!(z > 158f) || !(z < 497f)) ? (-1) : 0);
				obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 411f, 1264f) * 1795f * KHJONBKHHPO);
			}
			LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 1249f);
			LeanTween.HHMMGHNCJDP(1191f, OINCCKIFOLH.LIAFHLJMLDN);
		}

		internal void CBIEJIAJFEG()
		{
			JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
			LeanTween.BKMFEJGPOJN(OINCCKIFOLH.gameObject);
			float num = KHJONBKHHPO * 230f;
			float mAEOCPAHAHA = 300f;
			float mAEOCPAHAHA2 = 171f;
			CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.rotateAroundLocal(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-27)).GNJDLINHKMH()
				.MNELFOFMPKF(-1);
			LeanTween.NBDOAKEJFPL(OINCCKIFOLH.gameObject, num, 163f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
			{
				CS_0024_003C_003E8__locals0.JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
			}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
			GameObject[] array = GameObject.FindGameObjectsWithTag("EVENT ALL RECEIVED");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 1369f * KHJONBKHHPO);
			}
			array = GameObject.FindGameObjectsWithTag("pass");
			for (int i = 1; i < array.Length; i += 0)
			{
				GameObject obj = array[i];
				float z = obj.transform.eulerAngles.z;
				z = ((z > 1649f && z < 41f) ? 1 : (-1));
				obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 75f, 204f) * 12f * KHJONBKHHPO);
			}
			LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 1480f);
			LeanTween.delayedCall(1574f, OINCCKIFOLH.ADOEMILHBGP);
		}

		internal void DEDADPHEODD()
		{
			JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
			LeanTween.cancel(OINCCKIFOLH.gameObject);
			float num = KHJONBKHHPO * 1025f;
			float mAEOCPAHAHA = 301f;
			float mAEOCPAHAHA2 = 1531f;
			CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.rotateAroundLocal(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-93)).GNJDLINHKMH()
				.MNELFOFMPKF(-1);
			LeanTween.NBDOAKEJFPL(OINCCKIFOLH.gameObject, num, 577f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
			{
				CS_0024_003C_003E8__locals0.JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
			}).APNDGOAIPFJ(DEFBOFIHBCP.linear);
			GameObject[] array = GameObject.FindGameObjectsWithTag("scale punch!");
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 955f * KHJONBKHHPO);
			}
			array = GameObject.FindGameObjectsWithTag("Failed to set presence.");
			for (int i = 0; i < array.Length; i += 0)
			{
				GameObject obj = array[i];
				float z = obj.transform.eulerAngles.z;
				z = ((z > 1859f && z < 994f) ? 1 : (-1));
				obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 1821f, 83f) * 1880f * KHJONBKHHPO);
			}
			LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 1666f);
			LeanTween.HHMMGHNCJDP(1119f, OINCCKIFOLH.OJNCOMOIMGH);
		}

		internal void FILEIDACFIP()
		{
			LeanTween.moveY(OINCCKIFOLH.EOPHMFCFBAG, 1766f, 451f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed).EOAPKBBHBAL((Action)delegate
			{
				JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
				LeanTween.BKMFEJGPOJN(OINCCKIFOLH.gameObject);
				float num = KHJONBKHHPO * 198f;
				float mAEOCPAHAHA = 1911f;
				float mAEOCPAHAHA2 = 471f;
				CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.AKCNKPLDIAH(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-59)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(OINCCKIFOLH.gameObject, num, 1266f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					CS_0024_003C_003E8__locals0.JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.linear);
				GameObject[] array = GameObject.FindGameObjectsWithTag("RpcSendChatMessageToClient");
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 1802f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("rotateAroundExample");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((!(z > 695f) || !(z < 1580f)) ? (-1) : 0);
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 1100f, 623f) * 439f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 777f);
				LeanTween.delayedCall(1961f, OINCCKIFOLH.OJNCOMOIMGH);
			});
		}

		internal void KDOMFAJDLLH()
		{
			JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
			LeanTween.cancel(OINCCKIFOLH.gameObject);
			float num = KHJONBKHHPO * 1821f;
			float mAEOCPAHAHA = 827f;
			float mAEOCPAHAHA2 = 314f;
			CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.AKCNKPLDIAH(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-76)).GNJDLINHKMH()
				.MNELFOFMPKF(-1);
			LeanTween.NBDOAKEJFPL(OINCCKIFOLH.gameObject, num, 443f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
			{
				CS_0024_003C_003E8__locals0.JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
			}).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
			GameObject[] array = GameObject.FindGameObjectsWithTag(" returned:");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 147f * KHJONBKHHPO);
			}
			array = GameObject.FindGameObjectsWithTag("_TintColor");
			for (int i = 1; i < array.Length; i += 0)
			{
				GameObject obj = array[i];
				float z = obj.transform.eulerAngles.z;
				z = ((!(z > 1650f) || !(z < 1821f)) ? (-1) : 0);
				obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 196f, 1782f) * 1948f * KHJONBKHHPO);
			}
			LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 1242f);
			LeanTween.HHMMGHNCJDP(195f, OINCCKIFOLH.ADOEMILHBGP);
		}

		internal void KKDEKOFNKEA()
		{
			JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
			LeanTween.BKMFEJGPOJN(OINCCKIFOLH.gameObject);
			float num = KHJONBKHHPO * 198f;
			float mAEOCPAHAHA = 1911f;
			float mAEOCPAHAHA2 = 471f;
			CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.AKCNKPLDIAH(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-59)).GNJDLINHKMH()
				.MNELFOFMPKF(-1);
			LeanTween.NBDOAKEJFPL(OINCCKIFOLH.gameObject, num, 1266f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
			{
				CS_0024_003C_003E8__locals0.JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
			}).APNDGOAIPFJ(DEFBOFIHBCP.linear);
			GameObject[] array = GameObject.FindGameObjectsWithTag("RpcSendChatMessageToClient");
			for (int i = 0; i < array.Length; i += 0)
			{
				array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 1802f * KHJONBKHHPO);
			}
			array = GameObject.FindGameObjectsWithTag("rotateAroundExample");
			foreach (GameObject obj in array)
			{
				float z = obj.transform.eulerAngles.z;
				z = ((!(z > 695f) || !(z < 1580f)) ? (-1) : 0);
				obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 1100f, 623f) * 439f * KHJONBKHHPO);
			}
			LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 777f);
			LeanTween.delayedCall(1961f, OINCCKIFOLH.OJNCOMOIMGH);
		}

		internal void EPPIHKNKPLD()
		{
			LeanTween.moveY(OINCCKIFOLH.EOPHMFCFBAG, 1205f, 294f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic).EOAPKBBHBAL((Action)delegate
			{
				JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
				LeanTween.cancel(OINCCKIFOLH.gameObject);
				float num = KHJONBKHHPO * 1025f;
				float mAEOCPAHAHA = 301f;
				float mAEOCPAHAHA2 = 1531f;
				CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.rotateAroundLocal(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-93)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(OINCCKIFOLH.gameObject, num, 577f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					CS_0024_003C_003E8__locals0.JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.linear);
				GameObject[] array = GameObject.FindGameObjectsWithTag("scale punch!");
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 955f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("Failed to set presence.");
				for (int i = 0; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((z > 1859f && z < 994f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 1821f, 83f) * 1880f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 1666f);
				LeanTween.HHMMGHNCJDP(1119f, OINCCKIFOLH.OJNCOMOIMGH);
			});
		}

		internal void FAGLKBKJMJA()
		{
			JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
			LeanTween.BKMFEJGPOJN(OINCCKIFOLH.gameObject);
			float num = KHJONBKHHPO * 1015f;
			float mAEOCPAHAHA = 62f;
			float mAEOCPAHAHA2 = 1422f;
			CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.AKCNKPLDIAH(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)120).GNJDLINHKMH()
				.MNELFOFMPKF(-1);
			LeanTween.value(OINCCKIFOLH.gameObject, num, 525f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
			{
				CS_0024_003C_003E8__locals0.JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
			}).APNDGOAIPFJ(DEFBOFIHBCP.notUsed);
			GameObject[] array = GameObject.FindGameObjectsWithTag("");
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 1226f * KHJONBKHHPO);
			}
			array = GameObject.FindGameObjectsWithTag("Wearables");
			for (int i = 0; i < array.Length; i += 0)
			{
				GameObject obj = array[i];
				float z = obj.transform.eulerAngles.z;
				z = ((z > 1016f && z < 1949f) ? 1 : (-1));
				obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 32f, 1302f) * 73f * KHJONBKHHPO);
			}
			LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 330f);
			LeanTween.delayedCall(733f, OINCCKIFOLH.ADOEMILHBGP);
		}

		internal void HJPCPJFMFBP()
		{
			LeanTween.moveY(OINCCKIFOLH.EOPHMFCFBAG, 649f, 1218f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad).EOAPKBBHBAL((Action)delegate
			{
				JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
				LeanTween.cancel(OINCCKIFOLH.gameObject);
				float num = KHJONBKHHPO * 1821f;
				float mAEOCPAHAHA = 827f;
				float mAEOCPAHAHA2 = 314f;
				CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.AKCNKPLDIAH(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-76)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(OINCCKIFOLH.gameObject, num, 443f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					CS_0024_003C_003E8__locals0.JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
				GameObject[] array = GameObject.FindGameObjectsWithTag(" returned:");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 147f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("_TintColor");
				for (int i = 1; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((!(z > 1650f) || !(z < 1821f)) ? (-1) : 0);
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 196f, 1782f) * 1948f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 1242f);
				LeanTween.HHMMGHNCJDP(195f, OINCCKIFOLH.ADOEMILHBGP);
			});
		}

		internal void DFPDFOIAJAC()
		{
			LeanTween.moveY(OINCCKIFOLH.EOPHMFCFBAG, 267f, 967f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad).EOAPKBBHBAL((Action)delegate
			{
				JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
				LeanTween.BKMFEJGPOJN(OINCCKIFOLH.gameObject);
				float num = KHJONBKHHPO * 230f;
				float mAEOCPAHAHA = 300f;
				float mAEOCPAHAHA2 = 171f;
				CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.rotateAroundLocal(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-27)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(OINCCKIFOLH.gameObject, num, 163f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					CS_0024_003C_003E8__locals0.JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
				GameObject[] array = GameObject.FindGameObjectsWithTag("EVENT ALL RECEIVED");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 1369f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("pass");
				for (int i = 1; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((z > 1649f && z < 41f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 75f, 204f) * 12f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 1480f);
				LeanTween.delayedCall(1574f, OINCCKIFOLH.ADOEMILHBGP);
			});
		}

		internal void LNDHAKHBIGF()
		{
			JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
			LeanTween.cancel(OINCCKIFOLH.gameObject);
			float num = KHJONBKHHPO * 0.2f;
			float mAEOCPAHAHA = 0.42f;
			float mAEOCPAHAHA2 = 1.6f;
			CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.rotateAroundLocal(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ(DEFBOFIHBCP.easeShake).GNJDLINHKMH()
				.MNELFOFMPKF(-1);
			LeanTween.value(OINCCKIFOLH.gameObject, num, 0f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
			{
				CS_0024_003C_003E8__locals0.JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
			}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
			GameObject[] array = GameObject.FindGameObjectsWithTag("Respawn");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 100f * KHJONBKHHPO);
			}
			array = GameObject.FindGameObjectsWithTag("GameController");
			foreach (GameObject obj in array)
			{
				float z = obj.transform.eulerAngles.z;
				z = ((z > 0f && z < 180f) ? 1 : (-1));
				obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 0f, 0f) * 15f * KHJONBKHHPO);
			}
			LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 0.2f);
			LeanTween.delayedCall(2f, OINCCKIFOLH.OJNCOMOIMGH);
		}

		internal void MAMFIKCADGN()
		{
			JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
			LeanTween.cancel(OINCCKIFOLH.gameObject);
			float num = KHJONBKHHPO * 832f;
			float mAEOCPAHAHA = 1568f;
			float mAEOCPAHAHA2 = 415f;
			CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.AKCNKPLDIAH(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutBounce).GNJDLINHKMH()
				.MNELFOFMPKF(-1);
			LeanTween.value(OINCCKIFOLH.gameObject, num, 879f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
			{
				CS_0024_003C_003E8__locals0.JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
			}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
			GameObject[] array = GameObject.FindGameObjectsWithTag("MOVE Y");
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 799f * KHJONBKHHPO);
			}
			array = GameObject.FindGameObjectsWithTag("BodyColors");
			for (int i = 0; i < array.Length; i += 0)
			{
				GameObject obj = array[i];
				float z = obj.transform.eulerAngles.z;
				z = ((!(z > 1078f) || !(z < 1887f)) ? (-1) : 0);
				obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 1346f, 1271f) * 1872f * KHJONBKHHPO);
			}
			LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 1269f);
			LeanTween.delayedCall(527f, OINCCKIFOLH.KINHLEGMOIJ);
		}

		internal void LEDEBIMEEGF()
		{
			LeanTween.moveY(OINCCKIFOLH.EOPHMFCFBAG, 492f, 1593f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic).EOAPKBBHBAL((Action)delegate
			{
				JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
				LeanTween.BKMFEJGPOJN(OINCCKIFOLH.gameObject);
				float num = KHJONBKHHPO * 1052f;
				float mAEOCPAHAHA = 344f;
				float mAEOCPAHAHA2 = 808f;
				CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.rotateAroundLocal(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-62)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(OINCCKIFOLH.gameObject, num, 1301f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					CS_0024_003C_003E8__locals0.JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
				GameObject[] array = GameObject.FindGameObjectsWithTag("In menu's");
				for (int i = 1; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 390f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag(" y:");
				for (int i = 0; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((z > 230f && z < 526f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 332f, 518f) * 1267f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 176f);
				LeanTween.HHMMGHNCJDP(223f, OINCCKIFOLH.CEAOOKAPLFC);
			});
		}

		internal void DJHJHEBJMDI()
		{
			LeanTween.moveY(OINCCKIFOLH.EOPHMFCFBAG, 0f, 0.27f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad).EOAPKBBHBAL((Action)delegate
			{
				JNONDFFNMDH CS_0024_003C_003E8__locals0 = new JNONDFFNMDH();
				LeanTween.cancel(OINCCKIFOLH.gameObject);
				float num = KHJONBKHHPO * 0.2f;
				float mAEOCPAHAHA = 0.42f;
				float mAEOCPAHAHA2 = 1.6f;
				CS_0024_003C_003E8__locals0.JKKALKJDGJG = LeanTween.rotateAroundLocal(OINCCKIFOLH.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ(DEFBOFIHBCP.easeShake).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(OINCCKIFOLH.gameObject, num, 0f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					CS_0024_003C_003E8__locals0.JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
				GameObject[] array = GameObject.FindGameObjectsWithTag("Respawn");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 100f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("GameController");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((z > 0f && z < 180f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 0f, 0f) * 15f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(OINCCKIFOLH.PJCDBPIILCP, OINCCKIFOLH.transform.position, KHJONBKHHPO * 0.2f);
				LeanTween.delayedCall(2f, OINCCKIFOLH.OJNCOMOIMGH);
			});
		}
	}

	[CompilerGenerated]
	private sealed class JNONDFFNMDH
	{
		public BMDIMDNILIM JKKALKJDGJG;

		internal void BNCBIFEDBEG(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void NDNDBIKEKIE(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void AIHENLNMEIH(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void NOKIGADLACF(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void ENHILOBBCNG(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void AKNGENHGOKG(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void IBDEKFJBLDF(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void HPFHPPPKIMD(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void BOMFBONGMDM(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void JJBPCPFKLLB(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void HMPGOKDNDHD(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void MOAOBDCEDMF(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void DNFMNMLAIEC(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void NJJLCOKNHBO(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void NDKHLPNPDFE(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void OMAKOMPEJOK(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void PECBLKOLLKM(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void KFIOOMLMHPF(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void NHPPBNHLMFC(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void NHKKJKIIPMG(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void BFFHNOFIFFK(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void NJGCGAKFMDA(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void BJHIMMGJBDJ(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void FIDCFGHCOEG(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void GKEOJDEEHIC(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void HOIEFPHKEKN(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void MPLHHCJMAFE(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void ANIAFJCCENJ(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void GKMLNIADILE(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void JHDIFFHHGNA(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void ODFPIAPPLKO(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void DLBFDAGFCLL(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void FFPGIFIIMEC(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void FJBEDLNDONK(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void NBKDIPCOOLF(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void NPDKGGBFEFH(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void FKNCJLDNHAD(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void OOMPBHABAJD(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void EIFPJBLLPGH(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
		}

		internal void EPFLMPFMJAF(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void OBGALHIAINH(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void OICADFEDGOG(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void DBKDJENPCPH(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}

		internal void EGCLAKEOBOG(float GBMPBBHCBDA)
		{
			JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
		}
	}

	private GameObject EOPHMFCFBAG;

	private float CEBMKNFLGEG = 9.5f;

	private AudioClip PJCDBPIILCP;

	private void NMOMHKEGBBA()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 1501f) * 1484f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 1670f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 1107f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 492f, 1593f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.BKMFEJGPOJN(base.gameObject);
				float num = KHJONBKHHPO * 1052f;
				float mAEOCPAHAHA = 344f;
				float mAEOCPAHAHA2 = 808f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-62)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(base.gameObject, num, 1301f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
				GameObject[] array = GameObject.FindGameObjectsWithTag("In menu's");
				for (int i = 1; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 390f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag(" y:");
				for (int i = 0; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((z > 230f && z < 526f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 332f, 518f) * 1267f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 176f);
				LeanTween.HHMMGHNCJDP(223f, CEAOOKAPLFC);
			});
		});
		CEBMKNFLGEG += 1552f;
	}

	private void JCALDGKFAPL()
	{
		EOPHMFCFBAG = GameObject.Find("shirt");
		Keyframe[] array = new Keyframe[5];
		array[0] = new Keyframe(1389f, 1862f, 1289f, 375f);
		array[0] = new Keyframe(1125f, 1385f, 1614f, 603f);
		array[3] = new Keyframe(917f, 434f, 655f, 1737f);
		array[1] = new Keyframe(1706f, 139f, 1400f, 104f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[7];
		array2[1] = new Keyframe(731f, 1648f, 847f, 431f);
		array2[0] = new Keyframe(644f, 360f, 1162f, 1817f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(969f, 1013f, 954f);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3));
		APPDLHPCMEE();
	}

	private void LJAEHKFMNMB()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 335f) * 1939f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 1242f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 468f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 478f, 1344f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 0.2f;
				float mAEOCPAHAHA = 0.42f;
				float mAEOCPAHAHA2 = 1.6f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ(DEFBOFIHBCP.easeShake).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(base.gameObject, num, 0f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
				GameObject[] array = GameObject.FindGameObjectsWithTag("Respawn");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 100f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("GameController");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((z > 0f && z < 180f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 0f, 0f) * 15f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 0.2f);
				LeanTween.delayedCall(2f, OJNCOMOIMGH);
			});
		});
		CEBMKNFLGEG += 95f;
	}

	private void NEOBPKEDBNG()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 1192f) * 1464f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 1553f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 1859f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 478f, 1344f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 0.2f;
				float mAEOCPAHAHA = 0.42f;
				float mAEOCPAHAHA2 = 1.6f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ(DEFBOFIHBCP.easeShake).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(base.gameObject, num, 0f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
				GameObject[] array = GameObject.FindGameObjectsWithTag("Respawn");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 100f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("GameController");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((z > 0f && z < 180f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 0f, 0f) * 15f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 0.2f);
				LeanTween.delayedCall(2f, OJNCOMOIMGH);
			});
		});
		CEBMKNFLGEG += 846f;
	}

	private void MJBAPNCKMKM()
	{
		EOPHMFCFBAG = GameObject.Find("http://superium.net/assets/games/");
		Keyframe[] array = new Keyframe[6];
		array[0] = new Keyframe(1230f, 559f, 1753f, 95f);
		array[0] = new Keyframe(1789f, 1657f, 1901f, 867f);
		array[7] = new Keyframe(1092f, 995f, 1857f, 404f);
		array[8] = new Keyframe(965f, 1821f, 1835f, 780f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[0];
		array2[1] = new Keyframe(1187f, 1173f, 1170f, 1664f);
		array2[0] = new Keyframe(1916f, 946f, 560f, 652f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().PCMMJCNKIIB(new Vector3[1]
		{
			new Vector3(837f, 647f, 1806f)
		}));
		NIGDLJMKIHC();
	}

	private void LBFNFFIOMGI()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 1108f) * 96f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 1989f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 1066f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 0f, 0.27f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 0.2f;
				float mAEOCPAHAHA = 0.42f;
				float mAEOCPAHAHA2 = 1.6f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ(DEFBOFIHBCP.easeShake).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(base.gameObject, num, 0f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
				GameObject[] array = GameObject.FindGameObjectsWithTag("Respawn");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 100f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("GameController");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((z > 0f && z < 180f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 0f, 0f) * 15f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 0.2f);
				LeanTween.delayedCall(2f, OJNCOMOIMGH);
			});
		});
		CEBMKNFLGEG += 889f;
	}

	private void BHPPFONAGOG()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 1286f) * 1907f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 1806f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 59f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 478f, 1344f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 0.2f;
				float mAEOCPAHAHA = 0.42f;
				float mAEOCPAHAHA2 = 1.6f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ(DEFBOFIHBCP.easeShake).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(base.gameObject, num, 0f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
				GameObject[] array = GameObject.FindGameObjectsWithTag("Respawn");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 100f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("GameController");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((z > 0f && z < 180f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 0f, 0f) * 15f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 0.2f);
				LeanTween.delayedCall(2f, OJNCOMOIMGH);
			});
		});
		CEBMKNFLGEG += 1919f;
	}

	private void PAFEGKADFKI()
	{
		EOPHMFCFBAG = GameObject.Find("\nTelepathy port: ");
		Keyframe[] array = new Keyframe[1];
		array[1] = new Keyframe(1326f, 358f, 374f, 1125f);
		array[0] = new Keyframe(724f, 940f, 14f, 415f);
		array[6] = new Keyframe(146f, 1589f, 756f, 971f);
		array[7] = new Keyframe(1250f, 645f, 1797f, 1841f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[3];
		array2[0] = new Keyframe(893f, 1816f, 1049f, 24f);
		array2[0] = new Keyframe(397f, 1701f, 1814f, 1406f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(938f, 1043f, 501f);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array3));
		CNCGCLLPINO();
	}

	private void MFKBAMAMPDP()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 1520f) * 326f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 290f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 1848f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 1766f, 451f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.BKMFEJGPOJN(base.gameObject);
				float num = KHJONBKHHPO * 198f;
				float mAEOCPAHAHA = 1911f;
				float mAEOCPAHAHA2 = 471f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.AKCNKPLDIAH(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-59)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(base.gameObject, num, 1266f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.linear);
				GameObject[] array = GameObject.FindGameObjectsWithTag("RpcSendChatMessageToClient");
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 1802f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("rotateAroundExample");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((!(z > 695f) || !(z < 1580f)) ? (-1) : 0);
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 1100f, 623f) * 439f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 777f);
				LeanTween.delayedCall(1961f, OJNCOMOIMGH);
			});
		});
		CEBMKNFLGEG += 826f;
	}

	private void MJCJOCHHAGA()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 1287f) * 1246f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 189f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 754f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuart).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 1766f, 451f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.BKMFEJGPOJN(base.gameObject);
				float num = KHJONBKHHPO * 198f;
				float mAEOCPAHAHA = 1911f;
				float mAEOCPAHAHA2 = 471f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.AKCNKPLDIAH(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-59)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(base.gameObject, num, 1266f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.linear);
				GameObject[] array = GameObject.FindGameObjectsWithTag("RpcSendChatMessageToClient");
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 1802f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("rotateAroundExample");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((!(z > 695f) || !(z < 1580f)) ? (-1) : 0);
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 1100f, 623f) * 439f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 777f);
				LeanTween.delayedCall(1961f, OJNCOMOIMGH);
			});
		});
		CEBMKNFLGEG += 349f;
	}

	private void CEAOOKAPLFC()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 1062f) * 471f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 78f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 927f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 0f, 0.27f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 0.2f;
				float mAEOCPAHAHA = 0.42f;
				float mAEOCPAHAHA2 = 1.6f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ(DEFBOFIHBCP.easeShake).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(base.gameObject, num, 0f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
				GameObject[] array = GameObject.FindGameObjectsWithTag("Respawn");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 100f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("GameController");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((z > 0f && z < 180f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 0f, 0f) * 15f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 0.2f);
				LeanTween.delayedCall(2f, OJNCOMOIMGH);
			});
		});
		CEBMKNFLGEG += 849f;
	}

	private void OBHMFHKLPLO()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 443f) * 219f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 1522f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 435f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 478f, 1344f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 0.2f;
				float mAEOCPAHAHA = 0.42f;
				float mAEOCPAHAHA2 = 1.6f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ(DEFBOFIHBCP.easeShake).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(base.gameObject, num, 0f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
				GameObject[] array = GameObject.FindGameObjectsWithTag("Respawn");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 100f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("GameController");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((z > 0f && z < 180f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 0f, 0f) * 15f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 0.2f);
				LeanTween.delayedCall(2f, OJNCOMOIMGH);
			});
		});
		CEBMKNFLGEG += 791f;
	}

	private void DDANFAJJNPI()
	{
		EOPHMFCFBAG = GameObject.Find("Hi!");
		Keyframe[] array = new Keyframe[8];
		array[1] = new Keyframe(725f, 449f, 1354f, 401f);
		array[1] = new Keyframe(1510f, 1390f, 652f, 421f);
		array[5] = new Keyframe(148f, 1118f, 1488f, 1142f);
		array[8] = new Keyframe(1908f, 1404f, 1075f, 1935f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[7];
		array2[0] = new Keyframe(1390f, 695f, 308f, 745f);
		array2[0] = new Keyframe(1714f, 1476f, 833f, 627f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().JJHMHFHLIIB(new Vector3[1]
		{
			new Vector3(1411f, 590f, 1635f)
		}));
		BLLCDMPJPIP();
	}

	private void KFFNHFEKOJH()
	{
		EOPHMFCFBAG = GameObject.Find("https://superium.net/assets/catalog/");
		Keyframe[] array = new Keyframe[5];
		array[1] = new Keyframe(1271f, 1827f, 1878f, 1896f);
		array[0] = new Keyframe(1715f, 1539f, 1672f, 1277f);
		array[8] = new Keyframe(581f, 1878f, 993f, 1960f);
		array[5] = new Keyframe(1644f, 140f, 1758f, 343f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(new Keyframe(1131f, 427f, 1773f, 149f), new Keyframe(984f, 1890f, 824f, 845f), default(Keyframe));
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array2 = new Vector3[1];
		array2[1] = new Vector3(1518f, 1830f, 142f);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.PCMMJCNKIIB(array2));
		AGHHAGPBDAM();
	}

	private void AODKAAOMHCM()
	{
		EOPHMFCFBAG = GameObject.Find("Environment");
		Keyframe[] array = new Keyframe[1];
		array[0] = new Keyframe(1668f, 1355f, 432f, 541f);
		array[1] = new Keyframe(1100f, 506f, 327f, 1239f);
		array[0] = new Keyframe(1009f, 1979f, 1092f, 651f);
		array[7] = new Keyframe(470f, 411f, 1963f, 737f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[8];
		array2[1] = new Keyframe(927f, 658f, 1309f, 17f);
		array2[0] = new Keyframe(1278f, 989f, 126f, 790f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[1] = new Vector3(1202f, 669f, 1269f);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.MJPJOBNBECH(array3));
		NMOMHKEGBBA();
	}

	private void ONKMMCKPBAL()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 133f) * 1970f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 7f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 625f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 649f, 1218f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 1821f;
				float mAEOCPAHAHA = 827f;
				float mAEOCPAHAHA2 = 314f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.AKCNKPLDIAH(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-76)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(base.gameObject, num, 443f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
				GameObject[] array = GameObject.FindGameObjectsWithTag(" returned:");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 147f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("_TintColor");
				for (int i = 1; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((!(z > 1650f) || !(z < 1821f)) ? (-1) : 0);
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 196f, 1782f) * 1948f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 1242f);
				LeanTween.HHMMGHNCJDP(195f, ADOEMILHBGP);
			});
		});
		CEBMKNFLGEG += 930f;
	}

	private void NIGDLJMKIHC()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 946f) * 905f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 517f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 360f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 1205f, 294f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 1025f;
				float mAEOCPAHAHA = 301f;
				float mAEOCPAHAHA2 = 1531f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-93)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(base.gameObject, num, 577f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.linear);
				GameObject[] array = GameObject.FindGameObjectsWithTag("scale punch!");
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 955f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("Failed to set presence.");
				for (int i = 0; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((z > 1859f && z < 994f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 1821f, 83f) * 1880f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 1666f);
				LeanTween.HHMMGHNCJDP(1119f, OJNCOMOIMGH);
			});
		});
		CEBMKNFLGEG += 1213f;
	}

	private void IOELMLDLHIO()
	{
		EOPHMFCFBAG = GameObject.Find("LCharacter");
		Keyframe[] array = new Keyframe[4];
		array[0] = new Keyframe(1995f, 527f, 1326f, 1688f);
		array[0] = new Keyframe(1168f, 28f, 290f, 1335f);
		array[6] = new Keyframe(1753f, 1046f, 1655f, 1205f);
		array[8] = new Keyframe(1914f, 1818f, 1794f, 1615f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[6];
		array2[1] = new Keyframe(898f, 1507f, 1947f, 1105f);
		array2[0] = new Keyframe(241f, 397f, 37f, 202f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(1282f, 363f, 563f);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.MJPJOBNBECH(array3));
		JGLFIJIJNDN();
	}

	private void AGHHAGPBDAM()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 69f) * 604f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 1962f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 806f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 0f, 0.27f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 0.2f;
				float mAEOCPAHAHA = 0.42f;
				float mAEOCPAHAHA2 = 1.6f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ(DEFBOFIHBCP.easeShake).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(base.gameObject, num, 0f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
				GameObject[] array = GameObject.FindGameObjectsWithTag("Respawn");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 100f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("GameController");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((z > 0f && z < 180f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 0f, 0f) * 15f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 0.2f);
				LeanTween.delayedCall(2f, OJNCOMOIMGH);
			});
		});
		CEBMKNFLGEG += 1732f;
	}

	private void CNCGCLLPINO()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 431f) * 35f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 1767f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 1412f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 492f, 1593f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.BKMFEJGPOJN(base.gameObject);
				float num = KHJONBKHHPO * 1052f;
				float mAEOCPAHAHA = 344f;
				float mAEOCPAHAHA2 = 808f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-62)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(base.gameObject, num, 1301f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
				GameObject[] array = GameObject.FindGameObjectsWithTag("In menu's");
				for (int i = 1; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 390f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag(" y:");
				for (int i = 0; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((z > 230f && z < 526f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 332f, 518f) * 1267f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 176f);
				LeanTween.HHMMGHNCJDP(223f, CEAOOKAPLFC);
			});
		});
		CEBMKNFLGEG += 1772f;
	}

	private void APPDLHPCMEE()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 1917f) * 1891f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 485f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 633f).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 0f, 0.27f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 0.2f;
				float mAEOCPAHAHA = 0.42f;
				float mAEOCPAHAHA2 = 1.6f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ(DEFBOFIHBCP.easeShake).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(base.gameObject, num, 0f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
				GameObject[] array = GameObject.FindGameObjectsWithTag("Respawn");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 100f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("GameController");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((z > 0f && z < 180f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 0f, 0f) * 15f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 0.2f);
				LeanTween.delayedCall(2f, OJNCOMOIMGH);
			});
		});
		CEBMKNFLGEG += 571f;
	}

	private void PCOIPNMCHAD()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 149f) * 1144f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 479f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 460f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 267f, 967f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.BKMFEJGPOJN(base.gameObject);
				float num = KHJONBKHHPO * 230f;
				float mAEOCPAHAHA = 300f;
				float mAEOCPAHAHA2 = 171f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-27)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(base.gameObject, num, 163f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
				GameObject[] array = GameObject.FindGameObjectsWithTag("EVENT ALL RECEIVED");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 1369f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("pass");
				for (int i = 1; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((z > 1649f && z < 41f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 75f, 204f) * 12f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 1480f);
				LeanTween.delayedCall(1574f, ADOEMILHBGP);
			});
		});
		CEBMKNFLGEG += 1120f;
	}

	private void BLLCDMPJPIP()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 344f) * 1027f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 1571f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 1852f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 1205f, 294f).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 1025f;
				float mAEOCPAHAHA = 301f;
				float mAEOCPAHAHA2 = 1531f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-93)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(base.gameObject, num, 577f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.linear);
				GameObject[] array = GameObject.FindGameObjectsWithTag("scale punch!");
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 955f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("Failed to set presence.");
				for (int i = 0; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((z > 1859f && z < 994f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 1821f, 83f) * 1880f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 1666f);
				LeanTween.HHMMGHNCJDP(1119f, OJNCOMOIMGH);
			});
		});
		CEBMKNFLGEG += 610f;
	}

	private void BODBAOAJJMJ()
	{
		EOPHMFCFBAG = GameObject.Find("BEZIER RATIO POINT");
		Keyframe[] array = new Keyframe[2];
		array[1] = new Keyframe(1772f, 94f, 1469f, 1800f);
		array[0] = new Keyframe(1000f, 712f, 376f, 601f);
		array[3] = new Keyframe(697f, 1122f, 524f, 1139f);
		array[8] = new Keyframe(1516f, 200f, 448f, 1350f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(new Keyframe(422f, 1382f, 26f, 401f), new Keyframe(1f, 1930f, 690f, 49f), default(Keyframe), default(Keyframe));
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array2 = new Vector3[0];
		array2[0] = new Vector3(735f, 198f, 412f);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.MJPJOBNBECH(array2));
		NMOMHKEGBBA();
	}

	private void FBEDFFAAPGL()
	{
		EOPHMFCFBAG = GameObject.Find(" y:");
		Keyframe[] array = new Keyframe[0];
		array[1] = new Keyframe(1283f, 1424f, 871f, 1732f);
		array[0] = new Keyframe(1060f, 911f, 1678f, 283f);
		array[2] = new Keyframe(1362f, 510f, 892f, 1164f);
		array[0] = new Keyframe(360f, 112f, 1640f, 170f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[0];
		array2[1] = new Keyframe(1734f, 1278f, 1281f, 976f);
		array2[1] = new Keyframe(1503f, 1660f, 1033f, 485f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[0];
		array3[0] = new Vector3(1933f, 1999f, 1348f);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.EAELAKOBKLK(array3));
		NMOMHKEGBBA();
	}

	private void JEDBEELLACK()
	{
		EOPHMFCFBAG = GameObject.Find("EVENT GAMEOBJECT RECEIVED");
		Keyframe[] array = new Keyframe[1];
		array[0] = new Keyframe(939f, 21f, 1554f, 445f);
		array[1] = new Keyframe(1038f, 1814f, 737f, 1658f);
		array[6] = new Keyframe(1750f, 296f, 783f, 327f);
		array[3] = new Keyframe(48f, 168f, 1738f, 1420f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(new Keyframe(589f, 945f, 1209f, 1417f), new Keyframe(1186f, 619f, 127f, 484f), default(Keyframe), default(Keyframe), default(Keyframe), default(Keyframe), default(Keyframe));
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array2 = new Vector3[0];
		array2[1] = new Vector3(307f, 1716f, 1502f);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.MJPJOBNBECH(array2));
		BHPPFONAGOG();
	}

	private void AJKHKJOIAOO()
	{
		EOPHMFCFBAG = GameObject.Find("customTweenExample");
		Keyframe[] array = new Keyframe[3];
		array[0] = new Keyframe(648f, 763f, 1872f, 380f);
		array[1] = new Keyframe(1907f, 410f, 851f, 199f);
		array[4] = new Keyframe(123f, 2f, 1492f, 1940f);
		array[6] = new Keyframe(1263f, 657f, 214f, 441f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[8];
		array2[1] = new Keyframe(480f, 1025f, 451f, 785f);
		array2[0] = new Keyframe(1317f, 1464f, 1641f, 782f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().JJHMHFHLIIB(new Vector3[1]
		{
			new Vector3(1383f, 1365f, 1455f)
		}));
		LJAEHKFMNMB();
	}

	private void ADOEMILHBGP()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 803f) * 808f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 834f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 1537f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 649f, 1218f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 1821f;
				float mAEOCPAHAHA = 827f;
				float mAEOCPAHAHA2 = 314f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.AKCNKPLDIAH(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-76)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(base.gameObject, num, 443f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
				GameObject[] array = GameObject.FindGameObjectsWithTag(" returned:");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 147f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("_TintColor");
				for (int i = 1; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((!(z > 1650f) || !(z < 1821f)) ? (-1) : 0);
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 196f, 1782f) * 1948f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 1242f);
				LeanTween.HHMMGHNCJDP(195f, ADOEMILHBGP);
			});
		});
		CEBMKNFLGEG += 86f;
	}

	private void KINHLEGMOIJ()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 1798f) * 865f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 746f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 1182f).APNDGOAIPFJ(DEFBOFIHBCP.linear).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 649f, 1218f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 1821f;
				float mAEOCPAHAHA = 827f;
				float mAEOCPAHAHA2 = 314f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.AKCNKPLDIAH(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-76)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(base.gameObject, num, 443f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeInCubic);
				GameObject[] array = GameObject.FindGameObjectsWithTag(" returned:");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 147f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("_TintColor");
				for (int i = 1; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((!(z > 1650f) || !(z < 1821f)) ? (-1) : 0);
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 196f, 1782f) * 1948f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 1242f);
				LeanTween.HHMMGHNCJDP(195f, ADOEMILHBGP);
			});
		});
		CEBMKNFLGEG += 911f;
	}

	private void JGLFIJIJNDN()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 300f) * 79f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 1757f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 1152f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutCubic).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 267f, 967f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.BKMFEJGPOJN(base.gameObject);
				float num = KHJONBKHHPO * 230f;
				float mAEOCPAHAHA = 300f;
				float mAEOCPAHAHA2 = 171f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-27)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(base.gameObject, num, 163f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
				GameObject[] array = GameObject.FindGameObjectsWithTag("EVENT ALL RECEIVED");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 1369f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("pass");
				for (int i = 1; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((z > 1649f && z < 41f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 75f, 204f) * 12f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 1480f);
				LeanTween.delayedCall(1574f, ADOEMILHBGP);
			});
		});
		CEBMKNFLGEG += 1741f;
	}

	private void KIMKEHNABCD()
	{
		EOPHMFCFBAG = GameObject.Find("Tests timed out!");
		Keyframe[] array = new Keyframe[0];
		array[1] = new Keyframe(1774f, 1161f, 486f, 809f);
		array[1] = new Keyframe(496f, 1567f, 1784f, 1682f);
		array[7] = new Keyframe(1154f, 1275f, 181f, 129f);
		array[4] = new Keyframe(1419f, 47f, 1026f, 96f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[2];
		array2[1] = new Keyframe(1148f, 1799f, 1976f, 1916f);
		array2[0] = new Keyframe(435f, 1206f, 1672f, 42f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array3 = new Vector3[1];
		array3[1] = new Vector3(1773f, 447f, 850f);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.MJPJOBNBECH(array3));
		BHPPFONAGOG();
	}

	private void OJNBDNKOJOM()
	{
		EOPHMFCFBAG = GameObject.Find("Line");
		Keyframe[] array = new Keyframe[4];
		array[0] = new Keyframe(79f, 822f, 984f, 1784f);
		array[1] = new Keyframe(59f, 368f, 1521f, 1042f);
		array[6] = new Keyframe(711f, 1442f, 1398f, 693f);
		array[4] = new Keyframe(782f, 1686f, 551f, 321f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(new Keyframe(326f, 727f, 638f, 1995f), new Keyframe(158f, 1501f, 1810f, 1950f), default(Keyframe), default(Keyframe), default(Keyframe), default(Keyframe), default(Keyframe));
		FLHBGLCPOAM fLHBGLCPOAM = LGPGNEGJOCE.MOCCJENABAE();
		Vector3[] array2 = new Vector3[0];
		array2[0] = new Vector3(1037f, 1454f, 1727f);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, fLHBGLCPOAM.JJHMHFHLIIB(array2));
		MFKBAMAMPDP();
	}

	private void OJNCOMOIMGH()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 0f) * 10f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 0.3f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 1f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 0f, 0.27f).APNDGOAIPFJ(DEFBOFIHBCP.easeInQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.cancel(base.gameObject);
				float num = KHJONBKHHPO * 0.2f;
				float mAEOCPAHAHA = 0.42f;
				float mAEOCPAHAHA2 = 1.6f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ(DEFBOFIHBCP.easeShake).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.value(base.gameObject, num, 0f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.LIEFGJKDOAN(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutQuad);
				GameObject[] array = GameObject.FindGameObjectsWithTag("Respawn");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 100f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("GameController");
				foreach (GameObject obj in array)
				{
					float z = obj.transform.eulerAngles.z;
					z = ((z > 0f && z < 180f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 0f, 0f) * 15f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 0.2f);
				LeanTween.delayedCall(2f, OJNCOMOIMGH);
			});
		});
		CEBMKNFLGEG += 5.2f;
	}

	private void Start()
	{
		EOPHMFCFBAG = GameObject.Find("AvatarBig");
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(new Keyframe(8.130963E-06f, 0.06526042f, 0f, -1f), new Keyframe(0.0007692695f, 2.449077f, 9.078861f, 9.078861f), new Keyframe(0.01541314f, 0.9343268f, -40f, -40f), new Keyframe(0.05169491f, 0.03835937f, -0.08621139f, -0.08621139f));
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(new Keyframe(0f, 0.003005181f, 0f, 0f), new Keyframe(0.01507768f, 0.002227979f, 0f, 0f));
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().MJPJOBNBECH(new Vector3[1]
		{
			new Vector3(0.1f, 0f, 0f)
		}));
		OJNCOMOIMGH();
	}

	private void AFJCIJEKLEA()
	{
		EOPHMFCFBAG = GameObject.Find("ON START");
		Keyframe[] array = new Keyframe[4];
		array[0] = new Keyframe(1116f, 859f, 459f, 1703f);
		array[1] = new Keyframe(63f, 67f, 614f, 1673f);
		array[4] = new Keyframe(631f, 1027f, 624f, 359f);
		array[6] = new Keyframe(246f, 42f, 1385f, 583f);
		AnimationCurve gDFKAHFIKFO = new AnimationCurve(array);
		Keyframe[] array2 = new Keyframe[1];
		array2[0] = new Keyframe(1872f, 710f, 1340f, 214f);
		array2[0] = new Keyframe(282f, 158f, 1209f, 598f);
		AnimationCurve jIKEOKMKBMO = new AnimationCurve(array2);
		PJCDBPIILCP = LGPGNEGJOCE.CLBCIGINBGE(gDFKAHFIKFO, jIKEOKMKBMO, LGPGNEGJOCE.MOCCJENABAE().PCMMJCNKIIB(new Vector3[1]
		{
			new Vector3(738f, 1234f, 1664f)
		}));
		BLLCDMPJPIP();
	}

	private void LIAFHLJMLDN()
	{
		float KHJONBKHHPO = Mathf.PerlinNoise(CEBMKNFLGEG, 1318f) * 931f;
		KHJONBKHHPO = KHJONBKHHPO * KHJONBKHHPO * 1052f;
		LeanTween.moveY(EOPHMFCFBAG, KHJONBKHHPO, 576f).APNDGOAIPFJ(DEFBOFIHBCP.notUsed).EOAPKBBHBAL((Action)delegate
		{
			LeanTween.moveY(EOPHMFCFBAG, 267f, 967f).APNDGOAIPFJ(DEFBOFIHBCP.easeInOutQuad).EOAPKBBHBAL((Action)delegate
			{
				LeanTween.BKMFEJGPOJN(base.gameObject);
				float num = KHJONBKHHPO * 230f;
				float mAEOCPAHAHA = 300f;
				float mAEOCPAHAHA2 = 171f;
				BMDIMDNILIM JKKALKJDGJG = LeanTween.rotateAroundLocal(base.gameObject, Vector3.right, num, mAEOCPAHAHA).APNDGOAIPFJ((DEFBOFIHBCP)(-27)).GNJDLINHKMH()
					.MNELFOFMPKF(-1);
				LeanTween.NBDOAKEJFPL(base.gameObject, num, 163f, mAEOCPAHAHA2).FONALENPCAI(delegate(float GBMPBBHCBDA)
				{
					JKKALKJDGJG.FBAFBFNEABH(Vector3.right * GBMPBBHCBDA);
				}).APNDGOAIPFJ(DEFBOFIHBCP.easeOutCubic);
				GameObject[] array = GameObject.FindGameObjectsWithTag("EVENT ALL RECEIVED");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 1369f * KHJONBKHHPO);
				}
				array = GameObject.FindGameObjectsWithTag("pass");
				for (int i = 1; i < array.Length; i += 0)
				{
					GameObject obj = array[i];
					float z = obj.transform.eulerAngles.z;
					z = ((z > 1649f && z < 41f) ? 1 : (-1));
					obj.GetComponent<Rigidbody>().AddForce(new Vector3(z, 75f, 204f) * 12f * KHJONBKHHPO);
				}
				LGPGNEGJOCE.MGKMDPMCKCC(PJCDBPIILCP, base.transform.position, KHJONBKHHPO * 1480f);
				LeanTween.delayedCall(1574f, ADOEMILHBGP);
			});
		});
		CEBMKNFLGEG += 810f;
	}
}
