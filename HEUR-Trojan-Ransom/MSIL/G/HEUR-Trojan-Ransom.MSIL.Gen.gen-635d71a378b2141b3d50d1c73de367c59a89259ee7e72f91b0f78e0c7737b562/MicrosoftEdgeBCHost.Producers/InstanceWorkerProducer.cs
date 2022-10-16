using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InstanceWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceMethod()
	{
	}
}
