using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StrategyWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeWriter()
	{
	}
}
