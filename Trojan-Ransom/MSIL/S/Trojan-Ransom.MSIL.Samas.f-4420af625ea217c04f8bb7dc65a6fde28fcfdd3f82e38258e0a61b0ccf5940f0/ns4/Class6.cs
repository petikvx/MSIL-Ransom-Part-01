using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace ns4;

internal sealed class Class6
{
	internal struct Struct2
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
				stringBuilder.Append(", Version=");
				stringBuilder.Append(version_0);
			}
			stringBuilder.Append(", Culture=");
			stringBuilder.Append((string_1.Length == 0) ? "neutral" : string_1);
			stringBuilder.Append(", PublicKeyToken=");
			stringBuilder.Append((string_2.Length == 0) ? "null" : string_2);
			return stringBuilder.ToString();
		}

		public Struct2(string string_3)
		{
			version_0 = null;
			string_1 = string.Empty;
			string_2 = string.Empty;
			string_0 = string.Empty;
			string[] array = string_3.Split(new char[1] { ',' });
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				if (text.StartsWith("Version="))
				{
					version_0 = new Version(text.Substring(8));
				}
				else if (text.StartsWith("Culture="))
				{
					string_1 = text.Substring(8);
					if (string_1 == "neutral")
					{
						string_1 = string.Empty;
					}
				}
				else if (text.StartsWith("PublicKeyToken="))
				{
					string_2 = text.Substring(15);
					if (string_2 == "null")
					{
						string_2 = string.Empty;
					}
				}
				else
				{
					string_0 = text;
				}
			}
		}
	}

	internal const string string_0 = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

	private const int int_0 = 4;

	internal static Dictionary<string, Assembly> dictionary_0 = new Dictionary<string, Assembly>();

	internal static bool IsWebApplication
	{
		get
		{
			try
			{
				string text = Process.GetCurrentProcess().MainModule!.ModuleName!.ToLower();
				if (text == "w3wp.exe")
				{
					return true;
				}
				if (text == "aspnet_wp.exe")
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
}
