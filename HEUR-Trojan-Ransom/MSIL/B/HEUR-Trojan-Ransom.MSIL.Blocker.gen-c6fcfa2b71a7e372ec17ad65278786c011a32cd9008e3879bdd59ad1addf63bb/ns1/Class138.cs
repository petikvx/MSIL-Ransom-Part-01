using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using ns13;
using ns17;
using ns4;
using ns6;
using ns8;

namespace ns1;

internal class Class138 : Class137
{
	internal Class137? class137_0;

	internal Class137? class137_1;

	[CompilerGenerated]
	private Class8? class8_2;

	[CompilerGenerated]
	private bool? nullable_1;

	[CompilerGenerated]
	private Enum15? nullable_2;

	[CompilerGenerated]
	private Enum19? nullable_3;

	internal Class137? ItemContract
	{
		get
		{
			return class137_0;
		}
		set
		{
			class137_0 = value;
			if (class137_0 != null)
			{
				class137_1 = (class137_0!.UnderlyingType.smethod_10() ? class137_0 : null);
			}
			else
			{
				class137_1 = null;
			}
		}
	}

	internal Class137? FinalItemContract => class137_1;

	public Class8? ItemConverter
	{
		[CompilerGenerated]
		get
		{
			return class8_2;
		}
		[CompilerGenerated]
		set
		{
			class8_2 = value;
		}
	}

	public bool? ItemIsReference
	{
		[CompilerGenerated]
		get
		{
			return nullable_1;
		}
		[CompilerGenerated]
		set
		{
			nullable_1 = value;
		}
	}

	public Enum15? ItemReferenceLoopHandling
	{
		[CompilerGenerated]
		get
		{
			return nullable_2;
		}
		[CompilerGenerated]
		set
		{
			nullable_2 = value;
		}
	}

	public Enum19? ItemTypeNameHandling
	{
		[CompilerGenerated]
		get
		{
			return nullable_3;
		}
		[CompilerGenerated]
		set
		{
			nullable_3 = value;
		}
	}

	internal Class138(Type type_3)
		: base(type_3)
	{
		Attribute5 attribute = JsonTypeReflector.smethod_0<Attribute5>(type_3);
		if (attribute != null)
		{
			if (attribute.ItemConverterType != null)
			{
				ItemConverter = Class131.smethod_756(attribute.ItemConverterType, attribute.ItemConverterParameters);
			}
			ItemIsReference = attribute.nullable_1;
			ItemReferenceLoopHandling = attribute.nullable_2;
			ItemTypeNameHandling = attribute.nullable_3;
		}
	}
}
