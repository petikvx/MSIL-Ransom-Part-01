using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConsumerAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralQueue()
	{
	}
}
