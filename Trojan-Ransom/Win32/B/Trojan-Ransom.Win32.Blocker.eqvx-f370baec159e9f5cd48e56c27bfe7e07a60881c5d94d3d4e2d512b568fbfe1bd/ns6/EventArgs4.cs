using System;
using ns5;

namespace ns6;

internal class EventArgs4 : EventArgs
{
	private Enum2 enum2_0;

	private readonly bool bool_0;

	private readonly string string_0 = string.Empty;

	private readonly string string_1 = string.Empty;

	internal EventArgs4(Enum2 enum2_1, string string_2)
		: this(enum2_1, string_2, string.Empty)
	{
	}

	internal EventArgs4(Enum2 enum2_1, string string_2, string string_3)
	{
		enum2_0 = enum2_1;
		bool_0 = string_2 != null && string_2.Length > 0;
		string_0 = string_2;
		string_1 = string_3;
	}
}
