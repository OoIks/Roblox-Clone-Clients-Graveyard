// Part
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Interop;
using System;
using UnityEngine;

[MoonSharpUserData]
public class Part : Instance
{
	[MoonSharpVisible(false)]
	public Vector3 position;

	[MoonSharpVisible(false)]
	public Vector3 rotation;

	[MoonSharpVisible(false)]
	public Vector3 scale;

	[MoonSharpVisible(false)]
	public bool isKinematic;

	[MoonSharpVisible(false)]
	public string color;

	[MoonSharpVisible(false)]
	public string shape;

	public Vector3 Position
	{
		get
		{
			return position;
		}
		set
		{
			position = value;
			PropertiesUpdated();
		}
	}

	[MoonSharpProperty]
	public Vector3 Scale
	{
		get
		{
			return scale;
		}
		set
		{
			scale = value;
			PropertiesUpdated();
		}
	}

	[MoonSharpProperty]
	public Vector3 Rotation
	{
		get
		{
			return rotation;
		}
		set
		{
			rotation = value;
			PropertiesUpdated();
		}
	}

	[MoonSharpProperty]
	public bool Kinematic
	{
		get
		{
			return isKinematic;
		}
		set
		{
			isKinematic = value;
			PropertiesUpdated();
		}
	}

	[MoonSharpProperty]
	public string Color
	{
		get
		{
			return color;
		}
		set
		{
			color = value;
			PropertiesUpdated();
		}
	}

	[MoonSharpProperty]
	public string Shape
	{
		get
		{
			return shape;
		}
		set
		{
			shape = value;
			PropertiesUpdated();
		}
	}

	[MoonSharpVisible(true)]
	public event EventHandler Touched;

	public Part()
		: base("Part")
	{
		name = "Part";
		position = new Vector3(0f, 0f, 0f);
		rotation = new Vector3(0f, 0f, 0f);
		scale = new Vector3(1f, 1f, 1f);
		isKinematic = true;
		color = "#A3A2A4";
		shape = "cube";
		PropertiesUpdated();
	}

	public Part Clone()
	{
		Part part = new Part();
		part.position = position;
		part.rotation = rotation;
		part.scale = scale;
		part.isKinematic = isKinematic;
		part.color = color;
		part.shape = shape;
		part.name = name;
		part.SetParent(base.Parent);
		return part;
	}

	public void InvokeTouch()
	{
		Debug.Log("Got invoketouch call");
		if (this.Touched != null)
		{
			this.Touched(this, EventArgs.Empty);
		}
	}
}
