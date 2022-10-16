using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExceptionWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RevertObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertObserver()
	{
	}
}
