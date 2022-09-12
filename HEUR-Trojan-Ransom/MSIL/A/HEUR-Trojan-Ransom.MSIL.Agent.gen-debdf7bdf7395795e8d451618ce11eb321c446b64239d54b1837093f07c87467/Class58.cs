using System;
using System.Collections.Generic;

internal static class Class58
{
	private static readonly Dictionary<byte, efe82791> ecdd5317;

	static Class58()
	{
		ecdd5317 = new Dictionary<byte, efe82791>();
		Type[] types = typeof(Class58).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (typeof(efe82791).IsAssignableFrom(type) && !type.IsAbstract)
			{
				efe82791 efe82792 = (efe82791)Activator.CreateInstance(type);
				ecdd5317[efe82792.imethod_0()] = efe82792;
			}
		}
	}

	public static efe82791 smethod_0(byte byte_0)
	{
		return ecdd5317[byte_0];
	}
}
