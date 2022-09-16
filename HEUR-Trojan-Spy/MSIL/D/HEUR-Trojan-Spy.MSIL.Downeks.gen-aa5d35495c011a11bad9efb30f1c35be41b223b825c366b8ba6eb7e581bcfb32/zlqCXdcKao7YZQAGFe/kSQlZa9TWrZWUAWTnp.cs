using System;
using System.Reflection;

namespace zlqCXdcKao7YZQAGFe;

internal class kSQlZa9TWrZWUAWTnp
{
	internal static ModuleHandle gNRk6Y9h26 = ((Module)((object[])tYYCw9rUgR7XJvB9F3v(uawnhGrS6v6aaS6CRaM(typeof(kSQlZa9TWrZWUAWTnp).TypeHandle).Assembly))[0]).ModuleHandle;

	private static kSQlZa9TWrZWUAWTnp xVLZCNrnOQaoDn7dyaT;

	internal static RuntimeTypeHandle kYMrIWA6yci2W(int token)
	{
		return gNRk6Y9h26.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	internal static RuntimeFieldHandle J0ZrIWAa0xljE(int token)
	{
		return gNRk6Y9h26.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	internal static bool dAmEw0r2iThmNjMwxAH()
	{
		return xVLZCNrnOQaoDn7dyaT == null;
	}

	internal static kSQlZa9TWrZWUAWTnp vQJs2frwe0t6XO64nDl()
	{
		return xVLZCNrnOQaoDn7dyaT;
	}

	internal static Type uawnhGrS6v6aaS6CRaM(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object tYYCw9rUgR7XJvB9F3v(object object_0)
	{
		return ((Assembly)object_0).GetModules();
	}
}
