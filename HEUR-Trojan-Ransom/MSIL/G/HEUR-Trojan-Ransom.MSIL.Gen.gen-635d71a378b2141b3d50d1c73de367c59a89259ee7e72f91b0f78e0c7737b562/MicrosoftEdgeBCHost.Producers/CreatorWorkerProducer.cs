using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CreatorWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateObserver()
	{
	}
}
