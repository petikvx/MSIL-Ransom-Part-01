using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StrategyObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyObject()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralComparator()
	{
	}
}
