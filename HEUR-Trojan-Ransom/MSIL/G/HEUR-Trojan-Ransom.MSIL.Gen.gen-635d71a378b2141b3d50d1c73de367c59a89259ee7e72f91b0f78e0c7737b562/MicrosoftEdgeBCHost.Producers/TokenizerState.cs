using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TokenizerState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerState()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
