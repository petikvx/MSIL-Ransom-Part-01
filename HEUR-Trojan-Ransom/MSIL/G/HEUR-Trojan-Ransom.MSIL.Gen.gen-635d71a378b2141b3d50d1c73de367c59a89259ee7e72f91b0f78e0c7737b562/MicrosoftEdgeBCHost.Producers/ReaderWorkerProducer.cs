using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ReaderWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CalcConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcConsumer()
	{
	}
}
