using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IndexerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceExpression()
	{
	}
}
