using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InterpreterFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralWorker()
	{
	}
}
