using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BridgeWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CallRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallRepository()
	{
	}
}
