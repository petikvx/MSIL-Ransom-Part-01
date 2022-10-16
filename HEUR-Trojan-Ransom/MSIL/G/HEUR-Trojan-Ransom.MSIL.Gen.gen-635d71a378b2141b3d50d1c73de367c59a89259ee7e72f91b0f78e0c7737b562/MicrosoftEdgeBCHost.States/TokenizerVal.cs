using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TokenizerVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerVal()
	{
		WriterPropertyProducer.ResolveStub();
		CountProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountProducer()
	{
	}
}
