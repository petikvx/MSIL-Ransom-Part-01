using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IndexerServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerServer()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralRules()
	{
	}
}
