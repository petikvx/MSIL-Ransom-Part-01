using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BridgeBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CheckRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckRole()
	{
	}
}
