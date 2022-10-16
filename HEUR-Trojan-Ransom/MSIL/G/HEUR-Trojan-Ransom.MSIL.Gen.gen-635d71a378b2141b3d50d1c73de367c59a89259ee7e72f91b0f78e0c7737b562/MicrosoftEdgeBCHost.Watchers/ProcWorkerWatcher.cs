using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProcWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralMap()
	{
	}
}
