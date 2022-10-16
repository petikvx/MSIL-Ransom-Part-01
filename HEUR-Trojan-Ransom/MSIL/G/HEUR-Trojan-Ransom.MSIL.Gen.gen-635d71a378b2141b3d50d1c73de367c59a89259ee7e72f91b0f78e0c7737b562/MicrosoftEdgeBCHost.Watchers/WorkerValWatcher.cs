using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WorkerValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceError()
	{
	}
}
