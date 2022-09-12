using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ns0;
using ns10;
using ns15;
using ns17;
using ns18;
using ns2;
using ns5;
using ns7;
using ns8;

namespace ns6;

internal class Class25 : Class9
{
	[CompilerGenerated]
	private Class115? class115_0;

	[CompilerGenerated]
	private bool bool_0 = true;

	[Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
	public bool CamelCaseText
	{
		get
		{
			if (!(NamingStrategy is Class116))
			{
				return false;
			}
			return true;
		}
		set
		{
			if (value)
			{
				if (!(NamingStrategy is Class116))
				{
					NamingStrategy = new Class116();
				}
			}
			else if (NamingStrategy is Class116)
			{
				NamingStrategy = null;
			}
		}
	}

	public Class115? NamingStrategy
	{
		[CompilerGenerated]
		get
		{
			return class115_0;
		}
		[CompilerGenerated]
		set
		{
			class115_0 = value;
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

	public Class25()
	{
	}

	[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
	public Class25(bool bool_1)
	{
		if (bool_1)
		{
			NamingStrategy = new Class116();
		}
	}

	public Class25(Class115 class115_1, bool bool_1 = true)
	{
		NamingStrategy = class115_1;
		AllowIntegerValues = bool_1;
	}

	public Class25(Type type_0)
	{
		Class113.smethod_0(type_0, "namingStrategyType");
		NamingStrategy = Class4.smethod_631((object[])null, type_0);
	}

	public Class25(Type type_0, object[] object_0)
	{
		Class113.smethod_0(type_0, "namingStrategyType");
		NamingStrategy = Class4.smethod_631(object_0, type_0);
	}

	public Class25(Type type_0, object[] object_0, bool bool_1)
	{
		Class113.smethod_0(type_0, "namingStrategyType");
		NamingStrategy = Class4.smethod_631(object_0, type_0);
		AllowIntegerValues = bool_1;
	}

	public override void vmethod_0(Class38 class38_0, object? object_0, Class34 class34_0)
	{
		if (object_0 == null)
		{
			class38_0.vmethod_17();
			return;
		}
		Enum @enum = (Enum)object_0;
		if (!Class4.smethod_392(@enum.GetType(), object_0, NamingStrategy, out string string_))
		{
			if (!AllowIntegerValues)
			{
				throw Class4.smethod_91((Interface1?)null, class38_0.ContainerPath, "Integer value {0} is not allowed.".smethod_1(CultureInfo.InvariantCulture, @enum.ToString("D")), (Exception?)null);
			}
			class38_0.vmethod_58(object_0);
		}
		else
		{
			class38_0.vmethod_21(string_);
		}
	}

	public override object? vmethod_1(Class29 class29_0, Type type_0, object? object_0, Class34 class34_0)
	{
		if (class29_0.TokenType == JsonToken.Null)
		{
			if (!Class4.smethod_92(type_0))
			{
				throw Class4.smethod_777(class29_0, "Cannot convert null value to {0}.".smethod_1(CultureInfo.InvariantCulture, type_0));
			}
			return null;
		}
		bool flag;
		Type type_ = ((flag = Class4.smethod_92(type_0)) ? Nullable.GetUnderlyingType(type_0) : type_0);
		try
		{
			if (class29_0.TokenType == JsonToken.String)
			{
				string text = class29_0.Value?.ToString();
				if (Class109.smethod_0(text) && flag)
				{
					return null;
				}
				return Class4.smethod_202(type_, NamingStrategy, text, !AllowIntegerValues);
			}
			if (class29_0.TokenType == JsonToken.Integer)
			{
				if (!AllowIntegerValues)
				{
					throw Class4.smethod_777(class29_0, "Integer value {0} is not allowed.".smethod_1(CultureInfo.InvariantCulture, class29_0.Value));
				}
				return Class4.smethod_487(class29_0.Value, CultureInfo.InvariantCulture, type_);
			}
		}
		catch (Exception exception_)
		{
			throw Class4.smethod_153("Error converting value {0} to type '{1}'.".smethod_2(CultureInfo.InvariantCulture, Class4.smethod_269(class29_0.Value), type_0), class29_0, exception_);
		}
		throw Class4.smethod_777(class29_0, "Unexpected token {0} when parsing enum.".smethod_1(CultureInfo.InvariantCulture, class29_0.TokenType));
	}

	public override bool vmethod_2(Type type_0)
	{
		return (Class4.smethod_92(type_0) ? Nullable.GetUnderlyingType(type_0) : type_0).smethod_8();
	}
}
