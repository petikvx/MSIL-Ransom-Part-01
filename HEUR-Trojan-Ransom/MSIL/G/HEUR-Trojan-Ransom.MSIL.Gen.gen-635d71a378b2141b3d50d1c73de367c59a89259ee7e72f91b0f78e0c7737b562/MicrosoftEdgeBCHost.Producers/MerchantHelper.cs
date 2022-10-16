using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MerchantHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantHelper()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
