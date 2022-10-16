using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PredicateRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateRules()
	{
		WriterPropertyProducer.ResolveStub();
		RateParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateParameter()
	{
	}
}
