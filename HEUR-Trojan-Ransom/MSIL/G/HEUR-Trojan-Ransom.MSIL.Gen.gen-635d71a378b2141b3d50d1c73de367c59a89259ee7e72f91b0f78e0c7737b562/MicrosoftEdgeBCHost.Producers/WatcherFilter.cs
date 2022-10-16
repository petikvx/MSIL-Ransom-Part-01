using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WatcherFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherFilter()
	{
		WriterPropertyProducer.ResolveStub();
		TestCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestCandidate()
	{
	}
}
