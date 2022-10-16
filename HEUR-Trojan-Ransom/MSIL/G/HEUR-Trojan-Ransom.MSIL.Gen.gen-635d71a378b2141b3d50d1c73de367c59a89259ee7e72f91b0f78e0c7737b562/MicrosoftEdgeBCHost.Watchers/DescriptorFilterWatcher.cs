using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DescriptorFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
