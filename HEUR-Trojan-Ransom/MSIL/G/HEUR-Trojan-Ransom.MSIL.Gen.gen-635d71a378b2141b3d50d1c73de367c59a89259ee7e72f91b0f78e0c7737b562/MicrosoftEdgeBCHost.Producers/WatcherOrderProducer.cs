using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WatcherOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceToken()
	{
	}
}
