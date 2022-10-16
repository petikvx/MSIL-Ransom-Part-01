using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IndexerFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerFilter()
	{
		WriterPropertyProducer.ResolveStub();
		WriteCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteCandidate()
	{
	}
}
