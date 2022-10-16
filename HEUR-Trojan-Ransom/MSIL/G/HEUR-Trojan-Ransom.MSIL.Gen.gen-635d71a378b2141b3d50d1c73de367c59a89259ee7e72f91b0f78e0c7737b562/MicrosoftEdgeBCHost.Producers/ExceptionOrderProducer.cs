using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExceptionOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
