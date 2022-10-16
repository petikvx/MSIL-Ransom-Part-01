using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RepositoryWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralFactory()
	{
	}
}
