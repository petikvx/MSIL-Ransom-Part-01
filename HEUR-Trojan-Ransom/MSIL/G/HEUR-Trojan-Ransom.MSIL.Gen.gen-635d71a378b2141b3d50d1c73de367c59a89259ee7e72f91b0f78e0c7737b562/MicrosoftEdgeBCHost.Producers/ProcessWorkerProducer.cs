using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProcessWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceAdapter()
	{
	}
}
