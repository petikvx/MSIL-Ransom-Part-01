using System;
using System.Collections.Generic;

internal static class dfbbb5f1
{
	private static readonly Dictionary<byte, Interface0> e355e14b;

	static dfbbb5f1()
	{
		e355e14b = new Dictionary<byte, Interface0>();
		Type[] types = typeof(dfbbb5f1).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (typeof(Interface0).IsAssignableFrom(type) && !type.IsAbstract)
			{
				Interface0 @interface = (Interface0)Activator.CreateInstance(type);
				e355e14b[@interface.e9bf20d3()] = @interface;
			}
		}
	}

	public static Interface0 smethod_0(byte byte_0)
	{
		return e355e14b[byte_0];
	}
}
