using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PredicateObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateObject()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralCandidate()
	{
	}
}
