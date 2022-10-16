using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RegWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceBridge()
	{
	}
}
