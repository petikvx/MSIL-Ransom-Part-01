#define DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3904355907;

namespace C3554254475;

public static class C1130791706
{
	public static readonly StringComparison C3554254475 = StringComparison.OrdinalIgnoreCase;

	private static bool m_C3554254475 = false;

	private static UTF8Encoding m_C3554254475 = null;

	private static List<C3775001192> m_C3554254475 = null;

	private static readonly char[] m_C3554254475 = new char[1] { '*' };

	private static readonly char[] m_C3904355907 = new char[2] { '.', ',' };

	private static readonly byte[] m_C3554254475 = new byte[4] { 165, 116, 46, 236 };

	private static readonly char[] m_C1255198513 = new char[3] { ',', ';', ':' };

	private static readonly string[] m_C3554254475 = new string[10]
	{
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bk(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BL(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bl(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BM(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bm(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BN(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bn(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BO(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bo(),
		DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BP()
	};

	private static string[] m_C3904355907 = null;

	[SpecialName]
	public static StringComparer C3554254475()
	{
		return StringComparer.OrdinalIgnoreCase;
	}

	[SpecialName]
	public static bool C3904355907()
	{
		return global::C3554254475.C1130791706.m_C3554254475;
	}

	[SpecialName]
	public static void C3554254475(bool bool_0)
	{
		global::C3554254475.C1130791706.m_C3554254475 = bool_0;
	}

	[SpecialName]
	public static UTF8Encoding C1255198513()
	{
		if (global::C3554254475.C1130791706.m_C3554254475 == null)
		{
			global::C3554254475.C1130791706.m_C3554254475 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: false);
		}
		return global::C3554254475.C1130791706.m_C3554254475;
	}

	[SpecialName]
	public static IEnumerable<C3775001192> C1908338681()
	{
		if (global::C3554254475.C1130791706.m_C3554254475 != null)
		{
			return global::C3554254475.C1130791706.m_C3554254475;
		}
		List<C3775001192> list = new List<C3775001192>();
		list.Add(new C3775001192(global::C3554254475.C3664761504.C3904355907, Encoding.Default.EncodingName, Encoding.Default, (uint)Encoding.Default.GetBytes(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1505515367()).Length, null));
		list.Add(new C3775001192(global::C3554254475.C3664761504.C1255198513, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1657960367(), Encoding.ASCII, 1u, null));
		list.Add(new C3775001192(global::C3554254475.C3664761504.C1908338681, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aA(), Encoding.UTF7, 1u, null));
		list.Add(new C3775001192(global::C3554254475.C3664761504.C1037565863, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aa(), C1255198513(), 1u, new byte[3] { 239, 187, 191 }));
		list.Add(new C3775001192(global::C3554254475.C3664761504.C112844655, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aB(), new UnicodeEncoding(bigEndian: false, byteOrderMark: false), 2u, new byte[2] { 255, 254 }));
		list.Add(new C3775001192(global::C3554254475.C3664761504.C2746444292, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ab(), new UnicodeEncoding(bigEndian: true, byteOrderMark: false), 2u, new byte[2] { 254, 255 }));
		list.Add(new C3775001192(global::C3554254475.C3664761504.C2564639436, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aC(), new UTF32Encoding(bigEndian: false, byteOrderMark: false), 4u, new byte[4] { 255, 254, 0, 0 }));
		list.Add(new C3775001192(global::C3554254475.C3664761504.C3568589458, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ac(), new UTF32Encoding(bigEndian: true, byteOrderMark: false), 4u, new byte[4] { 0, 0, 254, 255 }));
		global::C3554254475.C1130791706.m_C3554254475 = list;
		return list;
	}

	public static string C3554254475(char char_0)
	{
		return DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aD() + ((short)char_0).ToString(NumberFormatInfo.InvariantInfo) + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ad();
	}

	internal static bool C3554254475(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return false;
		}
		return string_0.StartsWith(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aE()) && string_0.Length > DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aE().Length && char.IsDigit(string_0[DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aE().Length]);
	}

	public static string C3904355907(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return string.Empty;
		}
		string text = string_0;
		if (C3554254475(text))
		{
			text = text.Remove(2, 1);
		}
		return text;
	}

	internal static bool C1255198513(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (string_0[num] > 'ÿ')
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static string C1908338681(string string_0)
	{
		return C3554254475(string_0, bool_0: false);
	}

	internal static string C3554254475(string string_0, bool bool_0)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3081909835());
		}
		string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ae(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aF());
		string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.af(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aG());
		string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ag(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aH());
		string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ah(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aI());
		string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ai(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aJ());
		if (bool_0)
		{
			string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aj(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aK());
		}
		string_0 = C1255198513(string_0, bool_0: false);
		string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ak(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aL() + global::C3554254475.C2909332022.C3554254475());
		return string_0;
	}

	public static string C1037565863(string string_0)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3081909835());
		}
		string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aF(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ae());
		string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aG(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.af());
		string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aH(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ag());
		string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aI(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ah());
		string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aJ(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ai());
		return string_0;
	}

	public static string C3554254475(string string_0, string string_1, string string_2)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			return string_0;
		}
		Debug.Assert(string_1 != null);
		if (string_1 == null)
		{
			return string_0;
		}
		Debug.Assert(string_2 != null);
		if (string_2 == null)
		{
			return string_0;
		}
		string text = string_0;
		int num;
		for (num = 0; num < text.Length; num += string_2.Length)
		{
			num = text.IndexOf(string_1, num, StringComparison.OrdinalIgnoreCase);
			if (num < 0)
			{
				break;
			}
			text = text.Remove(num, string_1.Length);
			text = text.Insert(num, string_2);
		}
		return text;
	}

	public static string C3554254475(Color color_0, bool bool_0)
	{
		if (bool_0 && color_0.A != byte.MaxValue)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('#');
		byte b = (byte)(color_0.R >> 4);
		if (b < 10)
		{
			stringBuilder.Append((char)(48 + b));
		}
		else
		{
			stringBuilder.Append((char)(55 + b));
		}
		b = (byte)(color_0.R & 0xFu);
		if (b < 10)
		{
			stringBuilder.Append((char)(48 + b));
		}
		else
		{
			stringBuilder.Append((char)(55 + b));
		}
		b = (byte)(color_0.G >> 4);
		if (b < 10)
		{
			stringBuilder.Append((char)(48 + b));
		}
		else
		{
			stringBuilder.Append((char)(55 + b));
		}
		b = (byte)(color_0.G & 0xFu);
		if (b < 10)
		{
			stringBuilder.Append((char)(48 + b));
		}
		else
		{
			stringBuilder.Append((char)(55 + b));
		}
		b = (byte)(color_0.B >> 4);
		if (b < 10)
		{
			stringBuilder.Append((char)(48 + b));
		}
		else
		{
			stringBuilder.Append((char)(55 + b));
		}
		b = (byte)(color_0.B & 0xFu);
		if (b < 10)
		{
			stringBuilder.Append((char)(48 + b));
		}
		else
		{
			stringBuilder.Append((char)(55 + b));
		}
		return stringBuilder.ToString();
	}

	public static string C3554254475(Exception exception_0)
	{
		string text = string.Empty;
		if (!string.IsNullOrEmpty(exception_0.Message))
		{
			text = text + exception_0.Message + global::C3554254475.C2909332022.C3554254475();
		}
		if (!string.IsNullOrEmpty(exception_0.Source))
		{
			text = text + exception_0.Source + global::C3554254475.C2909332022.C3554254475();
		}
		if (!string.IsNullOrEmpty(exception_0.StackTrace))
		{
			text = text + exception_0.StackTrace + global::C3554254475.C2909332022.C3554254475();
		}
		if (exception_0.TargetSite != null)
		{
			text = text + exception_0.TargetSite!.ToString() + global::C3554254475.C2909332022.C3554254475();
		}
		if (exception_0.Data != null)
		{
			text += global::C3554254475.C2909332022.C3554254475();
			foreach (DictionaryEntry datum in exception_0.Data)
			{
				text = text + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ai() + datum.Key?.ToString() + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.al() + datum.Value?.ToString() + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ai() + global::C3554254475.C2909332022.C3554254475();
			}
		}
		if (exception_0.InnerException != null)
		{
			text = text + global::C3554254475.C2909332022.C3554254475() + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aM() + global::C3554254475.C2909332022.C3554254475();
			if (!string.IsNullOrEmpty(exception_0.InnerException!.Message))
			{
				text = text + exception_0.InnerException!.Message + global::C3554254475.C2909332022.C3554254475();
			}
			if (!string.IsNullOrEmpty(exception_0.InnerException!.Source))
			{
				text = text + exception_0.InnerException!.Source + global::C3554254475.C2909332022.C3554254475();
			}
			if (!string.IsNullOrEmpty(exception_0.InnerException!.StackTrace))
			{
				text = text + exception_0.InnerException!.StackTrace + global::C3554254475.C2909332022.C3554254475();
			}
			if (exception_0.InnerException!.TargetSite != null)
			{
				text += exception_0.InnerException!.TargetSite!.ToString();
			}
			if (exception_0.InnerException!.Data != null)
			{
				text += global::C3554254475.C2909332022.C3554254475();
				foreach (DictionaryEntry datum2 in exception_0.InnerException!.Data)
				{
					text = text + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ai() + datum2.Key?.ToString() + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.al() + datum2.Value?.ToString() + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ai() + global::C3554254475.C2909332022.C3554254475();
				}
			}
		}
		return text;
	}

	public static bool C3554254475(string string_0, out ushort ushort_0)
	{
		return ushort.TryParse(string_0, out ushort_0);
	}

	public static bool C3554254475(string string_0, out int int_0)
	{
		return int.TryParse(string_0, out int_0);
	}

	public static bool C3904355907(string string_0, out int int_0)
	{
		return int.TryParse(string_0, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out int_0);
	}

	public static bool C3554254475(string string_0, out uint uint_0)
	{
		return uint.TryParse(string_0, out uint_0);
	}

	public static bool C3904355907(string string_0, out uint uint_0)
	{
		return uint.TryParse(string_0, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out uint_0);
	}

	public static bool C3554254475(string string_0, out long long_0)
	{
		return long.TryParse(string_0, out long_0);
	}

	public static bool C3904355907(string string_0, out long long_0)
	{
		return long.TryParse(string_0, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out long_0);
	}

	public static bool C3554254475(string string_0, out ulong ulong_0)
	{
		return ulong.TryParse(string_0, out ulong_0);
	}

	public static bool C3904355907(string string_0, out ulong ulong_0)
	{
		return ulong.TryParse(string_0, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out ulong_0);
	}

	public static bool C3554254475(string string_0, out DateTime dateTime_0)
	{
		return DateTime.TryParse(string_0, out dateTime_0);
	}

	public static string C3554254475(string string_0, int int_0)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.am());
		}
		Debug.Assert(int_0 >= 0);
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aN());
		}
		if (string_0.Length <= int_0)
		{
			return string_0;
		}
		if (int_0 == 0)
		{
			return string.Empty;
		}
		if (int_0 <= 3)
		{
			return new string('.', int_0);
		}
		return string_0.Substring(0, int_0 - 3) + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.an();
	}

	public static string C3554254475(string string_0, int int_0, string string_1, string string_2)
	{
		int int_;
		return C3554254475(string_0, int_0, string_1, string_2, out int_);
	}

	public static string C3554254475(string string_0, int int_0, string string_1, string string_2, out int int_1)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.am());
		}
		if (string_1 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aO());
		}
		if (string_2 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ao());
		}
		int_1 = -1;
		int num = string_0.IndexOf(string_1, int_0);
		if (num < 0)
		{
			return string.Empty;
		}
		num += string_1.Length;
		int num2 = string_0.IndexOf(string_2, num);
		if (num2 < 0)
		{
			return string.Empty;
		}
		int_1 = num;
		return string_0.Substring(num, num2 - num);
	}

	public static string C112844655(string string_0)
	{
		Debug.Assert(string_0 != null);
		if (string.IsNullOrEmpty(string_0))
		{
			return string_0;
		}
		int length = string_0.Length;
		StringBuilder stringBuilder = new StringBuilder(length);
		for (int i = 0; i < length; i++)
		{
			char c = string_0[i];
			if ((c >= ' ' && c <= '\ud7ff') || c == '\t' || c == '\n' || c == '\r' || (c >= '\ue000' && c <= '\ufffd'))
			{
				stringBuilder.Append(c);
			}
			else if (c >= '\ud800' && c <= '\udbff')
			{
				if (i + 1 < length)
				{
					char c2 = string_0[i + 1];
					if (c2 >= '\udc00' && c2 <= '\udfff')
					{
						stringBuilder.Append(c);
						stringBuilder.Append(c2);
						i++;
					}
					else
					{
						Debug.Assert(condition: false);
					}
				}
				else
				{
					Debug.Assert(condition: false);
				}
			}
			Debug.Assert(c < '\udc00' || c > '\udfff');
		}
		return stringBuilder.ToString();
	}

	public static int C3554254475(string string_0, string string_1)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aP());
		}
		Debug.Assert(string_1 != null);
		if (string_1 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ap());
		}
		if (C543223747.C1037565863())
		{
			return C543223747.C3904355907(string_0, string_1);
		}
		int length = string_0.Length;
		int length2 = string_1.Length;
		if (length == 0)
		{
			return (length2 != 0) ? (-1) : 0;
		}
		if (length2 == 0)
		{
			return 1;
		}
		char c = string_0[0];
		char c2 = string_1[0];
		bool flag = c >= '0' && c <= '9';
		bool flag2 = c2 >= '0' && c2 <= '9';
		if (flag != flag2)
		{
			return string.Compare(string_0, string_1, ignoreCase: true);
		}
		int num = 0;
		int num2 = 0;
		int num3;
		while (true)
		{
			if (num < length && num2 < length2)
			{
				Debug.Assert((string_0[num] >= '0' && string_0[num] <= '9') == flag);
				Debug.Assert((string_1[num2] >= '0' && string_1[num2] <= '9') == flag);
				int i;
				for (i = num + 1; i < length; i++)
				{
					char c3 = string_0[i];
					if ((c3 >= '0' && c3 <= '9') != flag)
					{
						break;
					}
				}
				int j;
				for (j = num2 + 1; j < length2; j++)
				{
					char c4 = string_1[j];
					if ((c4 >= '0' && c4 <= '9') != flag)
					{
						break;
					}
				}
				string text = string_0.Substring(num, i - num);
				string text2 = string_1.Substring(num2, j - num2);
				bool flag3 = true;
				if (flag)
				{
					double result3;
					double result4;
					if (text.Length <= 19 && text2.Length <= 19)
					{
						if (ulong.TryParse(text, out var result) && ulong.TryParse(text2, out var result2))
						{
							if (result < result2)
							{
								return -1;
							}
							if (result > result2)
							{
								return 1;
							}
							flag3 = false;
						}
						else
						{
							Debug.Assert(condition: false);
						}
					}
					else if (double.TryParse(text, out result3) && double.TryParse(text2, out result4))
					{
						if (result3 < result4)
						{
							return -1;
						}
						if (result3 > result4)
						{
							return 1;
						}
						flag3 = false;
					}
					else
					{
						Debug.Assert(condition: false);
					}
				}
				if (flag3)
				{
					num3 = string.Compare(text, text2, ignoreCase: true);
					if (num3 != 0)
					{
						break;
					}
				}
				flag = !flag;
				num = i;
				num2 = j;
				continue;
			}
			if (num >= length)
			{
				Debug.Assert(num == length);
				if (num2 >= length2)
				{
					Debug.Assert(num2 == length2);
					return 0;
				}
				return -1;
			}
			Debug.Assert(num2 == length2);
			return 1;
		}
		return num3;
	}

	public static string C2746444292(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aQ());
		}
		string text = string_0;
		for (char c = 'A'; c <= 'Z'; c = (char)(c + 1))
		{
			string text2 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aq() + c + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aR();
			if (text.IndexOf(text2) >= 0)
			{
				text = text.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aj() + text2, string.Empty);
				text = text.Replace(text2, string.Empty);
			}
		}
		return text.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ae(), string.Empty);
	}

	public static string C3554254475(string string_0, List<char> list_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return null;
		}
		if (list_0 == null)
		{
			Debug.Assert(condition: false);
			return string_0;
		}
		int num = -1;
		int startIndex = 0;
		for (int i = 0; i < string_0.Length; i++)
		{
			char c = string_0[i];
			char item = char.ToUpperInvariant(c);
			num = list_0.IndexOf(item);
			if (num < 0)
			{
				char item2 = char.ToLowerInvariant(c);
				num = list_0.IndexOf(item2);
				if (num >= 0)
				{
					startIndex = i;
					break;
				}
				continue;
			}
			startIndex = i;
			break;
		}
		if (num < 0)
		{
			return string_0;
		}
		list_0.RemoveAt(num);
		return string_0.Insert(startIndex, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ae());
	}

	public static string C2564639436(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.am());
		}
		return string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ae(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ar());
	}

	public static string C3568589458(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.am());
		}
		return string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ae(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aS());
	}

	public static bool C3904355907(string string_0, bool bool_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3081909835());
		}
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				char c = string_0[num];
				if ((c < '0' || c > '9') && (c < 'a' || c > 'f') && (c < 'A' || c > 'F'))
				{
					if (bool_0)
					{
						return false;
					}
					if (c != ' ' && c != '\t' && c != '\r' && c != '\n')
					{
						break;
					}
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static bool C3554254475(byte[] byte_0, bool bool_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.@as());
		}
		int num = 0;
		while (true)
		{
			if (num < byte_0.Length)
			{
				byte b = byte_0[num];
				if ((b < 48 || b > 57) && (b < 97 || b > 102) && (b < 65 || b > 70))
				{
					if (bool_0)
					{
						return false;
					}
					if (b != 32 && b != 9 && b != 13 && b != 10)
					{
						break;
					}
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static bool C3554254475(string string_0, string string_1, StringComparison stringComparison_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aT());
		}
		if (string_1 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.am());
		}
		if (string_0.IndexOf('*') < 0)
		{
			return string_1.Equals(string_0, stringComparison_0);
		}
		string[] array = string_0.Split(global::C3554254475.C1130791706.m_C3554254475, StringSplitOptions.RemoveEmptyEntries);
		if (array == null)
		{
			Debug.Assert(condition: false);
			return true;
		}
		if (array.Length == 0)
		{
			return true;
		}
		if (string_1.Length == 0)
		{
			return false;
		}
		if (!string_0.StartsWith(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.at()) && !string_1.StartsWith(array[0], stringComparison_0))
		{
			return false;
		}
		if (!string_0.EndsWith(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.at()) && !string_1.EndsWith(array[^1], stringComparison_0))
		{
			return false;
		}
		int num = 0;
		int num2 = 0;
		while (true)
		{
			if (num2 < array.Length)
			{
				string text = array[num2];
				int num3 = string_1.IndexOf(text, num, stringComparison_0);
				if (num3 >= num)
				{
					num = num3 + text.Length;
					if (num == string_1.Length)
					{
						break;
					}
					num2++;
					continue;
				}
				return false;
			}
			return true;
		}
		return num2 == array.Length - 1;
	}

	public static bool C4024072794(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return false;
		}
		string text = string_0.Trim().ToLower();
		if (text == DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aU())
		{
			return true;
		}
		if (text == DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.au())
		{
			return true;
		}
		if (text == DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aV())
		{
			return true;
		}
		if (text == DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.av())
		{
			return true;
		}
		if (text == DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aW())
		{
			return true;
		}
		return false;
	}

	public static bool? C1304234792(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return null;
		}
		string text = string_0.Trim().ToLower();
		if (text == DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aU())
		{
			return true;
		}
		if (text == DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aw())
		{
			return false;
		}
		return null;
	}

	public static string C3904355907(bool bool_0)
	{
		return bool_0 ? DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aU() : DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aw();
	}

	public static string C3554254475(bool? nullable_0)
	{
		if (nullable_0.HasValue)
		{
			return C3904355907(nullable_0.Value);
		}
		return DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aX();
	}

	public static string C1255198513(string string_0, bool bool_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string_0;
		}
		string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ax(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ak());
		string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aY(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ak());
		if (bool_0)
		{
			string_0 = string_0.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ak(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ax());
		}
		return string_0;
	}

	internal static bool C3554254475(char[] char_0, bool bool_0)
	{
		if (char_0 == null)
		{
			Debug.Assert(condition: false);
			return true;
		}
		if (bool_0)
		{
			int num = -2;
			for (int i = 0; i < char_0.Length; i++)
			{
				switch (char_0[i])
				{
				case '\r':
					if (num < 0)
					{
						num = i;
						break;
					}
					return false;
				case '\n':
					if (num == i - 1)
					{
						num = -2;
						break;
					}
					return false;
				}
			}
			return num < 0;
		}
		return Array.IndexOf(char_0, '\r') < 0;
	}

	public static string C1993550816(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return global::C3554254475.C2909332022.C3554254475();
		}
		int length = string_0.Length;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		char c = '\0';
		for (int i = 0; i < length; i++)
		{
			char c2 = string_0[i];
			switch (c2)
			{
			case '\r':
				num2++;
				break;
			case '\n':
				num++;
				if (c == '\r')
				{
					num3++;
				}
				break;
			}
			c = c2;
		}
		num2 -= num3;
		num -= num3;
		int num4 = Math.Max(num3, Math.Max(num2, num));
		if (num4 == 0)
		{
			return global::C3554254475.C2909332022.C3554254475();
		}
		if (num3 == num4)
		{
			return DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ax();
		}
		return (num == num4) ? DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ak() : DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aY();
	}

	public static string C985283518(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string_0;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in string_0)
		{
			if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	public static string C3554254475(ulong ulong_0)
	{
		if (ulong_0 == 0L)
		{
			return DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ay();
		}
		if (ulong_0 <= 1024L)
		{
			return DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aZ();
		}
		if (ulong_0 <= 1048576L)
		{
			return (ulong_0 - 1L) / 1024uL + 1L + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.az();
		}
		if (ulong_0 <= 1073741824L)
		{
			return (ulong_0 - 1L) / 1048576uL + 1L + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BA();
		}
		if (ulong_0 <= 1099511627776L)
		{
			return (ulong_0 - 1L) / 1073741824uL + 1L + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ba();
		}
		return (ulong_0 - 1L) / 1099511627776uL + 1L + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BB();
	}

	public static string C3904355907(ulong ulong_0)
	{
		if (ulong_0 == 0L)
		{
			return DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ay();
		}
		if (ulong_0 <= 1024L)
		{
			return DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aZ();
		}
		return (ulong_0 - 1L) / 1024uL + 1L + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.az();
	}

	public static ulong C30677878(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return 0uL;
		}
		string[] array = string_0.Split(global::C3554254475.C1130791706.m_C3904355907);
		if (array == null || array.Length == 0)
		{
			Debug.Assert(condition: false);
			return 0uL;
		}
		C3554254475(array[0].Trim(), out ushort ushort_);
		ulong num = (ulong)ushort_ << 48;
		if (array.Length >= 2)
		{
			C3554254475(array[1].Trim(), out ushort_);
			num |= (ulong)ushort_ << 32;
		}
		if (array.Length >= 3)
		{
			C3554254475(array[2].Trim(), out ushort_);
			num |= (ulong)ushort_ << 16;
		}
		if (array.Length >= 4)
		{
			C3554254475(array[3].Trim(), out ushort_);
			num |= ushort_;
		}
		return num;
	}

	public static string C1255198513(ulong ulong_0)
	{
		return C3554254475(ulong_0, 1u);
	}

	[Obsolete]
	public static string C3554254475(ulong ulong_0, bool bool_0)
	{
		return C3554254475(ulong_0, (!bool_0) ? 1u : 2u);
	}

	public static string C3554254475(ulong ulong_0, uint uint_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		uint num = 0u;
		for (int i = 0; i < 4; i++)
		{
			if (ulong_0 == 0L)
			{
				break;
			}
			ushort num2 = (ushort)(ulong_0 >> 48);
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append('.');
			}
			stringBuilder.Append(num2.ToString(NumberFormatInfo.InvariantInfo));
			num++;
			ulong_0 <<= 16;
		}
		for (; num < uint_0; num++)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append('.');
			}
			stringBuilder.Append('0');
		}
		return stringBuilder.ToString();
	}

	public static string C2852464175(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string.Empty;
		}
		try
		{
			byte[] bytes = C1255198513().GetBytes(string_0);
			byte[] inArray = global::C3904355907.C1304234792.C3554254475(bytes, global::C3554254475.C1130791706.m_C3554254475, (DataProtectionScope)0);
			return Convert.ToBase64String(inArray, Base64FormattingOptions.None);
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		return string_0;
	}

	public static string C2439710439(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string.Empty;
		}
		try
		{
			byte[] byte_ = Convert.FromBase64String(string_0);
			byte[] array = global::C3904355907.C1304234792.C3904355907(byte_, global::C3554254475.C1130791706.m_C3554254475, (DataProtectionScope)0);
			return C1255198513().GetString(array, 0, array.Length);
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		return string_0;
	}

	public static string C3554254475(int[] int_0)
	{
		if (int_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bb());
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_0.Length; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append(int_0[i].ToString(NumberFormatInfo.InvariantInfo));
		}
		return stringBuilder.ToString();
	}

	public static int[] C3707901625(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BC());
		}
		if (string_0.Length == 0)
		{
			return new int[0];
		}
		string[] array = string_0.Split(new char[1] { ' ' });
		int[] array2 = new int[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			if (!C3904355907(array[i], out int int_))
			{
				Debug.Assert(condition: false);
			}
			array2[i] = int_;
		}
		return array2;
	}

	public static string C3554254475(List<string> list_0, bool bool_0)
	{
		if (list_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bc());
		}
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (string item in list_0)
		{
			if (string.IsNullOrEmpty(item))
			{
				Debug.Assert(condition: false);
				continue;
			}
			Debug.Assert(item.IndexOfAny(global::C3554254475.C1130791706.m_C1255198513) < 0);
			if (!flag)
			{
				if (bool_0)
				{
					stringBuilder.Append(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BD());
				}
				else
				{
					stringBuilder.Append(';');
				}
			}
			stringBuilder.Append(item);
			flag = false;
		}
		return stringBuilder.ToString();
	}

	public static List<string> C3865851505(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bd());
		}
		List<string> list = new List<string>();
		if (string_0.Length == 0)
		{
			return list;
		}
		string[] array = string_0.Split(global::C3554254475.C1130791706.m_C1255198513);
		string[] array2 = array;
		foreach (string text in array2)
		{
			string text2 = text.Trim();
			if (text2.Length > 0)
			{
				list.Add(text2);
			}
		}
		return list;
	}

	public static string C1141589763(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return string.Empty;
		}
		if (string_0.Length == 0)
		{
			return string.Empty;
		}
		byte[] bytes = C1255198513().GetBytes(string_0);
		Array.Reverse((Array)bytes);
		for (int i = 0; i < bytes.Length; i++)
		{
			bytes[i] = (byte)(bytes[i] ^ 0x65u);
		}
		return Convert.ToBase64String(bytes, Base64FormattingOptions.None);
	}

	public static string C2137352139(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return string.Empty;
		}
		if (string_0.Length == 0)
		{
			return string.Empty;
		}
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (byte)(array[i] ^ 0x65u);
			}
			Array.Reverse((Array)array);
			return C1255198513().GetString(array, 0, array.Length);
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		return string.Empty;
	}

	public static List<string> C3554254475(string string_0, string[] string_1, bool bool_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3081909835());
		}
		if (string_1 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BE());
		}
		List<string> list = new List<string>();
		while (true)
		{
			int num = int.MaxValue;
			int num2 = -1;
			for (int i = 0; i < string_1.Length; i++)
			{
				string value = string_1[i];
				if (string.IsNullOrEmpty(value))
				{
					Debug.Assert(condition: false);
					continue;
				}
				int num3 = (bool_0 ? string_0.IndexOf(value) : string_0.IndexOf(value, global::C3554254475.C1130791706.C3554254475));
				if (num3 >= 0 && num3 < num)
				{
					num = num3;
					num2 = i;
				}
			}
			if (num == int.MaxValue)
			{
				break;
			}
			list.Add(string_0.Substring(0, num));
			list.Add(string_1[num2]);
			string_0 = string_0.Substring(num + string_1[num2].Length);
		}
		list.Add(string_0);
		return list;
	}

	public static string C856455061(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return string.Empty;
		}
		if (string_0.Length == 0)
		{
			return string.Empty;
		}
		string text = string_0;
		text = text.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ax(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aj());
		text = text.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aY(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aj());
		return text.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ak(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aj());
	}

	public static List<string> C140662621(string string_0)
	{
		List<string> list = new List<string>();
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return list;
		}
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		foreach (char c in string_0)
		{
			if ((c == ' ' || c == '\t' || c == '\r' || c == '\n') && !flag)
			{
				if (stringBuilder.Length > 0)
				{
					list.Add(stringBuilder.ToString());
				}
				stringBuilder.Remove(0, stringBuilder.Length);
			}
			else if (c == '"')
			{
				flag = !flag;
			}
			else
			{
				stringBuilder.Append(c);
			}
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	public static int C3904355907(string string_0, string string_1)
	{
		if (string_0.Length == string_1.Length)
		{
			return 0;
		}
		return (string_0.Length <= string_1.Length) ? 1 : (-1);
	}

	public static bool C2909332022(string string_0)
	{
		return C1255198513(string_0, null);
	}

	public static bool C1255198513(string string_0, string string_1)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return false;
		}
		if (!string_0.StartsWith(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Be(), global::C3554254475.C1130791706.C3554254475))
		{
			return false;
		}
		int num = string_0.IndexOf(',');
		if (num < 0)
		{
			return false;
		}
		if (!string.IsNullOrEmpty(string_1))
		{
			int num2 = string_0.IndexOf(';', 0, num);
			int num3 = ((num2 >= 0) ? num2 : num);
			string text = string_0.Substring(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Be().Length, num3 - DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Be().Length);
			if (!text.Equals(string_1, global::C3554254475.C1130791706.C3554254475))
			{
				return false;
			}
		}
		return true;
	}

	public static string C3554254475(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2238339752());
		}
		if (string_0 == null)
		{
			string_0 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BF();
		}
		return DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Be() + string_0 + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bf() + Convert.ToBase64String(byte_0, Base64FormattingOptions.None);
	}

	public static byte[] C2517025534(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BG());
		}
		if (!string_0.StartsWith(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Be(), global::C3554254475.C1130791706.C3554254475))
		{
			return null;
		}
		int num = string_0.IndexOf(',');
		if (num < 0)
		{
			return null;
		}
		string text = string_0.Substring(5, num - 5);
		bool flag = text.EndsWith(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bg(), global::C3554254475.C1130791706.C3554254475);
		string text2 = string_0.Substring(num + 1);
		if (flag)
		{
			return Convert.FromBase64String(text2);
		}
		MemoryStream memoryStream = new MemoryStream();
		Encoding aSCII = Encoding.ASCII;
		string[] array = text2.Split(new char[1] { '%' });
		byte[] bytes = aSCII.GetBytes(array[0]);
		memoryStream.Write(bytes, 0, bytes.Length);
		for (int i = 1; i < array.Length; i++)
		{
			memoryStream.WriteByte(Convert.ToByte(array[i].Substring(0, 2), 16));
			bytes = aSCII.GetBytes(array[i].Substring(2));
			memoryStream.Write(bytes, 0, bytes.Length);
		}
		bytes = memoryStream.ToArray();
		memoryStream.Close();
		return bytes;
	}

	internal static bool C3664761504(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return false;
		}
		if (string_0.Length == 0)
		{
			return false;
		}
		string[] c3554254475 = global::C3554254475.C1130791706.m_C3554254475;
		int num = 0;
		while (true)
		{
			if (num < c3554254475.Length)
			{
				string value = c3554254475[num];
				if (string_0.StartsWith(value, global::C3554254475.C1130791706.C3554254475))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static string C3775001192(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return string.Empty;
		}
		while (true)
		{
			int num = string_0.IndexOf('{');
			if (num < 0)
			{
				break;
			}
			int num2 = string_0.IndexOf('}', num);
			if (num2 < 0)
			{
				break;
			}
			string_0 = string_0.Substring(0, num) + string_0.Substring(num2 + 1);
		}
		return string_0;
	}

	public static C3775001192 C3554254475(C3664761504 c3664761504_0)
	{
		foreach (C3775001192 item in C1908338681())
		{
			if (item.C3554254475() == c3664761504_0)
			{
				return item;
			}
		}
		return null;
	}

	public static C3775001192 C1130791706(string string_0)
	{
		foreach (C3775001192 item in C1908338681())
		{
			if (item.C3904355907() == string_0)
			{
				return item;
			}
		}
		return null;
	}

	public static char C2013832146(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return '@';
		}
		if (global::C3554254475.C1130791706.m_C3904355907 == null)
		{
			global::C3554254475.C1130791706.m_C3904355907 = new string[5]
			{
				DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BH(),
				global::C3904355907.C30677878.C3554254475,
				global::C3904355907.C30677878.C3904355907,
				global::C3904355907.C30677878.C1255198513,
				global::C3904355907.C30677878.C4024072794
			};
		}
		for (int i = 0; i < global::C3554254475.C1130791706.m_C3904355907.Length; i++)
		{
			string text = global::C3554254475.C1130791706.m_C3904355907[i];
			foreach (char c in text)
			{
				if (string_0.IndexOf(c) < 0)
				{
					return c;
				}
			}
		}
		char c2 = 'À';
		while (true)
		{
			if (c2 < '\uffff')
			{
				if (string_0.IndexOf(c2) < 0)
				{
					break;
				}
				c2 = (char)(c2 + 1);
				continue;
			}
			return '\0';
		}
		return c2;
	}

	public static char C3554254475(byte byte_0)
	{
		if (byte_0 < 32)
		{
			return '.';
		}
		if (byte_0 < 127)
		{
			return (char)byte_0;
		}
		if (byte_0 < 160)
		{
			return '.';
		}
		if (byte_0 == 173)
		{
			return '-';
		}
		return (char)byte_0;
	}

	public static int C1908338681(string string_0, string string_1)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return 0;
		}
		if (string.IsNullOrEmpty(string_1))
		{
			Debug.Assert(condition: false);
			return 0;
		}
		int num = 0;
		int num2 = 0;
		while (num < string_0.Length)
		{
			int num3 = string_0.IndexOf(string_1, num);
			if (num3 < 0)
			{
				break;
			}
			num2++;
			num = num3 + 1;
		}
		return num2;
	}

	internal static string C878818188(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return null;
		}
		if (string_0.IndexOf('\0') < 0)
		{
			return string_0;
		}
		return string_0.Replace('\0', ' ');
	}

	internal static string C252678980(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return string.Empty;
		}
		string text = string_0;
		text = text.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bh(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BI());
		text = text.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bi(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BJ());
		return text.Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bj(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BK());
	}
}
