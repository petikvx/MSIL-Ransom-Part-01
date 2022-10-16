using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParamOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceProduct()
	{
	}
}
