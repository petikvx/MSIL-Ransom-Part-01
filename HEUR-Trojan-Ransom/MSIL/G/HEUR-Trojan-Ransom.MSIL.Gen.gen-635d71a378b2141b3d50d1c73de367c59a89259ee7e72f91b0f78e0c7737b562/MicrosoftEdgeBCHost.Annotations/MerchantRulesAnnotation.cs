using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MerchantRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CallFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallFacade()
	{
	}
}
