using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class HelperOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
