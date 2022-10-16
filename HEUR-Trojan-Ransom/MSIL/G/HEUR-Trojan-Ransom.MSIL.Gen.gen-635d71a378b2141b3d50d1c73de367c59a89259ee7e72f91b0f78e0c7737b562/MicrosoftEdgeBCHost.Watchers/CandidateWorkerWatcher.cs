using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CandidateWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralGetter()
	{
	}
}
