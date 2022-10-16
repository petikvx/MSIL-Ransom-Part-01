using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SpecificationOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationOrder()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareRegistry()
	{
	}
}
