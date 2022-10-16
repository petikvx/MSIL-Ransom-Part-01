using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PageFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RestartClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartClass()
	{
	}
}
