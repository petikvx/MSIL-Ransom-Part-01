using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ReaderOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceComparator()
	{
	}
}
