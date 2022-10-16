using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConfigurationRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceResolver()
	{
	}
}
