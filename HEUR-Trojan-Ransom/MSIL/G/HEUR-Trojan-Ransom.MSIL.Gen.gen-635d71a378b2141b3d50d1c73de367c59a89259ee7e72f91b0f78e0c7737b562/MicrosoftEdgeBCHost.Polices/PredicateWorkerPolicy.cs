using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PredicateWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceAccount()
	{
	}
}
