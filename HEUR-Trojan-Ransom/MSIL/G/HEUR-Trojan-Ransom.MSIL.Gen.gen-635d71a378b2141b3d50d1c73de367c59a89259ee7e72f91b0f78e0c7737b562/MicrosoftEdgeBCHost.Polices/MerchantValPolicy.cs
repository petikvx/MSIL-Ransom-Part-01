using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MerchantValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AssetWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetWriter()
	{
	}
}
