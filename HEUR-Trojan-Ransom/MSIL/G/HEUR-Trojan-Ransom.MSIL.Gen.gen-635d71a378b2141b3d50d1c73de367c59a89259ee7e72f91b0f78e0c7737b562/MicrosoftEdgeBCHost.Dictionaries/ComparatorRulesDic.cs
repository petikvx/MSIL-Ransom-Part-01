using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ComparatorRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceParams()
	{
	}
}
