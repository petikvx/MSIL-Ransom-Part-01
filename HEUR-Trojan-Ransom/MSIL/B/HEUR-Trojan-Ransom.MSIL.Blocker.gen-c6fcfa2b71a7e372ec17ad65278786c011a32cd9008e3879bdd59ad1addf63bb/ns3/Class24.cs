using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ns1;
using ns12;
using ns13;
using ns15;
using ns17;
using ns7;
using ns9;

namespace ns3;

internal class Class24 : Class8
{
	[CompilerGenerated]
	private Class114? class114_0;

	[CompilerGenerated]
	private bool bool_0 = true;

	[Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
	public bool CamelCaseText
	{
		get
		{
			if (!(NamingStrategy is Class115))
			{
				return false;
			}
			return true;
		}
		set
		{
			if (value)
			{
				if (!(NamingStrategy is Class115))
				{
					NamingStrategy = new Class115();
				}
			}
			else if (NamingStrategy is Class115)
			{
				NamingStrategy = null;
			}
		}
	}

	public Class114? NamingStrategy
	{
		[CompilerGenerated]
		get
		{
			return class114_0;
		}
		[CompilerGenerated]
		set
		{
			class114_0 = value;
		}
	}

	public bool AllowIntegerValues
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public Class24()
	{
	}

	[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
	public Class24(bool bool_1)
	{
		if (bool_1)
		{
			NamingStrategy = new Class115();
		}
	}

	public Class24(Class114 class114_1, bool bool_1 = true)
	{
		NamingStrategy = class114_1;
		AllowIntegerValues = bool_1;
	}

	public Class24(Type type_0)
	{
		Class112.smethod_0(type_0, "namingStrategyType");
		NamingStrategy = Class131.smethod_498(type_0, (object[]?)null);
	}

	public Class24(Type type_0, object[] object_0)
	{
		Class112.smethod_0(type_0, "namingStrategyType");
		NamingStrategy = Class131.smethod_498(type_0, object_0);
	}

	public Class24(Type type_0, object[] object_0, bool bool_1)
	{
		Class112.smethod_0(type_0, "namingStrategyType");
		NamingStrategy = Class131.smethod_498(type_0, object_0);
		AllowIntegerValues = bool_1;
	}

	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		if (object_0 == null)
		{
			class37_0.vmethod_17();
			return;
		}
		Enum @enum = (Enum)object_0;
		if (!Class131.smethod_108(@enum.GetType(), object_0, NamingStrategy, out string string_))
		{
			if (!AllowIntegerValues)
			{
				throw Class131.smethod_634((Interface1?)null, class37_0.ContainerPath, "Integer value {0} is not allowed.".smethod_1(CultureInfo.InvariantCulture, @enum.ToString("D")), (Exception?)null);
			}
			class37_0.vmethod_58(object_0);
		}
		else
		{
			class37_0.vmethod_21(string_);
		}
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		if (class28_0.TokenType == JsonToken.Null)
		{
			if (!Class131.smethod_175(type_0))
			{
				throw Class131.smethod_38(class28_0, "Cannot convert null value to {0}.".smethod_1(CultureInfo.InvariantCulture, type_0));
			}
			return null;
		}
		bool flag;
		Type type_ = ((flag = Class131.smethod_175(type_0)) ? Nullable.GetUnderlyingType(type_0) : type_0);
		try
		{
			if (class28_0.TokenType == JsonToken.String)
			{
				string text = class28_0.Value?.ToString();
				if (Class108.smethod_0(text) && flag)
				{
					return null;
				}
				return Class131.smethod_352(type_, NamingStrategy, text, !AllowIntegerValues);
			}
			if (class28_0.TokenType == JsonToken.Integer)
			{
				if (!AllowIntegerValues)
				{
					throw Class131.smethod_38(class28_0, "Integer value {0} is not allowed.".smethod_1(CultureInfo.InvariantCulture, class28_0.Value));
				}
				return Class131.smethod_661(class28_0.Value, CultureInfo.InvariantCulture, type_);
			}
		}
		catch (Exception exception_)
		{
			throw Class131.smethod_200("Error converting value {0} to type '{1}'.".smethod_2(CultureInfo.InvariantCulture, Class131.smethod_575(class28_0.Value), type_0), exception_, class28_0);
		}
		throw Class131.smethod_38(class28_0, "Unexpected token {0} when parsing enum.".smethod_1(CultureInfo.InvariantCulture, class28_0.TokenType));
	}

	public override bool vmethod_2(Type type_0)
	{
		return (Class131.smethod_175(type_0) ? Nullable.GetUnderlyingType(type_0) : type_0).smethod_8();
	}
}
