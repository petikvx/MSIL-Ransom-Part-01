using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CandidateValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceTemplate()
	{
	}
}
