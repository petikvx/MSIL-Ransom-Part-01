using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ComparatorRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorRules()
	{
		WriterPropertyProducer.ResolveStub();
		CountPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountPrinter()
	{
	}
}
