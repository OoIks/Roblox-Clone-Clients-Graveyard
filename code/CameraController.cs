using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform target;
	public float distance;
	public float xSpeed;
	public float ySpeed;
	public float yMinLimit;
	public float yMaxLimit;
	public float minDist;
	public float maxDist;
	public float scrollSensitivity;
	public bool clipThroughWalls;
}
