using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ReaderFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeProduct()
	{
	}
}
