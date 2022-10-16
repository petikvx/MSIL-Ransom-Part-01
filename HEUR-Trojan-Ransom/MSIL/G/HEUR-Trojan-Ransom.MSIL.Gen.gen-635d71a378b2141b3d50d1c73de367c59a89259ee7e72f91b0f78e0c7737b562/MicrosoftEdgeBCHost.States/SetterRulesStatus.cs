using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SetterRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceBroadcaster()
	{
	}
}
