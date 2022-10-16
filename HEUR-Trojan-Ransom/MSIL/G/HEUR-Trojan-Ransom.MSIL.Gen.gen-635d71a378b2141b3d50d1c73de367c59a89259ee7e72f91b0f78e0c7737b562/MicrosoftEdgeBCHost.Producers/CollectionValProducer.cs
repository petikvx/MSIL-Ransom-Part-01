using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CollectionValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareAttr()
	{
	}
}
