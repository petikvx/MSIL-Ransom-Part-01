using System;
using System.Collections.Generic;

internal static class Class60
{
	private static readonly Dictionary<byte, Interface0> df35c65a;

	static Class60()
	{
		df35c65a = new Dictionary<byte, Interface0>();
		Type[] types = typeof(Class60).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (typeof(Interface0).IsAssignableFrom(type) && !type.IsAbstract)
			{
				Interface0 @interface = (Interface0)Activator.CreateInstance(type);
				df35c65a[@interface.f998adc2()] = @interface;
			}
		}
	}

	public static Interface0 smethod_0(byte byte_0)
	{
		return df35c65a[byte_0];
	}
}
