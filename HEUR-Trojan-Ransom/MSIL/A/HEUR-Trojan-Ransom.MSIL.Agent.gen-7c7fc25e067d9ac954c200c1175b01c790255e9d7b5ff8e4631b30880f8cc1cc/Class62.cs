using System;
using System.Collections.Generic;

internal static class Class62
{
	private static readonly Dictionary<byte, Interface1> dictionary_0;

	static Class62()
	{
		dictionary_0 = new Dictionary<byte, Interface1>();
		Type[] types = typeof(Class62).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (typeof(Interface1).IsAssignableFrom(type) && !type.IsAbstract)
			{
				Interface1 @interface = (Interface1)Activator.CreateInstance(type);
				dictionary_0[@interface.imethod_0()] = @interface;
			}
		}
	}

	public static Interface1 ff226187(byte byte_0)
	{
		return dictionary_0[byte_0];
	}
}
