using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TokenValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceQueue()
	{
	}
}
