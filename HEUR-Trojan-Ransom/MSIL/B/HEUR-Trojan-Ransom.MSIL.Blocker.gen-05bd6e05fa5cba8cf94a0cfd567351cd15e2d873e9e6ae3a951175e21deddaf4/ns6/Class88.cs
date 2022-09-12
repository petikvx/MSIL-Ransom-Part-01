using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ns1;
using ns10;
using ns11;
using ns17;
using ns18;

namespace ns6;

internal static class Class88
{
	internal static readonly bool[] bool_0;

	internal static readonly bool[] bool_1;

	internal static readonly bool[] bool_2;

	private const int int_0 = 6;

	private const string string_0 = "!";

	static Class88()
	{
		bool_0 = new bool[128];
		bool_1 = new bool[128];
		bool_2 = new bool[128];
		IList<char> list = new List<char> { '\n', '\r', '\t', '\\', '\f', '\b' };
		for (int i = 0; i < 32; i++)
		{
			list.Add((char)i);
		}
		foreach (char item in list.Union(new char[1] { '\'' }))
		{
			bool_0[(uint)item] = true;
		}
		foreach (char item2 in list.Union(new char[1] { '"' }))
		{
			bool_1[(uint)item2] = true;
		}
		foreach (char item3 in list.Union(new char[5] { '"', '\'', '<', '>', '&' }))
		{
			bool_2[(uint)item3] = true;
		}
	}

	public static void smethod_0(TextWriter textWriter_0, string? string_1, char char_0, bool bool_3, bool[] bool_4, Enum17 enum17_0, Interface0<char>? interface0_0, ref char[]? char_1)
	{
		if (bool_3)
		{
			textWriter_0.Write(char_0);
		}
		if (!Class109.smethod_0(string_1))
		{
			int num = Class4.smethod_57(enum17_0, string_1, bool_4);
			if (num == -1)
			{
				textWriter_0.Write(string_1);
			}
			else
			{
				if (num != 0)
				{
					if (char_1 == null || char_1!.Length < num)
					{
						char_1 = Class4.smethod_752(char_1, interface0_0, num);
					}
					string_1!.CopyTo(0, char_1, 0, num);
					textWriter_0.Write(char_1, 0, num);
				}
				int num2;
				for (int i = num; i < string_1!.Length; i++)
				{
					char c = string_1![i];
					if (c < bool_4.Length && !bool_4[(uint)c])
					{
						continue;
					}
					string text;
					switch (c)
					{
					case '\\':
						text = "\\\\";
						break;
					case '\b':
						text = "\\b";
						break;
					case '\t':
						text = "\\t";
						break;
					case '\n':
						text = "\\n";
						break;
					case '\f':
						text = "\\f";
						break;
					case '\r':
						text = "\\r";
						break;
					default:
						if (c >= bool_4.Length && enum17_0 != Enum17.const_1)
						{
							text = null;
							break;
						}
						if (c == '\'' && enum17_0 != Enum17.const_2)
						{
							text = "\\'";
							break;
						}
						if (c == '"' && enum17_0 != Enum17.const_2)
						{
							text = "\\\"";
							break;
						}
						if (char_1 == null || char_1!.Length < 6)
						{
							char_1 = Class4.smethod_752(char_1, interface0_0, 6);
						}
						Class4.smethod_176(c, char_1);
						text = "!";
						break;
					case '\u2029':
						text = "\\u2029";
						break;
					case '\u2028':
						text = "\\u2028";
						break;
					case '\u0085':
						text = "\\u0085";
						break;
					}
					if (text == null)
					{
						continue;
					}
					bool flag = string.Equals(text, "!", StringComparison.Ordinal);
					if (i > num)
					{
						num2 = i - num + (flag ? 6 : 0);
						int num3 = (flag ? 6 : 0);
						if (char_1 == null || char_1!.Length < num2)
						{
							char[] array = Class87.smethod_0(interface0_0, num2);
							if (flag)
							{
								Array.Copy(char_1, array, 6);
							}
							Class4.smethod_292(interface0_0, char_1);
							char_1 = array;
						}
						string_1!.CopyTo(num, char_1, num3, num2 - num3);
						textWriter_0.Write(char_1, num3, num2 - num3);
					}
					num = i + 1;
					if (!flag)
					{
						textWriter_0.Write(text);
					}
					else
					{
						textWriter_0.Write(char_1, 0, 6);
					}
				}
				num2 = string_1!.Length - num;
				if (num2 > 0)
				{
					if (char_1 == null || char_1!.Length < num2)
					{
						char_1 = Class4.smethod_752(char_1, interface0_0, num2);
					}
					string_1!.CopyTo(num, char_1, 0, num2);
					textWriter_0.Write(char_1, 0, num2);
				}
			}
		}
		if (bool_3)
		{
			textWriter_0.Write(char_0);
		}
	}
}
