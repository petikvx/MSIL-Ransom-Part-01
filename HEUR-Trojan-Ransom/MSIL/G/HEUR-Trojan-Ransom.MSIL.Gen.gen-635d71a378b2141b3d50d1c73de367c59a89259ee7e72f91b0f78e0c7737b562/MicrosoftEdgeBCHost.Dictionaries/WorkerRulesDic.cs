using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WorkerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceTests()
	{
	}
}
