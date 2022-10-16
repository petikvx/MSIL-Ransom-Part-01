using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class HelperWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PublishPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishPool()
	{
	}
}
