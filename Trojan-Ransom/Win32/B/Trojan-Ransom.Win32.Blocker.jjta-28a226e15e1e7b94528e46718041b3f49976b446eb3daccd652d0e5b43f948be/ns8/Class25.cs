using System;
using System.Runtime.CompilerServices;

namespace ns8;

internal sealed class Class25
{
	private readonly Type type_0;

	private readonly object object_0;

	private readonly bool bool_0;

	public Class25(object object_1, bool bool_1)
		: this(object_1, object_1?.GetType(), bool_1)
	{
	}

	public Class25(object object_1, Type type_1, bool bool_1)
	{
		object_0 = object_1;
		type_0 = type_1;
		bool_0 = bool_1;
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
