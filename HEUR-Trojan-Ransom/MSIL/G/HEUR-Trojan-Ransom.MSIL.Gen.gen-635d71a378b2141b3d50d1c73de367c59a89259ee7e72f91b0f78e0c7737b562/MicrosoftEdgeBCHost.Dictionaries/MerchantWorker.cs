using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MerchantWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveAccount()
	{
	}
}
