using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class EventOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralProduct()
	{
	}
}
