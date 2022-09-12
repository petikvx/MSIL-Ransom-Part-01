using System;
using System.Reflection;

namespace ns4;

internal sealed class Class3
{
	internal static void smethod_0(Type[] type_0, int int_0, TypeInfo[] typeInfo_0)
	{
		TypeInfo typeInfo = type_0[int_0].GetTypeInfo();
		if (!(typeInfo == null))
		{
			typeInfo_0[int_0] = typeInfo;
		}
	}
}
