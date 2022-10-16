using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListenerWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceIssuer()
	{
	}
}
