using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TestsWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceVal()
	{
	}
}
