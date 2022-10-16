using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MapOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceStrategy()
	{
	}
}
