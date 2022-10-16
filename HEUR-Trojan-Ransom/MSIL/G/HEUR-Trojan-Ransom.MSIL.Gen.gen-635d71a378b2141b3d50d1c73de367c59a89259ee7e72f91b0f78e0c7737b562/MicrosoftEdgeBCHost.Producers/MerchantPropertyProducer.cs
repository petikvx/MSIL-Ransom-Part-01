using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MerchantPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
