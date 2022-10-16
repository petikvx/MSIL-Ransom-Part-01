using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InvocationAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
