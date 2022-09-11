using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ns1;

internal class Class5
{
	private sealed class Class6
	{
		public string string_0;

		public bool method_0(string string_1)
		{
			return string_1.Contains(string_0);
		}
	}

	public static readonly List<string> list_0 = new List<string>();

	public static readonly List<string> list_1 = new List<string>();

	internal static Func<string, bool> func_0;

	internal static Func<string, FileInfo> func_1;

	private static Func<string, string[]> func_2;

	private static Func<string[], string> func_3;

	public static void smethod_0(string string_0)
	{
		Class6 @class = new Class6();
		@class.string_0 = string_0;
		try
		{
			string string_ = "tasklist";
			string string_2 = "/v /fo csv";
			string text = Class32.smethod_45(string_2, string_);
			string[] separator = new string[1] { "\r\n" };
			string[] source = text.Split(separator, StringSplitOptions.None);
			IEnumerable<string> source2 = source.Where(@class.method_0);
			if (func_2 == null)
			{
				func_2 = smethod_3;
			}
			IEnumerable<string[]> source3 = source2.Select(func_2);
			if (func_3 == null)
			{
				func_3 = smethod_4;
			}
			List<string> list = source3.Select(func_3).ToList();
			foreach (string item in list)
			{
				string_ = "taskkill";
				string_2 = "/f /pid " + item;
				Class32.smethod_45(string_2, string_);
			}
		}
		catch (Exception)
		{
		}
	}

	internal static bool smethod_1(string string_0)
	{
		return Class32.smethod_0(string_0);
	}

	internal static FileInfo smethod_2(string string_0)
	{
		return new FileInfo(string_0);
	}

	private static string[] smethod_3(string string_0)
	{
		return string_0.Split(new char[1] { ',' });
	}

	private static string smethod_4(string[] string_0)
	{
		return string_0[1].Replace("\"", "");
	}
}
