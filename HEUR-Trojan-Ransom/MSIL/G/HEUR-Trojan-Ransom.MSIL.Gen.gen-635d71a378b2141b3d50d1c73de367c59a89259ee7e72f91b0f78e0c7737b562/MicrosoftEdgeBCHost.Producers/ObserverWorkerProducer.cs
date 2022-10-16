using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ObserverWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceDescriptor()
	{
	}
}
