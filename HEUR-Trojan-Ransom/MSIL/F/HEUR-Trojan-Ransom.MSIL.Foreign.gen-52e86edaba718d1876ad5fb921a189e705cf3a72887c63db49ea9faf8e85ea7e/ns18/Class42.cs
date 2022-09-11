using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns19;
using ns5;
using ns7;

namespace ns18;

internal sealed class Class42 : Class38
{
	private bool? nullable_0;

	[NonSerialized]
	internal static GetString getString_1;

	public bool IsView
	{
		get
		{
			return method_0();
		}
		internal set
		{
			nullable_0 = value;
		}
	}

	private bool method_0()
	{
		if (!nullable_0.HasValue)
		{
			string text = base.Session.XSession.method_21(base.Schema, base.Name).ToUpperInvariant();
			nullable_0 = text == getString_1(107408525);
		}
		return nullable_0.Value;
	}

	internal Class42(Class41 class41_1, string string_1, bool bool_0)
		: base(class41_1, string_1)
	{
		nullable_0 = bool_0;
	}

	internal Class42(Class41 class41_1, string string_1)
		: base(class41_1, string_1)
	{
	}

	internal Class42()
		: base(null, null)
	{
	}

	public Class61 method_1(params string[] string_1)
	{
		return new Class61(this, string_1);
	}

	public Class66 method_2(params string[] string_1)
	{
		return new Class66(this, string_1);
	}

	public Class62 method_3()
	{
		return new Class62(this);
	}

	public Class60 method_4()
	{
		return new Class60(this, null);
	}

	public long method_5()
	{
		return base.Session.XSession.method_16(base.Schema, base.Name);
	}

	public override bool vmethod_0()
	{
		return base.Session.XSession.method_17(base.Schema, base.Name);
	}

	static Class42()
	{
		Strings.CreateGetStringDelegate(typeof(Class42));
	}
}
