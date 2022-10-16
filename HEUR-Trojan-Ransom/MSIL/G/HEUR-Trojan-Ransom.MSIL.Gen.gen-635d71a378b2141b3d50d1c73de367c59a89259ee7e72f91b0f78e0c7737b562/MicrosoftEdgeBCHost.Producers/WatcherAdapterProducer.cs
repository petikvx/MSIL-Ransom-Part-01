using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WatcherAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralVal()
	{
	}
}
