using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamsRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceProduct()
	{
	}
}
