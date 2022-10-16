using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProccesorFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RateProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateProduct()
	{
	}
}
