using System;
using System.Reflection;

namespace ns51;

internal class Class30
{
	internal static ModuleHandle moduleHandle_0 = smethod_5(((object[])smethod_4(typeof(Class30).Assembly))[0]);

	internal static object object_0;

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

	internal static Class30 smethod_3()
	{
		return (Class30)object_0;
	}

	internal static object smethod_4(object object_1)
	{
		return ((Assembly)object_1).GetModules();
	}

	internal static ModuleHandle smethod_5(object object_1)
	{
		return ((Module)object_1).ModuleHandle;
	}
}
