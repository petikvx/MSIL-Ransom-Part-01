using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MapperWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceQueue()
	{
	}
}
