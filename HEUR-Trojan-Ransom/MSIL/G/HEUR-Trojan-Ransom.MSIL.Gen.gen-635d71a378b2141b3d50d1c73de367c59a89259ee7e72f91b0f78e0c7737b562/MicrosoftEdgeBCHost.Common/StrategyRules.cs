using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StrategyRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyRules()
	{
		WriterPropertyProducer.ResolveStub();
		FillListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillListener()
	{
	}
}
