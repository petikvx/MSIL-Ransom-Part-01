using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class VisitorWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceManager()
	{
	}
}
