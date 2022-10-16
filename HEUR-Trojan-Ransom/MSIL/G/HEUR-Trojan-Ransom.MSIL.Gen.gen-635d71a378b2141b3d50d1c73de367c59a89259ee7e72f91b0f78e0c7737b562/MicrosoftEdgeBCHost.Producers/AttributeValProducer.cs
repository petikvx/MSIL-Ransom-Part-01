using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AttributeValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AssetDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetDatabase()
	{
	}
}
