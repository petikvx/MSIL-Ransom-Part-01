using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StrategyWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		GetConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetConfig()
	{
	}
}
