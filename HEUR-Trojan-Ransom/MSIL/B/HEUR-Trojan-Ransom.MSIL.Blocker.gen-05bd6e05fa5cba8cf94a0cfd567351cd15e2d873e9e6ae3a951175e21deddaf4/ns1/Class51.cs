using System;
using System.Globalization;
using System.IO;
using ns10;
using ns17;
using ns9;

namespace ns1;

internal static class Class51
{
	internal static readonly long long_0;

	private const string string_0 = "yyyy-MM-ddTHH:mm:ss.FFFFFFFK";

	private const int int_0 = 36524;

	private const int int_1 = 146097;

	private const int int_2 = 1461;

	private const int int_3 = 365;

	private const long long_1 = 864000000000L;

	internal static readonly int[] int_4;

	internal static readonly int[] int_5;

	static Class51()
	{
		long_0 = 621355968000000000L;
		int_4 = new int[13]
		{
			0, 31, 59, 90, 120, 151, 181, 212, 243, 273,
			304, 334, 365
		};
		int_5 = new int[13]
		{
			0, 31, 60, 91, 121, 152, 182, 213, 244, 274,
			305, 335, 366
		};
	}

	public static TimeSpan smethod_0(this DateTime dateTime_0)
	{
		return TimeZoneInfo.Local.GetUtcOffset(dateTime_0);
	}

	internal static void smethod_1(TextWriter textWriter_0, DateTime dateTime_0, Enum1 enum1_0, string? string_1, CultureInfo cultureInfo_0)
	{
		if (Class109.smethod_0(string_1))
		{
			char[] array = new char[64];
			int count = smethod_2(array, 0, dateTime_0, null, dateTime_0.Kind, enum1_0);
			textWriter_0.Write(array, 0, count);
		}
		else
		{
			textWriter_0.Write(dateTime_0.ToString(string_1, cultureInfo_0));
		}
	}

	internal static int smethod_2(char[] char_0, int int_6, DateTime dateTime_0, TimeSpan? nullable_0, DateTimeKind dateTimeKind_0, Enum1 enum1_0)
	{
		int num = int_6;
		if (enum1_0 == Enum1.const_1)
		{
			TimeSpan timeSpan_ = nullable_0 ?? dateTime_0.smethod_0();
			long num2 = Class4.smethod_476(timeSpan_, dateTime_0);
			"\\/Date(".CopyTo(0, char_0, num, 7);
			num += 7;
			string text = num2.ToString(CultureInfo.InvariantCulture);
			text.CopyTo(0, char_0, num, text.Length);
			num += text.Length;
			switch (dateTimeKind_0)
			{
			case DateTimeKind.Local:
				num = Class4.smethod_351(char_0, num, timeSpan_, enum1_0);
				break;
			case DateTimeKind.Unspecified:
				if (dateTime_0 != DateTime.MaxValue && dateTime_0 != DateTime.MinValue)
				{
					num = Class4.smethod_351(char_0, num, timeSpan_, enum1_0);
				}
				break;
			}
			")\\/".CopyTo(0, char_0, num, 3);
			num += 3;
		}
		else
		{
			num = Class4.smethod_4(char_0, num, dateTime_0);
			switch (dateTimeKind_0)
			{
			case DateTimeKind.Local:
				num = Class4.smethod_351(char_0, num, nullable_0 ?? dateTime_0.smethod_0(), enum1_0);
				break;
			case DateTimeKind.Utc:
				char_0[num++] = 'Z';
				break;
			}
		}
		return num;
	}

	internal static void smethod_3(TextWriter textWriter_0, DateTimeOffset dateTimeOffset_0, Enum1 enum1_0, string? string_1, CultureInfo cultureInfo_0)
	{
		if (Class109.smethod_0(string_1))
		{
			char[] array = new char[64];
			int count = smethod_2(array, 0, (enum1_0 == Enum1.const_0) ? dateTimeOffset_0.DateTime : dateTimeOffset_0.UtcDateTime, dateTimeOffset_0.Offset, DateTimeKind.Local, enum1_0);
			textWriter_0.Write(array, 0, count);
		}
		else
		{
			textWriter_0.Write(dateTimeOffset_0.ToString(string_1, cultureInfo_0));
		}
	}
}
