using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InterceptorContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorContext()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceContainer()
	{
	}
}
