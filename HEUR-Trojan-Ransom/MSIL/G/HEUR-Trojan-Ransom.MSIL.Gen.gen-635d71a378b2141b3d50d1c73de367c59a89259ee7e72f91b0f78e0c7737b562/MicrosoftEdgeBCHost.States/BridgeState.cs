using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BridgeState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeState()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceStatus()
	{
	}
}
