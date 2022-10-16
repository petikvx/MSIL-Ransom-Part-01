using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConfigRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceDecorator()
	{
	}
}
