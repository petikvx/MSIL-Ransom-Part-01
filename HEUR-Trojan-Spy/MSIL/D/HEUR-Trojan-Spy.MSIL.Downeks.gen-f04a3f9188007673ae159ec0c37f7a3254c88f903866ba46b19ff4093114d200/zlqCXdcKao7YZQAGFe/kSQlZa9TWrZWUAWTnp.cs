using System;
using System.Reflection;

namespace zlqCXdcKao7YZQAGFe;

internal class kSQlZa9TWrZWUAWTnp
{
	internal static ModuleHandle gNRk6Y9h26 = uVPZTHhPt1EXgQpYDEv(t4ckQehyGLM6IjEHclr(typeof(kSQlZa9TWrZWUAWTnp).TypeHandle).Assembly.GetModules()[0]);

	private static kSQlZa9TWrZWUAWTnp z064nDhSJnOdGQDw9S2;

	internal static RuntimeTypeHandle LkQixXdNRDLVn(int token)
	{
		return gNRk6Y9h26.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	internal static RuntimeFieldHandle mRrixXdIWsyOm(int token)
	{
		return gNRk6Y9h26.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	internal static bool ymTclIh3ptabUTBTyfs()
	{
		return z064nDhSJnOdGQDw9S2 == null;
	}

	internal static kSQlZa9TWrZWUAWTnp sfADwAhvDWioHWcAYqg()
	{
		return z064nDhSJnOdGQDw9S2;
	}

	internal static Type t4ckQehyGLM6IjEHclr(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static ModuleHandle uVPZTHhPt1EXgQpYDEv(object object_0)
	{
		return ((Module)object_0).ModuleHandle;
	}
}
