using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal sealed class ProductRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] RunStub(int initLow)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SearchServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchServer()
	{
	}
}
