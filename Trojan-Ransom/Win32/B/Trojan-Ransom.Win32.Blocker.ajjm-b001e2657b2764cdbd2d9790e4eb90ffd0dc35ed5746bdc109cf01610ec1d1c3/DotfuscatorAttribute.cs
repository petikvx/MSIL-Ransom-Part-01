using System;

[AttributeUsage(AttributeTargets.Assembly)]
public sealed class DotfuscatorAttribute : Attribute
{
	private string string_0;

	public string A => string_0;

	public DotfuscatorAttribute(string a)
	{
		string_0 = a;
	}
}
