using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConnectionWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ResetReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetReponse()
	{
	}
}
