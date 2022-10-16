using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FacadeOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
