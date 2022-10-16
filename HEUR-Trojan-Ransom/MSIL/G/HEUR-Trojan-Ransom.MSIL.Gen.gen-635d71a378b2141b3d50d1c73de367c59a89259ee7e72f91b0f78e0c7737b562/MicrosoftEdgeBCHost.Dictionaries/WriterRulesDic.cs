using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WriterRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceConfig()
	{
	}
}
