using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StateRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeObserver()
	{
	}
}
