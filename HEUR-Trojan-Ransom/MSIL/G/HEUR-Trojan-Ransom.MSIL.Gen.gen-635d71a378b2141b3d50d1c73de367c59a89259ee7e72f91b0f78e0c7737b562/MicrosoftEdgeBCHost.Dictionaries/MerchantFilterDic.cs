using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MerchantFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralIssuer()
	{
	}
}
