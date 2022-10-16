using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RequestWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralAdvisor()
	{
	}
}
