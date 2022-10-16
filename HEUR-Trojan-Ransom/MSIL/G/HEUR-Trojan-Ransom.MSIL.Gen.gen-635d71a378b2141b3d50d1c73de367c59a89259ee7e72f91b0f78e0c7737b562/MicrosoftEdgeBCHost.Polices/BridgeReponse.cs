using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BridgeReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeReponse()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceBase()
	{
	}
}
