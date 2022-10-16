using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConsumerValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		TestSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestSchema()
	{
	}
}
