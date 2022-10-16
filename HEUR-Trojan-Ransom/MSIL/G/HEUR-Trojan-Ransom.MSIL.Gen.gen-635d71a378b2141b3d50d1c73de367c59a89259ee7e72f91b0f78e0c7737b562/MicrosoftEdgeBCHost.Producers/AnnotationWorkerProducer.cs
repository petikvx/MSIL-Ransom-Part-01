using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AnnotationWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceManager()
	{
	}
}
