using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CandidateRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateRules()
	{
		WriterPropertyProducer.ResolveStub();
		InsertListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertListener()
	{
	}
}
