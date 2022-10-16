using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StrategyWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FlushMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushMapping()
	{
	}
}
