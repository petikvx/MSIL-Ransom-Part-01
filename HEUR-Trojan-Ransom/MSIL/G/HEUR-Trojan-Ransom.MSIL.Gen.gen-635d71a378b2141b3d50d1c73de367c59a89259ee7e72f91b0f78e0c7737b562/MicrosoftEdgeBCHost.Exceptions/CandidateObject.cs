using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CandidateObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateObject()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralComparator()
	{
	}
}
