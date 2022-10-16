using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CandidateOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralTask()
	{
	}
}
