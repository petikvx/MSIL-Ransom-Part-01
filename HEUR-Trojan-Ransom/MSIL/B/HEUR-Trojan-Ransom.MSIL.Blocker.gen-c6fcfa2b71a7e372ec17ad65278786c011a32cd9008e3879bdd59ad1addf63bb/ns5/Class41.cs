using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using ns10;
using ns11;
using ns13;
using ns15;
using ns17;
using ns18;
using ns7;
using ns9;

namespace ns5;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
internal class Class41 : Class37
{
	private readonly Class239 class239_0;

	internal Class242 class242_0;

	internal Class242 class242_1;

	internal string string_1;

	public DateTimeKind DateTimeKindHandling
	{
		get
		{
			return class239_0.DateTimeKindHandling;
		}
		set
		{
			class239_0.DateTimeKindHandling = value;
		}
	}

	public Class41(Stream stream_0)
	{
		Class112.smethod_0(stream_0, "stream");
		class239_0 = new Class239(new BinaryWriter(stream_0));
	}

	public Class41(BinaryWriter binaryWriter_0)
	{
		Class112.smethod_0(binaryWriter_0, "writer");
		class239_0 = new Class239(binaryWriter_0);
	}

	public override void vmethod_1()
	{
		Class131.smethod_165(class239_0);
	}

	protected override void vmethod_13(JsonToken jsonToken_0)
	{
		base.vmethod_13(jsonToken_0);
		Class131.smethod_225(this);
		if (base.Top == 0)
		{
			Class239 @class = class239_0;
			Class242 class2 = class242_0;
			Class131.smethod_397(class2, @class);
		}
	}

	public override void vmethod_59(string string_2)
	{
		throw Class131.smethod_285((Class37)this, "Cannot write JSON comment as BSON.", (Exception?)null);
	}

	public override void vmethod_7(string string_2)
	{
		throw Class131.smethod_285((Class37)this, "Cannot write JSON constructor as BSON.", (Exception?)null);
	}

	public override void vmethod_19(string string_2)
	{
		throw Class131.smethod_285((Class37)this, "Cannot write raw JSON as BSON.", (Exception?)null);
	}

	public override void vmethod_20(string string_2)
	{
		throw Class131.smethod_285((Class37)this, "Cannot write raw JSON as BSON.", (Exception?)null);
	}

	public override void vmethod_5()
	{
		base.vmethod_5();
		Class131.smethod_64(this, (Class242)new Class244());
	}

	public override void vmethod_3()
	{
		base.vmethod_3();
		Class131.smethod_64(this, (Class242)new Class243());
	}

	public override void vmethod_9(string string_2)
	{
		base.vmethod_9(string_2);
		string_1 = string_2;
	}

	public override void vmethod_2()
	{
		base.vmethod_2();
		if (base.CloseOutput)
		{
			Class239 @class = class239_0;
			if (@class != null)
			{
				Class131.smethod_506(@class);
			}
		}
	}

	public override void vmethod_58(object object_0)
	{
		if (object_0 is BigInteger bigInteger)
		{
			Class131.smethod_114((Class37)this, JsonToken.Integer, (object)null);
			Class131.smethod_450(this, (Class242)new Class249(bigInteger.ToByteArray(), Enum34.const_0));
		}
		else
		{
			base.vmethod_58(object_0);
		}
	}

	public override void vmethod_17()
	{
		base.vmethod_17();
		Class131.smethod_450(this, Class245.class242_1);
	}

	public override void vmethod_18()
	{
		base.vmethod_18();
		Class131.smethod_450(this, Class245.class242_2);
	}

	public override void vmethod_21(string string_2)
	{
		base.vmethod_21(string_2);
		Class131.smethod_450(this, (string_2 == null) ? Class245.class242_1 : new Class248(string_2, bool_1: true));
	}

	public override void vmethod_22(int int_0)
	{
		base.vmethod_22(int_0);
		Class131.smethod_182((object)int_0, this, BsonType.Integer);
	}

	[CLSCompliant(false)]
	public override void vmethod_23(uint uint_0)
	{
		if (uint_0 > int.MaxValue)
		{
			throw Class131.smethod_285((Class37)this, "Value is too large to fit in a signed 32 bit integer. BSON does not support unsigned values.", (Exception?)null);
		}
		base.vmethod_23(uint_0);
		Class131.smethod_182((object)uint_0, this, BsonType.Integer);
	}

	public override void vmethod_24(long long_0)
	{
		base.vmethod_24(long_0);
		Class131.smethod_182((object)long_0, this, BsonType.Long);
	}

	[CLSCompliant(false)]
	public override void vmethod_25(ulong ulong_0)
	{
		if (ulong_0 > long.MaxValue)
		{
			throw Class131.smethod_285((Class37)this, "Value is too large to fit in a signed 64 bit integer. BSON does not support unsigned values.", (Exception?)null);
		}
		base.vmethod_25(ulong_0);
		Class131.smethod_182((object)ulong_0, this, BsonType.Long);
	}

	public override void vmethod_26(float float_0)
	{
		base.vmethod_26(float_0);
		Class131.smethod_182((object)float_0, this, BsonType.Number);
	}

	public override void vmethod_27(double double_0)
	{
		base.vmethod_27(double_0);
		Class131.smethod_182((object)double_0, this, BsonType.Number);
	}

	public override void vmethod_28(bool bool_2)
	{
		base.vmethod_28(bool_2);
		Class131.smethod_450(this, (Class242)(bool_2 ? Class247.class247_1 : Class247.class247_0));
	}

	public override void vmethod_29(short short_0)
	{
		base.vmethod_29(short_0);
		Class131.smethod_182((object)short_0, this, BsonType.Integer);
	}

	[CLSCompliant(false)]
	public override void vmethod_30(ushort ushort_0)
	{
		base.vmethod_30(ushort_0);
		Class131.smethod_182((object)ushort_0, this, BsonType.Integer);
	}

	public override void vmethod_31(char char_0)
	{
		base.vmethod_31(char_0);
		string text = null;
		text = char_0.ToString(CultureInfo.InvariantCulture);
		Class131.smethod_450(this, (Class242)new Class248(text, bool_1: true));
	}

	public override void vmethod_32(byte byte_0)
	{
		base.vmethod_32(byte_0);
		Class131.smethod_182((object)byte_0, this, BsonType.Integer);
	}

	[CLSCompliant(false)]
	public override void vmethod_33(sbyte sbyte_0)
	{
		base.vmethod_33(sbyte_0);
		Class131.smethod_182((object)sbyte_0, this, BsonType.Integer);
	}

	public override void vmethod_34(decimal decimal_0)
	{
		base.vmethod_34(decimal_0);
		Class131.smethod_182((object)decimal_0, this, BsonType.Number);
	}

	public override void vmethod_35(DateTime dateTime_0)
	{
		base.vmethod_35(dateTime_0);
		dateTime_0 = Class131.smethod_17(dateTime_0, enum3_0);
		Class131.smethod_182((object)dateTime_0, this, BsonType.Date);
	}

	public override void vmethod_36(DateTimeOffset dateTimeOffset_0)
	{
		base.vmethod_36(dateTimeOffset_0);
		Class131.smethod_182((object)dateTimeOffset_0, this, BsonType.Date);
	}

	public override void vmethod_56(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			vmethod_17();
			return;
		}
		base.vmethod_56(byte_0);
		Class131.smethod_450(this, (Class242)new Class249(byte_0, Enum34.const_0));
	}

	public override void vmethod_37(Guid guid_0)
	{
		base.vmethod_37(guid_0);
		Class131.smethod_450(this, (Class242)new Class249(guid_0.ToByteArray(), Enum34.const_4));
	}

	public override void vmethod_38(TimeSpan timeSpan_0)
	{
		base.vmethod_38(timeSpan_0);
		Class131.smethod_450(this, (Class242)new Class248(timeSpan_0.ToString(), bool_1: true));
	}

	public override void vmethod_57(Uri uri_0)
	{
		if (uri_0 == null)
		{
			vmethod_17();
			return;
		}
		base.vmethod_57(uri_0);
		Class131.smethod_450(this, (Class242)new Class248(uri_0.ToString(), bool_1: true));
	}
}
