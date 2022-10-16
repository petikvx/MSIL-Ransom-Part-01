using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RuleWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceRules()
	{
	}
}
