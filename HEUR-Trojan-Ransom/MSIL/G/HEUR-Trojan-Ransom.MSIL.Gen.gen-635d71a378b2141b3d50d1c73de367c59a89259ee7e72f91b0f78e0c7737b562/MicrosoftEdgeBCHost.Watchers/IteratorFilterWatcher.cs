using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IteratorFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PublishAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishAdvisor()
	{
	}
}
