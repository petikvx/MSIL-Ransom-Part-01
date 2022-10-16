using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ListenerRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ListMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListMapping()
	{
	}
}
