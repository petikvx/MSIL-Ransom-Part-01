using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StrategyWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralSingleton()
	{
	}
}
