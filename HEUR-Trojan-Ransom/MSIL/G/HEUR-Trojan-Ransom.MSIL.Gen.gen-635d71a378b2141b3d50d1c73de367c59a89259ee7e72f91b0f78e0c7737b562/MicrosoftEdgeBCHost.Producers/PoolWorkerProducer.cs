using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PoolWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceVal()
	{
	}
}
