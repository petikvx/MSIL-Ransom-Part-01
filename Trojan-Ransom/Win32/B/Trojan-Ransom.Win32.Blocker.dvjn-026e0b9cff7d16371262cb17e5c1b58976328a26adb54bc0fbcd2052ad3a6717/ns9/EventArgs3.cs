using System;

namespace ns9;

internal class EventArgs3 : EventArgs
{
	internal Enum1 enum1_0;

	internal readonly bool bool_0;

	internal readonly string string_0 = string.Empty;

	private readonly string string_1 = string.Empty;

	internal EventArgs3(Enum1 enum1_1, string string_2)
		: this(enum1_1, string_2, string.Empty)
	{
	}

	internal EventArgs3(Enum1 enum1_1, string string_2, string string_3)
	{
		enum1_0 = enum1_1;
		bool_0 = string_2 != null && string_2.Length > 0;
		string_0 = string_2;
		string_1 = string_3;
	}

	internal static bool M0BlOjGfYa55mJSju3c()
	{
		return true;
	}

	internal static bool ORZ8gxGXuCVwDKFgkCF()
	{
		return false;
	}
}
