using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TestOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceMock()
	{
	}
}
