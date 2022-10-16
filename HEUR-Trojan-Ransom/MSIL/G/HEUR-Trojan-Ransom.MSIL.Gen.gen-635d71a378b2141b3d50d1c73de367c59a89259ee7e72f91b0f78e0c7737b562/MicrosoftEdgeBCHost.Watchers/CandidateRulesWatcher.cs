using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CandidateRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ViewTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewTests()
	{
	}
}
