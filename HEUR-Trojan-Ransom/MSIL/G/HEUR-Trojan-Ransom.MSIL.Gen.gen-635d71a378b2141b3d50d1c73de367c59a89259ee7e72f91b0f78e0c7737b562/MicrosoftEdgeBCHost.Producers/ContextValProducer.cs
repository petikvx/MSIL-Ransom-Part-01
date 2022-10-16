using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ContextValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RunTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunTest()
	{
	}
}
