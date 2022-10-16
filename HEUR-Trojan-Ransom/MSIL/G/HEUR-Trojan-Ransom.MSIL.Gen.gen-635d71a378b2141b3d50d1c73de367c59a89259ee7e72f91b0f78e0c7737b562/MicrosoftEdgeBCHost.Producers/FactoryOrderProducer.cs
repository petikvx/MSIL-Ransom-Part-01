using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FactoryOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceMock()
	{
	}
}
