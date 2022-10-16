using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class GlobalFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CountListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountListener()
	{
	}
}
