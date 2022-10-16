using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MessageAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
