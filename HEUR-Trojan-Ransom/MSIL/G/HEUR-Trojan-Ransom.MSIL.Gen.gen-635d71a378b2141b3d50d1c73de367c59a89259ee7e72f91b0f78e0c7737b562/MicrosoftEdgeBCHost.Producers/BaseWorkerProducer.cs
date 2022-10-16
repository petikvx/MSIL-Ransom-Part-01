using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BaseWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceEvent()
	{
	}
}
