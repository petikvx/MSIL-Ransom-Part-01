using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PageRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageRules()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeSchema()
	{
	}
}
