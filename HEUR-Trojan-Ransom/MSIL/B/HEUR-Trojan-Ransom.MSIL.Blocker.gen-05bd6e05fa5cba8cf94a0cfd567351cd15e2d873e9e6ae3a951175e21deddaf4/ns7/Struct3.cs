using System;
using ns10;
using ns11;
using ns18;

namespace ns7;

internal struct Struct3
{
	private char[]? char_0;

	private int int_0;

	public int Position
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	public bool IsEmpty => char_0 == null;

	public char[]? InternalBuffer => char_0;

	public Struct3(Interface0<char>? interface0_0, int int_1)
		: this(Class87.smethod_0(interface0_0, int_1))
	{
	}

	private Struct3(char[] char_1)
	{
		char_0 = char_1;
		int_0 = 0;
	}

	public void method_0(Interface0<char>? interface0_0, char char_1)
	{
		if (int_0 == char_0!.Length)
		{
			method_3(interface0_0, 1);
		}
		char_0[int_0++] = char_1;
	}

	public void method_1(Interface0<char>? interface0_0, char[] char_1, int int_1, int int_2)
	{
		if (int_0 + int_2 >= char_0!.Length)
		{
			method_3(interface0_0, int_2);
		}
		Array.Copy(char_1, int_1, char_0, int_0, int_2);
		int_0 += int_2;
	}

	public void method_2(Interface0<char>? interface0_0)
	{
		if (char_0 != null)
		{
			Class4.smethod_292(interface0_0, char_0);
			char_0 = null;
		}
		int_0 = 0;
	}

	private void method_3(Interface0<char>? interface0_0, int int_1)
	{
		char[] destinationArray = Class87.smethod_0(interface0_0, (int_0 + int_1) * 2);
		if (char_0 != null)
		{
			Array.Copy(char_0, destinationArray, int_0);
			Class4.smethod_292(interface0_0, char_0);
		}
		char_0 = destinationArray;
	}

	string ValueType.ToString()
	{
		return method_4(0, int_0);
	}

	public string method_4(int int_1, int int_2)
	{
		return new string(char_0, int_1, int_2);
	}
}
