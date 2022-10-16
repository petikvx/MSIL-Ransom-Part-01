using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WatcherServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherServer()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralPublisher()
	{
	}
}
