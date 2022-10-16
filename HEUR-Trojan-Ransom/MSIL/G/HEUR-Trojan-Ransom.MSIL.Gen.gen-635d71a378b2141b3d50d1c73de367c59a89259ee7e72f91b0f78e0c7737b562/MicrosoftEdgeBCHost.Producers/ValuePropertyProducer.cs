using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ValuePropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValuePropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralConsumer()
	{
	}
}
