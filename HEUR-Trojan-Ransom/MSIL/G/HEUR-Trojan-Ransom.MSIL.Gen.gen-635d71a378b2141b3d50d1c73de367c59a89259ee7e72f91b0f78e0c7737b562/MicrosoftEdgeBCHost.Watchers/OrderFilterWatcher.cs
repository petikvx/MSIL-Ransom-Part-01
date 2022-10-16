using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class OrderFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptModel()
	{
	}
}
