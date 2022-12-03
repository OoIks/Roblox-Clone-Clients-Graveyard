// Explosion
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Interop;
using UnityEngine;

[MoonSharpUserData]
public class Explosion : Instance
{
	[MoonSharpVisible(false)]
	public bool affectKinematic;

	[MoonSharpVisible(false)]
	public float radius = 32f;

	[MoonSharpVisible(false)]
	public Vector3 position = Vector3.zero;

	[MoonSharpVisible(false)]
	public float force = 10f;

	[MoonSharpVisible(false)]
	public bool explodeOnSpawn;

	[MoonSharpVisible(false)]
	public float upwardsModifier = 3f;

	public bool AffectKinematic
	{
		get
		{
			return affectKinematic;
		}
		set
		{
			affectKinematic = value;
		}
	}

	public float Radius
	{
		get
		{
			return radius;
		}
		set
		{
			radius = value;
		}
	}

	public Vector3 Position
	{
		get
		{
			return position;
		}
		set
		{
			position = value;
		}
	}

	public float Force
	{
		get
		{
			return force;
		}
		set
		{
			force = value;
		}
	}

	public Explosion()
		: base("Explosion")
	{
		if (explodeOnSpawn)
		{
			Activate();
		}
	}

	public void Activate()
	{
		Destroy();
	}

	public static void CreateExplosion(Vector3 position, float radius, float force, bool affectKinematic)
	{
		Explosion explosion = new Explosion();
		explosion.position = position;
		explosion.radius = radius;
		explosion.force = force;
		explosion.affectKinematic = affectKinematic;
		explosion.upwardsModifier = 3f;
		Instance.game["Environment"].AddChild(explosion);
		explosion.PropertiesUpdated();
	}

	public static void CreateExplosion(Vector3 position, float radius, float force, bool affectKinematic, float upwardsModifier)
	{
		Explosion explosion = new Explosion();
		explosion.position = position;
		explosion.radius = radius;
		explosion.force = force;
		explosion.affectKinematic = affectKinematic;
		explosion.upwardsModifier = upwardsModifier;
		Instance.game["Environment"].AddChild(explosion);
		explosion.PropertiesUpdated();
	}
}
