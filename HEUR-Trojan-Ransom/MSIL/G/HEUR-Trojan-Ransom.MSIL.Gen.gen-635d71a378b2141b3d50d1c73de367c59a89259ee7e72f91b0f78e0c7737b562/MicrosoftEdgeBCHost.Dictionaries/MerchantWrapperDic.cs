using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MerchantWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		DisableAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableAdapter()
	{
	}
}
