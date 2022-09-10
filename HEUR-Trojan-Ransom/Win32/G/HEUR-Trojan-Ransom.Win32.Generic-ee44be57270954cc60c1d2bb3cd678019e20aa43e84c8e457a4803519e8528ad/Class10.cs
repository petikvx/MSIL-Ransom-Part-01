#define TRACE
using System;
using System.Diagnostics;
using System.Text;

internal static class Class10
{
	private const long long_0 = 621355968000000000L;

	internal static byte[] smethod_0(string string_0, bool bool_0)
	{
		if (!string_0.EndsWith("."))
		{
			goto IL_0074;
		}
		goto IL_021a;
		IL_021a:
		int num;
		int num2;
		if (!(string_0 == "."))
		{
			num = -1537188009;
			num2 = -1537188009;
		}
		else
		{
			num = -281384184;
			num2 = -281384184;
		}
		goto IL_01ad;
		IL_01ad:
		StringBuilder stringBuilder = default(StringBuilder);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x96EECBA3u) % 19u)
			{
			case 18u:
				num = (int)((num3 * 719349250) ^ 0x672B8572);
				continue;
			case 17u:
				string_0 += ".";
				num = ((int)num3 * -417730959) ^ 0x643C0CE3;
				continue;
			case 16u:
				stringBuilder[stringBuilder.Length - 1] = '\0';
				num = ((int)num3 * -831158767) ^ -222274608;
				continue;
			case 15u:
				break;
			case 14u:
				stringBuilder = new StringBuilder();
				num = -645252861;
				continue;
			case 13u:
				stringBuilder.Append(char.ToLower(string_0[num4]));
				num = ((int)num3 * -1262239117) ^ -123330860;
				continue;
			case 11u:
				num5 = -1;
				num = ((int)num3 * -1130901006) ^ 0x792946BD;
				continue;
			case 10u:
				goto IL_00c7;
			case 9u:
				stringBuilder.Append('\0');
				num = (int)(num3 * 705097085) ^ -1371093428;
				continue;
			case 8u:
				stringBuilder.Append(string_0[num4]);
				num = -110429904;
				continue;
			case 7u:
				num4 = 0;
				num5 = 0;
				num = ((int)num3 * -158115642) ^ 0x22CE78E2;
				continue;
			case 6u:
				num = ((int)num3 * -1542922290) ^ 0x66E336BA;
				continue;
			case 5u:
				stringBuilder[num4 - num5] = (char)((uint)num5 & 0xFFu);
				num = ((int)num3 * -719961641) ^ -1629757953;
				continue;
			case 4u:
				num4++;
				num5++;
				num = -1830278716;
				continue;
			case 1u:
				goto IL_016f;
			case 0u:
				goto IL_0193;
			case 2u:
				goto IL_021a;
			case 3u:
				return new byte[1];
			default:
				return Encoding.ASCII.GetBytes(stringBuilder.ToString());
			}
			break;
			IL_0193:
			int num6;
			if (bool_0)
			{
				num = -1218703025;
				num6 = -1218703025;
			}
			else
			{
				num = -1404413585;
				num6 = -1404413585;
			}
			continue;
			IL_016f:
			int num7;
			if (string_0[num4] != '.')
			{
				num = -566019103;
				num7 = -566019103;
			}
			else
			{
				num = -333949523;
				num7 = -333949523;
			}
			continue;
			IL_00c7:
			int num8;
			if (num4 >= string_0.Length)
			{
				num = -97800486;
				num8 = -97800486;
			}
			else
			{
				num = -1075046781;
				num8 = -1075046781;
			}
		}
		goto IL_0074;
		IL_0074:
		num = -1414329200;
		goto IL_01ad;
	}

	internal static string smethod_1(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("[");
		byte[] array = default(byte[]);
		int num3 = default(int);
		byte b = default(byte);
		while (true)
		{
			int num = -1378714162;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA9F596F2u) % 9u)
				{
				case 8u:
					array = byte_0;
					num = (int)((num2 * 1666411103) ^ 0x90D994A);
					continue;
				case 7u:
					num3 = 0;
					num = ((int)num2 * -1771149946) ^ 0x571C5DBE;
					continue;
				case 6u:
					num3++;
					num = (int)((num2 * 1707605756) ^ 0x3994CA86);
					continue;
				case 5u:
					b = array[num3];
					num = -987437842;
					continue;
				case 3u:
					stringBuilder.Append(" ");
					num = ((int)num2 * -775472245) ^ 0x4BB85F8B;
					continue;
				case 2u:
					stringBuilder.Append((sbyte)b);
					stringBuilder.Append(" ");
					num = (int)(num2 * 1819603873) ^ -928725677;
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = -194770803;
						num4 = -194770803;
					}
					else
					{
						num = -2132202449;
						num4 = -2132202449;
					}
					continue;
				}
				case 0u:
					break;
				default:
					stringBuilder.Append("]");
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	internal static void smethod_2(DateTime dateTime_0, out int int_0, out long long_1)
	{
		DateTime dateTime = dateTime_0.ToUniversalTime();
		long num3 = default(long);
		while (true)
		{
			int num = 244815899;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x20C93976u) % 8u)
				{
				case 7u:
					long_1 = num3 & 0xFFFFFFFFL;
					num = ((int)num2 * -1574795493) ^ 0x468B9D7A;
					continue;
				case 5u:
					num3 = (dateTime.Ticks - 621355968000000000L) / 10000000L;
					int_0 = (int)(num3 >> 32);
					num = (int)((num2 * 1038938844) ^ 0x72C28855);
					continue;
				case 3u:
					Trace.WriteLine($"timeLow: {long_1}");
					num = (int)((num2 * 460720754) ^ 0x52458C1E);
					continue;
				case 2u:
					Trace.WriteLine($"timeHigh: {int_0}");
					num = (int)(num2 * 1693799887) ^ -433247373;
					continue;
				case 1u:
					Trace.WriteLine($"Date: {dateTime_0}");
					num = ((int)num2 * -619541548) ^ -538463302;
					continue;
				case 0u:
					Trace.WriteLine($"secondsFromEpoch: {num3}");
					num = (int)(num2 * 387807843) ^ -220670708;
					continue;
				default:
					return;
				case 4u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	internal static DateTime smethod_3(long long_1, long long_2)
	{
		long num = (long_2 << 32) + long_1;
		while (true)
		{
			int num2 = -58229133;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xC8583289u) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 2u:
					break;
				default:
					num += 621355968000000000L;
					return new DateTime(num);
				}
				break;
				IL_0009:
				num *= 10000000L;
				num2 = ((int)num3 * -177110929) ^ 0x94F3BBE;
			}
		}
	}

	internal static DateTime smethod_4(long long_1)
	{
		long_1 *= 10000000L;
		long_1 += 621355968000000000L;
		return new DateTime(long_1);
	}
}
