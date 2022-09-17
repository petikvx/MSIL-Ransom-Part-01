using System;
using System.Reflection;

namespace zlqCXdcKao7YZQAGFe;

internal class kSQlZa9TWrZWUAWTnp
{
	internal static ModuleHandle gNRk6Y9h26 = c1ZFiZVWZhFcfucR2eL(qvAopHVtqD2ADofO56u(typeof(kSQlZa9TWrZWUAWTnp).TypeHandle).Assembly.GetModules()[0]);

	private static object oeyGUmbzDhdsPSTGEts;

	internal static RuntimeTypeHandle vkJHMafihv8j6(int token)
	{
		return gNRk6Y9h26.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	internal static RuntimeFieldHandle GDAHMafcJJ50Y(int token)
	{
		return gNRk6Y9h26.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	internal static bool usQNOEVdrB4JIdcD0CY()
	{
		return oeyGUmbzDhdsPSTGEts == null;
	}

	internal static kSQlZa9TWrZWUAWTnp aDxc2uVjhqWcRTQuJEa()
	{
		return (kSQlZa9TWrZWUAWTnp)oeyGUmbzDhdsPSTGEts;
	}

	internal static Type qvAopHVtqD2ADofO56u(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static ModuleHandle c1ZFiZVWZhFcfucR2eL(object object_0)
	{
		return ((Module)object_0).ModuleHandle;
	}
}
