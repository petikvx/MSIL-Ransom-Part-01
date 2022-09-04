using System;

namespace ns7;

internal class Class20
{
	internal readonly Type type_0;

	internal readonly object object_0;

	internal readonly bool bool_0;

	public Class20(object object_1, bool bool_1)
		: this(object_1, object_1?.GetType(), bool_1)
	{
	}

	public Class20(object object_1, Type type_1, bool bool_1)
	{
		object_0 = object_1;
		type_0 = type_1;
		bool_0 = bool_1;
	}
}
