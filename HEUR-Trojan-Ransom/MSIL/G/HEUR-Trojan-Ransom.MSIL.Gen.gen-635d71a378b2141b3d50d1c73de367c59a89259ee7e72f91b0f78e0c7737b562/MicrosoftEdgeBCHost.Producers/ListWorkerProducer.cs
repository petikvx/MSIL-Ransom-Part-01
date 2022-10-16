using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceBroadcaster()
	{
	}
}
