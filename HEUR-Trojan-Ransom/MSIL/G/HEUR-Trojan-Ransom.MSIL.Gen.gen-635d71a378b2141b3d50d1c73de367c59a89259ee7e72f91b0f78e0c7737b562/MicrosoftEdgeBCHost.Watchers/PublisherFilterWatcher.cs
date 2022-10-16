using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PublisherFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		TestWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestWatcher()
	{
	}
}
