using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PredicateRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceSchema()
	{
	}
}
