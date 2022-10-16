using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class UtilsWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchSystem()
	{
	}
}
