using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AttrOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceProduct()
	{
	}
}
