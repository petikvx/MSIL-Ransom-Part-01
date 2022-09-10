using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace ns5;

internal class Class25
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
				if (bool_0)
				{
					int num = 0;
					if (!SQJViBNXINiUg4SgNtI())
					{
						goto IL_005d;
					}
					while (true)
					{
						switch (num)
						{
						default:
							num = 5;
							if (!aOXbCENS5J5eCBiXUrX())
							{
								continue;
							}
							goto IL_00b1;
						case 3:
							break;
						case 0:
						case 1:
							goto IL_005d;
						case 2:
						case 5:
							goto IL_00b1;
						case 4:
							goto IL_00bd;
						case 6:
							goto end_IL_0052;
						}
						break;
					}
					continue;
				}
				goto IL_0084;
				IL_0084:
				stringBuilder.Append(", Culture=");
				stringBuilder.Append((string_1.Length == 0) ? "neutral" : string_1);
				goto IL_00b1;
				IL_00b1:
				stringBuilder.Append(", PublicKeyToken=");
				goto IL_00bd;
				IL_005d:
				if (version_0 != null)
				{
					stringBuilder.Append(", Version=");
					stringBuilder.Append(version_0);
				}
				goto IL_0084;
				IL_00bd:
				stringBuilder.Append((string_2.Length == 0) ? "null" : string_2);
				break;
				continue;
				end_IL_0052:
				break;
			}
			return stringBuilder.ToString();
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

		internal static bool SQJViBNXINiUg4SgNtI()
		{
			return true;
		}

		internal static bool aOXbCENS5J5eCBiXUrX()
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

	internal static bool iw2haFNGFgE5yJJqn7w()
	{
		return true;
	}

	internal static bool Gdhy6gNodZGgA1RLrF4()
	{
		return false;
	}
}
