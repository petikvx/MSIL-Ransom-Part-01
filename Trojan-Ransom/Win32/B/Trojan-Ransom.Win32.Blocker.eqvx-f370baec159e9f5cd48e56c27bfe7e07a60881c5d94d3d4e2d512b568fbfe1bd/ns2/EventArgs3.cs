using System;
using System.Runtime.CompilerServices;
using ns9;

namespace ns2;

internal class EventArgs3 : EventArgs
{
	private Enum0 enum0_0;

	private readonly bool bool_0;

	private readonly string string_0 = string.Empty;

	private readonly string string_1 = string.Empty;

	[SpecialName]
	public Enum0 method_0()
	{
		return enum0_0;
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

	internal EventArgs3(Enum0 enum0_1, string string_2)
		: this(enum0_1, string_2, string.Empty)
	{
	}

	internal EventArgs3(Enum0 enum0_1, string string_2, string string_3)
	{
		enum0_0 = enum0_1;
		bool_0 = string_2 != null && string_2.Length > 0;
		string_0 = string_2;
		string_1 = string_3;
	}
}
