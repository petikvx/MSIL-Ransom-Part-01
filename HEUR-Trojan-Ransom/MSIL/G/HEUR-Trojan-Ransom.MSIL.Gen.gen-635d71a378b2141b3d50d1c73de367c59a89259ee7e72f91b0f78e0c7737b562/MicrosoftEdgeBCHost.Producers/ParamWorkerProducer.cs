using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParamWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchRegistry()
	{
	}
}
