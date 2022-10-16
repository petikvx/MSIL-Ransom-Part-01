using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RegistryWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		MapBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapBroadcaster()
	{
	}
}
