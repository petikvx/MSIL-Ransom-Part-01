using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AccountBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MapMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapMock()
	{
	}
}
