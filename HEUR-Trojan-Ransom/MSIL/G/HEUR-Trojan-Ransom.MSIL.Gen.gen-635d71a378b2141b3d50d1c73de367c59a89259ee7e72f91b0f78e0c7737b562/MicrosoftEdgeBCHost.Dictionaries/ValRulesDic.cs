using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ValRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceCollection()
	{
	}
}
