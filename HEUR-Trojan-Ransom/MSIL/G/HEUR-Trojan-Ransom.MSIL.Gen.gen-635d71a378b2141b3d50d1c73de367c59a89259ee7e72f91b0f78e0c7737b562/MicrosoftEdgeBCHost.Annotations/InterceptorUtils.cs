using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InterceptorUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorUtils()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceGlobal()
	{
	}
}
