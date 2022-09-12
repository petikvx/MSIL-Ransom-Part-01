using System;
using System.Runtime.CompilerServices;
using ns11;

namespace ns7;

internal sealed class EventArgs4 : EventArgs
{
	private Enum6 enum6_0;

	private readonly bool bool_0;

	private readonly string string_0 = string.Empty;

	private readonly string string_1 = string.Empty;

	[SpecialName]
	public Enum6 method_0()
	{
		return enum6_0;
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

	internal EventArgs4(Enum6 enum6_1, string string_2)
		: this(enum6_1, string_2, string.Empty)
	{
	}

	internal EventArgs4(Enum6 enum6_1, string string_2, string string_3)
	{
		enum6_0 = enum6_1;
		bool_0 = string_2 != null && string_2.Length > 0;
		string_0 = string_2;
		string_1 = string_3;
	}
}
