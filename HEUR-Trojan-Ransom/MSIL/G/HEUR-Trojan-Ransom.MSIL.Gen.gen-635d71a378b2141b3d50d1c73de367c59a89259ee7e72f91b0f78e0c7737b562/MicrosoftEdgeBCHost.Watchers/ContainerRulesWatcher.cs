using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContainerRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SearchCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchCollection()
	{
	}
}
