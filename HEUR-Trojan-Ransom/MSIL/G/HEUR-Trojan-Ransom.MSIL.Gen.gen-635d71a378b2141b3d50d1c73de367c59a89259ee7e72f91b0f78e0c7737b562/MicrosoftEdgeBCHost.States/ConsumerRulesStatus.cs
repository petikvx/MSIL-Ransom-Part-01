using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConsumerRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceState()
	{
	}
}
