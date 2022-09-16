using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using Traffic_Simulation.Properties;

namespace Traffic_Simulation;

internal static class Points
{
	public static string Bookmarks = "704B5A41~4B7864733736";

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
		byte[] result = default(byte[]);
		while (true)
		{
			int num2 = 95985881;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x15A32E76u) % 10u)
				{
				case 9u:
					num2 = (int)(num3 * 1192073245) ^ -2024864428;
					continue;
				case 8u:
				{
					int num4;
					if (num <= (Data_1.Length - 2 + 1) * (Round - 2 + 3))
					{
						num2 = 1458177400;
						num4 = 1458177400;
					}
					else
					{
						num2 = 836561913;
						num4 = 836561913;
					}
					continue;
				}
				case 6u:
					num2 = (int)((num3 * 172727482) ^ 0x48FED0A1);
					continue;
				case 5u:
					num2 = (int)((num3 * 444372169) ^ 0x55B9BCD3);
					continue;
				case 4u:
					result = Data_1;
					num2 = ((int)num3 * -627936340) ^ -1934587293;
					continue;
				case 3u:
					Array.Resize(ref Data_1, Data_1.Length - 2 + 1);
					num2 = (int)((num3 * 995249151) ^ 0x23DCCC8F);
					continue;
				case 2u:
					Data_1[num % Data_1.Length] = (byte)((Points.smethod_0(Data_1[num % Data_1.Length] ^ KeyGen[num % KeyGen.Length]) - Points.smethod_1(Data_1[(num + 1L) % Data_1.Length]) + 256) % 256);
					num2 = 724641206;
					continue;
				case 1u:
					num++;
					num2 = (int)(num3 * 1099644152) ^ -1145794564;
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

	public static void LoadTrace()
	{
		while (true)
		{
			int num = -474259064;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF28E0E47u) % 42u)
				{
				case 41u:
					num = ((int)num2 * -1687181904) ^ -2064829743;
					continue;
				case 40u:
					num = (int)(num2 * 670342051) ^ -1241149333;
					continue;
				case 39u:
					num = (int)(num2 * 2012023760) ^ -1095439404;
					continue;
				case 38u:
					loadOneTrace(Resources.Rondo_2_West_Exit, Rondo_2_West_Exit);
					num = ((int)num2 * -1244899535) ^ 0x288E316C;
					continue;
				case 37u:
					loadOneTrace(Resources.Rondo_1_Inside_Left_Entry_Rondo_2, Rondo_1_Inside_Left_Entry_Rondo_2);
					loadOneTrace(Resources.Rondo_1_North_Entry_Rondo_2, Rondo_1_North_Entry_Rondo_2);
					num = ((int)num2 * -879089128) ^ -1554391072;
					continue;
				case 36u:
					num = ((int)num2 * -1069754397) ^ -1738206854;
					continue;
				case 35u:
					loadOneTrace(Resources.Aleje_East_Right_Bitwy, Aleje_East_Right_Bitwy);
					num = ((int)num2 * -1143981393) ^ 0x7019FC20;
					continue;
				case 34u:
					loadOneTrace(Resources.Aleje_West_Exit_1, Aleje_West_Exit_1);
					num = ((int)num2 * -945895692) ^ 0x12AA1388;
					continue;
				case 33u:
					loadOneTrace(Resources.Aleje_East_Entry_Rondo, Aleje_East_Entry_Rondo);
					num = ((int)num2 * -1813728592) ^ 0x33EA5F03;
					continue;
				case 32u:
					loadOneTrace(Resources.Rondo_1_South_Inside_Rondo_2_Inside, Rondo_1_South_Inside_Rondo_2_Inside);
					num = (int)((num2 * 1374203375) ^ 0x2579AF47);
					continue;
				case 31u:
					loadOneTrace(Resources.Bitwy_North_Entry_Left_Rondo, Bitwy_North_Entry_Left_Rondo);
					loadOneTrace(Resources.Bitwy_North_Exit_1, Bitwy_North_Exit_1);
					loadOneTrace(Resources.Bitwy_North_Exit_2, Bitwy_North_Exit_2);
					num = (int)((num2 * 46110871) ^ 0x729FDD12);
					continue;
				case 30u:
					loadOneTrace(Resources.Rondo_2_North_Entry_Rondo_3, Rondo_2_North_Entry_Rondo_3);
					num = ((int)num2 * -224951775) ^ -427077725;
					continue;
				case 29u:
					num = (int)(num2 * 1150861885) ^ -1590342055;
					continue;
				case 28u:
					num = (int)(num2 * 725140710) ^ -399290635;
					continue;
				case 27u:
					loadOneTrace(Resources.Aleje_West_Entry_2, Aleje_West_Entry_2);
					num = ((int)num2 * -1505961141) ^ 0x34B6A8;
					continue;
				case 26u:
					loadOneTrace(Resources.Bitwy_South_Entry_2, Bitwy_South_Entry_2);
					num = ((int)num2 * -1209643603) ^ -1444264843;
					continue;
				case 25u:
					initListOfTrace();
					num = ((int)num2 * -1289140253) ^ 0x211005B;
					continue;
				case 24u:
					num = ((int)num2 * -380894423) ^ -315353718;
					continue;
				case 23u:
					num = (int)(num2 * 825928724) ^ -830040971;
					continue;
				case 21u:
					loadOneTrace(Resources.Bitwy_South_Right_Aleje, Bitwy_South_Right_Aleje);
					loadOneTrace(Resources.Rondo_1_East_Entry_Rondo_2, Rondo_1_East_Entry_Rondo_2);
					num = ((int)num2 * -458402854) ^ 0x357C2104;
					continue;
				case 20u:
					num = (int)(num2 * 404104704) ^ -929230480;
					continue;
				case 19u:
					loadOneTrace(Resources.Rondo_2_South_Exit, Rondo_2_South_Exit);
					num = (int)((num2 * 1681747883) ^ 0x62D73153);
					continue;
				case 18u:
					loadOneTrace(Resources.Aleje_Entry_Left_Bitwy, Aleje_Entry_Left_Bitwy);
					num = ((int)num2 * -784054354) ^ 0x2A2684BF;
					continue;
				case 17u:
					loadOneTrace(Resources.Bitwy_North_Left_Exit, Bitwy_North_Left_Exit);
					loadOneTrace(Resources.Bitwy_North_Right_Aleje, Bitwy_North_Right_Aleje);
					loadOneTrace(Resources.Bitwy_South_Entry_1, Bitwy_South_Entry_1);
					num = (int)(num2 * 277776078) ^ -1393821335;
					continue;
				case 16u:
					loadOneTrace(Resources.Rondo_1_West_Entry_Rondo_2, Rondo_1_West_Entry_Rondo_2);
					loadOneTrace(Resources.Rondo_2_East_Exit, Rondo_2_East_Exit);
					num = (int)((num2 * 506985966) ^ 0x5E8C93AF);
					continue;
				case 15u:
					loadOneTrace(Resources.Bitwy_South_Exit_2, Bitwy_South_Exit_2);
					num = ((int)num2 * -627873475) ^ 0x53ED4107;
					continue;
				case 14u:
					loadOneTrace(Resources.Aleje_East_Exit_2, Aleje_East_Exit_2);
					num = ((int)num2 * -925537470) ^ 0x2AF12042;
					continue;
				case 13u:
					loadOneTrace(Resources.Rondo_2_South_Inside_Exit, Rondo_2_South_Inside_Exit);
					num = ((int)num2 * -806113428) ^ 0x3A2C3141;
					continue;
				case 12u:
					loadOneTrace(Resources.Rondo_1_South_Entry_Rondo_2, Rondo_1_South_Entry_Rondo_2);
					num = ((int)num2 * -76195986) ^ 0x23C912FD;
					continue;
				case 11u:
					loadOneTrace(Resources.Aleje_West_Exit_2, Aleje_West_Exit_2);
					num = (int)((num2 * 1542469271) ^ 0x23CE9874);
					continue;
				case 10u:
					loadOneTrace(Resources.Rondo_2_Inside_Left_Entry_Rondo_3, Rondo_2_Inside_Left_Entry_Rondo_3);
					num = ((int)num2 * -2086352981) ^ -203899579;
					continue;
				case 9u:
					num = (int)((num2 * 1460417460) ^ 0x5494EAF3);
					continue;
				case 8u:
					num = ((int)num2 * -2144755053) ^ 0x68472977;
					continue;
				case 7u:
					loadOneTrace(Resources.Rondo_3_North_Exit, Rondo_3_North_Exit);
					num = ((int)num2 * -826302444) ^ -1445551445;
					continue;
				case 6u:
					loadOneTrace(Resources.Bitwy_South_Exit_1, Bitwy_South_Exit_1);
					num = ((int)num2 * -1672175035) ^ 0x5B281C02;
					continue;
				case 5u:
					loadOneTrace(Resources.Rondo_3_Inside_Left_exit, Rondo_3_Inside_Left_exit);
					num = (int)(num2 * 1252003880) ^ -943604628;
					continue;
				case 4u:
					loadOneTrace(Resources.Aleje_West_Entry_Bitwy, Aleje_West_Entry_Bitwy);
					num = ((int)num2 * -348589831) ^ -1618722070;
					continue;
				case 2u:
					loadOneTrace(Resources.Aleje_East_Exit_1, Aleje_East_Exit_1);
					num = ((int)num2 * -338226886) ^ -1123642718;
					continue;
				case 1u:
					loadOneTrace(Resources.Bitwy_North_Entry_1, Bitwy_North_Entry_1);
					loadOneTrace(Resources.Bitwy_North_Entry_2, Bitwy_North_Entry_2);
					num = ((int)num2 * -726734052) ^ -1522126584;
					continue;
				case 0u:
					loadOneTrace(Resources.Aleje_West_Entry_1, Aleje_West_Entry_1);
					num = (int)((num2 * 295452564) ^ 0x14FFCA40);
					continue;
				case 3u:
					break;
				default:
					loadOneTrace(Resources.Rondo_East_Inside, Rondo_East_Inside);
					return;
				}
				break;
			}
		}
	}

	private static void initListOfTrace()
	{
		while (true)
		{
			int num = -1408346393;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF029A123u) % 41u)
				{
				case 40u:
					Rondo_1_South_Entry_Rondo_2 = new List<Point>();
					Rondo_1_South_Inside_Rondo_2_Inside = new List<Point>();
					num = ((int)num2 * -821651783) ^ 0x1019EAA5;
					continue;
				case 39u:
					Rondo_2_Inside_Left_Entry_Rondo_3 = new List<Point>();
					num = (int)(num2 * 402019962) ^ -930412595;
					continue;
				case 38u:
					Aleje_East_Right_Bitwy = new List<Point>();
					Aleje_Entry_Left_Bitwy = new List<Point>();
					num = ((int)num2 * -474661875) ^ -903382685;
					continue;
				case 37u:
					num = (int)((num2 * 472445010) ^ 0x226DB7B6);
					continue;
				case 36u:
					Bitwy_North_Entry_1 = new List<Point>();
					num = ((int)num2 * -1305379689) ^ 0x42C527B3;
					continue;
				case 35u:
					Rondo_2_North_Entry_Rondo_3 = new List<Point>();
					num = ((int)num2 * -1051108546) ^ -389818428;
					continue;
				case 34u:
					num = (int)(num2 * 1426140621) ^ -1313918284;
					continue;
				case 33u:
					num = ((int)num2 * -601776124) ^ 0x1F5618B5;
					continue;
				case 32u:
					Aleje_West_Exit_2 = new List<Point>();
					num = (int)((num2 * 224876108) ^ 0x16F6BBF5);
					continue;
				case 29u:
					num = (int)(num2 * 1741975587) ^ -1960087773;
					continue;
				case 28u:
					Rondo_2_South_Inside_Exit = new List<Point>();
					Rondo_2_West_Exit = new List<Point>();
					num = (int)((num2 * 251363369) ^ 0x1563D6ED);
					continue;
				case 27u:
					Rondo_1_North_Entry_Rondo_2 = new List<Point>();
					num = ((int)num2 * -995598446) ^ -1750170420;
					continue;
				case 26u:
					Aleje_West_Entry_1 = new List<Point>();
					num = ((int)num2 * -1893010972) ^ 0x650A75AC;
					continue;
				case 25u:
					num = ((int)num2 * -435135218) ^ -1239474215;
					continue;
				case 24u:
					Aleje_East_Exit_1 = new List<Point>();
					num = (int)((num2 * 496083379) ^ 0x48456B17);
					continue;
				case 23u:
					Aleje_West_Entry_2 = new List<Point>();
					num = ((int)num2 * -1060493378) ^ -928617879;
					continue;
				case 22u:
					Rondo_1_West_Entry_Rondo_2 = new List<Point>();
					num = (int)((num2 * 1186160914) ^ 0x2372AC09);
					continue;
				case 21u:
					num = (int)(num2 * 444307972) ^ -1780859781;
					continue;
				case 20u:
					Bitwy_South_Entry_1 = new List<Point>();
					Bitwy_South_Entry_2 = new List<Point>();
					Bitwy_South_Exit_1 = new List<Point>();
					num = ((int)num2 * -1327607666) ^ 0x4AD28894;
					continue;
				case 19u:
					num = (int)((num2 * 2045370698) ^ 0x78DECC1D);
					continue;
				case 18u:
					Rondo_2_South_Exit = new List<Point>();
					num = (int)((num2 * 423567362) ^ 0x5296B2DF);
					continue;
				case 17u:
					Bitwy_North_Exit_1 = new List<Point>();
					num = ((int)num2 * -603870732) ^ 0x6047655B;
					continue;
				case 16u:
					Bitwy_South_Exit_2 = new List<Point>();
					num = (int)(num2 * 2078686248) ^ -1209779516;
					continue;
				case 15u:
					Rondo_3_North_Exit = new List<Point>();
					num = ((int)num2 * -127423854) ^ 0x5240EF4B;
					continue;
				case 14u:
					Bitwy_North_Exit_2 = new List<Point>();
					Bitwy_North_Left_Exit = new List<Point>();
					Bitwy_North_Right_Aleje = new List<Point>();
					num = (int)((num2 * 157611111) ^ 0x4F75D703);
					continue;
				case 13u:
					Aleje_East_Exit_2 = new List<Point>();
					num = ((int)num2 * -1640939157) ^ -225584890;
					continue;
				case 12u:
					num = ((int)num2 * -1754099867) ^ -1361704750;
					continue;
				case 11u:
					num = (int)(num2 * 2018399618) ^ -574953706;
					continue;
				case 10u:
					num = ((int)num2 * -1697752565) ^ 0x27CE7A18;
					continue;
				case 9u:
					Aleje_West_Entry_Bitwy = new List<Point>();
					num = (int)((num2 * 1213598487) ^ 0x1EF15D1A);
					continue;
				case 8u:
					Rondo_2_East_Exit = new List<Point>();
					num = (int)(num2 * 878287630) ^ -539787026;
					continue;
				case 7u:
					Rondo_3_Inside_Left_exit = new List<Point>();
					num = ((int)num2 * -1364027421) ^ 0x50D6691B;
					continue;
				case 6u:
					num = (int)((num2 * 1714931811) ^ 0x23115A12);
					continue;
				case 5u:
					Bitwy_South_Right_Aleje = new List<Point>();
					Rondo_1_East_Entry_Rondo_2 = new List<Point>();
					Rondo_1_Inside_Left_Entry_Rondo_2 = new List<Point>();
					num = ((int)num2 * -954174584) ^ 0x53333A42;
					continue;
				case 4u:
					num = (int)(num2 * 1931402506) ^ -880723099;
					continue;
				case 3u:
					Bitwy_North_Entry_2 = new List<Point>();
					Bitwy_North_Entry_Left_Rondo = new List<Point>();
					num = ((int)num2 * -217256438) ^ -1076393641;
					continue;
				case 2u:
					Aleje_East_Entry_Rondo = new List<Point>();
					num = ((int)num2 * -570373010) ^ -1273004008;
					continue;
				case 1u:
					Aleje_West_Exit_1 = new List<Point>();
					num = (int)(num2 * 449239632) ^ -674723879;
					continue;
				case 0u:
					Rondo_East_Inside = new List<Point>();
					num = ((int)num2 * -1970319231) ^ -2129611738;
					continue;
				default:
					return;
				case 30u:
					break;
				case 31u:
					return;
				}
				break;
			}
		}
	}

	private static void loadOneTrace(string path, List<Point> list)
	{
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected I4, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected I4, but got Unknown
		//IL_0153: Incompatible stack heights: 0 vs 1
		//IL_015a: Incompatible stack heights: 0 vs 1
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
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
					if ((string_ = Points.smethod_4((TextReader)stringReader)) == null)
					{
						num = -669246998;
						num2 = -669246998;
					}
					else
					{
						num = -1590140484;
						num2 = -1590140484;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)num ^ 0x84866631u) % 6u)
						{
						case 5u:
							num = -1590140484;
							continue;
						case 3u:
							list.Add(new Point(int.Parse(Points.smethod_3(string_, new char[1] { ';' })[0]), int.Parse(Points.smethod_3(string_, new char[1] { ';' })[1])));
							num = -1413174837;
							continue;
						case 1u:
							num = (int)((num3 * 1553790361) ^ 0x3E3EA4A4);
							continue;
						case 0u:
							num = ((int)num3 * -1133004637) ^ -650957539;
							continue;
						default:
							return;
						case 4u:
							break;
						case 2u:
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
						IL_011a:
						int num4 = -1645733705;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)num4 ^ 0x84866631u) % 4u)
							{
							case 2u:
								Points.smethod_5((IDisposable)stringReader);
								num4 = ((int)num3 * -778807028) ^ -1473312656;
								continue;
							case 1u:
								num4 = ((int)num3 * -807839766) ^ 0x507E1A2B;
								continue;
							default:
								goto end_IL_00f8;
							case 3u:
								break;
							case 0u:
								goto end_IL_00f8;
							}
							goto IL_011a;
							continue;
							end_IL_00f8:
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
				_ = -1345592697;
				while (true)
				{
					_003F val = /*Error near IL_012d: Stack underflow*/^ -2071566799;
					uint num3 = (uint)(int)val;
					switch (val % 3)
					{
					case 2:
						_ = (num3 * 1570252022) ^ 0xF00EB5F4u;
						continue;
					case 0:
						break;
					default:
						Points.smethod_7(Points.smethod_6(ex));
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
