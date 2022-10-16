using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FacadeRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceDispatcher()
	{
	}
}
