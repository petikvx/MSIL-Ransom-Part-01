using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MerchantPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceReader()
	{
	}
}
