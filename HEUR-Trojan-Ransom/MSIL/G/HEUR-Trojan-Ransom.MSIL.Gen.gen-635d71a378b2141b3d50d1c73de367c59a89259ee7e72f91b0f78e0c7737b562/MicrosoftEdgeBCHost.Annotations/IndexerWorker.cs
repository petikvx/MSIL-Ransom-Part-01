using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IndexerWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerWorker()
	{
		WriterPropertyProducer.ResolveStub();
		GetInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInvocation()
	{
	}
}
