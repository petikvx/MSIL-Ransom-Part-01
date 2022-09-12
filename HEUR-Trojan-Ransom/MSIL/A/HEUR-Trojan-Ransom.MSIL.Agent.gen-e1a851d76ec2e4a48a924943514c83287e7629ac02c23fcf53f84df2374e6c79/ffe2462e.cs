using System;
using System.Collections.Generic;

internal static class ffe2462e
{
	private static readonly Dictionary<byte, bae6a63f> dictionary_0;

	static ffe2462e()
	{
		dictionary_0 = new Dictionary<byte, bae6a63f>();
		Type[] types = typeof(ffe2462e).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (typeof(bae6a63f).IsAssignableFrom(type) && !type.IsAbstract)
			{
				bae6a63f bae6a63f2 = (bae6a63f)Activator.CreateInstance(type);
				dictionary_0[bae6a63f2.e9bf20d3()] = bae6a63f2;
			}
		}
	}

	public static bae6a63f smethod_0(byte byte_0)
	{
		return dictionary_0[byte_0];
	}
}
