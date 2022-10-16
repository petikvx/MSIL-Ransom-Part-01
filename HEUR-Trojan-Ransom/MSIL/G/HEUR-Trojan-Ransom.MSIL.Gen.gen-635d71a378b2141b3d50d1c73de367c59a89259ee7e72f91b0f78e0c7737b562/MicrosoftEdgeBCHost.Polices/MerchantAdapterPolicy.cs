using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MerchantAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralConfig()
	{
	}
}
