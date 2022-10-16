using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CollectionPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralSerializer()
	{
	}
}
