using System;
using System.Runtime.CompilerServices;

namespace ns13;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
internal sealed class Attribute10 : Attribute
{
	internal readonly Type type_0;

	[CompilerGenerated]
	private readonly object[]? object_0;

	public Type ConverterType => type_0;

	public object[]? ConverterParameters
	{
		[CompilerGenerated]
		get
		{
			return object_0;
		}
	}

	public Attribute10(Type type_1)
	{
		if (type_1 == null)
		{
			throw new ArgumentNullException("converterType");
		}
		type_0 = type_1;
	}

	public Attribute10(Type type_1, params object[] object_1)
		: this(type_1)
	{
		object_0 = object_1;
	}
}
