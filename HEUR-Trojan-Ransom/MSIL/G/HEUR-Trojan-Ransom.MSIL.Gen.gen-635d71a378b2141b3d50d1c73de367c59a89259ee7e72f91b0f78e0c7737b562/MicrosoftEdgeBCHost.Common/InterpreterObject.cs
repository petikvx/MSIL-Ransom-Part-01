using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InterpreterObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterObject()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralCandidate()
	{
	}
}
