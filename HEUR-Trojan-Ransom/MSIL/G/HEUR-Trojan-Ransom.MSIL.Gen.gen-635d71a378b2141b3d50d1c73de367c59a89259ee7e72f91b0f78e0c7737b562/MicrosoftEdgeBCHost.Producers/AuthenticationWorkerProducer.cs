using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AuthenticationWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectPool()
	{
	}
}
