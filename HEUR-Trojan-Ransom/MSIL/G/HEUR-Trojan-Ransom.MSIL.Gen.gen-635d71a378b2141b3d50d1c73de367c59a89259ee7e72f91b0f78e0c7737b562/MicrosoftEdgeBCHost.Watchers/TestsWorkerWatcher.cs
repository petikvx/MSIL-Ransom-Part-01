using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestsWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralService()
	{
	}
}
