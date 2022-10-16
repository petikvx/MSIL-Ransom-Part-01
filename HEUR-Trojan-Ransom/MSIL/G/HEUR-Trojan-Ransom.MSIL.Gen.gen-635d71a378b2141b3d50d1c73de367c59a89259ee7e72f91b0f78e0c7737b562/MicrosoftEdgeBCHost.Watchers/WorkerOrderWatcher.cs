using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WorkerOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralExporter()
	{
	}
}
