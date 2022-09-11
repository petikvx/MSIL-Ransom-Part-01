using System;
using System.Collections.Generic;
using System.Reflection;
using ns5;
using ns7;

namespace ns1;

internal sealed class Class0 : Assembly
{
	private static IEnumerable<TypeInfo> e
	{
		get
		{
			Type[] types = GClass0.q.GetTypes();
			TypeInfo[] array = new TypeInfo[types.Length];
			for (int i = 0; i < types.Length; i++)
			{
				TypeInfo typeInfo = types[i].GetTypeInfo();
				if (!(typeInfo == null))
				{
					array[i] = typeInfo;
					continue;
				}
				throw new NotSupportedException(types[i].FullName);
			}
			return array;
		}
	}

	internal static void smethod_0()
	{
		foreach (TypeInfo item in e)
		{
			GControl0.smethod_0(item);
		}
	}
}
