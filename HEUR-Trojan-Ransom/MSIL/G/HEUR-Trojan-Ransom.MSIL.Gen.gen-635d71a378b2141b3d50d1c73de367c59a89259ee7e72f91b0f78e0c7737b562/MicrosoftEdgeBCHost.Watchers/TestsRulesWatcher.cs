using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestsRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		QueryConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryConfiguration()
	{
	}
}
