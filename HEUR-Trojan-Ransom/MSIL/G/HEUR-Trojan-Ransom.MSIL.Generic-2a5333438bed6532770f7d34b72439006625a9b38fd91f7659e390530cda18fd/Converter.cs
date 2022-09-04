using System;
using System.Reflection;

internal class Converter
{
	private Assembly test;

	public Converter(Assembly ass)
	{
		test = ass;
	}

	public Type get()
	{
		return test.GetTypes()[0];
	}
}
