using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using Traffic_Simulation.Properties;

namespace Traffic_Simulation;

internal static class Points
{
	public static string Bookmarks = "694C43505870~51716F77426A68";

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
		byte[] result = default(byte[]);
		long num3 = default(long);
		bool flag = default(bool);
		while (true)
		{
			int num = 1909825171;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6BABF671u) % 8u)
				{
				case 7u:
					Array.Resize(ref Data_1, Data_1.Length - 2 + 1);
					result = Data_1;
					num = (int)(num2 * 885351071) ^ -808486698;
					continue;
				case 5u:
					Data_1[num3 % Data_1.Length] = (byte)((Points.smethod_0(Data_1[num3 % Data_1.Length] ^ KeyGen[num3 % KeyGen.Length]) - Points.smethod_1(Data_1[(num3 + 1L) % Data_1.Length]) + 256) % 256);
					num3++;
					num = (int)(num2 * 1018413712) ^ -997884855;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 1057119782;
						num5 = 1057119782;
					}
					else
					{
						num4 = 699436272;
						num5 = 699436272;
					}
					num = num4 ^ (int)(num2 * 465433746);
					continue;
				}
				case 2u:
					num3 = 0L;
					num = (int)((num2 * 1335605242) ^ 0x3909442D);
					continue;
				case 1u:
					num = 1354421780;
					continue;
				case 0u:
					flag = num3 <= (Data_1.Length - 2 + 1) * (Round - 2 + 3);
					num = 1697302706;
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

	public static void LoadTrace()
	{
		initListOfTrace();
		while (true)
		{
			int num = 1736185193;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3AB104E5u) % 45u)
				{
				case 44u:
					loadOneTrace(Resources.Rondo_2_South_Inside_Exit, Rondo_2_South_Inside_Exit);
					num = ((int)num2 * -1116846443) ^ -1530015964;
					continue;
				case 43u:
					loadOneTrace(Resources.Rondo_2_West_Exit, Rondo_2_West_Exit);
					num = ((int)num2 * -571279105) ^ -89696826;
					continue;
				case 42u:
					num = ((int)num2 * -520394071) ^ -795840058;
					continue;
				case 41u:
					loadOneTrace(Resources.Bitwy_North_Entry_Left_Rondo, Bitwy_North_Entry_Left_Rondo);
					num = (int)(num2 * 2892170) ^ -886093597;
					continue;
				case 40u:
					loadOneTrace(Resources.Aleje_East_Right_Bitwy, Aleje_East_Right_Bitwy);
					num = (int)(num2 * 130382408) ^ -1503863866;
					continue;
				case 39u:
					loadOneTrace(Resources.Bitwy_North_Exit_1, Bitwy_North_Exit_1);
					loadOneTrace(Resources.Bitwy_North_Exit_2, Bitwy_North_Exit_2);
					num = ((int)num2 * -1666946790) ^ -1582713167;
					continue;
				case 38u:
					loadOneTrace(Resources.Aleje_Entry_Left_Bitwy, Aleje_Entry_Left_Bitwy);
					num = ((int)num2 * -1421768520) ^ -731419995;
					continue;
				case 37u:
					loadOneTrace(Resources.Rondo_1_West_Entry_Rondo_2, Rondo_1_West_Entry_Rondo_2);
					num = ((int)num2 * -1106026087) ^ 0x1143E138;
					continue;
				case 36u:
					loadOneTrace(Resources.Aleje_West_Exit_1, Aleje_West_Exit_1);
					num = ((int)num2 * -1724164923) ^ -175888640;
					continue;
				case 35u:
					loadOneTrace(Resources.Aleje_East_Entry_Rondo, Aleje_East_Entry_Rondo);
					num = (int)((num2 * 1242869278) ^ 0xAE29788);
					continue;
				case 34u:
					loadOneTrace(Resources.Rondo_1_North_Entry_Rondo_2, Rondo_1_North_Entry_Rondo_2);
					num = ((int)num2 * -1580164194) ^ 0x65D22A58;
					continue;
				case 33u:
					num = ((int)num2 * -1130604511) ^ -705042076;
					continue;
				case 32u:
					loadOneTrace(Resources.Rondo_2_North_Entry_Rondo_3, Rondo_2_North_Entry_Rondo_3);
					num = (int)((num2 * 1170292434) ^ 0x6A5A37E3);
					continue;
				case 31u:
					num = (int)((num2 * 912345535) ^ 0x715CD767);
					continue;
				case 30u:
					loadOneTrace(Resources.Bitwy_North_Entry_2, Bitwy_North_Entry_2);
					num = (int)((num2 * 965233915) ^ 0x6A087177);
					continue;
				case 29u:
					loadOneTrace(Resources.Aleje_West_Entry_1, Aleje_West_Entry_1);
					num = (int)(num2 * 1825940535) ^ -1756334239;
					continue;
				case 28u:
					loadOneTrace(Resources.Aleje_East_Exit_1, Aleje_East_Exit_1);
					num = ((int)num2 * -1892614996) ^ 0x34F923E8;
					continue;
				case 27u:
					loadOneTrace(Resources.Rondo_2_Inside_Left_Entry_Rondo_3, Rondo_2_Inside_Left_Entry_Rondo_3);
					num = ((int)num2 * -89549053) ^ -802062081;
					continue;
				case 26u:
					num = (int)(num2 * 1139972624) ^ -1556127151;
					continue;
				case 25u:
					loadOneTrace(Resources.Rondo_2_East_Exit, Rondo_2_East_Exit);
					num = (int)(num2 * 1109250585) ^ -300467997;
					continue;
				case 24u:
					num = ((int)num2 * -1431830575) ^ 0x4A46D55C;
					continue;
				case 22u:
					loadOneTrace(Resources.Bitwy_South_Entry_1, Bitwy_South_Entry_1);
					num = (int)(num2 * 1088597974) ^ -1775714347;
					continue;
				case 21u:
					loadOneTrace(Resources.Rondo_1_Inside_Left_Entry_Rondo_2, Rondo_1_Inside_Left_Entry_Rondo_2);
					num = (int)(num2 * 643481830) ^ -1922408816;
					continue;
				case 20u:
					loadOneTrace(Resources.Rondo_1_South_Entry_Rondo_2, Rondo_1_South_Entry_Rondo_2);
					loadOneTrace(Resources.Rondo_1_South_Inside_Rondo_2_Inside, Rondo_1_South_Inside_Rondo_2_Inside);
					num = ((int)num2 * -522447313) ^ -2089292132;
					continue;
				case 19u:
					num = (int)(num2 * 1600936434) ^ -1111497039;
					continue;
				case 18u:
					loadOneTrace(Resources.Rondo_East_Inside, Rondo_East_Inside);
					num = ((int)num2 * -330801485) ^ 0x7FDD3900;
					continue;
				case 17u:
					num = ((int)num2 * -513845228) ^ -565967004;
					continue;
				case 16u:
					num = ((int)num2 * -378904246) ^ 0x3A619BDF;
					continue;
				case 15u:
					loadOneTrace(Resources.Bitwy_South_Exit_1, Bitwy_South_Exit_1);
					loadOneTrace(Resources.Bitwy_South_Exit_2, Bitwy_South_Exit_2);
					loadOneTrace(Resources.Bitwy_South_Right_Aleje, Bitwy_South_Right_Aleje);
					num = (int)((num2 * 1914121674) ^ 0x6C75D692);
					continue;
				case 14u:
					loadOneTrace(Resources.Aleje_East_Exit_2, Aleje_East_Exit_2);
					num = ((int)num2 * -30848454) ^ -509330548;
					continue;
				case 13u:
					loadOneTrace(Resources.Rondo_1_East_Entry_Rondo_2, Rondo_1_East_Entry_Rondo_2);
					num = ((int)num2 * -1756928563) ^ -1276052438;
					continue;
				case 12u:
					loadOneTrace(Resources.Bitwy_South_Entry_2, Bitwy_South_Entry_2);
					num = (int)((num2 * 320373513) ^ 0x7E2F85C3);
					continue;
				case 11u:
					num = ((int)num2 * -34051713) ^ -862626032;
					continue;
				case 10u:
					loadOneTrace(Resources.Bitwy_North_Entry_1, Bitwy_North_Entry_1);
					num = (int)(num2 * 432867209) ^ -794267581;
					continue;
				case 9u:
					loadOneTrace(Resources.Bitwy_North_Right_Aleje, Bitwy_North_Right_Aleje);
					num = ((int)num2 * -1713042251) ^ 0x6B09F6D8;
					continue;
				case 8u:
					loadOneTrace(Resources.Rondo_3_Inside_Left_exit, Rondo_3_Inside_Left_exit);
					loadOneTrace(Resources.Rondo_3_North_Exit, Rondo_3_North_Exit);
					num = ((int)num2 * -388571117) ^ -331435915;
					continue;
				case 7u:
					loadOneTrace(Resources.Aleje_West_Entry_2, Aleje_West_Entry_2);
					num = (int)(num2 * 365680181) ^ -1911034470;
					continue;
				case 6u:
					loadOneTrace(Resources.Aleje_West_Entry_Bitwy, Aleje_West_Entry_Bitwy);
					num = ((int)num2 * -556427663) ^ -494154760;
					continue;
				case 5u:
					num = (int)(num2 * 1680241163) ^ -124911002;
					continue;
				case 3u:
					loadOneTrace(Resources.Rondo_2_South_Exit, Rondo_2_South_Exit);
					num = ((int)num2 * -648823323) ^ -192259150;
					continue;
				case 2u:
					num = ((int)num2 * -1287998971) ^ 0x44253C82;
					continue;
				case 1u:
					loadOneTrace(Resources.Aleje_West_Exit_2, Aleje_West_Exit_2);
					num = (int)((num2 * 600326052) ^ 0x759EB7E4);
					continue;
				case 0u:
					loadOneTrace(Resources.Bitwy_North_Left_Exit, Bitwy_North_Left_Exit);
					num = ((int)num2 * -497986577) ^ -824110572;
					continue;
				default:
					return;
				case 23u:
					break;
				case 4u:
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
			int num = -1772206947;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA1D40118u) % 48u)
				{
				case 47u:
					Bitwy_South_Exit_2 = new List<Point>();
					num = (int)(num2 * 139524660) ^ -767151466;
					continue;
				case 46u:
					Rondo_East_Inside = new List<Point>();
					num = (int)((num2 * 1763995420) ^ 0x2ED0DEB8);
					continue;
				case 45u:
					Aleje_West_Exit_2 = new List<Point>();
					num = (int)(num2 * 1199774722) ^ -208399164;
					continue;
				case 44u:
					Rondo_3_North_Exit = new List<Point>();
					num = (int)((num2 * 321411828) ^ 0x6828CBF6);
					continue;
				case 43u:
					Aleje_West_Entry_Bitwy = new List<Point>();
					num = (int)(num2 * 2003247414) ^ -874124472;
					continue;
				case 42u:
					num = ((int)num2 * -20618619) ^ -112417204;
					continue;
				case 41u:
					num = (int)(num2 * 1483025029) ^ -1953358977;
					continue;
				case 39u:
					Rondo_1_West_Entry_Rondo_2 = new List<Point>();
					num = (int)((num2 * 231397463) ^ 0x73E61AF5);
					continue;
				case 38u:
					Aleje_East_Right_Bitwy = new List<Point>();
					Aleje_Entry_Left_Bitwy = new List<Point>();
					num = ((int)num2 * -312308992) ^ 0x1B3496CB;
					continue;
				case 36u:
					num = ((int)num2 * -1875243205) ^ -1869410221;
					continue;
				case 35u:
					Rondo_2_South_Exit = new List<Point>();
					num = ((int)num2 * -1967987300) ^ 0x5AA63228;
					continue;
				case 34u:
					Bitwy_South_Right_Aleje = new List<Point>();
					Rondo_1_East_Entry_Rondo_2 = new List<Point>();
					num = ((int)num2 * -197396982) ^ -1026717707;
					continue;
				case 33u:
					Bitwy_North_Left_Exit = new List<Point>();
					num = (int)(num2 * 2008126669) ^ -816021742;
					continue;
				case 32u:
					Bitwy_North_Exit_2 = new List<Point>();
					num = (int)((num2 * 978526570) ^ 0x7E1873D9);
					continue;
				case 31u:
					Bitwy_North_Entry_2 = new List<Point>();
					Bitwy_North_Entry_Left_Rondo = new List<Point>();
					num = (int)((num2 * 1934447896) ^ 0x502D7D40);
					continue;
				case 30u:
					Aleje_West_Entry_1 = new List<Point>();
					num = (int)((num2 * 223055801) ^ 0x7F5D9D2B);
					continue;
				case 29u:
					Aleje_West_Entry_2 = new List<Point>();
					num = (int)((num2 * 571511305) ^ 0x3560D006);
					continue;
				case 28u:
					num = (int)(num2 * 300139070) ^ -1634888412;
					continue;
				case 27u:
					Bitwy_North_Exit_1 = new List<Point>();
					num = (int)((num2 * 1733773352) ^ 0x39497AF8);
					continue;
				case 26u:
					Rondo_1_Inside_Left_Entry_Rondo_2 = new List<Point>();
					num = ((int)num2 * -1501244545) ^ 0x8F73EB6;
					continue;
				case 25u:
					Rondo_2_South_Inside_Exit = new List<Point>();
					num = ((int)num2 * -394687791) ^ -1266854373;
					continue;
				case 24u:
					Rondo_1_North_Entry_Rondo_2 = new List<Point>();
					Rondo_1_South_Entry_Rondo_2 = new List<Point>();
					Rondo_1_South_Inside_Rondo_2_Inside = new List<Point>();
					num = ((int)num2 * -315764874) ^ 0x6EF9696C;
					continue;
				case 23u:
					num = ((int)num2 * -1814585163) ^ 0x3F38BDB6;
					continue;
				case 22u:
					Bitwy_North_Right_Aleje = new List<Point>();
					num = (int)(num2 * 1159669348) ^ -487225645;
					continue;
				case 21u:
					Rondo_2_Inside_Left_Entry_Rondo_3 = new List<Point>();
					num = ((int)num2 * -1451139723) ^ -754709153;
					continue;
				case 20u:
					Bitwy_South_Entry_2 = new List<Point>();
					num = ((int)num2 * -462874046) ^ 0x9D1A11;
					continue;
				case 19u:
					Bitwy_South_Entry_1 = new List<Point>();
					num = ((int)num2 * -1473542674) ^ -1617151458;
					continue;
				case 18u:
					Rondo_2_East_Exit = new List<Point>();
					num = ((int)num2 * -937419887) ^ -1148901457;
					continue;
				case 17u:
					num = ((int)num2 * -689820813) ^ -1317268416;
					continue;
				case 16u:
					num = ((int)num2 * -265827083) ^ -824006973;
					continue;
				case 15u:
					Bitwy_South_Exit_1 = new List<Point>();
					num = (int)((num2 * 1279199666) ^ 0x657796F9);
					continue;
				case 14u:
					num = ((int)num2 * -292450437) ^ -1892835182;
					continue;
				case 13u:
					Aleje_East_Exit_2 = new List<Point>();
					num = ((int)num2 * -1400617614) ^ -885195800;
					continue;
				case 12u:
					num = (int)(num2 * 1392991947) ^ -1426759778;
					continue;
				case 11u:
					Rondo_3_Inside_Left_exit = new List<Point>();
					num = (int)((num2 * 306094515) ^ 0x680AF565);
					continue;
				case 10u:
					Rondo_2_West_Exit = new List<Point>();
					num = (int)((num2 * 987191162) ^ 0x6AACA43D);
					continue;
				case 9u:
					num = (int)(num2 * 1829922111) ^ -761588804;
					continue;
				case 8u:
					num = (int)((num2 * 1036715766) ^ 0x57257298);
					continue;
				case 7u:
					num = (int)((num2 * 915929233) ^ 0x19598249);
					continue;
				case 6u:
					Bitwy_North_Entry_1 = new List<Point>();
					num = ((int)num2 * -298667998) ^ -1862966069;
					continue;
				case 5u:
					Aleje_East_Exit_1 = new List<Point>();
					num = (int)((num2 * 1741109815) ^ 0xDCF68E6);
					continue;
				case 4u:
					num = (int)(num2 * 21837913) ^ -379076891;
					continue;
				case 3u:
					num = (int)((num2 * 163076186) ^ 0x5B2E48B8);
					continue;
				case 2u:
					Aleje_West_Exit_1 = new List<Point>();
					num = (int)(num2 * 677802974) ^ -1855179517;
					continue;
				case 1u:
					num = ((int)num2 * -1697564747) ^ -1112484542;
					continue;
				case 0u:
					Rondo_2_North_Entry_Rondo_3 = new List<Point>();
					num = ((int)num2 * -1430916284) ^ -2017696175;
					continue;
				default:
					return;
				case 37u:
					break;
				case 40u:
					return;
				}
				break;
			}
		}
	}

	private static void loadOneTrace(string path, List<Point> list)
	{
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected I4, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected I4, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Incompatible stack heights: 0 vs 1
		//IL_01a0: Incompatible stack heights: 0 vs 1
		try
		{
			StringReader stringReader = Points.smethod_2(path);
			try
			{
				while (true)
				{
					string string_;
					bool flag = (string_ = Points.smethod_4((TextReader)stringReader)) != null;
					int num = -2135120830;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xB41DC097u) % 9u)
						{
						case 7u:
							num = -1244866725;
							continue;
						case 5u:
							list.Add(new Point(int.Parse(Points.smethod_3(string_, new char[1] { ';' })[0]), int.Parse(Points.smethod_3(string_, new char[1] { ';' })[1])));
							num = (int)(num2 * 1007182446) ^ -748440293;
							continue;
						case 4u:
							num = (int)(num2 * 308470143) ^ -1387323024;
							continue;
						case 3u:
							num = (int)((num2 * 1039267313) ^ 0x163E6082);
							continue;
						case 2u:
							num = (int)((num2 * 2005608012) ^ 0x15BE21BD);
							continue;
						case 1u:
						{
							int num3;
							int num4;
							if (!flag)
							{
								num3 = 689596614;
								num4 = 689596614;
							}
							else
							{
								num3 = 815376878;
								num4 = 815376878;
							}
							num = num3 ^ ((int)num2 * -1806672477);
							continue;
						}
						case 0u:
							num = -93504143;
							continue;
						default:
							return;
						case 8u:
							break;
						case 6u:
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
						IL_0154:
						int num5 = -1213123150;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)num5 ^ 0xB41DC097u) % 4u)
							{
							case 3u:
								num5 = (int)((num2 * 2068524945) ^ 0x180F7E6E);
								continue;
							case 1u:
								Points.smethod_5((IDisposable)stringReader);
								num5 = (int)(num2 * 1977023584) ^ -198209076;
								continue;
							default:
								goto end_IL_0132;
							case 0u:
								break;
							case 2u:
								goto end_IL_0132;
							}
							goto IL_0154;
							continue;
							end_IL_0132:
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
				_ = -1131621178;
				while (true)
				{
					_003F val = /*Error near IL_0167: Stack underflow*/^ -1273118569;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 2:
						Points.smethod_7(Points.smethod_6(ex));
						_ = ((int)num2 * -750092095) ^ 0x469CB472;
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
