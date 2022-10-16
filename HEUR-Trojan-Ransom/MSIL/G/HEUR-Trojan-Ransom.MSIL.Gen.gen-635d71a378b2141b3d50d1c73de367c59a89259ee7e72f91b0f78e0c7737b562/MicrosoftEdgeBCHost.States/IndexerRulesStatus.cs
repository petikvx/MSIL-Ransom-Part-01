using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IndexerRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceBridge()
	{
	}
}
