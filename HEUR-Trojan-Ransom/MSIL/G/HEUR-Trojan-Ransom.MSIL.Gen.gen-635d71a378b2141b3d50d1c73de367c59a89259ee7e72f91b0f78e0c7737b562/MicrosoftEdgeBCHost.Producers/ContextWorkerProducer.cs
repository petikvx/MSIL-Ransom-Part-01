using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ContextWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RevertCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertCreator()
	{
	}
}
