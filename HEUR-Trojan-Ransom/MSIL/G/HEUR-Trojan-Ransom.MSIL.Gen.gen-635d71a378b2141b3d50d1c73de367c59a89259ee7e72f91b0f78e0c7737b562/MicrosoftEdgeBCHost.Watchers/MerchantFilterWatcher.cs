using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MerchantFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CountPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountPublisher()
	{
	}
}
