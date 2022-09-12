using System;
using System.Collections.Generic;
using ns10;
using ns3;
using ns5;

namespace ns4;

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
		return Class4.smethod_97(object_0, (Type?)null, bool_0);
	}

	public IList<Attribute> imethod_1(Type type_0, bool bool_0)
	{
		return Class4.smethod_97(object_0, type_0, bool_0);
	}
}
