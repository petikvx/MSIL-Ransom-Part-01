using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MessageWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		MapRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapRegistry()
	{
	}
}
