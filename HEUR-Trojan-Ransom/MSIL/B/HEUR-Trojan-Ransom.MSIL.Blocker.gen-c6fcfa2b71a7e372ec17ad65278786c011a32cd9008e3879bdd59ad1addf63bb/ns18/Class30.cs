using System;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;
using ns12;
using ns13;
using ns2;
using ns3;

namespace ns18;

internal class Class30 : Class28, Interface1
{
	internal readonly Class28 class28_0;

	internal readonly Class38 class38_0;

	internal readonly StringWriter stringWriter_0;

	public override int Depth => class28_0.Depth;

	public override string Path => class28_0.Path;

	public override char QuoteChar
	{
		get
		{
			return class28_0.QuoteChar;
		}
		protected internal set
		{
			class28_0.QuoteChar = value;
		}
	}

	public override JsonToken TokenType => class28_0.TokenType;

	public override object? Value => class28_0.Value;

	public override Type? ValueType => class28_0.ValueType;

	int Interface1.LineNumber
	{
		get
		{
			if (!(class28_0 is Interface1 @interface))
			{
				return 0;
			}
			return @interface.LineNumber;
		}
	}

	int Interface1.LinePosition
	{
		get
		{
			if (!(class28_0 is Interface1 @interface))
			{
				return 0;
			}
			return @interface.LinePosition;
		}
	}

	public Class30(Class28 class28_1)
	{
		class28_0 = class28_1;
		stringWriter_0 = new StringWriter(CultureInfo.InvariantCulture);
		stringWriter_0.Write("Deserialized JSON: " + Environment.NewLine);
		class38_0 = new Class38(stringWriter_0);
		class38_0.Formatting = Enum7.const_1;
	}

	public override bool vmethod_0()
	{
		bool result = class28_0.vmethod_0();
		Class131.smethod_681(this);
		return result;
	}

	public override int? vmethod_1()
	{
		int? result = class28_0.vmethod_1();
		Class131.smethod_681(this);
		return result;
	}

	public override string? vmethod_2()
	{
		string? result = class28_0.vmethod_2();
		Class131.smethod_681(this);
		return result;
	}

	public override byte[]? vmethod_3()
	{
		byte[]? result = class28_0.vmethod_3();
		Class131.smethod_681(this);
		return result;
	}

	public override decimal? vmethod_6()
	{
		decimal? result = class28_0.vmethod_6();
		Class131.smethod_681(this);
		return result;
	}

	public override double? vmethod_4()
	{
		double? result = class28_0.vmethod_4();
		Class131.smethod_681(this);
		return result;
	}

	public override bool? vmethod_5()
	{
		bool? result = class28_0.vmethod_5();
		Class131.smethod_681(this);
		return result;
	}

	public override DateTime? vmethod_7()
	{
		DateTime? result = class28_0.vmethod_7();
		Class131.smethod_681(this);
		return result;
	}

	public override DateTimeOffset? vmethod_8()
	{
		DateTimeOffset? result = class28_0.vmethod_8();
		Class131.smethod_681(this);
		return result;
	}

	public override void vmethod_10()
	{
		class28_0.vmethod_10();
	}

	bool Interface1.imethod_0()
	{
		if (class28_0 is Interface1 @interface)
		{
			return @interface.imethod_0();
		}
		return false;
	}
}
