using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RepositoryWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceDic()
	{
	}
}
