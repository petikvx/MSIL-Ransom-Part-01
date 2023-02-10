using System;
using System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Assembly)]
[ComVisible(false)]
public sealed class DotfuscatorAttribute : Attribute
{
	private string a;

	private int c;

	public string A => a;

	public int C => c;

	public DotfuscatorAttribute(string a, int c)
	{
		this.a = a;
		this.c = c;
	}
}
