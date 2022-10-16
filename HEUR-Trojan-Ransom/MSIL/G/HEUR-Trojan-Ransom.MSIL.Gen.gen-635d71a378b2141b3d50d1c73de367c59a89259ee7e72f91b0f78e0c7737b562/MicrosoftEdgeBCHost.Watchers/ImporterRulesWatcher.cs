using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ImporterRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PostMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostMap()
	{
	}
}
