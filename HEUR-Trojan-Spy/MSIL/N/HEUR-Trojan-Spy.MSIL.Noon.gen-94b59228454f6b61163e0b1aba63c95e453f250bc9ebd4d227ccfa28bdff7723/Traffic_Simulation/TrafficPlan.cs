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
		bool result = default(bool);
		using (List<CarInfo>.Enumerator enumerator = trafficList.GetEnumerator())
		{
			CarInfo current = default(CarInfo);
			bool flag = default(bool);
			while (true)
			{
				IL_00e6:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1908803470;
					num2 = -1908803470;
				}
				else
				{
					num = -1828102506;
					num2 = -1828102506;
				}
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num ^ 0xA195BDF7u) % 10u)
					{
					case 9u:
						num = -1616182015;
						continue;
					case 8u:
						num4 = ((where == current.iAmHere) ? 1 : 0);
						goto IL_002e;
					case 7u:
						num = -1908803470;
						continue;
					case 6u:
						result = false;
						num = ((int)num3 * -436830320) ^ -494492476;
						continue;
					case 2u:
					{
						int num5;
						int num6;
						if (!flag)
						{
							num5 = 776976220;
							num6 = 776976220;
						}
						else
						{
							num5 = 67136799;
							num6 = 67136799;
						}
						num = num5 ^ ((int)num3 * -916523981);
						continue;
					}
					case 1u:
						current = enumerator.Current;
						if (current.countMove == 0)
						{
							num = -66879983;
							continue;
						}
						num4 = 0;
						goto IL_002e;
					case 0u:
						num = ((int)num3 * -1845544393) ^ -1862184561;
						continue;
					default:
						goto end_IL_009c;
					case 4u:
						break;
					case 5u:
						goto end_IL_009c;
					case 3u:
						{
							return result;
						}
						IL_002e:
						flag = (byte)num4 != 0;
						num = -569035109;
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
		trafficList[idCar].countMove = 0;
		while (true)
		{
			int num7 = -1489778102;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num7 ^ 0xA195BDF7u) % 4u)
				{
				case 3u:
					num7 = ((int)num3 * -1827561500) ^ -1325191243;
					continue;
				case 1u:
					result = true;
					num7 = (int)(num3 * 1450387878) ^ -65403458;
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

	public static bool CanEntryInTheCheckPoint(int idCar, Simulation sim)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1587850694;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB27EA29u) % 4u)
				{
				case 3u:
					result = (bool)TrafficPlan.smethod_1(TrafficPlan.smethod_0((DispatcherObject)(object)sim), (Delegate)new check_del(checkLight), new object[2] { idCar, sim });
					num = (int)((num2 * 648151190) ^ 0x78D6395A);
					continue;
				case 1u:
					num = (int)(num2 * 259232981) ^ -343212038;
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

	public static bool CanMoveCar(int idCar, WhereIsNow where)
	{
		using (List<CarInfo>.Enumerator enumerator = trafficList.GetEnumerator())
		{
			bool result = default(bool);
			CarInfo current = default(CarInfo);
			bool flag = default(bool);
			while (true)
			{
				IL_00e7:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 14947535;
					num2 = 14947535;
				}
				else
				{
					num = 1304868719;
					num2 = 1304868719;
				}
				while (true)
				{
					uint num3;
					int num6;
					switch ((num3 = (uint)num ^ 0x6837AB2Fu) % 9u)
					{
					case 8u:
						result = false;
						num = (int)(num3 * 2052810245) ^ -199949956;
						continue;
					case 5u:
						num6 = ((trafficList[idCar].countMove == current.countMove - 1) ? 1 : 0);
						goto IL_004d;
					case 3u:
						num = 968817800;
						continue;
					case 2u:
						num = 1304868719;
						continue;
					case 1u:
						current = enumerator.Current;
						if (current.iAmHere == where)
						{
							num = 157417774;
							continue;
						}
						num6 = 0;
						goto IL_004d;
					case 0u:
					{
						int num4;
						int num5;
						if (!flag)
						{
							num4 = 232882144;
							num5 = 232882144;
						}
						else
						{
							num4 = 444985820;
							num5 = 444985820;
						}
						num = num4 ^ ((int)num3 * -1348324920);
						continue;
					}
					default:
						goto end_IL_00a1;
					case 7u:
						break;
					case 4u:
						goto end_IL_00a1;
					case 6u:
						{
							return result;
						}
						IL_004d:
						flag = (byte)num6 != 0;
						num = 894403706;
						continue;
					}
					goto IL_00e7;
					continue;
					end_IL_00a1:
					break;
				}
				break;
			}
		}
		return true;
	}

	private static bool checkLight(int idCar, Simulation sim)
	{
		bool flag7 = default(bool);
		bool flag8 = default(bool);
		bool result = default(bool);
		WhereIsNow whereIsNow = default(WhereIsNow);
		WhereIsNow iAmHere = default(WhereIsNow);
		bool flag14 = default(bool);
		bool flag11 = default(bool);
		bool flag18 = default(bool);
		bool flag19 = default(bool);
		bool flag15 = default(bool);
		bool flag9 = default(bool);
		bool flag5 = default(bool);
		bool flag17 = default(bool);
		bool flag13 = default(bool);
		bool flag16 = default(bool);
		bool flag12 = default(bool);
		bool flag10 = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 200535872;
			while (true)
			{
				uint num2;
				int num25;
				int num26;
				int num29;
				int num40;
				int num43;
				int num44;
				switch ((num2 = (uint)num ^ 0x6A68651Eu) % 134u)
				{
				case 133u:
					flag7 = TrafficPlan.smethod_2((Shape)(object)sim.light21) == green;
					num = 1049350812;
					continue;
				case 132u:
				{
					int num38;
					int num39;
					if (flag8)
					{
						num38 = -514348391;
						num39 = -514348391;
					}
					else
					{
						num38 = -556359604;
						num39 = -556359604;
					}
					num = num38 ^ ((int)num2 * -2057820630);
					continue;
				}
				case 131u:
					result = true;
					num = ((int)num2 * -115053580) ^ -1114059438;
					continue;
				case 130u:
					num = ((int)num2 * -24293082) ^ -926169748;
					continue;
				case 129u:
					num = (int)(num2 * 1129553895) ^ -1767459301;
					continue;
				case 128u:
					result = false;
					num = 302079370;
					continue;
				case 127u:
					whereIsNow = iAmHere;
					num = (int)(num2 * 486275529) ^ -1036205522;
					continue;
				case 126u:
					result = true;
					num = (int)(num2 * 664693281) ^ -1044084374;
					continue;
				case 125u:
				{
					int num41;
					int num42;
					if (flag14)
					{
						num41 = -1595623043;
						num42 = -1595623043;
					}
					else
					{
						num41 = -789739647;
						num42 = -789739647;
					}
					num = num41 ^ ((int)num2 * -596312196);
					continue;
				}
				case 124u:
					result = true;
					num = (int)((num2 * 1858946799) ^ 0x60E4705E);
					continue;
				case 123u:
					result = false;
					num = 417780596;
					continue;
				case 122u:
					num = (int)((num2 * 1740185427) ^ 0x1EDF6740);
					continue;
				case 121u:
					goto IL_011b;
				case 120u:
				{
					int num21;
					int num22;
					if (!flag11)
					{
						num21 = -1409741084;
						num22 = -1409741084;
					}
					else
					{
						num21 = -1977832340;
						num22 = -1977832340;
					}
					num = num21 ^ ((int)num2 * -702950606);
					continue;
				}
				case 119u:
					num = (int)(num2 * 1685190249) ^ -376622225;
					continue;
				case 118u:
				{
					int num45;
					int num46;
					if (flag18)
					{
						num45 = 1085968658;
						num46 = 1085968658;
					}
					else
					{
						num45 = 835738148;
						num46 = 835738148;
					}
					num = num45 ^ ((int)num2 * -1098787530);
					continue;
				}
				case 117u:
					num = (int)(num2 * 1888253489) ^ -1163135849;
					continue;
				case 116u:
					goto IL_01b1;
				case 115u:
				{
					int num36;
					int num37;
					if (flag19)
					{
						num36 = -1887152049;
						num37 = -1887152049;
					}
					else
					{
						num36 = -982518604;
						num37 = -982518604;
					}
					num = num36 ^ ((int)num2 * -958620766);
					continue;
				}
				case 114u:
				{
					int num32;
					int num33;
					if (!flag15)
					{
						num32 = 1367868447;
						num33 = 1367868447;
					}
					else
					{
						num32 = 1400888623;
						num33 = 1400888623;
					}
					num = num32 ^ (int)(num2 * 2095144499);
					continue;
				}
				case 113u:
					goto IL_0221;
				case 112u:
					goto IL_0251;
				case 111u:
					num = ((int)num2 * -1989778871) ^ 0x56FB5D21;
					continue;
				case 110u:
					goto IL_0270;
				case 109u:
					num = (int)(num2 * 834533806) ^ -506956906;
					continue;
				case 108u:
					result = true;
					num = ((int)num2 * -746670774) ^ -793030859;
					continue;
				case 107u:
					num = ((int)num2 * -229266460) ^ 0x6CDCB748;
					continue;
				case 106u:
					goto IL_02c9;
				case 105u:
				{
					int num17;
					int num18;
					if (!flag9)
					{
						num17 = 1066260123;
						num18 = 1066260123;
					}
					else
					{
						num17 = 1357057425;
						num18 = 1357057425;
					}
					num = num17 ^ (int)(num2 * 2111643965);
					continue;
				}
				case 104u:
					result = true;
					num = ((int)num2 * -1397102612) ^ -1188986916;
					continue;
				case 103u:
					result = true;
					num = ((int)num2 * -1461223917) ^ -829719006;
					continue;
				case 102u:
					goto IL_033a;
				case 101u:
					goto IL_0358;
				case 100u:
					result = false;
					num = 1514322777;
					continue;
				case 99u:
					result = false;
					num = 801975487;
					continue;
				case 98u:
					num = (int)((num2 * 278185370) ^ 0x7816EAD8);
					continue;
				case 97u:
					result = false;
					num = 6942683;
					continue;
				case 96u:
					result = false;
					num = 1832635817;
					continue;
				case 95u:
				{
					int num7;
					int num8;
					if (!flag5)
					{
						num7 = 338208994;
						num8 = 338208994;
					}
					else
					{
						num7 = 307762855;
						num8 = 307762855;
					}
					num = num7 ^ (int)(num2 * 791433330);
					continue;
				}
				case 94u:
					result = false;
					num = 566393260;
					continue;
				case 93u:
					goto IL_03ee;
				case 92u:
					goto IL_040c;
				case 91u:
					result = false;
					num = 417780596;
					continue;
				case 90u:
					num = (int)((num2 * 280259189) ^ 0x728F2958);
					continue;
				case 88u:
					result = false;
					num = 1190481348;
					continue;
				case 87u:
					num = (int)(num2 * 648959062) ^ -1818651658;
					continue;
				case 86u:
					num = ((int)num2 * -36713189) ^ -2104083170;
					continue;
				case 85u:
					result = true;
					num = ((int)num2 * -1582337775) ^ 0x638C0C8A;
					continue;
				case 84u:
					num = ((int)num2 * -1042730520) ^ -51237340;
					continue;
				case 83u:
					result = true;
					num = (int)(num2 * 1318633657) ^ -1040364311;
					continue;
				case 82u:
					result = true;
					num = (int)((num2 * 1649025099) ^ 0x27710F66);
					continue;
				case 81u:
					num = ((int)num2 * -485645625) ^ 0x5E423AA7;
					continue;
				case 80u:
					goto IL_04e0;
				case 79u:
					goto IL_0510;
				case 78u:
					result = false;
					num = 1939267929;
					continue;
				case 77u:
					goto IL_054c;
				case 76u:
					result = true;
					num = (int)((num2 * 1939811926) ^ 0xBDF7D44);
					continue;
				case 75u:
					result = true;
					num = ((int)num2 * -1224990199) ^ 0x195A722;
					continue;
				case 74u:
					num = (int)(num2 * 1780419872) ^ -1620391372;
					continue;
				case 73u:
					num = (int)(num2 * 1107214272) ^ -1479917644;
					continue;
				case 72u:
				{
					int num34;
					int num35;
					if (!flag17)
					{
						num34 = -1883436959;
						num35 = -1883436959;
					}
					else
					{
						num34 = -366061484;
						num35 = -366061484;
					}
					num = num34 ^ (int)(num2 * 1861101755);
					continue;
				}
				case 71u:
					num = ((int)num2 * -1718667934) ^ -859687486;
					continue;
				case 70u:
					result = false;
					num = 118998123;
					continue;
				case 69u:
					result = true;
					num = (int)(num2 * 258642888) ^ -198894500;
					continue;
				case 68u:
					result = false;
					num = 1249399953;
					continue;
				case 67u:
					result = false;
					num = 417780596;
					continue;
				case 66u:
					goto IL_0641;
				case 65u:
					result = true;
					num = (int)((num2 * 894850144) ^ 0x4AAFFAEB);
					continue;
				case 64u:
					num = ((int)num2 * -250054133) ^ -972542600;
					continue;
				case 63u:
					result = true;
					num = ((int)num2 * -1327224846) ^ 0x1A62F48B;
					continue;
				case 62u:
					num = ((int)num2 * -1742857192) ^ 0x5583AE94;
					continue;
				case 61u:
					result = false;
					num = 417780596;
					continue;
				case 60u:
				{
					int num30;
					int num31;
					if (flag13)
					{
						num30 = -769726617;
						num31 = -769726617;
					}
					else
					{
						num30 = -863525152;
						num31 = -863525152;
					}
					num = num30 ^ ((int)num2 * -452679162);
					continue;
				}
				case 59u:
					result = false;
					num = 70953146;
					continue;
				case 58u:
				{
					int num27;
					int num28;
					if (flag16)
					{
						num27 = -1941757679;
						num28 = -1941757679;
					}
					else
					{
						num27 = -1018374363;
						num28 = -1018374363;
					}
					num = num27 ^ ((int)num2 * -79112505);
					continue;
				}
				case 57u:
					switch (whereIsNow)
					{
					case WhereIsNow.Rondo_2_South_Inside_Exit:
						break;
					case WhereIsNow.Rondo_3_Inside_Left_exit:
						goto IL_011b;
					case WhereIsNow.Aleje_East_Right_Bitwy:
						goto IL_01b1;
					case WhereIsNow.Aleje_East_Exit_1:
						goto IL_0221;
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
						goto IL_0251;
					case WhereIsNow.Bitwy_North_Entry_Left_Rondo:
						goto IL_0270;
					case WhereIsNow.Bitwy_South_Exit_1:
						goto IL_02c9;
					case WhereIsNow.Rondo_2_Inside_Left_Entry_Rondo_3:
						goto IL_033a;
					case WhereIsNow.Aleje_West_Entry_Bitwy:
						goto IL_0358;
					case WhereIsNow.Bitwy_South_Right_Aleje:
						goto IL_03ee;
					case WhereIsNow.Bitwy_North_Exit_1:
						goto IL_040c;
					case WhereIsNow.Aleje_East_Entry_Rondo:
						goto IL_04e0;
					case WhereIsNow.Rondo_2_North_Entry_Rondo_3:
						goto IL_0510;
					case WhereIsNow.Rondo_1_East_Entry_Rondo_2:
						goto IL_054c;
					case WhereIsNow.Rondo_1_North_Entry_Rondo_2:
						goto IL_0641;
					default:
						goto IL_07b3;
					case WhereIsNow.Aleje_West_Entry_2:
						goto IL_07c6;
					case WhereIsNow.Aleje_West_Exit_1:
						goto IL_07e4;
					case WhereIsNow.Bitwy_North_Entry_2:
						goto IL_0802;
					case WhereIsNow.Bitwy_North_Right_Aleje:
						goto IL_0820;
					case WhereIsNow.Bitwy_South_Entry_2:
						goto IL_083e;
					case WhereIsNow.Rondo_1_South_Inside_Rondo_2_Inside:
						goto IL_085c;
					case WhereIsNow.Rondo_2_East_Exit:
						goto IL_087a;
					case WhereIsNow.Rondo_2_South_Exit:
						goto IL_08aa;
					case WhereIsNow.Rondo_2_West_Exit:
						goto IL_08c8;
					case WhereIsNow.Rondo_3_North_Exit:
						goto IL_08f8;
					case WhereIsNow.Rondo_East_Inside:
						goto IL_0916;
					}
					goto case 133u;
				case 45u:
					goto IL_07c6;
				case 17u:
					goto IL_07e4;
				case 26u:
					goto IL_0802;
				case 19u:
					goto IL_0820;
				case 52u:
					goto IL_083e;
				case 16u:
					goto IL_085c;
				case 56u:
					goto IL_087a;
				case 7u:
					goto IL_08aa;
				case 42u:
					goto IL_08c8;
				case 3u:
					goto IL_08f8;
				case 11u:
					goto IL_0916;
				case 55u:
					num = (int)((num2 * 1265200308) ^ 0x2341D050);
					continue;
				case 54u:
				{
					int num23;
					int num24;
					if (flag12)
					{
						num23 = 438942825;
						num24 = 438942825;
					}
					else
					{
						num23 = 733175905;
						num24 = 733175905;
					}
					num = num23 ^ ((int)num2 * -1798128101);
					continue;
				}
				case 53u:
					result = true;
					num = (int)((num2 * 1526331626) ^ 0x7F102B22);
					continue;
				case 51u:
					result = false;
					num = 1458906816;
					continue;
				case 50u:
					result = true;
					num = ((int)num2 * -992736670) ^ -365249040;
					continue;
				case 49u:
				{
					int num19;
					int num20;
					if (flag10)
					{
						num19 = 1347914356;
						num20 = 1347914356;
					}
					else
					{
						num19 = 2097663888;
						num20 = 2097663888;
					}
					num = num19 ^ ((int)num2 * -40221259);
					continue;
				}
				case 48u:
					num = (int)((num2 * 995065844) ^ 0x4EB3C6BC);
					continue;
				case 47u:
					num = ((int)num2 * -404181750) ^ 0x2461162;
					continue;
				case 46u:
					num = (int)((num2 * 430652398) ^ 0x14F6008);
					continue;
				case 44u:
				{
					int num15;
					int num16;
					if (flag3)
					{
						num15 = 1133373787;
						num16 = 1133373787;
					}
					else
					{
						num15 = 1325300384;
						num16 = 1325300384;
					}
					num = num15 ^ ((int)num2 * -181733885);
					continue;
				}
				case 43u:
					num = ((int)num2 * -1931052471) ^ 0xF921F29;
					continue;
				case 41u:
					result = false;
					num = 417780596;
					continue;
				case 40u:
				{
					int num13;
					int num14;
					if (flag7)
					{
						num13 = 2018361458;
						num14 = 2018361458;
					}
					else
					{
						num13 = 365835414;
						num14 = 365835414;
					}
					num = num13 ^ ((int)num2 * -531711222);
					continue;
				}
				case 39u:
					result = true;
					num = (int)(num2 * 1788149767) ^ -874870762;
					continue;
				case 38u:
					num = ((int)num2 * -1689589297) ^ -1005952416;
					continue;
				case 37u:
					num = (int)(num2 * 488201219) ^ -1550662751;
					continue;
				case 36u:
				{
					int num11;
					int num12;
					if (flag2)
					{
						num11 = -1011131119;
						num12 = -1011131119;
					}
					else
					{
						num11 = -861677176;
						num12 = -861677176;
					}
					num = num11 ^ ((int)num2 * -690930581);
					continue;
				}
				case 35u:
					num = ((int)num2 * -1303064183) ^ 0x6724CB19;
					continue;
				case 34u:
					result = true;
					num = (int)(num2 * 227064020) ^ -892524932;
					continue;
				case 33u:
					num = (int)(num2 * 223054884) ^ -1740497208;
					continue;
				case 32u:
					result = true;
					num = ((int)num2 * -300035645) ^ 0x250BA04C;
					continue;
				case 31u:
					result = true;
					num = ((int)num2 * -916504385) ^ 0x63C5C4E2;
					continue;
				case 30u:
					result = false;
					num = 1545252435;
					continue;
				case 29u:
					num = ((int)num2 * -1969751072) ^ 0x58FD4154;
					continue;
				case 28u:
					result = false;
					num = 417780596;
					continue;
				case 27u:
					result = false;
					num = 417780596;
					continue;
				case 25u:
					num = ((int)num2 * -92678431) ^ 0x700D9FF5;
					continue;
				case 24u:
					result = true;
					num = (int)(num2 * 1945221884) ^ -498480164;
					continue;
				case 23u:
				{
					int num9;
					int num10;
					if (flag6)
					{
						num9 = -817754512;
						num10 = -817754512;
					}
					else
					{
						num9 = -835874732;
						num10 = -835874732;
					}
					num = num9 ^ (int)(num2 * 25376715);
					continue;
				}
				case 22u:
					result = false;
					num = 275719090;
					continue;
				case 21u:
				{
					int num5;
					int num6;
					if (!flag4)
					{
						num5 = 2037734374;
						num6 = 2037734374;
					}
					else
					{
						num5 = 1107507638;
						num6 = 1107507638;
					}
					num = num5 ^ ((int)num2 * -2004706976);
					continue;
				}
				case 20u:
					result = false;
					num = 417780596;
					continue;
				case 18u:
					num = ((int)num2 * -1912619079) ^ -49407666;
					continue;
				case 15u:
					result = false;
					num = 599674888;
					continue;
				case 14u:
					result = false;
					num = 1101413730;
					continue;
				case 13u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1007184286;
						num4 = -1007184286;
					}
					else
					{
						num3 = -450600805;
						num4 = -450600805;
					}
					num = num3 ^ ((int)num2 * -799150524);
					continue;
				}
				case 12u:
					result = true;
					num = (int)(num2 * 1243316591) ^ -1150451696;
					continue;
				case 10u:
					num = (int)(num2 * 1382334124) ^ -112201100;
					continue;
				case 9u:
					result = true;
					num = ((int)num2 * -800691290) ^ -134309726;
					continue;
				case 8u:
					result = false;
					num = 1143609383;
					continue;
				case 6u:
					iAmHere = trafficList[idCar].iAmHere;
					num = (int)(num2 * 1595218339) ^ -1367423619;
					continue;
				case 5u:
					result = true;
					num = (int)((num2 * 314320683) ^ 0x1A3691D7);
					continue;
				case 4u:
					num = (int)((num2 * 790526261) ^ 0x741FDAE4);
					continue;
				case 2u:
					num = (int)((num2 * 1770067599) ^ 0x75AB583E);
					continue;
				case 1u:
					result = true;
					num = (int)((num2 * 2008093469) ^ 0xF4DD1AB);
					continue;
				case 89u:
					break;
				default:
					{
						return result;
					}
					IL_040c:
					flag2 = TrafficPlan.smethod_2((Shape)(object)sim.light23) == green;
					num = 519409708;
					continue;
					IL_03ee:
					flag3 = TrafficPlan.smethod_2((Shape)(object)sim.light2) == green;
					num = 1576034270;
					continue;
					IL_0358:
					flag8 = TrafficPlan.smethod_2((Shape)(object)sim.light6) == green;
					num = 479155436;
					continue;
					IL_033a:
					flag4 = TrafficPlan.smethod_2((Shape)(object)sim.light16) == green;
					num = 2011908531;
					continue;
					IL_02c9:
					flag11 = TrafficPlan.smethod_2((Shape)(object)sim.light25) == green;
					num = 352198432;
					continue;
					IL_0916:
					flag13 = TrafficPlan.smethod_2((Shape)(object)sim.light14) == green;
					num = 624212534;
					continue;
					IL_08f8:
					flag6 = TrafficPlan.smethod_2((Shape)(object)sim.light11) == green;
					num = 1256412823;
					continue;
					IL_08c8:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light5) != green)
					{
						num = 2090147355;
						num25 = 2090147355;
					}
					else
					{
						num = 1336354787;
						num25 = 1336354787;
					}
					continue;
					IL_0270:
					flag12 = TrafficPlan.smethod_2((Shape)(object)sim.light12) == green;
					num = 1864562726;
					continue;
					IL_08aa:
					flag9 = TrafficPlan.smethod_2((Shape)(object)sim.light4) == green;
					num = 527060663;
					continue;
					IL_087a:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light10) == green)
					{
						num = 388638281;
						num26 = 388638281;
					}
					else
					{
						num = 1360896580;
						num26 = 1360896580;
					}
					continue;
					IL_0251:
					result = true;
					num = 1574838365;
					continue;
					IL_085c:
					flag14 = TrafficPlan.smethod_2((Shape)(object)sim.light15) == green;
					num = 420360991;
					continue;
					IL_083e:
					flag15 = TrafficPlan.smethod_2((Shape)(object)sim.light4) == green;
					num = 887614228;
					continue;
					IL_0820:
					flag16 = TrafficPlan.smethod_2((Shape)(object)sim.light13) == green;
					num = 780664902;
					continue;
					IL_0802:
					flag17 = TrafficPlan.smethod_2((Shape)(object)sim.light18) == green;
					num = 1609273742;
					continue;
					IL_07e4:
					flag10 = TrafficPlan.smethod_2((Shape)(object)sim.light24) == green;
					num = 1058875587;
					continue;
					IL_07c6:
					flag5 = TrafficPlan.smethod_2((Shape)(object)sim.light7) == green;
					num = 366828383;
					continue;
					IL_07b3:
					num = ((int)num2 * -26247720) ^ 0x65C59E78;
					continue;
					IL_011b:
					flag = TrafficPlan.smethod_2((Shape)(object)sim.light17) == green;
					num = 505880043;
					continue;
					IL_0221:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light1) == green)
					{
						num = 839810430;
						num29 = 839810430;
					}
					else
					{
						num = 1113907224;
						num29 = 1113907224;
					}
					continue;
					IL_0641:
					flag18 = TrafficPlan.smethod_2((Shape)(object)sim.light19) == green;
					num = 937728166;
					continue;
					IL_054c:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light22) == green)
					{
						num = 977242952;
						num40 = 977242952;
					}
					else
					{
						num = 1001426520;
						num40 = 1001426520;
					}
					continue;
					IL_0510:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light20) != green)
					{
						num = 926710851;
						num43 = 926710851;
					}
					else
					{
						num = 1721190208;
						num43 = 1721190208;
					}
					continue;
					IL_01b1:
					flag19 = TrafficPlan.smethod_2((Shape)(object)sim.light8) == green;
					num = 1096179841;
					continue;
					IL_04e0:
					if (TrafficPlan.smethod_2((Shape)(object)sim.light9) != green)
					{
						num = 1256545439;
						num44 = 1256545439;
					}
					else
					{
						num = 2091580292;
						num44 = 2091580292;
					}
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
			int num = 436358278;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6E3A9A60u) % 3u)
				{
				case 1u:
					goto IL_000c;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000c:
				red = (Brush)TrafficPlan.smethod_4((TypeConverter)(object)TrafficPlan.smethod_3(), (object)"Red");
				green = (Brush)TrafficPlan.smethod_4((TypeConverter)(object)TrafficPlan.smethod_3(), (object)"Green");
				num = ((int)num2 * -1354439506) ^ -2123697633;
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
