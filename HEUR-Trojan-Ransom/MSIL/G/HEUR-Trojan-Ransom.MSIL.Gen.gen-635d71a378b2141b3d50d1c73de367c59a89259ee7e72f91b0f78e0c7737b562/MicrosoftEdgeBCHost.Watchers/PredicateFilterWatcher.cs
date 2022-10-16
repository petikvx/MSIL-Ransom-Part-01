using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PredicateFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceWorker()
	{
	}
}
