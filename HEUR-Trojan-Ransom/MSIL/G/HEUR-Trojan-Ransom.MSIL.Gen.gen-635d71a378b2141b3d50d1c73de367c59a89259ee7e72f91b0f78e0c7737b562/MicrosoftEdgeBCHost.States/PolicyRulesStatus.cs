using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PolicyRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SearchPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchPolicy()
	{
	}
}
