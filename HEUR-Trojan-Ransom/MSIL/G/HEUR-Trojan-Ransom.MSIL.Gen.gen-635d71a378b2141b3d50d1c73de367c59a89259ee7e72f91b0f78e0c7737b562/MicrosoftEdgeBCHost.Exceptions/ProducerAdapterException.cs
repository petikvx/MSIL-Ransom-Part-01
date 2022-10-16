using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProducerAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceItem()
	{
	}
}
