using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ObserverOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceCreator()
	{
	}
}
