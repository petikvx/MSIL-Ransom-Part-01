using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContextFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SearchSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchSchema()
	{
	}
}
