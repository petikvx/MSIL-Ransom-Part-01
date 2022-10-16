using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ItemAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralContainer()
	{
	}
}
