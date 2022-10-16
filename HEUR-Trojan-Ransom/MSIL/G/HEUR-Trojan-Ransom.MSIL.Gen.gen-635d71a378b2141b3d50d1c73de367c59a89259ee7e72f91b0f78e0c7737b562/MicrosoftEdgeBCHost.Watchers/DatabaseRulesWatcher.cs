using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DatabaseRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AddIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddIndexer()
	{
	}
}
