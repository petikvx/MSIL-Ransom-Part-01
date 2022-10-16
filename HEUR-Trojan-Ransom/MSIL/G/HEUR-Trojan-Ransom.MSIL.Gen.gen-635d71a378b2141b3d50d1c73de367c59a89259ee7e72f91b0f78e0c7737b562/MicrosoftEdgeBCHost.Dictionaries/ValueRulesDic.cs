using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ValueRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceComparator()
	{
	}
}
