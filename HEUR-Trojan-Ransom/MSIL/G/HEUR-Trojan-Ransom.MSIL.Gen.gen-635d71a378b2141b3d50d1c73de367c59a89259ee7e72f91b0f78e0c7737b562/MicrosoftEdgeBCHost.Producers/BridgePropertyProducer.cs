using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BridgePropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgePropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralToken()
	{
	}
}
