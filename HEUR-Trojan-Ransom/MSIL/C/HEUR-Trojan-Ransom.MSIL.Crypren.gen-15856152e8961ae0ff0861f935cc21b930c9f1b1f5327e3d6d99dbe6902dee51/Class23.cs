using System;
using System.Collections.Generic;
using System.Globalization;

internal static class Class23
{
	public static int smethod_0(TimeSpan timeSpan_0)
	{
		if (timeSpan_0.TotalMilliseconds > 2147483647.0 || timeSpan_0.TotalMilliseconds < -2147483648.0)
		{
			throw new InvalidCastException(string.Format(CultureInfo.CurrentCulture, "Cannot convert {0} to integer", new object[1] { timeSpan_0 }));
		}
		return (int)timeSpan_0.TotalMilliseconds;
	}

	public static TimeSpan smethod_1(int int_0)
	{
		return TimeSpan.FromMilliseconds(int_0);
	}

	public static string smethod_2(string string_0)
	{
		int num = 0;
		while (true)
		{
			int num2 = 1;
			int num3 = 1;
			while (true)
			{
				num3 ^= 0x59;
				while (true)
				{
					int num4 = 25;
					int num5 = 3;
					while (true)
					{
						num5 ^= 0x58;
						while (true)
						{
							int num6 = 5;
							int num7 = -4;
							while (true)
							{
								num7 ^= 0x4F;
								while (true)
								{
									int num8 = GEventArgs2.smethod_1(59);
									int num9 = 31;
									while (true)
									{
										num9 ^= 0x4F;
										int num10 = Class8.smethod_0(42);
										int num11 = -29;
										num11 = -75;
										while (true)
										{
											IL_0210:
											num10 ^= 0x56;
											while (true)
											{
												num11 = Class10.smethod_0(84);
												switch (num11 ^ 0x56)
												{
												case -78:
													goto end_IL_0008;
												case -76:
													goto IL_01ff;
												case -75:
													goto IL_0210;
												case -77:
													while (true)
													{
														num11 = -27;
														num11 = -77;
													}
												}
												continue;
												end_IL_0008:
												break;
											}
											switch (num10)
											{
											case -88:
												goto IL_005b;
											case -87:
												goto IL_01f1;
											case -86:
												goto IL_01f6;
											case -85:
												goto end_IL_0210;
											}
											num11 = -30;
											num11 = -76;
											goto IL_01ff;
											IL_01c3:
											num5 = 0;
											num6 = 3;
											goto IL_01c9;
											IL_01f6:
											num9 = 0;
											num10 = -3;
											continue;
											IL_01f1:
											num10 = -1;
											continue;
											IL_005b:
											switch (num9)
											{
											case 79:
												goto IL_007e;
											case 80:
												goto IL_01e8;
											case 78:
												goto IL_021c;
											case 77:
												goto end_IL_0224;
											}
											num10 = -4;
											continue;
											IL_021c:
											num9 = 1;
											break;
											IL_007e:
											switch (num8)
											{
											case -81:
												break;
											case -80:
												goto IL_01d0;
											case -79:
												goto IL_01df;
											default:
												goto IL_0221;
											case -78:
												goto end_IL_023e;
											}
											switch (num7)
											{
											case -78:
												goto IL_00bf;
											case -77:
												goto IL_01c9;
											case -79:
												goto IL_024d;
											case -80:
												goto end_IL_0256;
											}
											num8 = -1;
											goto IL_01e8;
											IL_0221:
											num9 = 2;
											break;
											IL_01df:
											num8 = Class8.smethod_0(42);
											goto IL_01e8;
											IL_01d0:
											num7 = Class8.smethod_0(41);
											num8 = -3;
											goto IL_01e8;
											IL_024d:
											num7 = -2;
											goto end_IL_023e;
											IL_00bf:
											switch (num6)
											{
											case 82:
												break;
											case 83:
												goto IL_00e6;
											case 84:
												goto IL_01c3;
											default:
												goto IL_0253;
											case 85:
												goto end_IL_025f;
											}
											num6 = 4;
											goto IL_01c9;
											IL_0253:
											num7 = -1;
											goto end_IL_023e;
											IL_00e6:
											switch (num5)
											{
											case 88:
												goto IL_0108;
											case 91:
												goto IL_01be;
											case 90:
												goto IL_026d;
											case 89:
												goto end_IL_0270;
											}
											num6 = 2;
											goto IL_01c9;
											IL_026d:
											num5 = 2;
											goto end_IL_025f;
											IL_0108:
											switch (num4)
											{
											case 84:
												break;
											case 83:
												goto IL_01b3;
											case 85:
												goto IL_01bb;
											default:
												goto IL_0268;
											case 86:
												goto end_IL_0279;
											}
											switch (num3)
											{
											case 85:
												goto IL_0144;
											case 88:
												goto IL_01ae;
											case 87:
												goto IL_0286;
											case 86:
												goto end_IL_0289;
											}
											num4 = 30;
											goto IL_01be;
											IL_0268:
											num5 = 1;
											goto end_IL_025f;
											IL_01bb:
											num4 = 24;
											goto IL_01be;
											IL_01c9:
											num6 ^= 0x56;
											goto IL_01d0;
											IL_0286:
											num3 = 14;
											goto end_IL_0279;
											IL_0144:
											switch (num2)
											{
											case 85:
												break;
											case 86:
												if (num != 0)
												{
													goto IL_016d;
												}
												goto IL_018d;
											case 87:
												goto IL_0172;
											case 89:
												num++;
												goto IL_01a6;
											case 88:
												if (string_0[num] != '"')
												{
													goto IL_01a6;
												}
												goto IL_01ac;
											default:
												goto IL_0281;
												IL_018d:
												if (num >= string_0.Length)
												{
													return string_0;
												}
												goto case 88;
												IL_01a6:
												num++;
												goto IL_018d;
											}
											num2 = 2;
											goto IL_01ae;
											IL_0281:
											num3 = 15;
											goto end_IL_0279;
											IL_0172:
											string_0 = string_0.Insert(num, "\"");
											num2 = 14;
											goto IL_01ae;
											IL_016d:
											num2 = 15;
											goto IL_01ae;
											IL_01ac:
											num2 = 0;
											goto IL_01ae;
											IL_01ff:
											num10 = Class8.smethod_0(42);
											num11 = -29;
											num11 = -75;
											continue;
											IL_01ae:
											num2 ^= 0x57;
											goto IL_01b3;
											IL_01b3:
											num3 = 12;
											num4 = 27;
											goto IL_01be;
											IL_01e8:
											num8 ^= 0x4F;
											goto IL_01f6;
											IL_01be:
											num4 ^= 0x4D;
											goto IL_01c3;
											continue;
											end_IL_0210:
											break;
										}
										continue;
										end_IL_0224:
										break;
									}
									continue;
									end_IL_023e:
									break;
								}
								continue;
								end_IL_0256:
								break;
							}
							continue;
							end_IL_025f:
							break;
						}
						continue;
						end_IL_0270:
						break;
					}
					continue;
					end_IL_0279:
					break;
				}
				continue;
				end_IL_0289:
				break;
			}
		}
	}

	public static void smethod_3(ref string string_0, Dictionary<string, string> dictionary_0, string string_1)
	{
		if (dictionary_0.Count <= 0)
		{
			return;
		}
		if (!string.IsNullOrEmpty(string_0) && 0 == 0)
		{
			string_0 += " ";
		}
		string_0 += string_1;
		using Dictionary<string, string>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext() ? true : false)
		{
			KeyValuePair<string, string> current = enumerator.Current;
			string_0 += string.Format(CultureInfo.InvariantCulture, " {0}=\"{1}\"", new object[2]
			{
				current.Key,
				Delegate74.smethod_0(current.Value)
			});
		}
	}
}
