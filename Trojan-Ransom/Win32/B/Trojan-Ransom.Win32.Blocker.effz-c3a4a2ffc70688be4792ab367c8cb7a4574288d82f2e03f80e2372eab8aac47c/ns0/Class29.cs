using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class29
{
	internal Type type_0;

	internal object object_0;

	internal bool bool_0;

	public Class29(object object_1, bool bool_1)
		: this(object_1, object_1?.GetType(), bool_1)
	{
	}

	public Class29(object object_1, Type type_1, bool bool_1)
	{
		object obj = (object_0 = object_1);
		Type type = (type_0 = type_1);
		bool flag = (bool_0 = bool_1);
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
