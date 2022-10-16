using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SpecificationAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceInstance()
	{
	}
}
