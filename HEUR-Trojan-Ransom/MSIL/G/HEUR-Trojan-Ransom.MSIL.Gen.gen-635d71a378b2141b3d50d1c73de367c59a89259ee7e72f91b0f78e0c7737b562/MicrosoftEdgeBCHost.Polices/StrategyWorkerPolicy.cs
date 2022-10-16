using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StrategyWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceTask()
	{
	}
}
