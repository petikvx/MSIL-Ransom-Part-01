using System;
using System.Runtime.CompilerServices;
using ns0;
using ns10;
using ns13;
using ns3;
using ns4;

namespace ns18;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
internal sealed class Attribute13 : Attribute
{
	internal Enum12? nullable_0;

	internal Enum4? nullable_1;

	internal Enum15? nullable_2;

	internal Enum13? nullable_3;

	internal Enum19? nullable_4;

	internal bool? nullable_5;

	internal int? nullable_6;

	internal Enum16? nullable_7;

	internal bool? nullable_8;

	internal Enum15? nullable_9;

	internal Enum19? nullable_10;

	[CompilerGenerated]
	private Type? type_0;

	[CompilerGenerated]
	private object[]? object_0;

	[CompilerGenerated]
	private Type? type_1;

	[CompilerGenerated]
	private object[]? object_1;

	[CompilerGenerated]
	private string? string_0;

	public Type? ItemConverterType
	{
		[CompilerGenerated]
		get
		{
			return type_0;
		}
		[CompilerGenerated]
		set
		{
			type_0 = value;
		}
	}

	public object[]? ItemConverterParameters
	{
		[CompilerGenerated]
		get
		{
			return object_0;
		}
		[CompilerGenerated]
		set
		{
			object_0 = value;
		}
	}

	public Type? NamingStrategyType
	{
		[CompilerGenerated]
		get
		{
			return type_1;
		}
		[CompilerGenerated]
		set
		{
			type_1 = value;
		}
	}

	public object[]? NamingStrategyParameters
	{
		[CompilerGenerated]
		get
		{
			return object_1;
		}
		[CompilerGenerated]
		set
		{
			object_1 = value;
		}
	}

	public Enum12 NullValueHandling
	{
		get
		{
			return nullable_0.GetValueOrDefault();
		}
		set
		{
			nullable_0 = value;
		}
	}

	public Enum4 DefaultValueHandling
	{
		get
		{
			return nullable_1.GetValueOrDefault();
		}
		set
		{
			nullable_1 = value;
		}
	}

	public Enum15 ReferenceLoopHandling
	{
		get
		{
			return nullable_2.GetValueOrDefault();
		}
		set
		{
			nullable_2 = value;
		}
	}

	public Enum13 ObjectCreationHandling
	{
		get
		{
			return nullable_3.GetValueOrDefault();
		}
		set
		{
			nullable_3 = value;
		}
	}

	public Enum19 TypeNameHandling
	{
		get
		{
			return nullable_4.GetValueOrDefault();
		}
		set
		{
			nullable_4 = value;
		}
	}

	public bool IsReference
	{
		get
		{
			return nullable_5.GetValueOrDefault();
		}
		set
		{
			nullable_5 = value;
		}
	}

	public int Order
	{
		get
		{
			return nullable_6.GetValueOrDefault();
		}
		set
		{
			nullable_6 = value;
		}
	}

	public Enum16 Required
	{
		get
		{
			return nullable_7.GetValueOrDefault();
		}
		set
		{
			nullable_7 = value;
		}
	}

	public string? PropertyName
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public Enum15 ItemReferenceLoopHandling
	{
		get
		{
			return nullable_9.GetValueOrDefault();
		}
		set
		{
			nullable_9 = value;
		}
	}

	public Enum19 ItemTypeNameHandling
	{
		get
		{
			return nullable_10.GetValueOrDefault();
		}
		set
		{
			nullable_10 = value;
		}
	}

	public bool ItemIsReference
	{
		get
		{
			return nullable_8.GetValueOrDefault();
		}
		set
		{
			nullable_8 = value;
		}
	}

	public Attribute13()
	{
	}

	public Attribute13(string string_1)
	{
		PropertyName = string_1;
	}
}
