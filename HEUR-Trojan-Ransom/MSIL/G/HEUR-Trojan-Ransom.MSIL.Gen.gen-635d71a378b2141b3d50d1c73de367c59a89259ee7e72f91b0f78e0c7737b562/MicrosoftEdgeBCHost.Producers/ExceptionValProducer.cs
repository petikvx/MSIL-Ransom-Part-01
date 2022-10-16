using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExceptionValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
