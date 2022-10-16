using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CandidatePolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidatePolicy()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceAdvisor()
	{
	}
}
