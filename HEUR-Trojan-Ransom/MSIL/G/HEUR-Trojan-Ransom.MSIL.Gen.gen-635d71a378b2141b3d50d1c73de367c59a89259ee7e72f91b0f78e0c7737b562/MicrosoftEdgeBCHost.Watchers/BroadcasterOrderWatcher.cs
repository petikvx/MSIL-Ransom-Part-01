using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BroadcasterOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralContext()
	{
	}
}
