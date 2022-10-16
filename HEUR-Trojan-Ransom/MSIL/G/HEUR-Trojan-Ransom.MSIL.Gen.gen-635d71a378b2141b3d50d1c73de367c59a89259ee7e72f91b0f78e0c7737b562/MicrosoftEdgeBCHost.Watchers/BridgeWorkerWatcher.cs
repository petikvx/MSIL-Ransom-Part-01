using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BridgeWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceClient()
	{
	}
}
