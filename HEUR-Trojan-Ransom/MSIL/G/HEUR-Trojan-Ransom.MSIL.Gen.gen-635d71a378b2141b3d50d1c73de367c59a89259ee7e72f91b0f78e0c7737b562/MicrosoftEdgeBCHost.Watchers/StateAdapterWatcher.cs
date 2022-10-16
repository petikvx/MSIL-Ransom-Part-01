using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StateAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralTokenizer()
	{
	}
}
