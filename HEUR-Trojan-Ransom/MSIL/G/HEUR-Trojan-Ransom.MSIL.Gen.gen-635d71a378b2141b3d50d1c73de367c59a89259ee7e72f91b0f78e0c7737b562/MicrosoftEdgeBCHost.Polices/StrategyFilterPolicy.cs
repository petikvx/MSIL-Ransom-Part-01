using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StrategyFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ViewComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewComparator()
	{
	}
}
