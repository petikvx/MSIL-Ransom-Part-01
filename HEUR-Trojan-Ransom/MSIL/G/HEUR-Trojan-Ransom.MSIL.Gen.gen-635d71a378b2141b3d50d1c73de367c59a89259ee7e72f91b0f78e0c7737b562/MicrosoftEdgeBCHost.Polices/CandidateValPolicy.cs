using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CandidateValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceValue()
	{
	}
}
