using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterpreterOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralWorker()
	{
	}
}
