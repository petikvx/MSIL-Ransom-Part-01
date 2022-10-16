using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExporterOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralAdvisor()
	{
	}
}
