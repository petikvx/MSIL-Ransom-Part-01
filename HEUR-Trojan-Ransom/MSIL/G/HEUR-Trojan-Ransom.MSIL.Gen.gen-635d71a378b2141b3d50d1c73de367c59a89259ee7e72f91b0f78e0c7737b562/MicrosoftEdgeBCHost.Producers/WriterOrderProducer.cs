using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WriterOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfacePublisher()
	{
	}
}
