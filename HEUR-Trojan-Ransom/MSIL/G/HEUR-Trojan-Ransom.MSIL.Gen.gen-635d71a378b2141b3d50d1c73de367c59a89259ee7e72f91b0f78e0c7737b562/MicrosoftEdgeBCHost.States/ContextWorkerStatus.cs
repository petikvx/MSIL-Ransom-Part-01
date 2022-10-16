using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ContextWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralRules()
	{
	}
}
