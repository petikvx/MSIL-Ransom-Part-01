using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Traffic_Simulation;

internal static class TrafficPlan
{
	private delegate bool check_del(int idCar, Simulation sim);

	public static List<CarInfo> trafficList = new List<CarInfo>();

	public static readonly Brush red;

	public static readonly Brush green;

	public static bool CanEntryInRoad(int idCar, WhereIsNow where)
	{
		CarInfo current = default(CarInfo);
		bool result = default(bool);
		while (true)
		{
			int num = -718451378;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEE4F3242u) % 3u)
				{
				case 2u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					using (List<CarInfo>.Enumerator enumerator = trafficList.GetEnumerator())
					{
						while (true)
						{
							IL_00ef:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -1001865165;
								num4 = -1001865165;
							}
							else
							{
								num3 = -2074975639;
								num4 = -2074975639;
							}
							while (true)
							{
								int num5;
								switch ((num2 = (uint)num3 ^ 0xEE4F3242u) % 8u)
								{
								case 7u:
									num3 = -483323930;
									continue;
								case 6u:
									num3 = (int)((num2 * 1848441988) ^ 0x565E16EF);
									continue;
								case 3u:
									current = enumerator.Current;
									if (current.countMove == 0)
									{
										num3 = -814494792;
										continue;
									}
									goto IL_0085;
								case 2u:
									if (where == current.iAmHere)
									{
										num3 = -1508375892;
										num5 = -1508375892;
										continue;
									}
									goto IL_0085;
								case 0u:
									num3 = -2074975639;
									continue;
								default:
									goto end_IL_00ae;
								case 4u:
									break;
								case 1u:
									goto end_IL_00ae;
								case 5u:
									{
										result = false;
										return result;
									}
									IL_0085:
									num3 = -481180187;
									num5 = -481180187;
									continue;
								}
								goto IL_00ef;
								continue;
								end_IL_00ae:
								break;
							}
							break;
						}
					}
					trafficList[idCar].countMove = 0;
					while (true)
					{
						int num6 = -2118572057;
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0xEE4F3242u) % 5u)
							{
							case 4u:
								num6 = (int)((num2 * 2034829774) ^ 0x76E0E822);
								continue;
							case 3u:
								num6 = ((int)num2 * -1225011276) ^ -1740383775;
								continue;
							case 2u:
								result = true;
								num6 = (int)((num2 * 1808913855) ^ 0x63AFB1CA);
								continue;
							case 0u:
								break;
							default:
								return result;
							}
							break;
						}
					}
				}
				}
				break;
				IL_0003:
				num = ((int)num2 * -1171486945) ^ 0x6D5F2DBA;
			}
		}
	}

	public static bool CanEntryInTheCheckPoint(int idCar, Simulation sim)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1582443616;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3152E01Au) % 4u)
				{
				case 2u:
					result = (bool)TrafficPlan.smethod_1(TrafficPlan.smethod_0((DispatcherObject)(object)sim), (Delegate)new check_del(checkLight), new object[2] { idCar, sim });
					num = ((int)num2 * -1992553811) ^ 0x7E37DA6D;
					continue;
				case 1u:
					num = (int)((num2 * 978696945) ^ 0x1378A433);
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static bool CanMoveCar(int idCar, WhereIsNow where)
	{
		CarInfo current = default(CarInfo);
		bool result = default(bool);
		while (true)
		{
			int num = -2022800782;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99008189u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
				{
					using (List<CarInfo>.Enumerator enumerator = trafficList.GetEnumerator())
					{
						while (true)
						{
							IL_0132:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -1408412182;
								num4 = -1408412182;
							}
							else
							{
								num3 = -1695162078;
								num4 = -1695162078;
							}
							while (true)
							{
								int num5;
								switch ((num2 = (uint)num3 ^ 0x99008189u) % 10u)
								{
								case 9u:
									num3 = -1408412182;
									continue;
								case 8u:
									if (current.iAmHere == where)
									{
										num3 = ((int)num2 * -2075644673) ^ -32360049;
										continue;
									}
									goto IL_007d;
								case 7u:
									current = enumerator.Current;
									num3 = -1347392869;
									continue;
								case 6u:
									if (trafficList[idCar].countMove == current.countMove - 1)
									{
										num3 = -665766701;
										num5 = -665766701;
										continue;
									}
									goto IL_007d;
								case 3u:
									result = false;
									num3 = (int)(num2 * 1700030495) ^ -1137505052;
									continue;
								case 2u:
									num3 = (int)(num2 * 2026429370) ^ -1356182654;
									continue;
								case 1u:
									num3 = -1168674169;
									continue;
								default:
									goto end_IL_00e8;
								case 4u:
									break;
								case 5u:
									goto end_IL_00e8;
								case 0u:
									{
										return result;
									}
									IL_007d:
									num3 = -1704391722;
									num5 = -1704391722;
									continue;
								}
								goto IL_0132;
								continue;
								end_IL_00e8:
								break;
							}
							break;
						}
					}
					return true;
				}
				}
				break;
				IL_0003:
				num = ((int)num2 * -1685823246) ^ -514564825;
			}
		}
	}

	private static bool checkLight(int idCar, Simulation sim)
	{
		WhereIsNow iAmHere = trafficList[idCar].iAmHere;
		WhereIsNow whereIsNow = iAmHere;
		bool result = default(bool);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		bool flag15 = default(bool);
		bool flag16 = default(bool);
		bool flag14 = default(bool);
		bool flag5 = default(bool);
		bool flag13 = default(bool);
		bool flag12 = default(bool);
		bool flag11 = default(bool);
		bool flag10 = default(bool);
		bool flag9 = default(bool);
		bool flag8 = default(bool);
		bool flag7 = default(bool);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 1183309452;
			while (true)
			{
				uint num2;
				int num9;
				int num18;
				int num21;
				int num24;
				int num28;
				int num33;
				int num36;
				int num39;
				switch ((num2 = (uint)num ^ 0x629CAAA2u) % 125u)
				{
				case 124u:
					result = false;
					num = 1643886944;
					continue;
				case 123u:
					num = ((int)num2 * -280857121) ^ -1000556801;
					continue;
				case 122u:
				{
					int num25;
					if (TrafficPlan.smethod_2((Shape)(object)sim.light17) != green)
					{
						num = 1203368756;
						num25 = 1203368756;
					}
					else
					{
						num = 1971234630;
						num25 = 1971234630;
					}
					continue;
				}
				case 121u:
					result = false;
					num = 197807908;
					continue;
				case 120u:
					num = (int)(num2 * 1415356643) ^ -68394452;
					continue;
				case 119u:
					result = true;
					num = ((int)num2 * -842965903) ^ -912761805;
					continue;
				case 118u:
					result = false;
					num = 95874994;
					continue;
				case 117u:
					goto IL_00a7;
				case 116u:
					num = ((int)num2 * -1953376964) ^ 0x3CEAB12D;
					continue;
				case 115u:
					switch (whereIsNow)
					{
					case WhereIsNow.Rondo_3_Inside_Left_exit:
						break;
					case WhereIsNow.Rondo_2_East_Exit:
						goto IL_00a7;
					default:
						goto IL_0172;
					case WhereIsNow.Aleje_East_Entry_Rondo:
						goto IL_0185;
					case WhereIsNow.Aleje_East_Exit_1:
						goto IL_01b5;
					case WhereIsNow.Aleje_East_Right_Bitwy:
						goto IL_01e5;
					case WhereIsNow.Aleje_West_Entry_2:
						goto IL_0203;
					case WhereIsNow.Aleje_West_Entry_Bitwy:
						goto IL_0221;
					case WhereIsNow.Aleje_West_Exit_1:
						goto IL_0251;
					case WhereIsNow.Bitwy_North_Entry_2:
						goto IL_026f;
					case WhereIsNow.Bitwy_North_Entry_Left_Rondo:
						goto IL_028d;
					case WhereIsNow.Bitwy_North_Exit_1:
						goto IL_02ab;
					case WhereIsNow.Bitwy_North_Right_Aleje:
						goto IL_02c9;
					case WhereIsNow.Bitwy_South_Entry_2:
						goto IL_02e7;
					case WhereIsNow.Bitwy_South_Exit_1:
						goto IL_0305;
					case WhereIsNow.Bitwy_South_Right_Aleje:
						goto IL_0335;
					case WhereIsNow.Rondo_1_East_Entry_Rondo_2:
						goto IL_0365;
					case WhereIsNow.Rondo_1_North_Entry_Rondo_2:
						goto IL_0383;
					case WhereIsNow.Rondo_1_South_Inside_Rondo_2_Inside:
						goto IL_03b3;
					case WhereIsNow.Aleje_East_Exit_2:
					case WhereIsNow.Aleje_Entry_Left_Bitwy:
					case WhereIsNow.Aleje_West_Entry_1:
					case WhereIsNow.Aleje_West_Exit_2:
					case WhereIsNow.Bitwy_North_Entry_1:
					case WhereIsNow.Bitwy_North_Exit_2:
					case WhereIsNow.Bitwy_North_Left_Exit:
					case WhereIsNow.Bitwy_South_Entry_1:
					case WhereIsNow.Bitwy_South_Exit_2:
					case WhereIsNow.Rondo_1_Inside_Left_Entry_Rondo_2:
					case WhereIsNow.Rondo_1_South_Entry_Rondo_2:
					case WhereIsNow.Rondo_1_West_Entry_Rondo_2:
						goto IL_03d1;
					case WhereIsNow.Rondo_2_Inside_Left_Entry_Rondo_3:
						goto IL_03dd;
					case WhereIsNow.Rondo_2_North_Entry_Rondo_3:
						goto IL_03fb;
					case WhereIsNow.Rondo_2_South_Exit:
						goto IL_0419;
					case WhereIsNow.Rondo_2_South_Inside_Exit:
						goto IL_0437;
					case WhereIsNow.Rondo_2_West_Exit:
						goto IL_0467;
					case WhereIsNow.Rondo_3_North_Exit:
						goto IL_0485;
					case WhereIsNow.Rondo_East_Inside:
						goto IL_04a3;
					}
					goto case 122u;
				case 28u:
					goto IL_0185;
				case 36u:
					goto IL_01b5;
				case 86u:
					goto IL_01e5;
				case 111u:
					goto IL_0203;
				case 73u:
					goto IL_0221;
				case 53u:
					goto IL_0251;
				case 0u:
					goto IL_026f;
				case 102u:
					goto IL_028d;
				case 15u:
					goto IL_02ab;
				case 64u:
					goto IL_02c9;
				case 51u:
					goto IL_02e7;
				case 33u:
					goto IL_0305;
				case 13u:
					goto IL_0335;
				case 84u:
					goto IL_0365;
				case 85u:
					goto IL_0383;
				case 103u:
					goto IL_03b3;
				case 52u:
					goto IL_03d1;
				case 10u:
					goto IL_03dd;
				case 62u:
					goto IL_03fb;
				case 50u:
					goto IL_0419;
				case 69u:
					goto IL_0437;
				case 9u:
					goto IL_0467;
				case 67u:
					goto IL_0485;
				case 44u:
					goto IL_04a3;
				case 114u:
					num = (int)(num2 * 1443180512) ^ -2067323327;
					continue;
				case 113u:
					result = false;
					num = 831203617;
					continue;
				case 112u:
					result = true;
					num = (int)((num2 * 1258673280) ^ 0x4CB571DD);
					continue;
				case 110u:
				{
					int num12;
					int num13;
					if (!flag6)
					{
						num12 = 431680625;
						num13 = 431680625;
					}
					else
					{
						num12 = 517888827;
						num13 = 517888827;
					}
					num = num12 ^ (int)(num2 * 962335834);
					continue;
				}
				case 109u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -1925626480;
						num6 = -1925626480;
					}
					else
					{
						num5 = -1033074486;
						num6 = -1033074486;
					}
					num = num5 ^ (int)(num2 * 32805441);
					continue;
				}
				case 108u:
					result = false;
					num = 831203617;
					continue;
				case 107u:
					num = (int)(num2 * 1940341770) ^ -1236345239;
					continue;
				case 106u:
					result = true;
					num = (int)((num2 * 1312937211) ^ 0x4C57C74A);
					continue;
				case 105u:
				{
					int num42;
					int num43;
					if (!flag15)
					{
						num42 = 441482779;
						num43 = 441482779;
					}
					else
					{
						num42 = 244734844;
						num43 = 244734844;
					}
					num = num42 ^ ((int)num2 * -1125727790);
					continue;
				}
				case 104u:
				{
					int num40;
					int num41;
					if (!flag16)
					{
						num40 = 624840279;
						num41 = 624840279;
					}
					else
					{
						num40 = 1094175438;
						num41 = 1094175438;
					}
					num = num40 ^ (int)(num2 * 1815434949);
					continue;
				}
				case 101u:
					num = (int)((num2 * 919875805) ^ 0x314C5021);
					continue;
				case 100u:
					result = true;
					num = ((int)num2 * -740298162) ^ -959100709;
					continue;
				case 99u:
				{
					int num37;
					int num38;
					if (flag14)
					{
						num37 = -1346336513;
						num38 = -1346336513;
					}
					else
					{
						num37 = -231785532;
						num38 = -231785532;
					}
					num = num37 ^ (int)(num2 * 1532737167);
					continue;
				}
				case 98u:
					result = true;
					num = ((int)num2 * -105452782) ^ 0x52DA5F7B;
					continue;
				case 97u:
					result = true;
					num = (int)((num2 * 937625956) ^ 0x44123201);
					continue;
				case 96u:
				{
					int num34;
					int num35;
					if (flag5)
					{
						num34 = -569990216;
						num35 = -569990216;
					}
					else
					{
						num34 = -1333214554;
						num35 = -1333214554;
					}
					num = num34 ^ ((int)num2 * -1534253221);
					continue;
				}
				case 95u:
					num = (int)(num2 * 1269285889) ^ -1749929251;
					continue;
				case 94u:
					result = true;
					num = (int)((num2 * 765043486) ^ 0x74221E7E);
					continue;
				case 93u:
				{
					int num31;
					int num32;
					if (flag13)
					{
						num31 = -1499254983;
						num32 = -1499254983;
					}
					else
					{
						num31 = -529997433;
						num32 = -529997433;
					}
					num = num31 ^ (int)(num2 * 312187859);
					continue;
				}
				case 91u:
					result = true;
					num = (int)((num2 * 863667646) ^ 0x2D5FE8BD);
					continue;
				case 90u:
					result = false;
					num = 17661350;
					continue;
				case 89u:
					num = (int)(num2 * 188892185) ^ -1571338106;
					continue;
				case 88u:
					result = true;
					num = ((int)num2 * -1104666807) ^ -185554864;
					continue;
				case 87u:
				{
					int num29;
					int num30;
					if (!flag12)
					{
						num29 = 324109860;
						num30 = 324109860;
					}
					else
					{
						num29 = 480107586;
						num30 = 480107586;
					}
					num = num29 ^ ((int)num2 * -1751555779);
					continue;
				}
				case 83u:
					num = (int)((num2 * 265073531) ^ 0x341FC09D);
					continue;
				case 82u:
					result = true;
					num = (int)((num2 * 402561532) ^ 0x51618C9E);
					continue;
				case 81u:
					result = false;
					num = 831203617;
					continue;
				case 80u:
					result = false;
					num = 1739597120;
					continue;
				case 79u:
					result = false;
					num = 831203617;
					continue;
				case 78u:
				{
					int num26;
					int num27;
					if (!flag11)
					{
						num26 = 1120034171;
						num27 = 1120034171;
					}
					else
					{
						num26 = 1052578999;
						num27 = 1052578999;
					}
					num = num26 ^ ((int)num2 * -1005073352);
					continue;
				}
				case 77u:
					num = (int)((num2 * 1678823818) ^ 0x23392A59);
					continue;
				case 76u:
				{
					int num22;
					int num23;
					if (flag10)
					{
						num22 = -457502362;
						num23 = -457502362;
					}
					else
					{
						num22 = -1753134663;
						num23 = -1753134663;
					}
					num = num22 ^ (int)(num2 * 376650529);
					continue;
				}
				case 75u:
					result = false;
					num = 1471976879;
					continue;
				case 74u:
					num = ((int)num2 * -805107880) ^ 0x4240D3A9;
					continue;
				case 72u:
					result = false;
					num = 831203617;
					continue;
				case 71u:
					num = ((int)num2 * -577977522) ^ 0x7576F551;
					continue;
				case 70u:
					result = false;
					num = 831203617;
					continue;
				case 68u:
					result = false;
					num = 695041517;
					continue;
				case 66u:
					num = (int)((num2 * 234288679) ^ 0x4388DBAD);
					continue;
				case 65u:
					num = ((int)num2 * -452157342) ^ 0x47935901;
					continue;
				case 63u:
					result = true;
					num = ((int)num2 * -1851116015) ^ 0x4EA6DDAD;
					continue;
				case 61u:
					result = true;
					num = (int)(num2 * 68805359) ^ -329807570;
					continue;
				case 60u:
					result = false;
					num = 831203617;
					continue;
				case 59u:
				{
					int num19;
					int num20;
					if (!flag9)
					{
						num19 = -1387923106;
						num20 = -1387923106;
					}
					else
					{
						num19 = -1316550895;
						num20 = -1316550895;
					}
					num = num19 ^ ((int)num2 * -1813015871);
					continue;
				}
				case 58u:
					result = false;
					num = 831203617;
					continue;
				case 57u:
					num = (int)(num2 * 321300886) ^ -1328152593;
					continue;
				case 56u:
					result = false;
					num = 2115519911;
					continue;
				case 55u:
					result = true;
					num = ((int)num2 * -221421443) ^ -494551304;
					continue;
				case 54u:
					num = ((int)num2 * -2120897584) ^ 0xB9EC151;
					continue;
				case 49u:
					num = ((int)num2 * -1113088735) ^ 0x500BFF7C;
					continue;
				case 47u:
					num = (int)(num2 * 1525764200) ^ -1114815487;
					continue;
				case 46u:
					result = true;
					num = (int)(num2 * 523435495) ^ -2130128787;
					continue;
				case 45u:
					num = (int)((num2 * 343941642) ^ 0xBFEE0EF);
					continue;
				case 43u:
					num = ((int)num2 * -1817559171) ^ 0x757C1F07;
					continue;
				case 42u:
					result = true;
					num = (int)(num2 * 329955594) ^ -78038474;
					continue;
				case 41u:
					result = true;
					num = (int)((num2 * 295445955) ^ 0x5FE0F982);
					continue;
				case 40u:
					result = false;
					num = 831203617;
					continue;
				case 39u:
					num = ((int)num2 * -727965232) ^ -1911609727;
					continue;
				case 38u:
					result = false;
					num = 1769772078;
					continue;
				case 37u:
					result = true;
					num = (int)(num2 * 303639467) ^ -332371236;
					continue;
				case 35u:
					result = true;
					num = ((int)num2 * -966859567) ^ 0x742F4E05;
					continue;
				case 34u:
					num = ((int)num2 * -1387174628) ^ -889204343;
					continue;
				case 32u:
					result = false;
					num = 1811386332;
					continue;
				case 31u:
					result = true;
					num = ((int)num2 * -1507991697) ^ 0x521F1B69;
					continue;
				case 30u:
				{
					int num16;
					int num17;
					if (flag8)
					{
						num16 = -478211645;
						num17 = -478211645;
					}
					else
					{
						num16 = -225712998;
						num17 = -225712998;
					}
					num = num16 ^ (int)(num2 * 1472863740);
					continue;
				}
				case 29u:
					result = true;
					num = ((int)num2 * -1895564161) ^ 0x6C1EE075;
					continue;
				case 27u:
					num = (int)(num2 * 1774568496) ^ -303430013;
					continue;
				case 26u:
					num = (int)((num2 * 779961846) ^ 0x567317);
					continue;
				case 25u:
					num = (int)((num2 * 2026124307) ^ 0x64CA6FC4);
					continue;
				case 24u:
				{
					int num14;
					int num15;
					if (flag7)
					{
						num14 = -1433513606;
						num15 = -1433513606;
					}
					else
					{
						num14 = -910006679;
						num15 = -910006679;
					}
					num = num14 ^ ((int)num2 * -432560062);
					continue;
				}
				case 23u:
					num = ((int)num2 * -1518306973) ^ -1215552595;
					continue;
				case 22u:
					result = false;
					num = 831203617;
					continue;
				case 21u:
					result = true;
					num = ((int)num2 * -1090213350) ^ 0x4FDE4D6C;
					continue;
				case 20u:
				{
					int num10;
					int num11;
					if (flag4)
					{
						num10 = 495502190;
						num11 = 495502190;
					}
					else
					{
						num10 = 1069521097;
						num11 = 1069521097;
					}
					num = num10 ^ (int)(num2 * 100818732);
					continue;
				}
				case 19u:
					num = (int)((num2 * 1823917342) ^ 0x6C7773E5);
					continue;
				case 18u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = -1253751157;
						num8 = -1253751157;
					}
					else
					{
						num7 = -991154597;
						num8 = -991154597;
					}
					num = num7 ^ ((int)num2 * -574759592);
					continue;
				}
				case 17u:
					result = false;
					num = 616764982;
					continue;
				case 16u:
					result = false;
					num = 831203617;
					continue;
				case 14u:
					result = false;
					num = 831203617;
					continue;
				case 12u:
					result = true;
					num = ((int)num2 * -1647203813) ^ 0x19577932;
					continue;
				case 11u:
					num = (int)(num2 * 498100893) ^ -308138046;
					continue;
				case 8u:
					result = false;
					num = 537257890;
					continue;
				case 7u:
					result = true;
					num = (int)(num2 * 1722628006) ^ -1795787943;
					continue;
				case 6u:
					num = ((int)num2 * -783941522) ^ 0x480B6361;
					continue;
				case 5u:
					result = true;
					num = ((int)num2 * -560318217) ^ -758584362;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1409939823;
						num4 = -1409939823;
					}
					else
					{
						num3 = -722791520;
						num4 = -722791520;
					}
					num = num3 ^ ((int)num2 * -475447230);
					continue;
				}
				case 3u:
					result = true;
					num = (int)(num2 * 2012112677) ^ -1607371925;
					continue;
				case 2u:
					result = false;
					num = 895917855;
					continue;
				case 1u:
					num = (int)(num2 * 213564044) ^ -2048952423;
					continue;
				case 92u:
					break;
				default:
					{
						return result;
					}
					IL_0251:
					flag2 = TrafficPlan.smethod_2((Shape)(object)sim.light24) == green;
					num = 964967650;
					continue;
					IL_0221:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light6) != green)
					{
						num = 412342598;
						num9 = 412342598;
					}
					else
					{
						num = 1961592400;
						num9 = 1961592400;
					}
					continue;
					IL_0203:
					flag3 = TrafficPlan.smethod_2((Shape)(object)sim.light7) == green;
					num = 1301439831;
					continue;
					IL_01e5:
					flag5 = TrafficPlan.smethod_2((Shape)(object)sim.light8) == green;
					num = 1313941331;
					continue;
					IL_04a3:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light14) != green)
					{
						num = 1864233956;
						num18 = 1864233956;
					}
					else
					{
						num = 717550418;
						num18 = 717550418;
					}
					continue;
					IL_0485:
					flag4 = TrafficPlan.smethod_2((Shape)(object)sim.light11) == green;
					num = 1662897298;
					continue;
					IL_01b5:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light1) == green)
					{
						num = 1831846324;
						num21 = 1831846324;
					}
					else
					{
						num = 1572447954;
						num21 = 1572447954;
					}
					continue;
					IL_0437:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light21) != green)
					{
						num = 763358402;
						num24 = 763358402;
					}
					else
					{
						num = 383958096;
						num24 = 383958096;
					}
					continue;
					IL_0467:
					flag = TrafficPlan.smethod_2((Shape)(object)sim.light5) == green;
					num = 710014515;
					continue;
					IL_0419:
					flag12 = TrafficPlan.smethod_2((Shape)(object)sim.light4) == green;
					num = 1351721655;
					continue;
					IL_03fb:
					flag13 = TrafficPlan.smethod_2((Shape)(object)sim.light20) == green;
					num = 627181615;
					continue;
					IL_0185:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light9) != green)
					{
						num = 317981604;
						num28 = 317981604;
					}
					else
					{
						num = 1639870198;
						num28 = 1639870198;
					}
					continue;
					IL_03d1:
					result = true;
					num = 808658326;
					continue;
					IL_03b3:
					flag10 = TrafficPlan.smethod_2((Shape)(object)sim.light15) == green;
					num = 646963104;
					continue;
					IL_03dd:
					flag9 = TrafficPlan.smethod_2((Shape)(object)sim.light16) == green;
					num = 2102966758;
					continue;
					IL_0383:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light19) == green)
					{
						num = 1322219798;
						num33 = 1322219798;
					}
					else
					{
						num = 528220365;
						num33 = 528220365;
					}
					continue;
					IL_0335:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light2) != green)
					{
						num = 359452281;
						num36 = 359452281;
					}
					else
					{
						num = 1665240465;
						num36 = 1665240465;
					}
					continue;
					IL_0172:
					num = (int)((num2 * 563554053) ^ 0x2909F695);
					continue;
					IL_0365:
					flag14 = TrafficPlan.smethod_2((Shape)(object)sim.light22) == green;
					num = 2033359084;
					continue;
					IL_0305:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light25) == green)
					{
						num = 722809091;
						num39 = 722809091;
					}
					else
					{
						num = 2130703725;
						num39 = 2130703725;
					}
					continue;
					IL_00a7:
					flag15 = TrafficPlan.smethod_2((Shape)(object)sim.light10) == green;
					num = 409079889;
					continue;
					IL_02e7:
					flag7 = TrafficPlan.smethod_2((Shape)(object)sim.light4) == green;
					num = 1678849380;
					continue;
					IL_02c9:
					flag11 = TrafficPlan.smethod_2((Shape)(object)sim.light13) == green;
					num = 7063127;
					continue;
					IL_028d:
					flag16 = TrafficPlan.smethod_2((Shape)(object)sim.light12) == green;
					num = 1898308227;
					continue;
					IL_026f:
					flag6 = TrafficPlan.smethod_2((Shape)(object)sim.light18) == green;
					num = 2020638804;
					continue;
					IL_02ab:
					flag8 = TrafficPlan.smethod_2((Shape)(object)sim.light23) == green;
					num = 1228943036;
					continue;
				}
				break;
			}
		}
	}

	static TrafficPlan()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		while (true)
		{
			int num = 2085445640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x39C42AE3u) % 3u)
				{
				case 2u:
					goto IL_000c;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000c:
				red = (Brush)TrafficPlan.smethod_4((TypeConverter)(object)TrafficPlan.smethod_3(), (object)"Red");
				green = (Brush)TrafficPlan.smethod_4((TypeConverter)(object)TrafficPlan.smethod_3(), (object)"Green");
				num = (int)((num2 * 1691503996) ^ 0xF8D9C0A);
			}
		}
	}

	static Dispatcher smethod_0(DispatcherObject dispatcherObject_0)
	{
		return dispatcherObject_0.get_Dispatcher();
	}

	static object smethod_1(Dispatcher dispatcher_0, Delegate delegate_0, object[] object_0)
	{
		return dispatcher_0.Invoke(delegate_0, object_0);
	}

	static Brush smethod_2(Shape shape_0)
	{
		return shape_0.get_Fill();
	}

	static BrushConverter smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new BrushConverter();
	}

	static object smethod_4(TypeConverter typeConverter_0, object object_0)
	{
		return typeConverter_0.ConvertFrom(object_0);
	}
}
