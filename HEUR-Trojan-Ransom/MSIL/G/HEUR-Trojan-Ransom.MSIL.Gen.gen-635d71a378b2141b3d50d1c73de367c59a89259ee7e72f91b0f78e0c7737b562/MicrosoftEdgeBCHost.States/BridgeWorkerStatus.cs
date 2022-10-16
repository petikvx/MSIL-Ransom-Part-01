using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BridgeWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralStrategy()
	{
	}
}
