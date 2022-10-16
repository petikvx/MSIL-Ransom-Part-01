using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MapWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceManager()
	{
	}
}
