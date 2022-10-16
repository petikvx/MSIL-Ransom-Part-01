using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ServerWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		EnableTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableTokenizer()
	{
	}
}
