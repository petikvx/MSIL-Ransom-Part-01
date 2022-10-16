using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProxyAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralBroadcaster()
	{
	}
}
