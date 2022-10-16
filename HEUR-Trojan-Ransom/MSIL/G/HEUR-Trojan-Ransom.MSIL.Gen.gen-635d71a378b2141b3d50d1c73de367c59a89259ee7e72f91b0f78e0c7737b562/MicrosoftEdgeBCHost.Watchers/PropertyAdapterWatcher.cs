using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PropertyAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralTokenizer()
	{
	}
}
