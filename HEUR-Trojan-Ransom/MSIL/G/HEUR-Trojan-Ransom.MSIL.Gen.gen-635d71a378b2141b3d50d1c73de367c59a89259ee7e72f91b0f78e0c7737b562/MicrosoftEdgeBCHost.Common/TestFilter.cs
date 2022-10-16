using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TestFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateProduct()
	{
	}
}
