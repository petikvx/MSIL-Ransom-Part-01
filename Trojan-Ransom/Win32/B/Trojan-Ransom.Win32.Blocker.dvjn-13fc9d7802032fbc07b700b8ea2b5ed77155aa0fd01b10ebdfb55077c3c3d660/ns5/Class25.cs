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

		public Struct13(string assemblyFullName)
		{
			version_0 = null;
			while (true)
			{
				string_1 = string.Empty;
				string_2 = string.Empty;
				string_0 = string.Empty;
				while (true)
				{
					string[] array = assemblyFullName.Split(new char[1] { ',' });
					int num = 0;
					while (true)
					{
						IL_0123:
						string text;
						int num2;
						if (num < array.Length)
						{
							text = array[num];
							num2 = 4;
							if (!QknPLiDOG16QBKVWbfQ())
							{
								goto IL_00d5;
							}
							goto IL_00f8;
						}
						return;
						IL_00d5:
						if (string_2 == "null")
						{
							string_2 = string.Empty;
						}
						goto IL_0026;
						IL_00f8:
						while (true)
						{
							switch (num2)
							{
							case 2:
							case 5:
								break;
							case 4:
								goto IL_003a;
							case 3:
							case 6:
								goto IL_00d5;
							default:
								num2 = 6;
								if (QknPLiDOG16QBKVWbfQ())
								{
									continue;
								}
								goto end_IL_012e;
							case 8:
								goto IL_0123;
							case 1:
								goto end_IL_0123;
							case 0:
							case 7:
								goto end_IL_012e;
							}
							break;
						}
						goto IL_0026;
						IL_0026:
						num++;
						num2 = 8;
						if (!QknPLiDOG16QBKVWbfQ())
						{
							goto IL_003a;
						}
						goto IL_00f8;
						IL_003a:
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
						else
						{
							if (text2.StartsWith("PublicKeyToken="))
							{
								string_2 = text2.Substring(15);
								goto IL_00d5;
							}
							string_0 = text2;
						}
						goto IL_0026;
						continue;
						end_IL_0123:
						break;
					}
					continue;
					end_IL_012e:
					break;
				}
			}
		}

		internal static bool QknPLiDOG16QBKVWbfQ()
		{
			return true;
		}

		internal static bool fUxnU7DYv70uGI9xlwa()
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

	internal static bool n4oa6mD0V14WMbHrQjl()
	{
		return true;
	}

	internal static bool Qm2o7uDS3YAmgqr54bB()
	{
		return false;
	}
}
