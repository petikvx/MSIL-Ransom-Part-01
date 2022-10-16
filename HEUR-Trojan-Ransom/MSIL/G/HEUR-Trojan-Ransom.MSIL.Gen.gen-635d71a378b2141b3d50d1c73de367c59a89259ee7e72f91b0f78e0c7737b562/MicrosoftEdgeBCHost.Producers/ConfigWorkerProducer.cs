using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceInstance()
	{
	}
}
