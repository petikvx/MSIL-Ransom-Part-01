using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StrategyRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		MovePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MovePolicy()
	{
	}
}
