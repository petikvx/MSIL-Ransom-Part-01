using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProducerWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeTest()
	{
	}
}
