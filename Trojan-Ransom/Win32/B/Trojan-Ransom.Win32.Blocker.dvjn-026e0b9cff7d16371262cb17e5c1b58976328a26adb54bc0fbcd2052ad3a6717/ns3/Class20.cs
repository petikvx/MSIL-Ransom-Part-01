using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace ns3;

internal class Class20
{
	internal struct Struct5
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
				int num;
				if (bool_0)
				{
					num = 5;
					if (zuPqaKB6YUhRqwrSjQ())
					{
						goto IL_006a;
					}
					goto IL_0095;
				}
				goto IL_00bc;
				IL_0095:
				if (version_0 != null)
				{
					stringBuilder.Append(", Version=");
					stringBuilder.Append(version_0);
				}
				goto IL_00bc;
				IL_00bc:
				stringBuilder.Append(", Culture=");
				goto IL_0018;
				IL_0018:
				stringBuilder.Append((string_1.Length != 0) ? string_1 : "neutral");
				stringBuilder.Append(", PublicKeyToken=");
				stringBuilder.Append((string_2.Length == 0) ? "null" : string_2);
				num = 6;
				if (E0bK8aqQ5hps6Wvy53())
				{
					continue;
				}
				goto IL_006a;
				IL_006a:
				switch (num)
				{
				case 1:
					break;
				case 5:
					goto IL_0095;
				default:
					goto IL_00bc;
				case 0:
				case 3:
					continue;
				case 6:
					return stringBuilder.ToString();
				}
				goto IL_0018;
			}
		}

		public Struct5(string assemblyFullName)
		{
			version_0 = null;
			while (true)
			{
				string_1 = string.Empty;
				string_2 = string.Empty;
				string_0 = string.Empty;
				string[] array = assemblyFullName.Split(new char[1] { ',' });
				int num = 0;
				while (true)
				{
					if (num >= array.Length)
					{
						return;
					}
					string text = array[num];
					string text2 = text.Trim();
					if (text2.StartsWith("Version="))
					{
						if (zuPqaKB6YUhRqwrSjQ())
						{
							switch (0)
							{
							case 0:
								version_0 = new Version(text2.Substring(8));
								goto IL_00ee;
							case 1:
							case 2:
							case 4:
							case 6:
								goto IL_00ee;
							case 8:
								continue;
							case 5:
								goto end_IL_00f2;
							}
						}
						goto IL_00a0;
					}
					if (text2.StartsWith("Culture="))
					{
						string_1 = text2.Substring(8);
						if (string_1 == "neutral")
						{
							goto IL_00a0;
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
					goto IL_00ee;
					IL_00a0:
					string_1 = string.Empty;
					goto IL_00ee;
					IL_00ee:
					num++;
					continue;
					end_IL_00f2:
					break;
				}
			}
		}

		internal static bool zuPqaKB6YUhRqwrSjQ()
		{
			return true;
		}

		internal static bool E0bK8aqQ5hps6Wvy53()
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

	internal static bool vLQait2vwwL8wYZnUt()
	{
		return true;
	}

	internal static bool IswEyqrtNoENoDH854()
	{
		return false;
	}
}
