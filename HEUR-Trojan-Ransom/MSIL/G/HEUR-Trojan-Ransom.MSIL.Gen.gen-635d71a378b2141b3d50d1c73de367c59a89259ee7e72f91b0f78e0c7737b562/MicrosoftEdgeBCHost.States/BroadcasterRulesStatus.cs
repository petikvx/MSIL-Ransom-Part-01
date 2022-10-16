using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BroadcasterRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceEvent()
	{
	}
}
