using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BridgeWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CallAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallAccount()
	{
	}
}
