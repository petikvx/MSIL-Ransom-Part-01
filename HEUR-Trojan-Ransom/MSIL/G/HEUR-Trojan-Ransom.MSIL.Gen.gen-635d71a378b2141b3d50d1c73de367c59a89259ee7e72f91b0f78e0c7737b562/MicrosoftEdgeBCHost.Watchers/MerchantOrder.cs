using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MerchantOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantOrder()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveReg()
	{
	}
}
