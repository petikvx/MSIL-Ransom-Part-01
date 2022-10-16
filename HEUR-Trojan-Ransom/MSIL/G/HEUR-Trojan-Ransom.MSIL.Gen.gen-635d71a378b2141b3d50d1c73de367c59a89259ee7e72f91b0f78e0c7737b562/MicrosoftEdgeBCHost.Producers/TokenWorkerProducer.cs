using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TokenWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceObject()
	{
	}
}
