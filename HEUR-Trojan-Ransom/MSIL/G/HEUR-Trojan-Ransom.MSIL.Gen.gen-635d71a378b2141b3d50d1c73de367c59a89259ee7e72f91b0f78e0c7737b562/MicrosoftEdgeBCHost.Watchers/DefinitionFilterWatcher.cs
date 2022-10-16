using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DefinitionFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		GetProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetProducer()
	{
	}
}
