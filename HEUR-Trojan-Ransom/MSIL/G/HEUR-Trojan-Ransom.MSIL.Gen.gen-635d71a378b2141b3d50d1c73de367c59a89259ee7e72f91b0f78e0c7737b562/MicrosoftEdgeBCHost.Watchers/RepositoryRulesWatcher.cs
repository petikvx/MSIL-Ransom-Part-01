using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RepositoryRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeCollection()
	{
	}
}
