using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PoolOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ListMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListMerchant()
	{
	}
}
