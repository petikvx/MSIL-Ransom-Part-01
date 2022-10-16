using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ObserverOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
