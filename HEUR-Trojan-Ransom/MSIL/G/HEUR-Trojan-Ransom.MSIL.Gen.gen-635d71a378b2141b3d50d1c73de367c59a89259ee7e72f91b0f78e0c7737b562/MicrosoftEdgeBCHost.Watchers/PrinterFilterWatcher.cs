using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PrinterFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectObserver()
	{
	}
}
