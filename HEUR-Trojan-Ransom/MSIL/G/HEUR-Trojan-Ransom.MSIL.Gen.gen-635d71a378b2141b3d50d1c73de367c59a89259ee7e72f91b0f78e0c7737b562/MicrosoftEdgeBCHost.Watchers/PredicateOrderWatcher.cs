using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PredicateOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralSystem()
	{
	}
}
