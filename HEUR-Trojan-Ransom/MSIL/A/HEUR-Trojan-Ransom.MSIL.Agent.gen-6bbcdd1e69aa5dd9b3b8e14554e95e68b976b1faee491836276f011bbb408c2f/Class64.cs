using System;
using System.Collections.Generic;

internal static class Class64
{
	private static readonly Dictionary<byte, c955c655> dictionary_0;

	static Class64()
	{
		dictionary_0 = new Dictionary<byte, c955c655>();
		Type[] types = typeof(Class64).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (typeof(c955c655).IsAssignableFrom(type) && !type.IsAbstract)
			{
				c955c655 c955c656 = (c955c655)Activator.CreateInstance(type);
				dictionary_0[c955c656.imethod_0()] = c955c656;
			}
		}
	}

	public static c955c655 f7aed62a(byte byte_0)
	{
		return dictionary_0[byte_0];
	}
}
