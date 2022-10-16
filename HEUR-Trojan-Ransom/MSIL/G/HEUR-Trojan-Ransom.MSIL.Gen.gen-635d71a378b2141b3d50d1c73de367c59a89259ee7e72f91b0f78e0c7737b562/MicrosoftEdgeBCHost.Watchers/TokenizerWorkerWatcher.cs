using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TokenizerWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceReponse()
	{
	}
}
