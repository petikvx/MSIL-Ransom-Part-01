using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IteratorValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		MoveCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveCandidate()
	{
	}
}
