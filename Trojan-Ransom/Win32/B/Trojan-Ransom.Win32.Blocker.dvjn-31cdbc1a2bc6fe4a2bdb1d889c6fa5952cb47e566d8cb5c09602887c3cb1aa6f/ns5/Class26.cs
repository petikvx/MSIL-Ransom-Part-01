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
				if (!bool_0)
				{
					goto IL_0018;
				}
				goto IL_0078;
				IL_0018:
				stringBuilder.Append(", Culture=");
				stringBuilder.Append((string_1.Length != 0) ? string_1 : "neutral");
				while (true)
				{
					stringBuilder.Append(", PublicKeyToken=");
					if (HrGv6Qg3YIwule5n6fj())
					{
					}
					switch (5)
					{
					case 4:
						goto end_IL_003d;
					case 0:
					case 3:
						goto IL_00ac;
					case 5:
						stringBuilder.Append((string_2.Length == 0) ? "null" : string_2);
						goto case 6;
					case 6:
						return stringBuilder.ToString();
					}
					continue;
					end_IL_003d:
					break;
				}
				goto IL_0078;
				IL_0078:
				if (version_0 != null)
				{
					stringBuilder.Append(", Version=");
					stringBuilder.Append(version_0);
				}
				goto IL_0018;
			}
		}

		public Struct13(string assemblyFullName)
		{
			version_0 = null;
			string text2 = default(string);
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
						string text;
						int num2;
						if (num < array.Length)
						{
							text = array[num];
							num2 = 7;
							if (HrGv6Qg3YIwule5n6fj())
							{
								goto IL_001e;
							}
							goto IL_0079;
						}
						return;
						IL_0040:
						string_1 = text2.Substring(8);
						if (string_1 == "neutral")
						{
							string_1 = string.Empty;
							num2 = 3;
							if (!HrGv6Qg3YIwule5n6fj())
							{
							}
							goto IL_0079;
						}
						goto IL_00f9;
						IL_0079:
						switch (num2)
						{
						case 7:
							break;
						default:
							goto IL_0040;
						case 0:
						case 3:
						case 4:
							goto IL_00f9;
						case 8:
							continue;
						case 1:
						case 5:
							goto end_IL_00fd;
						case 6:
							goto end_IL_0108;
						}
						goto IL_001e;
						IL_001e:
						text2 = text.Trim();
						if (!text2.StartsWith("Version="))
						{
							if (text2.StartsWith("Culture="))
							{
								goto IL_0040;
							}
							if (text2.StartsWith("PublicKeyToken="))
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
						else
						{
							version_0 = new Version(text2.Substring(8));
						}
						goto IL_00f9;
						IL_00f9:
						num++;
						continue;
						end_IL_00fd:
						break;
					}
					continue;
					end_IL_0108:
					break;
				}
			}
		}

		internal static bool IIb6S3gZScYcaj8pXJy()
		{
			return true;
		}

		internal static bool HrGv6Qg3YIwule5n6fj()
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

	internal static bool yCpAA7gpQSnSVvjdQMp()
	{
		return true;
	}

	internal static bool s55pNkgAD3n9CVk32jT()
	{
		return false;
	}
}
