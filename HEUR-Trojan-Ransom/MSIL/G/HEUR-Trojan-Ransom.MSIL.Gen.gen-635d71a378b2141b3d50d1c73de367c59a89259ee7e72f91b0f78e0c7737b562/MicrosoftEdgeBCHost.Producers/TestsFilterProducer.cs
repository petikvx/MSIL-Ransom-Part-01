using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TestsFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatAlgo()
	{
	}
}
