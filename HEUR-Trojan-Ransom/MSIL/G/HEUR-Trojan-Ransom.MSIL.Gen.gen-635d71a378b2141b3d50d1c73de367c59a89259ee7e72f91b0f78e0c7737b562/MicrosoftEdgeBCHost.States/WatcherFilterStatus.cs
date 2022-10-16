using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WatcherFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceAccount()
	{
	}
}
