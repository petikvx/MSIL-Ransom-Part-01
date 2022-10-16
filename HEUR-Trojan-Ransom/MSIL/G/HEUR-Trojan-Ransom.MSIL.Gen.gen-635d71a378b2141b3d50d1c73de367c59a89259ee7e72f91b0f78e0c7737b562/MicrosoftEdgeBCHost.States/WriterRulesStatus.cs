using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WriterRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceAlgo()
	{
	}
}
