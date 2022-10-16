using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IteratorRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceTask()
	{
	}
}
