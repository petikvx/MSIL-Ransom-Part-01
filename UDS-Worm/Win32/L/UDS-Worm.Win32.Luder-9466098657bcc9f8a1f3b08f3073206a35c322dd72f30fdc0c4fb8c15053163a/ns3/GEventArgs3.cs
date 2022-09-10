using System;
using System.Runtime.CompilerServices;
using ns4;

namespace ns3;

[GAttribute0(18)]
public class GEventArgs3 : EventArgs
{
	private GEnum1 genum1_0;

	private bool bool_0 = false;

	private string string_0 = string.Empty;

	private string string_1 = string.Empty;

	[SpecialName]
	public GEnum1 method_0()
	{
		return genum1_0;
	}

	[SpecialName]
	public bool method_1()
	{
		return bool_0;
	}

	[SpecialName]
	public string method_2()
	{
		return string_0;
	}

	[SpecialName]
	public void method_3(string string_2)
	{
		string_1 = string_2;
	}

	internal GEventArgs3(GEnum1 genum1_1)
		: this(genum1_1, string.Empty)
	{
	}

	internal GEventArgs3(GEnum1 genum1_1, string string_2)
	{
		genum1_0 = genum1_1;
		bool_0 = string_2 != null && string_2.Length > 0;
		string_0 = string_2;
	}
}
