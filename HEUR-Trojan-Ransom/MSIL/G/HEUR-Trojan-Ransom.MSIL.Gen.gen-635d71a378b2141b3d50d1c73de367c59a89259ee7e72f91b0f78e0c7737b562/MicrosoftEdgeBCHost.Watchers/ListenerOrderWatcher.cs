using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ListenerOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralModel()
	{
	}
}
