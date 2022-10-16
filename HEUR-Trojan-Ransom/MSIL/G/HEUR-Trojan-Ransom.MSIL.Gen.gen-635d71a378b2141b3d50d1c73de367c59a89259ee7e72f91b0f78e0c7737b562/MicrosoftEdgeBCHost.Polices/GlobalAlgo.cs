using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class GlobalAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralVal()
	{
	}
}
