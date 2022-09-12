using System;

namespace ns7;

internal readonly struct Struct4
{
	private readonly char[] char_0;

	private readonly int int_0;

	private readonly int int_1;

	public char this[int int_2] => char_0[int_2];

	public char[] Chars => char_0;

	public int StartIndex => int_0;

	public int Length => int_1;

	public Struct4(char[] char_1, int int_2, int int_3)
	{
		char_0 = char_1;
		int_0 = int_2;
		int_1 = int_3;
	}

	string ValueType.ToString()
	{
		return new string(char_0, int_0, int_1);
	}
}
