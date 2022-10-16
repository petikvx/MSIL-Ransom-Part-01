using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BroadcasterFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectAdapter()
	{
	}
}
