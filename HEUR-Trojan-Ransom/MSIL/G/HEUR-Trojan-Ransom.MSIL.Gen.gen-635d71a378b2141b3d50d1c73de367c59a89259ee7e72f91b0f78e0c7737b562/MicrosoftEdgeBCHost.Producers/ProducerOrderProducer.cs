using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProducerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceSerializer()
	{
	}
}
