using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MerchantFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceProducer()
	{
	}
}
