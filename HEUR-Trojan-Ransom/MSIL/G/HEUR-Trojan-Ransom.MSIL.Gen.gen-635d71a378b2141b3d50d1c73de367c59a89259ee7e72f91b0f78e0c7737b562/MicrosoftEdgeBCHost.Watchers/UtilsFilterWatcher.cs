using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class UtilsFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PushOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushOrder()
	{
	}
}
