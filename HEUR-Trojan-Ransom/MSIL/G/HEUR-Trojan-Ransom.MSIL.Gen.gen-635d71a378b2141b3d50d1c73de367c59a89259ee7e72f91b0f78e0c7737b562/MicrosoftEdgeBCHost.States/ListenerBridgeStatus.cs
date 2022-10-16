using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ListenerBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CallModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallModel()
	{
	}
}
