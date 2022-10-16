using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PrinterValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceTemplate()
	{
	}
}
