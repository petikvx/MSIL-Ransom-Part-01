using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PredicateFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateFilter()
	{
		WriterPropertyProducer.ResolveStub();
		InitWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitWatcher()
	{
	}
}
