using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PredicateReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralIdentifier()
	{
	}
}
