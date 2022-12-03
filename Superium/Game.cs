// Game
using System;
using System.Globalization;
using System.Net;
using System.Xml;
using UnityEngine;

public class Game : Instance
{
	private Action<Instance> cb_instanceUpdated;

	public Game()
		: base("Game")
	{
		Initialize();
	}

	public void Initialize()
	{
		ScriptService i = new ScriptService();
		Environment i2 = new Environment();
		Lighting i3 = new Lighting();
		AddChild(i);
		AddChild(i2);
		AddChild(i3);
	}

	public void RegisterInstanceUpdatedCallback(Action<Instance> callback)
	{
		cb_instanceUpdated = (Action<Instance>)Delegate.Combine(cb_instanceUpdated, callback);
	}

	public void UnregisterInstanceUpdatedCallback(Action<Instance> callback)
	{
		cb_instanceUpdated = (Action<Instance>)Delegate.Remove(cb_instanceUpdated, callback);
	}

	public void LoadFromFile(string path)
	{
		Debug.Log("Loading DataModel " + path);
		ClearDataModel();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(path);
		HandleXmlNodes(this, xmlDocument.DocumentElement.ChildNodes);
	}

	public void Load(int id)
	{
		Debug.Log("Loading place ID " + id);
		ClearDataModel();
		try
		{
			string xml = new WebClient().DownloadString("https://spm.blox.ltd/assets/games/" + id + ".spm");
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			HandleXmlNodes(this, xmlDocument.DocumentElement.ChildNodes);
		}
		catch (Exception ex)
		{
			Debug.LogError(ex.Message);
		}
	}

	private void HandleXmlNodes(Instance parent, XmlNodeList nodes)
	{
		foreach (XmlNode node in nodes)
		{
			string name = node.Name;
			if (!(name == "Item"))
			{
				if (!(name == "Properties"))
				{
					continue;
				}
				foreach (XmlNode childNode in node.ChildNodes)
				{
					switch (childNode.Name)
					{
					case "float":
						try
						{
							parent.GetType().GetField(childNode.Attributes["name"].InnerText).SetValue(parent, float.Parse(childNode.InnerText, new CultureInfo("en-US").NumberFormat));
						}
						catch (Exception ex4)
						{
							Debug.LogError(childNode.Attributes["name"].InnerText + ", " + childNode.InnerText + ", " + ex4.Message);
						}
						break;
					case "integer":
						try
						{
							parent.GetType().GetField(childNode.Attributes["name"].InnerText).SetValue(parent, int.Parse(childNode.InnerText, new CultureInfo("en-US").NumberFormat));
						}
						catch (Exception ex3)
						{
							Debug.LogError(ex3.Message);
						}
						break;
					case "string":
						try
						{
							parent.GetType().GetField(childNode.Attributes["name"].InnerText).SetValue(parent, childNode.InnerText);
						}
						catch (Exception ex2)
						{
							Debug.LogError(childNode.Attributes["name"].InnerText + ", " + childNode.InnerText + ", " + ex2.Message);
						}
						break;
					case "boolean":
						try
						{
							parent.GetType().GetField(childNode.Attributes["name"].InnerText).SetValue(parent, bool.Parse(childNode.InnerText));
						}
						catch (Exception ex)
						{
							Debug.LogError(ex.Message);
						}
						break;
					case "vector3":
					{
						float x = float.Parse(childNode["X"].InnerText, new CultureInfo("en-US").NumberFormat);
						float y = float.Parse(childNode["Y"].InnerText, new CultureInfo("en-US").NumberFormat);
						float z = float.Parse(childNode["Z"].InnerText, new CultureInfo("en-US").NumberFormat);
						parent.GetType().GetField(childNode.Attributes["name"].InnerText).SetValue(parent, new Vector3(x, y, z));
						break;
					}
					default:
						Debug.LogError("Unknown type \"" + childNode.Name + "\"");
						break;
					}
				}
			}
			else
			{
				Instance instance = null;
				switch (node.Attributes["class"].InnerText)
				{
				case "Environment":
					instance = new Environment();
					break;
				case "Lighting":
					instance = new Lighting();
					break;
				case "Players":
					instance = new Players();
					break;
				case "Part":
					instance = new Part();
					break;
				case "Script":
					instance = new ScriptInstance();
					break;
				case "ScriptInstance":
					instance = new ScriptInstance();
					break;
				case "ScriptService":
					instance = new ScriptService();
					break;
				case "Sun":
					instance = new Sun();
					break;
				case "PointLight":
					instance = new PointLight();
					break;
				}
				if (instance != null)
				{
					parent.AddChild(instance);
					HandleXmlNodes(instance, node.ChildNodes);
				}
			}
		}
	}

	private void ClearDataModel()
	{
		Instance[] children = GetChildren();
		foreach (Instance i2 in children)
		{
			RemoveChild(i2);
		}
	}

	public void OnPartChange(Instance i)
	{
		if (cb_instanceUpdated != null)
		{
			cb_instanceUpdated(i);
		}
	}
}
