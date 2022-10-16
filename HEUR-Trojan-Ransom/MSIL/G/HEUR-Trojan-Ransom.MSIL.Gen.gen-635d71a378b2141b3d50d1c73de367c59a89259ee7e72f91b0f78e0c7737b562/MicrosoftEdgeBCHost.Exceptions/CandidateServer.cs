using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CandidateServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateServer()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralUtils()
	{
	}
}
