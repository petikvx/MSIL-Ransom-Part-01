using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ValAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralSerializer()
	{
	}
}
