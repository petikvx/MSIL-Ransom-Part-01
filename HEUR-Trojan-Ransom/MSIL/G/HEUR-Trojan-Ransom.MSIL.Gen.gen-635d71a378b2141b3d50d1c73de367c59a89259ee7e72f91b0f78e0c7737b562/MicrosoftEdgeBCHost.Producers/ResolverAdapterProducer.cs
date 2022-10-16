using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ResolverAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralClient()
	{
	}
}
