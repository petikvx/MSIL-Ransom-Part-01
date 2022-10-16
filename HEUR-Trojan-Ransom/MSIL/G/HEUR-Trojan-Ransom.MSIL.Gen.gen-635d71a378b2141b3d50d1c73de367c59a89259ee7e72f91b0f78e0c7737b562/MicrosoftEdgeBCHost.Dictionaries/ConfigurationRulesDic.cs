using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConfigurationRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceRepository()
	{
	}
}
