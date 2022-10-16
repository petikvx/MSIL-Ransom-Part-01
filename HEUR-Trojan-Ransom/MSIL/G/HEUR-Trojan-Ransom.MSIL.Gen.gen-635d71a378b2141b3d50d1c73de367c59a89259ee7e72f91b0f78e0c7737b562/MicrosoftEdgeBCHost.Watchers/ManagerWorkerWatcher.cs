using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ManagerWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralBridge()
	{
	}
}
