using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InterpreterBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeSystem()
	{
	}
}
