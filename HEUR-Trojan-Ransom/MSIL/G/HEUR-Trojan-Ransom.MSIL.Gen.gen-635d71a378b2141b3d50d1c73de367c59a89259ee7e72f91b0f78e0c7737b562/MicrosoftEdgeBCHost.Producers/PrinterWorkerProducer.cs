using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PrinterWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceRef()
	{
	}
}
