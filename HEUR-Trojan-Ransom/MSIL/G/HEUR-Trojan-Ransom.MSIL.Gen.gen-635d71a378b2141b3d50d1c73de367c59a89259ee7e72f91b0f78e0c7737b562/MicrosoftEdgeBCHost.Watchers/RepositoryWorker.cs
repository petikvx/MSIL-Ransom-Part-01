using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RepositoryWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CheckHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckHelper()
	{
	}
}
