using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PrinterContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterContext()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceRequest()
	{
	}
}
