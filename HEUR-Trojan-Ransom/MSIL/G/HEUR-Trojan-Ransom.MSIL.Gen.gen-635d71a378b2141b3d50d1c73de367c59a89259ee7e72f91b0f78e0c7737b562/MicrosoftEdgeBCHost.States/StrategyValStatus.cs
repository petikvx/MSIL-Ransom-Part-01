using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StrategyValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralParameter()
	{
	}
}
