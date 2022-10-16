using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExporterRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyPrinter()
	{
	}
}
