// DiscordHandler
using Discord;
using System;
using UnityEngine;

public class DiscordHandler : MonoBehaviour
{
	public Discord.Discord discord;

	public void SetImage(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Failed to set presence.");
			}
		});
	}

	public void EJPHLIIBPNN(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("");
			}
		});
	}

	public void ENMGKEGGJKJ(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Wearables");
			}
		});
	}

	public void MEPBGCHHGMO(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("game:");
			}
		});
	}

	private void FBEDFFAAPGL()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(5L, 1uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = "VALUE2 UPDATE",
			Details = " id:",
			Assets = 
			{
				LargeImage = "EaseSpring",
				LargeText = "Meat"
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("alphaExample");
			}
		});
	}

	public void GMNENPCHEEC(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("AvatarBig");
			}
		});
	}

	private void JBFLACPKBCB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(-754L, 0uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = "EaseInOutCirc",
			Details = "Explosion",
			Assets = 
			{
				LargeImage = "http://www.starscenesoftware.com/objtest/Spot.obj",
				LargeText = "SPLINE CLOSED LOOP SHOULD END AT START"
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("timeScale:");
			}
		});
	}

	private void GIGPKNOPJFJ()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	private void LNKGNFEJHCA()
	{
		Debug.Log("START IGNORE TIMING");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("bRound");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	private void PEIIGOHMMNE()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	public void NFKGOLMEPNP(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Mouse Y");
			}
		});
	}

	private void FNDNADJAJFJ()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	private void IBFHEIJAOGK()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	public void HOCJPHAEIHK(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("game:");
			}
		});
	}

	public void BLAGICKEBCD(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Mouse Y");
			}
		});
	}

	public void JIHOLPAEGFP(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("_TintColor");
			}
		});
	}

	private void Start()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(715468601540476959L, 0uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = "In menu's",
			Details = "Waiting for a server",
			Assets = 
			{
				LargeImage = "logo",
				LargeText = "Waiting"
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Failed to set presence.");
			}
		});
	}

	public void DNJFACJMELF(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("https://superium.net/assets/catalog/");
			}
		});
	}

	private void LIFOFHMIDKA()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	private void BBNOEKBJJFC()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	public void KECPBNGIIPG(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("cancel variable time");
			}
		});
	}

	private void HJOPBBJKFBE()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(-751L, 1uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = "",
			Details = "current_game_playing",
			Assets = 
			{
				LargeImage = "Player",
				LargeText = "SEQ SCALE X FINISHED"
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("yo");
			}
		});
	}

	public void MIOGDKDGAPM(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("EaseInElastic");
			}
		});
	}

	private void MJBAPNCKMKM()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(1558L, 1uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = "Part",
			Details = "Waiting for a server",
			Assets = 
			{
				LargeImage = "auth",
				LargeText = "rotateFinished hash:"
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("<b>");
			}
		});
	}

	private void ODBDLBIFLCH()
	{
		Debug.Log("rotateExample");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("TOKEN_NOT_SET");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	public void DLNGJJHEFBK(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("bSpline");
			}
		});
	}

	private void FGIPNFFOHFN()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(1976L, 1uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = "COLOR",
			Details = "GROUP RESUME",
			Assets = 
			{
				LargeImage = "Leaderboard",
				LargeText = "ON START WAS CALLED"
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("<b>");
			}
		});
	}

	private void LLMJNKDNEDI()
	{
		Debug.Log("EaseShake");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("bRound");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	public void CMJKGOLIHME(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("game:");
			}
		});
	}

	private void LLJHEFBJCCB()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	public void EOHOMNPODOI(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("current_game_playing");
			}
		});
	}

	private void FDMCPGODMJI()
	{
		Debug.Log(".btw");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("endless");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	private void HEPACNIHKPP()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(1223L, 0uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = "https://superium.net/assets/catalog/",
			Details = ">",
			Assets = 
			{
				LargeImage = "game_name",
				LargeText = "move path finished"
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError(".png");
			}
		});
	}

	private void GIKBDCGLEEM()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	public void CJGPGJCJOAA(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Loading... ");
			}
		});
	}

	private void OnApplicationQuit()
	{
		Debug.Log("Discord RPC: Clearing activity");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("Failed to clear Discord Presence!");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	private void GAOJDAJACPG()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	private void EOGAMOODACI()
	{
		Debug.Log("");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("https://superium.net/assets/catalog/");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	private void FGFLCFGDHNC()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(-160L, 1uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = "Import",
			Details = "Waiting",
			Assets = 
			{
				LargeImage = "grounded",
				LargeText = "Wearables"
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Rotate");
			}
		});
	}

	public void KMKJNHFBGAE(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("EaseInElastic");
			}
		});
	}

	private void JINKHEPNNLA()
	{
		Debug.Log("port");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("LeanTween - When passing values for a vector path, you must pass four or more values!");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	private void DHDADJJCBEH()
	{
		Debug.Log("Client started.");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("https://superium.net/assets/catalog/");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	private void FGFKPOANKIN()
	{
		Debug.Log(", ");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("LeanTween - When passing values for a vector path, you must pass four or more values!");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	public void HCNIIPMPPNL(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("><b>");
			}
		});
	}

	public void PONPGHANJEC(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("MOVE LOCAL Z");
			}
		});
	}

	private void OMJOKDKAAJP()
	{
		Debug.Log("Waiting");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("Failed to clear Discord Presence!");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	private void IACKMLAIEKO()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	public void GABPGLALBDD(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Wearables");
			}
		});
	}

	private void PDNKACEECLJ()
	{
		Debug.Log("Prefabs/");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("LeanTween - When passing values for a vector path, you must pass four or more values!");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	private void FFONODKBHGM()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(430L, 0uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = " FAILED: ",
			Details = "thumbnailurl",
			Assets = 
			{
				LargeImage = "https://superium.net/assets/thumbnails/games/banners/",
				LargeText = "shirt"
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("loopTestClamp Time:");
			}
		});
	}

	public void GINILILIMKC(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Environment");
			}
		});
	}

	private void FLGMDCCIJKJ()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(597L, 0uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = "PlaceFile",
			Details = "cube",
			Assets = 
			{
				LargeImage = "J",
				LargeText = "Playing as "
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError(".png");
			}
		});
	}

	private void IPMJEBFCEKF()
	{
		Debug.Log("In game");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("bRound");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	private void EHLNFILPDOD()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	public void HAKIIFNGODL(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Playing as Player");
			}
		});
	}

	public void BEDEJMKKEJC(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("bSpline");
			}
		});
	}

	private void KFPLGLDKBPF()
	{
		Debug.Log("</color>: </b>");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("TOKEN_NOT_SET");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	private void JCALDGKFAPL()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(-1291L, 1uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = "grounded",
			Details = "Error loading file",
			Assets = 
			{
				LargeImage = "<",
				LargeText = "Player"
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("rotateExample");
			}
		});
	}

	private void CEKEHKACNHN()
	{
		Debug.Log("Prefabs/");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("Failed to clear Discord Presence!");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	public void PMELPAHMDEN(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Playing as Player");
			}
		});
	}

	private void NADKKNFLGHD()
	{
		Debug.Log("EaseOutQuad");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("WE CAN RETRIEVE A DESCRIPTION");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	private void Update()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	private void FIAGINNCCFB()
	{
		Debug.Log("http://superium.net/api/GetHostData?token=");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("TOKEN_NOT_SET");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	private void HEPAMDACOJD()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(1387L, 0uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = "BodyColors",
			Details = "leftleg",
			Assets = 
			{
				LargeImage = "~LeanTween",
				LargeText = "Prefabs/"
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("GROUP ISTWEENING");
			}
		});
	}

	private void HNGCGALADEI()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(-1498L, 1uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = "EaseOutExpo",
			Details = "GameThumbnail",
			Assets = 
			{
				LargeImage = "mp_auth",
				LargeText = "wedge"
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("GROUP ISTWEENING");
			}
		});
	}

	private void MCAOPIPBHAO()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	private void CMKLLDPHOEL()
	{
		try
		{
			discord.RunCallbacks();
		}
		catch (Exception)
		{
		}
	}

	public void HELCKDJKLNG(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("EaseOutExpo");
			}
		});
	}

	public void SetActivity(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Failed to set presence.");
			}
		});
	}

	private void DBCPHGOJMDI()
	{
		Debug.Log("zeroCube");
		discord.GetActivityManager().ClearActivity(delegate(Result KCLBCAOGDIN)
		{
			if (KCLBCAOGDIN != 0)
			{
				Debug.LogError("BodyColors");
			}
			Debug.Log(KCLBCAOGDIN);
		});
	}

	private void JGKGCJBIJIP()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		discord = new Discord.Discord(-628L, 0uL);
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = "PlaceID",
			Details = "EaseInOutQuart",
			Assets = 
			{
				LargeImage = "CmdUpdateUserData",
				LargeText = ""
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("timeScale:");
			}
		});
	}

	public void FMHIIMBLMBB(string ACMKHBONLMN, string AIKKFDEMKAE, string FJHADKGJOPC, string IKCNLOPOCJE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		Activity activity = new Activity
		{
			State = ACMKHBONLMN,
			Details = AIKKFDEMKAE,
			Assets = 
			{
				LargeImage = FJHADKGJOPC,
				LargeText = IKCNLOPOCJE
			}
		};
		activityManager.UpdateActivity(activity, delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Environment");
			}
		});
	}

	public void AOJGODMHODE(string OJDCIFFLDIE)
	{
		ActivityManager activityManager = discord.GetActivityManager();
		activityManager.ClearActivity(delegate
		{
		});
		activityManager.UpdateActivity(default(Activity), delegate(Result ADCBOPOHBNI)
		{
			if (ADCBOPOHBNI != 0)
			{
				Debug.LogError("Playing as Player");
			}
		});
	}
}
