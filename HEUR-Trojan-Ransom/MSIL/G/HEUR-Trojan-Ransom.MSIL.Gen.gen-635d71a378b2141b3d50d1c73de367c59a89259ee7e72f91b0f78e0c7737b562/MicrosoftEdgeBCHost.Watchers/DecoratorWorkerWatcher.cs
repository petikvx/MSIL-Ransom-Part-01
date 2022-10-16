using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DecoratorWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
