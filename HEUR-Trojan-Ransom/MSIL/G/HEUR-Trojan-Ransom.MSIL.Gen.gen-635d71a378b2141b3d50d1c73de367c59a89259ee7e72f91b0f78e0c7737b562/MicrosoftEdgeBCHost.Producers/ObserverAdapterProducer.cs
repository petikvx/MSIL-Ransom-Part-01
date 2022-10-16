using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ObserverAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralDispatcher()
	{
	}
}
