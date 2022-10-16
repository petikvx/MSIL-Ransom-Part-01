using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IteratorWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceImporter()
	{
	}
}
