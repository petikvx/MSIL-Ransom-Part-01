using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MappingRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceAccount()
	{
	}
}
