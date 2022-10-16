using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PublisherFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherFilter()
	{
		WriterPropertyProducer.ResolveStub();
		DefineProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineProduct()
	{
	}
}
