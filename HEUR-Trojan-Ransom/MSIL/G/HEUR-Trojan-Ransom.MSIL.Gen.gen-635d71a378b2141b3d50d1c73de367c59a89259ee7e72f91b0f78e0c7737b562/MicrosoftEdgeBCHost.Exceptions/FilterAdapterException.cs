using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FilterAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceProduct()
	{
	}
}
