using System;
using System.Collections.Generic;

internal static class Class63
{
	private static readonly Dictionary<byte, Interface0> c11e007c;

	static Class63()
	{
		c11e007c = new Dictionary<byte, Interface0>();
		Type[] types = typeof(Class63).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (typeof(Interface0).IsAssignableFrom(type) && !type.IsAbstract)
			{
				Interface0 @interface = (Interface0)Activator.CreateInstance(type);
				c11e007c[@interface.imethod_0()] = @interface;
			}
		}
	}

	public static Interface0 ff226187(byte byte_0)
	{
		return c11e007c[byte_0];
	}
}
