using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace ns2;

internal class Class8
{
	internal struct Struct4
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

		public Struct4(string assemblyFullName)
		{
			version_0 = null;
			string_1 = string.Empty;
			string_2 = string.Empty;
			string_0 = string.Empty;
			string[] array = assemblyFullName.Split(new char[1] { ',' });
			foreach (string text in array)
			{
				string text2 = text.Trim();
				if (text2.StartsWith("Version="))
				{
					version_0 = new Version(text2.Substring(8));
				}
				else if (text2.StartsWith("Culture="))
				{
					string_1 = text2.Substring(8);
					if (string_1 == "neutral")
					{
						string_1 = string.Empty;
					}
				}
				else if (text2.StartsWith("PublicKeyToken="))
				{
					string_2 = text2.Substring(15);
					if (string_2 == "null")
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

		internal static bool KVYcGbPQIH6X5AANHb()
		{
			return true;
		}

		internal static bool XqgSoS5NZtK4ZAK4YU()
		{
			return false;
		}
	}

	internal static Dictionary<string, Assembly> dictionary_0 = new Dictionary<string, Assembly>();

	internal static bool IsWebApplication
	{
		get
		{
			bool result;
			try
			{
				string text = Process.GetCurrentProcess().MainModule!.ModuleName!.ToLower();
				if (text == "w3wp.exe")
				{
					result = true;
				}
				else
				{
					if (!(text == "aspnet_wp.exe"))
					{
						goto IL_003c;
					}
					result = true;
				}
			}
			catch
			{
				goto IL_003c;
			}
			return result;
			IL_003c:
			return false;
		}
	}

	internal static bool pk175wcQ9mXBM1bdLv()
	{
		return true;
	}

	internal static bool o20B6hBF5LSLpReA0y()
	{
		return false;
	}
}
