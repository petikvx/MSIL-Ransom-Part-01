using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SpecificationWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceCustomer()
	{
	}
}
