using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContextAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralPool()
	{
	}
}
