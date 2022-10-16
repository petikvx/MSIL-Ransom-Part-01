using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ComparatorOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorOrder()
	{
		WriterPropertyProducer.ResolveStub();
		RateReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateReg()
	{
	}
}
