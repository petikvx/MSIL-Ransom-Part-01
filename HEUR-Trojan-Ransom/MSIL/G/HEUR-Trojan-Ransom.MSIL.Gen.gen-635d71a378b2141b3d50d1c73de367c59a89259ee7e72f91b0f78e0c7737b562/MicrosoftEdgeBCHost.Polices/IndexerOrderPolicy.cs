using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IndexerOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralInstance()
	{
	}
}
