using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FilterRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfacePrototype()
	{
	}
}
