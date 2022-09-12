using System;
using System.Collections.Generic;
using ns14;
using ns6;
using ns9;

namespace ns7;

internal class Class158 : Interface9
{
	private readonly object object_0;

	public Class158(object object_1)
	{
		Class113.smethod_0(object_1, "attributeProvider");
		object_0 = object_1;
	}

	public IList<Attribute> imethod_0(bool bool_0)
	{
		return Class7.smethod_714(object_0, (Type?)null, bool_0);
	}

	public IList<Attribute> imethod_1(Type type_0, bool bool_0)
	{
		return Class7.smethod_714(object_0, type_0, bool_0);
	}
}
