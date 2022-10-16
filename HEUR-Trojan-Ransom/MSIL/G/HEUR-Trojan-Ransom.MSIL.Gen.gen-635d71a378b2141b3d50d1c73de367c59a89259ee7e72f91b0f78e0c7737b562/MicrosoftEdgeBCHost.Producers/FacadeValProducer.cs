using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FacadeValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		OrderExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderExporter()
	{
	}
}
