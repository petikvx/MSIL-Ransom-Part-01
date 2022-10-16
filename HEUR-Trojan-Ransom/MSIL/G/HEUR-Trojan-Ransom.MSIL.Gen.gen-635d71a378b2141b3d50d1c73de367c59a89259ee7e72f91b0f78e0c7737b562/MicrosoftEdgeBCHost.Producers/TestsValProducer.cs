using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TestsValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ReadRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadRepository()
	{
	}
}
