using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RefOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefOrder()
	{
		WriterPropertyProducer.ResolveStub();
		MapMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapMerchant()
	{
	}
}
