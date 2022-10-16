using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterceptorHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorHelper()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
