using System;
using Microsoft.VisualBasic.CompilerServices;

namespace ABC_Bot;

[StandardModule]
internal sealed class mod_os
{
	public static string getOs()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string servicePack = default(string);
		OperatingSystem oSVersion = default(OperatingSystem);
		string arg = default(string);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 471:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0012;
						case 4:
							goto IL_001b;
						case 5:
							goto IL_002c;
						case 20:
						case 21:
							goto IL_004b;
						case 7:
						case 9:
							goto IL_0058;
						case 12:
						case 13:
							goto IL_0064;
						case 16:
						case 17:
							goto IL_0070;
						case 25:
							goto IL_007c;
						case 26:
							goto IL_0080;
						case 27:
							goto IL_0092;
						case 38:
						case 39:
							goto IL_00ae;
						case 29:
						case 31:
							goto IL_00bb;
						case 34:
						case 35:
							goto IL_00c7;
						case 6:
						case 10:
						case 11:
						case 14:
						case 15:
						case 18:
						case 19:
						case 22:
						case 23:
						case 24:
						case 28:
						case 32:
						case 33:
						case 36:
						case 37:
						case 40:
						case 41:
						case 42:
						case 43:
						case 44:
							goto IL_00d1;
						case 45:
							goto IL_00e1;
						case 46:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 47:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00e1:
					num = 45;
					servicePack = oSVersion.ServicePack;
					break;
					IL_00d1:
					num = 44;
					oSVersion.VersionString.ToString();
					goto IL_00e1;
					IL_0009:
					num = 2;
					oSVersion = Environment.OSVersion;
					goto IL_0012;
					IL_0012:
					num = 3;
					arg = "";
					goto IL_001b;
					IL_001b:
					num = 4;
					if (oSVersion.Version.Major == 5)
					{
						goto IL_002c;
					}
					goto IL_007c;
					IL_002c:
					num = 5;
					switch (oSVersion.Version.Minor)
					{
					case 0:
						goto IL_0058;
					case 1:
						goto IL_0064;
					case 2:
						goto IL_0070;
					}
					goto IL_004b;
					IL_0070:
					num = 17;
					arg = "Windows Server 2003";
					goto IL_00d1;
					IL_0064:
					num = 13;
					arg = "Windows XP";
					goto IL_00d1;
					IL_0058:
					num = 9;
					arg = "Windows 2000";
					goto IL_00d1;
					IL_004b:
					num = 21;
					arg = oSVersion.ToString();
					goto IL_00d1;
					IL_007c:
					num = 25;
					goto IL_0080;
					IL_0080:
					num = 26;
					if (oSVersion.Version.Major == 6)
					{
						goto IL_0092;
					}
					goto IL_00d1;
					IL_0092:
					num = 27;
					switch (oSVersion.Version.Minor)
					{
					case 0:
						goto IL_00bb;
					case 1:
						goto IL_00c7;
					}
					goto IL_00ae;
					IL_00c7:
					num = 35;
					arg = "Windows 7";
					goto IL_00d1;
					IL_00bb:
					num = 31;
					arg = "Windows Vista";
					goto IL_00d1;
					IL_00ae:
					num = 39;
					arg = oSVersion.ToString();
					goto IL_00d1;
					end_IL_0000_2:
					break;
				}
				num = 46;
				text = $"{arg}, {servicePack}";
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 471;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
