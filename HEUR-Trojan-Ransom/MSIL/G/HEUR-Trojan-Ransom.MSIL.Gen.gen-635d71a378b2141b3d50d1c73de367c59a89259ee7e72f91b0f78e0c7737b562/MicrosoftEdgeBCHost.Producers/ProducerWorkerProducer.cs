using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProducerWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceAttribute()
	{
	}
}
