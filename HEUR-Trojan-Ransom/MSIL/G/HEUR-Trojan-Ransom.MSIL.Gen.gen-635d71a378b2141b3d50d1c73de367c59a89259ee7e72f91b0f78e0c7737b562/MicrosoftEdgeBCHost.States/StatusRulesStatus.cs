using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StatusRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceEvent()
	{
	}
}
