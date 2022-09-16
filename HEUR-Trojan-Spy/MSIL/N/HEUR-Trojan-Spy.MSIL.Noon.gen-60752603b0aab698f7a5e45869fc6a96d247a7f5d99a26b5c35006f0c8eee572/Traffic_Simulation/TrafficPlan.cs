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
		List<CarInfo>.Enumerator enumerator = trafficList.GetEnumerator();
		bool result = default(bool);
		try
		{
			bool flag = default(bool);
			CarInfo current = default(CarInfo);
			while (true)
			{
				IL_00e6:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1184739922;
					num2 = -1184739922;
				}
				else
				{
					num = -1034189299;
					num2 = -1034189299;
				}
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num ^ 0xD3A1A823u) % 10u)
					{
					case 9u:
						num = -865504124;
						continue;
					case 8u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = -1429151258;
							num6 = -1429151258;
						}
						else
						{
							num5 = -1813233112;
							num6 = -1813233112;
						}
						num = num5 ^ (int)(num3 * 1599785580);
						continue;
					}
					case 7u:
						num = ((int)num3 * -984329229) ^ 0x5812BF3A;
						continue;
					case 6u:
						result = false;
						num = ((int)num3 * -1480393202) ^ 0x5245CBB9;
						continue;
					case 5u:
						num4 = ((where == current.iAmHere) ? 1 : 0);
						goto IL_0075;
					case 1u:
						current = enumerator.Current;
						if (current.countMove == 0)
						{
							num = -721523336;
							continue;
						}
						num4 = 0;
						goto IL_0075;
					case 0u:
						num = -1184739922;
						continue;
					default:
						goto end_IL_009c;
					case 3u:
						break;
					case 4u:
						goto end_IL_009c;
					case 2u:
						{
							return result;
						}
						IL_0075:
						flag = (byte)num4 != 0;
						num = -1838561167;
						continue;
					}
					goto IL_00e6;
					continue;
					end_IL_009c:
					break;
				}
				break;
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
			while (true)
			{
				IL_0136:
				int num7 = -321046517;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num7 ^ 0xD3A1A823u) % 3u)
					{
					case 2u:
						goto IL_010a;
					default:
						goto end_IL_0118;
					case 0u:
						break;
					case 1u:
						goto end_IL_0118;
					}
					goto IL_0136;
					IL_010a:
					num7 = ((int)num3 * -1006160288) ^ 0x1B5064F4;
					continue;
					end_IL_0118:
					break;
				}
				break;
			}
		}
		trafficList[idCar].countMove = 0;
		while (true)
		{
			int num8 = -2110886379;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num8 ^ 0xD3A1A823u) % 5u)
				{
				case 3u:
					result = true;
					num8 = ((int)num3 * -167616675) ^ -485036453;
					continue;
				case 2u:
					num8 = ((int)num3 * -859489610) ^ -718056624;
					continue;
				case 1u:
					num8 = (int)((num3 * 1510861674) ^ 0x205EDA95);
					continue;
				case 4u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static bool CanEntryInTheCheckPoint(int idCar, Simulation sim)
	{
		bool result = (bool)TrafficPlan.smethod_1(TrafficPlan.smethod_0((DispatcherObject)(object)sim), (Delegate)new check_del(checkLight), new object[2] { idCar, sim });
		while (true)
		{
			int num = -721542724;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD60635C3u) % 3u)
				{
				case 1u:
					goto IL_0032;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0032:
				num = (int)((num2 * 1067625975) ^ 0x23245C8F);
			}
		}
	}

	public static bool CanMoveCar(int idCar, WhereIsNow where)
	{
		using (List<CarInfo>.Enumerator enumerator = trafficList.GetEnumerator())
		{
			CarInfo current = default(CarInfo);
			bool flag = default(bool);
			bool result = default(bool);
			while (true)
			{
				IL_0112:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -179553799;
					num2 = -179553799;
				}
				else
				{
					num = -1210967737;
					num2 = -1210967737;
				}
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num ^ 0xE38E30D1u) % 11u)
					{
					case 8u:
						num = -1210967737;
						continue;
					case 7u:
						num4 = ((trafficList[idCar].countMove == current.countMove - 1) ? 1 : 0);
						goto IL_0045;
					case 6u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = 1707070872;
							num6 = 1707070872;
						}
						else
						{
							num5 = 2087203201;
							num6 = 2087203201;
						}
						num = num5 ^ ((int)num3 * -882754069);
						continue;
					}
					case 5u:
						if (current.iAmHere == where)
						{
							num = ((int)num3 * -371155565) ^ -2075106522;
							continue;
						}
						num4 = 0;
						goto IL_0045;
					case 4u:
						result = false;
						num = (int)(num3 * 259277654) ^ -1540573887;
						continue;
					case 3u:
						current = enumerator.Current;
						num = -648417860;
						continue;
					case 2u:
						num = ((int)num3 * -900747864) ^ 0xD14E6EF;
						continue;
					case 0u:
						num = -1295603807;
						continue;
					default:
						goto end_IL_00c4;
					case 1u:
						break;
					case 9u:
						goto end_IL_00c4;
					case 10u:
						{
							return result;
						}
						IL_0045:
						flag = (byte)num4 != 0;
						num = -1451066146;
						continue;
					}
					goto IL_0112;
					continue;
					end_IL_00c4:
					break;
				}
				break;
			}
		}
		return true;
	}

	private static bool checkLight(int idCar, Simulation sim)
	{
		bool result = default(bool);
		bool flag4 = default(bool);
		bool flag11 = default(bool);
		bool flag7 = default(bool);
		WhereIsNow iAmHere = default(WhereIsNow);
		bool flag8 = default(bool);
		WhereIsNow whereIsNow = default(WhereIsNow);
		bool flag10 = default(bool);
		bool flag9 = default(bool);
		bool flag6 = default(bool);
		bool flag5 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 97174050;
			while (true)
			{
				uint num2;
				int num11;
				int num23;
				int num24;
				int num25;
				int num26;
				int num27;
				int num28;
				int num29;
				int num32;
				int num33;
				int num34;
				int num37;
				int num38;
				switch ((num2 = (uint)num ^ 0x315B2417u) % 124u)
				{
				case 123u:
				{
					int num20;
					if (TrafficPlan.smethod_2((Shape)(object)sim.light4) != green)
					{
						num = 2056429712;
						num20 = 2056429712;
					}
					else
					{
						num = 1769836184;
						num20 = 1769836184;
					}
					continue;
				}
				case 122u:
					num = (int)(num2 * 90006858) ^ -358365292;
					continue;
				case 121u:
					num = (int)((num2 * 1790223992) ^ 0x5EF961A0);
					continue;
				case 120u:
					goto IL_005c;
				case 119u:
					result = false;
					num = 1411701639;
					continue;
				case 118u:
					num = (int)(num2 * 1583581613) ^ -874901618;
					continue;
				case 117u:
					result = false;
					num = 867869720;
					continue;
				case 116u:
					result = true;
					num = ((int)num2 * -549902372) ^ -1571294472;
					continue;
				case 115u:
					result = true;
					num = ((int)num2 * -121875895) ^ -686595938;
					continue;
				case 114u:
					num = (int)(num2 * 65516838) ^ -1478156244;
					continue;
				case 113u:
					result = false;
					num = 857668788;
					continue;
				case 112u:
					goto IL_00ee;
				case 111u:
				{
					int num9;
					int num10;
					if (flag4)
					{
						num9 = 842104067;
						num10 = 842104067;
					}
					else
					{
						num9 = 672237389;
						num10 = 672237389;
					}
					num = num9 ^ ((int)num2 * -904743487);
					continue;
				}
				case 110u:
					num = (int)((num2 * 183754772) ^ 0x39AFFD90);
					continue;
				case 109u:
				{
					int num35;
					int num36;
					if (flag11)
					{
						num35 = 1233183603;
						num36 = 1233183603;
					}
					else
					{
						num35 = 250697323;
						num36 = 250697323;
					}
					num = num35 ^ (int)(num2 * 1756978459);
					continue;
				}
				case 108u:
					num = (int)(num2 * 1084141008) ^ -748380456;
					continue;
				case 107u:
					result = false;
					num = 2090701601;
					continue;
				case 106u:
				{
					int num30;
					int num31;
					if (!flag7)
					{
						num30 = 1489728426;
						num31 = 1489728426;
					}
					else
					{
						num30 = 1807056712;
						num31 = 1807056712;
					}
					num = num30 ^ ((int)num2 * -1557828976);
					continue;
				}
				case 105u:
					result = false;
					num = 658891215;
					continue;
				case 104u:
					num = ((int)num2 * -1627068639) ^ -1637508596;
					continue;
				case 103u:
					goto IL_01d8;
				case 102u:
					goto IL_01e4;
				case 101u:
					iAmHere = trafficList[idCar].iAmHere;
					num = (int)((num2 * 134074027) ^ 0x3F8C81A8);
					continue;
				case 100u:
					result = false;
					num = 1254333315;
					continue;
				case 99u:
					num = ((int)num2 * -760237662) ^ -1241242714;
					continue;
				case 98u:
					num = (int)((num2 * 1396400228) ^ 0x65233380);
					continue;
				case 96u:
					num = (int)((num2 * 171264476) ^ 0x1D2E39B8);
					continue;
				case 94u:
					num = ((int)num2 * -481065570) ^ -1264368324;
					continue;
				case 93u:
					num = (int)((num2 * 1526352952) ^ 0x714E81C0);
					continue;
				case 92u:
					result = true;
					num = ((int)num2 * -559154609) ^ -754061188;
					continue;
				case 91u:
					result = false;
					num = 432396201;
					continue;
				case 90u:
					result = false;
					num = 867869720;
					continue;
				case 89u:
				{
					int num16;
					int num17;
					if (!flag8)
					{
						num16 = -1104875687;
						num17 = -1104875687;
					}
					else
					{
						num16 = -1171478218;
						num17 = -1171478218;
					}
					num = num16 ^ (int)(num2 * 859746150);
					continue;
				}
				case 88u:
					num = ((int)num2 * -548002679) ^ -638462496;
					continue;
				case 87u:
					num = (int)((num2 * 1179988606) ^ 0x49911A0A);
					continue;
				case 86u:
					result = false;
					num = 867869720;
					continue;
				case 85u:
					goto IL_032b;
				case 84u:
					result = false;
					num = 993578977;
					continue;
				case 83u:
					result = false;
					num = 588211886;
					continue;
				case 82u:
					result = true;
					num = ((int)num2 * -1057375566) ^ 0x141FF04;
					continue;
				case 81u:
					result = true;
					num = (int)(num2 * 934062000) ^ -650337163;
					continue;
				case 80u:
					whereIsNow = iAmHere;
					num = ((int)num2 * -821466734) ^ -1452016124;
					continue;
				case 79u:
					result = true;
					num = (int)((num2 * 988457562) ^ 0x7B134486);
					continue;
				case 78u:
					num = (int)((num2 * 494388172) ^ 0xF4CA600);
					continue;
				case 77u:
					goto IL_03da;
				case 76u:
					result = true;
					num = (int)(num2 * 2016449269) ^ -158733228;
					continue;
				case 75u:
					goto IL_040d;
				case 74u:
					goto IL_043d;
				case 73u:
					goto IL_046d;
				case 72u:
					num = (int)((num2 * 660407129) ^ 0x4D74AE74);
					continue;
				case 71u:
					result = true;
					num = (int)((num2 * 99219576) ^ 0xB3D9C03);
					continue;
				case 70u:
					num = ((int)num2 * -1539780532) ^ 0x2E814040;
					continue;
				case 69u:
					result = true;
					num = (int)((num2 * 314155029) ^ 0x31969BF3);
					continue;
				case 68u:
					goto IL_04db;
				case 67u:
					goto IL_050b;
				case 66u:
					num = ((int)num2 * -869715353) ^ -1223335966;
					continue;
				case 65u:
					result = false;
					num = 1819629273;
					continue;
				case 64u:
					goto IL_0548;
				case 63u:
					switch (whereIsNow)
					{
					case WhereIsNow.Rondo_2_South_Exit:
						break;
					case WhereIsNow.Rondo_2_West_Exit:
						goto IL_005c;
					case WhereIsNow.Rondo_1_East_Entry_Rondo_2:
						goto IL_00ee;
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
						goto IL_01d8;
					case WhereIsNow.Bitwy_North_Entry_Left_Rondo:
						goto IL_01e4;
					case WhereIsNow.Bitwy_South_Exit_1:
						goto IL_032b;
					case WhereIsNow.Bitwy_North_Exit_1:
						goto IL_03da;
					case WhereIsNow.Bitwy_North_Right_Aleje:
						goto IL_040d;
					case WhereIsNow.Rondo_East_Inside:
						goto IL_043d;
					case WhereIsNow.Bitwy_North_Entry_2:
						goto IL_046d;
					case WhereIsNow.Bitwy_South_Entry_2:
						goto IL_04db;
					case WhereIsNow.Rondo_2_South_Inside_Exit:
						goto IL_050b;
					case WhereIsNow.Rondo_1_North_Entry_Rondo_2:
						goto IL_0548;
					default:
						goto IL_0600;
					case WhereIsNow.Aleje_East_Entry_Rondo:
						goto IL_0613;
					case WhereIsNow.Aleje_East_Exit_1:
						goto IL_0643;
					case WhereIsNow.Aleje_East_Right_Bitwy:
						goto IL_0661;
					case WhereIsNow.Aleje_West_Entry_2:
						goto IL_0691;
					case WhereIsNow.Aleje_West_Entry_Bitwy:
						goto IL_06c1;
					case WhereIsNow.Aleje_West_Exit_1:
						goto IL_06f1;
					case WhereIsNow.Bitwy_South_Right_Aleje:
						goto IL_070f;
					case WhereIsNow.Rondo_1_South_Inside_Rondo_2_Inside:
						goto IL_073f;
					case WhereIsNow.Rondo_2_East_Exit:
						goto IL_075d;
					case WhereIsNow.Rondo_2_Inside_Left_Entry_Rondo_3:
						goto IL_078d;
					case WhereIsNow.Rondo_2_North_Entry_Rondo_3:
						goto IL_07bd;
					case WhereIsNow.Rondo_3_Inside_Left_exit:
						goto IL_07db;
					case WhereIsNow.Rondo_3_North_Exit:
						goto IL_080b;
					}
					goto case 123u;
				case 13u:
					goto IL_0613;
				case 48u:
					goto IL_0643;
				case 14u:
					goto IL_0661;
				case 8u:
					goto IL_0691;
				case 47u:
					goto IL_06c1;
				case 40u:
					goto IL_06f1;
				case 54u:
					goto IL_070f;
				case 27u:
					goto IL_073f;
				case 12u:
					goto IL_075d;
				case 19u:
					goto IL_078d;
				case 52u:
					goto IL_07bd;
				case 21u:
					goto IL_07db;
				case 49u:
					goto IL_080b;
				case 62u:
					result = true;
					num = (int)((num2 * 1088077516) ^ 0x5A10BF20);
					continue;
				case 61u:
					result = true;
					num = (int)(num2 * 75909865) ^ -891470296;
					continue;
				case 60u:
				{
					int num21;
					int num22;
					if (!flag10)
					{
						num21 = 1124841718;
						num22 = 1124841718;
					}
					else
					{
						num21 = 984487473;
						num22 = 984487473;
					}
					num = num21 ^ ((int)num2 * -1458633682);
					continue;
				}
				case 59u:
					result = false;
					num = 1508858296;
					continue;
				case 58u:
					result = false;
					num = 867869720;
					continue;
				case 57u:
					result = false;
					num = 867869720;
					continue;
				case 56u:
					num = ((int)num2 * -367568685) ^ -501027740;
					continue;
				case 55u:
					result = true;
					num = (int)(num2 * 785323125) ^ -410380069;
					continue;
				case 53u:
					num = (int)(num2 * 1514022984) ^ -1219033072;
					continue;
				case 51u:
					result = true;
					num = (int)((num2 * 843047389) ^ 0x2E3DF12B);
					continue;
				case 50u:
					num = ((int)num2 * -1224702787) ^ 0x18A96F6;
					continue;
				case 46u:
					num = (int)(num2 * 1843713024) ^ -1972757480;
					continue;
				case 45u:
					result = false;
					num = 828025152;
					continue;
				case 44u:
					result = false;
					num = 997074134;
					continue;
				case 43u:
					num = ((int)num2 * -425457135) ^ -855679829;
					continue;
				case 42u:
					result = true;
					num = (int)((num2 * 2085602203) ^ 0x7D23195F);
					continue;
				case 41u:
					num = ((int)num2 * -1384619400) ^ -1934462688;
					continue;
				case 39u:
					num = ((int)num2 * -1703454784) ^ -1575405992;
					continue;
				case 38u:
					result = true;
					num = (int)(num2 * 1619970178) ^ -1707756870;
					continue;
				case 37u:
				{
					int num18;
					int num19;
					if (flag9)
					{
						num18 = 566998003;
						num19 = 566998003;
					}
					else
					{
						num18 = 1685835373;
						num19 = 1685835373;
					}
					num = num18 ^ ((int)num2 * -836990443);
					continue;
				}
				case 36u:
				{
					int num14;
					int num15;
					if (flag6)
					{
						num14 = 442422383;
						num15 = 442422383;
					}
					else
					{
						num14 = 1791547773;
						num15 = 1791547773;
					}
					num = num14 ^ (int)(num2 * 525154831);
					continue;
				}
				case 35u:
					result = true;
					num = (int)(num2 * 1376968811) ^ -2028057745;
					continue;
				case 34u:
					result = true;
					num = (int)(num2 * 1129298285) ^ -831545619;
					continue;
				case 33u:
				{
					int num12;
					int num13;
					if (flag5)
					{
						num12 = -1558944582;
						num13 = -1558944582;
					}
					else
					{
						num12 = -814710934;
						num13 = -814710934;
					}
					num = num12 ^ ((int)num2 * -1946757289);
					continue;
				}
				case 32u:
				{
					int num7;
					int num8;
					if (flag3)
					{
						num7 = 1621130376;
						num8 = 1621130376;
					}
					else
					{
						num7 = 1682019330;
						num8 = 1682019330;
					}
					num = num7 ^ (int)(num2 * 252615817);
					continue;
				}
				case 31u:
					num = ((int)num2 * -675994544) ^ -1873182424;
					continue;
				case 30u:
					result = true;
					num = (int)((num2 * 268923254) ^ 0x4AAA2284);
					continue;
				case 29u:
					result = false;
					num = 305544337;
					continue;
				case 28u:
					result = true;
					num = (int)((num2 * 605771925) ^ 0x139DF7C8);
					continue;
				case 26u:
					num = ((int)num2 * -1291191223) ^ -1587312762;
					continue;
				case 25u:
					num = ((int)num2 * -105847089) ^ 0x2E83A617;
					continue;
				case 24u:
					num = ((int)num2 * -1955716621) ^ -336887384;
					continue;
				case 23u:
					num = (int)(num2 * 1396892186) ^ -1965016266;
					continue;
				case 22u:
					result = false;
					num = 867869720;
					continue;
				case 20u:
					result = true;
					num = (int)((num2 * 357850438) ^ 0x56592555);
					continue;
				case 18u:
					result = true;
					num = (int)((num2 * 1794273892) ^ 0xA0062DC);
					continue;
				case 17u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = -527723882;
						num6 = -527723882;
					}
					else
					{
						num5 = -1504460892;
						num6 = -1504460892;
					}
					num = num5 ^ ((int)num2 * -1928946702);
					continue;
				}
				case 16u:
					result = false;
					num = 867869720;
					continue;
				case 15u:
					num = (int)(num2 * 2088399765) ^ -685970489;
					continue;
				case 11u:
					result = true;
					num = ((int)num2 * -1971943781) ^ 0x6320BA8D;
					continue;
				case 10u:
					result = false;
					num = 867869720;
					continue;
				case 9u:
					result = true;
					num = (int)((num2 * 154676516) ^ 0x715EE86C);
					continue;
				case 7u:
					result = true;
					num = ((int)num2 * -2100080664) ^ -1424665127;
					continue;
				case 6u:
					num = ((int)num2 * -1144875589) ^ -169983490;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1053609183;
						num4 = 1053609183;
					}
					else
					{
						num3 = 120920966;
						num4 = 120920966;
					}
					num = num3 ^ (int)(num2 * 589892884);
					continue;
				}
				case 4u:
					result = false;
					num = 154500793;
					continue;
				case 3u:
					result = false;
					num = 966053189;
					continue;
				case 2u:
					result = false;
					num = 867869720;
					continue;
				case 1u:
					result = false;
					num = 867869720;
					continue;
				case 0u:
					result = true;
					num = (int)((num2 * 2036189343) ^ 0x2C0DCD34);
					continue;
				case 97u:
					break;
				default:
					{
						return result;
					}
					IL_032b:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light25) != green)
					{
						num = 720768342;
						num11 = 720768342;
					}
					else
					{
						num = 1584620269;
						num11 = 1584620269;
					}
					continue;
					IL_00ee:
					flag7 = TrafficPlan.smethod_2((Shape)(object)sim.light22) == green;
					num = 1731621949;
					continue;
					IL_080b:
					flag5 = TrafficPlan.smethod_2((Shape)(object)sim.light11) == green;
					num = 1938234926;
					continue;
					IL_07db:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light17) == green)
					{
						num = 1162787187;
						num23 = 1162787187;
					}
					else
					{
						num = 498170349;
						num23 = 498170349;
					}
					continue;
					IL_07bd:
					flag11 = TrafficPlan.smethod_2((Shape)(object)sim.light20) == green;
					num = 1768590986;
					continue;
					IL_078d:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light16) != green)
					{
						num = 709503743;
						num24 = 709503743;
					}
					else
					{
						num = 431425181;
						num24 = 431425181;
					}
					continue;
					IL_075d:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light10) != green)
					{
						num = 1331504168;
						num25 = 1331504168;
					}
					else
					{
						num = 710633742;
						num25 = 710633742;
					}
					continue;
					IL_01e4:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light12) != green)
					{
						num = 620640318;
						num26 = 620640318;
					}
					else
					{
						num = 2115552375;
						num26 = 2115552375;
					}
					continue;
					IL_073f:
					flag9 = TrafficPlan.smethod_2((Shape)(object)sim.light15) == green;
					num = 401659098;
					continue;
					IL_070f:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light2) == green)
					{
						num = 1925791701;
						num27 = 1925791701;
					}
					else
					{
						num = 1679991563;
						num27 = 1679991563;
					}
					continue;
					IL_06f1:
					flag = TrafficPlan.smethod_2((Shape)(object)sim.light24) == green;
					num = 21496942;
					continue;
					IL_06c1:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light6) == green)
					{
						num = 1333741097;
						num28 = 1333741097;
					}
					else
					{
						num = 1269161797;
						num28 = 1269161797;
					}
					continue;
					IL_01d8:
					result = true;
					num = 1586850819;
					continue;
					IL_0691:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light7) != green)
					{
						num = 1801796656;
						num29 = 1801796656;
					}
					else
					{
						num = 50057896;
						num29 = 50057896;
					}
					continue;
					IL_0661:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light8) == green)
					{
						num = 183930399;
						num32 = 183930399;
					}
					else
					{
						num = 537786109;
						num32 = 537786109;
					}
					continue;
					IL_0643:
					flag2 = TrafficPlan.smethod_2((Shape)(object)sim.light1) == green;
					num = 1911089794;
					continue;
					IL_0613:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light9) != green)
					{
						num = 1324859092;
						num33 = 1324859092;
					}
					else
					{
						num = 1246870451;
						num33 = 1246870451;
					}
					continue;
					IL_0600:
					num = (int)(num2 * 1096226970) ^ -857613203;
					continue;
					IL_0548:
					flag3 = TrafficPlan.smethod_2((Shape)(object)sim.light19) == green;
					num = 1018432583;
					continue;
					IL_050b:
					flag6 = TrafficPlan.smethod_2((Shape)(object)sim.light21) == green;
					num = 814013935;
					continue;
					IL_04db:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light4) == green)
					{
						num = 1167369351;
						num34 = 1167369351;
					}
					else
					{
						num = 1539162853;
						num34 = 1539162853;
					}
					continue;
					IL_046d:
					flag4 = TrafficPlan.smethod_2((Shape)(object)sim.light18) == green;
					num = 1809645472;
					continue;
					IL_043d:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light14) == green)
					{
						num = 720627070;
						num37 = 720627070;
					}
					else
					{
						num = 1398582299;
						num37 = 1398582299;
					}
					continue;
					IL_005c:
					flag8 = TrafficPlan.smethod_2((Shape)(object)sim.light5) == green;
					num = 812480846;
					continue;
					IL_040d:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light13) == green)
					{
						num = 190136349;
						num38 = 190136349;
					}
					else
					{
						num = 1171122682;
						num38 = 1171122682;
					}
					continue;
					IL_03da:
					flag10 = TrafficPlan.smethod_2((Shape)(object)sim.light23) == green;
					num = 847224491;
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		while (true)
		{
			int num = 1114485725;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69F5D3F0u) % 4u)
				{
				case 2u:
					green = (Brush)TrafficPlan.smethod_4((TypeConverter)(object)TrafficPlan.smethod_3(), (object)"Green");
					num = ((int)num2 * -545396828) ^ -2001665088;
					continue;
				case 1u:
					red = (Brush)TrafficPlan.smethod_4((TypeConverter)(object)TrafficPlan.smethod_3(), (object)"Red");
					num = ((int)num2 * -544443349) ^ 0x537414D1;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
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
