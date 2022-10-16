using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ComposerWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralIssuer()
	{
	}
}
