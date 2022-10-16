using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProducerBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MoveRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveRules()
	{
	}
}
