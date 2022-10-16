using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ErrorPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
