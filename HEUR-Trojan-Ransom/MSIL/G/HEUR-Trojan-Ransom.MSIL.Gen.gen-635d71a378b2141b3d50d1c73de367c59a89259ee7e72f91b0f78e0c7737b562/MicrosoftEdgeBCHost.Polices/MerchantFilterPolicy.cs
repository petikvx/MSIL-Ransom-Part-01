using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MerchantFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StartRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartRef()
	{
	}
}
