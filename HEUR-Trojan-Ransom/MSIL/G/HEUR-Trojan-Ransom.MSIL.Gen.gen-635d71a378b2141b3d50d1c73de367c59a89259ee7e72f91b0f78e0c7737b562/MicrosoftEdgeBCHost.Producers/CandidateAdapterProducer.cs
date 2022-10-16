using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CandidateAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralProduct()
	{
	}
}
