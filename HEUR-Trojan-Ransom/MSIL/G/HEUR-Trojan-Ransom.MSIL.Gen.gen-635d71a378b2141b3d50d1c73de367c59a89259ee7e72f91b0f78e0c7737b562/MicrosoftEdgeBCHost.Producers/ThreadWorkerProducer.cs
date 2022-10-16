using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ThreadWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceMapping()
	{
	}
}
