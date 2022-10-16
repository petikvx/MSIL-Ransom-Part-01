using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IdentifierState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierState()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
