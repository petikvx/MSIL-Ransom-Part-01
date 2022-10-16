using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DefinitionRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceComparator()
	{
	}
}
