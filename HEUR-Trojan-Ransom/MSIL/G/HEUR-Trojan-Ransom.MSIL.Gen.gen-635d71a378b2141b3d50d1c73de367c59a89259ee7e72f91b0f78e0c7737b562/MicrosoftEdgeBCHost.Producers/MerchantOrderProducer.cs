using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MerchantOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceMock()
	{
	}
}
