using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DispatcherServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherServer()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralPublisher()
	{
	}
}
