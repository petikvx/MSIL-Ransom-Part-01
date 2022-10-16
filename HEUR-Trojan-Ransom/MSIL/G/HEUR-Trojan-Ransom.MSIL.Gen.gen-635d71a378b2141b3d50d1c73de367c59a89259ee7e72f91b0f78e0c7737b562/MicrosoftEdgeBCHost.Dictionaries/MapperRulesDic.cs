using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MapperRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceSerializer()
	{
	}
}
