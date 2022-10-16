using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ValueWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceObject()
	{
	}
}
