using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RuleRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceAttr()
	{
	}
}
