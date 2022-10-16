using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MerchantFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantFacade()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralItem()
	{
	}
}
