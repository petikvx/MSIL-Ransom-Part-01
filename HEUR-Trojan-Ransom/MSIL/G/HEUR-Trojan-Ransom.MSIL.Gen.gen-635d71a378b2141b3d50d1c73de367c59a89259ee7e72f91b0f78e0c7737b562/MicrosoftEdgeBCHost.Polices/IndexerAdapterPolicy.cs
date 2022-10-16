using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IndexerAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralClient()
	{
	}
}
