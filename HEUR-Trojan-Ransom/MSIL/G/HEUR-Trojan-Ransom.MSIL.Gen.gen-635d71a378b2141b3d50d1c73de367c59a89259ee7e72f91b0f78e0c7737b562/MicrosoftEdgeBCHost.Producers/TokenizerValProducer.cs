using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TokenizerValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PrintOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintOrder()
	{
	}
}
