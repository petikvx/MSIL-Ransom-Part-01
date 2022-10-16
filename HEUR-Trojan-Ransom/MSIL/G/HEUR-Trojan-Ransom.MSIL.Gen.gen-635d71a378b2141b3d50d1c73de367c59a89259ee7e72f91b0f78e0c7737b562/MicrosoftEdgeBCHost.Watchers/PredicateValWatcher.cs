using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PredicateValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceMock()
	{
	}
}
