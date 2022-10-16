using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BaseBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SearchProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchProduct()
	{
	}
}
