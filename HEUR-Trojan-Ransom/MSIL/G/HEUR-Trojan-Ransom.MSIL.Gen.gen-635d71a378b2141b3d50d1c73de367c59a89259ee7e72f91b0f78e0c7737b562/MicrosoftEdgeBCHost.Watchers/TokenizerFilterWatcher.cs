using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TokenizerFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeTask()
	{
	}
}
