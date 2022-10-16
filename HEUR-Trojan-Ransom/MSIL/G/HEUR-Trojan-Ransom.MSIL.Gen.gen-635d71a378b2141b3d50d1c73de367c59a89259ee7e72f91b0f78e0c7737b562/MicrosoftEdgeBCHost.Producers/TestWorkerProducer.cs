using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TestWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceMethod()
	{
	}
}
