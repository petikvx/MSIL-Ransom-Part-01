using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MerchantOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralInitializer()
	{
	}
}
