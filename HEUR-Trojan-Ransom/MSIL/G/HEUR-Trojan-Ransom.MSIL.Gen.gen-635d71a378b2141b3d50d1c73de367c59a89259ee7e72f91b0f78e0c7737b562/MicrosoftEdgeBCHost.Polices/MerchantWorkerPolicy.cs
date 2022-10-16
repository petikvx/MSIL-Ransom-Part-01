using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MerchantWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceDispatcher()
	{
	}
}
