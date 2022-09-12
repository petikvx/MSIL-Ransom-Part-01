using System;
using ns1;

namespace ns6;

internal abstract class Class15 : Class8
{
	public override bool vmethod_2(Type type_0)
	{
		if (!(type_0 == typeof(DateTime)) && !(type_0 == typeof(DateTime?)))
		{
			if (!(type_0 == typeof(DateTimeOffset)) && !(type_0 == typeof(DateTimeOffset?)))
			{
				return false;
			}
			return true;
		}
		return true;
	}
}
