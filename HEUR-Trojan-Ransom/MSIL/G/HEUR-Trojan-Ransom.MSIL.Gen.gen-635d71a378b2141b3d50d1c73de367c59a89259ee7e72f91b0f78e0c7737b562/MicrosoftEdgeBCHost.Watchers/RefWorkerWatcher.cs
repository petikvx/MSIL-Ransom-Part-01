using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RefWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralState()
	{
	}
}
