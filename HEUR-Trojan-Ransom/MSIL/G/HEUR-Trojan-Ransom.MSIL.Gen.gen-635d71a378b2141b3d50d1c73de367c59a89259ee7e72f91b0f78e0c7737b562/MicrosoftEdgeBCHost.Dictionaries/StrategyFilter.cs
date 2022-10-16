using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StrategyFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CreateFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateFacade()
	{
	}
}
