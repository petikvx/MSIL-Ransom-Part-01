using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MerchantContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MerchantContext()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfacePredicate()
	{
	}
}
