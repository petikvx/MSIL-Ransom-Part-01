using System;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;
using ns10;
using ns15;
using ns2;
using ns8;

namespace ns5;

internal class Class31 : Class29, Interface1
{
	internal readonly Class29 class29_0;

	internal readonly Class39 class39_0;

	internal readonly StringWriter stringWriter_0;

	public override int Depth => class29_0.Depth;

	public override string Path => class29_0.Path;

	public override char QuoteChar
	{
		get
		{
			return class29_0.QuoteChar;
		}
		protected internal set
		{
			class29_0.QuoteChar = value;
		}
	}

	public override JsonToken TokenType => class29_0.TokenType;

	public override object? Value => class29_0.Value;

	public override Type? ValueType => class29_0.ValueType;

	int Interface1.LineNumber
	{
		get
		{
			if (!(class29_0 is Interface1 @interface))
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
			if (!(class29_0 is Interface1 @interface))
			{
				return 0;
			}
			return @interface.LinePosition;
		}
	}

	public Class31(Class29 class29_1)
	{
		class29_0 = class29_1;
		stringWriter_0 = new StringWriter(CultureInfo.InvariantCulture);
		stringWriter_0.Write("Deserialized JSON: " + Environment.NewLine);
		class39_0 = new Class39(stringWriter_0);
		class39_0.Formatting = Enum7.const_1;
	}

	public override bool vmethod_0()
	{
		bool result = class29_0.vmethod_0();
		Class4.smethod_474(this);
		return result;
	}

	public override int? vmethod_1()
	{
		int? result = class29_0.vmethod_1();
		Class4.smethod_474(this);
		return result;
	}

	public override string? vmethod_2()
	{
		string? result = class29_0.vmethod_2();
		Class4.smethod_474(this);
		return result;
	}

	public override byte[]? vmethod_3()
	{
		byte[]? result = class29_0.vmethod_3();
		Class4.smethod_474(this);
		return result;
	}

	public override decimal? vmethod_6()
	{
		decimal? result = class29_0.vmethod_6();
		Class4.smethod_474(this);
		return result;
	}

	public override double? vmethod_4()
	{
		double? result = class29_0.vmethod_4();
		Class4.smethod_474(this);
		return result;
	}

	public override bool? vmethod_5()
	{
		bool? result = class29_0.vmethod_5();
		Class4.smethod_474(this);
		return result;
	}

	public override DateTime? vmethod_7()
	{
		DateTime? result = class29_0.vmethod_7();
		Class4.smethod_474(this);
		return result;
	}

	public override DateTimeOffset? vmethod_8()
	{
		DateTimeOffset? result = class29_0.vmethod_8();
		Class4.smethod_474(this);
		return result;
	}

	public override void vmethod_10()
	{
		class29_0.vmethod_10();
	}

	bool Interface1.imethod_0()
	{
		if (class29_0 is Interface1 @interface)
		{
			return @interface.imethod_0();
		}
		return false;
	}
}
