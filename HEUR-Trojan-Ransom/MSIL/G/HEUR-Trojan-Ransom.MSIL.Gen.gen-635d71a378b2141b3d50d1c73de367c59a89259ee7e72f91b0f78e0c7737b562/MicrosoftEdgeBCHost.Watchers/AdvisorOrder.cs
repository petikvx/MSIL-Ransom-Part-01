using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AdvisorOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeRule()
	{
	}
}
