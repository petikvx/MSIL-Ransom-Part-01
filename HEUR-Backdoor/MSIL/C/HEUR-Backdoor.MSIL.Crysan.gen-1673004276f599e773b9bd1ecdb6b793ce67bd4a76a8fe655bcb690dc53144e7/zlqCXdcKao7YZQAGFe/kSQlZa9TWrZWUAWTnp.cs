using System;
using System.Reflection;

namespace zlqCXdcKao7YZQAGFe;

internal class kSQlZa9TWrZWUAWTnp
{
	internal static ModuleHandle gNRk6Y9h26 = em76ESV4gGYh4QFLYjQ(hNRno5V7kQ327HeUxUt(typeof(kSQlZa9TWrZWUAWTnp).TypeHandle).Assembly.GetModules()[0]);

	private static object UtKwqAV1RY9APrDhZGB;

	internal static RuntimeTypeHandle KnGe1PkwAmvpm(int token)
	{
		return gNRk6Y9h26.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	internal static RuntimeFieldHandle rH2e1PksOSfOE(int token)
	{
		return gNRk6Y9h26.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	internal static bool X5urH4VIJhnfXBFeQxp()
	{
		return UtKwqAV1RY9APrDhZGB == null;
	}

	internal static kSQlZa9TWrZWUAWTnp AO5bPwVipbI0lhCULuQ()
	{
		return (kSQlZa9TWrZWUAWTnp)UtKwqAV1RY9APrDhZGB;
	}

	internal static Type hNRno5V7kQ327HeUxUt(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static ModuleHandle em76ESV4gGYh4QFLYjQ(object object_0)
	{
		return ((Module)object_0).ModuleHandle;
	}
}
