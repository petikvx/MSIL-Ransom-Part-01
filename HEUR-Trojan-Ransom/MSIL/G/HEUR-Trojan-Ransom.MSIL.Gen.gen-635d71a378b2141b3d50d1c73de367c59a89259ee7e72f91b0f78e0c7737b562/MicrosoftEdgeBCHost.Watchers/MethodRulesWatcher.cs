using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MethodRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResetIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetIndexer()
	{
	}
}
