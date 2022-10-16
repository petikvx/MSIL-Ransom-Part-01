using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TokenizerAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
