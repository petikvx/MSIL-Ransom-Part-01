using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StatusWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceManager()
	{
	}
}
