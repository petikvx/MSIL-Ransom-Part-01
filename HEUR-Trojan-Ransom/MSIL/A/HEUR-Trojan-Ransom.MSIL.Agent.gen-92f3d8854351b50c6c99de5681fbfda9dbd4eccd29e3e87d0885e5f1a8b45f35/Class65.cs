using System;
using System.Collections.Generic;

internal static class Class65
{
	private static readonly Dictionary<byte, d88be11e> dictionary_0;

	static Class65()
	{
		dictionary_0 = new Dictionary<byte, d88be11e>();
		Type[] types = typeof(Class65).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (typeof(d88be11e).IsAssignableFrom(type) && !type.IsAbstract)
			{
				d88be11e d88be11e2 = (d88be11e)Activator.CreateInstance(type);
				dictionary_0[d88be11e2.b4b1262()] = d88be11e2;
			}
		}
	}

	public static d88be11e smethod_0(byte byte_0)
	{
		return dictionary_0[byte_0];
	}
}
