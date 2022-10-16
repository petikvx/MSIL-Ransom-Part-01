using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProductWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LoginClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginClass()
	{
	}
}
