using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PredicateWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralService()
	{
	}
}
