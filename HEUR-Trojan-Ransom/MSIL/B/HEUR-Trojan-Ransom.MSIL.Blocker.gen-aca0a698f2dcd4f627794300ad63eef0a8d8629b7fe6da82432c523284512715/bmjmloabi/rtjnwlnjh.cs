using System;
using System.Reflection;

namespace bmjmloabi;

internal sealed class rtjnwlnjh
{
	internal static void c(Type[] type_0, int int_0, TypeInfo[] typeInfo_0)
	{
		TypeInfo typeInfo = type_0[int_0].GetTypeInfo();
		if (typeInfo == null)
		{
			throw new NotSupportedException(type_0[int_0].FullName);
		}
		typeInfo_0[int_0] = typeInfo;
	}
}
