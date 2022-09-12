using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using Newtonsoft.Json;
using ns11;
using ns13;
using ns14;
using ns3;
using ns9;

namespace ns2;

internal class Class38 : Class37
{
	private const int int_0 = 12;

	internal readonly TextWriter textWriter_0;

	private Class42? class42_0;

	internal char char_0;

	private int int_1;

	internal char char_1;

	private bool bool_2;

	internal bool[]? bool_3;

	internal char[]? char_2;

	internal Interface0<char>? interface0_0;

	internal char[]? char_3;

	private Class42 Base64Encoder
	{
		get
		{
			if (class42_0 == null)
			{
				class42_0 = new Class42(textWriter_0);
			}
			return class42_0;
		}
	}

	public Interface0<char>? ArrayPool
	{
		get
		{
			return interface0_0;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			interface0_0 = value;
		}
	}

	public int Indentation
	{
		get
		{
			return int_1;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Indentation value must be greater than 0.");
			}
			int_1 = value;
		}
	}

	public char QuoteChar
	{
		get
		{
			return char_1;
		}
		set
		{
			if (value != '"' && value != '\'')
			{
				throw new ArgumentException("Invalid JavaScript string quote character. Valid quote characters are ' and \".");
			}
			char_1 = value;
			Class131.smethod_410(this);
		}
	}

	public char IndentChar
	{
		get
		{
			return char_0;
		}
		set
		{
			if (value != char_0)
			{
				char_0 = value;
				char_3 = null;
			}
		}
	}

	public bool QuoteName
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	public Class38(TextWriter textWriter_1)
	{
		if (textWriter_1 == null)
		{
			throw new ArgumentNullException("textWriter");
		}
		textWriter_0 = textWriter_1;
		char_1 = '"';
		bool_2 = true;
		char_0 = ' ';
		int_1 = 2;
		Class131.smethod_410(this);
	}

	public override void vmethod_1()
	{
		textWriter_0.Flush();
	}

	public override void vmethod_2()
	{
		base.vmethod_2();
		Class131.smethod_148(this);
	}

	public override void vmethod_3()
	{
		Class131.smethod_21((Class37)this, JsonToken.StartObject, JsonContainerType.Object);
		textWriter_0.Write('{');
	}

	public override void vmethod_5()
	{
		Class131.smethod_21((Class37)this, JsonToken.StartArray, JsonContainerType.Array);
		textWriter_0.Write('[');
	}

	public override void vmethod_7(string string_1)
	{
		Class131.smethod_21((Class37)this, JsonToken.StartConstructor, JsonContainerType.Constructor);
		textWriter_0.Write("new ");
		textWriter_0.Write(string_1);
		textWriter_0.Write('(');
	}

	protected override void vmethod_13(JsonToken jsonToken_0)
	{
		switch (jsonToken_0)
		{
		default:
			throw Class131.smethod_285((Class37)this, "Invalid JsonToken: " + jsonToken_0, (Exception?)null);
		case JsonToken.EndObject:
			textWriter_0.Write('}');
			break;
		case JsonToken.EndArray:
			textWriter_0.Write(']');
			break;
		case JsonToken.EndConstructor:
			textWriter_0.Write(')');
			break;
		}
	}

	public override void vmethod_9(string string_1)
	{
		Class131.smethod_171((Class37)this, string_1);
		method_4(string_1, bool_2);
		textWriter_0.Write(':');
	}

	public override void vmethod_10(string string_1, bool bool_4)
	{
		Class131.smethod_171((Class37)this, string_1);
		if (bool_4)
		{
			method_4(string_1, bool_2);
		}
		else
		{
			if (bool_2)
			{
				textWriter_0.Write(char_1);
			}
			textWriter_0.Write(string_1);
			if (bool_2)
			{
				textWriter_0.Write(char_1);
			}
		}
		textWriter_0.Write(':');
	}

	internal override void vmethod_0()
	{
		Class131.smethod_410(this);
	}

	protected override void vmethod_14()
	{
		int num = base.Top * int_1;
		int num2 = Class131.smethod_639(this);
		textWriter_0.Write(char_3, 0, num2 + Math.Min(num, 12));
		while ((num -= 12) > 0)
		{
			textWriter_0.Write(char_3, num2, Math.Min(num, 12));
		}
	}

	protected override void vmethod_15()
	{
		textWriter_0.Write(',');
	}

	protected override void vmethod_16()
	{
		textWriter_0.Write(' ');
	}

	private void method_3(string string_1, JsonToken jsonToken_0)
	{
		textWriter_0.Write(string_1);
	}

	public override void vmethod_58(object? object_0)
	{
		if (object_0 is BigInteger bigInteger)
		{
			Class131.smethod_314((Class37)this, JsonToken.Integer);
			method_3(bigInteger.ToString(CultureInfo.InvariantCulture), JsonToken.String);
		}
		else
		{
			base.vmethod_58(object_0);
		}
	}

	public override void vmethod_17()
	{
		Class131.smethod_314((Class37)this, JsonToken.Null);
		method_3(Class7.string_2, JsonToken.Null);
	}

	public override void vmethod_18()
	{
		Class131.smethod_314((Class37)this, JsonToken.Undefined);
		method_3(Class7.string_3, JsonToken.Undefined);
	}

	public override void vmethod_19(string? string_1)
	{
		Class131.smethod_532((Class37)this);
		textWriter_0.Write(string_1);
	}

	public override void vmethod_21(string? string_1)
	{
		Class131.smethod_314((Class37)this, JsonToken.String);
		if (string_1 == null)
		{
			method_3(Class7.string_2, JsonToken.Null);
		}
		else
		{
			method_4(string_1, bool_4: true);
		}
	}

	private void method_4(string string_1, bool bool_4)
	{
		Class131.smethod_463(this);
		Class87.smethod_0(textWriter_0, string_1, char_1, bool_4, bool_3, enum17_0, interface0_0, ref char_2);
	}

	public override void vmethod_22(int int_2)
	{
		Class131.smethod_314((Class37)this, JsonToken.Integer);
		Class131.smethod_662(this, int_2);
	}

	[CLSCompliant(false)]
	public override void vmethod_23(uint uint_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.Integer);
		Class131.smethod_616(this, (long)uint_0);
	}

	public override void vmethod_24(long long_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.Integer);
		Class131.smethod_616(this, long_0);
	}

	[CLSCompliant(false)]
	public override void vmethod_25(ulong ulong_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.Integer);
		Class131.smethod_569(this, ulong_0, bool_0: false);
	}

	public override void vmethod_26(float float_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.Float);
		method_3(Class7.smethod_8(float_0, enum5_0, char_1, bool_0: false), JsonToken.Float);
	}

	public override void vmethod_43(float? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
			return;
		}
		Class131.smethod_314((Class37)this, JsonToken.Float);
		method_3(Class7.smethod_8(nullable_0.GetValueOrDefault(), enum5_0, char_1, bool_0: true), JsonToken.Float);
	}

	public override void vmethod_27(double double_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.Float);
		method_3(Class7.smethod_11(double_0, enum5_0, char_1, bool_0: false), JsonToken.Float);
	}

	public override void vmethod_44(double? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
			return;
		}
		Class131.smethod_314((Class37)this, JsonToken.Float);
		method_3(Class7.smethod_11(nullable_0.GetValueOrDefault(), enum5_0, char_1, bool_0: true), JsonToken.Float);
	}

	public override void vmethod_28(bool bool_4)
	{
		Class131.smethod_314((Class37)this, JsonToken.Boolean);
		method_3(Class131.smethod_735(bool_4), JsonToken.Boolean);
	}

	public override void vmethod_29(short short_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.Integer);
		Class131.smethod_662(this, (int)short_0);
	}

	[CLSCompliant(false)]
	public override void vmethod_30(ushort ushort_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.Integer);
		Class131.smethod_662(this, (int)ushort_0);
	}

	public override void vmethod_31(char char_4)
	{
		Class131.smethod_314((Class37)this, JsonToken.String);
		method_3(Class131.smethod_557(char_4), JsonToken.String);
	}

	public override void vmethod_32(byte byte_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.Integer);
		Class131.smethod_662(this, (int)byte_0);
	}

	[CLSCompliant(false)]
	public override void vmethod_33(sbyte sbyte_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.Integer);
		Class131.smethod_662(this, (int)sbyte_0);
	}

	public override void vmethod_34(decimal decimal_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.Float);
		method_3(Class7.smethod_14(decimal_0), JsonToken.Float);
	}

	public override void vmethod_35(DateTime dateTime_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.Date);
		dateTime_0 = Class131.smethod_17(dateTime_0, enum3_0);
		if (Class108.smethod_0(base.DateFormatString))
		{
			int count = Class131.smethod_544(this, dateTime_0);
			textWriter_0.Write(char_2, 0, count);
		}
		else
		{
			textWriter_0.Write(char_1);
			textWriter_0.Write(dateTime_0.ToString(base.DateFormatString, base.Culture));
			textWriter_0.Write(char_1);
		}
	}

	public override void vmethod_56(byte[]? byte_0)
	{
		if (byte_0 == null)
		{
			vmethod_17();
			return;
		}
		Class131.smethod_314((Class37)this, JsonToken.Bytes);
		textWriter_0.Write(char_1);
		Class131.smethod_243(0, Base64Encoder, byte_0!.Length, byte_0);
		Class131.smethod_372(Base64Encoder);
		textWriter_0.Write(char_1);
	}

	public override void vmethod_36(DateTimeOffset dateTimeOffset_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.Date);
		if (Class108.smethod_0(base.DateFormatString))
		{
			int count = Class131.smethod_677(dateTimeOffset_0, this);
			textWriter_0.Write(char_2, 0, count);
		}
		else
		{
			textWriter_0.Write(char_1);
			textWriter_0.Write(dateTimeOffset_0.ToString(base.DateFormatString, base.Culture));
			textWriter_0.Write(char_1);
		}
	}

	public override void vmethod_37(Guid guid_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.String);
		string value = guid_0.ToString("D", CultureInfo.InvariantCulture);
		textWriter_0.Write(char_1);
		textWriter_0.Write(value);
		textWriter_0.Write(char_1);
	}

	public override void vmethod_38(TimeSpan timeSpan_0)
	{
		Class131.smethod_314((Class37)this, JsonToken.String);
		string value = timeSpan_0.ToString(null, CultureInfo.InvariantCulture);
		textWriter_0.Write(char_1);
		textWriter_0.Write(value);
		textWriter_0.Write(char_1);
	}

	public override void vmethod_57(Uri? uri_0)
	{
		if (uri_0 == null)
		{
			vmethod_17();
			return;
		}
		Class131.smethod_314((Class37)this, JsonToken.String);
		method_4(uri_0!.OriginalString, bool_4: true);
	}

	public override void vmethod_59(string? string_1)
	{
		Class131.smethod_440((Class37)this);
		textWriter_0.Write("/*");
		textWriter_0.Write(string_1);
		textWriter_0.Write("*/");
	}

	public override void vmethod_60(string string_1)
	{
		Class131.smethod_312(string_1, (Class37)this);
		textWriter_0.Write(string_1);
	}
}
