using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BridgeAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralGetter()
	{
	}
}
