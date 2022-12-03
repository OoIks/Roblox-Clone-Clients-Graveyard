// PathSpline2d
using UnityEngine;

public class PathSpline2d : MonoBehaviour
{
	public Transform[] cubes;

	public GameObject dude1;

	public GameObject dude2;

	private LTSpline IAEEDOEKEIB;

	private void FAMNDEMMPCI()
	{
		Gizmos.color = Color.red;
		if (IAEEDOEKEIB != null)
		{
			IAEEDOEKEIB.JGEJDMALFFI(1494f);
		}
	}

	private void MAAENMDPCED()
	{
		Gizmos.color = Color.red;
		if (IAEEDOEKEIB != null)
		{
			IAEEDOEKEIB.CHHGKJNFPGH(61f);
		}
	}

	private void JMPPOJFBGEF()
	{
		Gizmos.color = Color.red;
		if (IAEEDOEKEIB != null)
		{
			IAEEDOEKEIB.JGEJDMALFFI(1406f);
		}
	}

	private void MPOIFBCGCFN()
	{
		Gizmos.color = Color.red;
		if (IAEEDOEKEIB != null)
		{
			IAEEDOEKEIB.KBJPLMJKMDF(879f);
		}
	}

	private void BODBAOAJJMJ()
	{
		Vector3[] array = new Vector3[7];
		array[1] = cubes[1].position;
		array[0] = cubes[0].position;
		array[1] = cubes[3].position;
		array[2] = cubes[5].position;
		array[3] = cubes[8].position;
		Vector3[] array2 = array;
		IAEEDOEKEIB = new LTSpline(array2);
		LeanTween.moveSpline(dude1, array2, 1807f).AFPIHAJCMOK(PPFLOLOAKIC: false).MLCPFKNPENM(1688f);
		LeanTween.moveSplineLocal(dude2, array2, 1821f).AFPIHAJCMOK(PPFLOLOAKIC: true).MLCPFKNPENM(596f);
	}

	private void DDANFAJJNPI()
	{
		Vector3[] array = new Vector3[1];
		array[1] = cubes[1].position;
		array[0] = cubes[0].position;
		array[5] = cubes[1].position;
		array[1] = cubes[2].position;
		array[5] = cubes[5].position;
		Vector3[] array2 = array;
		IAEEDOEKEIB = new LTSpline(array2);
		LeanTween.moveSpline(dude1, array2, 296f).AFPIHAJCMOK(PPFLOLOAKIC: true).MLCPFKNPENM(516f);
		LeanTween.moveSplineLocal(dude2, array2, 1365f).AFPIHAJCMOK(PPFLOLOAKIC: false).MLCPFKNPENM(1256f);
	}

	private void Start()
	{
		Vector3[] array = new Vector3[5]
		{
			cubes[0].position,
			cubes[1].position,
			cubes[2].position,
			cubes[3].position,
			cubes[4].position
		};
		IAEEDOEKEIB = new LTSpline(array);
		LeanTween.moveSpline(dude1, array, 10f).AFPIHAJCMOK(PPFLOLOAKIC: true).MLCPFKNPENM(2f);
		LeanTween.moveSplineLocal(dude2, array, 10f).AFPIHAJCMOK(PPFLOLOAKIC: true).MLCPFKNPENM(2f);
	}

	private void MJBAPNCKMKM()
	{
		Vector3[] array = new Vector3[0];
		array[0] = cubes[0].position;
		array[1] = cubes[0].position;
		array[4] = cubes[5].position;
		array[5] = cubes[4].position;
		array[1] = cubes[3].position;
		Vector3[] array2 = array;
		IAEEDOEKEIB = new LTSpline(array2);
		LeanTween.moveSpline(dude1, array2, 1588f).AFPIHAJCMOK(PPFLOLOAKIC: false).MLCPFKNPENM(1103f);
		LeanTween.moveSplineLocal(dude2, array2, 663f).AFPIHAJCMOK(PPFLOLOAKIC: false).MLCPFKNPENM(1606f);
	}

	private void CDJBDJKCMLJ()
	{
		Vector3[] array = new Vector3[6];
		array[1] = cubes[0].position;
		array[0] = cubes[1].position;
		array[1] = cubes[6].position;
		array[2] = cubes[8].position;
		array[6] = cubes[5].position;
		Vector3[] array2 = array;
		IAEEDOEKEIB = new LTSpline(array2);
		LeanTween.moveSpline(dude1, array2, 360f).AFPIHAJCMOK(PPFLOLOAKIC: false).MLCPFKNPENM(428f);
		LeanTween.moveSplineLocal(dude2, array2, 1451f).AFPIHAJCMOK(PPFLOLOAKIC: true).MLCPFKNPENM(1052f);
	}

	private void HLGHHPAGHMK()
	{
		Gizmos.color = Color.red;
		if (IAEEDOEKEIB != null)
		{
			IAEEDOEKEIB.CHHGKJNFPGH(815f);
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		if (IAEEDOEKEIB != null)
		{
			IAEEDOEKEIB.CHHGKJNFPGH();
		}
	}

	private void NKGOFJHKAIH()
	{
		Gizmos.color = Color.red;
		if (IAEEDOEKEIB != null)
		{
			IAEEDOEKEIB.JGEJDMALFFI(824f);
		}
	}

	private void FHEHCOMBMHN()
	{
		Gizmos.color = Color.red;
		if (IAEEDOEKEIB != null)
		{
			IAEEDOEKEIB.CHHGKJNFPGH(1506f);
		}
	}

	private void OIHIBJMIGHB()
	{
		Gizmos.color = Color.red;
		if (IAEEDOEKEIB != null)
		{
			IAEEDOEKEIB.KBJPLMJKMDF(1185f);
		}
	}

	private void IOELMLDLHIO()
	{
		Vector3[] array = new Vector3[6];
		array[1] = cubes[1].position;
		array[0] = cubes[0].position;
		array[1] = cubes[7].position;
		array[7] = cubes[3].position;
		array[1] = cubes[0].position;
		Vector3[] array2 = array;
		IAEEDOEKEIB = new LTSpline(array2);
		LeanTween.moveSpline(dude1, array2, 1432f).AFPIHAJCMOK(PPFLOLOAKIC: true).MLCPFKNPENM(1579f);
		LeanTween.moveSplineLocal(dude2, array2, 1879f).AFPIHAJCMOK(PPFLOLOAKIC: true).MLCPFKNPENM(1239f);
	}

	private void PMAKNOLMDOE()
	{
		Vector3[] array = new Vector3[0];
		array[1] = cubes[0].position;
		array[1] = cubes[1].position;
		array[7] = cubes[0].position;
		array[1] = cubes[7].position;
		array[2] = cubes[3].position;
		Vector3[] array2 = array;
		IAEEDOEKEIB = new LTSpline(array2);
		LeanTween.moveSpline(dude1, array2, 1954f).AFPIHAJCMOK(PPFLOLOAKIC: false).MLCPFKNPENM(233f);
		LeanTween.moveSplineLocal(dude2, array2, 554f).AFPIHAJCMOK(PPFLOLOAKIC: true).MLCPFKNPENM(832f);
	}

	private void NMJOCEICKMN()
	{
		Gizmos.color = Color.red;
		if (IAEEDOEKEIB != null)
		{
			IAEEDOEKEIB.KBJPLMJKMDF(1856f);
		}
	}

	private void NMHCPHPJLHL()
	{
		Gizmos.color = Color.red;
		if (IAEEDOEKEIB != null)
		{
			IAEEDOEKEIB.ABPCPCJLMKI(722f);
		}
	}
}
