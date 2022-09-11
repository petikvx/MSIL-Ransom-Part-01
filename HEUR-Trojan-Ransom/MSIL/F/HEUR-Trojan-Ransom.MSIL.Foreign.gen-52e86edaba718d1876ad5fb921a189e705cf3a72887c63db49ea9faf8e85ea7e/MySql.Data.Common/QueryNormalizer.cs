using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns15;
using ns21;

namespace MySql.Data.Common;

internal sealed class QueryNormalizer
{
	private static readonly List<string> list_0;

	private readonly List<Token> list_1 = new List<Token>();

	private int int_0;

	private string string_0;

	private string string_1;

	[NonSerialized]
	internal static GetString getString_0;

	public string QueryType => string_1;

	static QueryNormalizer()
	{
		Strings.CreateGetStringDelegate(typeof(QueryNormalizer));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398169), getString_0(107398164)).Replace(getString_0(107398127), getString_0(107398122)));
		if (StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) && bool_ && executingAssembly.FullName!.EndsWith(getString_0(107398117)))
		{
			list_0 = new List<string>();
			StringReader stringReader = new StringReader(Class121.keywords);
			for (string text = stringReader.ReadLine(); text != null; text = stringReader.ReadLine())
			{
				list_0.Add(text);
			}
			return;
		}
		throw new SecurityException(getString_0(107398092));
	}

	public string method_0(string string_2)
	{
		list_1.Clear();
		StringBuilder stringBuilder = new StringBuilder();
		string_0 = string_2;
		method_5(string_2);
		method_1(list_1);
		smethod_0(list_1);
		method_2(list_1);
		method_4(list_1);
		smethod_1(list_1);
		foreach (Token item in list_1.Where((Token token_0) => token_0.bool_0))
		{
			stringBuilder.Append(item.string_0);
		}
		return stringBuilder.ToString();
	}

	private void method_1(List<Token> list_2)
	{
		using IEnumerator<Token> enumerator = list_2.Where((Token token_0) => token_0.enum32_0 == Enum32.const_0).GetEnumerator();
		if (enumerator.MoveNext())
		{
			Token current = enumerator.Current;
			string_1 = current.string_0.ToUpperInvariant();
		}
	}

	private static void smethod_0(List<Token> list_2)
	{
		Token token = null;
		foreach (Token item in list_2)
		{
			if (item.enum32_0 == Enum32.const_3 && (item.string_0 == getString_0(107409437) || item.string_0 == getString_0(107407163)) && token != null && token.enum32_0 != Enum32.const_2 && token.enum32_0 != Enum32.const_4 && (token.enum32_0 != Enum32.const_3 || token.string_0 != getString_0(107409541)))
			{
				item.bool_0 = false;
			}
			if (item.IsRealToken)
			{
				token = item;
			}
		}
	}

	private static void smethod_1(List<Token> list_2)
	{
		Token token = null;
		foreach (Token item in list_2)
		{
			if (item.bool_0 && item.enum32_0 == Enum32.const_7 && token != null && token.enum32_0 == Enum32.const_7)
			{
				item.bool_0 = false;
			}
			if (item.bool_0)
			{
				token = item;
			}
		}
	}

	private void method_2(List<Token> list_2)
	{
		int int_ = -1;
		while (++int_ < list_2.Count)
		{
			Token token = list_2[int_];
			if (token.enum32_0 == Enum32.const_0 && token.string_0.StartsWith(getString_0(107356525), StringComparison.OrdinalIgnoreCase))
			{
				method_3(list_2, ref int_);
			}
		}
	}

	private void method_3(List<Token> list_2, ref int int_1)
	{
		List<int> list = new List<int>();
		while (true)
		{
			if (++int_1 >= list_2.Count || (list_2[int_1].enum32_0 == Enum32.const_3 && list_2[int_1].string_0 == getString_0(107409541)) || int_1 == list_2.Count - 1)
			{
				list.Add(int_1);
				while (++int_1 < list_2.Count && !list_2[int_1].IsRealToken)
				{
				}
				if (int_1 == list_2.Count)
				{
					break;
				}
				if (!(list_2[int_1].string_0 == getString_0(107404969)))
				{
					int_1--;
					break;
				}
			}
		}
		if (list.Count >= 2)
		{
			int num = list[0];
			list_2[++num] = new Token(Enum32.const_7, getString_0(107396269));
			list_2[++num] = new Token(Enum32.const_5, getString_0(107356516));
			num++;
			while (num <= list[list.Count - 1])
			{
				list_2[num++].bool_0 = false;
			}
		}
	}

	private void method_4(List<Token> list_2)
	{
		int int_ = -1;
		while (++int_ < list_2.Count)
		{
			Token token = list_2[int_];
			if (token.enum32_0 == Enum32.const_0 && !(token.string_0 != getString_0(107357011)))
			{
				smethod_3(list_2, ref int_);
			}
		}
	}

	private static Token smethod_2(List<Token> list_2, ref int int_1)
	{
		do
		{
			if (++int_1 >= list_2.Count)
			{
				return null;
			}
		}
		while (!list_2[int_1].IsRealToken);
		return list_2[int_1];
	}

	private static void smethod_3(List<Token> list_2, ref int int_1)
	{
		Token token = smethod_2(list_2, ref int_1);
		if (token == null)
		{
			return;
		}
		token = smethod_2(list_2, ref int_1);
		if (token == null || token.enum32_0 == Enum32.const_0)
		{
			return;
		}
		int num = int_1;
		while (++int_1 < list_2.Count)
		{
			token = list_2[int_1];
			if (token.enum32_0 == Enum32.const_6)
			{
				return;
			}
			if (token.IsRealToken)
			{
				if (token.string_0 == getString_0(107409546))
				{
					return;
				}
				if (token.string_0 == getString_0(107409541))
				{
					break;
				}
			}
		}
		for (int num2 = int_1; num2 > num; num2--)
		{
			list_2.RemoveAt(num2);
		}
		list_2.Insert(++num, new Token(Enum32.const_7, getString_0(107396269)));
		list_2.Insert(++num, new Token(Enum32.const_5, getString_0(107356516)));
		list_2.Insert(++num, new Token(Enum32.const_7, getString_0(107396269)));
		list_2.Insert(++num, new Token(Enum32.const_3, getString_0(107409541)));
	}

	private void method_5(string string_2)
	{
		int_0 = 0;
		while (int_0 < string_2.Length)
		{
			char c = string_2[int_0];
			if (method_6(c) && method_8())
			{
				continue;
			}
			if (char.IsWhiteSpace(c))
			{
				method_12();
			}
			else if (c != '\'' && c != '"' && c != '`')
			{
				if (!method_7(c))
				{
					method_11();
				}
				else
				{
					method_9();
				}
			}
			else
			{
				method_10(c);
			}
		}
	}

	private bool method_6(char char_0)
	{
		if (char_0 != '#' && char_0 != '/')
		{
			return char_0 == '-';
		}
		return true;
	}

	private bool method_7(char char_0)
	{
		if (!char.IsLetterOrDigit(char_0) && char_0 != '$' && char_0 != '_')
		{
			return char_0 != '.';
		}
		return false;
	}

	private bool method_8()
	{
		char c = string_0[int_0];
		if (c == '/' && (int_0 + 1 >= string_0.Length || string_0[int_0 + 1] != '*'))
		{
			return false;
		}
		if (c == '-' && (int_0 + 2 >= string_0.Length || string_0[int_0 + 1] != '-' || string_0[int_0 + 2] != ' '))
		{
			return false;
		}
		string text = getString_0(107357279);
		if (c == '/')
		{
			text = getString_0(107357274);
		}
		int num = string_0.IndexOf(text, int_0);
		num = ((num != -1) ? (num + text.Length) : (string_0.Length - 1));
		string text2 = string_0.Substring(int_0, num - int_0);
		if (text2.StartsWith(getString_0(107357006), StringComparison.Ordinal))
		{
			list_1.Add(new Token(Enum32.const_6, text2));
		}
		int_0 = num;
		return true;
	}

	private void method_9()
	{
		char c = string_0[int_0++];
		list_1.Add(new Token(Enum32.const_3, c.ToString()));
	}

	private void method_10(char char_0)
	{
		bool flag = false;
		int num = int_0;
		int_0++;
		while (int_0 < string_0.Length)
		{
			char c = string_0[int_0];
			if (c == char_0 && !flag)
			{
				break;
			}
			if (flag)
			{
				flag = false;
			}
			else if (c == '\\')
			{
				flag = true;
			}
			int_0++;
		}
		int_0++;
		list_1.Add((char_0 == '\'') ? new Token(Enum32.const_1, getString_0(107409700)) : new Token(Enum32.const_4, string_0.Substring(num, int_0 - num)));
	}

	private void method_11()
	{
		int num = int_0;
		while (int_0 < string_0.Length && !method_7(string_0[int_0]))
		{
			int_0++;
		}
		string text = string_0.Substring(num, int_0 - num);
		if (double.TryParse(text, out var _))
		{
			list_1.Add(new Token(Enum32.const_2, getString_0(107409700)));
			return;
		}
		Token token = new Token(Enum32.const_4, text);
		if (smethod_4(text))
		{
			token.enum32_0 = Enum32.const_0;
			token.string_0 = token.string_0.ToUpperInvariant();
		}
		list_1.Add(token);
	}

	private void method_12()
	{
		list_1.Add(new Token(Enum32.const_7, getString_0(107396269)));
		while (int_0 < string_0.Length && char.IsWhiteSpace(string_0[int_0]))
		{
			int_0++;
		}
	}

	private static bool smethod_4(string string_2)
	{
		return list_0.Contains(string_2.ToUpperInvariant());
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_2, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
