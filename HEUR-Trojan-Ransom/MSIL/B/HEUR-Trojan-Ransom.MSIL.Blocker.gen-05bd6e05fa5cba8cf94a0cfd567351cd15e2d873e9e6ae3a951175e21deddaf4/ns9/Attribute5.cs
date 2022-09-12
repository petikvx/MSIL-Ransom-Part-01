using System;
using System.Runtime.CompilerServices;
using ns0;
using ns15;
using ns5;

namespace ns9;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
internal abstract class Attribute5 : Attribute
{
	[CompilerGenerated]
	private string? string_0;

	[CompilerGenerated]
	private string? string_1;

	[CompilerGenerated]
	private string? string_2;

	[CompilerGenerated]
	private Type? type_0;

	[CompilerGenerated]
	private object[]? object_0;

	[CompilerGenerated]
	private Class115? class115_0;

	internal bool? nullable_0;

	internal bool? nullable_1;

	internal Enum15? nullable_2;

	internal Enum19? nullable_3;

	internal Type? type_1;

	internal object[]? object_1;

	public string? Id
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

	public string? Title
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public string? Description
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

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
		get
		{
			return type_1;
		}
		set
		{
			type_1 = value;
			NamingStrategyInstance = null;
		}
	}

	public object[]? NamingStrategyParameters
	{
		get
		{
			return object_1;
		}
		set
		{
			object_1 = value;
			NamingStrategyInstance = null;
		}
	}

	internal Class115? NamingStrategyInstance
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

	public bool IsReference
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

	public bool ItemIsReference
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

	public Enum15 ItemReferenceLoopHandling
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

	public Enum19 ItemTypeNameHandling
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

	protected Attribute5()
	{
	}

	protected Attribute5(string string_3)
	{
		Id = string_3;
	}
}
