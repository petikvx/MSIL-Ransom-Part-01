using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ItemWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceResolver()
	{
	}
}
