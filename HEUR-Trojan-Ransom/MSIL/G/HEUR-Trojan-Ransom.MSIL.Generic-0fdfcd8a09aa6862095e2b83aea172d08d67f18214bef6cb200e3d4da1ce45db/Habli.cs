using System;
using System.Reflection;

internal class Habli
{
	private Assembly test;

	public Habli(Assembly ass)
	{
		test = ass;
	}

	public Type get()
	{
		return test.GetTypes()[0];
	}
}
