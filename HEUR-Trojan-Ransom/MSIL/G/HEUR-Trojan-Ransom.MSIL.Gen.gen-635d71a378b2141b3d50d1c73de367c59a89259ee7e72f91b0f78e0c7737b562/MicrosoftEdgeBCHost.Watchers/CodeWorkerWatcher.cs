using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CodeWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceObserver()
	{
	}
}
