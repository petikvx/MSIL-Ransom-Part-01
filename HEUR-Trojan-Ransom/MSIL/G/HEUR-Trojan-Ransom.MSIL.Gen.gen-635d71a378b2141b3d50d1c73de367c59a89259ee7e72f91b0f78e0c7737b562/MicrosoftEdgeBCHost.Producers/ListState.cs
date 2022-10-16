using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListState()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
