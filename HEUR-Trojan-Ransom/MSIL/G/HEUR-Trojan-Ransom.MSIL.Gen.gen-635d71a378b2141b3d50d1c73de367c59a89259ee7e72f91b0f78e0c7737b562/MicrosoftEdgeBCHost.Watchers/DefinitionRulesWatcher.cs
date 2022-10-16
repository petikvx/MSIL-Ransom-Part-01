using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DefinitionRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CreateAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateAlgo()
	{
	}
}
