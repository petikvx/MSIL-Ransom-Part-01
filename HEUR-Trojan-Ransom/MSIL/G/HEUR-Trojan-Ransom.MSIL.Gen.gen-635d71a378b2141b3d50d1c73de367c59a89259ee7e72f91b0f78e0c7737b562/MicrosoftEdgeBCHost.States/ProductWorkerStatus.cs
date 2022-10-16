using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProductWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralSpecification()
	{
	}
}
