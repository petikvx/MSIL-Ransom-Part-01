using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MappingFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DisableProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableProduct()
	{
	}
}
