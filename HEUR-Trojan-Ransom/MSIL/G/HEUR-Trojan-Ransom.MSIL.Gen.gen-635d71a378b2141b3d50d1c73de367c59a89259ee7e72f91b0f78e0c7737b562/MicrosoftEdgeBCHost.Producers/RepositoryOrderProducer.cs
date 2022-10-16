using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RepositoryOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfacePool()
	{
	}
}
