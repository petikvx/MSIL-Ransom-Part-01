using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ReaderFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SortClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortClient()
	{
	}
}
