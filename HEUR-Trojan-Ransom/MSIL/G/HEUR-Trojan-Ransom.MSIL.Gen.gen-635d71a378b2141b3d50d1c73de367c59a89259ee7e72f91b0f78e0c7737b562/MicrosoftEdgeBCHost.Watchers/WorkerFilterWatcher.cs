using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WorkerFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FindContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindContext()
	{
	}
}
