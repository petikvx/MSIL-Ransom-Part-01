using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParameterAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralPublisher()
	{
	}
}
