using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StrategyOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralToken()
	{
	}
}
