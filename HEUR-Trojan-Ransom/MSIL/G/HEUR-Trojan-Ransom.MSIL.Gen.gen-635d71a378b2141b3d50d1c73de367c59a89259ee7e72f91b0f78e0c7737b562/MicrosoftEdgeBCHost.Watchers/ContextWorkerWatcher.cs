using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContextWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceUtils()
	{
	}
}
