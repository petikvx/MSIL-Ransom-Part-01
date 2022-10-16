using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WatcherBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateAuthentication()
	{
	}
}
