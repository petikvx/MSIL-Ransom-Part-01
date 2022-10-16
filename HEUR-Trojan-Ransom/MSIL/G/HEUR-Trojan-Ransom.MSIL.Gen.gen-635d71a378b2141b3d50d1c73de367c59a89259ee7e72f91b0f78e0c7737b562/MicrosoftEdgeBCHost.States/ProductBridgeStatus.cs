using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProductBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RestartMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartMessage()
	{
	}
}
