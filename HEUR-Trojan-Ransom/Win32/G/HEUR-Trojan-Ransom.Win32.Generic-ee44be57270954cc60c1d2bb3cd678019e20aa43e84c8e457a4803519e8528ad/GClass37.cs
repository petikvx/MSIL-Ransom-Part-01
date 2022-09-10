using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;

public abstract class GClass37
{
	protected enum GEnum14
	{
		Uninitialized,
		Initialized,
		Error
	}

	protected class GClass40
	{
		public FileAttributes fileAttributes_0;

		public FILETIME filetime_0;

		public FILETIME filetime_1;

		public FILETIME filetime_2;

		public int int_0;

		public int int_1;

		internal void method_0(Class17.Struct6 struct6_0)
		{
			fileAttributes_0 = struct6_0.fileAttributes_0;
			filetime_0 = struct6_0.filetime_0;
			filetime_1 = struct6_0.filetime_1;
			filetime_2 = struct6_0.filetime_2;
			while (true)
			{
				int num = 438241828;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3A52E0F3u) % 4u)
					{
					case 3u:
						int_0 = struct6_0.int_0;
						num = (int)(num2 * 1576155235) ^ -901540150;
						continue;
					case 0u:
						int_1 = struct6_0.int_1;
						num = (int)((num2 * 1006679352) ^ 0x409642C6);
						continue;
					default:
						return;
					case 2u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}

		public GClass40()
		{
			while (true)
			{
				int num = 1439624791;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x6E4927A1u) % 3u)
					{
					case 2u:
						goto IL_0008;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0008:
					num = (int)(num2 * 653178781) ^ -139449630;
				}
			}
		}
	}

	protected string string_0;

	protected string string_1;

	protected GEnum14 genum14_0;

	protected readonly GClass40 gclass40_0 = new GClass40();

	protected int int_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_2;

	public FileAttributes FileAttributes_0
	{
		get
		{
			return GClass33.smethod_1(string_1);
		}
		set
		{
			GClass33.smethod_0(string_1, value);
		}
	}

	public DateTime DateTime_0
	{
		get
		{
			DateTime dateTime_ = DateTime_1;
			DateTime result = default(DateTime);
			while (true)
			{
				int num = -695564513;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD2E731EBu) % 3u)
					{
					case 2u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0009:
					result = dateTime_.ToLocalTime();
					num = (int)(num2 * 1184361840) ^ -192020297;
				}
			}
		}
		set
		{
			DateTime_1 = value.ToUniversalTime();
		}
	}

	public DateTime DateTime_1
	{
		get
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			DateTime result = default(DateTime);
			while (true)
			{
				int num = -1357230056;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEA4AE6BEu) % 12u)
					{
					case 10u:
						method_0();
						num = (int)((num2 * 676604000) ^ 0x1D11E1B2);
						continue;
					case 9u:
					{
						int num5;
						int num6;
						if (flag)
						{
							num5 = -2102937088;
							num6 = -2102937088;
						}
						else
						{
							num5 = -329143558;
							num6 = -329143558;
						}
						num = num5 ^ ((int)num2 * -1387783924);
						continue;
					}
					case 8u:
						flag2 = genum14_0 == GEnum14.Error;
						num = -2089884411;
						continue;
					case 7u:
					{
						int num3;
						int num4;
						if (!flag2)
						{
							num3 = -204705;
							num4 = -204705;
						}
						else
						{
							num3 = -1036685367;
							num4 = -1036685367;
						}
						num = num3 ^ ((int)num2 * -656146288);
						continue;
					}
					case 6u:
						num = (int)((num2 * 1486538249) ^ 0x3489EB54);
						continue;
					case 4u:
						num = ((int)num2 * -2091787593) ^ -282722027;
						continue;
					case 3u:
						GClass33.smethod_13(int_0, string_1);
						num = (int)(num2 * 1418370385) ^ -456996840;
						continue;
					case 2u:
						flag = genum14_0 == GEnum14.Uninitialized;
						num = ((int)num2 * -1848996330) ^ 0x32FD797;
						continue;
					case 1u:
					{
						long fileTime = ((long)gclass40_0.filetime_0.dwHighDateTime << 32) | (gclass40_0.filetime_0.dwLowDateTime & 0xFFFFFFFFL);
						result = DateTime.FromFileTimeUtc(fileTime);
						num = -1818833962;
						continue;
					}
					case 0u:
						num = ((int)num2 * -558728763) ^ 0x251A67E0;
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
		set
		{
			bool flag = default(bool);
			while (true)
			{
				int num = 1587977195;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9849252u) % 8u)
					{
					case 6u:
						num = (int)(num2 * 1439450238) ^ -582224771;
						continue;
					case 5u:
						GClass34.smethod_17(string_1, value);
						num = ((int)num2 * -1034887199) ^ 0x701B94BC;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (!flag)
						{
							num3 = 432122430;
							num4 = 432122430;
						}
						else
						{
							num3 = 2001255987;
							num4 = 2001255987;
						}
						num = num3 ^ ((int)num2 * -1573715997);
						continue;
					}
					case 3u:
						genum14_0 = GEnum14.Uninitialized;
						num = 1536262677;
						continue;
					case 1u:
						flag = this is GClass38;
						num = (int)(num2 * 1014412647) ^ -246127503;
						continue;
					case 0u:
						GClass36.smethod_19(string_1, value);
						num = 974502012;
						continue;
					default:
						return;
					case 2u:
						break;
					case 7u:
						return;
					}
					break;
				}
			}
		}
	}

	public DateTime DateTime_2
	{
		get
		{
			DateTime dateTime_ = DateTime_3;
			DateTime result = default(DateTime);
			while (true)
			{
				int num = -1268497691;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEF8A0800u) % 4u)
					{
					case 3u:
						num = (int)((num2 * 1645385109) ^ 0xCE8F729);
						continue;
					case 1u:
						result = dateTime_.ToLocalTime();
						num = ((int)num2 * -241288051) ^ -427562042;
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
		set
		{
			while (true)
			{
				int num = -404176956;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x990CA27Eu) % 3u)
					{
					case 2u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0003:
					DateTime_3 = value.ToUniversalTime();
					num = ((int)num2 * -1970723623) ^ 0x7A7CBA93;
				}
			}
		}
	}

	public DateTime DateTime_3
	{
		get
		{
			long fileTime = default(long);
			DateTime result = default(DateTime);
			while (true)
			{
				int num = 1754684961;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x48D21BBFu) % 10u)
					{
					case 9u:
						num = (int)(num2 * 346470770) ^ -2094339853;
						continue;
					case 8u:
						smethod_0(int_0, string_1);
						num = ((int)num2 * -1480603334) ^ 0x7374F7AE;
						continue;
					case 7u:
						method_0();
						num = (int)((num2 * 2065272751) ^ 0x2BEB05B5);
						continue;
					case 6u:
						fileTime = ((long)gclass40_0.filetime_2.dwHighDateTime << 32) | (gclass40_0.filetime_2.dwLowDateTime & 0xFFFFFFFFL);
						num = 489087981;
						continue;
					case 5u:
						num = (int)((num2 * 1022794822) ^ 0x5FB44B30);
						continue;
					case 4u:
						result = DateTime.FromFileTimeUtc(fileTime);
						num = ((int)num2 * -589224252) ^ -1594699052;
						continue;
					case 2u:
					{
						int num4;
						int num5;
						if (genum14_0 == GEnum14.Uninitialized)
						{
							num4 = 1619698698;
							num5 = 1619698698;
						}
						else
						{
							num4 = 871119426;
							num5 = 871119426;
						}
						num = num4 ^ (int)(num2 * 918174516);
						continue;
					}
					case 1u:
					{
						int num3;
						if (genum14_0 == GEnum14.Error)
						{
							num = 1837693183;
							num3 = 1837693183;
						}
						else
						{
							num = 1361854817;
							num3 = 1361854817;
						}
						continue;
					}
					case 0u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -290366630;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC7DD1F9Bu) % 8u)
					{
					case 6u:
						num = ((int)num2 * -579202502) ^ 0xADDBF0;
						continue;
					case 5u:
						GClass34.smethod_18(string_1, value);
						num = ((int)num2 * -2004510912) ^ -1454009541;
						continue;
					case 4u:
						GClass36.smethod_23(string_1, value);
						num = -172863119;
						continue;
					case 2u:
						num = (int)((num2 * 1456626122) ^ 0x13CD4118);
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (!(this is GClass38))
						{
							num3 = -2017631261;
							num4 = -2017631261;
						}
						else
						{
							num3 = -621165758;
							num4 = -621165758;
						}
						num = num3 ^ ((int)num2 * -1978253972);
						continue;
					}
					case 0u:
						num = ((int)num2 * -2092527753) ^ 0x2E5A465;
						continue;
					case 3u:
						break;
					default:
						genum14_0 = GEnum14.Uninitialized;
						return;
					}
					break;
				}
			}
		}
	}

	public DateTime DateTime_4
	{
		get
		{
			DateTime result = default(DateTime);
			DateTime dateTime_ = default(DateTime);
			while (true)
			{
				int num = -783849554;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFA350C8Bu) % 5u)
					{
					case 4u:
						result = dateTime_.ToLocalTime();
						num = ((int)num2 * -113657156) ^ 0x32B7D448;
						continue;
					case 1u:
						dateTime_ = DateTime_5;
						num = (int)(num2 * 1123106894) ^ -1303101717;
						continue;
					case 0u:
						num = (int)((num2 * 688451287) ^ 0x53EF8014);
						continue;
					case 2u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -604948434;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAFF6C2F3u) % 4u)
					{
					case 1u:
						DateTime_5 = value.ToUniversalTime();
						num = (int)((num2 * 617909185) ^ 0x4B61E436);
						continue;
					case 0u:
						num = (int)(num2 * 386072593) ^ -1550099155;
						continue;
					default:
						return;
					case 3u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}
	}

	public DateTime DateTime_5
	{
		get
		{
			DateTime result = default(DateTime);
			while (true)
			{
				int num = 1899538559;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3FBFBF4u) % 9u)
					{
					case 8u:
					{
						long fileTime = ((long)gclass40_0.filetime_1.dwHighDateTime << 32) | (gclass40_0.filetime_1.dwLowDateTime & 0xFFFFFFFFL);
						result = DateTime.FromFileTimeUtc(fileTime);
						num = 1082739401;
						continue;
					}
					case 7u:
						num = (int)((num2 * 43553810) ^ 0x3D424E64);
						continue;
					case 6u:
					{
						int num4;
						int num5;
						if (genum14_0 != 0)
						{
							num4 = -419767470;
							num5 = -419767470;
						}
						else
						{
							num4 = -688008489;
							num5 = -688008489;
						}
						num = num4 ^ (int)(num2 * 1615062118);
						continue;
					}
					case 4u:
					{
						int num3;
						if (genum14_0 != GEnum14.Error)
						{
							num = 299534799;
							num3 = 299534799;
						}
						else
						{
							num = 1902001748;
							num3 = 1902001748;
						}
						continue;
					}
					case 3u:
						GClass33.smethod_13(int_0, string_1);
						num = (int)((num2 * 1103328551) ^ 0x72A9B2AF);
						continue;
					case 1u:
						method_0();
						num = (int)(num2 * 1321545617) ^ -1281075718;
						continue;
					case 0u:
						num = ((int)num2 * -1355476068) ^ -291661444;
						continue;
					case 2u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 457784435;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1A563C59u) % 8u)
					{
					case 7u:
						num = ((int)num2 * -1318864750) ^ -569506709;
						continue;
					case 6u:
						num = (int)((num2 * 356745501) ^ 0x7C5F4EB);
						continue;
					case 3u:
						GClass36.smethod_27(string_1, value);
						num = 1999325663;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (!(this is GClass38))
						{
							num3 = -1148822734;
							num4 = -1148822734;
						}
						else
						{
							num3 = -130457208;
							num4 = -130457208;
						}
						num = num3 ^ (int)(num2 * 1919601288);
						continue;
					}
					case 1u:
						GClass34.smethod_19(string_1, value);
						num = ((int)num2 * -893596166) ^ 0x6C2C223;
						continue;
					case 0u:
						num = ((int)num2 * -1581913095) ^ -1984355258;
						continue;
					case 5u:
						break;
					default:
						genum14_0 = GEnum14.Uninitialized;
						return;
					}
					break;
				}
			}
		}
	}

	public virtual string String_2
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -1588714612;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC863D27Du) % 4u)
					{
					case 2u:
						num = (int)((num2 * 536161058) ^ 0x9DE9795);
						continue;
					case 1u:
						result = string_1;
						num = (int)(num2 * 1750335816) ^ -245956341;
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
	}

	public string String_0 => GClass41.smethod_22(string_1);

	public abstract string GClass37_002E_200F_206C_206C_200C_200E_200B_202D_202D_202E_206C_200C_200D_200F_206D_206D_202C_206F_200B_200B_206A_200F_202B_200B_206B_202A_202A_202A_206E_202C_206E_202C_202D_200D_206D_202E_200E_206F_202B_206B_206C_202E { get; }

	public abstract bool GClass37_002E_206C_206A_206B_206C_200D_206C_202E_202C_200F_206A_200E_202D_206D_200F_206A_200B_206C_206B_206F_206C_206A_200D_206A_206E_202E_202D_206B_200D_206D_200F_200E_202C_202D_206B_206F_202E_206D_200C_200B_202C_202E { get; }

	internal string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	private static void smethod_0(int int_1, string string_3)
	{
		bool flag2 = default(bool);
		int num5 = default(int);
		bool flag = default(bool);
		string text = default(string);
		bool flag3 = default(bool);
		while (true)
		{
			int num = -916589139;
			while (true)
			{
				uint num2;
				string text2;
				int num9;
				switch ((num2 = (uint)num ^ 0xB2656226u) % 46u)
				{
				case 45u:
				{
					int num12;
					int num13;
					if (!flag2)
					{
						num12 = 907694227;
						num13 = 907694227;
					}
					else
					{
						num12 = 70317885;
						num13 = 70317885;
					}
					num = num12 ^ (int)(num2 * 1965685970);
					continue;
				}
				case 44u:
				{
					int num10;
					int num11;
					if (num5 > 80)
					{
						num10 = -180972731;
						num11 = -180972731;
					}
					else
					{
						num10 = -1654152298;
						num11 = -1654152298;
					}
					num = num10 ^ ((int)num2 * -330262364);
					continue;
				}
				case 43u:
				{
					int num8;
					if (num5 == 32)
					{
						num = -1318978625;
						num8 = -1318978625;
					}
					else
					{
						num = -1413442021;
						num8 = -1413442021;
					}
					continue;
				}
				case 42u:
					num = ((int)num2 * -291260918) ^ 0x28EE2078;
					continue;
				case 39u:
					flag = text.Length == 0;
					num = -153873182;
					continue;
				case 38u:
					text2 = string_3;
					goto IL_00a2;
				case 35u:
					num = (int)((num2 * 492036268) ^ 0x5A177595);
					continue;
				case 34u:
					num = ((int)num2 * -741080541) ^ 0x4DE174EE;
					continue;
				case 33u:
				{
					int num6;
					if (num5 == 80)
					{
						num = -34570401;
						num6 = -34570401;
					}
					else
					{
						num = -220749239;
						num6 = -220749239;
					}
					continue;
				}
				case 32u:
				{
					int num23;
					if (num5 != 206)
					{
						num = -692973196;
						num23 = -692973196;
					}
					else
					{
						num = -845658894;
						num23 = -845658894;
					}
					continue;
				}
				case 31u:
					num = ((int)num2 * -660062303) ^ 0x26CE13C9;
					continue;
				case 30u:
				{
					int num19;
					int num20;
					if (num5 <= 15)
					{
						num19 = -46142556;
						num20 = -46142556;
					}
					else
					{
						num19 = -759822857;
						num20 = -759822857;
					}
					num = num19 ^ ((int)num2 * -692709718);
					continue;
				}
				case 25u:
				{
					int num15;
					if (text.Length != 0)
					{
						num = -2011543948;
						num15 = -2011543948;
					}
					else
					{
						num = -1906460242;
						num15 = -1906460242;
					}
					continue;
				}
				case 22u:
					num = ((int)num2 * -1205078716) ^ -982938552;
					continue;
				case 21u:
				{
					int num7;
					if (num5 != 15)
					{
						num = -659567769;
						num7 = -659567769;
					}
					else
					{
						num = -283836970;
						num7 = -283836970;
					}
					continue;
				}
				case 20u:
					if (!flag3)
					{
						num = (int)(num2 * 1780644719) ^ -1425626596;
						continue;
					}
					text2 = GClass41.smethod_12(string_3);
					goto IL_00a2;
				case 19u:
				{
					int num22;
					if (num5 <= 183)
					{
						num = -1427335371;
						num22 = -1427335371;
					}
					else
					{
						num = -1778721096;
						num22 = -1778721096;
					}
					continue;
				}
				case 18u:
					flag2 = text.Length == 0;
					num = -13636545;
					continue;
				case 16u:
				{
					int num21;
					if (num5 != 995)
					{
						num = -1646212482;
						num21 = -1646212482;
					}
					else
					{
						num = -746171659;
						num21 = -746171659;
					}
					continue;
				}
				case 15u:
					num = (int)(num2 * 1278813926) ^ -1595064686;
					continue;
				case 14u:
					num = (int)(num2 * 1925884613) ^ -1236763905;
					continue;
				case 13u:
				{
					int num17;
					int num18;
					if (num5 != 87)
					{
						num17 = 1680373255;
						num18 = 1680373255;
					}
					else
					{
						num17 = 1546458134;
						num18 = 1546458134;
					}
					num = num17 ^ ((int)num2 * -1332244661);
					continue;
				}
				case 12u:
					switch (num5)
					{
					case 5:
						break;
					default:
						goto IL_0297;
					case 4:
						goto IL_045a;
					case 2:
					case 3:
						return;
					}
					goto case 18u;
				case 11u:
					num = ((int)num2 * -1786551134) ^ 0x79C8ABB2;
					continue;
				case 10u:
				{
					int num16;
					if (text.Length == 0)
					{
						num = -515287781;
						num16 = -515287781;
					}
					else
					{
						num = -1360657968;
						num16 = -1360657968;
					}
					continue;
				}
				case 9u:
					num = (int)(num2 * 851462957) ^ -2034958460;
					continue;
				case 5u:
				{
					int num14;
					if (num5 != 183)
					{
						num = -2118552412;
						num14 = -2118552412;
					}
					else
					{
						num = -1839825444;
						num14 = -1839825444;
					}
					continue;
				}
				case 4u:
					num9 = ((int_1 == 161) ? 1 : 0);
					goto IL_031d;
				case 2u:
					num = (int)((num2 * 1362725335) ^ 0x603BB040);
					continue;
				case 1u:
					if (int_1 != 123)
					{
						num = (int)(num2 * 1485558126) ^ -283561300;
						continue;
					}
					num9 = 1;
					goto IL_031d;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1867971335;
						num4 = 1867971335;
					}
					else
					{
						num3 = 2034165007;
						num4 = 2034165007;
					}
					num = num3 ^ (int)(num2 * 691128554);
					continue;
				}
				default:
					return;
				case 29u:
					break;
				case 3u:
					throw new OperationCanceledException();
				case 6u:
					throw new PathTooLongException("Path too long");
				case 8u:
					goto IL_045a;
				case 17u:
					throw new IOException("Sharing violation with empty filename", Class17.smethod_0(int_1));
				case 23u:
					throw new UnauthorizedAccessException($"Access denied accessing {text}");
				case 24u:
					throw new IOException($"File exists {text}", Class17.smethod_0(int_1));
				case 27u:
					throw new UnauthorizedAccessException("Empty path");
				case 36u:
					throw new DriveNotFoundException($"Drive {text} not found");
				case 37u:
					throw new IOException(Class17.smethod_2(int_1), Class17.smethod_0(int_1));
				case 40u:
					throw new IOException($"File {text}", Class17.smethod_0(int_1));
				case 41u:
					throw new IOException($"Sharing violation: {text}", Class17.smethod_0(int_1));
				case 7u:
				case 26u:
				case 28u:
					return;
					IL_031d:
					flag3 = (byte)num9 != 0;
					num = -700403686;
					continue;
					IL_045a:
					throw new IOException(Class17.smethod_2(int_1), Class17.smethod_0(int_1));
					IL_0297:
					num = ((int)num2 * -1469153271) ^ 0x465291FF;
					continue;
					IL_00a2:
					text = text2;
					num5 = int_1;
					num = -309711928;
					continue;
				}
				break;
			}
		}
	}

	public virtual void vmethod_0(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		while (true)
		{
			int num = -1401167007;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE5FBDBBFu) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				serializationInfo_0.AddValue("OriginalPath", string_0, typeof(string));
				serializationInfo_0.AddValue("FullPath", string_1, typeof(string));
				num = (int)(num2 * 1387299621) ^ -1220418823;
			}
		}
	}

	public void method_0()
	{
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected I4, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected I4, but got Unknown
		//IL_0238: Incompatible stack heights: 0 vs 1
		//IL_023f: Incompatible stack heights: 0 vs 1
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected I4, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected I4, but got Unknown
		//IL_0292: Incompatible stack heights: 0 vs 1
		//IL_02b1: Incompatible stack heights: 0 vs 1
		//IL_02c1: Incompatible stack heights: 0 vs 1
		//IL_02f1: Incompatible stack heights: 0 vs 1
		//IL_02fb: Incompatible stack heights: 0 vs 1
		//IL_0305: Incompatible stack heights: 0 vs 1
		try
		{
			string text = default(string);
			while (true)
			{
				int num = -1038438334;
				while (true)
				{
					string text2;
					uint num2;
					switch ((num2 = (uint)num ^ 0xE1B94C19u) % 4u)
					{
					case 3u:
						if (new GClass38(string_1).GClass38_0 != null)
						{
							num = ((int)num2 * -1060128714) ^ 0x3A8434A7;
							continue;
						}
						text2 = GClass41.smethod_6(string_1, "*");
						goto IL_0036;
					case 0u:
						text2 = string_1;
						goto IL_0036;
					case 2u:
						break;
					default:
						{
							Class17.Struct6 struct6_;
							Class19 @class = GClass34.smethod_9(text, out struct6_);
							try
							{
								while (true)
								{
									int num3 = -1746765486;
									while (true)
									{
										switch ((num2 = (uint)num3 ^ 0xE1B94C19u) % 12u)
										{
										case 11u:
											int_0 = Marshal.GetLastWin32Error();
											num3 = (int)((num2 * 1949040411) ^ 0x23F958C2);
											continue;
										case 10u:
											num3 = -1289112440;
											continue;
										case 8u:
											num3 = ((int)num2 * -770328522) ^ 0x27E30CEC;
											continue;
										case 7u:
										{
											int num4;
											int num5;
											if (@class != null)
											{
												num4 = 1911513602;
												num5 = 1911513602;
											}
											else
											{
												num4 = 1018180972;
												num5 = 1018180972;
											}
											num3 = num4 ^ ((int)num2 * -1427863273);
											continue;
										}
										case 6u:
											num3 = (int)((num2 * 1545884704) ^ 0x3245D931);
											continue;
										case 5u:
											genum14_0 = GEnum14.Initialized;
											num3 = (int)(num2 * 738591277) ^ -183662548;
											continue;
										case 4u:
											num3 = (int)((num2 * 129494127) ^ 0x17E7E4E3);
											continue;
										case 2u:
											genum14_0 = GEnum14.Error;
											num3 = (int)(num2 * 1875583321) ^ -2076397768;
											continue;
										case 1u:
											gclass40_0.method_0(struct6_);
											num3 = (int)(num2 * 1328693172) ^ -594278288;
											continue;
										case 0u:
											num3 = (int)((num2 * 1074229249) ^ 0x74B5D8CC);
											continue;
										default:
											return;
										case 3u:
											break;
										case 9u:
											return;
										}
										break;
									}
								}
							}
							finally
							{
								if (@class != null)
								{
									while (true)
									{
										IL_01f5:
										int num6 = -757429806;
										while (true)
										{
											switch ((num2 = (uint)num6 ^ 0xE1B94C19u) % 4u)
											{
											case 3u:
												((IDisposable)@class).Dispose();
												num6 = (int)(num2 * 1821571132) ^ -1474208292;
												continue;
											case 1u:
												num6 = (int)(num2 * 1573328807) ^ -306915000;
												continue;
											default:
												goto end_IL_01d3;
											case 0u:
												break;
											case 2u:
												goto end_IL_01d3;
											}
											goto IL_01f5;
											continue;
											end_IL_01d3:
											break;
										}
										break;
									}
								}
							}
						}
						IL_0036:
						text = GClass41.smethod_0(text2);
						num = -1774906796;
						continue;
					}
					break;
				}
			}
		}
		catch (DirectoryNotFoundException)
		{
			while (true)
			{
				_ = -1937978331;
				while (true)
				{
					_003F val = /*Error near IL_020b: Stack underflow*/^ -507950055;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					case 2:
						genum14_0 = GEnum14.Error;
						_ = (num2 * 2054853371) ^ 0x475CA31F;
						continue;
					case 0:
						break;
					default:
						int_0 = 3;
						return;
					}
					break;
				}
			}
		}
		catch (Exception)
		{
			while (true)
			{
				_ = -911433089;
				while (true)
				{
					_003F val2 = /*Error near IL_0259: Stack underflow*/^ -507950055;
					uint num2 = (uint)(int)val2;
					switch (val2 % 7)
					{
					default:
						return;
					case 5:
						_ = ((int)num2 * -768917664) ^ -1993065353;
						continue;
					case 4:
						GClass33.smethod_13(Marshal.GetLastWin32Error(), string.Empty);
						_ = ((int)num2 * -99077760) ^ -1500009868;
						continue;
					case 2:
						_ = ((int)num2 * -1557089082) ^ -616568415;
						continue;
					case 1:
					{
						int num7;
						int num8;
						if (genum14_0 == GEnum14.Error)
						{
							num7 = -1381485433;
							num8 = -1381485433;
						}
						else
						{
							num7 = -566829574;
							num8 = -566829574;
						}
						_ = (uint)num7 ^ (num2 * 1082270940);
						continue;
					}
					case 0:
						_ = -1148526358;
						continue;
					case 6:
						break;
					case 3:
						return;
					}
					break;
				}
			}
		}
	}

	public abstract void GClass37_002E_200E_206A_206A_206C_206A_206A_206E_206B_200F_200F_202B_200D_206A_206F_200E_200B_206D_200C_206D_206B_200B_202C_202C_206C_206E_206A_206C_206C_202B_206A_202B_206E_200B_202D_202E_206D_206A_202B_200F_200F_202E();
}
