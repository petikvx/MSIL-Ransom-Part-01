using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PrinterAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceGetter()
	{
	}
}
