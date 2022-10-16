using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ErrorAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
