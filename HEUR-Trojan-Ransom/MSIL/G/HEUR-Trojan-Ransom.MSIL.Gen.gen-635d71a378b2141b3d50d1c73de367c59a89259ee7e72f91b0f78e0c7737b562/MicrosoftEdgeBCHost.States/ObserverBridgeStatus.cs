using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ObserverBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterMock()
	{
	}
}
