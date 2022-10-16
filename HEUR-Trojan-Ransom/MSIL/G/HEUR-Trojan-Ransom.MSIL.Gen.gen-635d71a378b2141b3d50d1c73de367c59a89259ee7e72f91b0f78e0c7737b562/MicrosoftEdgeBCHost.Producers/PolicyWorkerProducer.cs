using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PolicyWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SetupHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupHelper()
	{
	}
}
