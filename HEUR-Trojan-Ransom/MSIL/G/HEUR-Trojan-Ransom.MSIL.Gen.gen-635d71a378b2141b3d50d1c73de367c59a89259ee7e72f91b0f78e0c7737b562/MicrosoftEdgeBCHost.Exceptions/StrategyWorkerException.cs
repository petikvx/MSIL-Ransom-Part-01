using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StrategyWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		DisableCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableCallback()
	{
	}
}
