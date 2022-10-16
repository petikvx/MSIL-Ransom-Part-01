using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProductOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceTemplate()
	{
	}
}
