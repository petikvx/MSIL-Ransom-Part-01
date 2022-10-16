using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProducerBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CollectBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectBridge()
	{
	}
}
