using System;
using System.Collections.Generic;
using System.Reflection;
using ns6;
using ns8;

namespace ns3;

internal sealed class Class2 : Assembly
{
	private static IEnumerable<TypeInfo> w
	{
		get
		{
			Type[] types = Class4.q.GetTypes();
			TypeInfo[] array = new TypeInfo[types.Length];
			for (int i = 0; i < types.Length; i++)
			{
				TypeInfo typeInfo = types[i].GetTypeInfo();
				int num = i;
				if (!(typeInfo == null))
				{
					array[num] = typeInfo;
					continue;
				}
				throw new NotSupportedException(types[i].FullName);
			}
			return array;
		}
	}

	internal static void smethod_0()
	{
		foreach (TypeInfo item in w)
		{
			GControl0.smethod_0(item);
		}
	}
}
