using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

[SuppressIldasm]
internal sealed class Class4
{
	[SuppressIldasm]
	internal struct Struct0
	{
		public string string_0;

		public Version version_0;

		public string string_1;

		public string string_2;

		public string method_0(bool bool_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string_0);
			if (bool_0 && version_0 != null)
			{
				stringBuilder.Append(Class18.smethod_3());
				stringBuilder.Append(version_0);
			}
			stringBuilder.Append(Class18.smethod_4());
			stringBuilder.Append((string_1.Length == 0) ? Class18.smethod_5() : string_1);
			stringBuilder.Append(Class18.smethod_6());
			stringBuilder.Append((string_2.Length == 0) ? Class18.smethod_7() : string_2);
			return stringBuilder.ToString();
		}

		public Struct0(string assemblyFullName)
		{
			version_0 = null;
			string_1 = string.Empty;
			string_2 = string.Empty;
			string_0 = string.Empty;
			string[] array = assemblyFullName.Split(new char[1] { ',' });
			foreach (string text in array)
			{
				string text2 = text.Trim();
				if (text2.StartsWith(Class18.smethod_10()))
				{
					version_0 = new Version(text2.Substring(8));
				}
				else if (text2.StartsWith(Class18.smethod_8()))
				{
					string_1 = text2.Substring(8);
					if (string_1 == Class18.smethod_5())
					{
						string_1 = string.Empty;
					}
				}
				else if (text2.StartsWith(Class18.smethod_9()))
				{
					string_2 = text2.Substring(15);
					if (string_2 == Class18.smethod_7())
					{
						string_2 = string.Empty;
					}
				}
				else
				{
					string_0 = text2;
				}
			}
		}
	}

	internal const string string_0 = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

	private const int int_0 = 4;

	internal static Dictionary<string, Assembly> dictionary_0 = new Dictionary<string, Assembly>();

	[SpecialName]
	internal static bool smethod_0()
	{
		try
		{
			string text = Process.GetCurrentProcess().MainModule!.ModuleName!.ToLower();
			if (text == Class18.smethod_1())
			{
				return true;
			}
			if (text == Class18.smethod_2())
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}
}
