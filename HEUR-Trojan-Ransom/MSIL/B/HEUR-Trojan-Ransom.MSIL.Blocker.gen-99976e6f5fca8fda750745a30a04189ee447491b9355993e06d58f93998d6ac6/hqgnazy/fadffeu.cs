using System;
using System.Reflection;

namespace hqgnazy;

internal sealed class fadffeu
{
	internal static void O(Type[] type_0, int int_0, TypeInfo[] typeInfo_0)
	{
		TypeInfo typeInfo = type_0[int_0].GetTypeInfo();
		if (typeInfo == null)
		{
			throw new NotSupportedException(type_0[int_0].FullName);
		}
		typeInfo_0[int_0] = typeInfo;
	}
}
