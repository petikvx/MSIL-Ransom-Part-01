using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConnectionBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RunException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunException()
	{
	}
}
