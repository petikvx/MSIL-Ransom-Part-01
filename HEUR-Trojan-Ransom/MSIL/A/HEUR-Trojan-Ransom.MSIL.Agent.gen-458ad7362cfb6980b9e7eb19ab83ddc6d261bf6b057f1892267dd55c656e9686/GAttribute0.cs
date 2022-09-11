using System;
using System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Assembly)]
[ComVisible(false)]
public sealed class GAttribute0 : Attribute
{
	private string string_0;

	private int int_0;

	public string String_0 => string_0;

	public int Int32_0 => int_0;

	public GAttribute0(string a, int c)
	{
		string_0 = a;
		int_0 = c;
	}
}
