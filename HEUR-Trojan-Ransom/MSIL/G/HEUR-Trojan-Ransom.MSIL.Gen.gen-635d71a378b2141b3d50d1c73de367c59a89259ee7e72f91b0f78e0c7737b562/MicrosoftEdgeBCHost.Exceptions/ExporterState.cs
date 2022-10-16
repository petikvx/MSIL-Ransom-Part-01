using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExporterState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterState()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceOrder()
	{
	}
}
