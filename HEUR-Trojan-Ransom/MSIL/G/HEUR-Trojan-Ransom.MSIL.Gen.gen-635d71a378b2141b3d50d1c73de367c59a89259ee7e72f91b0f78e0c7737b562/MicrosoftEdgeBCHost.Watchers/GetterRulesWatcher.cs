using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class GetterRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatDispatcher()
	{
	}
}
