using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TokenizerValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
