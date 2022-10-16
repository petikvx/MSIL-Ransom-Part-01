using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MockWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralValue()
	{
	}
}
