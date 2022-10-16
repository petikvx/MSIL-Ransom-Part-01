using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CandidateExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateExpression()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralPrototype()
	{
	}
}
