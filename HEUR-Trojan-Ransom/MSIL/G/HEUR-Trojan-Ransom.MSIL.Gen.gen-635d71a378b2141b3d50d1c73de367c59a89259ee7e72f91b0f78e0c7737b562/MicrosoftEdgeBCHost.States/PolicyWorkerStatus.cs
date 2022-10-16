using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PolicyWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralRules()
	{
	}
}
