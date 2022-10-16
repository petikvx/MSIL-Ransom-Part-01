using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RulesRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceMapper()
	{
	}
}
