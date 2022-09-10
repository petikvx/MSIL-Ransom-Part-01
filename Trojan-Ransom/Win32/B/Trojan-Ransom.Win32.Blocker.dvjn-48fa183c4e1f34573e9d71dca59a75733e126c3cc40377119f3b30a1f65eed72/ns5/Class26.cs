using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace ns5;

internal class Class26
{
	internal struct Struct13
	{
		public string string_0;

		public Version version_0;

		public string string_1;

		public string string_2;

		public string method_0(bool bool_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string_0);
			while (true)
			{
				IL_00ac:
				if (bool_0)
				{
					goto IL_0074;
				}
				goto IL_009b;
				IL_009b:
				stringBuilder.Append(", Culture=");
				while (true)
				{
					stringBuilder.Append((string_1.Length != 0) ? string_1 : "neutral");
					stringBuilder.Append(", PublicKeyToken=");
					if (!am33Ucat2d0aZg1lWPj())
					{
						switch (5)
						{
						case 4:
							goto end_IL_0018;
						case 0:
						case 3:
							goto IL_00ac;
						case 5:
							stringBuilder.Append((string_2.Length == 0) ? "null" : string_2);
							goto IL_00d5;
						case 6:
							goto IL_00d5;
						}
						continue;
					}
					goto IL_00d5;
					IL_00d5:
					return stringBuilder.ToString();
					continue;
					end_IL_0018:
					break;
				}
				goto IL_0074;
				IL_0074:
				if (version_0 != null)
				{
					stringBuilder.Append(", Version=");
					stringBuilder.Append(version_0);
				}
				goto IL_009b;
			}
		}

		public Struct13(string assemblyFullName)
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

		internal static bool oFWbXAayfpkcZ3Eg6jR()
		{
			return true;
		}

		internal static bool am33Ucat2d0aZg1lWPj()
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

	internal static bool Oc9rM5aIsnPvnM0dPPN()
	{
		return true;
	}

	internal static bool BGqcVLaJQWvNcHOTU1v()
	{
		return false;
	}
}
