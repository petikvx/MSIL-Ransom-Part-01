using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InterceptorWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
