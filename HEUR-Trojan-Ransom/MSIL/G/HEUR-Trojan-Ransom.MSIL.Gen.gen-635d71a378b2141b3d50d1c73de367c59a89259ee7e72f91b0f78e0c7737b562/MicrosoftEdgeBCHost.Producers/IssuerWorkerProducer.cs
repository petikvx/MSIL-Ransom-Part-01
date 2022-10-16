using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IssuerWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceDic()
	{
	}
}
