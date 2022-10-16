using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SpecificationRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceContainer()
	{
	}
}
