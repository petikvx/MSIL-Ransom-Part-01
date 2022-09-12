using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using ns1;
using ns10;
using ns16;
using ns17;
using ns18;
using ns2;
using ns3;
using ns5;
using ns6;
using ns7;

namespace ns13;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
internal class Class42 : Class38
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

	public Class42(Stream stream_0)
	{
		Class113.smethod_0(stream_0, "stream");
		class239_0 = new Class239(new BinaryWriter(stream_0));
	}

	public Class42(BinaryWriter binaryWriter_0)
	{
		Class113.smethod_0(binaryWriter_0, "writer");
		class239_0 = new Class239(binaryWriter_0);
	}

	public override void vmethod_1()
	{
		Class4.smethod_314(class239_0);
	}

	protected override void vmethod_13(JsonToken jsonToken_0)
	{
		base.vmethod_13(jsonToken_0);
		Class4.smethod_532(this);
		if (base.Top == 0)
		{
			Class4.smethod_477(class239_0, class242_0);
		}
	}

	public override void vmethod_59(string string_2)
	{
		throw Class4.smethod_436((Class38)this, "Cannot write JSON comment as BSON.", (Exception?)null);
	}

	public override void vmethod_7(string string_2)
	{
		throw Class4.smethod_436((Class38)this, "Cannot write JSON constructor as BSON.", (Exception?)null);
	}

	public override void vmethod_19(string string_2)
	{
		throw Class4.smethod_436((Class38)this, "Cannot write raw JSON as BSON.", (Exception?)null);
	}

	public override void vmethod_20(string string_2)
	{
		throw Class4.smethod_436((Class38)this, "Cannot write raw JSON as BSON.", (Exception?)null);
	}

	public override void vmethod_5()
	{
		base.vmethod_5();
		Class4.smethod_73((Class242)new Class244(), this);
	}

	public override void vmethod_3()
	{
		base.vmethod_3();
		Class4.smethod_73((Class242)new Class243(), this);
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
				Class4.smethod_472(@class);
			}
		}
	}

	public override void vmethod_58(object object_0)
	{
		if (object_0 is BigInteger bigInteger)
		{
			Class4.smethod_112((Class38)this, JsonToken.Integer, (object)null);
			Class4.smethod_692(this, (Class242)new Class249(bigInteger.ToByteArray(), Enum34.const_0));
		}
		else
		{
			base.vmethod_58(object_0);
		}
	}

	public override void vmethod_17()
	{
		base.vmethod_17();
		Class4.smethod_692(this, Class245.class242_1);
	}

	public override void vmethod_18()
	{
		base.vmethod_18();
		Class4.smethod_692(this, Class245.class242_2);
	}

	public override void vmethod_21(string string_2)
	{
		base.vmethod_21(string_2);
		Class4.smethod_692(this, (string_2 == null) ? Class245.class242_1 : new Class248(string_2, bool_1: true));
	}

	public override void vmethod_22(int int_0)
	{
		base.vmethod_22(int_0);
		Class4.smethod_667(BsonType.Integer, this, (object)int_0);
	}

	[CLSCompliant(false)]
	public override void vmethod_23(uint uint_0)
	{
		if (uint_0 > int.MaxValue)
		{
			throw Class4.smethod_436((Class38)this, "Value is too large to fit in a signed 32 bit integer. BSON does not support unsigned values.", (Exception?)null);
		}
		base.vmethod_23(uint_0);
		Class4.smethod_667(BsonType.Integer, this, (object)uint_0);
	}

	public override void vmethod_24(long long_0)
	{
		base.vmethod_24(long_0);
		Class4.smethod_667(BsonType.Long, this, (object)long_0);
	}

	[CLSCompliant(false)]
	public override void vmethod_25(ulong ulong_0)
	{
		if (ulong_0 > long.MaxValue)
		{
			throw Class4.smethod_436((Class38)this, "Value is too large to fit in a signed 64 bit integer. BSON does not support unsigned values.", (Exception?)null);
		}
		base.vmethod_25(ulong_0);
		Class4.smethod_667(BsonType.Long, this, (object)ulong_0);
	}

	public override void vmethod_26(float float_0)
	{
		base.vmethod_26(float_0);
		Class4.smethod_667(BsonType.Number, this, (object)float_0);
	}

	public override void vmethod_27(double double_0)
	{
		base.vmethod_27(double_0);
		Class4.smethod_667(BsonType.Number, this, (object)double_0);
	}

	public override void vmethod_28(bool bool_2)
	{
		base.vmethod_28(bool_2);
		Class4.smethod_692(this, (Class242)(bool_2 ? Class247.class247_1 : Class247.class247_0));
	}

	public override void vmethod_29(short short_0)
	{
		base.vmethod_29(short_0);
		Class4.smethod_667(BsonType.Integer, this, (object)short_0);
	}

	[CLSCompliant(false)]
	public override void vmethod_30(ushort ushort_0)
	{
		base.vmethod_30(ushort_0);
		Class4.smethod_667(BsonType.Integer, this, (object)ushort_0);
	}

	public override void vmethod_31(char char_0)
	{
		base.vmethod_31(char_0);
		string text = null;
		text = char_0.ToString(CultureInfo.InvariantCulture);
		Class4.smethod_692(this, (Class242)new Class248(text, bool_1: true));
	}

	public override void vmethod_32(byte byte_0)
	{
		base.vmethod_32(byte_0);
		Class4.smethod_667(BsonType.Integer, this, (object)byte_0);
	}

	[CLSCompliant(false)]
	public override void vmethod_33(sbyte sbyte_0)
	{
		base.vmethod_33(sbyte_0);
		Class4.smethod_667(BsonType.Integer, this, (object)sbyte_0);
	}

	public override void vmethod_34(decimal decimal_0)
	{
		base.vmethod_34(decimal_0);
		Class4.smethod_667(BsonType.Number, this, (object)decimal_0);
	}

	public override void vmethod_35(DateTime dateTime_0)
	{
		base.vmethod_35(dateTime_0);
		dateTime_0 = Class4.smethod_442(dateTime_0, enum3_0);
		Class4.smethod_667(BsonType.Date, this, (object)dateTime_0);
	}

	public override void vmethod_36(DateTimeOffset dateTimeOffset_0)
	{
		base.vmethod_36(dateTimeOffset_0);
		Class4.smethod_667(BsonType.Date, this, (object)dateTimeOffset_0);
	}

	public override void vmethod_56(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			vmethod_17();
			return;
		}
		base.vmethod_56(byte_0);
		Class4.smethod_692(this, (Class242)new Class249(byte_0, Enum34.const_0));
	}

	public override void vmethod_37(Guid guid_0)
	{
		base.vmethod_37(guid_0);
		Class4.smethod_692(this, (Class242)new Class249(guid_0.ToByteArray(), Enum34.const_4));
	}

	public override void vmethod_38(TimeSpan timeSpan_0)
	{
		base.vmethod_38(timeSpan_0);
		Class4.smethod_692(this, (Class242)new Class248(timeSpan_0.ToString(), bool_1: true));
	}

	public override void vmethod_57(Uri uri_0)
	{
		if (uri_0 == null)
		{
			vmethod_17();
			return;
		}
		base.vmethod_57(uri_0);
		Class4.smethod_692(this, (Class242)new Class248(uri_0.ToString(), bool_1: true));
	}
}
