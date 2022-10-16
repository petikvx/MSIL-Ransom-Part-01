using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BroadcasterOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceFacade()
	{
	}
}
