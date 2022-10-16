using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CandidateWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceMap()
	{
	}
}
