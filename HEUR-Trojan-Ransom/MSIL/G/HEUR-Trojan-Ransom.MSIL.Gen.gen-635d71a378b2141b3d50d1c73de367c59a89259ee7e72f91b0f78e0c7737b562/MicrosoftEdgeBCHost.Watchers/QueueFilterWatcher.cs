using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class QueueFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResetCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetCandidate()
	{
	}
}
