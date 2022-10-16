using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PredicateWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceVal()
	{
	}
}
