// Instance
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class Instance
{
	public string name;

	public static Game game;

	protected Action<Instance> cb_propertiesUpdated;

	private IDictionary<string, Instance> children = new Dictionary<string, Instance>();

	private Instance parentInstance;

	private string classname;

	public string uuid;

	public GameObject linkedObject;

	public bool canDelete
	{
		get;
		set;
	}

	public string ClassName => classname;

	public Instance this[string name] => FindChild(name);

	public Instance Parent
	{
		get
		{
			return parentInstance;
		}
		set
		{
			SetParent(value);
		}
	}

	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			name = value;
		}
	}

	public event EventHandler ChildAdded;

	public event EventHandler ChildRemoved;

	public event EventHandler Destroyed;

	protected void PropertiesUpdated()
	{
		if (cb_propertiesUpdated != null)
		{
			cb_propertiesUpdated(this);
		}
	}

	public void RegisterPropertyChangedCallback(Action<Instance> callback)
	{
		cb_propertiesUpdated = (Action<Instance>)Delegate.Combine(cb_propertiesUpdated, callback);
	}

	public void UnregisterPropertyChangedCallback(Action<Instance> callback)
	{
		cb_propertiesUpdated = (Action<Instance>)Delegate.Remove(cb_propertiesUpdated, callback);
	}

	public Instance(string name)
	{
		classname = name;
		this.name = name;
		canDelete = true;
		uuid = Guid.NewGuid().ToString("N");
		RegisterPropertyChangedCallback(delegate
		{
			game.OnPartChange(this);
		});
	}

	public void SetParent(Instance par)
	{
		if (parentInstance != null && parentInstance.children.ContainsKey(uuid))
		{
			parentInstance.children.Remove(uuid);
		}
		par.AddChild(this);
	}

	public void AddChild(Instance i)
	{
		children.Add(i.uuid, i);
		if (i.parentInstance != null && i.parentInstance.children.ContainsKey(i.uuid))
		{
			i.parentInstance.children.Remove(i.uuid);
		}
		i.parentInstance = this;
		new PEHLMFEHGAJ().AGPJJLDICNG = i;
	}

	public void RemoveChild(Instance i)
	{
		children.Remove(i.uuid);
		new FDPLLCOGDND().AGPJJLDICNG = i;
	}

	public static Instance Create(string className, Instance parent)
	{
		Instance result = null;
		if (!(className == "Part"))
		{
			if (className == "Explosion")
			{
				Explosion explosion = new Explosion();
				parent.AddChild(explosion);
				return explosion;
			}
			return result;
		}
		Part part = new Part();
		parent.AddChild(part);
		return part;
	}

	public Instance[] GetChildren()
	{
		return children.Values.ToArray();
	}

	public void Destroy()
	{
		foreach (Instance value in children.Values)
		{
			value.Destroy();
		}
		if (parentInstance != null)
		{
			parentInstance.RemoveChild(this);
		}
	}

	public void Delete()
	{
		Destroy();
	}

	public Instance FindChild(string name)
	{
		foreach (Instance value in children.Values)
		{
			if (value.name == name)
			{
				return value;
			}
		}
		return null;
	}

	public Instance GetChild(string name)
	{
		return FindChild(name);
	}
}
