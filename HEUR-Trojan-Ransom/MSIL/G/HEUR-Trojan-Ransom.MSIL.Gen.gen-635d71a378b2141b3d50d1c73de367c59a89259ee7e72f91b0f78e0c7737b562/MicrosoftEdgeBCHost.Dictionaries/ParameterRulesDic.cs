using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParameterRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceSystem()
	{
	}
}
