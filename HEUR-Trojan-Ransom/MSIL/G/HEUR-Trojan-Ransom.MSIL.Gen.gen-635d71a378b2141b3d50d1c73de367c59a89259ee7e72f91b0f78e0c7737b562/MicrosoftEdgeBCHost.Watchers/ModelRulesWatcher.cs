using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ModelRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CollectMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectMapper()
	{
	}
}
