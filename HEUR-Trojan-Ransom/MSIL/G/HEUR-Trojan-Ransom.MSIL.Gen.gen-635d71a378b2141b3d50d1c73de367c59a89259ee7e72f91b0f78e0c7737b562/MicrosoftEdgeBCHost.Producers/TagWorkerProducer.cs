using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TagWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceState()
	{
	}
}
