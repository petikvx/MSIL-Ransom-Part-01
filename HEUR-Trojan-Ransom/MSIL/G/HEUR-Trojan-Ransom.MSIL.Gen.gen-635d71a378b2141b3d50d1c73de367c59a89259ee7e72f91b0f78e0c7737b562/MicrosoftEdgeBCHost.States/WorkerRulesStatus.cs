using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WorkerRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		StopPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopPool()
	{
	}
}
