using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListenerAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
