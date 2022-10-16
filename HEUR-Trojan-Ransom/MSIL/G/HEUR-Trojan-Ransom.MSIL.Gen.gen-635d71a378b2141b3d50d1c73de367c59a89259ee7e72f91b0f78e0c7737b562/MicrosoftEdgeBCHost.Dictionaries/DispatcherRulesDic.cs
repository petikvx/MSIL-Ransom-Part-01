using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DispatcherRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceExpression()
	{
	}
}
