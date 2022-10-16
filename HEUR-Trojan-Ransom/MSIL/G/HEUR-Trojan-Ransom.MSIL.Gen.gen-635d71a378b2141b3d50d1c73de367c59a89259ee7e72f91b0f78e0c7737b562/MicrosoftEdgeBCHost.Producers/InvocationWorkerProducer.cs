using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InvocationWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceEvent()
	{
	}
}
