using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CandidateValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ReadWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadWatcher()
	{
	}
}
