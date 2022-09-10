using System;

namespace ns4;

internal sealed class Class39
{
	internal readonly Type type_0;

	internal readonly object object_0;

	internal readonly bool bool_0;

	public bool FirstLevel => bool_0;

	public Class39(object o, bool firstLevel)
		: this(o, o?.GetType(), firstLevel)
	{
	}

	public Class39(object o, Type t, bool firstLevel)
	{
		object_0 = o;
		type_0 = t;
		bool_0 = firstLevel;
	}
}
