using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AdvisorRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
