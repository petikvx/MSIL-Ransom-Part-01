using System;
using System.Globalization;
using System.Numerics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ns1;
using ns13;
using ns14;
using ns17;
using ns3;
using ns5;
using ns8;
using ns9;

namespace ns4;

internal class Class40 : Class37
{
	private Class176? class176_0;

	internal Class176? class176_1;

	internal Class179? class179_0;

	internal JToken? jtoken_0;

	public JToken? CurrentToken => jtoken_0;

	public JToken? Token
	{
		get
		{
			if (class176_0 != null)
			{
				return class176_0;
			}
			return class179_0;
		}
	}

	public Class40(Class176 class176_2)
	{
		Class112.smethod_0(class176_2, "container");
		class176_0 = class176_2;
		class176_1 = class176_2;
	}

	public Class40()
	{
	}

	public override void vmethod_1()
	{
	}

	public override void vmethod_2()
	{
		base.vmethod_2();
	}

	public override void vmethod_3()
	{
		base.vmethod_3();
		method_3(new JObject());
	}

	private void method_3(Class176 class176_2)
	{
		if (class176_1 == null)
		{
			class176_0 = class176_2;
		}
		else
		{
			class176_1!.method_13(class176_2);
		}
		class176_1 = class176_2;
		jtoken_0 = class176_2;
	}

	public override void vmethod_5()
	{
		base.vmethod_5();
		method_3(new Class177());
	}

	public override void vmethod_7(string string_1)
	{
		base.vmethod_7(string_1);
		method_3(new Class178(string_1));
	}

	protected override void vmethod_13(JsonToken jsonToken_0)
	{
		Class131.smethod_728(this);
	}

	public override void vmethod_9(string string_1)
	{
		(class176_1 as JObject)?.System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemove(string_1);
		method_3(new JProperty(string_1));
		base.vmethod_9(string_1);
	}

	public override void vmethod_58(object? object_0)
	{
		if (object_0 is BigInteger)
		{
			Class131.smethod_314((Class37)this, JsonToken.Integer);
			Class131.smethod_747(JsonToken.Integer, object_0, this);
		}
		else
		{
			base.vmethod_58(object_0);
		}
	}

	public override void vmethod_17()
	{
		base.vmethod_17();
		Class131.smethod_638(JsonToken.Null, (Class179)null, this);
	}

	public override void vmethod_18()
	{
		base.vmethod_18();
		Class131.smethod_638(JsonToken.Undefined, (Class179)null, this);
	}

	public override void vmethod_19(string? string_1)
	{
		base.vmethod_19(string_1);
		Class131.smethod_638(JsonToken.Raw, (Class179)new Class180(string_1), this);
	}

	public override void vmethod_59(string? string_1)
	{
		base.vmethod_59(string_1);
		Class131.smethod_638(JsonToken.Comment, new Class179(string_1, JTokenType.Comment), this);
	}

	public override void vmethod_21(string? string_1)
	{
		base.vmethod_21(string_1);
		Class131.smethod_747(JsonToken.String, (object)string_1, this);
	}

	public override void vmethod_22(int int_0)
	{
		base.vmethod_22(int_0);
		Class131.smethod_747(JsonToken.Integer, (object)int_0, this);
	}

	[CLSCompliant(false)]
	public override void vmethod_23(uint uint_0)
	{
		base.vmethod_23(uint_0);
		Class131.smethod_747(JsonToken.Integer, (object)uint_0, this);
	}

	public override void vmethod_24(long long_0)
	{
		base.vmethod_24(long_0);
		Class131.smethod_747(JsonToken.Integer, (object)long_0, this);
	}

	[CLSCompliant(false)]
	public override void vmethod_25(ulong ulong_0)
	{
		base.vmethod_25(ulong_0);
		Class131.smethod_747(JsonToken.Integer, (object)ulong_0, this);
	}

	public override void vmethod_26(float float_0)
	{
		base.vmethod_26(float_0);
		Class131.smethod_747(JsonToken.Float, (object)float_0, this);
	}

	public override void vmethod_27(double double_0)
	{
		base.vmethod_27(double_0);
		Class131.smethod_747(JsonToken.Float, (object)double_0, this);
	}

	public override void vmethod_28(bool bool_2)
	{
		base.vmethod_28(bool_2);
		Class131.smethod_747(JsonToken.Boolean, (object)bool_2, this);
	}

	public override void vmethod_29(short short_0)
	{
		base.vmethod_29(short_0);
		Class131.smethod_747(JsonToken.Integer, (object)short_0, this);
	}

	[CLSCompliant(false)]
	public override void vmethod_30(ushort ushort_0)
	{
		base.vmethod_30(ushort_0);
		Class131.smethod_747(JsonToken.Integer, (object)ushort_0, this);
	}

	public override void vmethod_31(char char_0)
	{
		base.vmethod_31(char_0);
		string object_ = char_0.ToString(CultureInfo.InvariantCulture);
		Class131.smethod_747(JsonToken.String, (object)object_, this);
	}

	public override void vmethod_32(byte byte_0)
	{
		base.vmethod_32(byte_0);
		Class131.smethod_747(JsonToken.Integer, (object)byte_0, this);
	}

	[CLSCompliant(false)]
	public override void vmethod_33(sbyte sbyte_0)
	{
		base.vmethod_33(sbyte_0);
		Class131.smethod_747(JsonToken.Integer, (object)sbyte_0, this);
	}

	public override void vmethod_34(decimal decimal_0)
	{
		base.vmethod_34(decimal_0);
		Class131.smethod_747(JsonToken.Float, (object)decimal_0, this);
	}

	public override void vmethod_35(DateTime dateTime_0)
	{
		base.vmethod_35(dateTime_0);
		dateTime_0 = Class131.smethod_17(dateTime_0, enum3_0);
		Class131.smethod_747(JsonToken.Date, (object)dateTime_0, this);
	}

	public override void vmethod_36(DateTimeOffset dateTimeOffset_0)
	{
		base.vmethod_36(dateTimeOffset_0);
		Class131.smethod_747(JsonToken.Date, (object)dateTimeOffset_0, this);
	}

	public override void vmethod_56(byte[]? byte_0)
	{
		base.vmethod_56(byte_0);
		Class131.smethod_747(JsonToken.Bytes, (object)byte_0, this);
	}

	public override void vmethod_38(TimeSpan timeSpan_0)
	{
		base.vmethod_38(timeSpan_0);
		Class131.smethod_747(JsonToken.String, (object)timeSpan_0, this);
	}

	public override void vmethod_37(Guid guid_0)
	{
		base.vmethod_37(guid_0);
		Class131.smethod_747(JsonToken.String, (object)guid_0, this);
	}

	public override void vmethod_57(Uri? uri_0)
	{
		base.vmethod_57(uri_0);
		Class131.smethod_747(JsonToken.String, (object)uri_0, this);
	}

	internal override void vmethod_12(Class28 class28_0, bool bool_2, bool bool_3, bool bool_4)
	{
		Class31 @class = class28_0 as Class31;
		if (@class != null && bool_2 && bool_3 && bool_4)
		{
			if (@class.TokenType == JsonToken.None && !@class.vmethod_0())
			{
				return;
			}
			JToken jToken = @class.CurrentToken!.vmethod_0();
			if (class176_1 != null)
			{
				class176_1!.Add(jToken);
				jtoken_0 = class176_1!.Last;
				if (class176_1!.Type == JTokenType.Property)
				{
					class176_1 = class176_1!.Parent;
					Class131.smethod_314((Class37)this, JsonToken.Null);
				}
			}
			else
			{
				jtoken_0 = jToken;
				if (class176_0 == null && class179_0 == null)
				{
					class176_0 = jToken as Class176;
					class179_0 = jToken as Class179;
				}
			}
			Class131.smethod_482((Class28)@class);
		}
		else
		{
			base.vmethod_12(class28_0, bool_2, bool_3, bool_4);
		}
	}
}
