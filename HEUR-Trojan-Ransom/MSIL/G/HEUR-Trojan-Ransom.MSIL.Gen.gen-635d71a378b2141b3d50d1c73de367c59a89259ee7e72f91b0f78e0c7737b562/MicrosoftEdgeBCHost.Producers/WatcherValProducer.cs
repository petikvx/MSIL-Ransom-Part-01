using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WatcherValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		QueryParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryParams()
	{
	}
}
