using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StateFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareOrder()
	{
	}
}
