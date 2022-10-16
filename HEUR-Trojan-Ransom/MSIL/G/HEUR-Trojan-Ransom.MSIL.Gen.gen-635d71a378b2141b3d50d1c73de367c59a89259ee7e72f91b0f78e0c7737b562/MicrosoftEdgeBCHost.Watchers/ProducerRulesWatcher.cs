using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProducerRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
