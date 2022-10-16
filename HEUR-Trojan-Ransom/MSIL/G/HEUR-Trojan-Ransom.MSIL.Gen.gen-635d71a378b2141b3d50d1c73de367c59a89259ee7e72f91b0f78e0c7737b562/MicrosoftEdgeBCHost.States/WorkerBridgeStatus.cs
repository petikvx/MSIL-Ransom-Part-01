using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WorkerBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		StartParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartParser()
	{
	}
}
