using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterceptorWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceCode()
	{
	}
}
