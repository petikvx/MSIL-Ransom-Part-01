using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TokenValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralParser()
	{
	}
}
