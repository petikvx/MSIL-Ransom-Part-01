using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AttributeRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceReponse()
	{
	}
}
