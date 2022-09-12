using System;
using System.Collections.Generic;

internal static class Class61
{
	private static readonly Dictionary<byte, f788ae7e> dictionary_0;

	static Class61()
	{
		dictionary_0 = new Dictionary<byte, f788ae7e>();
		Type[] types = typeof(Class61).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (typeof(f788ae7e).IsAssignableFrom(type) && !type.IsAbstract)
			{
				f788ae7e f788ae7e2 = (f788ae7e)Activator.CreateInstance(type);
				dictionary_0[f788ae7e2.f998adc2()] = f788ae7e2;
			}
		}
	}

	public static f788ae7e smethod_0(byte byte_0)
	{
		return dictionary_0[byte_0];
	}
}
