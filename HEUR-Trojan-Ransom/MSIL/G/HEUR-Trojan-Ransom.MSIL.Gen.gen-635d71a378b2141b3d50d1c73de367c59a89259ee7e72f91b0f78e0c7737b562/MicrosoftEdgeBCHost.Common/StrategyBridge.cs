using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StrategyBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyBridge()
	{
		WriterPropertyProducer.ResolveStub();
		DisableException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableException()
	{
	}
}
