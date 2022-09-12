using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using Newtonsoft.Json;
using ns18;
using ns3;
using ns9;

namespace ns10;

internal class Class40 : Class38
{
	private readonly Class38 class38_0;

	private readonly Class39 class39_0;

	internal readonly StringWriter stringWriter_0;

	public Class40(Class38 class38_1)
	{
		class38_0 = class38_1;
		stringWriter_0 = new StringWriter(CultureInfo.InvariantCulture);
		stringWriter_0.Write("Serialized JSON: " + Environment.NewLine);
		class39_0 = new Class39(stringWriter_0);
		class39_0.Formatting = Enum7.const_1;
		class39_0.cultureInfo_0 = class38_1.Culture;
		class39_0.DateFormatHandling = class38_1.enum1_0;
		class39_0.DateFormatString = class38_1.DateFormatString;
		class39_0.DateTimeZoneHandling = class38_1.enum3_0;
		class39_0.FloatFormatHandling = class38_1.enum5_0;
	}

	public override void vmethod_34(decimal decimal_0)
	{
		class39_0.vmethod_34(decimal_0);
		class38_0.vmethod_34(decimal_0);
		base.vmethod_34(decimal_0);
	}

	public override void vmethod_51(decimal? nullable_0)
	{
		class39_0.vmethod_51(nullable_0);
		class38_0.vmethod_51(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_34(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_28(bool bool_2)
	{
		class39_0.vmethod_28(bool_2);
		class38_0.vmethod_28(bool_2);
		base.vmethod_28(bool_2);
	}

	public override void vmethod_45(bool? nullable_0)
	{
		class39_0.vmethod_45(nullable_0);
		class38_0.vmethod_45(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_28(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_32(byte byte_0)
	{
		class39_0.vmethod_32(byte_0);
		class38_0.vmethod_32(byte_0);
		base.vmethod_32(byte_0);
	}

	public override void vmethod_49(byte? nullable_0)
	{
		class39_0.vmethod_49(nullable_0);
		class38_0.vmethod_49(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_32(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_31(char char_0)
	{
		class39_0.vmethod_31(char_0);
		class38_0.vmethod_31(char_0);
		base.vmethod_31(char_0);
	}

	public override void vmethod_48(char? nullable_0)
	{
		class39_0.vmethod_48(nullable_0);
		class38_0.vmethod_48(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_31(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_56(byte[]? byte_0)
	{
		class39_0.vmethod_56(byte_0);
		class38_0.vmethod_56(byte_0);
		if (byte_0 == null)
		{
			base.vmethod_18();
		}
		else
		{
			base.vmethod_56(byte_0);
		}
	}

	public override void vmethod_35(DateTime dateTime_0)
	{
		class39_0.vmethod_35(dateTime_0);
		class38_0.vmethod_35(dateTime_0);
		base.vmethod_35(dateTime_0);
	}

	public override void vmethod_52(DateTime? nullable_0)
	{
		class39_0.vmethod_52(nullable_0);
		class38_0.vmethod_52(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_35(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_36(DateTimeOffset dateTimeOffset_0)
	{
		class39_0.vmethod_36(dateTimeOffset_0);
		class38_0.vmethod_36(dateTimeOffset_0);
		base.vmethod_36(dateTimeOffset_0);
	}

	public override void vmethod_53(DateTimeOffset? nullable_0)
	{
		class39_0.vmethod_53(nullable_0);
		class38_0.vmethod_53(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_36(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_27(double double_0)
	{
		class39_0.vmethod_27(double_0);
		class38_0.vmethod_27(double_0);
		base.vmethod_27(double_0);
	}

	public override void vmethod_44(double? nullable_0)
	{
		class39_0.vmethod_44(nullable_0);
		class38_0.vmethod_44(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_27(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_18()
	{
		class39_0.vmethod_18();
		class38_0.vmethod_18();
		base.vmethod_18();
	}

	public override void vmethod_17()
	{
		class39_0.vmethod_17();
		class38_0.vmethod_17();
		base.vmethod_18();
	}

	public override void vmethod_26(float float_0)
	{
		class39_0.vmethod_26(float_0);
		class38_0.vmethod_26(float_0);
		base.vmethod_26(float_0);
	}

	public override void vmethod_43(float? nullable_0)
	{
		class39_0.vmethod_43(nullable_0);
		class38_0.vmethod_43(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_26(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_37(Guid guid_0)
	{
		class39_0.vmethod_37(guid_0);
		class38_0.vmethod_37(guid_0);
		base.vmethod_37(guid_0);
	}

	public override void vmethod_54(Guid? nullable_0)
	{
		class39_0.vmethod_54(nullable_0);
		class38_0.vmethod_54(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_37(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_22(int int_0)
	{
		class39_0.vmethod_22(int_0);
		class38_0.vmethod_22(int_0);
		base.vmethod_22(int_0);
	}

	public override void vmethod_39(int? nullable_0)
	{
		class39_0.vmethod_39(nullable_0);
		class38_0.vmethod_39(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_22(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_24(long long_0)
	{
		class39_0.vmethod_24(long_0);
		class38_0.vmethod_24(long_0);
		base.vmethod_24(long_0);
	}

	public override void vmethod_41(long? nullable_0)
	{
		class39_0.vmethod_41(nullable_0);
		class38_0.vmethod_41(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_24(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_58(object? object_0)
	{
		if (object_0 is BigInteger)
		{
			class39_0.vmethod_58(object_0);
			class38_0.vmethod_58(object_0);
			Class7.smethod_325((Class38)this, JsonToken.Integer);
			return;
		}
		class39_0.vmethod_58(object_0);
		class38_0.vmethod_58(object_0);
		if (object_0 == null)
		{
			base.vmethod_18();
		}
		else
		{
			Class7.smethod_325((Class38)this, JsonToken.String);
		}
	}

	public override void vmethod_33(sbyte sbyte_0)
	{
		class39_0.vmethod_33(sbyte_0);
		class38_0.vmethod_33(sbyte_0);
		base.vmethod_33(sbyte_0);
	}

	public override void vmethod_50(sbyte? nullable_0)
	{
		class39_0.vmethod_50(nullable_0);
		class38_0.vmethod_50(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_33(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_29(short short_0)
	{
		class39_0.vmethod_29(short_0);
		class38_0.vmethod_29(short_0);
		base.vmethod_29(short_0);
	}

	public override void vmethod_46(short? nullable_0)
	{
		class39_0.vmethod_46(nullable_0);
		class38_0.vmethod_46(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_29(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_21(string? string_1)
	{
		class39_0.vmethod_21(string_1);
		class38_0.vmethod_21(string_1);
		base.vmethod_21(string_1);
	}

	public override void vmethod_38(TimeSpan timeSpan_0)
	{
		class39_0.vmethod_38(timeSpan_0);
		class38_0.vmethod_38(timeSpan_0);
		base.vmethod_38(timeSpan_0);
	}

	public override void vmethod_55(TimeSpan? nullable_0)
	{
		class39_0.vmethod_55(nullable_0);
		class38_0.vmethod_55(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_38(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_23(uint uint_0)
	{
		class39_0.vmethod_23(uint_0);
		class38_0.vmethod_23(uint_0);
		base.vmethod_23(uint_0);
	}

	public override void vmethod_40(uint? nullable_0)
	{
		class39_0.vmethod_40(nullable_0);
		class38_0.vmethod_40(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_23(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_25(ulong ulong_0)
	{
		class39_0.vmethod_25(ulong_0);
		class38_0.vmethod_25(ulong_0);
		base.vmethod_25(ulong_0);
	}

	public override void vmethod_42(ulong? nullable_0)
	{
		class39_0.vmethod_42(nullable_0);
		class38_0.vmethod_42(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_25(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_57(Uri? uri_0)
	{
		class39_0.vmethod_57(uri_0);
		class38_0.vmethod_57(uri_0);
		if (uri_0 == null)
		{
			base.vmethod_18();
		}
		else
		{
			base.vmethod_57(uri_0);
		}
	}

	public override void vmethod_30(ushort ushort_0)
	{
		class39_0.vmethod_30(ushort_0);
		class38_0.vmethod_30(ushort_0);
		base.vmethod_30(ushort_0);
	}

	public override void vmethod_47(ushort? nullable_0)
	{
		class39_0.vmethod_47(nullable_0);
		class38_0.vmethod_47(nullable_0);
		if (nullable_0.HasValue)
		{
			base.vmethod_30(nullable_0.GetValueOrDefault());
		}
		else
		{
			base.vmethod_18();
		}
	}

	public override void vmethod_60(string string_1)
	{
		class39_0.vmethod_60(string_1);
		class38_0.vmethod_60(string_1);
		base.vmethod_60(string_1);
	}

	public override void vmethod_59(string? string_1)
	{
		class39_0.vmethod_59(string_1);
		class38_0.vmethod_59(string_1);
		base.vmethod_59(string_1);
	}

	public override void vmethod_5()
	{
		class39_0.vmethod_5();
		class38_0.vmethod_5();
		base.vmethod_5();
	}

	public override void vmethod_6()
	{
		class39_0.vmethod_6();
		class38_0.vmethod_6();
		base.vmethod_6();
	}

	public override void vmethod_7(string string_1)
	{
		class39_0.vmethod_7(string_1);
		class38_0.vmethod_7(string_1);
		base.vmethod_7(string_1);
	}

	public override void vmethod_8()
	{
		class39_0.vmethod_8();
		class38_0.vmethod_8();
		base.vmethod_8();
	}

	public override void vmethod_9(string string_1)
	{
		class39_0.vmethod_9(string_1);
		class38_0.vmethod_9(string_1);
		base.vmethod_9(string_1);
	}

	public override void vmethod_10(string string_1, bool bool_2)
	{
		class39_0.vmethod_10(string_1, bool_2);
		class38_0.vmethod_10(string_1, bool_2);
		base.vmethod_9(string_1);
	}

	public override void vmethod_3()
	{
		class39_0.vmethod_3();
		class38_0.vmethod_3();
		base.vmethod_3();
	}

	public override void vmethod_4()
	{
		class39_0.vmethod_4();
		class38_0.vmethod_4();
		base.vmethod_4();
	}

	public override void vmethod_20(string? string_1)
	{
		class39_0.vmethod_20(string_1);
		class38_0.vmethod_20(string_1);
		Class7.smethod_325((Class38)this, JsonToken.Undefined);
	}

	public override void vmethod_19(string? string_1)
	{
		class39_0.vmethod_19(string_1);
		class38_0.vmethod_19(string_1);
		base.vmethod_19(string_1);
	}

	public override void vmethod_2()
	{
		class39_0.vmethod_2();
		class38_0.vmethod_2();
		base.vmethod_2();
	}

	public override void vmethod_1()
	{
		class39_0.vmethod_1();
		class38_0.vmethod_1();
	}
}
