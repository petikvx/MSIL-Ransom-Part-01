using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RegFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegFacade()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralMerchant()
	{
	}
}
