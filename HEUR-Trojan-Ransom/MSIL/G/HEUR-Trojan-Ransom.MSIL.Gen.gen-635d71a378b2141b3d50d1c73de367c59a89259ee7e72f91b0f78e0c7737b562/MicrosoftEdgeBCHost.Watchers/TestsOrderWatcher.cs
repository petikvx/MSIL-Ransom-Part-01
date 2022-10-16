using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestsOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralSystem()
	{
	}
}
