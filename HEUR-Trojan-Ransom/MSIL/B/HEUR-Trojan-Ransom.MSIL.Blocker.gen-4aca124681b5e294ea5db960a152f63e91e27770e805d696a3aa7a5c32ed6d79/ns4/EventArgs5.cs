using System;
using ns7;

namespace ns4;

internal sealed class EventArgs5 : EventArgs
{
	private Enum8 enum8_0;

	private readonly bool bool_0;

	private readonly string string_0 = string.Empty;

	private readonly string string_1 = string.Empty;

	internal EventArgs5(Enum8 enum8_1, string string_2)
		: this(enum8_1, string_2, string.Empty)
	{
	}

	internal EventArgs5(Enum8 enum8_1, string string_2, string string_3)
	{
		enum8_0 = enum8_1;
		bool_0 = string_2 != null && string_2.Length > 0;
		string_0 = string_2;
		string_1 = string_3;
	}
}
