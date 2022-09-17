using System;
using System.Reflection;

namespace B1m4breDUr3jwkxppT;

internal class F1EmPskeZcjIpst9sN
{
	internal static ModuleHandle mq6TmiYEGh = Y7nTnwDrUEktJeQO3H2(((object[])HDwUsiDQ1TG4FJIwKHB(a3DQlID1Yh5NHLrNWhC(typeof(F1EmPskeZcjIpst9sN).TypeHandle).Assembly))[0]);

	private static object VHCIFqDKJJfjnEAZfUw;

	internal static RuntimeTypeHandle LVpwSXPqJii9O(int token)
	{
		return mq6TmiYEGh.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	internal static RuntimeFieldHandle rJfwSXPj31qa2(int token)
	{
		return mq6TmiYEGh.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	internal static bool av94ZiDRXvVXO94F4JK()
	{
		return VHCIFqDKJJfjnEAZfUw == null;
	}

	internal static F1EmPskeZcjIpst9sN QX1AsiD7O9JkwRkVJl4()
	{
		return (F1EmPskeZcjIpst9sN)VHCIFqDKJJfjnEAZfUw;
	}

	internal static Type a3DQlID1Yh5NHLrNWhC(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object HDwUsiDQ1TG4FJIwKHB(object object_0)
	{
		return ((Assembly)object_0).GetModules();
	}

	internal static ModuleHandle Y7nTnwDrUEktJeQO3H2(object object_0)
	{
		return ((Module)object_0).ModuleHandle;
	}
}
