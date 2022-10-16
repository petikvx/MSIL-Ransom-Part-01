using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListenerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceClient()
	{
	}
}
