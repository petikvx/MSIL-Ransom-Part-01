using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PrinterOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralToken()
	{
	}
}
