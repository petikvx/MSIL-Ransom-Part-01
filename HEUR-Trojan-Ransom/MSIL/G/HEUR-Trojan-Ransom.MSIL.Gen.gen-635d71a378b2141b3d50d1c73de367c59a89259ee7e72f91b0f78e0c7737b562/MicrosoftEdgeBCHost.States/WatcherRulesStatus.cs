using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WatcherRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CancelInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelInterfaceTest()
	{
	}
}
