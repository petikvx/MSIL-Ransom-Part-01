using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MockWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceSetter()
	{
	}
}
