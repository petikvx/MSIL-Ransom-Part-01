using System;
using System.Collections.Generic;

internal static class Class59
{
	private static readonly Dictionary<byte, Interface0> dictionary_0;

	static Class59()
	{
		dictionary_0 = new Dictionary<byte, Interface0>();
		Type[] types = typeof(Class59).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (typeof(Interface0).IsAssignableFrom(type) && !type.IsAbstract)
			{
				Interface0 @interface = (Interface0)Activator.CreateInstance(type);
				dictionary_0[@interface.imethod_0()] = @interface;
			}
		}
	}

	public static Interface0 smethod_0(byte byte_0)
	{
		return dictionary_0[byte_0];
	}
}
