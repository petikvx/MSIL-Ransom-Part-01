using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DecoratorOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorOrder()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateMerchant()
	{
	}
}
