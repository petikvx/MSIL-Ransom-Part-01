using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class _______________________________________________
{
	public static bool _ = false;

	public static string __ = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + _003CModule_003E._______<string>(236852029u);

	public static string ___ = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + _003CModule_003E._____<string>(557937962u);

	public static string ____ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E._____<string>(445349365u);

	public static string _____ = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + _003CModule_003E.______<string>(2681471099u);

	public static string ______ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E._____<string>(201716570u);

	public static string _______ = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + _003CModule_003E._______<string>(1789853648u);

	public static string ________ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.______<string>(2014329861u);

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int int_0, int int_1);

	public unsafe static void __(string string_0)
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
				int num6;
				nint num7;
				int num8;
				int num9;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 578:
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
							goto IL_0008;
						case 3:
							goto IL_003b;
						case 4:
							goto IL_0048;
						case 6:
							goto IL_0080;
						case 7:
							goto IL_00d3;
						case 8:
							goto IL_00f8;
						case 10:
							goto IL_0136;
						case 11:
							goto IL_0140;
						case 12:
							goto IL_018b;
						case 14:
							goto IL_01ac;
						case 15:
							goto IL_01af;
						default:
							goto end_IL_0000;
						case 5:
						case 9:
						case 13:
						case 16:
						case 17:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_01af:
					num = 15;
					______________________________________________________________.______________(_003CModule_003E._____<string>(1464211711u), _003CModule_003E.___<string>(62867243u));
					goto end_IL_0000_2;
					IL_0008:
					num = 2;
					if (______())
					{
						int num5 = ___________._;
						if ((0xC90 & (num5 * 224 + num5 * 288 + -4211)) == 0)
						{
							goto end_IL_0000_2;
						}
						goto IL_003b;
					}
					goto IL_0080;
					IL_00d3:
					num = 7;
					_______(_______________________________________________.______, _______________________________________________.______, string_0);
					if (sizeof(int) + 26895 == 26899)
					{
					}
					goto IL_00f8;
					IL_003b:
					num = 3;
					________(_______________________________________________._______, string_0);
					goto IL_0048;
					IL_0048:
					num = 4;
					num6 = _003CModule_003E._____________;
					num7 = ((((uint)(1073741824 * num6) ^ 0x2291u) != 0) ? ((nint)Type.EmptyTypes.LongLength + 2) : (sizeof(double) + 2080157580));
					goto IL_011b;
					IL_00f8:
					num = 8;
					______________________________________________________________.______________(_003CModule_003E._______<string>(2721646351u), _003CModule_003E._____<string>(2076956526u));
					num7 = (nint)Type.EmptyTypes.LongLength + 0;
					goto IL_011b;
					IL_0136:
					num = 10;
					if (____())
					{
						goto IL_0140;
					}
					goto IL_01ac;
					IL_0080:
					num = 6;
					num8 = _003CModule_003E.______________;
					if ((0x80000000u & (((uint)num8 % 1839123172u) ^ 0xFFFFF721u)) == 2147483648u)
					{
						if ((uint)num2 % 22486u == 1879671821)
						{
							break;
						}
						num7 = sizeof(ulong) + -7;
					}
					else
					{
						num7 = (nint)Type.EmptyTypes.LongLength + 875603800;
					}
					goto IL_011b;
					IL_0140:
					num = 11;
					num9 = _003CModule_003E._____________;
					if (((~(-(num9 * -662700032)) != -(num9 * 397 + num9 * 115) * 32) ? 31943 : 1291661600) != 31943)
					{
					}
					_______(_______________________________________________.__, _______________________________________________.____, string_0);
					goto IL_018b;
					IL_01ac:
					num = 14;
					goto IL_01af;
					IL_018b:
					num = 12;
					______________________________________________________________.______________(_003CModule_003E.___<string>(982404538u), _003CModule_003E._______<string>(1058440249u));
					goto end_IL_0000_2;
					IL_011b:
					switch (num7)
					{
					case 1:
						break;
					default:
						goto end_IL_0000_3;
					case 0:
						goto end_IL_0000_2;
					}
					if (_____())
					{
						goto IL_00d3;
					}
					goto IL_0136;
					end_IL_0000_3:
					break;
				}
				______________________________________________________________.______________(_003CModule_003E._____<string>(1464211711u), _003CModule_003E.______<string>(999801087u));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 578;
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

	public static string ___(string string_0)
	{
		try
		{
			return string_0.Substring(string_0.LastIndexOf(_003CModule_003E._______<string>(492003881u), StringComparison.Ordinal) + 1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return string_0;
		}
	}

	public static bool ____()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
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
				case 75:
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
							goto IL_0015;
						case 4:
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0015:
					num = 3;
					flag = true;
					goto end_IL_0000_3;
					IL_0007:
					num = 2;
					if (!File.Exists(_______________________________________________.__))
					{
						break;
					}
					goto IL_0015;
					end_IL_0000_2:
					break;
				}
				num = 5;
				flag = false;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 75;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool _____()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
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
				case 75:
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
							goto IL_0015;
						case 4:
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0015:
					num = 3;
					flag = true;
					goto end_IL_0000_3;
					IL_0007:
					num = 2;
					if (!File.Exists(_______________________________________________.______))
					{
						break;
					}
					goto IL_0015;
					end_IL_0000_2:
					break;
				}
				num = 5;
				flag = false;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 75;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			______________________._______ = num;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool ______()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
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
				case 75:
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
							goto IL_0015;
						case 4:
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0015:
					num = 3;
					flag = true;
					goto end_IL_0000_3;
					IL_0007:
					num = 2;
					if (!File.Exists(_______________________________________________._______))
					{
						break;
					}
					goto IL_0015;
					end_IL_0000_2:
					break;
				}
				num = 5;
				flag = false;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 75;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public unsafe static void _______(string string_0, string string_1, string string_2)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		int num7 = default(int);
		int num8 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				nint num5;
				int num6;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 803:
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
							goto IL_0008;
						case 11:
							goto IL_001e;
						case 13:
							goto IL_004a;
						case 5:
							goto IL_0070;
						case 6:
							goto IL_007a;
						case 7:
							goto IL_0091;
						case 10:
							goto IL_00c1;
						case 3:
							goto IL_0177;
						case 4:
							goto IL_0181;
						case 8:
							goto IL_0254;
						case 16:
							goto IL_026b;
						case 17:
							goto IL_0281;
						case 14:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
						case 12:
						case 15:
						case 18:
						case 19:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_019c:
					processStartInfo.Arguments = _003CModule_003E._____<string>(3370797896u) + string_1 + _003CModule_003E.______<string>(972167253u) + string_2 + _003CModule_003E._______<string>(2966123985u);
					num5 = sizeof(int) + -2;
					goto IL_0236;
					IL_0008:
					num = 2;
					processStartInfo = new ProcessStartInfo();
					num5 = (nint)Type.EmptyTypes.LongLength + 0;
					goto IL_0236;
					IL_0236:
					switch (num5)
					{
					case 3:
						break;
					case 2:
						goto IL_0070;
					case 1:
						goto IL_008a;
					default:
						goto IL_0177;
					case 4:
						goto end_IL_0000_2;
					}
					goto IL_0038;
					IL_008a:
					Process.Start(processStartInfo);
					goto IL_0091;
					IL_0091:
					num = 7;
					if (!string_0.Contains(_003CModule_003E._____<string>(1626602138u)))
					{
						goto IL_00c1;
					}
					if (sizeof(ulong) + 15134 != 15142)
					{
						goto IL_019c;
					}
					goto IL_0254;
					IL_026b:
					num = 16;
					if (!string_0.Contains(_003CModule_003E._____<string>(3034887096u)))
					{
						goto end_IL_0000_3;
					}
					goto IL_0281;
					IL_0254:
					num = 8;
					_________(_003CModule_003E.___<string>(3591498653u));
					goto end_IL_0000_3;
					IL_00c1:
					num = 10;
					num6 = _003CModule_003E.__________;
					if (((num6 * 65536) ^ -7037) == 0)
					{
						num5 = (nint)Type.EmptyTypes.LongLength + 1836527369;
					}
					else if ((0xFDE & ((num7 << 11) + -5420)) == 0)
					{
						num5 = ((((num8 * 1291 + num8 * 757) ^ 0xC0B) == 0) ? ((nint)Type.EmptyTypes.LongLength + -1468712637) : ((nint)Type.EmptyTypes.LongLength + 1830062664));
					}
					else if ((0x79FA6CF6u ^ (uint)(num * 201 + 3976 + num * 55)) != 0)
					{
						num5 = (((-1682 | (num7 * 878 + 1170 * num7 + 2423)) == -1665) ? ((nint)Type.EmptyTypes.LongLength + 3) : ((nint)Type.EmptyTypes.LongLength + 1210754440));
					}
					else
					{
						num8 = _003CModule_003E.______________;
						if (1024 * num8 + -671088640 == num8 << 10)
						{
							goto IL_0177;
						}
						num5 = (nint)Type.EmptyTypes.LongLength + 1318893668;
					}
					goto IL_0236;
					IL_001e:
					num = 11;
					if ((nint)Type.EmptyTypes.LongLength + 11872 != 11872)
					{
						goto IL_0038;
					}
					goto IL_0299;
					IL_0299:
					_________(_003CModule_003E.____<string>(2392912635u));
					goto end_IL_0000_3;
					IL_0070:
					num = 5;
					processStartInfo.CreateNoWindow = true;
					goto IL_007a;
					IL_0038:
					if (string_0.Contains(_003CModule_003E._____<string>(2922298499u)))
					{
						goto IL_001e;
					}
					goto IL_004a;
					IL_004a:
					num = 13;
					if (string_0.Contains(_003CModule_003E._____<string>(1759501327u)))
					{
						num5 = (nint)Type.EmptyTypes.LongLength + 4;
						goto IL_0236;
					}
					goto IL_026b;
					IL_007a:
					num = 6;
					num5 = (nint)Type.EmptyTypes.LongLength + 1;
					goto IL_0236;
					IL_0281:
					num = 17;
					_________(_003CModule_003E.____<string>(3159327612u));
					goto end_IL_0000_3;
					IL_0177:
					num = 3;
					processStartInfo.FileName = string_0;
					goto IL_0181;
					IL_0181:
					num = 4;
					if (sizeof(ulong) + 26656 == 26664)
					{
						goto IL_019c;
					}
					goto IL_0299;
					end_IL_0000_2:
					break;
				}
				num = 14;
				_________(_003CModule_003E.___<string>(3511378730u));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 803;
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
	}

	public unsafe static void ________(string string_0, string string_1)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		Process process = default(Process);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num5;
				nint num6;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 265:
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
							goto IL_001c;
						case 4:
							goto IL_0026;
						case 5:
							goto IL_0085;
						case 6:
							goto IL_00a2;
						case 7:
							goto IL_00ad;
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0026:
					num = 4;
					if ((((num3 << 2) + -8891) & 4) != ((4 * ~num3) & 4))
					{
						if (((-num3 ^ (num3 - 4234)) & 1) == 0)
						{
							num5 = sizeof(ushort) + 1011069272;
							num6 = num5;
						}
						else
						{
							num6 = (nint)Type.EmptyTypes.LongLength + 1172345196;
						}
					}
					else
					{
						num6 = (nint)Type.EmptyTypes.LongLength + 0;
					}
					goto IL_006f;
					IL_0007:
					num = 2;
					processStartInfo = new ProcessStartInfo();
					num5 = 1;
					num6 = num5;
					goto IL_006f;
					IL_006f:
					switch (num6)
					{
					case 0:
						goto IL_007e;
					}
					goto IL_001c;
					IL_007e:
					processStartInfo.Arguments = string_1;
					goto IL_0085;
					IL_0085:
					num = 5;
					processStartInfo.CreateNoWindow = true;
					if (sizeof(ushort) + 28426 == -25063)
					{
					}
					goto IL_00a2;
					IL_00a2:
					num = 6;
					process = Process.Start(processStartInfo);
					goto IL_00ad;
					IL_00ad:
					num = 7;
					_________(Conversions.ToString((int)process.MainWindowHandle));
					break;
					IL_001c:
					num = 3;
					processStartInfo.FileName = string_0;
					goto IL_0026;
					end_IL_0000_2:
					break;
				}
				num = 8;
				Thread.Sleep(1000);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 265;
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
	}

	public static void _________(string string_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process[] processesByName = default(Process[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					if (-14083 != (nint)Type.EmptyTypes.LongLength + -14084)
					{
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_001a;
					}
					goto IL_0027;
				case 116:
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
							goto IL_001a;
						case 3:
							goto IL_0027;
						case 4:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_001a:
					num = 2;
					Thread.Sleep(1000);
					goto IL_0027;
					IL_0027:
					num = 3;
					processesByName = Process.GetProcessesByName(string_0);
					break;
					end_IL_0000_2:
					break;
				}
				num = 4;
				ShowWindow(processesByName[0].MainWindowHandle.ToInt32(), 0);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 116;
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
	}
}
