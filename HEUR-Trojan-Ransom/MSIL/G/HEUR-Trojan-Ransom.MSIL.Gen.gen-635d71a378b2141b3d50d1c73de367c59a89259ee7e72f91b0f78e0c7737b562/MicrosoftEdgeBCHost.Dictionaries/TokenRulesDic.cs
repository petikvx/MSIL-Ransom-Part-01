using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TokenRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceProduct()
	{
	}
}
