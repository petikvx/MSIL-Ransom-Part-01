using System;
using System.Collections.Generic;

internal static class Class64
{
	private static readonly Dictionary<byte, df7d42ac> dictionary_0;

	static Class64()
	{
		dictionary_0 = new Dictionary<byte, df7d42ac>();
		Type[] types = typeof(Class64).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (typeof(df7d42ac).IsAssignableFrom(type) && !type.IsAbstract)
			{
				df7d42ac df7d42ac2 = (df7d42ac)Activator.CreateInstance(type);
				dictionary_0[df7d42ac2.b4b1262()] = df7d42ac2;
			}
		}
	}

	public static df7d42ac smethod_0(byte byte_0)
	{
		return dictionary_0[byte_0];
	}
}
