using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StateWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
