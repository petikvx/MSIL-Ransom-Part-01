using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TestsOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralFactory()
	{
	}
}
