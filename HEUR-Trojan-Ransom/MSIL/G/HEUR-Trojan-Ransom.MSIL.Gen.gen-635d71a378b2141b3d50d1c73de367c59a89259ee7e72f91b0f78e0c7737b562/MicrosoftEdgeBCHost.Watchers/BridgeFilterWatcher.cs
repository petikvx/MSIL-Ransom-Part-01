using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BridgeFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateProperty()
	{
	}
}
