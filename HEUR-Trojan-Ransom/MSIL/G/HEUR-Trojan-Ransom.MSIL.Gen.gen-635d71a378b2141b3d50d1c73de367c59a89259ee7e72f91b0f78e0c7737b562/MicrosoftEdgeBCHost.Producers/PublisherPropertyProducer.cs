using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PublisherPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralPolicy()
	{
	}
}
