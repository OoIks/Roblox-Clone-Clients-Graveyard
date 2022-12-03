using Mirror;
using UnityEngine;

public class ScriptManager : NetworkBehaviour
{
	[TextAreaAttribute]
	public string scriptCode;
	public GameObject partPrefab;
}
