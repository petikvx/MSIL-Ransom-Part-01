using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PrinterWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralCode()
	{
	}
}
