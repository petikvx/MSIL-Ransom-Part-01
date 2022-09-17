using System;
using System.Reflection;

namespace zlqCXdcKao7YZQAGFe;

internal class kSQlZa9TWrZWUAWTnp
{
	internal static ModuleHandle gNRk6Y9h26 = V87B1Cdh9xFI45Gjhn7(((object[])EXsbDcdKNByMLfOtVcP(CiVEp6dfFklXyUxgsTk(typeof(kSQlZa9TWrZWUAWTnp).TypeHandle).Assembly))[0]);

	private static kSQlZa9TWrZWUAWTnp olJuRydrvcsF1fIZ5mk;

	internal static RuntimeTypeHandle Fe0gdfeqAWHRK(int token)
	{
		return gNRk6Y9h26.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	internal static RuntimeFieldHandle HEDgdfejbbkRH(int token)
	{
		return gNRk6Y9h26.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	internal static bool zqIvqfdor4AWjqNdaWR()
	{
		return olJuRydrvcsF1fIZ5mk == null;
	}

	internal static kSQlZa9TWrZWUAWTnp QhGAbDddNosHFZHfD08()
	{
		return olJuRydrvcsF1fIZ5mk;
	}

	internal static Type CiVEp6dfFklXyUxgsTk(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object EXsbDcdKNByMLfOtVcP(object object_0)
	{
		return ((Assembly)object_0).GetModules();
	}

	internal static ModuleHandle V87B1Cdh9xFI45Gjhn7(object object_0)
	{
		return ((Module)object_0).ModuleHandle;
	}
}
