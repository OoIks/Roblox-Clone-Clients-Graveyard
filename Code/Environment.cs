// Environment
using System;

public class Environment : Instance
{
	public float timeSinceGameStart;

	public event EventHandler UpdateEnvironment;

	public Environment()
		: base("Environment")
	{
	}

	public void InvokeUpdate()
	{
	}
}
