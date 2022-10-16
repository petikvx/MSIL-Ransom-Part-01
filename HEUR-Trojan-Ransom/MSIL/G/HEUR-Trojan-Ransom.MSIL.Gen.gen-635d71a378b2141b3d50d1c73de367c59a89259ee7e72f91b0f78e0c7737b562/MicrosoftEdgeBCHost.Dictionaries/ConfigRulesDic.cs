using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConfigRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceConfig()
	{
	}
}
