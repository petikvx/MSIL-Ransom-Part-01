using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AttrFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateFacade()
	{
	}
}
