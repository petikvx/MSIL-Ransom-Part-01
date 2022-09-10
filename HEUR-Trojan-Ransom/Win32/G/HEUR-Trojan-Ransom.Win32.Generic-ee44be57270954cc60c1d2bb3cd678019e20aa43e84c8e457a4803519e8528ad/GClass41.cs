using System;
using System.Globalization;
using System.IO;
using System.Text;

public static class GClass41
{
	public static readonly char[] char_0 = Path.GetInvalidPathChars();

	private static readonly char[] char_1;

	internal const string string_0 = "\\\\?\\";

	internal const string string_1 = "\\\\?\\UNC\\";

	public static readonly char char_2;

	public static readonly char char_3;

	public static readonly char char_4;

	public static readonly char char_5;

	internal static string smethod_0(string string_2)
	{
		string result = smethod_1(string_2, "path");
		while (true)
		{
			int num = 552237148;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x58D51DD8u) % 3u)
				{
				case 2u:
					goto IL_000e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000e:
				num = ((int)num2 * -1156545324) ^ 0x3028955;
			}
		}
	}

	internal static string smethod_1(string string_2, string string_3)
	{
		bool flag = string_2 == null;
		string[] array = default(string[]);
		bool flag5 = default(bool);
		bool flag4 = default(bool);
		string result = default(string);
		StringBuilder stringBuilder = default(StringBuilder);
		bool flag6 = default(bool);
		bool flag2 = default(bool);
		uint fullPathName = default(uint);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 627152116;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x4D250AD8u) % 36u)
				{
				case 34u:
					num = (int)((num2 * 563334776) ^ 0x5A42B40D);
					continue;
				case 32u:
				{
					int num19;
					int num20;
					if (flag)
					{
						num19 = 514106289;
						num20 = 514106289;
					}
					else
					{
						num19 = 1760615486;
						num20 = 1760615486;
					}
					num = num19 ^ ((int)num2 * -1767031930);
					continue;
				}
				case 31u:
				{
					int num10;
					int num11;
					if (array.Length >= 2)
					{
						num10 = -135305132;
						num11 = -135305132;
					}
					else
					{
						num10 = -1270241326;
						num11 = -1270241326;
					}
					num = num10 ^ ((int)num2 * -715106831);
					continue;
				}
				case 30u:
					num = ((int)num2 * -1311584655) ^ 0x758F0BBA;
					continue;
				case 28u:
				{
					int num15;
					int num16;
					if (flag5)
					{
						num15 = -415063126;
						num16 = -415063126;
					}
					else
					{
						num15 = -836787386;
						num16 = -836787386;
					}
					num = num15 ^ ((int)num2 * -1297214448);
					continue;
				}
				case 27u:
				{
					int num8;
					int num9;
					if (!flag4)
					{
						num8 = -1856693460;
						num9 = -1856693460;
					}
					else
					{
						num8 = -370829353;
						num9 = -370829353;
					}
					num = num8 ^ ((int)num2 * -205303288);
					continue;
				}
				case 26u:
					result = smethod_5(stringBuilder.ToString());
					num = 768872507;
					continue;
				case 25u:
				{
					int num13;
					int num14;
					if (!flag6)
					{
						num13 = -1753781486;
						num14 = -1753781486;
					}
					else
					{
						num13 = -2046863807;
						num14 = -2046863807;
					}
					num = num13 ^ ((int)num2 * -653829712);
					continue;
				}
				case 24u:
					num = ((int)num2 * -80073520) ^ 0x4B53E4B7;
					continue;
				case 23u:
				{
					int num4;
					int num5;
					if (!flag2)
					{
						num4 = -739195940;
						num5 = -739195940;
					}
					else
					{
						num4 = -1994552081;
						num5 = -1994552081;
					}
					num = num4 ^ (int)(num2 * 977008447);
					continue;
				}
				case 21u:
				{
					int num17;
					int num18;
					if (fullPathName <= stringBuilder.Capacity)
					{
						num17 = 797537515;
						num18 = 797537515;
					}
					else
					{
						num17 = 679843703;
						num18 = 679843703;
					}
					num = num17 ^ (int)(num2 * 335204423);
					continue;
				}
				case 20u:
					flag3 = fullPathName == 0;
					num = 1679167869;
					continue;
				case 19u:
					fullPathName = Class17.GetFullPathName(string_2, fullPathName, stringBuilder, IntPtr.Zero);
					num = (int)(num2 * 33470560) ^ -470583078;
					continue;
				case 18u:
					flag4 = fullPathName < 2;
					num = ((int)num2 * -1972199233) ^ 0x21A10831;
					continue;
				case 16u:
				{
					int num12;
					if (fullPathName > 32000)
					{
						num = 33338014;
						num12 = 33338014;
					}
					else
					{
						num = 1062762084;
						num12 = 1062762084;
					}
					continue;
				}
				case 13u:
					result = smethod_3(string_2);
					num = (int)((num2 * 1764150453) ^ 0x2B096A8E);
					continue;
				case 12u:
					array = stringBuilder.ToString().Split(new char[1] { char_2 }, StringSplitOptions.RemoveEmptyEntries);
					num = 1644914955;
					continue;
				case 11u:
					num = 1992988742;
					continue;
				case 10u:
					stringBuilder = new StringBuilder(string_2.Length + 1);
					fullPathName = Class17.GetFullPathName(string_2, (uint)stringBuilder.Capacity, stringBuilder, IntPtr.Zero);
					num = 1910524749;
					continue;
				case 9u:
					flag6 = GClass33.smethod_17(string_2);
					num = 2064522169;
					continue;
				case 8u:
					if (fullPathName > 1)
					{
						num = 644489937;
						continue;
					}
					goto IL_0296;
				case 7u:
					num = (int)(num2 * 1967800550) ^ -1802032231;
					continue;
				case 6u:
					flag2 = string_2.Length == 0;
					num = 1644054071;
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (!flag3)
					{
						num6 = 921157286;
						num7 = 921157286;
					}
					else
					{
						num6 = 232662616;
						num7 = 232662616;
					}
					num = num6 ^ ((int)num2 * -597772402);
					continue;
				}
				case 3u:
					stringBuilder.Capacity = (int)fullPathName;
					num = ((int)num2 * -651191198) ^ -1588375587;
					continue;
				case 2u:
					num = ((int)num2 * -519685116) ^ 0x403B8054;
					continue;
				case 1u:
					if (stringBuilder[0] == char_2)
					{
						num = (int)((num2 * 38149622) ^ 0x53D228C6);
						continue;
					}
					goto IL_0296;
				case 0u:
					num3 = ((stringBuilder[1] == char_2) ? 1 : 0);
					goto IL_0297;
				case 22u:
					break;
				case 4u:
					throw GClass33.smethod_9(string_3);
				case 14u:
					throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "'{0}' cannot be an empty string.", new object[1] { string_3 }), string_3);
				case 15u:
					throw new ArgumentException("The UNC path should be of the form \\\\server\\share.");
				case 17u:
					throw new ArgumentNullException(string_3);
				case 29u:
					throw new ArgumentException("The UNC path should be of the form \\\\server\\share.");
				case 33u:
					throw GClass33.smethod_11(206, string_3);
				default:
					{
						return result;
					}
					IL_0296:
					num3 = 0;
					goto IL_0297;
					IL_0297:
					flag5 = (byte)num3 != 0;
					num = 199802216;
					continue;
				}
				break;
			}
		}
	}

	internal static bool smethod_2(string string_2, out string string_3)
	{
		bool result = default(bool);
		try
		{
			string_3 = smethod_0(string_2);
			result = true;
			return result;
		}
		catch (ArgumentException)
		{
		}
		catch (PathTooLongException)
		{
		}
		string_3 = null;
		while (true)
		{
			int num = 874148364;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3960886Bu) % 4u)
				{
				case 3u:
					result = false;
					num = ((int)num2 * -241070722) ^ -1445544889;
					continue;
				case 2u:
					num = ((int)num2 * -1278269925) ^ -2007636136;
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

	internal static string smethod_3(string string_2)
	{
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -1574273670;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xC6632A24u) % 11u)
				{
				case 10u:
				{
					int num6;
					if (string_2.Length >= 260)
					{
						num = -1781717493;
						num6 = -1781717493;
					}
					else
					{
						num = -1853803994;
						num6 = -1853803994;
					}
					continue;
				}
				case 7u:
					num = (int)(num2 * 323250521) ^ -1888531848;
					continue;
				case 6u:
					result = smethod_5(string_2);
					num = ((int)num2 * -155323342) ^ 0x73C2A29;
					continue;
				case 5u:
					if (!string.IsNullOrEmpty(string_2))
					{
						num = ((int)num2 * -1138539056) ^ -73051179;
						continue;
					}
					num3 = 1;
					goto IL_0074;
				case 4u:
					num = (int)((num2 * 1604844665) ^ 0x5CD63726);
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (flag)
					{
						num4 = 818162690;
						num5 = 818162690;
					}
					else
					{
						num4 = 679651819;
						num5 = 679651819;
					}
					num = num4 ^ ((int)num2 * -1718191896);
					continue;
				}
				case 2u:
					result = string_2;
					num = -1546679275;
					continue;
				case 1u:
					result = string_2;
					num = (int)(num2 * 1431707036) ^ -1674004601;
					continue;
				case 0u:
					num3 = (string_2.StartsWith("\\\\?\\") ? 1 : 0);
					goto IL_0074;
				case 8u:
					break;
				default:
					{
						return result;
					}
					IL_0074:
					flag = (byte)num3 != 0;
					num = -530961803;
					continue;
				}
				break;
			}
		}
	}

	internal static string smethod_4(string string_2)
	{
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 894516034;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)num ^ 0x19B088EFu) % 11u)
				{
				case 10u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -149986125;
						num6 = -149986125;
					}
					else
					{
						num5 = -1864812746;
						num6 = -1864812746;
					}
					num = num5 ^ ((int)num2 * -1076102170);
					continue;
				}
				case 9u:
					result = string.Format("\\\\{0}", string_2.Substring("\\\\?\\UNC\\".Length));
					num = (int)(num2 * 627173942) ^ -382831048;
					continue;
				case 8u:
					num4 = ((!string_2.StartsWith("\\\\?\\")) ? 1 : 0);
					goto IL_0068;
				case 7u:
					if (!string.IsNullOrEmpty(string_2))
					{
						num = (int)((num2 * 2059135382) ^ 0x597A673F);
						continue;
					}
					num4 = 1;
					goto IL_0068;
				case 6u:
					num = (int)(num2 * 1819622865) ^ -24467327;
					continue;
				case 4u:
					result = string_2.Substring("\\\\?\\".Length);
					num = 1533274912;
					continue;
				case 3u:
				{
					int num3;
					if (!string_2.StartsWith("\\\\?\\UNC\\", StringComparison.InvariantCultureIgnoreCase))
					{
						num = 268887031;
						num3 = 268887031;
					}
					else
					{
						num = 2117195525;
						num3 = 2117195525;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -1808369333) ^ -1960680470;
					continue;
				case 0u:
					result = string_2;
					num = (int)(num2 * 1491182083) ^ -497914082;
					continue;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_0068:
					flag = (byte)num4 != 0;
					num = 1319458597;
					continue;
				}
				break;
			}
		}
	}

	private static string smethod_5(string string_2)
	{
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = -1962915203;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xEAF9CDCEu) % 10u)
				{
				case 8u:
					result = "\\\\?\\UNC\\" + string_2.Substring(2);
					num = ((int)num2 * -1004860568) ^ 0x5DF8AFBC;
					continue;
				case 7u:
					result = string_2;
					num = ((int)num2 * -970031105) ^ -300669661;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = 1877183619;
						num6 = 1877183619;
					}
					else
					{
						num5 = 1346095600;
						num6 = 1346095600;
					}
					num = num5 ^ ((int)num2 * -1181417830);
					continue;
				}
				case 5u:
					if (!string.IsNullOrEmpty(string_2))
					{
						num = ((int)num2 * -753732075) ^ 0x3C18CB68;
						continue;
					}
					num3 = 1;
					goto IL_007a;
				case 4u:
				{
					int num4;
					if (!string_2.StartsWith("\\\\"))
					{
						num = -671583901;
						num4 = -671583901;
					}
					else
					{
						num = -1917726368;
						num4 = -1917726368;
					}
					continue;
				}
				case 3u:
					result = "\\\\?\\" + string_2;
					num = -2086939060;
					continue;
				case 2u:
					num = ((int)num2 * -1813988765) ^ -604631566;
					continue;
				case 1u:
					num3 = (string_2.StartsWith("\\\\?\\") ? 1 : 0);
					goto IL_007a;
				case 9u:
					break;
				default:
					{
						return result;
					}
					IL_007a:
					flag = (byte)num3 != 0;
					num = -1825699224;
					continue;
				}
				break;
			}
		}
	}

	public static string smethod_6(string string_2, string string_3)
	{
		if (string_2 != null)
		{
			goto IL_00d2;
		}
		int num = 1;
		goto IL_02d5;
		IL_02d5:
		bool flag = (byte)num != 0;
		int num2 = -474542425;
		goto IL_0256;
		IL_00d2:
		num2 = -1078929591;
		goto IL_0256;
		IL_0256:
		string result = default(string);
		bool flag3 = default(bool);
		char c = default(char);
		bool flag2 = default(bool);
		while (true)
		{
			uint num3;
			int num11;
			int num6;
			object paramName;
			switch ((num3 = (uint)num2 ^ 0x86DEB883u) % 26u)
			{
			case 25u:
			{
				char c2 = char_2;
				result = string_2 + c2 + string_3;
				num2 = (int)((num3 * 908353600) ^ 0x13AE5297);
				continue;
			}
			case 24u:
			{
				int num12;
				int num13;
				if (!flag3)
				{
					num12 = 2067952973;
					num13 = 2067952973;
				}
				else
				{
					num12 = 184979706;
					num13 = 184979706;
				}
				num2 = num12 ^ ((int)num3 * -538252738);
				continue;
			}
			case 23u:
				num11 = (smethod_7(string_3) ? 1 : 0);
				goto IL_006a;
			case 22u:
				result = string_2 + string_3;
				num2 = -750859118;
				continue;
			case 21u:
				result = string_2;
				num2 = ((int)num3 * -18004228) ^ -2137915790;
				continue;
			case 20u:
				num2 = (int)((num3 * 57648077) ^ 0x15221788);
				continue;
			case 19u:
				smethod_10(string_2);
				num2 = -1307201943;
				continue;
			case 18u:
				num2 = (int)((num3 * 121407854) ^ 0x2E1876EC);
				continue;
			case 17u:
				break;
			case 16u:
				if (c != char_3)
				{
					num2 = (int)((num3 * 968942565) ^ 0x157241A2);
					continue;
				}
				goto IL_00f8;
			case 15u:
				smethod_10(string_3);
				num2 = (int)(num3 * 1546325970) ^ -886626645;
				continue;
			case 14u:
				num2 = (int)((num3 * 1167269621) ^ 0x36E9CEE4);
				continue;
			case 13u:
				if (string_2.Length != 0)
				{
					num2 = -370043260;
					continue;
				}
				num11 = 1;
				goto IL_006a;
			case 11u:
				num2 = (int)((num3 * 382429434) ^ 0x27762056);
				continue;
			case 10u:
			{
				int num9;
				int num10;
				if (!flag)
				{
					num9 = -812362204;
					num10 = -812362204;
				}
				else
				{
					num9 = -1137150609;
					num10 = -1137150609;
				}
				num2 = num9 ^ (int)(num3 * 1830552829);
				continue;
			}
			case 9u:
				result = string_3;
				num2 = ((int)num3 * -34794463) ^ 0x58E517EC;
				continue;
			case 8u:
			{
				int num7;
				int num8;
				if (string_3.Length == 0)
				{
					num7 = -1375160512;
					num8 = -1375160512;
				}
				else
				{
					num7 = -954688176;
					num8 = -954688176;
				}
				num2 = num7 ^ (int)(num3 * 1503831287);
				continue;
			}
			case 7u:
				num6 = ((c != char_4) ? 1 : 0);
				goto IL_00f9;
			case 6u:
				if (string_2 != null)
				{
					num2 = (int)(num3 * 353551850) ^ -1474063635;
					continue;
				}
				paramName = "path1";
				goto IL_02ec;
			case 5u:
			{
				int num4;
				int num5;
				if (flag2)
				{
					num4 = 2013138427;
					num5 = 2013138427;
				}
				else
				{
					num4 = 1814732082;
					num5 = 1814732082;
				}
				num2 = num4 ^ ((int)num3 * -1749440683);
				continue;
			}
			case 4u:
				num2 = ((int)num3 * -1258138656) ^ -31816107;
				continue;
			case 1u:
				num2 = (int)((num3 * 632374798) ^ 0x2260683A);
				continue;
			case 0u:
				c = string_2[string_2.Length - 1];
				if (c != char_2)
				{
					num2 = -1843099707;
					continue;
				}
				goto IL_00f8;
			case 2u:
				goto IL_02d1;
			case 12u:
				paramName = "path2";
				goto IL_02ec;
			default:
				{
					return result;
				}
				IL_00f8:
				num6 = 0;
				goto IL_00f9;
				IL_00f9:
				flag3 = (byte)num6 != 0;
				num2 = -1197425045;
				continue;
				IL_02ec:
				throw new ArgumentNullException((string?)paramName);
				IL_006a:
				flag2 = (byte)num11 != 0;
				num2 = -884537176;
				continue;
			}
			break;
		}
		goto IL_00d2;
		IL_02d1:
		num = ((string_3 == null) ? 1 : 0);
		goto IL_02d5;
	}

	public static bool smethod_7(string string_2)
	{
		bool result = default(bool);
		while (true)
		{
			int num = 1624419579;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6DF47BC9u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = Path.IsPathRooted(string_2);
				num = (int)((num2 * 893019645) ^ 0x1C625BB5);
			}
		}
	}

	public static string smethod_8(string string_2, string string_3, string string_4)
	{
		string result = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num = 192497308;
			while (true)
			{
				uint num2;
				object paramName;
				int num5;
				switch ((num2 = (uint)num ^ 0x3196CB28u) % 11u)
				{
				case 10u:
					if (string_3 != null)
					{
						num = (int)((num2 * 739270854) ^ 0x619951AE);
						continue;
					}
					paramName = "path2";
					goto IL_0101;
				case 9u:
					num5 = ((string_4 == null) ? 1 : 0);
					goto IL_0022;
				case 8u:
					if (string_2 != null)
					{
						num = ((int)num2 * -1101145511) ^ -1106727229;
						continue;
					}
					goto IL_003c;
				case 7u:
					num = ((int)num2 * -1769486750) ^ -1643544473;
					continue;
				case 5u:
					result = smethod_6(smethod_6(string_2, string_3), string_4);
					num = 1377668954;
					continue;
				case 4u:
					if (string_3 != null)
					{
						num = ((int)num2 * -1435686535) ^ 0x316996EF;
						continue;
					}
					goto IL_003c;
				case 3u:
					if (string_2 != null)
					{
						num = ((int)num2 * -1664244948) ^ 0x7E5014F4;
						continue;
					}
					paramName = "path1";
					goto IL_0101;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -6690889;
						num4 = -6690889;
					}
					else
					{
						num3 = -1111585500;
						num4 = -1111585500;
					}
					num = num3 ^ (int)(num2 * 791725050);
					continue;
				}
				case 2u:
					break;
				case 6u:
					paramName = "path3";
					goto IL_0101;
				default:
					{
						return result;
					}
					IL_0101:
					throw new ArgumentNullException((string?)paramName);
					IL_003c:
					num5 = 1;
					goto IL_0022;
					IL_0022:
					flag = (byte)num5 != 0;
					num = 707896729;
					continue;
				}
				break;
			}
		}
	}

	public static string smethod_9(string string_2, string string_3, string string_4, string string_5)
	{
		if (string_2 == null)
		{
			goto IL_0008;
		}
		goto IL_0018;
		IL_0008:
		int num = 1278269339;
		int num2 = 1278269339;
		goto IL_009b;
		IL_009b:
		string result = default(string);
		while (true)
		{
			uint num3;
			object paramName;
			switch ((num3 = (uint)num ^ 0x5439D6F9u) % 10u)
			{
			case 9u:
				break;
			case 8u:
				goto IL_001f;
			case 5u:
				goto IL_0034;
			case 4u:
				result = smethod_6(smethod_6(smethod_6(string_2, string_3), string_4), string_5);
				num = 1783351847;
				continue;
			case 2u:
				if (string_2 != null)
				{
					num = ((int)num3 * -134989896) ^ 0x920D000;
					continue;
				}
				paramName = "path1";
				goto IL_010e;
			case 1u:
				if (string_3 != null)
				{
					num = (int)(num3 * 1322932724) ^ -1095722009;
					continue;
				}
				paramName = "path2";
				goto IL_010e;
			case 0u:
				if (string_4 != null)
				{
					num = (int)((num3 * 88311081) ^ 0x775E4DEE);
					continue;
				}
				paramName = "path3";
				goto IL_010e;
			case 7u:
				goto IL_00d5;
			case 3u:
				paramName = "path4";
				goto IL_010e;
			default:
				{
					return result;
				}
				IL_010e:
				throw new ArgumentNullException((string?)paramName);
			}
			break;
			IL_00d5:
			if (string_5 != null)
			{
				num = 1628644303;
				num2 = 1628644303;
				continue;
			}
			goto IL_0008;
			IL_001f:
			if (string_3 != null)
			{
				num = (int)((num3 * 45146869) ^ 0x100380EA);
				continue;
			}
			goto IL_0008;
			IL_0034:
			if (string_4 != null)
			{
				num = ((int)num3 * -1066742151) ^ -66924667;
				continue;
			}
			goto IL_0008;
		}
		goto IL_0018;
		IL_0018:
		num = 930925775;
		goto IL_009b;
	}

	private static void smethod_10(string string_2)
	{
		if (smethod_11(string_2))
		{
			throw new ArgumentException("Invalid characters in path", "path");
		}
	}

	private static bool smethod_11(string string_2)
	{
		int num5 = default(int);
		bool result = default(bool);
		char gparam_ = default(char);
		string text = default(string);
		while (true)
		{
			int num = 1590654477;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C44F13Cu) % 16u)
				{
				case 15u:
					num = 1236094484;
					continue;
				case 14u:
					num5 = 0;
					num = (int)(num2 * 1282401938) ^ -834940133;
					continue;
				case 13u:
					result = false;
					num = ((int)num2 * -774785092) ^ 0x1D04BD82;
					continue;
				case 12u:
					result = true;
					num = ((int)num2 * -563341821) ^ -2062432483;
					continue;
				case 11u:
					num = ((int)num2 * -1173018149) ^ -1218627306;
					continue;
				case 10u:
					num = ((int)num2 * -1143230386) ^ 0x31E96CB0;
					continue;
				case 8u:
					num5++;
					num = (int)((num2 * 1798854441) ^ 0x3D59DC87);
					continue;
				case 7u:
					gparam_ = text[num5];
					num = 1146229270;
					continue;
				case 5u:
					num = ((int)num2 * -1214545827) ^ 0x2B1B544;
					continue;
				case 4u:
					num = ((int)num2 * -269369658) ^ 0x37FAE918;
					continue;
				case 3u:
				{
					int num6;
					if (num5 >= text.Length)
					{
						num = 59638625;
						num6 = 59638625;
					}
					else
					{
						num = 1235090315;
						num6 = 1235090315;
					}
					continue;
				}
				case 2u:
					num = (int)((num2 * 785764681) ^ 0x3E679BE7);
					continue;
				case 1u:
					text = string_2;
					num = (int)((num2 * 541699046) ^ 0x1AA5CBE4);
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (GClass43.smethod_1(char_0, gparam_))
					{
						num3 = -84290376;
						num4 = -84290376;
					}
					else
					{
						num3 = -1888779181;
						num4 = -1888779181;
					}
					num = num3 ^ ((int)num2 * -1915667623);
					continue;
				}
				case 6u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static string smethod_12(string string_2)
	{
		string fileName = Path.GetFileName(smethod_0(string_2));
		while (true)
		{
			int num = 653192073;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x317B8584u) % 3u)
				{
				case 1u:
					goto IL_000e;
				case 0u:
					break;
				default:
					return fileName;
				}
				break;
				IL_000e:
				num = (int)(num2 * 864236452) ^ -721170104;
			}
		}
	}

	public static string smethod_13(string string_2)
	{
		if (!GClass33.smethod_17(string_2))
		{
			goto IL_001a;
		}
		string text = string_2;
		goto IL_004b;
		IL_0040:
		text = smethod_4(smethod_0(string_2));
		goto IL_004b;
		IL_001a:
		int num = -378502530;
		goto IL_001f;
		IL_001f:
		string result = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x9E9E9260u) % 4u)
			{
			case 3u:
				num = ((int)num2 * -1745861178) ^ -674420593;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_0040;
			default:
				return result;
			}
			break;
		}
		goto IL_001a;
		IL_004b:
		result = text;
		num = -1725129897;
		goto IL_001f;
	}

	public static string smethod_14(string string_2)
	{
		bool flag3 = default(bool);
		string text2 = default(string);
		int num3 = default(int);
		int num7 = default(int);
		bool flag2 = default(bool);
		bool flag = default(bool);
		string result = default(string);
		while (true)
		{
			int num = 39632116;
			while (true)
			{
				uint num2;
				int num8;
				switch ((num2 = (uint)num ^ 0x5F9E3B22u) % 26u)
				{
				case 25u:
				{
					int num15;
					int num16;
					if (flag3)
					{
						num15 = -525366805;
						num16 = -525366805;
					}
					else
					{
						num15 = -1924493324;
						num16 = -1924493324;
					}
					num = num15 ^ (int)(num2 * 1936233199);
					continue;
				}
				case 24u:
				{
					int num13;
					int num14;
					if (string_2 != null)
					{
						num13 = -1646126135;
						num14 = -1646126135;
					}
					else
					{
						num13 = -135677609;
						num14 = -135677609;
					}
					num = num13 ^ ((int)num2 * -1555153255);
					continue;
				}
				case 23u:
					text2 = Directory.GetCurrentDirectory();
					num = ((int)num2 * -1560123556) ^ -281292682;
					continue;
				case 22u:
					text2 = null;
					num = ((int)num2 * -1075604773) ^ -363450567;
					continue;
				case 21u:
					num3 = 0;
					num = ((int)num2 * -977847092) ^ -409718791;
					continue;
				case 20u:
					num = 1398866043;
					continue;
				case 19u:
					num = (int)((num2 * 1202478970) ^ 0x7844778C);
					continue;
				case 18u:
					string_2 = smethod_4(smethod_0(string_2));
					num = 128484579;
					continue;
				case 17u:
					num7 = smethod_16(string_2);
					flag3 = string_2.Length <= num7;
					num = ((int)num2 * -1230851679) ^ -1811018492;
					continue;
				case 16u:
					string_2 = string_2.Substring(text2.Length + 1);
					num3 = num3 - text2.Length - 1;
					flag2 = num3 < 0;
					num = ((int)num2 * -2017833555) ^ -1093377201;
					continue;
				case 15u:
					flag = !smethod_7(string_2);
					num = ((int)num2 * -834690857) ^ 0x641963A;
					continue;
				case 14u:
				{
					int num11;
					int num12;
					if (text2 != null)
					{
						num11 = 432259832;
						num12 = 432259832;
					}
					else
					{
						num11 = 1657289228;
						num12 = 1657289228;
					}
					num = num11 ^ ((int)num2 * -1584779337);
					continue;
				}
				case 13u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = -635728170;
						num10 = -635728170;
					}
					else
					{
						num9 = -984822506;
						num10 = -984822506;
					}
					num = num9 ^ ((int)num2 * -203636423);
					continue;
				}
				case 12u:
					result = string_2.Substring(0, num3);
					num = 2066812497;
					continue;
				case 11u:
					smethod_10(string_2);
					num = 882438954;
					continue;
				case 10u:
					if (string_2[num3] != Path.AltDirectorySeparatorChar)
					{
						num = 894949236;
						num8 = 894949236;
						continue;
					}
					goto IL_01e7;
				case 8u:
					num = (int)((num2 * 126159988) ^ 0x561D76D9);
					continue;
				case 7u:
					num3 = string_2.Length;
					num = 894949236;
					continue;
				case 6u:
					if (num3 > num7)
					{
						num = (int)(num2 * 2018075609) ^ -363914840;
						continue;
					}
					goto IL_01e7;
				case 5u:
				{
					int num5;
					int num6;
					if (flag)
					{
						num5 = -1410180948;
						num6 = -1410180948;
					}
					else
					{
						num5 = -407249101;
						num6 = -407249101;
					}
					num = num5 ^ ((int)num2 * -1251029355);
					continue;
				}
				case 4u:
					result = null;
					num = ((int)num2 * -1422612717) ^ -264416600;
					continue;
				case 2u:
				{
					string text = string_2;
					int num4 = num3 - 1;
					num3 = num4;
					if (text[num4] != Path.DirectorySeparatorChar)
					{
						num = ((int)num2 * -2063542702) ^ 0x1E590D32;
						continue;
					}
					goto IL_01e7;
				}
				case 1u:
					num = 583152448;
					continue;
				case 0u:
					break;
				case 3u:
					throw new ArgumentNullException("path");
				default:
					{
						return result;
					}
					IL_01e7:
					num = 1453855286;
					num8 = 1453855286;
					continue;
				}
				break;
			}
		}
	}

	private static int smethod_15(string string_2)
	{
		string[] array = string_2.Split(new char[1] { char_2 }, StringSplitOptions.RemoveEmptyEntries);
		string text = $"\\\\{array[0]}\\{array[1]}\\";
		int length = default(int);
		while (true)
		{
			int num = 2032907790;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23DC4DA7u) % 3u)
				{
				case 1u:
					goto IL_0031;
				case 0u:
					break;
				default:
					return length;
				}
				break;
				IL_0031:
				length = text.Length;
				num = (int)((num2 * 25435763) ^ 0x3B1D8A3F);
			}
		}
	}

	internal static int smethod_16(string string_2)
	{
		bool flag = GClass33.smethod_17(string_2);
		int num3 = default(int);
		int result = default(int);
		int length = default(int);
		int num10 = default(int);
		int num11 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -844355027;
			while (true)
			{
				uint num2;
				int num5;
				int num15;
				int num4;
				int num16;
				int num12;
				switch ((num2 = (uint)num ^ 0xA92FFFAAu) % 35u)
				{
				case 34u:
				{
					int num6;
					int num7;
					if (string_2[num3] != Path.DirectorySeparatorChar)
					{
						num6 = -1931096403;
						num7 = -1931096403;
					}
					else
					{
						num6 = -2108192968;
						num7 = -2108192968;
					}
					num = num6 ^ ((int)num2 * -972442832);
					continue;
				}
				case 33u:
					num = ((int)num2 * -2064217095) ^ -49236692;
					continue;
				case 32u:
					if (smethod_17(string_2[0]))
					{
						num = -1477203361;
						num5 = -1477203361;
						continue;
					}
					goto IL_0060;
				case 31u:
					num = ((int)num2 * -1043781411) ^ 0x2E0EE2FF;
					continue;
				case 30u:
					result = num3;
					num = -1334353095;
					continue;
				case 29u:
					num3 = 0;
					length = string_2.Length;
					if (length >= 1)
					{
						num = ((int)num2 * -1819193833) ^ -1009390009;
						continue;
					}
					goto IL_0060;
				case 28u:
					num10 = num11;
					num = ((int)num2 * -1660327753) ^ 0x34C61916;
					continue;
				case 27u:
					num15 = (smethod_17(string_2[1]) ? 1 : 0);
					goto IL_00e1;
				case 26u:
					num10 = 2;
					num = (int)((num2 * 689951130) ^ 0x4459EC0F);
					continue;
				case 25u:
					num = -1737170140;
					continue;
				case 24u:
					num3 = 1;
					num = (int)((num2 * 1395132017) ^ 0x23FC1EC3);
					continue;
				case 23u:
					num3 = num11;
					num = ((int)num2 * -2094279365) ^ -54118482;
					continue;
				case 22u:
					num3 = 2;
					num = ((int)num2 * -196626531) ^ 0x296B7895;
					continue;
				case 21u:
					num11 = num10 - 1;
					num = -1246379985;
					continue;
				case 19u:
				{
					int num17;
					int num18;
					if (flag)
					{
						num17 = -342357763;
						num18 = -342357763;
					}
					else
					{
						num17 = -757893283;
						num18 = -757893283;
					}
					num = num17 ^ (int)(num2 * 1940446208);
					continue;
				}
				case 18u:
					num11 = num3 + 1;
					num = (int)(num2 * 1417150941) ^ -2115850378;
					continue;
				case 17u:
					num = (int)((num2 * 1143670031) ^ 0xDC1439F);
					continue;
				case 16u:
					if (length >= 2)
					{
						num = ((int)num2 * -1136477235) ^ 0x13534F34;
						continue;
					}
					num15 = 0;
					goto IL_00e1;
				case 15u:
					if (string_2[num3] == Path.AltDirectorySeparatorChar)
					{
						num = ((int)num2 * -1443947674) ^ 0x4BAC6192;
						continue;
					}
					num4 = 0;
					goto IL_01ef;
				case 14u:
					num11 = num3 + 1;
					num = -2058076015;
					continue;
				case 13u:
					if (smethod_17(string_2[2]))
					{
						num = -267600758;
						num16 = -267600758;
						continue;
					}
					goto IL_0224;
				case 12u:
				{
					int num13;
					int num14;
					if (!flag3)
					{
						num13 = -1366228644;
						num14 = -1366228644;
					}
					else
					{
						num13 = -1269442790;
						num14 = -1269442790;
					}
					num = num13 ^ (int)(num2 * 1781787902);
					continue;
				}
				case 11u:
					string_2 = smethod_13(string_2);
					smethod_10(string_2);
					num = -1260590341;
					continue;
				case 10u:
					num = -620716481;
					continue;
				case 9u:
					num4 = ((num11 <= 0) ? 1 : 0);
					goto IL_01ef;
				case 8u:
					result = smethod_15(string_2);
					num = (int)((num2 * 346386439) ^ 0x572FD458);
					continue;
				case 7u:
					num3 = num11;
					num = ((int)num2 * -1262130911) ^ -2093175797;
					continue;
				case 5u:
					num = ((int)num2 * -1078899374) ^ -1854828526;
					continue;
				case 4u:
					num3 = 2;
					if (length >= 3)
					{
						num = ((int)num2 * -1436156242) ^ -415760990;
						continue;
					}
					goto IL_0224;
				case 3u:
					if (string_2[1] == Path.VolumeSeparatorChar)
					{
						num = -1176690348;
						num12 = -1176690348;
						continue;
					}
					goto IL_0307;
				case 2u:
					if (length >= 2)
					{
						num = -511588649;
						continue;
					}
					goto IL_0307;
				case 1u:
				{
					int num8;
					int num9;
					if (flag2)
					{
						num8 = 1191952266;
						num9 = 1191952266;
					}
					else
					{
						num8 = 637418760;
						num9 = 637418760;
					}
					num = num8 ^ ((int)num2 * -1364293018);
					continue;
				}
				case 0u:
					if (num3 < length)
					{
						num = -1403643236;
						continue;
					}
					num4 = 1;
					goto IL_01ef;
				case 20u:
					break;
				default:
					{
						return result;
					}
					IL_0060:
					num = -2076262314;
					num5 = -2076262314;
					continue;
					IL_0307:
					num = -1737170140;
					num12 = -1737170140;
					continue;
					IL_00e1:
					flag2 = (byte)num15 != 0;
					num = -1958827415;
					continue;
					IL_0224:
					num = -623818438;
					num16 = -623818438;
					continue;
					IL_01ef:
					flag3 = (byte)num4 != 0;
					num = -1155548747;
					continue;
				}
				break;
			}
		}
	}

	internal static bool smethod_17(char char_6)
	{
		bool result = default(bool);
		while (true)
		{
			int num = -1281015079;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xA839A5F9u) % 5u)
				{
				case 4u:
					num = (int)(num2 * 1734226122) ^ -1863859746;
					continue;
				case 1u:
					if (char_6 != char_2)
					{
						num = (int)((num2 * 957978892) ^ 0x141EB2FB);
						continue;
					}
					num3 = 1;
					goto IL_002a;
				case 0u:
					num3 = ((char_6 == char_3) ? 1 : 0);
					goto IL_002a;
				case 2u:
					break;
				default:
					{
						return result;
					}
					IL_002a:
					result = (byte)num3 != 0;
					num = -561194480;
					continue;
				}
				break;
			}
		}
	}

	public static char[] smethod_18()
	{
		char[] result = default(char[]);
		while (true)
		{
			int num = -1458470856;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9DC718DDu) % 4u)
				{
				case 3u:
					num = (int)((num2 * 1623238601) ^ 0x771D14AA);
					continue;
				case 1u:
					result = char_0;
					num = ((int)num2 * -1884375734) ^ 0x616554E0;
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

	public static char[] smethod_19()
	{
		return char_1;
	}

	public static string smethod_20()
	{
		string randomFileName = default(string);
		while (true)
		{
			int num = -880487818;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF3AB4765u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return randomFileName;
				}
				break;
				IL_0003:
				randomFileName = Path.GetRandomFileName();
				num = ((int)num2 * -762032398) ^ -1654499129;
			}
		}
	}

	public static string smethod_21(string string_2)
	{
		if (string_2 == null)
		{
			goto IL_0023;
		}
		goto IL_011b;
		IL_011b:
		bool flag = smethod_7(string_2);
		int num = -21971795;
		goto IL_00dc;
		IL_00dc:
		string result = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xF70C4DACu) % 11u)
			{
			case 10u:
				result = string_2.Substring(0, smethod_16(string_2));
				num = -858181590;
				continue;
			case 9u:
				break;
			case 8u:
			{
				int num5;
				int num6;
				if (flag)
				{
					num5 = -1617472897;
					num6 = -1617472897;
				}
				else
				{
					num5 = -1369553806;
					num6 = -1369553806;
				}
				num = num5 ^ (int)(num2 * 206805039);
				continue;
			}
			case 7u:
				string_2 = smethod_4(smethod_0(string_2));
				num = ((int)num2 * -391947590) ^ -939414514;
				continue;
			case 6u:
				result = string.Empty;
				num = -525372800;
				continue;
			case 5u:
				num = (int)(num2 * 1864988825) ^ -223878619;
				continue;
			case 3u:
			{
				int num3;
				int num4;
				if (GClass33.smethod_17(string_2))
				{
					num3 = -1795098138;
					num4 = -1795098138;
				}
				else
				{
					num3 = -299176260;
					num4 = -299176260;
				}
				num = num3 ^ ((int)num2 * -2027924638);
				continue;
			}
			case 1u:
				result = null;
				num = (int)((num2 * 739334467) ^ 0x24002A8A);
				continue;
			case 0u:
				num = ((int)num2 * -875240748) ^ 0x29BC185A;
				continue;
			case 2u:
				goto IL_011b;
			default:
				return result;
			}
			break;
		}
		goto IL_0023;
		IL_0023:
		num = -575154937;
		goto IL_00dc;
	}

	public static string smethod_22(string string_2)
	{
		string extension = Path.GetExtension(string_2);
		while (true)
		{
			int num = 2107791395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69B2971Du) % 3u)
				{
				case 2u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return extension;
				}
				break;
				IL_0009:
				num = ((int)num2 * -1097079623) ^ -1100238143;
			}
		}
	}

	public static bool smethod_23(string string_2)
	{
		bool result = Path.HasExtension(string_2);
		while (true)
		{
			int num = -1353965903;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDFA5DF55u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0009:
				num = ((int)num2 * -1794472150) ^ -1871724212;
			}
		}
	}

	public static string smethod_24()
	{
		string tempPath = Path.GetTempPath();
		while (true)
		{
			int num = -1303442626;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9450B0ECu) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					return tempPath;
				}
				break;
				IL_0008:
				num = (int)(num2 * 876681356) ^ -1663439289;
			}
		}
	}

	public static string smethod_25()
	{
		string tempFileName = Path.GetTempFileName();
		while (true)
		{
			int num = 1204814919;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2EC40523u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
					return tempFileName;
				}
				break;
				IL_0008:
				num = ((int)num2 * -35744605) ^ -1106905159;
			}
		}
	}

	public static string smethod_26(string string_2)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(string_2);
		while (true)
		{
			int num = -1767381234;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC4683B19u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 2u:
					break;
				default:
					return fileNameWithoutExtension;
				}
				break;
				IL_0009:
				num = ((int)num2 * -928567493) ^ 0x155220B3;
			}
		}
	}

	public static string smethod_27(string string_2, string string_3)
	{
		string result = Path.ChangeExtension(string_2, string_3);
		while (true)
		{
			int num = -451121438;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC74315E6u) % 3u)
				{
				case 1u:
					goto IL_000a;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000a:
				num = (int)((num2 * 1706984222) ^ 0x720A05AB);
			}
		}
	}

	public static string smethod_28(string[] string_2)
	{
		bool flag = string_2 == null;
		int num5 = default(int);
		bool flag3 = default(bool);
		string result = default(string);
		int num6 = default(int);
		string text = default(string);
		bool flag2 = default(bool);
		while (true)
		{
			int num = -2124612969;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB8FAE348u) % 20u)
				{
				case 19u:
					num5 = 1;
					num = (int)((num2 * 234905611) ^ 0x1F6CCF71);
					continue;
				case 18u:
				{
					int num10;
					int num11;
					if (flag3)
					{
						num10 = -1414472222;
						num11 = -1414472222;
					}
					else
					{
						num10 = -1796529829;
						num11 = -1796529829;
					}
					num = num10 ^ (int)(num2 * 1251871921);
					continue;
				}
				case 17u:
					result = string_2[0];
					num = (int)(num2 * 1267106746) ^ -1316366329;
					continue;
				case 16u:
				{
					int num7;
					if (string_2.Length != 0)
					{
						num = -1369828053;
						num7 = -1369828053;
					}
					else
					{
						num = -1397314090;
						num7 = -1397314090;
					}
					continue;
				}
				case 15u:
					num6 = num5 + 1;
					num = ((int)num2 * -1701560699) ^ -166483435;
					continue;
				case 13u:
					flag3 = num5 < string_2.Length;
					num = -1866231870;
					continue;
				case 12u:
					num = ((int)num2 * -1121712434) ^ -1571024507;
					continue;
				case 11u:
				{
					int num8;
					int num9;
					if (!flag)
					{
						num8 = -1178557880;
						num9 = -1178557880;
					}
					else
					{
						num8 = -1658584733;
						num9 = -1658584733;
					}
					num = num8 ^ ((int)num2 * -686415996);
					continue;
				}
				case 10u:
					num5 = num6;
					num = (int)((num2 * 1168805989) ^ 0x20EAB133);
					continue;
				case 9u:
					result = text;
					num = (int)(num2 * 670315728) ^ -298376091;
					continue;
				case 8u:
					text = smethod_6(text, string_2[num5]);
					num = -765303753;
					continue;
				case 7u:
					flag2 = string_2.Length == 1;
					num = -1077289056;
					continue;
				case 6u:
					text = string_2[0];
					num = -266425817;
					continue;
				case 5u:
					num = ((int)num2 * -1557608616) ^ -2049328316;
					continue;
				case 2u:
					result = string.Empty;
					num = ((int)num2 * -2021931720) ^ -1733042644;
					continue;
				case 1u:
					num = ((int)num2 * -853998054) ^ 0x6DD2A1EE;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag2)
					{
						num3 = 1904217834;
						num4 = 1904217834;
					}
					else
					{
						num3 = 1582702021;
						num4 = 1582702021;
					}
					num = num3 ^ (int)(num2 * 841447327);
					continue;
				}
				case 14u:
					break;
				case 3u:
					throw new ArgumentNullException("paths");
				default:
					return result;
				}
				break;
			}
		}
	}

	static GClass41()
	{
		while (true)
		{
			int num = -616133182;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85430BB5u) % 3u)
				{
				case 1u:
					goto IL_000c;
				case 0u:
					break;
				default:
					char_3 = Path.AltDirectorySeparatorChar;
					char_4 = ':';
					char_5 = Path.PathSeparator;
					return;
				}
				break;
				IL_000c:
				char_1 = Path.GetInvalidFileNameChars();
				char_2 = Path.DirectorySeparatorChar;
				num = (int)(num2 * 255883879) ^ -2135564710;
			}
		}
	}
}
