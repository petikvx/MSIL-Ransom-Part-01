using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListenerPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralRule()
	{
	}
}
