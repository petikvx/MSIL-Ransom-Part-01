using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MappingOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceItem()
	{
	}
}
