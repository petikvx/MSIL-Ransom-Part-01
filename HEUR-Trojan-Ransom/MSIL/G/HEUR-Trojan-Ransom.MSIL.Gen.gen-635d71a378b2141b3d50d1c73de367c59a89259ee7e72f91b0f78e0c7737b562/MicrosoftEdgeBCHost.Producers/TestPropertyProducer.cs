using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TestPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralRegistry()
	{
	}
}
