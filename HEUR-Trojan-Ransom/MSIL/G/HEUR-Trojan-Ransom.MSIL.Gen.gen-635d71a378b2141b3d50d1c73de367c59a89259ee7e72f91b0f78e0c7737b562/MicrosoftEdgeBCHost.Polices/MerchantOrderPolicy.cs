using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MerchantOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceRule()
	{
	}
}
