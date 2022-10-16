using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DispatcherValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectOrder()
	{
	}
}
