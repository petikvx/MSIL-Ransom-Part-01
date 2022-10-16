using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WatcherRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceRules()
	{
	}
}
