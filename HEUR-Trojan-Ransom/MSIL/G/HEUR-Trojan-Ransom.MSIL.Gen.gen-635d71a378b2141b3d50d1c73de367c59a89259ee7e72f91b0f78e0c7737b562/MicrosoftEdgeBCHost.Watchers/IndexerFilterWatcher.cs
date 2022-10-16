using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IndexerFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AddSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddSingleton()
	{
	}
}
