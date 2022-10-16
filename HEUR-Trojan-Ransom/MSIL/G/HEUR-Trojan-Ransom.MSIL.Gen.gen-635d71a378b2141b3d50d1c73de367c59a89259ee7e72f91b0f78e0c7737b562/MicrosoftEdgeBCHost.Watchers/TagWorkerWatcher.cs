using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TagWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralIssuer()
	{
	}
}
