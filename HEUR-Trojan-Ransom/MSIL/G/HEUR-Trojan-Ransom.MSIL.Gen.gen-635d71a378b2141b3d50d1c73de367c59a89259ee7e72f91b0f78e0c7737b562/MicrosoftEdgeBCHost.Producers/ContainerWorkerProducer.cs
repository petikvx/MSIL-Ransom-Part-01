using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ContainerWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceSetter()
	{
	}
}
