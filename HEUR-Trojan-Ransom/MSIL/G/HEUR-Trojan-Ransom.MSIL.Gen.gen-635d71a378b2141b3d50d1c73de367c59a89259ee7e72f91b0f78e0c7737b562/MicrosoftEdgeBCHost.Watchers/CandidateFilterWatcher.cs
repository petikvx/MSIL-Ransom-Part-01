using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CandidateFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PublishObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishObserver()
	{
	}
}
