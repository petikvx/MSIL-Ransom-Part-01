using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ModelAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralTag()
	{
	}
}
