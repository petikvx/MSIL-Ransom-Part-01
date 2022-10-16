using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProducerValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ManageMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageMock()
	{
	}
}
