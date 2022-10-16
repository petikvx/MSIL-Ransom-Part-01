using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProccesorWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceRef()
	{
	}
}
