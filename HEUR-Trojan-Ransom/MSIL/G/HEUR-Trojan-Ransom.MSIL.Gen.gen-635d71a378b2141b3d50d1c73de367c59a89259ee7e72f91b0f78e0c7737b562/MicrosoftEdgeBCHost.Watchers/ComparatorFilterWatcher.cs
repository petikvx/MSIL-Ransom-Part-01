using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ComparatorFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AssetRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetRules()
	{
	}
}
