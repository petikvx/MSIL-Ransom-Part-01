using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BridgeAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralThread()
	{
	}
}
