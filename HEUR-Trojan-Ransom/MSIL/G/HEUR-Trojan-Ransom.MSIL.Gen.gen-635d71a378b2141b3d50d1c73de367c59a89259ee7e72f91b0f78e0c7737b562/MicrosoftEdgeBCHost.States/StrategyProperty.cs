using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StrategyProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceTest()
	{
	}
}
