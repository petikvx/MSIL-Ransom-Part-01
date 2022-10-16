using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StrategyAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralProxy()
	{
	}
}
