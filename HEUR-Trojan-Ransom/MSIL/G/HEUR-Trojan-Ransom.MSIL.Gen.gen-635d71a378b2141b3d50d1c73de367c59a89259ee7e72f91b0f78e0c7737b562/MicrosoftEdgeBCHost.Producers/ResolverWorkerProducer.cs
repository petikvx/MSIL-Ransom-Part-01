using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ResolverWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceMapper()
	{
	}
}
