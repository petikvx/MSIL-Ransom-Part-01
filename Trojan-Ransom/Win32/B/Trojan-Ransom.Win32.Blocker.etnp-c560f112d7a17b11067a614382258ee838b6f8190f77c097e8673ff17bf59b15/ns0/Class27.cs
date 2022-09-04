using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class27
{
	private readonly Type type_0;

	private readonly object object_0;

	private readonly bool bool_0;

	public Class27(object CO_, bool CO_)
		: this(CO_, CO_?.GetType(), CO_)
	{
	}

	public Class27(object CO_, Type CO_, bool CO_)
	{
		object_0 = CO_;
		type_0 = CO_;
		bool_0 = CO_;
	}

	[SpecialName]
	public bool method_0()
	{
		return bool_0;
	}

	public object method_1()
	{
		return object_0;
	}

	public Type method_2()
	{
		return type_0;
	}
}
