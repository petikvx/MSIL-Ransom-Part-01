using System;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class3
{
	private static bool bool_0;

	static Class3()
	{
		smethod_0();
	}

	internal static void smethod_0()
	{
		if (bool_0)
		{
			return;
		}
		lock (typeof(Class3))
		{
			if (!bool_0)
			{
				bool_0 = true;
				AppDomain.CurrentDomain.ResourceResolve += Class1.smethod_0;
			}
		}
	}
}
