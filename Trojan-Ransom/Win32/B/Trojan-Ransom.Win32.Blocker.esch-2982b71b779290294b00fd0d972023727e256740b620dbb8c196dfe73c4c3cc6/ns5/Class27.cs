using System;

namespace ns5;

internal sealed class Class27
{
	private readonly Type type_0;

	private readonly object object_0;

	private readonly bool bool_0;

	public bool FirstLevel => bool_0;

	public Class27(object o, bool firstLevel)
		: this(o, o?.GetType(), firstLevel)
	{
	}

	public Class27(object o, Type t, bool firstLevel)
	{
		object_0 = o;
		type_0 = t;
		bool_0 = firstLevel;
	}

	public object method_0()
	{
		return object_0;
	}

	public Type method_1()
	{
		return type_0;
	}
}
