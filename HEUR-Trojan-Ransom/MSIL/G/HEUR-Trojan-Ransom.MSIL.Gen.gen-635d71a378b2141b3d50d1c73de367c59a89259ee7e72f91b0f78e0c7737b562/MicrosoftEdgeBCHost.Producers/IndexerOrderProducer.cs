using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IndexerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfacePredicate()
	{
	}
}
