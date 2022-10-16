using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TokenizerValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralQueue()
	{
	}
}
