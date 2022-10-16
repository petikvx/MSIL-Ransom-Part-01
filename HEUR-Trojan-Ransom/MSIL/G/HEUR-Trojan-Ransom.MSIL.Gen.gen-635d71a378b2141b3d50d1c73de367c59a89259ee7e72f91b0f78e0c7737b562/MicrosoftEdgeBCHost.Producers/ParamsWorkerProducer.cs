using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParamsWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceConnection()
	{
	}
}
