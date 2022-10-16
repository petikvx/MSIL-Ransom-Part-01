using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InvocationValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
