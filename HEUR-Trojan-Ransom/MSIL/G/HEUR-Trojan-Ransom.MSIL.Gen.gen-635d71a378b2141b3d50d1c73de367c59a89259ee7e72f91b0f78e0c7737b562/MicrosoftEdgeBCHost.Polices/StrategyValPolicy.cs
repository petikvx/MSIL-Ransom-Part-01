using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StrategyValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceMapping()
	{
	}
}
