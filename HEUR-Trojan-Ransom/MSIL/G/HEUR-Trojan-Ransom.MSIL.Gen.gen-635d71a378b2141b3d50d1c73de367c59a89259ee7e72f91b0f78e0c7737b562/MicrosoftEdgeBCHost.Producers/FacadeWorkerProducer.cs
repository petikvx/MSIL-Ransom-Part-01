using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FacadeWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ComparePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComparePool()
	{
	}
}
