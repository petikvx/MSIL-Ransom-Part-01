using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RuleRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceSingleton()
	{
	}
}
