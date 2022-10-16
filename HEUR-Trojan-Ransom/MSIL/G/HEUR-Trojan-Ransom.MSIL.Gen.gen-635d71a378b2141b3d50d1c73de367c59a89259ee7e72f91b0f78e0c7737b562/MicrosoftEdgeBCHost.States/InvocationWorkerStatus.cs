using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InvocationWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralClass()
	{
	}
}
