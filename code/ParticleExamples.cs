using System;
using UnityEngine;

[Serializable]
public class ParticleExamples
{
	public string title;
	[TextAreaAttribute]
	public string description;
	public bool isWeaponEffect;
	public GameObject particleSystemGO;
	public Vector3 particlePosition;
	public Vector3 particleRotation;
}
