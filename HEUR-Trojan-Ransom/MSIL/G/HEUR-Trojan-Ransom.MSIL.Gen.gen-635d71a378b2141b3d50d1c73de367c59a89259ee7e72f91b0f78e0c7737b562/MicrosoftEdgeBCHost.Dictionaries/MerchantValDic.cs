using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MerchantValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralWatcher()
	{
	}
}
