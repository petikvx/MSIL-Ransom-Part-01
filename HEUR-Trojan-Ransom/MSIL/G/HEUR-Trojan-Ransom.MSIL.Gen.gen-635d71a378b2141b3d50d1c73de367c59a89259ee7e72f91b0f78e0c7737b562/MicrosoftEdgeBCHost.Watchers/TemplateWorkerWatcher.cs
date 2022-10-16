using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TemplateWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralImporter()
	{
	}
}
