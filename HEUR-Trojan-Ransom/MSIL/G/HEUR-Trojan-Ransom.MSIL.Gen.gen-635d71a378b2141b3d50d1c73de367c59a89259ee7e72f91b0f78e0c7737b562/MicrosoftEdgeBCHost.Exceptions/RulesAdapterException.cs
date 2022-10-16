using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RulesAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceProduct()
	{
	}
}
