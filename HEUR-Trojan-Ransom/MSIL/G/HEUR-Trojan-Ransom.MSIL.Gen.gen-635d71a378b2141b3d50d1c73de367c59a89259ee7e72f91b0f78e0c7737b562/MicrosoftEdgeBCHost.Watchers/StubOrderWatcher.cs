using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StubOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralMap()
	{
	}
}
