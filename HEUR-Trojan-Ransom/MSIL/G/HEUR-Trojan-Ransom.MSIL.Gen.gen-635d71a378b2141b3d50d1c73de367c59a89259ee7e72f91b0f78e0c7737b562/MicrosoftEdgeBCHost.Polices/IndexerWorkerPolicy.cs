using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IndexerWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfacePage()
	{
	}
}
