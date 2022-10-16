using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class OrderAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralMapping()
	{
	}
}
