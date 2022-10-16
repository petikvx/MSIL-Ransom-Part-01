using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AlgoRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InitRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitRule()
	{
	}
}
