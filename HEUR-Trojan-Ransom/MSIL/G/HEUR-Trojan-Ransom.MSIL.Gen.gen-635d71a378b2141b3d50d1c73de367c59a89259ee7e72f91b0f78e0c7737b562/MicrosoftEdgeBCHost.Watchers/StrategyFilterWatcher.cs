using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StrategyFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DefinePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefinePolicy()
	{
	}
}
