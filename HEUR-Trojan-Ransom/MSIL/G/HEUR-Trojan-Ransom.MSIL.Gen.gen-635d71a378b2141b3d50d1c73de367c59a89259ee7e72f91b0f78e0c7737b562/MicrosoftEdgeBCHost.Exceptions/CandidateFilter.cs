using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CandidateFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateFilter()
	{
		WriterPropertyProducer.ResolveStub();
		VisitIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitIterator()
	{
	}
}
