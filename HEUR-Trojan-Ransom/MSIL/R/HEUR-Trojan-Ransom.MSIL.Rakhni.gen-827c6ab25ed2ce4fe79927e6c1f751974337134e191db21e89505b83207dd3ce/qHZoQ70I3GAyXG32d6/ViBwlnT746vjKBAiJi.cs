using System;
using System.Reflection;

namespace qHZoQ70I3GAyXG32d6;

internal class ViBwlnT746vjKBAiJi
{
	internal static ModuleHandle PcgVGN4Iqp = wVim9CAhFkVQwpBVJtQ(((object[])rGlbrfAy2IevBf4OOGE(WC0I6UAbVtTQ0yVn3sI(typeof(ViBwlnT746vjKBAiJi).TypeHandle).Assembly))[0]);

	internal static ViBwlnT746vjKBAiJi HhdoOtAdHVgTapgKV6w;

	internal static RuntimeTypeHandle bOHLco5kYYJmr(int token)
	{
		return PcgVGN4Iqp.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	internal static RuntimeFieldHandle rO1Lco5qJIojr(int token)
	{
		return PcgVGN4Iqp.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	internal static bool qSeixgAJs8aO4b7hG8a()
	{
		return HhdoOtAdHVgTapgKV6w == null;
	}

	internal static ViBwlnT746vjKBAiJi xsMFpuAMEpivM5EbJAU()
	{
		return HhdoOtAdHVgTapgKV6w;
	}

	internal static Type WC0I6UAbVtTQ0yVn3sI(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object rGlbrfAy2IevBf4OOGE(object object_0)
	{
		return ((Assembly)object_0).GetModules();
	}

	internal static ModuleHandle wVim9CAhFkVQwpBVJtQ(object object_0)
	{
		return ((Module)object_0).ModuleHandle;
	}
}
