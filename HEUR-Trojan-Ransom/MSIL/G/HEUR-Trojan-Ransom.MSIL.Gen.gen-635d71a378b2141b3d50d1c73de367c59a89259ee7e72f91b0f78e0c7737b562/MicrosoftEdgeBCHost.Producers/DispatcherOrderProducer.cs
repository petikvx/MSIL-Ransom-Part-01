using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DispatcherOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceInterpreter()
	{
	}
}
