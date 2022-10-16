using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CandidateFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteAuthentication()
	{
	}
}
