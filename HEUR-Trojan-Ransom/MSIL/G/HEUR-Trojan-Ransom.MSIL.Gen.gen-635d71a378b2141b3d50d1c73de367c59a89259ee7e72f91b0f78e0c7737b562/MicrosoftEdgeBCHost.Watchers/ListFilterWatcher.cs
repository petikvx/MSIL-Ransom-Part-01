using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ListFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RestartHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartHelper()
	{
	}
}
