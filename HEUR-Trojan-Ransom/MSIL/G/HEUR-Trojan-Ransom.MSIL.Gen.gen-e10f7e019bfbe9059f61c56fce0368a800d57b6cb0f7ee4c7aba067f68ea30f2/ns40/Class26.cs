using System;
using System.Reflection;

namespace ns40;

internal class Class26
{
	internal static ModuleHandle moduleHandle_0 = smethod_5(smethod_4(typeof(Class26).TypeHandle).Assembly.GetModules()[0]);

	private static object object_0;

	internal static RuntimeTypeHandle smethod_0(int token)
	{
		return moduleHandle_0.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	internal static RuntimeFieldHandle smethod_1(int token)
	{
		return moduleHandle_0.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	internal static bool smethod_2()
	{
		return object_0 == null;
	}

	internal static Class26 smethod_3()
	{
		return (Class26)object_0;
	}

	internal static Type smethod_4(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static ModuleHandle smethod_5(object object_1)
	{
		return ((Module)object_1).ModuleHandle;
	}
}
