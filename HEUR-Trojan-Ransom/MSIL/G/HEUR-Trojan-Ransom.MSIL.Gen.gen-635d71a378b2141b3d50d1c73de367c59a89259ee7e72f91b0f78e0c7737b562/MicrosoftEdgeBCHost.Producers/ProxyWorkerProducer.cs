using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProxyWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyObserver()
	{
	}
}
