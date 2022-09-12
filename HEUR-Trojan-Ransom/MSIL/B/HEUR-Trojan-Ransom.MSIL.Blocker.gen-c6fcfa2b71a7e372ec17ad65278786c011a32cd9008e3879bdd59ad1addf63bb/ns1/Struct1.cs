using System;
using ns12;

namespace ns1;

internal struct Struct1
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public Enum24 enum24_0;

	private char[] char_0;

	private int int_9;

	private static readonly int[] int_10;

	private static readonly int int_11;

	private static readonly int int_12;

	private static readonly int int_13;

	private static readonly int int_14;

	private static readonly int int_15;

	private static readonly int int_16;

	private static readonly int int_17;

	private static readonly int int_18;

	private static readonly int int_19;

	private static readonly int int_20;

	private static readonly int int_21;

	private static readonly int int_22;

	private static readonly int int_23;

	private const short short_0 = 7;

	static Struct1()
	{
		int_10 = new int[7] { -1, 10, 100, 1000, 10000, 100000, 1000000 };
		int_11 = "yyyy".Length;
		int_12 = "yyyy-".Length;
		int_13 = "yyyy-MM".Length;
		int_14 = "yyyy-MM-".Length;
		int_15 = "yyyy-MM-dd".Length;
		int_16 = "yyyy-MM-ddT".Length;
		int_17 = "HH".Length;
		int_18 = "HH:".Length;
		int_19 = "HH:mm".Length;
		int_20 = "HH:mm:".Length;
		int_21 = "HH:mm:ss".Length;
		int_22 = "-".Length;
		int_23 = "-zz".Length;
	}

	public bool method_0(char[] char_1, int int_24, int int_25)
	{
		char_0 = char_1;
		int_9 = int_24 + int_25;
		if (method_1(int_24) && method_7(int_15 + int_24, 'T') && method_2(int_16 + int_24))
		{
			return true;
		}
		return false;
	}

	private bool method_1(int int_24)
	{
		if (method_5(int_24, out int_0) && 1 <= int_0 && method_7(int_24 + int_11, '-') && method_6(int_24 + int_12, out int_1) && 1 <= int_1 && int_1 <= 12 && method_7(int_24 + int_13, '-') && method_6(int_24 + int_14, out int_2) && 1 <= int_2)
		{
			return int_2 <= DateTime.DaysInMonth(int_0, int_1);
		}
		return false;
	}

	private bool method_2(int int_24)
	{
		if (method_3(ref int_24))
		{
			return method_4(int_24);
		}
		return false;
	}

	private bool method_3(ref int int_24)
	{
		if (method_6(int_24, out int_3) && int_3 <= 24 && method_7(int_24 + int_17, ':') && method_6(int_24 + int_18, out int_4) && int_4 < 60 && method_7(int_24 + int_19, ':') && method_6(int_24 + int_20, out int_5) && int_5 < 60 && (int_3 != 24 || (int_4 == 0 && int_5 == 0)))
		{
			int_24 += int_21;
			if (method_7(int_24, '.'))
			{
				int_6 = 0;
				int num = 0;
				while (++int_24 < int_9 && num < 7)
				{
					int num2 = char_0[int_24] - 48;
					if (num2 < 0 || num2 > 9)
					{
						break;
					}
					int_6 = int_6 * 10 + num2;
					num++;
				}
				if (num < 7)
				{
					if (num == 0)
					{
						return false;
					}
					int_6 *= int_10[7 - num];
				}
				if (int_3 == 24 && int_6 != 0)
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	private bool method_4(int int_24)
	{
		if (int_24 < int_9)
		{
			char c = char_0[int_24];
			if (c != 'Z' && c != 'z')
			{
				if (int_24 + 2 < int_9 && method_6(int_24 + int_22, out int_7) && int_7 <= 99)
				{
					switch (c)
					{
					case '-':
						enum24_0 = Enum24.const_2;
						int_24 += int_23;
						break;
					case '+':
						enum24_0 = Enum24.const_3;
						int_24 += int_23;
						break;
					}
				}
				if (int_24 < int_9)
				{
					if (method_7(int_24, ':'))
					{
						int_24++;
						if (int_24 + 1 < int_9 && method_6(int_24, out int_8) && int_8 <= 99)
						{
							int_24 += 2;
						}
					}
					else if (int_24 + 1 < int_9 && method_6(int_24, out int_8) && int_8 <= 99)
					{
						int_24 += 2;
					}
				}
			}
			else
			{
				enum24_0 = Enum24.const_1;
				int_24++;
			}
		}
		return int_24 == int_9;
	}

	private bool method_5(int int_24, out int int_25)
	{
		if (int_24 + 3 < int_9)
		{
			int num = char_0[int_24] - 48;
			int num2 = char_0[int_24 + 1] - 48;
			int num3 = char_0[int_24 + 2] - 48;
			int num4 = char_0[int_24 + 3] - 48;
			if (0 <= num && num < 10 && 0 <= num2 && num2 < 10 && 0 <= num3 && num3 < 10 && 0 <= num4 && num4 < 10)
			{
				int_25 = ((num * 10 + num2) * 10 + num3) * 10 + num4;
				return true;
			}
		}
		int_25 = 0;
		return false;
	}

	private bool method_6(int int_24, out int int_25)
	{
		if (int_24 + 1 < int_9)
		{
			int num = char_0[int_24] - 48;
			int num2 = char_0[int_24 + 1] - 48;
			if (0 <= num && num < 10 && 0 <= num2 && num2 < 10)
			{
				int_25 = num * 10 + num2;
				return true;
			}
		}
		int_25 = 0;
		return false;
	}

	private bool method_7(int int_24, char char_1)
	{
		if (int_24 < int_9)
		{
			return char_0[int_24] == char_1;
		}
		return false;
	}
}
