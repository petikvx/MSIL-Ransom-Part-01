using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PropertyWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfacePredicate()
	{
	}
}
