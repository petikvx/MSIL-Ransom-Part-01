using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BroadcasterWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceConnection()
	{
	}
}
