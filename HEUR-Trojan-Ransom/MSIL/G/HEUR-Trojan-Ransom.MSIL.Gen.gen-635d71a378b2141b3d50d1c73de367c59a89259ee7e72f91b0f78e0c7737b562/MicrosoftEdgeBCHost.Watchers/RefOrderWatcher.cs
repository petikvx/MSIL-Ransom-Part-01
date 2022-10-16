using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RefOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
