using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InitializerFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerFilter()
	{
		WriterPropertyProducer.ResolveStub();
		SearchCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchCandidate()
	{
	}
}
