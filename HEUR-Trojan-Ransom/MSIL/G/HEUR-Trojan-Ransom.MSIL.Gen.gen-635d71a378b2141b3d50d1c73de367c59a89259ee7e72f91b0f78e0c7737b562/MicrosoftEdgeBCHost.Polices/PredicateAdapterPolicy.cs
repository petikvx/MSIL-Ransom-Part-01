using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PredicateAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralReponse()
	{
	}
}
