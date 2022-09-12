using System;
using ns7;

namespace ns4;

internal abstract class Class16 : Class9
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
