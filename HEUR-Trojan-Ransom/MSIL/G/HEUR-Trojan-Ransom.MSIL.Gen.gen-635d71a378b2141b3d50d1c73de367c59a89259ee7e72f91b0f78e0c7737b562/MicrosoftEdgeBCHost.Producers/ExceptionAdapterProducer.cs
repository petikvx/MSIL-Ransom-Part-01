using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExceptionAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
