using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CustomerWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceExporter()
	{
	}
}
