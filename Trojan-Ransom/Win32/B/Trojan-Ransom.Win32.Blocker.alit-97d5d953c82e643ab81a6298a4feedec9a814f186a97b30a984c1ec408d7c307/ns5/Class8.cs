using System;
using System.Collections;
using System.Diagnostics;
using System.Text;

namespace ns5;

internal sealed class Class8
{
	internal struct Struct1
	{
		public string string_0;

		public Version version_0;

		public string string_1;

		public string string_2;

		public string method_0(bool includeVersion)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string_0);
			if (includeVersion && version_0 != null)
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

		public Struct1(string assemblyFullName)
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
	}

	internal const string string_0 = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

	private const int int_0 = 4;

	internal static Hashtable hashtable_0 = new Hashtable();

	internal unsafe static bool IsWebApplication
	{
		get
		{
			void* ptr = stackalloc byte[2];
			try
			{
				string text = Process.GetCurrentProcess().MainModule!.ModuleName!.ToLower();
				if (text == "w3wp.exe")
				{
					*(sbyte*)ptr = 1;
				}
				else
				{
					if (!(text == "aspnet_wp.exe"))
					{
						goto IL_0043;
					}
					*(sbyte*)ptr = 1;
				}
			}
			catch
			{
				goto IL_0043;
			}
			((byte*)ptr)[1] = *(byte*)ptr;
			goto IL_0052;
			IL_0043:
			((byte*)ptr)[1] = 0;
			goto IL_0052;
			IL_0052:
			return ((byte*)ptr)[1] != 0;
		}
	}
}