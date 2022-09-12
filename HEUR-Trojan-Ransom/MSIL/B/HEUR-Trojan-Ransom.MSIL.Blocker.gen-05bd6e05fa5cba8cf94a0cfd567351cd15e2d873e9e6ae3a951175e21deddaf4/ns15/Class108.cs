using System;
using ns7;

namespace ns15;

internal static class Class108
{
	public static int smethod_0(this Struct4 struct4_0, char char_0, int int_0, int int_1)
	{
		int num = Array.IndexOf(struct4_0.Chars, char_0, struct4_0.StartIndex + int_0, int_1);
		if (num == -1)
		{
			return -1;
		}
		return num - struct4_0.StartIndex;
	}

	public static bool smethod_1(this Struct4 struct4_0, string string_0)
	{
		if (string_0.Length > struct4_0.Length)
		{
			return false;
		}
		char[] chars = struct4_0.Chars;
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (string_0[num] != chars[num + struct4_0.StartIndex])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static bool smethod_2(this Struct4 struct4_0, string string_0)
	{
		if (string_0.Length > struct4_0.Length)
		{
			return false;
		}
		char[] chars = struct4_0.Chars;
		int num = struct4_0.StartIndex + struct4_0.Length - string_0.Length;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_0.Length)
			{
				if (string_0[num2] != chars[num2 + num])
				{
					break;
				}
				num2++;
				continue;
			}
			return true;
		}
		return false;
	}
}
