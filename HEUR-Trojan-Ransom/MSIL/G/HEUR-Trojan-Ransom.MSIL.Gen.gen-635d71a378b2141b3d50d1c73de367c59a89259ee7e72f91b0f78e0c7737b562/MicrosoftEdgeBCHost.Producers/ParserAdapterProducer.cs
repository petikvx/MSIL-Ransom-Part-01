using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParserAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
