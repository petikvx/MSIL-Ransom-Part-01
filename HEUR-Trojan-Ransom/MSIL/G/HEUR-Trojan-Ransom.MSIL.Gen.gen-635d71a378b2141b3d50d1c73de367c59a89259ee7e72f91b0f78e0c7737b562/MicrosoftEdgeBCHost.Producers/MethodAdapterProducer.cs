using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MethodAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralPublisher()
	{
	}
}
