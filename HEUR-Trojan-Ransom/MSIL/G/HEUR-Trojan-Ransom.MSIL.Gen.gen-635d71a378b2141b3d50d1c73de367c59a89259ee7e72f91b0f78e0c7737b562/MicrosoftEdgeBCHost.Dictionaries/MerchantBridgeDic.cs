using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MerchantBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		EnableHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableHelper()
	{
	}
}
