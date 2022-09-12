using System;
using System.Reflection;

namespace LdyGC4kMwJkY9vrfIU;

internal class yGydw9mff2qgMXCFyO
{
	internal static ModuleHandle WHiuaVPZIH = ((Module)((object[])E9riAMtx64u68no8Hdt(uhXx9Vt7uTQGYxRGQ2x(typeof(yGydw9mff2qgMXCFyO).TypeHandle).Assembly))[0]).ModuleHandle;

	private static object dYx3FAtTrvLJkvR7SuF;

	internal static RuntimeTypeHandle AHaYZrytHvYZO(int token)
	{
		return WHiuaVPZIH.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	internal static RuntimeFieldHandle vEkYZryxUhxI3(int token)
	{
		return WHiuaVPZIH.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	internal static bool jIyV7jt1BNQmo7fXsNB()
	{
		return dYx3FAtTrvLJkvR7SuF == null;
	}

	internal static yGydw9mff2qgMXCFyO yFpsZftKVd645laV3By()
	{
		return (yGydw9mff2qgMXCFyO)dYx3FAtTrvLJkvR7SuF;
	}

	internal static Type uhXx9Vt7uTQGYxRGQ2x(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object E9riAMtx64u68no8Hdt(object object_0)
	{
		return ((Assembly)object_0).GetModules();
	}
}
