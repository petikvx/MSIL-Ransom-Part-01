using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PrinterAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralProduct()
	{
	}
}
