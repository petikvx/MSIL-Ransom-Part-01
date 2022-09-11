using System;
using System.Reflection;

namespace xrkys;

internal sealed class ezkuh
{
	internal static void f(Type[] type_0, int int_0, TypeInfo[] typeInfo_0)
	{
		TypeInfo typeInfo = type_0[int_0].GetTypeInfo();
		if (typeInfo == null)
		{
			throw new NotSupportedException(type_0[int_0].FullName);
		}
		typeInfo_0[int_0] = typeInfo;
	}
}
